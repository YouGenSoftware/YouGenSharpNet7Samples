/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307202958 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Enterprise Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
function getHydratedStaticXE_HR_LOCATIONS(fillPrimaryKey = false) {
	let retObj = new XE_HR_LOCATIONS_IR();
	retObj.LOCATION_ID_IR = (fillPrimaryKey ? encrypt(1) : null);
	retObj.STREET_ADDRESS = 'N1fqfQUDsepERKCcqovzPK3t4txPEzvRd95Nyecq';
	retObj.POSTAL_CODE = 'CW0wdc6zj955';
	retObj.CITY = 'wZJoCbkGAsk7xYtvpusJkZprYXtje1';
	retObj.STATE_PROVINCE = 'qm7ROqiQ2mc1FUvNK ZXw7gwP';
	retObj.COUNTRY_ID = 'G3';
	// Foreign key entities
	retObj.LOC_C_ID_FK_Ref_IR = getHydratedStaticXE_HR_COUNTRIES_IR();
	return retObj;
}