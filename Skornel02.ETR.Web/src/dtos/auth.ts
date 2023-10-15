import z from 'zod';
import { UserType } from '../enums/usertypes';

export const LoginRequestDtoSchema = z.object({
    username: z.string(),
    password: z.string(),
    userType: z.nativeEnum(UserType),
});

export type LoginRequestDto = z.infer<typeof LoginRequestDtoSchema>;
