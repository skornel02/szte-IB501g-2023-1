import { z } from 'zod';
import { CredentialsSchema } from './LoginRequestDto';
import { UserType } from '../enums/usertypes';

export const UserCreationFormSchema = CredentialsSchema.and(
	z.object({
		passwordRepeat: z.string().min(1, { message: 'A jelszó nem lehet üres!' }),
		name: z
			.string()
			.min(1, { message: 'A név nem lehet üres!' })
			.max(100, { message: 'A név nem lehet hosszabb 100 karakternél!' }),
		roles: z.object({
			student: z.boolean(),
			teacher: z.boolean()
		}),
		birthDate: z.coerce
			.date()
			.min(new Date(1900, 1, 1), { message: 'A születési dátum nem lehet korábbi 1900.01.01-nél!' })
			.max(new Date(), { message: 'A születési dátum nem lehet későbbi a mai dátumnál!' }),
		birthLocation: z.string().min(1, { message: 'A születési hely nem lehet üres!' }),
		degrees: z.array(z.object({ value: z.string() }))
	})
).superRefine(({ password, passwordRepeat, roles }, ctx) => {
	if (passwordRepeat !== password) {
		ctx.addIssue({
			code: 'custom',
			path: ['passwordRepeat'],
			message: 'A két jelszó nem egyezett!'
		});
	}
	if (!roles.student && !roles.teacher) {
		ctx.addIssue({
			code: 'custom',
			path: ['roles'],
			message: 'Legalább egy szerepkör megadása kötelező!'
		});
	}
});

export type UserCreationForm = z.infer<typeof UserCreationFormSchema>;

export const userCreationFormToDto = (form: UserCreationForm): UserCreationDto => {
	const roles = [];
	if (form.roles.student) {
		roles.push(UserType.Student);
	}
	if (form.roles.teacher) {
		roles.push(UserType.Teacher);
	}

	return {
		username: form.username,
		password: form.password,
		name: form.name,
		roles,
		birthDate: form.birthDate,
		birthLocation: form.birthLocation,
		degrees: form.degrees.map((d) => d.value)
	};
};

export const UserCreationDtoSchema = CredentialsSchema.and(
	z.object({
		name: z.string().min(1, { message: 'A név nem lehet üres!' }),
		roles: z
			.array(z.nativeEnum(UserType))
			.min(1, { message: 'Legalább egy szerepkör megadása kötelező!' }),
		birthDate: z.coerce
			.date()
			.min(new Date(1900, 1, 1), { message: 'A születési dátum nem lehet korábbi 1900.01.01-nél!' })
			.max(new Date(), { message: 'A születési dátum nem lehet későbbi a mai dátumnál!' }),
		birthLocation: z.string().min(1, { message: 'A születési hely nem lehet üres!' }),
		degrees: z.array(z.string())
	})
);

export type UserCreationDto = z.infer<typeof UserCreationDtoSchema>;
