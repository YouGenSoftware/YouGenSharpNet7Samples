/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307202926 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Professional Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
using XE_HR_BackEndSqlEntities.Entities;
using XE_HR_BackEndCommon.Services;
using XE_HR_Common.IndirectReferenceTransformerModels;
namespace XE_HR_BackEndCommon.IndirectReferenceTransformers;
public partial class IRTransformers : IIRTransformers
{
	public XE_HR_EMP_DETAILS_VIEW_IR ToIndirectModel(XE_HR_EMP_DETAILS_VIEW input)
	{
		var retData = new XE_HR_EMP_DETAILS_VIEW_IR(
			eMPLOYEE_ID_IR_ : _encryptionDecryptionService!.EncInt32(input.EMPLOYEE_ID),
			jOB_ID_ : input.JOB_ID,
			mANAGER_ID_IR_ : _encryptionDecryptionService!.EncInt32Nullable(input.MANAGER_ID),
			dEPARTMENT_ID_IR_ : _encryptionDecryptionService!.EncInt32Nullable(input.DEPARTMENT_ID),
			lOCATION_ID_IR_ : _encryptionDecryptionService!.EncInt32Nullable(input.LOCATION_ID),
			cOUNTRY_ID_ : input.COUNTRY_ID,
			fIRST_NAME_ : input.FIRST_NAME,
			lAST_NAME_ : input.LAST_NAME,
			sALARY_ : input.SALARY,
			cOMMISSION_PCT_ : input.COMMISSION_PCT,
			dEPARTMENT_NAME_ : input.DEPARTMENT_NAME,
			jOB_TITLE_ : input.JOB_TITLE,
			cITY_ : input.CITY,
			sTATE_PROVINCE_ : input.STATE_PROVINCE,
			cOUNTRY_NAME_ : input.COUNTRY_NAME,
			rEGION_NAME_ : input.REGION_NAME
			);
		return retData;
	}
	public XE_HR_EMP_DETAILS_VIEW ToEntity(XE_HR_EMP_DETAILS_VIEW_IR input)
	{
		var retData = new XE_HR_EMP_DETAILS_VIEW(		
			eMPLOYEE_ID_ : _encryptionDecryptionService.DecInt32(input.EMPLOYEE_ID_IR),
			jOB_ID_ : input.JOB_ID ?? String.Empty,
			mANAGER_ID_ : _encryptionDecryptionService.DecInt32Nullable(input.MANAGER_ID_IR),
			dEPARTMENT_ID_ : _encryptionDecryptionService.DecInt32Nullable(input.DEPARTMENT_ID_IR),
			lOCATION_ID_ : _encryptionDecryptionService.DecInt32Nullable(input.LOCATION_ID_IR),
			cOUNTRY_ID_ : input.COUNTRY_ID,
			fIRST_NAME_ : input.FIRST_NAME,
			lAST_NAME_ : input.LAST_NAME ?? String.Empty,
			sALARY_ : input.SALARY,
			cOMMISSION_PCT_ : input.COMMISSION_PCT,
			dEPARTMENT_NAME_ : input.DEPARTMENT_NAME ?? String.Empty,
			jOB_TITLE_ : input.JOB_TITLE ?? String.Empty,
			cITY_ : input.CITY ?? String.Empty,
			sTATE_PROVINCE_ : input.STATE_PROVINCE,
			cOUNTRY_NAME_ : input.COUNTRY_NAME,
			rEGION_NAME_ : input.REGION_NAME
			);
		return retData;
	}
}
