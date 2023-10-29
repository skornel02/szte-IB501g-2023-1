<script lang="ts">
	import { base } from '$app/paths';
	import LoginForm from '$lib/LoginForm.svelte';
	import LoginJunk from '$lib/LoginJunk.svelte';
	import LoginLogo from '$lib/LoginLogo.svelte';
	import Cookies from 'js-cookie';
	import { UserType } from '../../../enums/usertypes';
	import { ErrorResponseDtoSchema } from '../../../schemas/ErrorResponseDto';
	import type { Credentials, LoginRequestDto } from '../../../schemas/LoginRequestDto';
	import { onMount } from 'svelte';
	import { AuthResponseSchema } from '../../../schemas/AuthResponse';
	import { goto } from '$app/navigation';

	const handleLogin = async (cred: Credentials) => {
		const loginDto: LoginRequestDto = {
			...cred,
			userType: UserType.Teacher
		};

		try {
			const resp = await fetch(base + '/api/auth', {
				method: 'POST',
				body: JSON.stringify(loginDto),
				headers: {
					'Content-Type': 'application/json'
				}
			});

			if (resp.status === 200) {
				const response = await AuthResponseSchema.parseAsync(await resp.json());
				const expiration = new Date(new Date().getTime() + response.expiresIn * 1000);

				Cookies.set('oktato-token', response.accessToken, {
					expires: expiration,
					path: '/',
					secure: true,
					sameSite: 'strict'
				});

				await goto(`${base}/oktato/kezdolap`);
			} else {
				const errorResponse = await resp.json();
				const errorResponseDto = await ErrorResponseDtoSchema.safeParseAsync(errorResponse);
				if (errorResponseDto.success) {
					return errorResponseDto.data.errorMessage;
				} else {
					return 'Ismeretlen hiba történt!';
				}
			}
		} catch (ex) {
			console.error(ex);
			return 'Ismeretlen hiba történt!';
		}
	};

	const checkAlreadyLoggedIn = async () => {
		const token = Cookies.get('oktato-token');

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
				goto(`${base}/oktato/kezdolap`);
			}
		} catch (ex) {
			console.error('Auth check failed with error: ', ex);
		}
	};

	onMount(async () => {
		checkAlreadyLoggedIn();
	});
</script>

<div class="container logo-container">
	<div class="card" style="width: 20rem;">
		<div class="card-body">
			<h4 class="card-title">Oktatói belépés</h4>

			<LoginForm regUrl={`${base}/kozos/regisztracio`} loginHandler={handleLogin} />
		</div>
	</div>
	<LoginLogo />
</div>

<LoginJunk />

<style>
	.logo-container {
		display: flex;
		flex-direction: row;
		align-items: center;
	}

	.card {
		margin: 1rem 5rem;
	}

	.card-body {
		background-color: white;
	}
</style>
