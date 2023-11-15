import Cookies from 'js-cookie';
import type { PageLoad } from './$types';
import { ClassRoomDtoSchema } from '../../../../schemas/ClassRoomDto';
import { base } from '$app/paths';
import { error, fail } from '@sveltejs/kit';
import { CourseDtoSchema } from '../../../../schemas/CourseDto';
import { z } from 'zod';

export const load = (async ({ fetch }) => {
	const token = Cookies.get('oktato-token');

	const classRoomResult = await fetch(base + '/api/classrooms', {
		method: 'GET',
		headers: {
			Authorization: `Bearer ${token}`,
			'Content-Type': 'application/json'
		}
	});

	console.log(classRoomResult);
	if (classRoomResult.status === 401) {
		throw error(401, 'Hiba történt a session ellenőrzése közben, kérem lépjen be újra!');
	}

	const classRoomResponse = await classRoomResult.json();
	const classRooms = await ClassRoomDtoSchema.parseAsync(classRoomResponse);

	const coursesResult = await fetch(base + '/api/courses', {
		method: 'GET',
		headers: {
			Authorization: `Bearer ${token}`,
			'Content-Type': 'application/json'
		}
	});

	const coursesResponse = await coursesResult.json();
	const courses = await z.array(CourseDtoSchema).parseAsync(coursesResponse);

	classRooms.sort((a, b) => a.capacity - b.capacity);

	return {
		classRooms,
		courses
	};
}) satisfies PageLoad;
