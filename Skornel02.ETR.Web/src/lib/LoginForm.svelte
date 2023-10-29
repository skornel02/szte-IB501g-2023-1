<script lang="ts">
	import type { ZodFormattedError } from 'zod';
	import { type Credentials, CredentialsSchema } from '../schemas/LoginRequestDto';
	import { toast } from '@zerodevx/svelte-toast';

	export let regUrl: string;
	export let loginHandler: (cred: Credentials) => Promise<string | undefined>;

	const formData: Credentials = {
		username: '',
		password: ''
	};

	let errors: ZodFormattedError<Credentials> = {
		_errors: []
	};

	const handleSubmit = async () => {
		errors = {
			_errors: []
		};
		const test = await CredentialsSchema.safeParseAsync(formData);

		if (test.success) {
			const loginResult = await loginHandler(formData);
			if (loginResult !== undefined) {
				errors._errors = [loginResult];
			} else {
				toast.push('Sikeres bejelentkezés!');
			}
		} else {
			errors = test.error.format();
		}
	};

	const closeError = (type: keyof typeof errors) => {
		if (type === '_errors') {
			errors._errors = [];
		} else {
			errors[type] = undefined;
		}
	};
</script>

<form method="get" on:submit|preventDefault={handleSubmit}>
	<div class="form-group">
		<label for="usernameInput">Felhasználó név</label>
		<input
			type="text"
			placeholder="ABCEFG"
			id="usernameInput"
			name="username"
			class="input-block"
			bind:value={formData.username}
		/>
		{#if errors?.username}
			<div id="login-alert" class="alert alert-danger dismissible">
				{errors.username._errors[0]}
				<butto class="btn-close" for="login-alert" on:click={() => closeError('username')}>X</butto>
			</div>
		{/if}
	</div>
	<div class="form-group">
		<label for="passwordInput">Jelszó</label>
		<input
			type="password"
			id="passwordInput"
			name="password"
			class="input-block"
			bind:value={formData.password}
		/>
		{#if errors?.password}
			<div id="login-alert" class="alert alert-danger dismissible">
				{errors.password._errors[0]}
				<butto class="btn-close" for="login-alert" on:click={() => closeError('password')}>X</butto>
			</div>
		{/if}
	</div>
	{#if errors._errors.length > 0}
		<div id="login-alert" class="alert alert-danger dismissible">
			{errors._errors[0]}
			<label class="btn-close" for="login-alert" on:click={() => closeError('_errors')}>X</label>
		</div>
	{/if}
	<div id="form-controls">
		<a href={regUrl} class="paper-btn btn-secondary">Regisztráció</a>
		<button type="submit" class="btn-primary">Belépés</button>
	</div>
</form>

<style>
	#form-controls {
		display: flex;
		justify-content: space-between;
	}
</style>
