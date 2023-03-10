/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307202958 on behalf of: ****
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
using XE_HR_Common.IndirectReferenceTransformerModels;
using XE_HR_BackEndSqlEntities.Entities;
using XE_HR_BackEndCommon.Services;
namespace XE_HR_CommonTests.HydratedStaticIndirectReferenceTransformerModels;
public partial class XE_HR_HydratedStaticIndirectReferenceTransformerModels : XE_HR_HydratedStaticIndirectReferenceTransformerModelsBase
{
	public XE_HR_PACKAGE1_OPEN_ONE_CURSOR_OM_IR GetHydratedStaticXE_HR_PACKAGE1_OPEN_ONE_CURSOR_OM_IR(Boolean fillPrimaryKey = false)
	{
		var retObj = new XE_HR_PACKAGE1_OPEN_ONE_CURSOR_OM_IR();
		retObj.Query1_Results_IR!.ToList().Add(new XE_HR_PACKAGE1_OPEN_ONE_CURSOR_OM_Query1_IR());
		retObj.Query1_Results_IR!.First()!.EMPLOYEE_ID_IR = _encryptionDecryptionService!.EncDecimal(Convert.ToDecimal(1));
		retObj.Query1_Results_IR!.First()!.JOB_ID = "fc rS T4BT";
		retObj.Query1_Results_IR!.First()!.MANAGER_ID_IR = _encryptionDecryptionService!.EncDecimalNullable(Convert.ToDecimal(1));
		retObj.Query1_Results_IR!.First()!.DEPARTMENT_ID_IR = _encryptionDecryptionService!.EncDecimalNullable(Convert.ToDecimal(1));
		retObj.Query1_Results_IR!.First()!.LOCATION_ID_IR = _encryptionDecryptionService!.EncDecimalNullable(Convert.ToDecimal(1));
		retObj.Query1_Results_IR!.First()!.COUNTRY_ID = "vD";
		retObj.Query1_Results_IR!.First()!.FIRST_NAME = "b7SsWdaoWoIlzxYhv0d7";
		retObj.Query1_Results_IR!.First()!.LAST_NAME = " dSRdGqgkOyvnvkDMpgV9gKvt";
		retObj.Query1_Results_IR!.First()!.SALARY = (0.10927217517833798M);
		retObj.Query1_Results_IR!.First()!.COMMISSION_PCT = (0.9881304537824388M);
		retObj.Query1_Results_IR!.First()!.DEPARTMENT_NAME = "aCA8 FSiNkWqwHThDFfa7UMnkm7JRC";
		retObj.Query1_Results_IR!.First()!.JOB_TITLE = "WGNndMRtzvTNCUqIvhsAokeScXVzttMek6S";
		retObj.Query1_Results_IR!.First()!.CITY = "5d wUksiAiErKHrxb6ApeKoavBTXzI";
		retObj.Query1_Results_IR!.First()!.STATE_PROVINCE = "fRBS 3eRMCuiF8dx0W1UMTsR0";
		retObj.Query1_Results_IR!.First()!.COUNTRY_NAME = "KZzaZhoZxQ2V10WDcosxVmpV8BUTqmDzIwWBWRQr";
		retObj.Query1_Results_IR!.First()!.REGION_NAME = "MH4QPcp1 MjOGTN9srBhmzZEe";
		return retObj;
	}
}
