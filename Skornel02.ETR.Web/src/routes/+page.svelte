<script>
	import { base } from "$app/paths";

</script>
<main>
	<h2><b>E</b>ntergalaktikus <b>T</b>anulmányi <b>R</b>endszer</h2>
	<article class="container">
		<div id="spacer" />
		<div id="buttons">
			<a href={`${base}/hallgato/login`} class="paper-btn"> Hallgatók / Students </a>
			<a href={`${base}/oktato/login`} class="paper-btn"> Oktatók / Teachers </a>
		</div>
	</article>
</main>

<style>
	main {
		display: flex;
		flex-direction: column;
		min-height: 100vh;
		background-color: var(--background-color);
	}

	h2 {
		color: var(--text-color);
		text-align: center;
	}

	article {
		height: 650px;
		margin: 0 auto;
		background-image: url('https://placehold.co/1000x450/EEE/31343C');
		background-repeat: no-repeat;

		display: flex;
		flex-direction: column;
		justify-content: start;
	}

	#spacer {
		height: 175px;
	}

	#buttons {
		display: flex;
		justify-content: space-around;
	}

	a {
		border-radius: 50px;
		background-color: var(--background-color);
		color: var(--text-color);
	}
</style>
