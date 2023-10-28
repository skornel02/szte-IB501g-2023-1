using Skornel02.ETR.Common.Enums;

namespace Skornel02.ETR.Common.Dtos;

public record ClassRoomDto(
    string Address,
    string RoomNumber,
    RoomType RoomType
);