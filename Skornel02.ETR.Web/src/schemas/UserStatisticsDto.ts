import { z } from "zod";

/*
public record UserStatisticsDto(
    string Username,
    string Name,
    DateOnly BirthDate,
    string BirthLocation
);
*/

export const UserStatisticsSchema = z.object({
    username: z.string(),
    name: z.string(),
    birthDate: z.string(),
    birthLocation: z.string(),
    });

export type UserStatistics = z.infer<typeof UserStatisticsSchema>;

export const UserStatisticsDtoSchema = z.array(UserStatisticsSchema);

export type UserStatisticsDto = z.infer<typeof UserStatisticsDtoSchema>;