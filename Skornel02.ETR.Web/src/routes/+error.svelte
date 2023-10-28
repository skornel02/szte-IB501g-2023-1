<script lang="ts">
	import { page } from '$app/stores';
</script>

<h3>{$page.error?.message} <span class="badge danger">{$page.status}</span></h3>

<style>
	h3 {
		text-align: center;
	}
</style>
