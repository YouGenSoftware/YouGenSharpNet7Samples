/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307202926 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Professional Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
using Microsoft.EntityFrameworkCore;
using Tynamix.ObjectFiller;
using XE_HR_BackEndSqlEntities.Entities;
namespace XE_HR_BackEndDatabaseClientTests.HydratedDynamicEntities;
public partial class XE_HR_HydratedDynamicEntities  : XE_HR_HydratedDynamicEntitiesBase
{
	protected Filler<XE_HR_EMPLOYEES> _XE_HR_EMPLOYEES_Filler = new Filler<XE_HR_EMPLOYEES>();
	protected FillerSetup? _XE_HR_EMPLOYEES_FillerSetup;
	public FillerSetup GetXE_HR_EMPLOYEES_FillerSetup(Boolean onlyFillExplicitlyNamedProperties, 
		Boolean fillPrimaryKey = false)
	{
		if (_XE_HR_EMPLOYEES_FillerSetup != null)
			return _XE_HR_EMPLOYEES_FillerSetup;
		_XE_HR_EMPLOYEES_FillerSetup = _XE_HR_EMPLOYEES_Filler.Setup(onlyFillExplicitlyNamedProperties)
		.OnProperty(x => x.EMPLOYEE_ID).Use(() => (fillPrimaryKey ? Convert.ToInt32(1) : 0))
		.OnProperty(x => x.FIRST_NAME).Use(() => new String(Enumerable.Repeat(_chars, Convert.ToInt32(20)).Select(s => s[Random.Shared.Next(s.Length)]).ToArray()))
		.OnProperty(x => x.LAST_NAME).Use(() => new String(Enumerable.Repeat(_chars, Convert.ToInt32(25)).Select(s => s[Random.Shared.Next(s.Length)]).ToArray()))
		.OnProperty(x => x.EMAIL).Use(() => new String(Enumerable.Repeat(_chars, Convert.ToInt32(25)).Select(s => s[Random.Shared.Next(s.Length)]).ToArray()))
		.OnProperty(x => x.PHONE_NUMBER).Use(() => new String(Enumerable.Repeat(_chars, Convert.ToInt32(20)).Select(s => s[Random.Shared.Next(s.Length)]).ToArray()))
		.OnProperty(x => x.HIRE_DATE).Use(() => _seedDateTime.AddDays(Random.Shared.Next(_range)))
		.OnProperty(x => x.JOB_ID).Use(() => new String(Enumerable.Repeat(_chars, Convert.ToInt32(10)).Select(s => s[Random.Shared.Next(s.Length)]).ToArray()))
		.OnProperty(x => x.SALARY).Use(() => Convert.ToDecimal(Random.Shared.NextDouble()))
		.OnProperty(x => x.COMMISSION_PCT).Use(() => Convert.ToDecimal(Random.Shared.NextDouble()))
		.OnProperty(x => x.MANAGER_ID).Use(() => Convert.ToInt32(1))
		.OnProperty(x => x.DEPARTMENT_ID).Use(() => Convert.ToInt32(1))
		// Foreign key entities
		.OnProperty(x => x.EMP_DEPT_FK_Ref).IgnoreIt()
		.OnProperty(x => x.EMP_JOB_FK_Ref).IgnoreIt()
		.OnProperty(x => x.EMP_MANAGER_FK_Ref).IgnoreIt()
		// Entities that reference this entity by foreign key
		.OnProperty(x => x.EMP_MANAGER_FK_RefBy).IgnoreIt()
		.OnProperty(x => x.DEPT_MGR_FK_RefBy).IgnoreIt()
		.OnProperty(x => x.JHIST_EMP_FK_RefBy).IgnoreIt()
		.Result;
		return _XE_HR_EMPLOYEES_FillerSetup;
	}
	public XE_HR_EMPLOYEES GetHydratedDynamicXE_HR_EMPLOYEES(Boolean onlyFillExplicitlyNamedProperties = true, 
		Boolean fillPrimaryKey = false,	
		Boolean fillInnerForeignKeys = false, 
		Boolean fillInnerPrimaryKeyReferencedBy = false)
	{
		return GetHydratedDynamicIEnumerableOfXE_HR_EMPLOYEES(1,
			onlyFillExplicitlyNamedProperties, 
			fillPrimaryKey, 
			fillInnerForeignKeys, 
			fillInnerPrimaryKeyReferencedBy).First();
	}
	public IEnumerable<XE_HR_EMPLOYEES> GetHydratedDynamicIEnumerableOfXE_HR_EMPLOYEES(Int32 numberToCreate, 
		Boolean onlyFillExplicitlyNamedProperties = true, 
		Boolean fillPrimaryKey = false, 
		Boolean fillInnerForeignKeys = false, 
		Boolean fillInnerPrimaryKeyReferencedBy = false)
	{
		_XE_HR_EMPLOYEES_Filler.Setup(GetXE_HR_EMPLOYEES_FillerSetup(onlyFillExplicitlyNamedProperties, fillPrimaryKey));
		var retObjects = _XE_HR_EMPLOYEES_Filler.Create(numberToCreate);
		if (fillInnerForeignKeys) FillInnerForeignKeys(retObjects);
        if (fillInnerPrimaryKeyReferencedBy) FillInnerPrimaryKeyReferencedBy(retObjects);
		return retObjects;
	}
	private void FillInnerForeignKeys(IEnumerable<XE_HR_EMPLOYEES> entities)
	{
		foreach (var entity in entities)
		{
			entity.EMP_DEPT_FK_Ref = GetHydratedDynamicXE_HR_DEPARTMENTS();
			entity.EMP_JOB_FK_Ref = GetHydratedDynamicXE_HR_JOBS();
			entity.EMP_MANAGER_FK_Ref = GetHydratedDynamicXE_HR_EMPLOYEES();
		}
	}
	private void FillInnerPrimaryKeyReferencedBy(IEnumerable<XE_HR_EMPLOYEES> entities)
	{
		foreach (var entity in entities)
		{
			// entity.EMP_MANAGER_FK_RefBy!.Add(GetHydratedDynamicXE_HR_EMPLOYEES());
			// entity.DEPT_MGR_FK_RefBy!.Add(GetHydratedDynamicXE_HR_DEPARTMENTS());
			// entity.JHIST_EMP_FK_RefBy!.Add(GetHydratedDynamicXE_HR_JOB_HISTORY());
		}
	}
}