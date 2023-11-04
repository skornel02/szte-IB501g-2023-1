import { z } from 'zod';
import { CourseType } from '../enums/coursetypes';

export const CourseDtoSchema = z.object({
	courseCode: z.string(),
	courseSemester: z.string(),
	hours: z.number(),
	credits: z.number(),
	courseName: z.string().optional(),
	courseType: z.nativeEnum(CourseType),
	classRoomAddress: z.string(),
	classRoomNumber: z.string(),
	classRoomName: z.string()
});

export type CourseDto = z.infer<typeof CourseDtoSchema>;
