<script lang="ts">
	import type { ZodFormattedError } from 'zod';
	import {
		UserCreationFormSchema,
		type UserCreationDto,
		type UserCreationForm,
		userCreationFormToDto
	} from '../schemas/UserCreationDto';

	export let registerHandler: (request: UserCreationDto) => Promise<UserCreationResult>;

	/**
	 * Milyen üzenettel ment végbe az eredmény.
	 * Hiba történt-e
	 */
	type UserCreationResult = [string, boolean];

	const formData: UserCreationForm = {
		username: '',
		password: '',
		passwordRepeat: '',
		name: '',
		birthDate: new Date().toISOString().split('T')[0] as unknown as Date,
		birthLocation: '',
		roles: {
			student: false,
			teacher: false
		}
	};

	let errors: ZodFormattedError<UserCreationForm> = {
		_errors: []
	};

	let success: string | undefined = undefined;

	const handleSubmit = async () => {
		errors = {
			_errors: []
		};
		success = undefined;
		const test = await UserCreationFormSchema.safeParseAsync(formData);

		if (test.success) {
			const dto = userCreationFormToDto(formData);
			const [registrationResult, registrationFailed] = await registerHandler(dto);
			if (registrationFailed) {
				errors._errors = [registrationResult];
			} else {
				success = registrationResult;
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

<form method="get" on:submit|preventDefault={handleSubmit}>
	<div class="form-group">
		<label for="usernameInput">Felhasználó név</label>
		<input
			type="text"
			placeholder="ABCEFG"
			id="usernameInput"
			name="username"
			class="input-block"
			bind:value={formData.username}
		/>
		{#if errors?.username}
			<div id="login-alert" class="alert alert-danger dismissible">
				{errors.username._errors[0]}
				<butto class="btn-close" for="login-alert" on:click={() => closeError('username')}>X</butto>
			</div>
		{/if}
	</div>
	<div class="form-group">
		<label for="passwordInput">Jelszó</label>
		<input
			type="password"
			id="passwordInput"
			name="password"
			class="input-block"
			bind:value={formData.password}
		/>
		{#if errors?.password}
			<div id="login-alert" class="alert alert-danger dismissible">
				{errors.password._errors[0]}
				<butto class="btn-close" for="login-alert" on:click={() => closeError('password')}>X</butto>
			</div>
		{/if}
	</div>
	<div class="form-group">
		<label for="passwordRepeatInput">Jelszó újra</label>
		<input
			type="password"
			id="passwordRepeatInput"
			name="passwordRepeat"
			class="input-block"
			bind:value={formData.passwordRepeat}
		/>
		{#if errors?.passwordRepeat}
			<div id="login-alert" class="alert alert-danger dismissible">
				{errors.passwordRepeat._errors[0]}
				<butto class="btn-close" for="login-alert" on:click={() => closeError('passwordRepeat')}
					>X</butto
				>
			</div>
		{/if}
	</div>
	<hr />
	<div class="form-group">
		<label for="nameInput">Természetes név</label>
		<input type="text" id="nameInput" name="name" class="input-block" bind:value={formData.name} />
		{#if errors?.name}
			<div id="login-alert" class="alert alert-danger dismissible">
				{errors.name._errors[0]}
				<butto class="btn-close" for="login-alert" on:click={() => closeError('name')}>X</butto>
			</div>
		{/if}
	</div>
	<div class="form-group">
		<label for="birthLocationInput">Születési hely</label>
		<input
			type="text"
			id="birthLocationInput"
			name="birthLocation"
			class="input-block"
			bind:value={formData.birthLocation}
		/>
		{#if errors?.birthLocation}
			<div id="login-alert" class="alert alert-danger dismissible">
				{errors.birthLocation._errors[0]}
				<butto class="btn-close" for="login-alert" on:click={() => closeError('birthLocation')}
					>X</butto
				>
			</div>
		{/if}
	</div>
	<div class="form-group">
		<label for="birthDateInput">Születési idő</label>
		<input
			type="date"
			id="birthDateInput"
			name="birthDate"
			class="input-block"
			bind:value={formData.birthDate}
		/>
		{#if errors?.birthDate}
			<div id="login-alert" class="alert alert-danger dismissible">
				{errors.birthDate._errors[0]}
				<butto class="btn-close" for="login-alert" on:click={() => closeError('birthDate')}>X</butto
				>
			</div>
		{/if}
	</div>
	<hr />
	<div class="form-group">
		<legend>Engedélykörök</legend>
		<label for="hallgatoCheckInput" class="paper-check">
			<input
				type="checkbox"
				name="roleCheck"
				value="hallgatoRole"
				id="hallgatoCheckInput"
				bind:checked={formData.roles.student}
			/>
			<span>Hallgató</span>
		</label>
		<label for="oktatoCheckInput" class="paper-check">
			<input
				type="checkbox"
				name="roleCheck"
				value="oktatoRole"
				id="oktatoCheckInput"
				bind:checked={formData.roles.teacher}
			/>
			<span>Oktató</span>
		</label>

		{#if errors?.roles}
			<div id="login-alert" class="alert alert-danger dismissible">
				{errors.roles._errors[0]}
				<butto class="btn-close" for="login-alert" on:click={() => closeError('roles')}>X</butto>
			</div>
		{/if}
	</div>
	{#if errors._errors.length > 0}
		<div id="login-alert" class="alert alert-danger dismissible">
			{errors._errors[0]}
			<label class="btn-close" for="login-alert" on:click={() => closeError('_errors')}>X</label>
		</div>
	{/if}
	{#if success !== undefined}
		<div id="login-success" class="alert alert-success dismissible">
			{success}
		</div>
	{/if}
	<div id="form-controls">
		<button type="submit" class="btn-primary">Regisztráció</button>
	</div>
</form>

<style>
	#form-controls {
		display: flex;
		justify-content: end;
	}
</style>
