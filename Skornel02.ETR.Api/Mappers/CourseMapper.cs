using Riok.Mapperly.Abstractions;

using Skornel02.ETR.Api.Entities;
using Skornel02.ETR.Common.Dtos;

namespace Skornel02.ETR.Api.Mappers;

[Mapper]
public static partial class CourseMapper
{

    [MapProperty(nameof(CourseCreationDto.CourseCode), nameof(Course.CourseCode))]
    [MapProperty(nameof(CourseCreationDto.CourseSemester), nameof(Course.Semester))]
    [MapProperty(nameof(CourseCreationDto.Hours), nameof(Course.Hours))]
    [MapProperty(nameof(CourseCreationDto.Credits), nameof(Course.Credits))]
    [MapProperty(nameof(CourseCreationDto.ClassRoomAddress), nameof(Course.ClassRoomAddress))]
    [MapProperty(nameof(CourseCreationDto.ClassRoomNumber), nameof(Course.ClassRoomRoomName))]
    public static partial Course ToCourse(this CourseCreationDto dto);


    [MapProperty(nameof(CourseCreationDto.CourseCode), nameof(Course.CourseCode))]
    [MapProperty(nameof(CourseCreationDto.CourseName), nameof(CourseMetadata.Name))]
    [MapProperty(nameof(CourseCreationDto.CourseType), nameof(CourseMetadata.Type))]
    public static partial CourseMetadata ToMetadata(this CourseCreationDto dto);
}