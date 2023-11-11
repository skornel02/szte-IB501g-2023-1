<script lang="ts">
	import ProfileDisplay from '$lib/ProfileDisplay.svelte';
	import type { ProfileDto } from '../../../../schemas/ProfileDto';
    import type { PageData } from './$types';
    
    export let data: PageData;

    let profile: ProfileDto;
    $: {
        profile = data.props?.profile!;
    }
</script>

<div class="container">
    <h1>Profil</h1>
    
    <ProfileDisplay {profile} />
</div>

<style>
    h1 {
        margin-top: 5px;
        text-align: center;
    }
</style>