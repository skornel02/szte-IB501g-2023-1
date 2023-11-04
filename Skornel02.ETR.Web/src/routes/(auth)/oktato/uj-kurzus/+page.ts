import Cookies from 'js-cookie';
import type { PageLoad } from './$types';
import { ClassRoomDtoSchema } from '../../../../schemas/ClassRoomDto';
import { base } from '$app/paths';
import { error, fail } from '@sveltejs/kit';

export const load = (async ({ fetch }) => {
	const token = Cookies.get('oktato-token');

	const result = await fetch(base + '/api/classrooms', {
		method: 'GET',
		headers: {
			Authorization: `Bearer ${token}`,
			'Content-Type': 'application/json'
		}
	});

	console.log(result);
	if (result.status === 401) {
		throw error(401, 'Hiba történt a session ellenőrzése közben, kérem lépjen be újra!');
	}

	const response = await result.json();
	const classRooms = await ClassRoomDtoSchema.parseAsync(response);

	classRooms.sort((a, b) => a.capacity - b.capacity);

	return {
		classRooms
	};
}) satisfies PageLoad;
