import { z } from 'zod';
import { ExamType } from '../enums/examtypes';

export const ExamCreationDtoSchema = z
	.object({
		courseCode: z
			.string()
			.min(1, 'Kurzus kódja nem lehet üres!')
			.max(15, 'Kurzus kódja nem lehet 15 karakternél hosszabb'),
		courseSemester: z
			.string()
			.regex(
				/[1-9][0-9][0-9][0-9]\/[1-2]/,
				'A szemesztert a következő formátumban kell megadni: 2023/1'
			),
		start: z.string(),
		end: z.string(),
		examType: z.nativeEnum(ExamType),
		classRoomAddress: z.string(),
		classRoomNumber: z.string()
	})
	.superRefine(({ start, end }, ctx) => {
		if (new Date(start).getTime() >= new Date(end).getTime()) {
			ctx.addIssue({
				code: 'custom',
				path: ['end'],
				message: 'A vége nem lehet a kezdete előtt!'
			});
		}
	});

export type ExamCreationDto = z.infer<typeof ExamCreationDtoSchema>;
