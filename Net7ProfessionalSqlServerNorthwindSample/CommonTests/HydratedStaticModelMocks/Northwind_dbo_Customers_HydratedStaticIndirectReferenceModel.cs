/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307200541 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Professional Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
using System.ComponentModel;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Northwind_Common.IndirectReferenceTransformerModels;
using Northwind_BackEndSqlEntities.Entities;
using Northwind_BackEndCommon.Services;
namespace Northwind_CommonTests.HydratedStaticIndirectReferenceTransformerModels;
public partial class Northwind_HydratedStaticIndirectReferenceTransformerModels : Northwind_HydratedStaticIndirectReferenceTransformerModelsBase
{
	public Northwind_dbo_Customers_IR GetHydratedStaticNorthwind_dbo_Customers_IR(Boolean fillPrimaryKey = false)
	{
		var retObj = new Northwind_dbo_Customers_IR();
		retObj.CustomerID = (fillPrimaryKey ? "ZDgWC" : String.Empty);
		retObj.CompanyName = "iGOaNoILHrp1vKN1bSDr90LJHS5FfWFaWsHldodU";
		retObj.ContactName = "ttJFKr Ba695dSI402OBvemQG4Lx0b";
		retObj.ContactTitle = "CwerG Rbf68jwXWRMZZnF2GQYnSDrM";
		retObj.Address = "TQrSoNsznZ PK6rLLyB73rHGu82wboSyuMVkYKZsJh6lua3uAOn bzpPdqmO";
		retObj.City = "BCAUDdTfJ65IXWS";
		retObj.Region = "DCKMXEExinZYXTl";
		retObj.PostalCode = "K9NsaZcVV2";
		retObj.Country = "3GtVHbUqZDNFXXv";
		retObj.Phone = "7VWp1RIKu FD7bAwO7MBkHev";
		retObj.Fax = "SQPfearqwfDZtt6lEVHARKJf";
		return retObj;
	}
}
