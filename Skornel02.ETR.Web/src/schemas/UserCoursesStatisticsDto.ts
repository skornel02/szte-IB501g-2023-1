import { z } from 'zod';

export const USerCoursesStatistics = z.object({
	username: z.string(),
	name: z.string(),
	courseCount: z.number()
});

export type UserCoursesStatistics = z.infer<typeof USerCoursesStatistics>;

export const UserCoursesStatisticsDtoSchema = z.array(USerCoursesStatistics);

export type UserCoursesStatisticsDto = z.infer<typeof UserCoursesStatisticsDtoSchema>;
