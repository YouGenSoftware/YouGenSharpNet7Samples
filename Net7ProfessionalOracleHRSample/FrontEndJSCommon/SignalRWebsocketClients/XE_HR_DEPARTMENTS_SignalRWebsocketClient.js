/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307202926 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Professional Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
const url_XE_HR_DEPARTMENTS = baseUrlSignalR_XE_HR + '/XE_HR_DEPARTMENTS_Hub';
const connection_XE_HR_DEPARTMENTS = new signalR.HubConnectionBuilder()
	.withUrl(url_XE_HR_DEPARTMENTS)
	.configureLogging(signalR.LogLevel.Information)
	.build();
async function Start_connection_XE_HR_DEPARTMENTS() {
	try {
		await connection_XE_HR_DEPARTMENTS.start();
		console.log('SignalR Connected to url:  ' + url_XE_HR_DEPARTMENTS);
	} catch (error) {
		console.log(error);
		setTimeout(start_connection_XE_HR_DEPARTMENTS(), 5000);
	}
}
async function Stop_connection_XE_HR_DEPARTMENTS() {
	try {
		await connection_XE_HR_DEPARTMENTS.stop();
		console.log('SignalR Disconnected from url:  ' + url_XE_HR_DEPARTMENTS);
	} catch (error) {
		console.log(error);
	}
}
async function XE_HR_DEPARTMENTS_IR_GetAll() {
	try {
		let response = await connection_XE_HR_DEPARTMENTS.invoke('GetAll');
		// console.log(response);
		// process response
	} catch (error) {
		// console.log(error);
	}
}
async function XE_HR_DEPARTMENTS_IR_GetByDEPARTMENT_ID(DEPARTMENT_ID_IR) {
	try {
		let response = await connection_XE_HR_DEPARTMENTS.invoke('GetByDEPARTMENT_ID',DEPARTMENT_ID_IR);
		// console.log(response);
		// process response
	} catch (error) {
		// console.log(error);
	}
}
async function XE_HR_DEPARTMENTS_IR_GetByLOCATION_ID(LOCATION_ID_IR) {
	try {
		let response = await connection_XE_HR_DEPARTMENTS.invoke('GetByLOCATION_ID',LOCATION_ID_IR);
		// console.log(response);
		// process response
	} catch (error) {
		// console.log(error);
	}
}
async function XE_HR_DEPARTMENTS_IR_Create(input) {
	try {
		let response = await connection_XE_HR_DEPARTMENTS.invoke('Create',input);
		// console.log(response);
		// process response
	} catch (error) {
		// console.log(error);
	}
}
async function XE_HR_DEPARTMENTS_IR_UpdateByDEPARTMENT_ID(DEPARTMENT_ID_IR,input) {
	try {
		await connection_XE_HR_DEPARTMENTS.invoke('UpdateByDEPARTMENT_ID',DEPARTMENT_ID_IR,input);
	} catch (error) {
		// console.log(error);
	}
}
async function XE_HR_DEPARTMENTS_IR_UpdateByLOCATION_ID(LOCATION_ID_IR,input) {
	try {
		await connection_XE_HR_DEPARTMENTS.invoke('UpdateByLOCATION_ID',LOCATION_ID_IR,input);
	} catch (error) {
		// console.log(error);
	}
}
async function XE_HR_DEPARTMENTS_IR_DeleteByDEPARTMENT_ID(DEPARTMENT_ID_IR) {
	try {
		await connection_XE_HR_DEPARTMENTS.invoke('DeleteByDEPARTMENT_ID',DEPARTMENT_ID_IR);
	} catch (error) {
		// console.log(error);
	}
}
async function XE_HR_DEPARTMENTS_IR_DeleteByLOCATION_ID(LOCATION_ID_IR) {
	try {
		await connection_XE_HR_DEPARTMENTS.invoke('DeleteByLOCATION_ID',LOCATION_ID_IR);
	} catch (error) {
		// console.log(error);
	}
}
