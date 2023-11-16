import { z } from "zod";
import { ExamType } from "../enums/examtypes";

export const ExamUpdateDtoSchema = z.object({
    courseCode: z.string(),
    courseSemester: z.string(),
    originalStart: z.string(),
    end: z.string(),
    examType: z.nativeEnum(ExamType),
    classRoomAddress: z.string(),
    classRoomNumber: z.string()

}).superRefine(({ originalStart, end }, ctx) => {
    if (new Date(originalStart).getTime() >= new Date(end).getTime()) {
        ctx.addIssue({
            code: 'custom',
            path: ['end'],
            message: 'A vége nem lehet a kezdete előtt!'
        });
    }
});

export type ExamUpdateDto = z.infer<typeof ExamUpdateDtoSchema>;
