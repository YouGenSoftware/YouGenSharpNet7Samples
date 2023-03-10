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
	public Northwind_dbo_Employees_IR GetHydratedStaticNorthwind_dbo_Employees_IR(Boolean fillPrimaryKey = false)
	{
		var retObj = new Northwind_dbo_Employees_IR();
		retObj.EmployeeID_IR = (fillPrimaryKey ? _encryptionDecryptionService!.EncInt32(Convert.ToInt32(1)) : String.Empty);
		retObj.LastName = "PiUfdTWrMscxfZ6h8sB8";
		retObj.FirstName = "gl9SYwI0vg";
		retObj.Title = "Gk2qVfcX0xUgjRcFTj IwoJN2DQzCH";
		retObj.TitleOfCourtesy = "gL5t13lgZ4FsCgNLup5PRQkMM";
		retObj.BirthDate = DateTime.Parse("12/8/2006 12:00:00 AM");
		retObj.HireDate = DateTime.Parse("9/20/2000 12:00:00 AM");
		retObj.Address = "T6ODO2Q0FC6bjbtSw9O4WGJHWwwniQGCuJ7awta3xR6EOVynfNsHToeRbjsS";
		retObj.City = "2F8jd4HgnbQvHaN";
		retObj.Region = "v63T6Le7nNz3IOs";
		retObj.PostalCode = "PMcxCdCU3O";
		retObj.Country = "Wb9y8xQ0pVZ3L3r";
		retObj.HomePhone = "FDafpblvar9Lyj5SSA9VPQxj";
		retObj.Extension = "U81c";
		retObj.Photo = new Byte[] { 203, 191, 202, 20, 35, 181, 22, 76, 136, 210, 64, 102, 166, 206, 250, 204, 28, 42, 97, 216, 52, 78, 179, 54, 22, 97, 127, 247, 91, 193, 25, 106, 155, 108, 29, 23, 215, 8, 24, 239, 196, 252, 210, 17, 89, 159, 142, 198, 195, 46, 169, 84, 36, 112, 204, 136, 38, 53, 31, 194, 176, 139, 129, 48, 215, 70, 161, 214, 57, 135, 41, 253, 107, 169, 184, 219, 34, 15, 175, 207, 157, 186, 124, 238, 75, 112, 191, 180, 111, 132, 47, 248, 4, 147, 112, 113, 223, 180, 77, 83 };
		retObj.Notes = "yGw0swp3OPiDN zgu1aIQpVQGJtZA2xOnO7dRcqQk qBMiRhdHT2EFjFIPOyANDDqYrGXfI HsW3apAGParTT33EPLOTxADV1TA5";
		retObj.ReportsTo_IR = _encryptionDecryptionService!.EncInt32Nullable(Convert.ToInt32(1));
		retObj.PhotoPath = "P5DpNn58D9rq3bgMJQ85JV5mE2bnIhKMy8vaLBhjyAjFlMJpIKq4YnO15qIaC6oNbwiBaIwQNAqTWW8QbpR nVQNlC vxzr0iLHjBP6mzPsm0dk7aqyAUfB0JGobkbTThIPfxaAbgjxRcE0yCwJbIDb1oCoXmZqdVFtxwZQo VhU cHmUz6lBoldPrXE0zej5fcSkLGKEGGKVnbsNWqt3 jv B2EvB8h1ah7iqk0FxyPmJhbG8ko8A6X6h69bdU";
		// Foreign key entities
		retObj.FK_Employees_Employees_Ref_IR = GetHydratedStaticNorthwind_dbo_Employees_IR();
		return retObj;
	}
}
