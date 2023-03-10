/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307200541 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Professional Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
function getHydratedStaticNorthwind_dbo_Orders(fillPrimaryKey = false) {
	let retObj = new Northwind_dbo_Orders_IR();
	retObj.OrderID_IR = (fillPrimaryKey ? encrypt(1) : null);
	retObj.CustomerID = 'WcW12';
	retObj.EmployeeID_IR = encrypt(1);
	retObj.OrderDate = '/Date(2/17/2009 12:00:00 AM)/';
	retObj.RequiredDate = '/Date(8/28/1999 12:00:00 AM)/';
	retObj.ShippedDate = '/Date(9/23/2006 12:00:00 AM)/';
	retObj.ShipVia_IR = encrypt(1);
	retObj.Freight = 0.9195274934431852;
	retObj.ShipName = '2I5DakecBWgTaR5zmiaZvhyuacCBTrRvxE0gepJf';
	retObj.ShipAddress = 'eXFdkhk9iwTqdshpX04uFmbcAdQeOuHHiNHCSysB3CsY0BjDoPF5JfiigPi2';
	retObj.ShipCity = 'xd1mmiwDXoqlyez';
	retObj.ShipRegion = 'DLNh6QMEP Upegi';
	retObj.ShipPostalCode = 'rus12F7iuU';
	retObj.ShipCountry = 'YPiJEv2nsJYmNXt';
	// Foreign key entities
	retObj.FK_Orders_Customers_Ref_IR = getHydratedStaticNorthwind_dbo_Customers_IR();
	retObj.FK_Orders_Employees_Ref_IR = getHydratedStaticNorthwind_dbo_Employees_IR();
	retObj.FK_Orders_Shippers_Ref_IR = getHydratedStaticNorthwind_dbo_Shippers_IR();
	return retObj;
}
