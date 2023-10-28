<script lang="ts">
	import { onMount } from 'svelte';
	import type { ClassRoomDto } from '../../../../schemas/ClassRoomDto';
	import type { PageData } from './$types';
	import { roomTypeToName } from '../../../../enums/roomtypes';

	export let data: PageData;

	const { classRooms } = data;
</script>

<h1>Termek</h1>

<div class="container">
    <table class="table-hover">
        <thead>
            <tr>
                <th>#</th>
                <th>Cím</th>
                <th>Szoba szám</th>
                <th>Szoba típusa</th>
            </tr>
        </thead>
        <tbody>
            {#each classRooms as classRoom, i}
            <tr>
                <td>{i + 1}</td>
                <td>{classRoom.address}</td>
                <td>{classRoom.roomNumber}</td>
                <td>{roomTypeToName(classRoom.roomType)}</td>
            </tr>
            {/each}
        </tbody>
    </table>
</div>

<style>
	h1 {
		margin-top: 5px;
		text-align: center;
	}
</style>
