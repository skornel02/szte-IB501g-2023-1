export enum ExamType {
	Oral,
	Test,
	Combined,
	Computer,
	Online
}

export const ExamTypeToName = (examType: ExamType) => {
	switch (examType) {
		case ExamType.Oral:
			return 'Szóbeli';
		case ExamType.Test:
			return 'Írásbeli';
		case ExamType.Combined:
			return 'Kombinált';
		case ExamType.Computer:
			return 'Számítógépes';
		case ExamType.Online:
			return 'Online';
	}
};
