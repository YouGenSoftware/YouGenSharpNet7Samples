/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307200434 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Standard Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Northwind_BackEndDatabaseClient.Repositories;
using Northwind_BackEndSqlEntities.Entities;
namespace Northwind_BackEndCommon.RequestHandlers;
public class Northwind_dbo_Customers_RequestHandler : INorthwind_dbo_Customers_RequestHandler
{
    private readonly ILogger<Northwind_dbo_Customers_RequestHandler> _logger;
    private readonly INorthwind_dbo_Customers_Repository _repository;
    public Northwind_dbo_Customers_RequestHandler(
    ILogger<Northwind_dbo_Customers_RequestHandler> logger
    ,INorthwind_dbo_Customers_Repository repository)
    {
        _logger = logger;
        _repository = repository;
    }
	//Main Handlers
	public async Task<IEnumerable<Northwind_dbo_Customers>?> HandleGetAll()
	{
		var retData = await _repository.GetAll();
		return retData;
	}
	public async Task<IEnumerable<Northwind_dbo_Customers>?> HandleGetByCity(String? city)
	{
		var retData = await _repository.GetByCity(city);
		return retData;
	}
	public async Task<IEnumerable<Northwind_dbo_Customers>?> HandleGetByCompanyName(String companyName)
	{
		var retData = await _repository.GetByCompanyName(companyName);
		return retData;
	}
	public async Task<IEnumerable<Northwind_dbo_Customers>?> HandleGetByCustomerID(String customerID)
	{
		var retData = await _repository.GetByCustomerID(customerID);
		return retData;
	}
	public async Task<IEnumerable<Northwind_dbo_Customers>?> HandleGetByPostalCode(String? postalCode)
	{
		var retData = await _repository.GetByPostalCode(postalCode);
		return retData;
	}
	public async Task<IEnumerable<Northwind_dbo_Customers>?> HandleGetByRegion(String? region)
	{
		var retData = await _repository.GetByRegion(region);
		return retData;
	}
	public async Task<Northwind_dbo_Customers?> HandleCreate(Northwind_dbo_Customers input)
	{
		var results = await _repository.Create(input);
		return results;
	}
	public async Task HandleUpdateByCity(String? city, Northwind_dbo_Customers entity)
	{
		await _repository.UpdateByCity(city, entity);
	}
	public async Task HandleUpdateByCompanyName(String companyName, Northwind_dbo_Customers entity)
	{
		await _repository.UpdateByCompanyName(companyName, entity);
	}
	public async Task HandleUpdateByCustomerID(String customerID, Northwind_dbo_Customers entity)
	{
		await _repository.UpdateByCustomerID(customerID, entity);
	}
	public async Task HandleUpdateByPostalCode(String? postalCode, Northwind_dbo_Customers entity)
	{
		await _repository.UpdateByPostalCode(postalCode, entity);
	}
	public async Task HandleUpdateByRegion(String? region, Northwind_dbo_Customers entity)
	{
		await _repository.UpdateByRegion(region, entity);
	}
	public async Task HandleDeleteByCity(String? city)
	{
		await _repository.DeleteByCity(city);
	}
	public async Task HandleDeleteByCompanyName(String companyName)
	{
		await _repository.DeleteByCompanyName(companyName);
	}
	public async Task HandleDeleteByCustomerID(String customerID)
	{
		await _repository.DeleteByCustomerID(customerID);
	}
	public async Task HandleDeleteByPostalCode(String? postalCode)
	{
		await _repository.DeleteByPostalCode(postalCode);
	}
	public async Task HandleDeleteByRegion(String? region)
	{
		await _repository.DeleteByRegion(region);
	}
}
