import Cookies from 'js-cookie';
import type { PageLoad } from './$types';
import { CourseDtoSchema, type CourseDto } from '../../../../schemas/CourseDto';
import { z } from 'zod';
import { base } from '$app/paths';

export const load = (async ({ fetch }) => {
	const token = Cookies.get('oktato-token');

	let taughtCourses: CourseDto[] = [];
	let courses: CourseDto[] = [];

	try {
		const taughtCoursesResult = await fetch(base + '/api/courses?teachedByMe=true', {
			method: 'GET',
			headers: {
				Authorization: `Bearer ${token}`,
				'Content-Type': 'application/json'
			}
		});

		const taughtCoursesResponse = await taughtCoursesResult.json();
		taughtCourses = await z.array(CourseDtoSchema).parseAsync(taughtCoursesResponse);
	} catch (error) {
		console.error('Teacher statistics failed!', error);
	}

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
					!taughtCourses.some(
						(taughtCourse) =>
							taughtCourse.courseCode === course.courseCode &&
							taughtCourse.courseSemester === course.courseSemester
					)
			);
	} catch (error) {
		console.error('Teacher statistics failed!', error);
	}

	return {
		taughtCourses,
		courses
	};
}) satisfies PageLoad;
