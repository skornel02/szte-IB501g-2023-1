using Riok.Mapperly.Abstractions;

using Skornel02.ETR.Api.Dtos;

namespace Skornel02.ETR.Api.Mappers;

[Mapper]
public static partial class ErrorResponseMapper
{
    [MapProperty("", nameof(ErrorResponseDto.ErrorMessage))]
    public static partial ErrorResponseDto ToError(this string text);
}