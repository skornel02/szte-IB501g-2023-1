import Cookies from 'js-cookie';
import type { LayoutLoad } from './$types';
import { base } from '$app/paths';
import { ProfileDtoSchema } from '../../schemas/ProfileDto';
import { goto } from '$app/navigation';

export const prerender = true;
export const ssr = false;
export const csr = true;

export const load: LayoutLoad = async ({ fetch }) => {
	const isStudent = window.location.href.includes('/hallgato/');

	const token = Cookies.get((isStudent ? 'hallgato' : 'oktato') + '-token');

	if (token === undefined || token.length === 0) {
		return;
	}

	try {
		const resp = await fetch(base + '/api/profile', {
			method: 'GET',
			headers: {
				Authorization: `Bearer ${token}`
			}
		});

		if (resp.status === 200) {
			const json = await resp.json();
			const profile = await ProfileDtoSchema.parseAsync(json);

			return {
				props: {
					profile
				}
			};
		}
	} catch (ex) {
		console.error('Auth check failed with error: ', ex);
	}

	goto(`${base}/hallgato/login`);
	alert('Hiba történt a bejelentkezés ellenőrzése közben! Próbálja újra később.');
	throw Error('Authentication failed!');
};
