/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307200636 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Enterprise Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
using Northwind_BackEndSqlEntities.Entities;
using Northwind_BackEndCommon.Services;
using Northwind_Common.IndirectReferenceTransformerModels;
namespace Northwind_BackEndCommon.IndirectReferenceTransformers;
public partial class IRTransformers : IIRTransformers
{
	public Northwind_dbo_Employee_Sales_by_Country_IM_IR ToIndirectModel(Northwind_dbo_Employee_Sales_by_Country_IM input)
	{
		var retData = new Northwind_dbo_Employee_Sales_by_Country_IM_IR(
			beginning_Date_ : input.Beginning_Date,
			ending_Date_ : input.Ending_Date
		);
		return retData;
	}
	public Northwind_dbo_Employee_Sales_by_Country_IM ToEntity(Northwind_dbo_Employee_Sales_by_Country_IM_IR input)
	{
		var retData = new Northwind_dbo_Employee_Sales_by_Country_IM(		
			beginning_Date_ : input.Beginning_Date,
			ending_Date_ : input.Ending_Date
		);
		return retData;
	}
}