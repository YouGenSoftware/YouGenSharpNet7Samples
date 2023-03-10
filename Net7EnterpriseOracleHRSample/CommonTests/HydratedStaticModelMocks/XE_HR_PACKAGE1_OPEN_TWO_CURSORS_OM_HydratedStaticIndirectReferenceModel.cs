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
	public XE_HR_PACKAGE1_OPEN_TWO_CURSORS_OM_IR GetHydratedStaticXE_HR_PACKAGE1_OPEN_TWO_CURSORS_OM_IR(Boolean fillPrimaryKey = false)
	{
		var retObj = new XE_HR_PACKAGE1_OPEN_TWO_CURSORS_OM_IR();
		retObj.Query1_Results_IR!.ToList().Add(new XE_HR_PACKAGE1_OPEN_TWO_CURSORS_OM_Query1_IR());
		retObj.Query1_Results_IR!.First()!.EMPLOYEE_ID_IR = _encryptionDecryptionService!.EncDecimal(Convert.ToDecimal(1));
		retObj.Query1_Results_IR!.First()!.FIRST_NAME = "XgI0UnnCWi5sOyzG6mbT";
		retObj.Query1_Results_IR!.First()!.LAST_NAME = "3WxbFRkGU1kYzknxMA8ysznBw";
		retObj.Query1_Results_IR!.First()!.EMAIL = "h5FdPqYhhYMIGxgq5vg8nZiEX";
		retObj.Query1_Results_IR!.First()!.PHONE_NUMBER = "6v7Bf xosdO2xyfbDz95";
		retObj.Query1_Results_IR!.First()!.HIRE_DATE = "pFxb0O4";
		retObj.Query1_Results_IR!.First()!.JOB_ID = "NXE 32iekd";
		retObj.Query1_Results_IR!.First()!.SALARY = (0.7332604045459279M);
		retObj.Query1_Results_IR!.First()!.COMMISSION_PCT = (0.46736384167183553M);
		retObj.Query1_Results_IR!.First()!.MANAGER_ID_IR = _encryptionDecryptionService!.EncDecimalNullable(Convert.ToDecimal(1));
		retObj.Query1_Results_IR!.First()!.DEPARTMENT_ID_IR = _encryptionDecryptionService!.EncDecimalNullable(Convert.ToDecimal(1));
		retObj.Query2_Results_IR!.ToList().Add(new XE_HR_PACKAGE1_OPEN_TWO_CURSORS_OM_Query2_IR());
		retObj.Query2_Results_IR!.First()!.DEPARTMENT_ID_IR = _encryptionDecryptionService!.EncDecimal(Convert.ToDecimal(1));
		retObj.Query2_Results_IR!.First()!.DEPARTMENT_NAME = "Z5wRXkVe70S2SPYypkNI5Ub9GL2ozG";
		retObj.Query2_Results_IR!.First()!.MANAGER_ID_IR = _encryptionDecryptionService!.EncDecimalNullable(Convert.ToDecimal(1));
		retObj.Query2_Results_IR!.First()!.LOCATION_ID_IR = _encryptionDecryptionService!.EncDecimalNullable(Convert.ToDecimal(1));
		return retObj;
	}
}
