using Riok.Mapperly.Abstractions;

using Skornel02.ETR.Common.Dtos;

namespace Skornel02.ETR.Api.Mappers;

[Mapper]
public static partial class ErrorResponseMapper
{
    [MapProperty("", nameof(ErrorResponseDto.ErrorMessage))]
    public static partial ErrorResponseDto ToError(this string text);
}