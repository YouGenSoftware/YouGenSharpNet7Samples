/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307202958 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Enterprise Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
const controllerRoute = '/XE_HR_EMPLOYEES';
async function XE_HR_EMPLOYEES_IR_GetAll() {
	let config = {};
	config.baseURL = baseUrl_XE_HR + controllerRoute;
	config.url = 'GetAll';
	config.method = 'get';
	try {
		let response = await axios.request(config);
		// console.log(response);
		// process response
	} catch (error) {
		// console.log(error);
	}
}
async function XE_HR_EMPLOYEES_IR_GetByFIRST_NAMEAndLAST_NAME(FIRST_NAME,LAST_NAME) {
	let config = {};
	config.baseURL = baseUrl_XE_HR + controllerRoute;
	config.url = 'GetByFIRST_NAMEAndLAST_NAME?' + GetUriForParamsForFIRST_NAMEAndLAST_NAME(FIRST_NAME,LAST_NAME);
	config.method = 'get';
	try {
		let response = await axios.request(config);
		// console.log(response);
		// process response
	} catch (error) {
		// console.log(error);
	}
}
async function XE_HR_EMPLOYEES_IR_GetByDEPARTMENT_ID(DEPARTMENT_ID_IR) {
	let config = {};
	config.baseURL = baseUrl_XE_HR + controllerRoute;
	config.url = 'GetByDEPARTMENT_ID?' + GetUriForParamsForDEPARTMENT_ID(DEPARTMENT_ID_IR);
	config.method = 'get';
	try {
		let response = await axios.request(config);
		// console.log(response);
		// process response
	} catch (error) {
		// console.log(error);
	}
}
async function XE_HR_EMPLOYEES_IR_GetByEMAIL(EMAIL) {
	let config = {};
	config.baseURL = baseUrl_XE_HR + controllerRoute;
	config.url = 'GetByEMAIL?' + GetUriForParamsForEMAIL(EMAIL);
	config.method = 'get';
	try {
		let response = await axios.request(config);
		// console.log(response);
		// process response
	} catch (error) {
		// console.log(error);
	}
}
async function XE_HR_EMPLOYEES_IR_GetByEMPLOYEE_ID(EMPLOYEE_ID_IR) {
	let config = {};
	config.baseURL = baseUrl_XE_HR + controllerRoute;
	config.url = 'GetByEMPLOYEE_ID?' + GetUriForParamsForEMPLOYEE_ID(EMPLOYEE_ID_IR);
	config.method = 'get';
	try {
		let response = await axios.request(config);
		// console.log(response);
		// process response
	} catch (error) {
		// console.log(error);
	}
}
async function XE_HR_EMPLOYEES_IR_GetByJOB_ID(JOB_ID) {
	let config = {};
	config.baseURL = baseUrl_XE_HR + controllerRoute;
	config.url = 'GetByJOB_ID?' + GetUriForParamsForJOB_ID(JOB_ID);
	config.method = 'get';
	try {
		let response = await axios.request(config);
		// console.log(response);
		// process response
	} catch (error) {
		// console.log(error);
	}
}
async function XE_HR_EMPLOYEES_IR_GetByMANAGER_ID(MANAGER_ID_IR) {
	let config = {};
	config.baseURL = baseUrl_XE_HR + controllerRoute;
	config.url = 'GetByMANAGER_ID?' + GetUriForParamsForMANAGER_ID(MANAGER_ID_IR);
	config.method = 'get';
	try {
		let response = await axios.request(config);
		// console.log(response);
		// process response
	} catch (error) {
		// console.log(error);
	}
}
async function XE_HR_EMPLOYEES_IR_Create(input) {
	let config = {};
	config.baseURL = baseUrl_XE_HR + controllerRoute;
	config.url = 'Create';
	config.method = 'post';
	config.data = input;
	try {
		let response = await axios.request(config);
		// console.log(response);
		// process response
	} catch (error) {
		// console.log(error);
	}
}
async function XE_HR_EMPLOYEES_IR_UpdateByFIRST_NAMEAndLAST_NAME(FIRST_NAME,LAST_NAME,input) {
	let config = {};
	config.baseURL = baseUrl_XE_HR + controllerRoute;
	config.url = 'UpdateByFIRST_NAMEAndLAST_NAME?' + GetUriForParamsForFIRST_NAMEAndLAST_NAME(FIRST_NAME,LAST_NAME);
	config.method = 'put';
	config.data = input;
	try {
		let response = await axios.request(config);
		// console.log(response);
		// process response
	} catch (error) {
		// console.log(error);
	}
}
async function XE_HR_EMPLOYEES_IR_UpdateByDEPARTMENT_ID(DEPARTMENT_ID_IR,input) {
	let config = {};
	config.baseURL = baseUrl_XE_HR + controllerRoute;
	config.url = 'UpdateByDEPARTMENT_ID?' + GetUriForParamsForDEPARTMENT_ID(DEPARTMENT_ID_IR);
	config.method = 'put';
	config.data = input;
	try {
		let response = await axios.request(config);
		// console.log(response);
		// process response
	} catch (error) {
		// console.log(error);
	}
}
async function XE_HR_EMPLOYEES_IR_UpdateByEMAIL(EMAIL,input) {
	let config = {};
	config.baseURL = baseUrl_XE_HR + controllerRoute;
	config.url = 'UpdateByEMAIL?' + GetUriForParamsForEMAIL(EMAIL);
	config.method = 'put';
	config.data = input;
	try {
		let response = await axios.request(config);
		// console.log(response);
		// process response
	} catch (error) {
		// console.log(error);
	}
}
async function XE_HR_EMPLOYEES_IR_UpdateByEMPLOYEE_ID(EMPLOYEE_ID_IR,input) {
	let config = {};
	config.baseURL = baseUrl_XE_HR + controllerRoute;
	config.url = 'UpdateByEMPLOYEE_ID?' + GetUriForParamsForEMPLOYEE_ID(EMPLOYEE_ID_IR);
	config.method = 'put';
	config.data = input;
	try {
		let response = await axios.request(config);
		// console.log(response);
		// process response
	} catch (error) {
		// console.log(error);
	}
}
async function XE_HR_EMPLOYEES_IR_UpdateByJOB_ID(JOB_ID,input) {
	let config = {};
	config.baseURL = baseUrl_XE_HR + controllerRoute;
	config.url = 'UpdateByJOB_ID?' + GetUriForParamsForJOB_ID(JOB_ID);
	config.method = 'put';
	config.data = input;
	try {
		let response = await axios.request(config);
		// console.log(response);
		// process response
	} catch (error) {
		// console.log(error);
	}
}
async function XE_HR_EMPLOYEES_IR_UpdateByMANAGER_ID(MANAGER_ID_IR,input) {
	let config = {};
	config.baseURL = baseUrl_XE_HR + controllerRoute;
	config.url = 'UpdateByMANAGER_ID?' + GetUriForParamsForMANAGER_ID(MANAGER_ID_IR);
	config.method = 'put';
	config.data = input;
	try {
		let response = await axios.request(config);
		// console.log(response);
		// process response
	} catch (error) {
		// console.log(error);
	}
}
async function XE_HR_EMPLOYEES_IR_DeleteByFIRST_NAMEAndLAST_NAME(FIRST_NAME,LAST_NAME) {
	let config = {};
	config.baseURL = baseUrl_XE_HR + controllerRoute;
	config.url = 'DeleteByFIRST_NAMEAndLAST_NAME?' + GetUriForParamsForFIRST_NAMEAndLAST_NAME(FIRST_NAME,LAST_NAME);
	config.method = 'delete';
	try {
		let response = await axios.request(config);
		// console.log(response);
		// process response
	} catch (error) {
		// console.log(error);
	}
}
async function XE_HR_EMPLOYEES_IR_DeleteByDEPARTMENT_ID(DEPARTMENT_ID_IR) {
	let config = {};
	config.baseURL = baseUrl_XE_HR + controllerRoute;
	config.url = 'DeleteByDEPARTMENT_ID?' + GetUriForParamsForDEPARTMENT_ID(DEPARTMENT_ID_IR);
	config.method = 'delete';
	try {
		let response = await axios.request(config);
		// console.log(response);
		// process response
	} catch (error) {
		// console.log(error);
	}
}
async function XE_HR_EMPLOYEES_IR_DeleteByEMAIL(EMAIL) {
	let config = {};
	config.baseURL = baseUrl_XE_HR + controllerRoute;
	config.url = 'DeleteByEMAIL?' + GetUriForParamsForEMAIL(EMAIL);
	config.method = 'delete';
	try {
		let response = await axios.request(config);
		// console.log(response);
		// process response
	} catch (error) {
		// console.log(error);
	}
}
async function XE_HR_EMPLOYEES_IR_DeleteByEMPLOYEE_ID(EMPLOYEE_ID_IR) {
	let config = {};
	config.baseURL = baseUrl_XE_HR + controllerRoute;
	config.url = 'DeleteByEMPLOYEE_ID?' + GetUriForParamsForEMPLOYEE_ID(EMPLOYEE_ID_IR);
	config.method = 'delete';
	try {
		let response = await axios.request(config);
		// console.log(response);
		// process response
	} catch (error) {
		// console.log(error);
	}
}
async function XE_HR_EMPLOYEES_IR_DeleteByJOB_ID(JOB_ID) {
	let config = {};
	config.baseURL = baseUrl_XE_HR + controllerRoute;
	config.url = 'DeleteByJOB_ID?' + GetUriForParamsForJOB_ID(JOB_ID);
	config.method = 'delete';
	try {
		let response = await axios.request(config);
		// console.log(response);
		// process response
	} catch (error) {
		// console.log(error);
	}
}
async function XE_HR_EMPLOYEES_IR_DeleteByMANAGER_ID(MANAGER_ID_IR) {
	let config = {};
	config.baseURL = baseUrl_XE_HR + controllerRoute;
	config.url = 'DeleteByMANAGER_ID?' + GetUriForParamsForMANAGER_ID(MANAGER_ID_IR);
	config.method = 'delete';
	try {
		let response = await axios.request(config);
		// console.log(response);
		// process response
	} catch (error) {
		// console.log(error);
	}
}
function GetUriForParamsForFIRST_NAMEAndLAST_NAME(FIRST_NAME,LAST_NAME) {
	const urlParams = new URLSearchParams({
		"FIRST_NAME": FIRST_NAME,
		"LAST_NAME": LAST_NAME
	});
	return urlParams.toString();
}
function GetUriForParamsForDEPARTMENT_ID(DEPARTMENT_ID_IR) {
	const urlParams = new URLSearchParams({
		"DEPARTMENT_ID_IR": DEPARTMENT_ID_IR
	});
	return urlParams.toString();
}
function GetUriForParamsForEMAIL(EMAIL) {
	const urlParams = new URLSearchParams({
		"EMAIL": EMAIL
	});
	return urlParams.toString();
}
function GetUriForParamsForEMPLOYEE_ID(EMPLOYEE_ID_IR) {
	const urlParams = new URLSearchParams({
		"EMPLOYEE_ID_IR": EMPLOYEE_ID_IR
	});
	return urlParams.toString();
}
function GetUriForParamsForJOB_ID(JOB_ID) {
	const urlParams = new URLSearchParams({
		"JOB_ID": JOB_ID
	});
	return urlParams.toString();
}
function GetUriForParamsForMANAGER_ID(MANAGER_ID_IR) {
	const urlParams = new URLSearchParams({
		"MANAGER_ID_IR": MANAGER_ID_IR
	});
	return urlParams.toString();
}