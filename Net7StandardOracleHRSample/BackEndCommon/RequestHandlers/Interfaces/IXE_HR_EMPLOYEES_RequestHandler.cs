/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307202848 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Standard Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
using Microsoft.EntityFrameworkCore;
using XE_HR_BackEndDatabaseClient.Repositories;
using XE_HR_BackEndSqlEntities.Entities;
namespace XE_HR_BackEndCommon.RequestHandlers;
public interface IXE_HR_EMPLOYEES_RequestHandler
{
	//Main Handlers
	Task<IEnumerable<XE_HR_EMPLOYEES>?> HandleGetAll();
	Task<IEnumerable<XE_HR_EMPLOYEES>?> HandleGetByFIRST_NAMEAndLAST_NAME(String? fIRST_NAME, String lAST_NAME);
	Task<IEnumerable<XE_HR_EMPLOYEES>?> HandleGetByDEPARTMENT_ID(Int32? dEPARTMENT_ID);
	Task<IEnumerable<XE_HR_EMPLOYEES>?> HandleGetByEMAIL(String eMAIL);
	Task<IEnumerable<XE_HR_EMPLOYEES>?> HandleGetByEMPLOYEE_ID(Int32 eMPLOYEE_ID);
	Task<IEnumerable<XE_HR_EMPLOYEES>?> HandleGetByJOB_ID(String jOB_ID);
	Task<IEnumerable<XE_HR_EMPLOYEES>?> HandleGetByMANAGER_ID(Int32? mANAGER_ID);
	Task<XE_HR_EMPLOYEES?> HandleCreate(XE_HR_EMPLOYEES entity);
	Task HandleUpdateByFIRST_NAMEAndLAST_NAME(String? fIRST_NAME, String lAST_NAME, XE_HR_EMPLOYEES entity);
	Task HandleUpdateByDEPARTMENT_ID(Int32? dEPARTMENT_ID, XE_HR_EMPLOYEES entity);
	Task HandleUpdateByEMAIL(String eMAIL, XE_HR_EMPLOYEES entity);
	Task HandleUpdateByEMPLOYEE_ID(Int32 eMPLOYEE_ID, XE_HR_EMPLOYEES entity);
	Task HandleUpdateByJOB_ID(String jOB_ID, XE_HR_EMPLOYEES entity);
	Task HandleUpdateByMANAGER_ID(Int32? mANAGER_ID, XE_HR_EMPLOYEES entity);
	Task HandleDeleteByFIRST_NAMEAndLAST_NAME(String? fIRST_NAME, String lAST_NAME);
	Task HandleDeleteByDEPARTMENT_ID(Int32? dEPARTMENT_ID);
	Task HandleDeleteByEMAIL(String eMAIL);
	Task HandleDeleteByEMPLOYEE_ID(Int32 eMPLOYEE_ID);
	Task HandleDeleteByJOB_ID(String jOB_ID);
	Task HandleDeleteByMANAGER_ID(Int32? mANAGER_ID);
}
