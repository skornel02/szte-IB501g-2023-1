import { z } from 'zod';

const TeacherLoadStatisticsSchema = z.object({
	name: z.string(),
	username: z.string(),
	semester: z.string(),
	hours: z.number()
});

export type TeacherLoadStatistics = z.infer<typeof TeacherLoadStatisticsSchema>;

export const TeacherLoadStatisticsDtoSchema = z.array(TeacherLoadStatisticsSchema);

export type TeacherLoadStatisticsDto = z.infer<typeof TeacherLoadStatisticsDtoSchema>;
