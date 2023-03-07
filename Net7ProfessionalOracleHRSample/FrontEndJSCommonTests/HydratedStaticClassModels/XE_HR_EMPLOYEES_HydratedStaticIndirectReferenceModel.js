/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307202926 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Professional Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
function getHydratedStaticXE_HR_EMPLOYEES(fillPrimaryKey = false) {
	let retObj = new XE_HR_EMPLOYEES_IR();
	retObj.EMPLOYEE_ID_IR = (fillPrimaryKey ? encrypt(1) : null);
	retObj.FIRST_NAME = 'xJugVA79QdskrG3wsdUE';
	retObj.LAST_NAME = '0pbMwvdduWEYFE9j9eGfBRNFh';
	retObj.EMAIL = '7sfaTEoWtTtiR04oJkhzmRHPQ';
	retObj.PHONE_NUMBER = ' oQc7327nGhLNxW16EjJ';
	retObj.HIRE_DATE = '/Date(11/6/2022 12:00:00 AM)/';
	retObj.JOB_ID = 'i eB8u3bYX';
	retObj.SALARY = 0.19299790661087401;
	retObj.COMMISSION_PCT = 0.4939104148246999;
	retObj.MANAGER_ID_IR = encrypt(1);
	retObj.DEPARTMENT_ID_IR = encrypt(1);
	// Foreign key entities
	retObj.EMP_DEPT_FK_Ref_IR = getHydratedStaticXE_HR_DEPARTMENTS_IR();
	retObj.EMP_JOB_FK_Ref_IR = getHydratedStaticXE_HR_JOBS_IR();
	retObj.EMP_MANAGER_FK_Ref_IR = getHydratedStaticXE_HR_EMPLOYEES_IR();
	return retObj;
}