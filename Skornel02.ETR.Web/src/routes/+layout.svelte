<script lang="ts">
	import { SvelteToast } from '@zerodevx/svelte-toast';
	import 'papercss/dist/paper.min.css';
	import type { SvelteToastOptions } from '@zerodevx/svelte-toast/stores';

	const options: SvelteToastOptions = {
		duration: 6000,
		pausable: false
	};
</script>

<slot />
{#key options}
	<SvelteToast {options} />
{/key}

<style global>
	:root {
		--background-color: rgb(112, 80, 255);
		--text-color: rgb(255, 255, 255);
	}
</style>
