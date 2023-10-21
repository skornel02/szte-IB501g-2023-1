import { z } from "zod";

export const AuthResponseSchema = z.object({
    accessToken: z.string(),
    refreshToken: z.string(),
    expiresIn: z.number(),
});

export type AuthResponse = z.infer<typeof AuthResponseSchema>;
