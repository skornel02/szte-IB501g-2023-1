<script lang="ts">
	import { getNameForUserType } from '../enums/usertypes';
	import type { ProfileDto } from '../schemas/ProfileDto';

	export let profile: ProfileDto;
</script>

<article>
	<div class="card" style="width: 20rem;">
		<div class="card-header">Felhasználó információk</div>
		<div class="card-body">
			<h4 class="card-title">Név</h4>
			<p class="card-text">{profile.name}</p>
			<h4 class="card-title">Jogok</h4>
			{#each profile.roles as role}
				<span class="badge secondary">{getNameForUserType(role)}</span>
			{/each}
		</div>
	</div>
	{#each profile.degrees as degree}
		<div class="card" style="width: 20rem;">
			<div class="card-header">Szak: {degree.name}</div>
			<div class="card-body">
				<h4 class="card-title">Kezdés</h4>
				<p class="card-text">{degree.startDate}</p>
				{#if degree.endDate !== null}
					<h4 class="card-title">Végzés</h4>
					<p class="card-text">{degree.endDate}</p>
				{:else}
					<p class="card-text">Ez a szak még elvégzés alatt áll.</p>
				{/if}
			</div>
		</div>
	{/each}
</article>

<style>
	article {
		display: flex;
		flex-direction: column;
		align-items: center;
	}
</style>
