<script lang="ts">
	import rickroll from '../../../../rick';

	const nextText = 'Ezen az oldalon TÉNYLEG nincsen semmi!';
	let text = 'Ezen az oldalon nincs semmi!';

	const handleClose = () => {
		if (text === nextText) {
			rickroll(
				{
					mouseleave: true
				},
				document.getElementById('alert')
			);
			text = "Táncra fel 💃!"
		} else {
			text = nextText;
		}
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
