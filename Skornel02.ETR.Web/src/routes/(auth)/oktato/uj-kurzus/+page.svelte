<script lang="ts">
	import type { PageData } from './$types';
	import { roomTypeToName } from '../../../../enums/roomtypes';
	import {
		CourseCreationDtoSchema,
		type CourseCreationDto
	} from '../../../../schemas/CourseCreationDto';
	import { CourseType, CourseTypeToName } from '../../../../enums/coursetypes';
	import type { ZodFormattedError } from 'zod';
	import { toast } from '@zerodevx/svelte-toast';
	import {
		CourseMetadataResponseDtoSchema,
		type CourseMetadataResponseDto
	} from '../../../../schemas/CourseMetadataResponseDto';
	import Cookies from 'js-cookie';
	import { base } from '$app/paths';
	import { ErrorResponseDtoSchema } from '../../../../schemas/ErrorResponseDto';

	export let data: PageData;

	let courseMetadataLoading = false;
	let courseMetadataFound = false;

	const { classRooms } = data;

	let classroomAddressAndRoomNumber = `${classRooms[0]?.address}|${classRooms[0]?.roomNumber}`;

	const formData: CourseCreationDto = {
		courseCode: '',
		courseSemester: '',
		courseName: '',
		courseType: CourseType.Optional,
		credits: 0,
		hours: 0,
		classRoomAddress: classRooms[0]?.address,
		classRoomNumber: classRooms[0]?.roomNumber
	};

	let errors: ZodFormattedError<CourseCreationDto> = {
		_errors: []
	};

	const handleClassroomChange = (event: Event) => {
		const [address, roomNumber] = (event.target as HTMLSelectElement).value.split('|');
		formData.classRoomAddress = address;
		formData.classRoomNumber = roomNumber;

		console.log(formData);
	};

	const fetchCourseMetadata = async (
		courseCode: string
	): Promise<CourseMetadataResponseDto | undefined> => {
		const token = Cookies.get('oktato-token');

		const result = await fetch(base + '/api/courses/' + courseCode, {
			method: 'GET',
			headers: {
				Authorization: `Bearer ${token}`,
				'Content-Type': 'application/json'
			}
		});

		const response = await result.json();
		const classRooms = await CourseMetadataResponseDtoSchema.safeParseAsync(response);

		if (!classRooms.success) {
			return undefined;
		} else {
			return classRooms.data;
		}
	};

	const handleCourseCodeChange = async (event: Event) => {
		courseMetadataLoading = true;
		courseMetadataFound = false;

		try {
			const courseCode = (event.target as HTMLInputElement).value;
			const courseMetadata = await fetchCourseMetadata(courseCode);

			if (courseMetadata !== undefined) {
				courseMetadataFound = true;
				formData.courseName = courseMetadata.name;
				formData.courseType = courseMetadata.type;
			}
		} finally {
			courseMetadataLoading = false;
		}
	};

	const createCourse = async (dto: CourseCreationDto) => {
		const token = Cookies.get('oktato-token');

		const result = await fetch(base + '/api/courses', {
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
		const test = await CourseCreationDtoSchema.safeParseAsync(formData);

		if (test.success) {
			const loginResult = await createCourse(formData);
			if (loginResult !== undefined) {
				errors._errors = [loginResult];
			} else {
				toast.push('Kurzus sikeresen létrehozva!');
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
	<h3>Új kurzus létrehozása</h3>

	<form method="get" on:submit|preventDefault={handleSubmit}>
		<div class="form-group">
			<label for="courseCodeInput">Kurzus kódja</label>
			<input
				type="text"
				placeholder="db-101"
				id="courseCodeInput"
				class="input-block"
				bind:value={formData.courseCode}
				on:change={handleCourseCodeChange}
			/>
			{#if errors?.courseCode}
				<div id="login-alert" class="alert alert-danger dismissible">
					{errors.courseCode._errors[0]}
					<butto class="btn-close" for="login-alert" on:click={() => closeError('courseCode')}
						>X</butto
					>
				</div>
			{/if}
		</div>
		<div class="form-group">
			<label for="courseSemesterInput">Kurzus szemesztere</label>
			<input
				type="text"
				placeholder="2023/1"
				id="courseSemesterInput"
				class="input-block"
				bind:value={formData.courseSemester}
			/>
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
			<label for="courseNameInput">Kurzus neve</label>
			<input
				type="text"
				placeholder="Databázisok 1"
				id="courseNameInput"
				class="input-block"
				bind:value={formData.courseName}
				disabled={courseMetadataLoading || courseMetadataFound}
			/>
			{#if errors?.courseName}
				<div id="login-alert" class="alert alert-danger dismissible">
					{errors.courseName._errors[0]}
					<butto class="btn-close" for="login-alert" on:click={() => closeError('courseName')}
						>X</butto
					>
				</div>
			{/if}
		</div>
		<div class="form-group">
			<label for="courseTypeInput">Kurzus típusa</label>
			<select
				id="courseTypeInput"
				class="input-block"
				bind:value={formData.courseType}
				disabled={courseMetadataLoading || courseMetadataFound}
			>
				{#each Object.keys(CourseType) as courseType}
					{#if !isNaN(Number(courseType))}
						<option value={Number(courseType)}>{CourseTypeToName(Number(courseType))}</option>
					{/if}
				{/each}
			</select>
			{#if errors?.courseType}
				<div id="login-alert" class="alert alert-danger dismissible">
					{errors.courseType._errors[0]}
					<butto class="btn-close" for="login-alert" on:click={() => closeError('courseType')}
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
			<label for="creditsInput">Kredit</label>
			<input
				type="number"
				placeholder="5"
				id="creditsInput"
				class="input-block"
				bind:value={formData.credits}
			/>
			{#if errors?.credits}
				<div id="login-alert" class="alert alert-danger dismissible">
					{errors.credits._errors[0]}
					<butto class="btn-close" for="login-alert" on:click={() => closeError('credits')}>X</butto
					>
				</div>
			{/if}
		</div>
		<div class="form-group">
			<label for="hoursInput">Óraszám</label>
			<input
				type="number"
				placeholder="5"
				id="hoursInput"
				class="input-block"
				bind:value={formData.hours}
			/>
			{#if errors?.hours}
				<div id="login-alert" class="alert alert-danger dismissible">
					{errors.hours._errors[0]}
					<butto class="btn-close" for="login-alert" on:click={() => closeError('hours')}>X</butto>
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
