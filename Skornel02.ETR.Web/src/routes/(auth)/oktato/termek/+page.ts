import Cookies from 'js-cookie';
import type { PageLoad } from './$types';
import { ClassRoomDtoSchema } from '../../../../schemas/ClassRoomDto';
import { base } from '$app/paths';

export const load = (async ({fetch}) => {
    const token = Cookies.get('token');

    const result = await fetch(base + '/api/classrooms', {
        method: 'GET',
        headers: {
            'Authorization': `Bearer ${token}`,
            'Content-Type': 'application/json',
        }
    });

    const response = await result.json();
    const classRooms = await ClassRoomDtoSchema.parseAsync(response);

    return {
        classRooms,
    };
}) satisfies PageLoad;