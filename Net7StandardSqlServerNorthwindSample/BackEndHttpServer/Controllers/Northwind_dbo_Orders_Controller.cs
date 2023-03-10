/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307200434 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Standard Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using Northwind_BackEndSqlEntities.Entities;
using Northwind_BackEndCommon.RequestHandlers;
namespace Northwind_BackEndDatabaseClient.Controllers;
[SwaggerTag(@"Controller Description: N/A")]
[RequireHttps]
public class Northwind_dbo_Orders_Controller : ControllerBase
{
	private readonly INorthwind_dbo_Orders_RequestHandler _requestHandler;
	public Northwind_dbo_Orders_Controller(INorthwind_dbo_Orders_RequestHandler requestHandler)
	{
		_requestHandler = requestHandler;
	}
	/// <summary>
	/// Get All records of Orders table
	/// </summary>
	[HttpGet, Route("Northwind_dbo_Orders/GetAll")]
	public async Task<IEnumerable<Northwind_dbo_Orders>?> GetAll()
	{
		return await _requestHandler.HandleGetAll();
	}
	/// <summary>
	/// Get record of Orders table by indexed selector(s)
	/// </summary>
	[HttpGet, Route("Northwind_dbo_Orders/GetByCustomerID")]
	public async Task<IEnumerable<Northwind_dbo_Orders>?> GetByCustomerID(String? customerID)
	{
		return await _requestHandler.HandleGetByCustomerID(customerID);
	}
	/// <summary>
	/// Get record of Orders table by indexed selector(s)
	/// </summary>
	[HttpGet, Route("Northwind_dbo_Orders/GetByEmployeeID")]
	public async Task<IEnumerable<Northwind_dbo_Orders>?> GetByEmployeeID(Int32? employeeID)
	{
		return await _requestHandler.HandleGetByEmployeeID(employeeID);
	}
	/// <summary>
	/// Get record of Orders table by indexed selector(s)
	/// </summary>
	[HttpGet, Route("Northwind_dbo_Orders/GetByOrderDate")]
	public async Task<IEnumerable<Northwind_dbo_Orders>?> GetByOrderDate(DateTime? orderDate)
	{
		return await _requestHandler.HandleGetByOrderDate(orderDate);
	}
	/// <summary>
	/// Get record of Orders table by indexed selector(s)
	/// </summary>
	[HttpGet, Route("Northwind_dbo_Orders/GetByOrderID")]
	public async Task<IEnumerable<Northwind_dbo_Orders>?> GetByOrderID(Int32 orderID)
	{
		return await _requestHandler.HandleGetByOrderID(orderID);
	}
	/// <summary>
	/// Get record of Orders table by indexed selector(s)
	/// </summary>
	[HttpGet, Route("Northwind_dbo_Orders/GetByShippedDate")]
	public async Task<IEnumerable<Northwind_dbo_Orders>?> GetByShippedDate(DateTime? shippedDate)
	{
		return await _requestHandler.HandleGetByShippedDate(shippedDate);
	}
	/// <summary>
	/// Get record of Orders table by indexed selector(s)
	/// </summary>
	[HttpGet, Route("Northwind_dbo_Orders/GetByShipVia")]
	public async Task<IEnumerable<Northwind_dbo_Orders>?> GetByShipVia(Int32? shipVia)
	{
		return await _requestHandler.HandleGetByShipVia(shipVia);
	}
	/// <summary>
	/// Get record of Orders table by indexed selector(s)
	/// </summary>
	[HttpGet, Route("Northwind_dbo_Orders/GetByShipPostalCode")]
	public async Task<IEnumerable<Northwind_dbo_Orders>?> GetByShipPostalCode(String? shipPostalCode)
	{
		return await _requestHandler.HandleGetByShipPostalCode(shipPostalCode);
	}
	/// <summary>
	/// Create and return record of Orders table
	/// Note: Any foreign key data referenced by or referencing these records should not be included in the body payload
	/// </summary>
	[HttpPost, Route("Northwind_dbo_Orders/Create")]
	public async Task<Northwind_dbo_Orders?> Create([FromBody]Northwind_dbo_Orders input)
	{
		return await _requestHandler.HandleCreate(input);
	}
	/// <summary>
	/// Update record of Orders table by indexed selector(s)
	/// Note: Any foreign key data referenced by or referencing these records should not be included in the body payload
	/// </summary>
	[HttpPut, Route("Northwind_dbo_Orders/UpdateByCustomerID")]
	public async Task UpdateByCustomerID(String? customerID, [FromBody]Northwind_dbo_Orders input)
	{
		await _requestHandler.HandleUpdateByCustomerID(customerID, input);
	}
	/// <summary>
	/// Update record of Orders table by indexed selector(s)
	/// Note: Any foreign key data referenced by or referencing these records should not be included in the body payload
	/// </summary>
	[HttpPut, Route("Northwind_dbo_Orders/UpdateByEmployeeID")]
	public async Task UpdateByEmployeeID(Int32? employeeID, [FromBody]Northwind_dbo_Orders input)
	{
		await _requestHandler.HandleUpdateByEmployeeID(employeeID, input);
	}
	/// <summary>
	/// Update record of Orders table by indexed selector(s)
	/// Note: Any foreign key data referenced by or referencing these records should not be included in the body payload
	/// </summary>
	[HttpPut, Route("Northwind_dbo_Orders/UpdateByOrderDate")]
	public async Task UpdateByOrderDate(DateTime? orderDate, [FromBody]Northwind_dbo_Orders input)
	{
		await _requestHandler.HandleUpdateByOrderDate(orderDate, input);
	}
	/// <summary>
	/// Update record of Orders table by indexed selector(s)
	/// Note: Any foreign key data referenced by or referencing these records should not be included in the body payload
	/// </summary>
	[HttpPut, Route("Northwind_dbo_Orders/UpdateByOrderID")]
	public async Task UpdateByOrderID(Int32 orderID, [FromBody]Northwind_dbo_Orders input)
	{
		await _requestHandler.HandleUpdateByOrderID(orderID, input);
	}
	/// <summary>
	/// Update record of Orders table by indexed selector(s)
	/// Note: Any foreign key data referenced by or referencing these records should not be included in the body payload
	/// </summary>
	[HttpPut, Route("Northwind_dbo_Orders/UpdateByShippedDate")]
	public async Task UpdateByShippedDate(DateTime? shippedDate, [FromBody]Northwind_dbo_Orders input)
	{
		await _requestHandler.HandleUpdateByShippedDate(shippedDate, input);
	}
	/// <summary>
	/// Update record of Orders table by indexed selector(s)
	/// Note: Any foreign key data referenced by or referencing these records should not be included in the body payload
	/// </summary>
	[HttpPut, Route("Northwind_dbo_Orders/UpdateByShipVia")]
	public async Task UpdateByShipVia(Int32? shipVia, [FromBody]Northwind_dbo_Orders input)
	{
		await _requestHandler.HandleUpdateByShipVia(shipVia, input);
	}
	/// <summary>
	/// Update record of Orders table by indexed selector(s)
	/// Note: Any foreign key data referenced by or referencing these records should not be included in the body payload
	/// </summary>
	[HttpPut, Route("Northwind_dbo_Orders/UpdateByShipPostalCode")]
	public async Task UpdateByShipPostalCode(String? shipPostalCode, [FromBody]Northwind_dbo_Orders input)
	{
		await _requestHandler.HandleUpdateByShipPostalCode(shipPostalCode, input);
	}
	/// <summary>
	/// Delete record of Orders table by indexed selector(s)
	/// </summary>
	[HttpDelete, Route("Northwind_dbo_Orders/DeleteByCustomerID")]
	public async Task DeleteByCustomerID(String? customerID)
	{
		await _requestHandler.HandleDeleteByCustomerID(customerID);
	}
	/// <summary>
	/// Delete record of Orders table by indexed selector(s)
	/// </summary>
	[HttpDelete, Route("Northwind_dbo_Orders/DeleteByEmployeeID")]
	public async Task DeleteByEmployeeID(Int32? employeeID)
	{
		await _requestHandler.HandleDeleteByEmployeeID(employeeID);
	}
	/// <summary>
	/// Delete record of Orders table by indexed selector(s)
	/// </summary>
	[HttpDelete, Route("Northwind_dbo_Orders/DeleteByOrderDate")]
	public async Task DeleteByOrderDate(DateTime? orderDate)
	{
		await _requestHandler.HandleDeleteByOrderDate(orderDate);
	}
	/// <summary>
	/// Delete record of Orders table by indexed selector(s)
	/// </summary>
	[HttpDelete, Route("Northwind_dbo_Orders/DeleteByOrderID")]
	public async Task DeleteByOrderID(Int32 orderID)
	{
		await _requestHandler.HandleDeleteByOrderID(orderID);
	}
	/// <summary>
	/// Delete record of Orders table by indexed selector(s)
	/// </summary>
	[HttpDelete, Route("Northwind_dbo_Orders/DeleteByShippedDate")]
	public async Task DeleteByShippedDate(DateTime? shippedDate)
	{
		await _requestHandler.HandleDeleteByShippedDate(shippedDate);
	}
	/// <summary>
	/// Delete record of Orders table by indexed selector(s)
	/// </summary>
	[HttpDelete, Route("Northwind_dbo_Orders/DeleteByShipVia")]
	public async Task DeleteByShipVia(Int32? shipVia)
	{
		await _requestHandler.HandleDeleteByShipVia(shipVia);
	}
	/// <summary>
	/// Delete record of Orders table by indexed selector(s)
	/// </summary>
	[HttpDelete, Route("Northwind_dbo_Orders/DeleteByShipPostalCode")]
	public async Task DeleteByShipPostalCode(String? shipPostalCode)
	{
		await _requestHandler.HandleDeleteByShipPostalCode(shipPostalCode);
	}
}
