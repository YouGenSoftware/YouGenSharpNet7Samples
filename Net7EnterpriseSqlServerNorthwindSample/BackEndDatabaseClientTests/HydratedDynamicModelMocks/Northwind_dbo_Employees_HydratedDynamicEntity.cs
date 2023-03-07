/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307200636 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Enterprise Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
using Microsoft.EntityFrameworkCore;
using Tynamix.ObjectFiller;
using Northwind_BackEndSqlEntities.Entities;
namespace Northwind_BackEndDatabaseClientTests.HydratedDynamicEntities;
public partial class Northwind_HydratedDynamicEntities  : Northwind_HydratedDynamicEntitiesBase
{
	protected Filler<Northwind_dbo_Employees> _Northwind_dbo_Employees_Filler = new Filler<Northwind_dbo_Employees>();
	protected FillerSetup? _Northwind_dbo_Employees_FillerSetup;
	public FillerSetup GetNorthwind_dbo_Employees_FillerSetup(Boolean onlyFillExplicitlyNamedProperties, 
		Boolean fillPrimaryKey = false)
	{
		if (_Northwind_dbo_Employees_FillerSetup != null)
			return _Northwind_dbo_Employees_FillerSetup;
		_Northwind_dbo_Employees_FillerSetup = _Northwind_dbo_Employees_Filler.Setup(onlyFillExplicitlyNamedProperties)
		.OnProperty(x => x.EmployeeID).Use(() => (fillPrimaryKey ? Convert.ToInt32(1) : 0))
		.OnProperty(x => x.LastName).Use(() => new String(Enumerable.Repeat(_chars, Convert.ToInt32(20)).Select(s => s[Random.Shared.Next(s.Length)]).ToArray()))
		.OnProperty(x => x.FirstName).Use(() => new String(Enumerable.Repeat(_chars, Convert.ToInt32(10)).Select(s => s[Random.Shared.Next(s.Length)]).ToArray()))
		.OnProperty(x => x.Title).Use(() => new String(Enumerable.Repeat(_chars, Convert.ToInt32(30)).Select(s => s[Random.Shared.Next(s.Length)]).ToArray()))
		.OnProperty(x => x.TitleOfCourtesy).Use(() => new String(Enumerable.Repeat(_chars, Convert.ToInt32(25)).Select(s => s[Random.Shared.Next(s.Length)]).ToArray()))
		.OnProperty(x => x.BirthDate).Use(() => _seedDateTime.AddDays(Random.Shared.Next(_range)))
		.OnProperty(x => x.HireDate).Use(() => _seedDateTime.AddDays(Random.Shared.Next(_range)))
		.OnProperty(x => x.Address).Use(() => new String(Enumerable.Repeat(_chars, Convert.ToInt32(60)).Select(s => s[Random.Shared.Next(s.Length)]).ToArray()))
		.OnProperty(x => x.City).Use(() => new String(Enumerable.Repeat(_chars, Convert.ToInt32(15)).Select(s => s[Random.Shared.Next(s.Length)]).ToArray()))
		.OnProperty(x => x.Region).Use(() => new String(Enumerable.Repeat(_chars, Convert.ToInt32(15)).Select(s => s[Random.Shared.Next(s.Length)]).ToArray()))
		.OnProperty(x => x.PostalCode).Use(() => new String(Enumerable.Repeat(_chars, Convert.ToInt32(10)).Select(s => s[Random.Shared.Next(s.Length)]).ToArray()))
		.OnProperty(x => x.Country).Use(() => new String(Enumerable.Repeat(_chars, Convert.ToInt32(15)).Select(s => s[Random.Shared.Next(s.Length)]).ToArray()))
		.OnProperty(x => x.HomePhone).Use(() => new String(Enumerable.Repeat(_chars, Convert.ToInt32(24)).Select(s => s[Random.Shared.Next(s.Length)]).ToArray()))
		.OnProperty(x => x.Extension).Use(() => new String(Enumerable.Repeat(_chars, Convert.ToInt32(4)).Select(s => s[Random.Shared.Next(s.Length)]).ToArray()))
		.OnProperty(x => x.Photo).Use(() => {
                    var bytes = new Byte[Convert.ToInt32(100)];
                    Random.Shared.NextBytes(bytes);
                    return bytes;
                })
		.OnProperty(x => x.Notes).Use(() => new String(Enumerable.Repeat(_chars, Convert.ToInt32(100)).Select(s => s[Random.Shared.Next(s.Length)]).ToArray()))
		.OnProperty(x => x.ReportsTo).Use(() => Convert.ToInt32(1))
		.OnProperty(x => x.PhotoPath).Use(() => new String(Enumerable.Repeat(_chars, Convert.ToInt32(255)).Select(s => s[Random.Shared.Next(s.Length)]).ToArray()))
		// Foreign key entities
		.OnProperty(x => x.FK_Employees_Employees_Ref).IgnoreIt()
		// Entities that reference this entity by foreign key
		.OnProperty(x => x.FK_Employees_Employees_RefBy).IgnoreIt()
		.OnProperty(x => x.FK_EmployeeTerritories_Employees_RefBy).IgnoreIt()
		.OnProperty(x => x.FK_Orders_Employees_RefBy).IgnoreIt()
		.Result;
		return _Northwind_dbo_Employees_FillerSetup;
	}
	public Northwind_dbo_Employees GetHydratedDynamicNorthwind_dbo_Employees(Boolean onlyFillExplicitlyNamedProperties = true, 
		Boolean fillPrimaryKey = false,	
		Boolean fillInnerForeignKeys = false, 
		Boolean fillInnerPrimaryKeyReferencedBy = false)
	{
		return GetHydratedDynamicIEnumerableOfNorthwind_dbo_Employees(1,
			onlyFillExplicitlyNamedProperties, 
			fillPrimaryKey, 
			fillInnerForeignKeys, 
			fillInnerPrimaryKeyReferencedBy).First();
	}
	public IEnumerable<Northwind_dbo_Employees> GetHydratedDynamicIEnumerableOfNorthwind_dbo_Employees(Int32 numberToCreate, 
		Boolean onlyFillExplicitlyNamedProperties = true, 
		Boolean fillPrimaryKey = false, 
		Boolean fillInnerForeignKeys = false, 
		Boolean fillInnerPrimaryKeyReferencedBy = false)
	{
		_Northwind_dbo_Employees_Filler.Setup(GetNorthwind_dbo_Employees_FillerSetup(onlyFillExplicitlyNamedProperties, fillPrimaryKey));
		var retObjects = _Northwind_dbo_Employees_Filler.Create(numberToCreate);
		if (fillInnerForeignKeys) FillInnerForeignKeys(retObjects);
        if (fillInnerPrimaryKeyReferencedBy) FillInnerPrimaryKeyReferencedBy(retObjects);
		return retObjects;
	}
	private void FillInnerForeignKeys(IEnumerable<Northwind_dbo_Employees> entities)
	{
		foreach (var entity in entities)
		{
			entity.FK_Employees_Employees_Ref = GetHydratedDynamicNorthwind_dbo_Employees();
		}
	}
	private void FillInnerPrimaryKeyReferencedBy(IEnumerable<Northwind_dbo_Employees> entities)
	{
		foreach (var entity in entities)
		{
			// entity.FK_Employees_Employees_RefBy!.Add(GetHydratedDynamicNorthwind_dbo_Employees());
			// entity.FK_EmployeeTerritories_Employees_RefBy!.Add(GetHydratedDynamicNorthwind_dbo_EmployeeTerritories());
			// entity.FK_Orders_Employees_RefBy!.Add(GetHydratedDynamicNorthwind_dbo_Orders());
		}
	}
}