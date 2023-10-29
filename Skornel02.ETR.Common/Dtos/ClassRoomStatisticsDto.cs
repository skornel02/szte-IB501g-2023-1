namespace Skornel02.ETR.Common.Dtos;

public record ClassRoomStatisticsDto(
    int Capacity,
    List<ClassRoomStatisticsCourse> Courses,
    List<ClassRoomStatisticsExam> Exams
);

public record ClassRoomStatisticsCourse(
    string CourseCode,
    string CourseSemester
);

public record ClassRoomStatisticsExam(
    string CourseCode,
    string CourseSemester,
    DateTime ExamDate
);
