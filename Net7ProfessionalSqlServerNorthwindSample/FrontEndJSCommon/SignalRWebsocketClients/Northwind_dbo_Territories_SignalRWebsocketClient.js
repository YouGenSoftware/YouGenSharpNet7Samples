/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307200541 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Professional Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
const url_Northwind_dbo_Territories = baseUrlSignalR_Northwind + '/Northwind_dbo_Territories_Hub';
const connection_Northwind_dbo_Territories = new signalR.HubConnectionBuilder()
	.withUrl(url_Northwind_dbo_Territories)
	.configureLogging(signalR.LogLevel.Information)
	.build();
async function Start_connection_Northwind_dbo_Territories() {
	try {
		await connection_Northwind_dbo_Territories.start();
		console.log('SignalR Connected to url:  ' + url_Northwind_dbo_Territories);
	} catch (error) {
		console.log(error);
		setTimeout(start_connection_Northwind_dbo_Territories(), 5000);
	}
}
async function Stop_connection_Northwind_dbo_Territories() {
	try {
		await connection_Northwind_dbo_Territories.stop();
		console.log('SignalR Disconnected from url:  ' + url_Northwind_dbo_Territories);
	} catch (error) {
		console.log(error);
	}
}
async function Northwind_dbo_Territories_IR_GetAll() {
	try {
		let response = await connection_Northwind_dbo_Territories.invoke('GetAll');
		// console.log(response);
		// process response
	} catch (error) {
		// console.log(error);
	}
}
async function Northwind_dbo_Territories_IR_GetByTerritoryID(TerritoryID) {
	try {
		let response = await connection_Northwind_dbo_Territories.invoke('GetByTerritoryID',TerritoryID);
		// console.log(response);
		// process response
	} catch (error) {
		// console.log(error);
	}
}
async function Northwind_dbo_Territories_IR_Create(input) {
	try {
		let response = await connection_Northwind_dbo_Territories.invoke('Create',input);
		// console.log(response);
		// process response
	} catch (error) {
		// console.log(error);
	}
}
async function Northwind_dbo_Territories_IR_UpdateByTerritoryID(TerritoryID,input) {
	try {
		await connection_Northwind_dbo_Territories.invoke('UpdateByTerritoryID',TerritoryID,input);
	} catch (error) {
		// console.log(error);
	}
}
async function Northwind_dbo_Territories_IR_DeleteByTerritoryID(TerritoryID) {
	try {
		await connection_Northwind_dbo_Territories.invoke('DeleteByTerritoryID',TerritoryID);
	} catch (error) {
		// console.log(error);
	}
}
