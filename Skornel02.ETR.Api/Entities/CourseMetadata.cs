using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using Skornel02.ETR.Common.Enums;

namespace Skornel02.ETR.Api.Entities;

[Table("CourseMetadatas")]
public class CourseMetadata
{
    [Key, StringLength(15)]
    [Description("Kurzus kódja")]
    public required string CourseCode { get; init; }
    [Description("Kurzus típusa")]
    public required CourseType Type { get; set; }
    [Description("Kurzus neve")]
    public required string Name { get; set; }

    public List<Course> Courses { get; init; } = [];
}