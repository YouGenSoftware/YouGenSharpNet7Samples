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
	protected Filler<Northwind_dbo_Product_Sales_for_1997> _Northwind_dbo_Product_Sales_for_1997_Filler = new Filler<Northwind_dbo_Product_Sales_for_1997>();
	protected FillerSetup? _Northwind_dbo_Product_Sales_for_1997_FillerSetup;
	public FillerSetup GetNorthwind_dbo_Product_Sales_for_1997_FillerSetup(Boolean onlyFillExplicitlyNamedProperties)
	{
		if (_Northwind_dbo_Product_Sales_for_1997_FillerSetup != null)
			return _Northwind_dbo_Product_Sales_for_1997_FillerSetup;
		_Northwind_dbo_Product_Sales_for_1997_FillerSetup = _Northwind_dbo_Product_Sales_for_1997_Filler.Setup(onlyFillExplicitlyNamedProperties)
		.OnProperty(x => x.CategoryName).Use(() => new String(Enumerable.Repeat(_chars, Convert.ToInt32(15)).Select(s => s[Random.Shared.Next(s.Length)]).ToArray()))
		.OnProperty(x => x.ProductName).Use(() => new String(Enumerable.Repeat(_chars, Convert.ToInt32(40)).Select(s => s[Random.Shared.Next(s.Length)]).ToArray()))
		.OnProperty(x => x.ProductSales).Use(() => Convert.ToDecimal(Random.Shared.NextDouble()))
		.Result;
		return _Northwind_dbo_Product_Sales_for_1997_FillerSetup;
	}
	public Northwind_dbo_Product_Sales_for_1997 GetHydratedDynamicNorthwind_dbo_Product_Sales_for_1997(Boolean onlyFillExplicitlyNamedProperties = true)
	{
		return GetHydratedDynamicIEnumerableOfNorthwind_dbo_Product_Sales_for_1997(1, onlyFillExplicitlyNamedProperties).First();
	}
	public IEnumerable<Northwind_dbo_Product_Sales_for_1997> GetHydratedDynamicIEnumerableOfNorthwind_dbo_Product_Sales_for_1997(Int32 numberToCreate, 
		Boolean onlyFillExplicitlyNamedProperties = true)
	{
		_Northwind_dbo_Product_Sales_for_1997_Filler.Setup(GetNorthwind_dbo_Product_Sales_for_1997_FillerSetup(onlyFillExplicitlyNamedProperties));
		var retObjects = _Northwind_dbo_Product_Sales_for_1997_Filler.Create(numberToCreate);
		return retObjects;
	}
}
