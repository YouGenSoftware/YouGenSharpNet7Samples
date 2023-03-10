/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307202958 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Enterprise Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
using Microsoft.EntityFrameworkCore;
using XE_HR_BackEndSqlEntities.Entities;
namespace XE_HR_BackEndDatabaseClientTests.HydratedStaticEntities;
public partial class XE_HR_HydratedStaticEntities 
{
	public XE_HR_PACKAGE1_PARAMOUTCURSORS_OM GetHydratedStaticXE_HR_PACKAGE1_PARAMOUTCURSORS_OM(Boolean fillPrimaryKey = false)
	{
		var retObj = new XE_HR_PACKAGE1_PARAMOUTCURSORS_OM();
		// Output parameters
		retObj.CONVERTED_TO_VARCHAR2 = "fQBPlL3FfVKTqBe51O2VEesgoD4t nWWJ MglJsJMCggcHdPtLU54 KGE8Ga4LHCIPWPAek4IZEOFAT6lLZGLw4Tl3gjq 0PPN2I";
		retObj.Query1_Results!.ToList().Add(new XE_HR_PACKAGE1_PARAMOUTCURSORS_OM_Query1());
		retObj.Query2_Results!.ToList().Add(new XE_HR_PACKAGE1_PARAMOUTCURSORS_OM_Query2());
		retObj.Query1_Results!.First()!.EMPLOYEE_ID = Convert.ToDecimal(1);
		retObj.Query1_Results!.First()!.START_DATE = "aEVaOES";
		retObj.Query1_Results!.First()!.END_DATE = "0hlH6hY";
		retObj.Query1_Results!.First()!.JOB_ID = "eN9eMAaSpF";
		retObj.Query1_Results!.First()!.DEPARTMENT_ID = Convert.ToDecimal(1);
		retObj.Query2_Results!.First()!.DEPARTMENT_ID = Convert.ToDecimal(1);
		retObj.Query2_Results!.First()!.DEPARTMENT_NAME = "rnCDyLus4TyKKUUqAiq saNgREzcDD";
		retObj.Query2_Results!.First()!.MANAGER_ID = Convert.ToDecimal(1);
		retObj.Query2_Results!.First()!.LOCATION_ID = Convert.ToDecimal(1);
		return retObj;
	}
}
