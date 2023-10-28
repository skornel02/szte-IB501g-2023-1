<script lang="ts">
	import { base } from '$app/paths';
	import Cookies from 'js-cookie';
	import type { LayoutData } from './$types';

	export let data: LayoutData;

	if (!data.props) {
		throw new Error('data is undefined');
	}

	const handleLogout = async () => {
		Cookies.remove('token', {
			path: '/hallgato/',
			secure: true,
			sameSite: 'strict'
		});
		window.location.href = window.location.href.split('/').slice(0, -1).join('/') + '/login';
	};

	const { profile } = data.props;
	const isStudent = window.location.href.includes('/hallgato/');
	const isTeacher = window.location.href.includes('/oktato/');
</script>

<nav class="border split-nav">
	<div class="nav-brand">
		<h5>
			{profile.name} ({profile.username}) <br> [
			{#if profile.degrees.length > 0}
				{profile.degrees[0].name} ({profile.degrees[0].startDate} => {profile.degrees[0].endDate ??
					'-'})
			{/if}
			]
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
					<li><a href={`${base}/hallgato/kurzusok`}>Kurzusok</a></li>
					<li><a href={`${base}/hallgato/vizsgak`}>Vizsgák</a></li>
					<li><a href={`${base}/hallgato/profil`}>Profil</a></li>
				{:else if isTeacher}
					<li><a href={`${base}/oktato/kurzusok`}>Kurzusok</a></li>
					<li><a href={`${base}/oktato/vizsgak`}>Vizsgák</a></li>
					<li><a href={`${base}/oktato/termek`}>Termek</a></li>
					<li><a href={`${base}/oktato/statisztikak`}>Statisztikák</a></li>
					<li><a href={`${base}/oktato/profil`}>Profil</a></li>
				{/if}
				<li><button on:click={handleLogout}>Logout</button></li>
			</ul>
		</div>
	</div>
</nav>

<slot/>
