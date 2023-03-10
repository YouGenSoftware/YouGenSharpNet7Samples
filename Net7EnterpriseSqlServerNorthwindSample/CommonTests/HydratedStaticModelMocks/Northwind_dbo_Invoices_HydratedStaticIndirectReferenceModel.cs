/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307200636 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Enterprise Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
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
	public Northwind_dbo_Invoices_IR GetHydratedStaticNorthwind_dbo_Invoices_IR(Boolean fillPrimaryKey = false)
	{
		var retObj = new Northwind_dbo_Invoices_IR();
		retObj.ShipName = "7rO38FczVK9IXz7xins0a7GO61OlxHAyDesp5aVo";
		retObj.ShipAddress = "hWaFzOhhW2mgSGIEUU3Vd1t6HOHRDykEhElfYQf8fZsfDzQx4vW0HmF3chaQ";
		retObj.ShipCity = "t7LsrhCVfRGdwhA";
		retObj.ShipRegion = "5sFLKdqHhm7Uiw5";
		retObj.ShipPostalCode = "i8K01iySUs";
		retObj.ShipCountry = "87EIx72u0PJDJig";
		retObj.CustomerID = (fillPrimaryKey ? "25S0M" : String.Empty);
		retObj.CustomerName = "sFBqIfVFXkQNCefpqQCNmJyKe7noCW9YytOkkzqq";
		retObj.Address = "WC2TuAhIsBSMd0AB550KgAukVq2VEJJ3LeHAHdrfQiaY2l6 3dabEYIA TWz";
		retObj.City = "O7p1vLCaet1RzgG";
		retObj.Region = "4hBuV3yERPv 5mY";
		retObj.PostalCode = "Eu7t36Xg9J";
		retObj.Country = "uSWcnZsrGKRpXEh";
		retObj.Salesperson = "rj JHoo6HqEzcr1pzTaZT1fuVLrqGA3";
		retObj.OrderID_IR = (fillPrimaryKey ? _encryptionDecryptionService!.EncInt32(Convert.ToInt32(1)) : String.Empty);
		retObj.OrderDate = DateTime.Parse("8/25/2012 12:00:00 AM");
		retObj.RequiredDate = DateTime.Parse("4/19/2000 12:00:00 AM");
		retObj.ShippedDate = DateTime.Parse("4/1/1998 12:00:00 AM");
		retObj.ShipperName = "R3cJWvuMIiIOvdV18ZCekODNtcS3PTXif 2CSDyb";
		retObj.ProductID_IR = (fillPrimaryKey ? _encryptionDecryptionService!.EncInt32(Convert.ToInt32(1)) : String.Empty);
		retObj.ProductName = "bcQik5iBWbr0MhBzV3AglXZulmIX6b2wmtPYgYND";
		retObj.UnitPrice = (0.7006624042241535M);
		retObj.Quantity = (21871);
		retObj.Discount = (0.1721654F);
		retObj.ExtendedPrice = (0.44437735503038867M);
		retObj.Freight = (0.5612442424123566M);
		return retObj;
	}
}
