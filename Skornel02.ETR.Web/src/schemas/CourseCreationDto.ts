import { z } from "zod";
import { CourseType } from "../enums/coursetypes";

/* 
public record CourseCreationDto(
    string CourseCode,
    string CourseSemester,
    int Hours,
    int Credits,
    string? CourseName,
    CourseType? CourseType,
    string ClassRoomAddress,
    string ClassRoomNumber
);
*/

export const CourseCreationDtoSchema = z.object({
    courseCode: z.string()
        .min(1, "Kurzus kódja nem lehet üres!")
        .max(15, "Kurzus kódja nem lehet 15 karakternél hosszabb"),
    courseSemester: z.string()
        .regex(/[1-9][0-9][0-9][0-9]\/[1-2]/, "A szemesztert a következő formátumban kell megadni: 2023/1"),
    hours: z.number(),
    credits: z.number().min(1, "A tárgyra fordított erő arányos a kreditszámmal-"),
    courseName: z.string().optional(),
    courseType: z.nativeEnum(CourseType),
    classRoomAddress: z.string(),
    classRoomNumber: z.string(),
})

export type CourseCreationDto = z.infer<typeof CourseCreationDtoSchema>;
