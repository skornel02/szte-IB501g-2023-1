using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using Skornel02.ETR.Common.Enums;

namespace Skornel02.ETR.Api.Entities;

[Table("CourseMetadatas")]
public class CourseMetadata
{
    [Key, StringLength(15)]
    public required string CourseCode { get; init; }
    public required CourseType Type { get; set; }
    public required string Name { get; set; }

    public List<Course> Courses { get; init; } = [];
}