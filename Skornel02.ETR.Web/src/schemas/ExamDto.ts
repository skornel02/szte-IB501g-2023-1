import { z } from 'zod';
import { ExamType } from '../enums/examtypes';

export const ExamSchema = z.object({
	courseCode: z.string(),
	courseSemester: z.string(),
	examType: z.nativeEnum(ExamType),
	start: z.string(),
	end: z.string(),
	classRoomAddress: z.string(),
	classRoomNumber: z.string(),
	classRoomName: z.string()
});

export type Exam = z.infer<typeof ExamSchema>;

export const ExamDtoSchema = z.array(ExamSchema);

export type ExamDto = z.infer<typeof ExamDtoSchema>;
