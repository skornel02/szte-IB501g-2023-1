<script lang="ts">
	import { base } from '$app/paths';
	import LoginAdvert from '$lib/LoginAdvert.svelte';
	import LoginForm from '$lib/LoginForm.svelte';
	import LoginJunk from '$lib/LoginJunk.svelte';
	import LoginLogo from '$lib/LoginLogo.svelte';
	import Cookies from 'js-cookie';
	import { UserType } from '../../../enums/usertypes';
	import { AuthResponseSchema } from '../../../schemas/AuthResponse';
	import { ErrorResponseDtoSchema } from '../../../schemas/ErrorResponseDto';
	import type { Credentials, LoginRequestDto } from '../../../schemas/LoginRequestDto';
	import { onMount } from 'svelte';

	const handleLogin = async (cred: Credentials) => {
		const loginDto: LoginRequestDto = {
			...cred,
			userType: UserType.Student
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

				Cookies.set('token', response.accessToken, {
					expires: expiration,
					path: '/hallgato/',
					secure: true,
					sameSite: 'strict'
				});

				window.location.href = `${base}/hallgato/kezdolap`;
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
		const token = Cookies.get('token');

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
				window.location.href = `${base}/hallgato/kezdolap`;
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
			<h4 class="card-title">Hallgatói belépés</h4>

			<LoginForm regUrl={`${base}/kozos/regisztracio`} loginHandler={handleLogin} />
		</div>
	</div>
	<LoginLogo />
</div>

<LoginAdvert />
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
