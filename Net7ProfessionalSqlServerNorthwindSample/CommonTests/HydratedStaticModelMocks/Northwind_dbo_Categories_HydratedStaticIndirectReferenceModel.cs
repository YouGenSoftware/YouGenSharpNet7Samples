/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307200541 on behalf of: ****
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
using Northwind_Common.IndirectReferenceTransformerModels;
using Northwind_BackEndSqlEntities.Entities;
using Northwind_BackEndCommon.Services;
namespace Northwind_CommonTests.HydratedStaticIndirectReferenceTransformerModels;
public partial class Northwind_HydratedStaticIndirectReferenceTransformerModels : Northwind_HydratedStaticIndirectReferenceTransformerModelsBase
{
	public Northwind_dbo_Categories_IR GetHydratedStaticNorthwind_dbo_Categories_IR(Boolean fillPrimaryKey = false)
	{
		var retObj = new Northwind_dbo_Categories_IR();
		retObj.CategoryID_IR = (fillPrimaryKey ? _encryptionDecryptionService!.EncInt32(Convert.ToInt32(1)) : String.Empty);
		retObj.CategoryName = "0NSUK10xJJjukYH";
		retObj.Description = "KKv8OKV8AriGN9HWXK8yndpZuFmohToOdg635ObpjKPPVnuJyJPlPeBndrQ7j3BmZSX3xuv grX6cbNOF1dahaLQijUVBMf0IDQn";
		retObj.Picture = new Byte[] { 102, 131, 19, 254, 218, 254, 243, 210, 20, 152, 238, 137, 193, 251, 105, 105, 162, 239, 14, 21, 133, 32, 25, 165, 150, 36, 191, 175, 210, 175, 57, 60, 149, 167, 125, 144, 93, 168, 217, 118, 183, 34, 201, 215, 121, 247, 72, 159, 134, 250, 184, 137, 149, 112, 114, 214, 226, 173, 219, 82, 152, 117, 163, 20, 240, 25, 13, 237, 81, 23, 220, 181, 226, 141, 142, 96, 32, 237, 43, 56, 1, 197, 107, 243, 239, 198, 240, 170, 184, 245, 198, 104, 111, 139, 101, 165, 224, 32, 40, 96 };
		return retObj;
	}
}
