/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307200541 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Professional Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
function getHydratedStaticNorthwind_dbo_Products(fillPrimaryKey = false) {
	let retObj = new Northwind_dbo_Products_IR();
	retObj.ProductID_IR = (fillPrimaryKey ? encrypt(1) : null);
	retObj.ProductName = 'sw39U9xRTbCEzrOSpAFi9 Bg0p4rQjVPAfb6yoLU';
	retObj.SupplierID_IR = encrypt(1);
	retObj.CategoryID_IR = encrypt(1);
	retObj.QuantityPerUnit = 'm6l1p6kNzoT444n qw O';
	retObj.UnitPrice = 0.2987930382946813;
	retObj.UnitsInStock = -2168;
	retObj.UnitsOnOrder = -2606;
	retObj.ReorderLevel = 12114;
	retObj.Discontinued = true;
	// Foreign key entities
	retObj.FK_Products_Categories_Ref_IR = getHydratedStaticNorthwind_dbo_Categories_IR();
	retObj.FK_Products_Suppliers_Ref_IR = getHydratedStaticNorthwind_dbo_Suppliers_IR();
	return retObj;
}
