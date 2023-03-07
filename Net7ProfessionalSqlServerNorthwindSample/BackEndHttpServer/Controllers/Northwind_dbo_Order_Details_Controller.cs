/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307200541 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Professional Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using Northwind_Common.IndirectReferenceTransformerModels;
using Northwind_BackEndCommon.RequestHandlers;
namespace Northwind_BackEndDatabaseClient.Controllers;
[SwaggerTag(@"Controller Description: N/A")]
[RequireHttps]
public class Northwind_dbo_Order_Details_Controller : ControllerBase
{
	private readonly INorthwind_dbo_Order_Details_RequestHandler _requestHandler;
	public Northwind_dbo_Order_Details_Controller(INorthwind_dbo_Order_Details_RequestHandler requestHandler)
	{
		_requestHandler = requestHandler;
	}
	/// <summary>
	/// Get All records of Order_Details table
	/// </summary>
	[HttpGet, Route("Northwind_dbo_Order_Details/GetAll")]
	public async Task<IEnumerable<Northwind_dbo_Order_Details_IR>?> GetAll()
	{
		return await _requestHandler.HandleGetAll();
	}
	/// <summary>
	/// Get record of Order_Details table by indexed selector(s)
	/// </summary>
	[HttpGet, Route("Northwind_dbo_Order_Details/GetByOrderIDAndProductID")]
	public async Task<IEnumerable<Northwind_dbo_Order_Details_IR>?> GetByOrderIDAndProductID(String? orderID_IR, String? productID_IR)
	{
		return await _requestHandler.HandleGetByOrderIDAndProductID(orderID_IR, productID_IR);
	}
	/// <summary>
	/// Get record of Order_Details table by indexed selector(s)
	/// </summary>
	[HttpGet, Route("Northwind_dbo_Order_Details/GetByOrderID")]
	public async Task<IEnumerable<Northwind_dbo_Order_Details_IR>?> GetByOrderID(String? orderID_IR)
	{
		return await _requestHandler.HandleGetByOrderID(orderID_IR);
	}
	/// <summary>
	/// Get record of Order_Details table by indexed selector(s)
	/// </summary>
	[HttpGet, Route("Northwind_dbo_Order_Details/GetByProductID")]
	public async Task<IEnumerable<Northwind_dbo_Order_Details_IR>?> GetByProductID(String? productID_IR)
	{
		return await _requestHandler.HandleGetByProductID(productID_IR);
	}
	/// <summary>
	/// Create and return record of Order_Details table
	/// Note: Any foreign key data referenced by or referencing these records should not be included in the body payload
	/// </summary>
	[HttpPost, Route("Northwind_dbo_Order_Details/Create")]
	public async Task<Northwind_dbo_Order_Details_IR?> Create([FromBody]Northwind_dbo_Order_Details_IR input)
	{
		return await _requestHandler.HandleCreate(input);
	}
	/// <summary>
	/// Update record of Order_Details table by indexed selector(s)
	/// Note: Any foreign key data referenced by or referencing these records should not be included in the body payload
	/// </summary>
	[HttpPut, Route("Northwind_dbo_Order_Details/UpdateByOrderIDAndProductID")]
	public async Task UpdateByOrderIDAndProductID(String? orderID_IR, String? productID_IR, [FromBody]Northwind_dbo_Order_Details_IR input)
	{
		await _requestHandler.HandleUpdateByOrderIDAndProductID(orderID_IR, productID_IR, input);
	}
	/// <summary>
	/// Update record of Order_Details table by indexed selector(s)
	/// Note: Any foreign key data referenced by or referencing these records should not be included in the body payload
	/// </summary>
	[HttpPut, Route("Northwind_dbo_Order_Details/UpdateByOrderID")]
	public async Task UpdateByOrderID(String? orderID_IR, [FromBody]Northwind_dbo_Order_Details_IR input)
	{
		await _requestHandler.HandleUpdateByOrderID(orderID_IR, input);
	}
	/// <summary>
	/// Update record of Order_Details table by indexed selector(s)
	/// Note: Any foreign key data referenced by or referencing these records should not be included in the body payload
	/// </summary>
	[HttpPut, Route("Northwind_dbo_Order_Details/UpdateByProductID")]
	public async Task UpdateByProductID(String? productID_IR, [FromBody]Northwind_dbo_Order_Details_IR input)
	{
		await _requestHandler.HandleUpdateByProductID(productID_IR, input);
	}
	/// <summary>
	/// Delete record of Order_Details table by indexed selector(s)
	/// </summary>
	[HttpDelete, Route("Northwind_dbo_Order_Details/DeleteByOrderIDAndProductID")]
	public async Task DeleteByOrderIDAndProductID(String? orderID_IR, String? productID_IR)
	{
		await _requestHandler.HandleDeleteByOrderIDAndProductID(orderID_IR, productID_IR);
	}
	/// <summary>
	/// Delete record of Order_Details table by indexed selector(s)
	/// </summary>
	[HttpDelete, Route("Northwind_dbo_Order_Details/DeleteByOrderID")]
	public async Task DeleteByOrderID(String? orderID_IR)
	{
		await _requestHandler.HandleDeleteByOrderID(orderID_IR);
	}
	/// <summary>
	/// Delete record of Order_Details table by indexed selector(s)
	/// </summary>
	[HttpDelete, Route("Northwind_dbo_Order_Details/DeleteByProductID")]
	public async Task DeleteByProductID(String? productID_IR)
	{
		await _requestHandler.HandleDeleteByProductID(productID_IR);
	}
}