/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307200636 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Enterprise Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using Z.EntityFramework.Plus;
using Northwind_BackEndDatabaseClient;
using Northwind_BackEndSqlEntities.Entities;
namespace Northwind_BackEndDatabaseClient.Repositories;
public class Northwind_dbo_Territories_Repository : GenericTableRepository<Northwind_dbo_Territories>, INorthwind_dbo_Territories_Repository
{
    private readonly ILogger<Northwind_dbo_Territories_Repository> _logger;    
    public Northwind_dbo_Territories_Repository
    (
        ILogger<Northwind_dbo_Territories_Repository> logger
        ,Northwind_Context dbContext
    ) : base(dbContext)
    {
        _logger = logger;
    }
	public async Task<IEnumerable<Northwind_dbo_Territories>?> GetByTerritoryID(String territoryID_)
	{
		return await _dbContext.Northwind_dbo_Territories!
			.Where(x => x.TerritoryID == territoryID_)
			.Include(x => x.FK_Territories_Region_Ref)
			.AsNoTracking()
			.ToListAsync();
	}
	public async Task UpdateByTerritoryID(String territoryID_, Northwind_dbo_Territories entity)
	{
		await _dbContext.Northwind_dbo_Territories!
			.Where(x => x.TerritoryID == territoryID_)
			.UpdateFromQueryAsync(x => new Northwind_dbo_Territories(){ TerritoryDescription = entity.TerritoryDescription, RegionID = entity.RegionID });
	}
	public async Task DeleteByTerritoryID(String territoryID_)
	{
		await _dbContext.Northwind_dbo_Territories!
			.Where(x => x.TerritoryID == territoryID_)
			.DeleteFromQueryAsync();
	}
}