<script lang="ts">
	import { goto, invalidateAll } from '$app/navigation';
	import Cookies from 'js-cookie';
	import { CourseTypeToName } from '../../../../enums/coursetypes';
	import type { PageData } from './$types';
	import { base } from '$app/paths';
	import { toast } from '@zerodevx/svelte-toast';

	export let data: PageData;

	const refresh = () => invalidateAll();

	const subscribeToCourse = async (
		courseCode: string,
		courseSemester: string,
		type: 'subscribe' | 'unsubscribe'
	) => {
		const token = Cookies.get('hallgato-token');
		const method = type === 'subscribe' ? 'POSt' : 'DELETE';
		const methodName = type === 'subscribe' ? 'feliratkozás' : 'leiratkozás';

		const result = await fetch(
			`${base}/api/course-learn?code=${courseCode}&semester=${courseSemester}`,
			{
				method,
				headers: {
					Authorization: `Bearer ${token}`,
					'Content-Type': 'application/json'
				}
			}
		);

		if (result.status === 204) {
			refresh();
			toast.push(`Sikeresen ${methodName} müvelet!`);
		} else {
			toast.push(`Sikertelen ${methodName} müvelet!`);
		}
	};

	const seeExamsForCourse = async (courseCode: string, courseSemester: string) => {
		goto('vizsga?course=' + courseCode + '|' + courseSemester);
	};
</script>

<div class="container">
	<h4>Kurzusok</h4>
	<div class="toolbar">
		<button class="btn-small btn-primary" on:click={refresh}>Frissítés</button>
	</div>
	<h5>Általam felvett kurzusok</h5>
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
				<th>Műveletek</th>
			</tr>
		</thead>
		<tbody>
			{#each data.attendedCourses as course}
				<tr>
					<td>{course.courseCode}</td>
					<td>{course.courseSemester}</td>
					<td>{course.courseName}</td>
					<td>{course.hours}</td>
					<td>{course.credits}</td>
					<td>{CourseTypeToName(course.courseType)}</td>
					<td>{course.classRoomAddress}, {course.classRoomNumber}</td>
					<td class="table-commands">
						<button
							class="btn-small btn-secondary"
							on:click={() =>
								seeExamsForCourse(course.courseCode, course.courseSemester, 'subscribe')}
						>
							Vizsgák
						</button>
						<button
							class="btn-small"
							on:click={() =>
								subscribeToCourse(course.courseCode, course.courseSemester, 'unsubscribe')}
						>
							Lead
						</button>
					</td>
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
				<th>Műveletek</th>
			</tr>
		</thead>
		<tbody>
			{#each data.courses as course}
				<tr>
					<td>{course.courseCode}</td>
					<td>{course.courseSemester}</td>
					<td>{course.courseName}</td>
					<td>{course.hours}</td>
					<td>{course.credits}</td>
					<td>{CourseTypeToName(course.courseType)}</td>
					<td>{course.classRoomAddress}, {course.classRoomNumber}</td>
					<td class="table-commands">
						<button
							class="btn-small btn-secondary"
							on:click={() =>
								seeExamsForCourse(course.courseCode, course.courseSemester, 'subscribe')}
						>
							Vizsgák
						</button>
						<button
							class="btn-small"
							on:click={() =>
								subscribeToCourse(course.courseCode, course.courseSemester, 'subscribe')}
						>
							Felvesz
						</button>
					</td>
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
</style>
