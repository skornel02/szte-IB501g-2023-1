<script lang="ts">
	import type { ZodFormattedError } from 'zod';
	import { ExamType, ExamTypeToName } from '../../../../enums/examtypes';
	import type { PageData } from './$types';
	import { toast } from '@zerodevx/svelte-toast';
	import Cookies from 'js-cookie';
	import { base } from '$app/paths';
	import { ErrorResponseDtoSchema } from '../../../../schemas/ErrorResponseDto';
	import { onMount } from 'svelte';
	import { page } from '$app/stores';
	import { ExamUpdateDtoSchema, type ExamUpdateDto } from '../../../../schemas/ExamUpdateDto';

	export let data: PageData;

	const { classRooms, exams } = data;

	let examCodeAndSemesterAndStart = `${exams[0]?.courseCode}|${exams[0]?.courseSemester}|${exams[0]?.start}}`;
	let classroomAddressAndRoomNumber = `${classRooms[0]?.address}|${classRooms[0]?.roomNumber}`;

	const formData: ExamUpdateDto = {
		courseCode: exams[0]?.courseCode,
		courseSemester: exams[0]?.courseSemester,
		originalStart: exams[0]?.start,
		end: new Date(new Date().getTime() + 1000 * 3600).toISOString().slice(0, 16),
		examType: ExamType.Online,
		classRoomAddress: classRooms[0]?.address,
		classRoomNumber: classRooms[0]?.roomNumber
	};

	onMount(() => {
		const exam = $page.url.searchParams.get('exam');
		if (exam) {
			examCodeAndSemesterAndStart = exam;
			const [courseCode, courseSemester, start] = exam.split('|');
			formData.courseCode = courseCode;
			formData.courseSemester = courseSemester;
			formData.originalStart = start;
		}
	});

	let errors: ZodFormattedError<ExamUpdateDto> = {
		_errors: []
	};

	const handleClassroomChange = (event: Event) => {
		const [address, roomNumber] = (event.target as HTMLSelectElement).value.split('|');
		formData.classRoomAddress = address;
		formData.classRoomNumber = roomNumber;

		console.log(formData);
	};

	const updateExam = async (dto: ExamUpdateDto) => {
		const token = Cookies.get('oktato-token');

		const result = await fetch(base + '/api/exams', {
			method: 'PATCH',
			headers: {
				Authorization: `Bearer ${token}`,
				'Content-Type': 'application/json'
			},
			body: JSON.stringify(dto)
		});

		if (result.status === 200) {
			return undefined;
		} else {
			const errorResponse = await result.json();
			const errorResponseDto = await ErrorResponseDtoSchema.safeParseAsync(errorResponse);
			if (errorResponseDto.success) {
				return errorResponseDto.data.errorMessage;
			} else {
				return 'Ismeretlen hiba történt!';
			}
		}
	};

	const handleSubmit = async () => {
		errors = {
			_errors: []
		};
		const test = await ExamUpdateDtoSchema.safeParseAsync(formData);

		if (test.success) {
			const loginResult = await updateExam(formData);
			if (loginResult !== undefined) {
				errors._errors = [loginResult];
			} else {
				toast.push('Vizsga sikeresen létrehozva!');
			}
		} else {
			errors = test.error.format();
		}
	};

	const closeError = (type: keyof typeof errors) => {
		if (type === '_errors') {
			errors._errors = [];
		} else {
			errors[type] = undefined;
		}
	};
</script>

<div class="container">
	<h3>Vizsga szerkesztése</h3>

	<form method="get" on:submit|preventDefault={handleSubmit}>
		<div class="form-group text-center">
			<h4>{formData.courseCode} (Félév: {formData.courseSemester})</h4>
			<p>
				Kezdet: {formData.originalStart}
			</p>
		</div>
		<div class="form-group">
			<label for="courseTypeInput">Vizsga típusa</label>
			<select id="courseTypeInput" class="input-block" bind:value={formData.examType}>
				{#each Object.keys(ExamType) as examType}
					{#if !isNaN(Number(examType))}
						<option value={Number(examType)}>{ExamTypeToName(Number(examType))}</option>
					{/if}
				{/each}
			</select>
			{#if errors?.examType}
				<div id="login-alert" class="alert alert-danger dismissible">
					{errors.examType._errors[0]}
					<butto class="btn-close" for="login-alert" on:click={() => closeError('examType')}
						>X</butto
					>
				</div>
			{/if}
		</div>
		<div class="form-group">
			<label for="classRoomInput">Terem</label>
			<select
				id="classRoomInput"
				class="input-block"
				bind:value={classroomAddressAndRoomNumber}
				on:change={handleClassroomChange}
			>
				{#each classRooms as classroom}
					<option value={`${classroom.address}|${classroom.roomNumber}`}>
						{classroom.name} (Kapacitás: {classroom.capacity})
					</option>
				{/each}
			</select>
			{#if errors?.classRoomAddress}
				<div id="login-alert" class="alert alert-danger dismissible">
					{errors.classRoomAddress._errors[0]}
					<butto class="btn-close" for="login-alert" on:click={() => closeError('classRoomAddress')}
						>X</butto
					>
				</div>
			{/if}
			{#if errors?.classRoomNumber}
				<div id="login-alert" class="alert alert-danger dismissible">
					{errors.classRoomNumber._errors[0]}
					<butto class="btn-close" for="login-alert" on:click={() => closeError('classRoomNumber')}
						>X</butto
					>
				</div>
			{/if}
		</div>
		<div class="form-group">
			<label for="endDateInput">Vizsga vége</label>
			<input
				type="datetime-local"
				id="endDateInput"
				class="input-block"
				bind:value={formData.end}
			/>
			{#if errors?.end}
				<div id="login-alert" class="alert alert-danger dismissible">
					{errors.end._errors[0]}
					<butto class="btn-close" for="login-alert" on:click={() => closeError('end')}>X</butto>
				</div>
			{/if}
		</div>
		{#if errors._errors.length > 0}
			<div id="login-alert" class="alert alert-danger dismissible">
				{errors._errors[0]}
				<label class="btn-close" for="login-alert" on:click={() => closeError('_errors')}>X</label>
			</div>
		{/if}
		<div id="form-controls">
			<button type="submit" class="btn-primary">Mentés</button>
		</div>
	</form>
</div>

<style>
	h3 {
		text-align: center;
		margin-top: 15px;
	}

	#form-controls {
		display: flex;
		justify-content: end;
	}
</style>
