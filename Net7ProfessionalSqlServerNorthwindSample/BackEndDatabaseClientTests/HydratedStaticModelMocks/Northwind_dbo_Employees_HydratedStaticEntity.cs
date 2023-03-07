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
	public Northwind_dbo_Employees GetHydratedStaticNorthwind_dbo_Employees(Boolean fillPrimaryKey = false)
	{
		var retObj = new Northwind_dbo_Employees();
		retObj.EmployeeID = (fillPrimaryKey ? Convert.ToInt32(1) : 0);
		retObj.LastName = "JOp1Q1haOr5tiyv9jUMP";
		retObj.FirstName = "Fhz4e1wOwB";
		retObj.Title = "2i8aP8ivNhBbPqVTQJJLJBPGtWldnJ";
		retObj.TitleOfCourtesy = "KrFcweCzEz1lQvTaxSGAK7g5s";
		retObj.BirthDate = DateTime.Parse("9/18/2017 12:00:00 AM");
		retObj.HireDate = DateTime.Parse("1/7/2008 12:00:00 AM");
		retObj.Address = "JC0gfMW32fm1cQ88SfhbFrXHxWq4bp C0XGzy0DOlfdolgOpOjp2M HvlgkY";
		retObj.City = "3H6MPGR6isnhskH";
		retObj.Region = "pS5wI5UrEgrHQRk";
		retObj.PostalCode = "qa7rBa3jTb";
		retObj.Country = "YN1 FIUO1CJuY41";
		retObj.HomePhone = "H6MpDlC29LeSwoNVL3 ek3DT";
		retObj.Extension = "PcNJ";
		retObj.Photo = new Byte[] { 232, 38, 27, 169, 23, 104, 19, 39, 171, 173, 63, 168, 204, 50, 130, 228, 237, 47, 191, 238, 43, 136, 145, 98, 50, 88, 42, 129, 44, 27, 248, 224, 9, 123, 75, 40, 0, 205, 152, 47, 159, 31, 77, 123, 44, 190, 159, 62, 13, 247, 124, 230, 75, 45, 58, 55, 16, 172, 59, 77, 251, 191, 237, 77, 163, 2, 78, 50, 115, 197, 195, 95, 180, 178, 162, 142, 190, 124, 74, 192, 56, 104, 221, 150, 79, 240, 110, 33, 74, 200, 188, 23, 5, 17, 13, 77, 169, 44, 105, 15 };
		retObj.Notes = "kvB4F2OqvmprOzrD vLBiu56Sh qQxqMwwSmveSgyYQ51ieO9wWNqnK1hV18RGdd5paj0x06 iu3UUhvZC7qLdiVkGOU7HGf3JvJ";
		retObj.ReportsTo = Convert.ToInt32(1);
		retObj.PhotoPath = "g WL8dhiLFer DOvas0EKmKFA2eEHWMiPn6 VpbzE1daJP2EHen35QOOyNgc97NgQo9L42cTS056aU2c5ueuAM1iJ25A7US8uVhzLSuo9m1aZJBprH16efbIVL0focdcExU8q7MOksxCE7SYIAda3e2ZDWz9cXzOrniYopdiOXL40Sh1NVxGpo n3K97jxYaJ CzE9eKGAwI9WzfgmnclOH6zoKB1Crrq1ohKZs8KGIETGAdbO2L1GzbqErMBVK";
		// Foreign key entities
		retObj.FK_Employees_Employees_Ref = GetHydratedStaticNorthwind_dbo_Employees();
		return retObj;
	}
}