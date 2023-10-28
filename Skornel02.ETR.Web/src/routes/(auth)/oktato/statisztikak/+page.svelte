<script lang="ts">
	import type { PageData } from './$types';

	export let data: PageData;

	const { teachers, students, teacherLoadLevels } = data;
</script>

<h1>Statisztikák</h1>

<div class="container">
	<div class="row flex-spaces tabs">
		<input id="tab1" type="radio" name="tabs" checked />
		<label for="tab1">Oktatók</label>

		<input id="tab2" type="radio" name="tabs" />
		<label for="tab2">Hallgatók</label>

		<input id="tab3" type="radio" name="tabs" />
		<label for="tab3">Tab 3</label>

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
			<p>Bacon ipsum dolor sit amet beef venison beef ribs kielbasa...</p>
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
		margin-top: 5px;
		text-align: center;
	}
</style>
