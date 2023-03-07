/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307202958 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Enterprise Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
namespace XE_HR_Common.IndirectReferenceTransformerModels;
/// <summary>
/// Sql Entity Description: Model Description: Stored Procedure Output Model
/// </summary>
public class XE_HR_PACKAGE1_FUNCCONVERTDECIMALTOVARCHAR_OM_IR
{
	public XE_HR_PACKAGE1_FUNCCONVERTDECIMALTOVARCHAR_OM_IR() 
	{
	} 
	public XE_HR_PACKAGE1_FUNCCONVERTDECIMALTOVARCHAR_OM_IR(
		String? functionReturnParam_
	)
	{
		FunctionReturnParam = functionReturnParam_;
	}
	[JsonConstructor]
	public XE_HR_PACKAGE1_FUNCCONVERTDECIMALTOVARCHAR_OM_IR(
		String? FunctionReturnParam,
		String? FunctionReturnParam_OriginalValue,
		Boolean FunctionReturnParam_HasBeenChanged
	)
	{
		this.FunctionReturnParam = FunctionReturnParam;
		this.FunctionReturnParam_OriginalValue = FunctionReturnParam_OriginalValue;
		this.FunctionReturnParam_HasBeenChanged = FunctionReturnParam_HasBeenChanged;
	}
	public String? FunctionReturnParam
	{
		get => _functionReturnParam;
		set
		{
			_functionReturnParam = value;
			FunctionReturnParam_HasBeenChanged = _functionReturnParam == FunctionReturnParam_OriginalValue ? false : true;
		}
	}
	private String? _functionReturnParam;
	public String? FunctionReturnParam_OriginalValue { get; private set; }
	public Boolean FunctionReturnParam_HasBeenChanged { get; private set; }
}