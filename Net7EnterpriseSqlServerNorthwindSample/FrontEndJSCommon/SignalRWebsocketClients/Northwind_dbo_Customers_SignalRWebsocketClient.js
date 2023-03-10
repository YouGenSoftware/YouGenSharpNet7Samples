/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307200636 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Enterprise Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
const url_Northwind_dbo_Customers = baseUrlSignalR_Northwind + '/Northwind_dbo_Customers_Hub';
const connection_Northwind_dbo_Customers = new signalR.HubConnectionBuilder()
	.withUrl(url_Northwind_dbo_Customers)
	.configureLogging(signalR.LogLevel.Information)
	.build();
async function Start_connection_Northwind_dbo_Customers() {
	try {
		await connection_Northwind_dbo_Customers.start();
		console.log('SignalR Connected to url:  ' + url_Northwind_dbo_Customers);
	} catch (error) {
		console.log(error);
		setTimeout(start_connection_Northwind_dbo_Customers(), 5000);
	}
}
async function Stop_connection_Northwind_dbo_Customers() {
	try {
		await connection_Northwind_dbo_Customers.stop();
		console.log('SignalR Disconnected from url:  ' + url_Northwind_dbo_Customers);
	} catch (error) {
		console.log(error);
	}
}
async function Northwind_dbo_Customers_IR_GetAll() {
	try {
		let response = await connection_Northwind_dbo_Customers.invoke('GetAll');
		// console.log(response);
		// process response
	} catch (error) {
		// console.log(error);
	}
}
async function Northwind_dbo_Customers_IR_GetByCity(City) {
	try {
		let response = await connection_Northwind_dbo_Customers.invoke('GetByCity',City);
		// console.log(response);
		// process response
	} catch (error) {
		// console.log(error);
	}
}
async function Northwind_dbo_Customers_IR_GetByCompanyName(CompanyName) {
	try {
		let response = await connection_Northwind_dbo_Customers.invoke('GetByCompanyName',CompanyName);
		// console.log(response);
		// process response
	} catch (error) {
		// console.log(error);
	}
}
async function Northwind_dbo_Customers_IR_GetByCustomerID(CustomerID) {
	try {
		let response = await connection_Northwind_dbo_Customers.invoke('GetByCustomerID',CustomerID);
		// console.log(response);
		// process response
	} catch (error) {
		// console.log(error);
	}
}
async function Northwind_dbo_Customers_IR_GetByPostalCode(PostalCode) {
	try {
		let response = await connection_Northwind_dbo_Customers.invoke('GetByPostalCode',PostalCode);
		// console.log(response);
		// process response
	} catch (error) {
		// console.log(error);
	}
}
async function Northwind_dbo_Customers_IR_GetByRegion(Region) {
	try {
		let response = await connection_Northwind_dbo_Customers.invoke('GetByRegion',Region);
		// console.log(response);
		// process response
	} catch (error) {
		// console.log(error);
	}
}
async function Northwind_dbo_Customers_IR_Create(input) {
	try {
		let response = await connection_Northwind_dbo_Customers.invoke('Create',input);
		// console.log(response);
		// process response
	} catch (error) {
		// console.log(error);
	}
}
async function Northwind_dbo_Customers_IR_UpdateByCity(City,input) {
	try {
		await connection_Northwind_dbo_Customers.invoke('UpdateByCity',City,input);
	} catch (error) {
		// console.log(error);
	}
}
async function Northwind_dbo_Customers_IR_UpdateByCompanyName(CompanyName,input) {
	try {
		await connection_Northwind_dbo_Customers.invoke('UpdateByCompanyName',CompanyName,input);
	} catch (error) {
		// console.log(error);
	}
}
async function Northwind_dbo_Customers_IR_UpdateByCustomerID(CustomerID,input) {
	try {
		await connection_Northwind_dbo_Customers.invoke('UpdateByCustomerID',CustomerID,input);
	} catch (error) {
		// console.log(error);
	}
}
async function Northwind_dbo_Customers_IR_UpdateByPostalCode(PostalCode,input) {
	try {
		await connection_Northwind_dbo_Customers.invoke('UpdateByPostalCode',PostalCode,input);
	} catch (error) {
		// console.log(error);
	}
}
async function Northwind_dbo_Customers_IR_UpdateByRegion(Region,input) {
	try {
		await connection_Northwind_dbo_Customers.invoke('UpdateByRegion',Region,input);
	} catch (error) {
		// console.log(error);
	}
}
async function Northwind_dbo_Customers_IR_DeleteByCity(City) {
	try {
		await connection_Northwind_dbo_Customers.invoke('DeleteByCity',City);
	} catch (error) {
		// console.log(error);
	}
}
async function Northwind_dbo_Customers_IR_DeleteByCompanyName(CompanyName) {
	try {
		await connection_Northwind_dbo_Customers.invoke('DeleteByCompanyName',CompanyName);
	} catch (error) {
		// console.log(error);
	}
}
async function Northwind_dbo_Customers_IR_DeleteByCustomerID(CustomerID) {
	try {
		await connection_Northwind_dbo_Customers.invoke('DeleteByCustomerID',CustomerID);
	} catch (error) {
		// console.log(error);
	}
}
async function Northwind_dbo_Customers_IR_DeleteByPostalCode(PostalCode) {
	try {
		await connection_Northwind_dbo_Customers.invoke('DeleteByPostalCode',PostalCode);
	} catch (error) {
		// console.log(error);
	}
}
async function Northwind_dbo_Customers_IR_DeleteByRegion(Region) {
	try {
		await connection_Northwind_dbo_Customers.invoke('DeleteByRegion',Region);
	} catch (error) {
		// console.log(error);
	}
}
