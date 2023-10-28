import { z } from 'zod';

export const DegreeDtoSchema = z.object({
	name: z.string(),
	startDate: z.string(),
	endDate: z.string().nullable()
});

export type DegreeDto = z.infer<typeof DegreeDtoSchema>;
