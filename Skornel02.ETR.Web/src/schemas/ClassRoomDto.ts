import { z } from "zod";
import { RoomTypes } from "../enums/roomtypes";

export const ClassRoomSchema = z.object({
    address: z.string(),
    roomNumber: z.string(),
    roomType: z.nativeEnum(RoomTypes),
});

export type ClassRoom = z.infer<typeof ClassRoomSchema>;

export const ClassRoomDtoSchema = z.array(ClassRoomSchema);

export type ClassRoomDto = z.infer<typeof ClassRoomDtoSchema>;