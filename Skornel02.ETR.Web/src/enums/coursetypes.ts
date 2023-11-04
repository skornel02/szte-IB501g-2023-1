export enum CourseType {
	Compulsory,
	CompulsoryOptional,
	Optional
}

export const CourseTypeToName = (type: CourseType): string => {
	switch (type) {
		case CourseType.Compulsory:
			return 'Kötelező';
		case CourseType.Optional:
			return 'Szabadon választható';
		case CourseType.CompulsoryOptional:
			return 'Kötelezően választható';
		default:
			return 'Ismeretlen';
	}
};
