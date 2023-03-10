/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307202926 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Professional Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
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
	public XE_HR_LOCATIONS_IR GetHydratedStaticXE_HR_LOCATIONS_IR(Boolean fillPrimaryKey = false)
	{
		var retObj = new XE_HR_LOCATIONS_IR();
		retObj.LOCATION_ID_IR = (fillPrimaryKey ? _encryptionDecryptionService!.EncInt32(Convert.ToInt32(1)) : String.Empty);
		retObj.STREET_ADDRESS = "GgPyrLo9oRoqom8kIh6PDpNwob kKKvyiqCiDtyU";
		retObj.POSTAL_CODE = "Vct4Fnnul0lC";
		retObj.CITY = "JOJyEcz81tNO03 gIvl1JdotqRPmJL";
		retObj.STATE_PROVINCE = "g6dUP7lk 6tAZey8gfX29k22A";
		retObj.COUNTRY_ID = "bI";
		// Foreign key entities
		retObj.LOC_C_ID_FK_Ref_IR = GetHydratedStaticXE_HR_COUNTRIES_IR();
		return retObj;
	}
}
