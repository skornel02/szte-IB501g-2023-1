import z from 'zod';

export const ErrorResponseDtoSchema = z.object({
    errorMessage: z.string(),
});

export type ErrorResponseDto = z.infer<typeof ErrorResponseDtoSchema>;
