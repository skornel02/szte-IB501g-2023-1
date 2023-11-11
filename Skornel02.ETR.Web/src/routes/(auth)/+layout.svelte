<script lang="ts">
	import { base } from '$app/paths';
	import Cookies from 'js-cookie';
	import type { LayoutData } from './$types';
	import { toast } from '@zerodevx/svelte-toast';
	import { goto } from '$app/navigation';
	import type { ProfileDto } from '../../schemas/ProfileDto';

	export let data: LayoutData;

	const isStudent = window.location.href.includes('/hallgato/');
	const isTeacher = window.location.href.includes('/oktato/');

	const handleLogout = async () => {
		Cookies.remove((isStudent ? 'hallgato' : 'oktato') + '-token', {
			path: '/',
			secure: true,
			sameSite: 'strict'
		});
		toast.push('Sikeres kijelentkezés!');
		goto(window.location.href.split('/').slice(0, -1).join('/') + '/login');
	};

	let profile: ProfileDto;
	$: {
		profile = data.props?.profile ?? {
			name: 'hiba, próbálja meg az oldalt újratölteni és/vagy újra bejelentkezni',
			degrees: [],
			roles: [],
			username: 'session lejárt?'
		};
	}
</script>

<nav class="border split-nav">
	<div class="nav-brand">
		<h5>
			{profile.name} ({profile.username}) <br />
			{#if isStudent}
				[
				{#if profile.degrees.length > 0}
					{profile.degrees[0].name} ({profile.degrees[0].startDate} => {profile.degrees[0]
						.endDate ?? '-'})
				{/if}
				]
			{/if}
		</h5>
	</div>
	<div class="collapsible">
		<input id="collapsible1" type="checkbox" name="collapsible1" />
		<label for="collapsible1">
			<div class="bar1" />
			<div class="bar2" />
			<div class="bar3" />
		</label>
		<div class="collapsible-body">
			<ul class="inline">
				{#if isStudent}
					<li><a href={`${base}/hallgato/kurzusok`} class="paper-btn btn-small">Kurzusok</a></li>
					<li><a href={`${base}/hallgato/vizsgak`} class="paper-btn btn-small">Vizsgák</a></li>
					<li><a href={`${base}/hallgato/profil`} class="paper-btn btn-small">Profil</a></li>
				{:else if isTeacher}
					<li><a href={`${base}/oktato/kurzusok`} class="paper-btn btn-small">Kurzusok</a></li>
					<li><a href={`${base}/oktato/vizsgak`} class="paper-btn btn-small">Vizsgák</a></li>
					<li><a href={`${base}/oktato/termek`} class="paper-btn btn-small">Termek</a></li>
					<li>
						<a href={`${base}/oktato/statisztikak`} class="paper-btn btn-small">Statisztikák</a>
					</li>
					<li><a href={`${base}/oktato/profil`} class="paper-btn btn-small">Profil</a></li>
				{/if}
				<li><button on:click={handleLogout} class="btn-small btn-primary">Logout</button></li>
			</ul>
		</div>
	</div>
</nav>

<slot />
