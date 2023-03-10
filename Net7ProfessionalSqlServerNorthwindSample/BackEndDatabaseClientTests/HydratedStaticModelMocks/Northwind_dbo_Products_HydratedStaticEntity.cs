/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307200541 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Professional Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
using Microsoft.EntityFrameworkCore;
using Northwind_BackEndSqlEntities.Entities;
namespace Northwind_BackEndDatabaseClientTests.HydratedStaticEntities;
public partial class Northwind_HydratedStaticEntities 
{
	public Northwind_dbo_Products GetHydratedStaticNorthwind_dbo_Products(Boolean fillPrimaryKey = false)
	{
		var retObj = new Northwind_dbo_Products();
		retObj.ProductID = (fillPrimaryKey ? Convert.ToInt32(1) : 0);
		retObj.ProductName = "SxwM0zJkpdyO7ow8KCrRkQNDeVTGiwjWsBd9tCQo";
		retObj.SupplierID = Convert.ToInt32(1);
		retObj.CategoryID = Convert.ToInt32(1);
		retObj.QuantityPerUnit = "aRj7U3l9YvpMiJzgA0hM";
		retObj.UnitPrice = (0.7232382522769683M);
		retObj.UnitsInStock = (-20472);
		retObj.UnitsOnOrder = (27465);
		retObj.ReorderLevel = (-5264);
		retObj.Discontinued = (false);
		// Foreign key entities
		retObj.FK_Products_Categories_Ref = GetHydratedStaticNorthwind_dbo_Categories();
		retObj.FK_Products_Suppliers_Ref = GetHydratedStaticNorthwind_dbo_Suppliers();
		return retObj;
	}
}
