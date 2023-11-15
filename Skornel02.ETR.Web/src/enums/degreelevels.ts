export enum DegreeLevels {
	None,
	Bsc,
	Msc,
	PhD
}

export const getNameOfDegreeLevel = (degreeLevel: DegreeLevels): string => {
	switch (degreeLevel) {
		case DegreeLevels.Bsc:
			return 'BSc';
		case DegreeLevels.Msc:
			return 'MSc';
		case DegreeLevels.PhD:
			return 'PhD';
		default:
			return '-';
	}
};
