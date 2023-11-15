import Cookies from 'js-cookie';
import type { PageLoad } from './$types';
import { z } from 'zod';
import { base } from '$app/paths';
import type { CourseDto } from '../../../../schemas/CourseDto';
import { ExamDtoSchema, type ExamDto } from '../../../../schemas/ExamDto';

export const load = (async ({ fetch }) => {
	const token = Cookies.get('oktato-token');

	let taughtExams: ExamDto = [];
	let exams: ExamDto = [];

	try {
		const taughtExamsResult = await fetch(base + '/api/exams?teachedByMe=true', {
			method: 'GET',
			headers: {
				Authorization: `Bearer ${token}`,
				'Content-Type': 'application/json'
			}
		});

		const taughtExamsResponse = await taughtExamsResult.json();
		taughtExams = await ExamDtoSchema.parseAsync(taughtExamsResponse);
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
			// filter exams taught by me
			.filter(
				(exam) =>
					!taughtExams.some(
						(taughtExam) =>
							taughtExam.courseCode === exam.courseCode &&
							taughtExam.courseSemester === exam.courseSemester &&
							taughtExam.start === exam.start
					)
			);
	} catch (error) {
		console.error('Teacher statistics failed!', error);
	}

	return {
		taughtExams,
		exams
	};
}) satisfies PageLoad;
