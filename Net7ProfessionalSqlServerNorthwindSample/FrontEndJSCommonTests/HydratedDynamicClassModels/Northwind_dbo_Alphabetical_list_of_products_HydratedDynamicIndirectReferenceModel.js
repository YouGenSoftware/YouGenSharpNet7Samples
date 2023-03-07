/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307200541 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Professional Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
function getHydratedDynamicNorthwind_dbo_Alphabetical_list_of_products(fillPrimaryKey = false) {
	let retObj = new Northwind_dbo_Alphabetical_list_of_products_IR();
	retObj.ProductID_IR = (fillPrimaryKey ? encrypt(1) : null);
	retObj.ProductName = generateString(40);
	retObj.SupplierID_IR = (fillPrimaryKey ? encrypt(1) : null);
	retObj.CategoryID_IR = (fillPrimaryKey ? encrypt(1) : null);
	retObj.QuantityPerUnit = generateString(20);
	retObj.UnitPrice = generateDecimal(19,4);
	retObj.UnitsInStock = generateInt16();
	retObj.UnitsOnOrder = generateInt16();
	retObj.ReorderLevel = generateInt16();
	retObj.Discontinued = generateBoolean();
	retObj.CategoryName = generateString(15);
	return retObj;
}