<script lang="ts">
	import { base } from '$app/paths';
	import LoginForm from '$lib/LoginForm.svelte';
	import LoginJunk from '$lib/LoginJunk.svelte';
	import LoginLogo from '$lib/LoginLogo.svelte';
	import type { Credentials } from '$lib/authentication';
	import type { PageData } from './$types';

	export let data: PageData;

	const handleLogin = async (cred: Credentials) => {
		console.log(cred);
	};
</script>

<div class="container logo-container">
	<div class="card" style="width: 20rem;">
		<div class="card-body">
			<h4 class="card-title">Oktatói belépés</h4>

			<LoginForm regUrl={`${base}/oktato/regisztracio`} loginHandler={handleLogin} />
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