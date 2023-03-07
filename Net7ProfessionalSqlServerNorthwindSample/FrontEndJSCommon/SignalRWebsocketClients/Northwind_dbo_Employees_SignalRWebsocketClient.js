/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307200541 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Professional Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
const url_Northwind_dbo_Employees = baseUrlSignalR_Northwind + '/Northwind_dbo_Employees_Hub';
const connection_Northwind_dbo_Employees = new signalR.HubConnectionBuilder()
	.withUrl(url_Northwind_dbo_Employees)
	.configureLogging(signalR.LogLevel.Information)
	.build();
async function Start_connection_Northwind_dbo_Employees() {
	try {
		await connection_Northwind_dbo_Employees.start();
		console.log('SignalR Connected to url:  ' + url_Northwind_dbo_Employees);
	} catch (error) {
		console.log(error);
		setTimeout(start_connection_Northwind_dbo_Employees(), 5000);
	}
}
async function Stop_connection_Northwind_dbo_Employees() {
	try {
		await connection_Northwind_dbo_Employees.stop();
		console.log('SignalR Disconnected from url:  ' + url_Northwind_dbo_Employees);
	} catch (error) {
		console.log(error);
	}
}
async function Northwind_dbo_Employees_IR_GetAll() {
	try {
		let response = await connection_Northwind_dbo_Employees.invoke('GetAll');
		// console.log(response);
		// process response
	} catch (error) {
		// console.log(error);
	}
}
async function Northwind_dbo_Employees_IR_GetByLastName(LastName) {
	try {
		let response = await connection_Northwind_dbo_Employees.invoke('GetByLastName',LastName);
		// console.log(response);
		// process response
	} catch (error) {
		// console.log(error);
	}
}
async function Northwind_dbo_Employees_IR_GetByEmployeeID(EmployeeID_IR) {
	try {
		let response = await connection_Northwind_dbo_Employees.invoke('GetByEmployeeID',EmployeeID_IR);
		// console.log(response);
		// process response
	} catch (error) {
		// console.log(error);
	}
}
async function Northwind_dbo_Employees_IR_GetByPostalCode(PostalCode) {
	try {
		let response = await connection_Northwind_dbo_Employees.invoke('GetByPostalCode',PostalCode);
		// console.log(response);
		// process response
	} catch (error) {
		// console.log(error);
	}
}
async function Northwind_dbo_Employees_IR_Create(input) {
	try {
		let response = await connection_Northwind_dbo_Employees.invoke('Create',input);
		// console.log(response);
		// process response
	} catch (error) {
		// console.log(error);
	}
}
async function Northwind_dbo_Employees_IR_UpdateByLastName(LastName,input) {
	try {
		await connection_Northwind_dbo_Employees.invoke('UpdateByLastName',LastName,input);
	} catch (error) {
		// console.log(error);
	}
}
async function Northwind_dbo_Employees_IR_UpdateByEmployeeID(EmployeeID_IR,input) {
	try {
		await connection_Northwind_dbo_Employees.invoke('UpdateByEmployeeID',EmployeeID_IR,input);
	} catch (error) {
		// console.log(error);
	}
}
async function Northwind_dbo_Employees_IR_UpdateByPostalCode(PostalCode,input) {
	try {
		await connection_Northwind_dbo_Employees.invoke('UpdateByPostalCode',PostalCode,input);
	} catch (error) {
		// console.log(error);
	}
}
async function Northwind_dbo_Employees_IR_DeleteByLastName(LastName) {
	try {
		await connection_Northwind_dbo_Employees.invoke('DeleteByLastName',LastName);
	} catch (error) {
		// console.log(error);
	}
}
async function Northwind_dbo_Employees_IR_DeleteByEmployeeID(EmployeeID_IR) {
	try {
		await connection_Northwind_dbo_Employees.invoke('DeleteByEmployeeID',EmployeeID_IR);
	} catch (error) {
		// console.log(error);
	}
}
async function Northwind_dbo_Employees_IR_DeleteByPostalCode(PostalCode) {
	try {
		await connection_Northwind_dbo_Employees.invoke('DeleteByPostalCode',PostalCode);
	} catch (error) {
		// console.log(error);
	}
}