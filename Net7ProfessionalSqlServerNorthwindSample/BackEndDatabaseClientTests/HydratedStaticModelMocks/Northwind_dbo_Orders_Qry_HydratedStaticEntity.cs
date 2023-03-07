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
	public Northwind_dbo_Orders_Qry GetHydratedStaticNorthwind_dbo_Orders_Qry(Boolean fillPrimaryKey = false)
	{
		var retObj = new Northwind_dbo_Orders_Qry();
		retObj.OrderID = (1201816827);
		retObj.CustomerID = "rLuPx";
		retObj.EmployeeID = (1468189112);
		retObj.OrderDate = DateTime.Parse("10/1/2017 12:00:00 AM");
		retObj.RequiredDate = DateTime.Parse("2/20/2013 12:00:00 AM");
		retObj.ShippedDate = DateTime.Parse("5/20/2002 12:00:00 AM");
		retObj.ShipVia = (-123181996);
		retObj.Freight = (0.775528012613293M);
		retObj.ShipName = "VMMzpMO3g6zQFZ40ELtwDeqjkIAxGWYuGrjdmaAl";
		retObj.ShipAddress = "Oy8FC1Zzd58jWIUqRW0y HGy5ypYdBCHQs1qEJBft5DEU5IUqKh2jd4DlZID";
		retObj.ShipCity = "eEqn1vJABw0lrTA";
		retObj.ShipRegion = "N2H7EERhng3VVpo";
		retObj.ShipPostalCode = "91XoSPN7hq";
		retObj.ShipCountry = "qwC27AxBxuMP L1";
		retObj.CompanyName = "lddA5TlZkG4Pudl pTlNQnLuM1YBbKdBIZdJ9Ep3";
		retObj.Address = "E3 OYutflVRFPmR7zRTy7PBHj6rEAzIsUaNQohkU1wnIeu78rYUTgXmPHixn";
		retObj.City = "e6ejg9DWpBCqQUD";
		retObj.Region = "Jq4shUx2DuN56hV";
		retObj.PostalCode = "b79Fie5XKu";
		retObj.Country = "QIQ5MGqAJcKdK84";
		return retObj;
	}
}