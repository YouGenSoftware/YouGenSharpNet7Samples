/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307200541 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Professional Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
using Microsoft.AspNetCore.SignalR.Client;
using Northwind_Common.IndirectReferenceTransformerModels;
namespace Northwind_FrontEndSignalRWebsocketClient.SignalRWebsocketClients;
public class Northwind_dbo_Order_Details_Extended_SignalRWebsocketClient : SignalRWebsocketClientBase, INorthwind_dbo_Order_Details_Extended_SignalRWebsocketClient, IAsyncDisposable
{
	public Northwind_dbo_Order_Details_Extended_SignalRWebsocketClient(String hubUrl) : base(hubUrl)
    {
    }
	public async Task<IEnumerable<Northwind_dbo_Order_Details_Extended_IR>?> GetByBestMatchedQueryPattern(Northwind_dbo_Order_Details_Extended_IR input)
	{
		if (input == null) return null;
		IEnumerable<Northwind_dbo_Order_Details_Extended_IR>? retData;
		retData = await GetAll();
		return retData == null ? null : retData.Where(x => WhereAllFilledFields(x, input));
	}
	private static Boolean WhereAllFilledFields(Northwind_dbo_Order_Details_Extended_IR record, Northwind_dbo_Order_Details_Extended_IR filter)
	{
		return 			(!filter.OrderID_IR_HasBeenChanged || record.OrderID_IR == filter.OrderID_IR) &&
			(!filter.ProductID_IR_HasBeenChanged || record.ProductID_IR == filter.ProductID_IR) &&
			(!filter.ProductName_HasBeenChanged || record.ProductName == filter.ProductName) &&
			(!filter.UnitPrice_HasBeenChanged || record.UnitPrice == filter.UnitPrice) &&
			(!filter.Quantity_HasBeenChanged || record.Quantity == filter.Quantity) &&
			(!filter.Discount_HasBeenChanged || record.Discount == filter.Discount) &&
			(!filter.ExtendedPrice_HasBeenChanged || record.ExtendedPrice == filter.ExtendedPrice);
	}
	public async Task<IEnumerable<Northwind_dbo_Order_Details_Extended_IR>?> GetAll()
	{
		return await _hubConnection.InvokeAsync<IEnumerable<Northwind_dbo_Order_Details_Extended_IR>?>("GetAll");
	}
    public async Task InitializeAsync()
    {
        await base.EstablishConnection();
    }
    public Boolean GetStatus()
    {
        return base.Initiated;
    }
    public async ValueTask DisposeAsync()
    {
        await base.TerminateConnection();
        GC.SuppressFinalize(this);
    }
}