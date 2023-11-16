<script lang="ts">
	import rickroll from '../../../../rick';

	let text = 'Ezen az oldalon nincs semmi!';

	const handleClose = () => {
		rickroll(
			{
				mouseleave: true
			},
			document.getElementById('alert')
		);
		text = 'Még mindig nincs! Nem is lesz!';
	};
</script>

<div class="container">
	<div class="alert alert-warning dismissible" id="alert">
		{text}
		<label class="btn-close" for="alert-4" on:click={handleClose}>X</label>
	</div>
</div>

<style>
	.container {
		margin-top: 20px;
	}
</style>
