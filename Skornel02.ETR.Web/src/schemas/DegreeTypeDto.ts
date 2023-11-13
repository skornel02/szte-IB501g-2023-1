import { z } from "zod";
import { DegreeLevels } from "../enums/degreelevels";


export const DegreeTypeSchema = z.object({
    name: z.string(),
    level: z.nativeEnum(DegreeLevels),
});

export type DegreeType = z.infer<typeof DegreeTypeSchema>;

export const DegreeTypeDtoSchema = z.array(DegreeTypeSchema);

export type DegreeTypeDto = z.infer<typeof DegreeTypeDtoSchema>;
