<script lang="ts">
	import { CourseTypeToName } from '../../../../enums/coursetypes';
	import type { PageData } from './$types';

	export let data: PageData;

	const { courses, taughtCourses } = data;
</script>

<div class="container">
	<h4>Kurzusok</h4>
	<div class="toolbar">
		<a href="uj-kurzus" class="paper-btn btn-small btn-secondary">Új kurzus</a>
	</div>
	<h5>Általam tartott kurzusok</h5>
	<table class="table-hover">
		<thead>
			<tr>
				<th>Kód</th>
				<th>Szemeszter</th>
				<th>Név</th>
				<th>Óraszám</th>
				<th>Credit</th>
				<th>Típus</th>
				<th>Terem</th>
			</tr>
		</thead>
		<tbody>
			{#each taughtCourses as course}
				<tr>
					<td>{course.courseCode}</td>
					<td>{course.courseSemester}</td>
					<td>{course.courseName}</td>
					<td>{course.hours}</td>
					<td>{course.credits}</td>
					<td>{CourseTypeToName(course.courseType)}</td>
					<td>{course.classRoomAddress}, {course.classRoomNumber}</td>
				</tr>
			{/each}
		</tbody>
	</table>
	<h5>További kurzusok</h5>
	<table class="table-hover">
		<thead>
			<tr>
				<th>Kód</th>
				<th>Szemeszter</th>
				<th>Név</th>
				<th>Óraszám</th>
				<th>Credit</th>
				<th>Típus</th>
				<th>Terem</th>
			</tr>
		</thead>
		<tbody>
			{#each courses as course}
				<tr>
					<td>{course.courseCode}</td>
					<td>{course.courseSemester}</td>
					<td>{course.courseName}</td>
					<td>{course.hours}</td>
					<td>{course.credits}</td>
					<td>{CourseTypeToName(course.courseType)}</td>
					<td>{course.classRoomAddress}, {course.classRoomNumber}</td>
				</tr>
			{/each}
		</tbody>
	</table>
</div>

<style>
	h4 {
		text-align: center;
		margin-top: 15px;
		margin-bottom: 0;
	}

	.toolbar {
		display: flex;
		justify-content: end;
	}
</style>
