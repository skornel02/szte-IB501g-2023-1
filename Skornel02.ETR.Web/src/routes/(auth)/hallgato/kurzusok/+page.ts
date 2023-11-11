import Cookies from 'js-cookie';
import type { PageLoad } from '../../oktato/kurzusok/$types';
import { CourseDtoSchema, type CourseDto } from '../../../../schemas/CourseDto';
import { z } from 'zod';
import { base } from '$app/paths';

export const load = (async ({ fetch }) => {
	const token = Cookies.get('hallgato-token');

	let attendedCourses: CourseDto[] = [];
	let courses: CourseDto[] = [];

	try {
		const attendedCoursesResult = await fetch(base + '/api/courses?attendedByMe=true', {
			method: 'GET',
			headers: {
				Authorization: `Bearer ${token}`,
				'Content-Type': 'application/json'
			}
		});

		const attendedCoursesResponse = await attendedCoursesResult.json();
		attendedCourses = await z.array(CourseDtoSchema).parseAsync(attendedCoursesResponse);
	} catch (error) {
		console.error('Learning courses fetch failed!', error);
	}

	console.log({ attendedCourses });

	try {
		const coursesResult = await fetch(base + '/api/courses', {
			method: 'GET',
			headers: {
				Authorization: `Bearer ${token}`,
				'Content-Type': 'application/json'
			}
		});

		const coursesResponse = await coursesResult.json();
		courses = (await z.array(CourseDtoSchema).parseAsync(coursesResponse))
			// filter courses taught by me
			.filter(
				(course) =>
					!attendedCourses.some(
						(attendedCourses) =>
							attendedCourses.courseCode === course.courseCode &&
							attendedCourses.courseSemester === course.courseSemester
					)
			);
	} catch (error) {
		console.error('Courses fetch failed!', error);
	}

	return {
		attendedCourses,
		courses
	};
}) satisfies PageLoad;
