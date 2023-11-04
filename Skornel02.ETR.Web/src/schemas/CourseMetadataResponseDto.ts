import { z } from 'zod';
import { CourseType } from '../enums/coursetypes';

export const CourseMetadataResponseDtoSchema = z.object({
	name: z.string(),
	type: z.nativeEnum(CourseType)
});

export type CourseMetadataResponseDto = z.infer<typeof CourseMetadataResponseDtoSchema>;
