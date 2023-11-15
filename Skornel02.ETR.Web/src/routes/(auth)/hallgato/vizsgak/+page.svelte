<script lang="ts">
	import { goto, invalidateAll } from '$app/navigation';
	import Cookies from 'js-cookie';
	import { CourseTypeToName } from '../../../../enums/coursetypes';
	import type { PageData } from './$types';
	import { base } from '$app/paths';
	import { toast } from '@zerodevx/svelte-toast';
	import { ExamTypeToName } from '../../../../enums/examtypes';
	import { ErrorResponseDtoSchema } from '../../../../schemas/ErrorResponseDto';

	export let data: PageData;

	const refresh = () => invalidateAll();

	const subscribeToExam = async (
		courseCode: string,
		courseSemester: string,
		start: string,
		type: 'subscribe' | 'unsubscribe'
	) => {
		const token = Cookies.get('hallgato-token');
		const method = type === 'subscribe' ? 'POST' : 'DELETE';
		const methodName = type === 'subscribe' ? 'feliratkozás' : 'leiratkozás';

		const result = await fetch(
			`${base}/api/exams-learn?code=${courseCode}&semester=${courseSemester}&start=${encodeURIComponent(
				start
			)}`,
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
			const errorResponse = await result.json();
			const errorResponseDto = await ErrorResponseDtoSchema.safeParseAsync(errorResponse);
			if (errorResponseDto.success) {
				toast.push(errorResponseDto.data.errorMessage);
			} else {
				toast.push(`Sikertelen ${methodName} müvelet!`);
			}
		}
	};
</script>

<div class="container">
	<h4>Vizsgák</h4>
	<div class="toolbar">
		<button class="btn-small btn-primary" on:click={refresh}>Frissítés</button>
		<a href="uj-vizsga" class="paper-btn btn-small btn-secondary">Új vizsga</a>
	</div>
	<h5>Általam felvett vizsgák</h5>
	<table class="table-hover">
		<thead>
			<tr>
				<th>Kód</th>
				<th>Szemeszter</th>
				<th>Kezdet</th>
				<th>Vége</th>
				<th>Típus</th>
				<th>Terem</th>
				<th>Műveletek</th>
			</tr>
		</thead>
		<tbody>
			{#each data.attendedExams as exam}
				<tr>
					<td>{exam.courseCode}</td>
					<td>{exam.courseSemester}</td>
					<td>{exam.start}</td>
					<td>{exam.end}</td>
					<td>{ExamTypeToName(exam.examType)}</td>
					<td>{exam.classRoomAddress}, {exam.classRoomNumber}</td>
					<td class="table-commands">
						<button
							class="btn-small btn-danger"
							on:click={() =>
								subscribeToExam(exam.courseCode, exam.courseSemester, exam.start, 'unsubscribe')}
						>
							Lead
						</button>
					</td>
				</tr>
			{/each}
		</tbody>
	</table>
	<h5>További vizsgák</h5>
	<table class="table-hover">
		<thead>
			<tr>
				<th>Kód</th>
				<th>Szemeszter</th>
				<th>Kezdet</th>
				<th>Vég</th>
				<th>Típus</th>
				<th>Terem</th>
				<th>Műveletek</th>
			</tr>
		</thead>
		<tbody>
			{#each data.exams as exam}
				<tr>
					<td>{exam.courseCode}</td>
					<td>{exam.courseSemester}</td>
					<td>{exam.start}</td>
					<td>{exam.end}</td>
					<td>{ExamTypeToName(exam.examType)}</td>
					<td>{exam.classRoomAddress}, {exam.classRoomNumber}</td>
					<td class="table-commands">
						<button
							class="btn-small"
							on:click={() =>
								subscribeToExam(exam.courseCode, exam.courseSemester, exam.start, 'subscribe')}
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
