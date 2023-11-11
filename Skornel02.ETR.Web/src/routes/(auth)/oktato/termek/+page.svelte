<script lang="ts">
	import { onMount } from 'svelte';
	import type { ClassRoomDto } from '../../../../schemas/ClassRoomDto';
	import type { PageData } from './$types';
	import { roomTypeToName } from '../../../../enums/roomtypes';

	export let data: PageData;
</script>

<h1>Termek</h1>

<div class="container">
	<table class="table-hover">
		<thead>
			<tr>
				<th>Név</th>
				<th>Cím</th>
				<th>Szoba szám</th>
				<th>Szoba típusa</th>
				<th>Férőhelyek</th>
			</tr>
		</thead>
		<tbody>
			{#each data.classRooms as classRoom, i}
				<tr>
					<td>{classRoom.name}</td>
					<td>{classRoom.address}</td>
					<td>{classRoom.roomNumber}</td>
					<td>{roomTypeToName(classRoom.roomType)}</td>
					<td>{classRoom.capacity}</td>
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
