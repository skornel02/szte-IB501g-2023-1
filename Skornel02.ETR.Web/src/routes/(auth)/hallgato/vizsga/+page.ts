import Cookies from 'js-cookie';
import type { PageLoad } from './$types';
import { base } from '$app/paths';
import { CourseDtoSchema } from '../../../../schemas/CourseDto';
import { z } from 'zod';

export const load = (async ({ fetch }) => {
	const token = Cookies.get('hallgato-token');

	const coursesResult = await fetch(base + '/api/courses', {
		method: 'GET',
		headers: {
			Authorization: `Bearer ${token}`,
			'Content-Type': 'application/json'
		}
	});

	const coursesResponse = await coursesResult.json();
	const courses = await z.array(CourseDtoSchema).parseAsync(coursesResponse);

	return {
		courses
	};
}) satisfies PageLoad;
