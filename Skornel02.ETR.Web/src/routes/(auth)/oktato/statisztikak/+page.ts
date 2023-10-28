import Cookies from 'js-cookie';
import type { PageLoad } from './$types';
import { UserStatisticsDtoSchema, type UserStatisticsDto } from '../../../../schemas/UserStatisticsDto';
import { base } from '$app/paths';
import { UserCoursesStatisticsDtoSchema, type UserCoursesStatisticsDto } from '../../../../schemas/UserCoursesStatisticsDto';

export const load = (async ({fetch}) => {
    const token = Cookies.get('token');

    let teachers: UserStatisticsDto = [];
    let students: UserCoursesStatisticsDto = [];

    try {
        const teachersResult = await fetch(base + '/api/statistics/teachers', {
            method: 'GET',
            headers: {
                'Authorization': `Bearer ${token}`,
                'Content-Type': 'application/json',
            }
        });
    
        const teachersResponse = await teachersResult.json();
        teachers = await UserStatisticsDtoSchema.parseAsync(teachersResponse);
    } catch (error) {
        console.error("Teacher statistics failed!", error);
    }

    try {
        const studentsResult = await fetch(base + '/api/statistics/students', {
            method: 'GET',
            headers: {
                'Authorization': `Bearer ${token}`,
                'Content-Type': 'application/json',
            }
        });
    
        const studentsResponse = await studentsResult.json();
        students = await UserCoursesStatisticsDtoSchema.parseAsync(studentsResponse);
    } catch (error) {
        console.error("Student statistics failed!", error);
    }

    return {
        teachers,
        students,
    };
}) satisfies PageLoad;