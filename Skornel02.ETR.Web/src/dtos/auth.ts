import z from 'zod';
import { UserType } from '../enums/usertypes';

export const CredentialsSchema = z.object({
    username: z.string()
        .min(1, { message: "A felhasználónév nem lehet üres!" })
        .max(255, { message: "A felhasználónév nem lehet hosszabb 255 karakternél!" }),
    password: z.string()
        .min(1, { message: "A jelszó nem lehet üres!" }),
});

export type Credentials = z.infer<typeof CredentialsSchema>;

export const LoginRequestDtoSchema = CredentialsSchema.and(z.object({
    userType: z.nativeEnum(UserType),
}));

export type LoginRequestDto = z.infer<typeof LoginRequestDtoSchema>;
