using Riok.Mapperly.Abstractions;

using Skornel02.ETR.Api.Dtos;
using Skornel02.ETR.Api.Entities;

namespace Skornel02.ETR.Api.Mappers;

[Mapper]
public static partial class UserMapper
{
    [MapperIgnoreSource(nameof(UserCreationDto.Password))]
    [MapperIgnoreSource(nameof(UserCreationDto.Roles))]
    [MapperIgnoreTarget(nameof(User.PasswordHash))]
    public static partial User ToUser(this UserCreationDto dto);

    public static partial ProfileDto ToProfileDto(this User user);
}