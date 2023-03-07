/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307200636 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Enterprise Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
function getHydratedDynamicNorthwind_dbo_EmployeeTerritories(fillPrimaryKey = false) {
	let retObj = new Northwind_dbo_EmployeeTerritories_IR();
	retObj.EmployeeID_IR = (fillPrimaryKey ? encrypt(1) : null);
	retObj.TerritoryID = (fillPrimaryKey ? generateString(20) : null);
	// Foreign key entities
	retObj.FK_EmployeeTerritories_Employees_Ref_IR = getHydratedDynamicNorthwind_dbo_Employees_IR();
	retObj.FK_EmployeeTerritories_Territories_Ref_IR = getHydratedDynamicNorthwind_dbo_Territories_IR();
	return retObj;
}