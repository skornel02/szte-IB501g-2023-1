import type { PageLoad } from './$types';
import { base } from '$app/paths';
import { DegreeTypeDtoSchema, type DegreeTypeDto } from '../../../schemas/DegreeTypeDto';

export const load = (async ({ fetch }) => {
	let degrees: DegreeTypeDto = [];

	try {
		const result = await fetch(base + '/api/degrees', {
			method: 'GET',
			headers: {
				'Content-Type': 'application/json'
			}
		});

		console.log(result);

		const response = await result.json();
		degrees = await DegreeTypeDtoSchema.parseAsync(response);
	} catch (e) {
		console.error("Szakok betöltése elbukott!", e);
	}

	degrees.sort((a, b) => a.name.localeCompare(b.name));

	return {
		degrees
	};
}) satisfies PageLoad;
