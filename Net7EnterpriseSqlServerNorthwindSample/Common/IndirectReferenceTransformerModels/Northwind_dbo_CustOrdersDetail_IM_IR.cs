/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307200636 on behalf of: ****
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
namespace Northwind_Common.IndirectReferenceTransformerModels;
/// <summary>
/// Sql Entity Description: Model Description: Stored Procedure Input Model
/// </summary>
public class Northwind_dbo_CustOrdersDetail_IM_IR
{
	public Northwind_dbo_CustOrdersDetail_IM_IR() 
	{
	} 
	public Northwind_dbo_CustOrdersDetail_IM_IR(
		String? orderID_IR_
	)
	{
		OrderID_IR = orderID_IR_;
	}
	[JsonConstructor]
	public Northwind_dbo_CustOrdersDetail_IM_IR(
		String? OrderID_IR,
		String? OrderID_IR_OriginalValue,
		Boolean OrderID_IR_HasBeenChanged
	)
	{
		this.OrderID_IR = OrderID_IR;
		this.OrderID_IR_OriginalValue = OrderID_IR_OriginalValue;
		this.OrderID_IR_HasBeenChanged = OrderID_IR_HasBeenChanged;
	}
	public String? OrderID_IR
	{
		get => _orderID_IR;
		set
		{
			_orderID_IR = value;
			OrderID_IR_HasBeenChanged = _orderID_IR == OrderID_IR_OriginalValue ? false : true;
		}
	}
	private String? _orderID_IR;
	public String? OrderID_IR_OriginalValue { get; private set; }
	public Boolean OrderID_IR_HasBeenChanged { get; private set; }
}
