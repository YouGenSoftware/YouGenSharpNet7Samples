/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307200636 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Enterprise Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
using Microsoft.AspNetCore.SignalR;
using Northwind_Common.IndirectReferenceTransformerModels;
using Northwind_BackEndCommon.RequestHandlers;
namespace Northwind_BackEndSignalRWebsocketServer.Hubs;
public class Northwind_dbo_Products_Hub : Hub<INorthwind_dbo_Products_Hub>
{
	private readonly INorthwind_dbo_Products_RequestHandler _requestHandler;
	public Northwind_dbo_Products_Hub(INorthwind_dbo_Products_RequestHandler requestHandler)
	{
		_requestHandler = requestHandler;
	}
	public async Task<IEnumerable<Northwind_dbo_Products_IR>?> GetAll()
	{
		return await _requestHandler.HandleGetAll();
	}
	public async Task<IEnumerable<Northwind_dbo_Products_IR>?> GetByCategoryID(String? categoryID_IR)
	{
		return await _requestHandler.HandleGetByCategoryID(categoryID_IR);
	}
	public async Task<IEnumerable<Northwind_dbo_Products_IR>?> GetByProductID(String? productID_IR)
	{
		return await _requestHandler.HandleGetByProductID(productID_IR);
	}
	public async Task<IEnumerable<Northwind_dbo_Products_IR>?> GetByProductName(String productName)
	{
		return await _requestHandler.HandleGetByProductName(productName);
	}
	public async Task<IEnumerable<Northwind_dbo_Products_IR>?> GetBySupplierID(String? supplierID_IR)
	{
		return await _requestHandler.HandleGetBySupplierID(supplierID_IR);
	}
	public async Task<Northwind_dbo_Products_IR?> Create(Northwind_dbo_Products_IR input)
	{
		return await _requestHandler.HandleCreate(input);
	}
	public async Task UpdateByCategoryID(String? categoryID_IR, Northwind_dbo_Products_IR input)
	{
		await _requestHandler.HandleUpdateByCategoryID(categoryID_IR, input);
	}
	public async Task UpdateByProductID(String? productID_IR, Northwind_dbo_Products_IR input)
	{
		await _requestHandler.HandleUpdateByProductID(productID_IR, input);
	}
	public async Task UpdateByProductName(String productName, Northwind_dbo_Products_IR input)
	{
		await _requestHandler.HandleUpdateByProductName(productName, input);
	}
	public async Task UpdateBySupplierID(String? supplierID_IR, Northwind_dbo_Products_IR input)
	{
		await _requestHandler.HandleUpdateBySupplierID(supplierID_IR, input);
	}
	public async Task DeleteByCategoryID(String? categoryID_IR)
	{
		await _requestHandler.HandleDeleteByCategoryID(categoryID_IR);
	}
	public async Task DeleteByProductID(String? productID_IR)
	{
		await _requestHandler.HandleDeleteByProductID(productID_IR);
	}
	public async Task DeleteByProductName(String productName)
	{
		await _requestHandler.HandleDeleteByProductName(productName);
	}
	public async Task DeleteBySupplierID(String? supplierID_IR)
	{
		await _requestHandler.HandleDeleteBySupplierID(supplierID_IR);
	}
}