export enum RoomTypes {
    SeminarRoom,
    ClassRoom,
    ComputerRoom,
    Laboratory,
}

export const roomTypeToName = (roomType: RoomTypes) => {
    switch (roomType) {
        case RoomTypes.SeminarRoom:
            return 'Előadó terem';
        case RoomTypes.ClassRoom:
            return 'Tanterem';
        case RoomTypes.ComputerRoom:
            return 'Számítógép terem';
        case RoomTypes.Laboratory:
            return 'Laboratórium';
        default:
            ((_: never) => { throw new Error(`Unknown room type: ${_}`) })(roomType);
    }
};
