<script lang="ts">
	import type { Credentials } from './authentication';

	export let regUrl: string;
	export let error: string | null = null;
	export let loginHandler: (cred: Credentials) => Promise<void>;

	const handleSubmit = (event: Event) => {
		const form = event.target as HTMLFormElement;
		const formData = new FormData(form);
		const data = Object.fromEntries(formData.entries()) as object;
		console.log(data);

		if (!('username' in data) || typeof data.username !== 'string' || data.username.length === 0) {
			error = 'Felhasználónév megadása kötelező!';
			return;
		}

		if (!('password' in data) || typeof data.password !== 'string' || data.password.length === 0) {
			error = 'Jelszó megadása kötelező!';
			return;
		}

		const cred: Credentials = {
			username: data.username as string,
			password: data.password as string
		};
		loginHandler(cred);
	};

	const closeError = () => {
		error = null;
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
		/>
	</div>
	<div class="form-group">
		<label for="passwordInput">Jelszó</label>
		<input type="password" id="passwordInput" name="password" class="input-block" />
	</div>
	{#if error !== null}
		<div id="login-alert" class="alert alert-danger">
			{error}
			<label class="btn-close" for="login-alert" on:click={closeError}>X</label>
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
