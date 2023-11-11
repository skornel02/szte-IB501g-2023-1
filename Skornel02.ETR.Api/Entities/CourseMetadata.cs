using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using Microsoft.EntityFrameworkCore;

using Skornel02.ETR.Common.Enums;

namespace Skornel02.ETR.Api.Entities;

[Table("CourseMetadatas")]
public class CourseMetadata
{
    [Key, StringLength(15)]
    [Comment("Kurzus kódja")]
    public required string CourseCode { get; init; }
    [Comment("Kurzus típusa")]
    public required CourseType Type { get; set; }
    [Comment("Kurzus neve")]
    public required string Name { get; set; }

    public List<Course> Courses { get; init; } = [];
}