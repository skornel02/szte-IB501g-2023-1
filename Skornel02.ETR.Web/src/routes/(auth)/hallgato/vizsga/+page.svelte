<script lang="ts">
	import { onMount } from 'svelte';
	import type { PageData } from './$types';
	import { page } from '$app/stores';
	import { ExamDtoSchema, type ExamDto } from '../../../../schemas/ExamDto';
	import { ExamTypeToName } from '../../../../enums/examtypes';
	import { base } from '$app/paths';
	import Cookies from 'js-cookie';
	import { invalidateAll } from '$app/navigation';
	import { toast } from '@zerodevx/svelte-toast';

	export let data: PageData;

	const refresh = () => {
		invalidateAll();
		loadExams();
	};

	const { courses } = data;

	let courseCodeAndSemester = `${courses[0]?.courseCode}|${courses[0]?.courseSemester}`;
	let exams: ExamDto = [];
	let loading = true;

	onMount(() => {
		const course = $page.url.searchParams.get('course');
		if (course) {
			courseCodeAndSemester = course;
		}
		loadExams();
	});

	const handleCourseChange = () => {
		loadExams();
	};

	const loadExams = async () => {
		loading = true;
		try {
			const token = Cookies.get('hallgato-token');

			const [courseCode, courseSemester] = courseCodeAndSemester.split('|');
			const coursesResult = await fetch(
				base +
					'/api/exams?courseCode=' +
					courseCode +
					'&courseSemester=' +
					encodeURI(courseSemester),
				{
					method: 'GET',
					headers: {
						Authorization: `Bearer ${token}`,
						'Content-Type': 'application/json'
					}
				}
			);

			const coursesResponse = await coursesResult.json();
			exams = await ExamDtoSchema.parseAsync(coursesResponse);
		} catch (error) {
			toast.push('Hiba történt a vizsgák betöltése közben!');
		} finally {
			loading = false;
		}
	};
</script>

<div class="container">
	<h3>Kurzus vizsgái</h3>

	<div class="toolbar">
		<button class="btn-small btn-primary" on:click={refresh}>Frissítés</button>
	</div>

	<h4>Kurzus választó</h4>
	<select
		id="classRoomInput"
		class="input-block"
		bind:value={courseCodeAndSemester}
		on:change={handleCourseChange}
	>
		{#each courses as course}
			<option value={`${course.courseCode}|${course.courseSemester}`}>
				{course.courseCode} (Félév: {course.courseSemester})
			</option>
		{/each}
	</select>

    <h4>Vizsgák</h4>
	{#if loading}
        <p>
            Betöltés...
        </p>
    {:else}
		{#if exams.length === 0}
			<p>Nincsenek vizsgák</p>
		{:else}
			<table class="table-hover">
				<thead>
					<tr>
						<th>Kezdet</th>
						<th>Vég</th>
						<th>Típus</th>
						<th>Terem</th>
					</tr>
				</thead>
				<tbody>
					{#each exams as exam}
						<tr>
							<td>{exam.start}</td>
							<td>{exam.end}</td>
							<td>{ExamTypeToName(exam.examType)}</td>
							<td>{exam.classRoomAddress}, {exam.classRoomNumber}</td>
						</tr>
					{/each}
				</tbody>
			</table>
		{/if}
	{/if}
</div>

<style>
	h3 {
		margin-top: 1rem;
		text-align: center;
	}
</style>
