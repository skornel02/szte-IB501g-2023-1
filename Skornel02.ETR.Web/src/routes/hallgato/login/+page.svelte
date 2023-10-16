<script lang="ts">
	import { base } from '$app/paths';
	import LoginAdvert from '$lib/LoginAdvert.svelte';
	import LoginForm from '$lib/LoginForm.svelte';
	import LoginJunk from '$lib/LoginJunk.svelte';
	import LoginLogo from '$lib/LoginLogo.svelte';
	import type { Credentials } from '$lib/authentication';
	import type { LoginRequestDto } from '../../../dtos/auth';
	import { ErrorResponseDtoSchema } from '../../../dtos/general';
	import { UserType } from '../../../enums/usertypes';
	import type { PageData } from './$types';

	export let data: PageData;

	const handleLogin = async (cred: Credentials) => {
		const loginDto: LoginRequestDto = {
			...cred,
			userType: UserType.Student
		};

		try {
			const resp = await fetch('/api/check-auth', {
				method: 'POST',
				body: JSON.stringify(loginDto),
				headers: {
					'Content-Type': 'application/json'
				},
			});
	
			if (resp.status === 204) {
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
			return 'Ismeretlen hálózati hiba történt!';
		}
	};
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
