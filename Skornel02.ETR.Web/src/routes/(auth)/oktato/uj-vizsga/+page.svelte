<script lang="ts">
	import type { ZodFormattedError } from 'zod';
	import { ExamType, ExamTypeToName } from '../../../../enums/examtypes';
	import { ExamCreationDtoSchema, type ExamCreationDto } from '../../../../schemas/ExamCreationDto';
	import type { PageData } from './$types';
	import { toast } from '@zerodevx/svelte-toast';
	import Cookies from 'js-cookie';
	import { base } from '$app/paths';
	import { ErrorResponseDtoSchema } from '../../../../schemas/ErrorResponseDto';
	import { onMount } from 'svelte';
	import { page } from '$app/stores';

	export let data: PageData;

	const { classRooms, courses } = data;

	let courseCodeAndSemester = `${courses[0]?.courseCode}|${courses[0]?.courseSemester}`;
	let classroomAddressAndRoomNumber = `${classRooms[0]?.address}|${classRooms[0]?.roomNumber}`;

	const formData: ExamCreationDto = {
		courseCode: courses[0]?.courseCode,
		courseSemester: courses[0]?.courseSemester,
		start: new Date().toISOString().slice(0, 16),
		end: new Date(new Date().getTime() + 1000 * 3600).toISOString().slice(0, 16),
		examType: ExamType.Online,
		classRoomAddress: classRooms[0]?.address,
		classRoomNumber: classRooms[0]?.roomNumber
	};

	onMount(() => {
		const course = $page.url.searchParams.get('course');
		if (course) {
			courseCodeAndSemester = course;
			formData.courseCode = course.split('|')[0];
			formData.courseSemester = course.split('|')[1];
		}
	});

	let errors: ZodFormattedError<ExamCreationDto> = {
		_errors: []
	};

	const handleClassroomChange = (event: Event) => {
		const [address, roomNumber] = (event.target as HTMLSelectElement).value.split('|');
		formData.classRoomAddress = address;
		formData.classRoomNumber = roomNumber;

		console.log(formData);
	};

	const handleCourseChange = (event: Event) => {
		const [courseCode, courseSemester] = (event.target as HTMLSelectElement).value.split('|');
		formData.courseCode = courseCode;
		formData.courseSemester = courseSemester;

		console.log(formData);
	};

	const createExam = async (dto: ExamCreationDto) => {
		const token = Cookies.get('oktato-token');

		const result = await fetch(base + '/api/exams', {
			method: 'POST',
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
		const test = await ExamCreationDtoSchema.safeParseAsync(formData);

		if (test.success) {
			const loginResult = await createExam(formData);
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
	<h3>Új vizsga létrehozása</h3>

	<form method="get" on:submit|preventDefault={handleSubmit}>
		<div class="form-group">
			<label for="classRoomInput">Kurzus</label>
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
			{#if errors?.courseCode}
				<div id="login-alert" class="alert alert-danger dismissible">
					{errors.courseCode._errors[0]}
					<butto class="btn-close" for="login-alert" on:click={() => closeError('courseCode')}
						>X</butto
					>
				</div>
			{/if}
			{#if errors?.courseSemester}
				<div id="login-alert" class="alert alert-danger dismissible">
					{errors.courseSemester._errors[0]}
					<butto class="btn-close" for="login-alert" on:click={() => closeError('courseSemester')}
						>X</butto
					>
				</div>
			{/if}
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
			<label for="startDateInput">Vizsga kezdete</label>
			<input
				type="datetime-local"
				id="startDateInput"
				class="input-block"
				bind:value={formData.start}
			/>
			{#if errors?.start}
				<div id="login-alert" class="alert alert-danger dismissible">
					{errors.start._errors[0]}
					<butto class="btn-close" for="login-alert" on:click={() => closeError('start')}>X</butto>
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
			<button type="submit" class="btn-primary">Létrehozás</button>
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
