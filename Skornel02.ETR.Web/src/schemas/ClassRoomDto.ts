import { z } from 'zod';
import { RoomTypes } from '../enums/roomtypes';

export const ClassRoomSchema = z.object({
	name: z.string(),
	address: z.string(),
	roomNumber: z.string(),
	roomType: z.nativeEnum(RoomTypes),
	capacity: z.number()
});

export type ClassRoom = z.infer<typeof ClassRoomSchema>;

export const ClassRoomDtoSchema = z.array(ClassRoomSchema);

export type ClassRoomDto = z.infer<typeof ClassRoomDtoSchema>;
