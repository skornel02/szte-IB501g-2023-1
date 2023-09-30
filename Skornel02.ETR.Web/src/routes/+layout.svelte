<script lang="ts">
	import 'papercss/dist/paper.min.css';
	import type { LayoutData } from './$types';

	export let data: LayoutData;
</script>

<slot />

<style global>
	:root {
		--background-color: rgb(112, 80, 255);
		--text-color: rgb(255, 255, 255);
	}
</style>
