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
	protected Filler<Northwind_dbo_Shippers> _Northwind_dbo_Shippers_Filler = new Filler<Northwind_dbo_Shippers>();
	protected FillerSetup? _Northwind_dbo_Shippers_FillerSetup;
	public FillerSetup GetNorthwind_dbo_Shippers_FillerSetup(Boolean onlyFillExplicitlyNamedProperties, 
		Boolean fillPrimaryKey = false)
	{
		if (_Northwind_dbo_Shippers_FillerSetup != null)
			return _Northwind_dbo_Shippers_FillerSetup;
		_Northwind_dbo_Shippers_FillerSetup = _Northwind_dbo_Shippers_Filler.Setup(onlyFillExplicitlyNamedProperties)
		.OnProperty(x => x.ShipperID).Use(() => (fillPrimaryKey ? Convert.ToInt32(1) : 0))
		.OnProperty(x => x.CompanyName).Use(() => new String(Enumerable.Repeat(_chars, Convert.ToInt32(40)).Select(s => s[Random.Shared.Next(s.Length)]).ToArray()))
		.OnProperty(x => x.Phone).Use(() => new String(Enumerable.Repeat(_chars, Convert.ToInt32(24)).Select(s => s[Random.Shared.Next(s.Length)]).ToArray()))
		// Entities that reference this entity by foreign key
		.OnProperty(x => x.FK_Orders_Shippers_RefBy).IgnoreIt()
		.Result;
		return _Northwind_dbo_Shippers_FillerSetup;
	}
	public Northwind_dbo_Shippers GetHydratedDynamicNorthwind_dbo_Shippers(Boolean onlyFillExplicitlyNamedProperties = true, 
		Boolean fillPrimaryKey = false,	
		Boolean fillInnerForeignKeys = false, 
		Boolean fillInnerPrimaryKeyReferencedBy = false)
	{
		return GetHydratedDynamicIEnumerableOfNorthwind_dbo_Shippers(1,
			onlyFillExplicitlyNamedProperties, 
			fillPrimaryKey, 
			fillInnerForeignKeys, 
			fillInnerPrimaryKeyReferencedBy).First();
	}
	public IEnumerable<Northwind_dbo_Shippers> GetHydratedDynamicIEnumerableOfNorthwind_dbo_Shippers(Int32 numberToCreate, 
		Boolean onlyFillExplicitlyNamedProperties = true, 
		Boolean fillPrimaryKey = false, 
		Boolean fillInnerForeignKeys = false, 
		Boolean fillInnerPrimaryKeyReferencedBy = false)
	{
		_Northwind_dbo_Shippers_Filler.Setup(GetNorthwind_dbo_Shippers_FillerSetup(onlyFillExplicitlyNamedProperties, fillPrimaryKey));
		var retObjects = _Northwind_dbo_Shippers_Filler.Create(numberToCreate);
		if (fillInnerForeignKeys) FillInnerForeignKeys(retObjects);
        if (fillInnerPrimaryKeyReferencedBy) FillInnerPrimaryKeyReferencedBy(retObjects);
		return retObjects;
	}
	private void FillInnerForeignKeys(IEnumerable<Northwind_dbo_Shippers> entities)
	{
		foreach (var entity in entities)
		{
		}
	}
	private void FillInnerPrimaryKeyReferencedBy(IEnumerable<Northwind_dbo_Shippers> entities)
	{
		foreach (var entity in entities)
		{
			// entity.FK_Orders_Shippers_RefBy!.Add(GetHydratedDynamicNorthwind_dbo_Orders());
		}
	}
}
