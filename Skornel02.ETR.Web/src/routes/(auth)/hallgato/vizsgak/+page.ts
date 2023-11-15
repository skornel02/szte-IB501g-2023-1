import Cookies from 'js-cookie';
import type { PageLoad } from './$types';
import { z } from 'zod';
import { base } from '$app/paths';
import type { CourseDto } from '../../../../schemas/CourseDto';
import { ExamDtoSchema, type ExamDto } from '../../../../schemas/ExamDto';

export const load = (async ({ fetch }) => {
	const token = Cookies.get('hallgato-token');

	let attendedExams: ExamDto = [];
	let exams: ExamDto = [];

	try {
		const attendedExamsResult = await fetch(base + '/api/exams?attendedByMe=true', {
			method: 'GET',
			headers: {
				Authorization: `Bearer ${token}`,
				'Content-Type': 'application/json'
			}
		});

		const attendedExamsResponse = await attendedExamsResult.json();
		attendedExams = await ExamDtoSchema.parseAsync(attendedExamsResponse);
	} catch (error) {
		console.error('Teacher statistics failed!', error);
	}

	try {
		const coursesResult = await fetch(base + '/api/exams', {
			method: 'GET',
			headers: {
				Authorization: `Bearer ${token}`,
				'Content-Type': 'application/json'
			}
		});

		const coursesResponse = await coursesResult.json();
		exams = (await ExamDtoSchema.parseAsync(coursesResponse))
			// filter exams attended by me
			.filter(
				(exam) =>
					!attendedExams.some(
						(attendedExam) =>
							attendedExam.courseCode === exam.courseCode &&
							attendedExam.courseSemester === exam.courseSemester &&
							attendedExam.start === exam.start
					)
			);
	} catch (error) {
		console.error('Teacher statistics failed!', error);
	}

	return {
		attendedExams,
		exams
	};
}) satisfies PageLoad;
