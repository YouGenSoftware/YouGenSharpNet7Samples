/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307202926 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Professional Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using XE_HR_Common.IndirectReferenceTransformerModels;
using XE_HR_BackEndCommon.RequestHandlers;
namespace XE_HR_BackEndDatabaseClient.Controllers;
[SwaggerTag(@"Controller Description: N/A")]
[RequireHttps]
public class XE_HR_REGIONS_Controller : ControllerBase
{
	private readonly IXE_HR_REGIONS_RequestHandler _requestHandler;
	public XE_HR_REGIONS_Controller(IXE_HR_REGIONS_RequestHandler requestHandler)
	{
		_requestHandler = requestHandler;
	}
	/// <summary>
	/// Get All records of REGIONS table
	/// </summary>
	[HttpGet, Route("XE_HR_REGIONS/GetAll")]
	public async Task<IEnumerable<XE_HR_REGIONS_IR>?> GetAll()
	{
		return await _requestHandler.HandleGetAll();
	}
	/// <summary>
	/// Get record of REGIONS table by indexed selector(s)
	/// </summary>
	[HttpGet, Route("XE_HR_REGIONS/GetByREGION_ID")]
	public async Task<IEnumerable<XE_HR_REGIONS_IR>?> GetByREGION_ID(String? rEGION_ID_IR)
	{
		return await _requestHandler.HandleGetByREGION_ID(rEGION_ID_IR);
	}
	/// <summary>
	/// Create and return record of REGIONS table
	/// Note: Any foreign key data referenced by or referencing these records should not be included in the body payload
	/// </summary>
	[HttpPost, Route("XE_HR_REGIONS/Create")]
	public async Task<XE_HR_REGIONS_IR?> Create([FromBody]XE_HR_REGIONS_IR input)
	{
		return await _requestHandler.HandleCreate(input);
	}
	/// <summary>
	/// Update record of REGIONS table by indexed selector(s)
	/// Note: Any foreign key data referenced by or referencing these records should not be included in the body payload
	/// </summary>
	[HttpPut, Route("XE_HR_REGIONS/UpdateByREGION_ID")]
	public async Task UpdateByREGION_ID(String? rEGION_ID_IR, [FromBody]XE_HR_REGIONS_IR input)
	{
		await _requestHandler.HandleUpdateByREGION_ID(rEGION_ID_IR, input);
	}
	/// <summary>
	/// Delete record of REGIONS table by indexed selector(s)
	/// </summary>
	[HttpDelete, Route("XE_HR_REGIONS/DeleteByREGION_ID")]
	public async Task DeleteByREGION_ID(String? rEGION_ID_IR)
	{
		await _requestHandler.HandleDeleteByREGION_ID(rEGION_ID_IR);
	}
}