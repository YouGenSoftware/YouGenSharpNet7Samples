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
	public Northwind_dbo_Sales_Totals_by_Amount GetHydratedStaticNorthwind_dbo_Sales_Totals_by_Amount(Boolean fillPrimaryKey = false)
	{
		var retObj = new Northwind_dbo_Sales_Totals_by_Amount();
		retObj.SaleAmount = (0.3354120450464887M);
		retObj.OrderID = (-420670075);
		retObj.CompanyName = "lY5DH5VtyGk 9uB9F177 xNpcPSfyRtRQvBaZmD5";
		retObj.ShippedDate = DateTime.Parse("1/24/2012 12:00:00 AM");
		return retObj;
	}
}