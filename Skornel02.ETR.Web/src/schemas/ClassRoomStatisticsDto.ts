import { z } from 'zod';

const ClassRoomStatisticsCourseSchema = z.object({
	courseCode: z.string(),
	courseSemester: z.string()
});

export type ClassRoomStatisticsCourse = z.infer<typeof ClassRoomStatisticsCourseSchema>;

const ClassRoomStatisticsExamSchema = z.object({
	courseCode: z.string(),
	courseSemester: z.string(),
	examDate: z.string()
});

export type ClassRoomStatisticsExam = z.infer<typeof ClassRoomStatisticsExamSchema>;

export const ClassRoomStatisticsDtoSchema = z.object({
	capacity: z.number(),
	courses: z.array(ClassRoomStatisticsCourseSchema),
	exams: z.array(ClassRoomStatisticsExamSchema)
});

export type ClassRoomStatisticsDto = z.infer<typeof ClassRoomStatisticsDtoSchema>;
