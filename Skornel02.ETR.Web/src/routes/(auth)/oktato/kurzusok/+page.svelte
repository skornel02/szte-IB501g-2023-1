<script lang="ts">
	import type { PageData } from './$types';

	export let data: PageData;
</script>

<div class="container">
	<h4>Kurzusok</h4>
	<div class="toolbar">
		<a href="uj-kurzus" class="paper-btn btn-small btn-secondary">Új kurzus</a>
	</div>
</div>

<style>
	h4 {
		text-align: center;
		margin-top: 15px;
		margin-bottom: 0;
	}

	.toolbar {
		display: flex;
		justify-content: end;
	}
</style>
