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
	public Northwind_dbo_CustomerDemographics GetHydratedStaticNorthwind_dbo_CustomerDemographics(Boolean fillPrimaryKey = false)
	{
		var retObj = new Northwind_dbo_CustomerDemographics();
		retObj.CustomerTypeID = (fillPrimaryKey ? "BQbnkPDx27" : String.Empty);
		retObj.CustomerDesc = "IGFe22lBKE1wfz RvZWuZ1KlBujNb96Bdi72eNZ1floM5z19UUKB4jXuwHBaFtlQlZ3LtEb2FvJIlJwheDsq0AJv30k3ik2DYn1g";
		return retObj;
	}
}
