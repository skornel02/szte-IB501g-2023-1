export enum UserType {
	Student = 0,
	Teacher = 1
}

export const getNameForUserType = (userType: UserType) => {
	switch (userType) {
		case UserType.Student:
			return 'Hallgató';
		case UserType.Teacher:
			return 'Oktató';
		default:
			return 'Ismeretlen';
	}
}
