/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307200636 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Enterprise Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Northwind_Common.IndirectReferenceTransformerModels;
using Northwind_BackEndDatabaseClient.Repositories;
using Northwind_Common.Validators;
using Northwind_BackEndCommon.IndirectReferenceTransformers;
using Northwind_BackEndCommon.Services;
namespace Northwind_BackEndCommon.RequestHandlers;
public class Northwind_dbo_Territories_RequestHandler : INorthwind_dbo_Territories_RequestHandler
{
    private readonly ILogger<Northwind_dbo_Territories_RequestHandler> _logger;
    private readonly IEncryptionDecryptionService _encryptionDecryptionService; 
    private readonly IIRTransformers _indirectReferenceTransformers;
    private readonly INorthwind_dbo_Territories_Repository _repository;
    private readonly Northwind_dbo_Territories_IR_FluentValidator_Create _createValidator;
    private readonly Northwind_dbo_Territories_IR_FluentValidator_Read _readValidator;
    private readonly Northwind_dbo_Territories_IR_FluentValidator_Update _updateValidator;
    private readonly Northwind_dbo_Territories_IR_FluentValidator_Delete _deleteValidator;
    public Northwind_dbo_Territories_RequestHandler(
        ILogger<Northwind_dbo_Territories_RequestHandler> logger
        ,IEncryptionDecryptionService encryptionDecryptionService
        ,IIRTransformers indirectReferenceTransformers
        ,INorthwind_dbo_Territories_Repository repository 
        ,Northwind_dbo_Territories_IR_FluentValidator_Create createValidator
        ,Northwind_dbo_Territories_IR_FluentValidator_Read readValidator
        ,Northwind_dbo_Territories_IR_FluentValidator_Update updateValidator
        ,Northwind_dbo_Territories_IR_FluentValidator_Delete deleteValidator
    )
    {
        _logger = logger;
        _encryptionDecryptionService = encryptionDecryptionService;
        _indirectReferenceTransformers = indirectReferenceTransformers;
        _repository = repository;
        _createValidator = createValidator;
        _readValidator = readValidator;
        _updateValidator = updateValidator;
        _deleteValidator = deleteValidator;
    }
	//Main Handlers
	public async Task<IEnumerable<Northwind_dbo_Territories_IR>?> HandleGetAll()
	{
		await PreHandleGetAll();
		var retData = await _repository.GetAll();
		await PostHandleGetAll();
		return retData == null || !retData.Any() ? Enumerable.Empty<Northwind_dbo_Territories_IR>() : retData.Select(x => _indirectReferenceTransformers.ToIndirectModel(x)!).ToList();
	}
	public async Task<IEnumerable<Northwind_dbo_Territories_IR>?> HandleGetByTerritoryID(String territoryID)
	{
		await PreHandleGetByTerritoryID(territoryID);
		var retData = await _repository.GetByTerritoryID((territoryID));
		await PostHandleGetByTerritoryID(territoryID);
		return retData == null || !retData.Any() ? Enumerable.Empty<Northwind_dbo_Territories_IR>() : retData.Select(x => _indirectReferenceTransformers.ToIndirectModel(x)!).ToList();
	}
	public async Task<Northwind_dbo_Territories_IR?> HandleCreate<T>(T irModel) where T : Northwind_dbo_Territories_IR
	{
		var entity = _indirectReferenceTransformers.ToEntity(irModel);
		await PreHandleCreate(irModel);
		entity = await _repository.Create(entity!);
		if (entity != null) 
		{
			await PostHandleCreate(irModel);
			return _indirectReferenceTransformers.ToIndirectModel(entity!);
		}
		else
			return null;
	}
	public async Task HandleUpdateByTerritoryID<T>(String territoryID, T irModel) where T : Northwind_dbo_Territories_IR
	{
		var entity = _indirectReferenceTransformers.ToEntity(irModel);
		await PreHandleUpdateByTerritoryID(territoryID, irModel);
		await _repository.UpdateByTerritoryID((territoryID), entity!);
		await PostHandleUpdateByTerritoryID(territoryID, irModel);
	}
	public async Task HandleDeleteByTerritoryID(String territoryID)
	{
		await PreHandleDeleteByTerritoryID(territoryID);
		await _repository.DeleteByTerritoryID((territoryID));
		await PostHandleDeleteByTerritoryID(territoryID);
	}
	//PreCRUD Handlers
	private async Task PreHandleGetAll()
	{
		// Add preCRUD calls/events
		// Remove the line below after adding optional async logic
		await Task.CompletedTask;
	}
	private async Task PreHandleGetByTerritoryID(String territoryID)
	{
		// Add preCRUD calls/events
		var selectorProperties = new Northwind_dbo_Territories_IR();
		selectorProperties.TerritoryID = territoryID;
		await _readValidator.ValidateModelAndThrow(selectorProperties);
	}
	private async Task PreHandleCreate(Northwind_dbo_Territories_IR irModel)
	{
		// Add preCRUD calls/events
		await _createValidator.ValidateModelAndThrow(irModel);
	}
	private async Task PreHandleUpdateByTerritoryID(String territoryID, Northwind_dbo_Territories_IR irModel)
	{
		// Add preCRUD calls/events
		var selectorProperties = new Northwind_dbo_Territories_IR();
		selectorProperties.TerritoryID = territoryID;
		await _readValidator.ValidateModelAndThrow(selectorProperties);
		await _updateValidator.ValidateModelAndThrow(irModel);
	}
	private async Task PreHandleDeleteByTerritoryID(String territoryID)
	{
		// Add preCRUD calls/events
		var selectorProperties = new Northwind_dbo_Territories_IR();
		selectorProperties.TerritoryID = territoryID;
		await _deleteValidator.ValidateModelAndThrow(selectorProperties);
	}
	//PostCRUD Handlers
	private async Task PostHandleGetAll()
	{
		// Add postCRUD calls/events
		// Remove the line below after adding optional async logic
		await Task.CompletedTask;
	}
	private async Task PostHandleGetByTerritoryID(String territoryID)
	{
		// Add postCRUD calls/events
		// Remove the line below after adding optional async logic
		await Task.CompletedTask;
	}
	private async Task PostHandleCreate(Northwind_dbo_Territories_IR irModel)
	{
		// Add postCRUD calls/events
		// Remove the line below after adding optional async logic
		await Task.CompletedTask;
	}
	private async Task PostHandleUpdateByTerritoryID(String territoryID, Northwind_dbo_Territories_IR irModel)
	{
		// Add postCRUD calls/events
		// Remove the line below after adding optional async logic
		await Task.CompletedTask;
	}
	private async Task PostHandleDeleteByTerritoryID(String territoryID)
	{
		// Add postCRUD calls/events
		// Remove the line below after adding optional async logic
		await Task.CompletedTask;
	}
}
