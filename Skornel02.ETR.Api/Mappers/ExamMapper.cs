using Riok.Mapperly.Abstractions;

using Skornel02.ETR.Api.Entities;
using Skornel02.ETR.Common.Dtos;

namespace Skornel02.ETR.Api.Mappers;

[Mapper]
public static partial class ExamMapper
{

    [MapProperty(nameof(ExamCreationDto.CourseCode), nameof(Exam.CourseCode))]
    [MapProperty(nameof(ExamCreationDto.CourseSemester), nameof(Exam.CourseSemester))]
    [MapProperty(nameof(ExamCreationDto.Start), nameof(Exam.Start))]
    [MapProperty(nameof(ExamCreationDto.End), nameof(Exam.End))]
    [MapProperty(nameof(ExamCreationDto.ExamType), nameof(Exam.ExamType))]
    [MapProperty(nameof(ExamCreationDto.ClassRoomAddress), nameof(Exam.ClassRoomAddress))]
    [MapProperty(nameof(ExamCreationDto.ClassRoomNumber), nameof(Exam.ClassRoomRoomName))]
    public static partial Exam ToExam(this ExamCreationDto dto);
}