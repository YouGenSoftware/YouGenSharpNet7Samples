/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307200636 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Enterprise Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
using Microsoft.EntityFrameworkCore;
using Northwind_BackEndSqlEntities.Entities;
namespace Northwind_BackEndDatabaseClientTests.HydratedStaticEntities;
public partial class Northwind_HydratedStaticEntities 
{
	public Northwind_dbo_Shippers GetHydratedStaticNorthwind_dbo_Shippers(Boolean fillPrimaryKey = false)
	{
		var retObj = new Northwind_dbo_Shippers();
		retObj.ShipperID = (fillPrimaryKey ? Convert.ToInt32(1) : 0);
		retObj.CompanyName = " fYfehdjRCact05vOFMGBLAsDx59ClZcrU5DsNnZ";
		retObj.Phone = "Fcrxp7ezn1H4enE2OB4748kM";
		return retObj;
	}
}
