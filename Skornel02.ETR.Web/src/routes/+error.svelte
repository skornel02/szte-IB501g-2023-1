<script lang="ts">
	import { page } from '$app/stores';
</script>

<h3>{$page.error?.message} <span class="badge danger">{$page.status}</span></h3>

<p>Boldogak a sajtkészítők!</p>

<style>
	h3 {
		text-align: center;
	}

	p {
		text-align: center;
		font-style: italic;
		color: grey;
	}
</style>
