import { z } from 'zod';
import { DegreeDtoSchema } from './DegreeDto';
import { UserType } from '../enums/usertypes';

export const ProfileDtoSchema = z.object({
	name: z.string(),
	username: z.string(),
	degrees: z.array(DegreeDtoSchema),
	roles: z.array(z.nativeEnum(UserType))
});

export type ProfileDto = z.infer<typeof ProfileDtoSchema>;
