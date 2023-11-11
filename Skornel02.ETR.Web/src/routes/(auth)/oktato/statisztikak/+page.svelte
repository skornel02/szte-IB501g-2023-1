<script lang="ts">
	import { invalidateAll } from '$app/navigation';
	import type { PageData } from './$types';

	export let data: PageData;

	const { teachers, students, classRoom, teacherLoadLevels } = data;

	const refresh = () => invalidateAll();
</script>

<div class="container">
	<h1>Statisztikák</h1>

	<div class="toolbar">
		<button on:click|preventDefault={refresh} class="btn-small btn-secondary">Frissítés</button>
	</div>

	<div class="row flex-spaces tabs">
		<input id="tab1" type="radio" name="tabs" checked />
		<label for="tab1">Oktatók</label>

		<input id="tab2" type="radio" name="tabs" />
		<label for="tab2">Hallgatók</label>

		<input id="tab3" type="radio" name="tabs" />
		<label for="tab3">Legnagyobb terem</label>

		<input id="tab4" type="radio" name="tabs" />
		<label for="tab4">Oktató leterheltség</label>

		<div class="content" id="content1">
			<p>Az oktatók kilistázva, fiatalabbtól az idősebbig.</p>
			<table class="table-hover">
				<thead>
					<tr>
						<th>Felhasználó név</th>
						<th>Név</th>
						<th>Születési dátum</th>
						<th>Születési hely</th>
					</tr>
				</thead>
				<tbody>
					{#each teachers as teacher}
						<tr>
							<td>{teacher.username}</td>
							<td>{teacher.name}</td>
							<td>{teacher.birthDate}</td>
							<td>{teacher.birthLocation}</td>
						</tr>
					{/each}
				</tbody>
			</table>
		</div>
		<div class="content" id="content2">
			<p>Hallgatók által felvett kurzus mennyiség, a hallgatók neve ABC szerinti sorrendben.</p>
			<table class="table-hover">
				<thead>
					<tr>
						<th>Felhasználó név</th>
						<th>Név</th>
						<th>Kurzusok száma</th>
					</tr>
				</thead>
				<tbody>
					{#each students as student}
						<tr>
							<td>{student.username}</td>
							<td>{student.name}</td>
							<td>{student.courseCount}</td>
						</tr>
					{/each}
				</tbody>
			</table>
		</div>
		<div class="content" id="content3">
			<p>A legnagyobb (kapacitású) terem összesen {classRoom?.capacity}</p>
			<table class="table-hover">
				<tbody>
					{#if classRoom !== undefined}
						<tr>
							<th>Kurzuskód</th>
							<th>Szemeszter</th>
							<th>-</th>
						</tr>
						{#each classRoom.courses as course}
							<tr>
								<td>{course.courseCode}</td>
								<td colspan="2">{course.courseSemester}</td>
							</tr>
						{/each}
						<tr>
							<th>Kurzuskód</th>
							<th>Szemeszter</th>
							<th>Vizsga időpont</th>
						</tr>
						{#each classRoom.exams as exam}
							<tr>
								<td>{exam.courseCode}</td>
								<td>{exam.courseSemester}</td>
								<td>{exam.examDate}</td>
							</tr>
						{/each}
					{/if}
				</tbody>
			</table>
		</div>
		<div class="content" id="content4">
			<p>
				Tanárok leterheltsége egyes félévekben. Aki nem tart órát, az nem jelenik meg a listában.
			</p>
			<table class="table-hover">
				<thead>
					<tr>
						<th>Felhasználónév</th>
						<th>Név</th>
						<th>Félév</th>
						<th>Órák száma</th>
					</tr>
				</thead>
				<tbody>
					{#each teacherLoadLevels as teacherLoadLevel}
						<tr>
							<td>{teacherLoadLevel.name}</td>
							<td>{teacherLoadLevel.username}</td>
							<td>{teacherLoadLevel.semester}</td>
							<td>{teacherLoadLevel.hours}</td>
						</tr>
					{/each}
				</tbody>
			</table>
		</div>
	</div>
</div>

<style>
	h1 {
		text-align: center;
		margin-top: 5px;
		margin-bottom: 0;
	}
</style>
