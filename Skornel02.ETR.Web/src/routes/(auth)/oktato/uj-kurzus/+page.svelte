<script lang="ts">
    	import type { PageData } from './$types';
	import { roomTypeToName } from '../../../../enums/roomtypes';

	export let data: PageData;

	const { classRooms } = data;

    let classroomAddressAndRoomNumber = `${classRooms[0]?.address}|${classRooms[0]?.roomNumber}`;
</script>

<div class="container">
    <h3>
        Új kurzus létrehozása
    </h3>

    <select bind:value={classroomAddressAndRoomNumber}>
        {#each classRooms as classroom}
            <option value={`${classroom.address}|${classroom.roomNumber}`}>
                {classroom.name} ({classroom.address})
            </option>
        {/each}
    </select>
</div>

<style>
    h3 {
        text-align: center;
        margin-top: 15px;
    }
</style>