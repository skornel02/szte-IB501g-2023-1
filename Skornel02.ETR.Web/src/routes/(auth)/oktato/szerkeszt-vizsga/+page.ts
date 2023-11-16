import Cookies from 'js-cookie';
import type { PageLoad } from './$types';
import { z } from 'zod';
import { base } from '$app/paths';
import { ExamDtoSchema, type ExamDto } from '../../../../schemas/ExamDto';
import { ClassRoomDtoSchema, type ClassRoomDto } from '../../../../schemas/ClassRoomDto';
import { error } from '@sveltejs/kit';

export const load = (async ({ fetch }) => {
	const token = Cookies.get('oktato-token');

	let exams: ExamDto = [];
	let classRooms: ClassRoomDto = [];

	try {
		const examsResult = await fetch(base + '/api/exams?teachedByMe=true', {
			method: 'GET',
			headers: {
				Authorization: `Bearer ${token}`,
				'Content-Type': 'application/json'
			}
		});

		const examsResponse = await examsResult.json();
		exams = await ExamDtoSchema.parseAsync(examsResponse);
	} catch (error) {
		console.error('Exams loading failed!', error);
	}

	try {
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
		classRooms = await ClassRoomDtoSchema.parseAsync(classRoomResponse);
	} catch (error) {
		console.error('Classroom loading failed!', error);
	}

	return {
		classRooms,
		exams
	};
}) satisfies PageLoad;
