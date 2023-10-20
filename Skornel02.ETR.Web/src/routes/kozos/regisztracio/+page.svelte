<script lang="ts">
	import LoginJunk from '$lib/LoginJunk.svelte';
	import LoginLogo from '$lib/LoginLogo.svelte';
	import RegistrationForm from '$lib/RegistrationForm.svelte';
	import { ErrorResponseDtoSchema } from '../../../dtos/general';
	import type { UserCreationDto } from '../../../dtos/user';
	import type { PageData } from '../../kozos/regisztracio/$types';

	export let data: PageData;

	const handleRegistration = async (registerDto: UserCreationDto): Promise<[string, boolean]> => {
		try {
			const resp = await fetch('/api/register', {
				method: 'POST',
				body: JSON.stringify(registerDto),
				headers: {
					'Content-Type': 'application/json'
				}
			});
			
			if (resp.status !== 204) {
				const errorResponse = await resp.json();
				const errorResponseDto = await ErrorResponseDtoSchema.safeParseAsync(errorResponse);
				if (errorResponseDto.success) {
					return [errorResponseDto.data.errorMessage, true];
				} else {
					return ['Ismeretlen hiba történt!', true];
				}
			} 
		} catch (ex) {
			console.error(ex);
			return ['Ismeretlen hálózati hiba történt!', true];
		}
		return [`Felhasználó '${registerDto.username}' sikeresen létrehozva!`, false]
	};
</script>

<div class="container logo-container">
	<div class="card" style="width: 20rem;">
		<div class="card-body">
			<h4 class="card-title">Regisztráció</h4>
			<RegistrationForm registerHandler={handleRegistration} />
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
