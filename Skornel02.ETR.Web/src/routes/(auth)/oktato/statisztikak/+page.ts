import Cookies from 'js-cookie';
import type { PageLoad } from './$types';
import {
	UserStatisticsDtoSchema,
	type UserStatisticsDto
} from '../../../../schemas/UserStatisticsDto';
import { base } from '$app/paths';
import {
	UserCoursesStatisticsDtoSchema,
	type UserCoursesStatisticsDto
} from '../../../../schemas/UserCoursesStatisticsDto';
import {
	TeacherLoadStatisticsDtoSchema,
	type TeacherLoadStatisticsDto
} from '../../../../schemas/TeacherLoadStatisticsDto';
import { ClassRoomStatisticsDtoSchema, type ClassRoomStatisticsDto } from '../../../../schemas/ClassRoomStatisticsDto';

export const load = (async ({ fetch }) => {
	const token = Cookies.get('token');

	let teachers: UserStatisticsDto = [];
	let teacherLoadLevels: TeacherLoadStatisticsDto = [];
	let students: UserCoursesStatisticsDto = [];
	let classRoom: ClassRoomStatisticsDto | undefined;

	try {
		const teachersResult = await fetch(base + '/api/statistics/teachers', {
			method: 'GET',
			headers: {
				Authorization: `Bearer ${token}`,
				'Content-Type': 'application/json'
			}
		});

		const teachersResponse = await teachersResult.json();
		teachers = await UserStatisticsDtoSchema.parseAsync(teachersResponse);
	} catch (error) {
		console.error('Teacher statistics failed!', error);
	}

	try {
		const teacherLoadLevelsResult = await fetch(base + '/api/statistics/teacher-load-level', {
			method: 'GET',
			headers: {
				Authorization: `Bearer ${token}`,
				'Content-Type': 'application/json'
			}
		});

		const teacherLoadLevelsResponse = await teacherLoadLevelsResult.json();
		teacherLoadLevels = await TeacherLoadStatisticsDtoSchema.parseAsync(teacherLoadLevelsResponse);
	} catch (error) {
		console.error('Teacher load level statistics failed!', error);
	}

	try {
		const studentsResult = await fetch(base + '/api/statistics/students', {
			method: 'GET',
			headers: {
				Authorization: `Bearer ${token}`,
				'Content-Type': 'application/json'
			}
		});

		const studentsResponse = await studentsResult.json();
		students = await UserCoursesStatisticsDtoSchema.parseAsync(studentsResponse);
	} catch (error) {
		console.error('Student statistics failed!', error);
	}

	try {
		const classRoomResult = await fetch(base + '/api/statistics/largest-classroom', {
			method: 'GET',
			headers: {
				Authorization: `Bearer ${token}`,
				'Content-Type': 'application/json'
			}
		});

		const classRoomResponse = await classRoomResult.json();
		classRoom = await ClassRoomStatisticsDtoSchema.parseAsync(classRoomResponse);
	} catch (error) {
		console.error('Biggest classroom statistics failed!', error);
	}

	return {
		teachers,
		students,
		teacherLoadLevels,
		classRoom,
	};
}) satisfies PageLoad;
