/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307202958 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Enterprise Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
using Microsoft.EntityFrameworkCore;
using Tynamix.ObjectFiller;
using XE_HR_BackEndSqlEntities.Entities;
namespace XE_HR_BackEndDatabaseClientTests.HydratedDynamicEntities;
public partial class XE_HR_HydratedDynamicEntities  : XE_HR_HydratedDynamicEntitiesBase
{
	protected Filler<XE_HR_COUNTRIES> _XE_HR_COUNTRIES_Filler = new Filler<XE_HR_COUNTRIES>();
	protected FillerSetup? _XE_HR_COUNTRIES_FillerSetup;
	public FillerSetup GetXE_HR_COUNTRIES_FillerSetup(Boolean onlyFillExplicitlyNamedProperties, 
		Boolean fillPrimaryKey = false)
	{
		if (_XE_HR_COUNTRIES_FillerSetup != null)
			return _XE_HR_COUNTRIES_FillerSetup;
		_XE_HR_COUNTRIES_FillerSetup = _XE_HR_COUNTRIES_Filler.Setup(onlyFillExplicitlyNamedProperties)
		.OnProperty(x => x.COUNTRY_ID).Use(() => (fillPrimaryKey ? new String(Enumerable.Repeat(_chars, Convert.ToInt32(2)).Select(s => s[Random.Shared.Next(s.Length)]).ToArray()) : String.Empty))
		.OnProperty(x => x.COUNTRY_NAME).Use(() => new String(Enumerable.Repeat(_chars, Convert.ToInt32(40)).Select(s => s[Random.Shared.Next(s.Length)]).ToArray()))
		.OnProperty(x => x.REGION_ID).Use(() => Convert.ToInt32(1))
		// Foreign key entities
		.OnProperty(x => x.COUNTR_REG_FK_Ref).IgnoreIt()
		// Entities that reference this entity by foreign key
		.OnProperty(x => x.LOC_C_ID_FK_RefBy).IgnoreIt()
		.Result;
		return _XE_HR_COUNTRIES_FillerSetup;
	}
	public XE_HR_COUNTRIES GetHydratedDynamicXE_HR_COUNTRIES(Boolean onlyFillExplicitlyNamedProperties = true, 
		Boolean fillPrimaryKey = false,	
		Boolean fillInnerForeignKeys = false, 
		Boolean fillInnerPrimaryKeyReferencedBy = false)
	{
		return GetHydratedDynamicIEnumerableOfXE_HR_COUNTRIES(1,
			onlyFillExplicitlyNamedProperties, 
			fillPrimaryKey, 
			fillInnerForeignKeys, 
			fillInnerPrimaryKeyReferencedBy).First();
	}
	public IEnumerable<XE_HR_COUNTRIES> GetHydratedDynamicIEnumerableOfXE_HR_COUNTRIES(Int32 numberToCreate, 
		Boolean onlyFillExplicitlyNamedProperties = true, 
		Boolean fillPrimaryKey = false, 
		Boolean fillInnerForeignKeys = false, 
		Boolean fillInnerPrimaryKeyReferencedBy = false)
	{
		_XE_HR_COUNTRIES_Filler.Setup(GetXE_HR_COUNTRIES_FillerSetup(onlyFillExplicitlyNamedProperties, fillPrimaryKey));
		var retObjects = _XE_HR_COUNTRIES_Filler.Create(numberToCreate);
		if (fillInnerForeignKeys) FillInnerForeignKeys(retObjects);
        if (fillInnerPrimaryKeyReferencedBy) FillInnerPrimaryKeyReferencedBy(retObjects);
		return retObjects;
	}
	private void FillInnerForeignKeys(IEnumerable<XE_HR_COUNTRIES> entities)
	{
		foreach (var entity in entities)
		{
			entity.COUNTR_REG_FK_Ref = GetHydratedDynamicXE_HR_REGIONS();
		}
	}
	private void FillInnerPrimaryKeyReferencedBy(IEnumerable<XE_HR_COUNTRIES> entities)
	{
		foreach (var entity in entities)
		{
			// entity.LOC_C_ID_FK_RefBy!.Add(GetHydratedDynamicXE_HR_LOCATIONS());
		}
	}
}