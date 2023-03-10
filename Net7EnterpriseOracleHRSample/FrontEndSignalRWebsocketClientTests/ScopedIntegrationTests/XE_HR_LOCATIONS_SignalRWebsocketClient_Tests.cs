/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307202958 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Enterprise Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
using Microsoft.VisualStudio.TestTools.UnitTesting;
using XE_HR_Common.IndirectReferenceTransformerModels;
using XE_HR_FrontEndSignalRWebsocketClient.SignalRWebsocketClients;
using XE_HR_FrontEndSignalRWebsocketClientTests;
using XE_HR_CommonTests.HydratedDynamicIndirectReferenceTransformerModels;
using XE_HR_CommonTests.HydratedStaticIndirectReferenceTransformerModels;
namespace XE_HR_FrontEndSignalRWebsocketClientTests.ScopedIntegrationTests;
[TestClass()]
public class XE_HR_LOCATIONS_SignalRWebsocketClient_Tests : SignalRWebsocketClientTestBase
{   
	protected IXE_HR_LOCATIONS_SignalRWebsocketClient? _signalRWebsocketClient;
	private XE_HR_HydratedDynamicIndirectReferenceTransformerModels? _dynamicIRModels;
	private XE_HR_HydratedStaticIndirectReferenceTransformerModels? _staticIRModels;
	[TestInitialize()]
    public override async Task Init()
    {
        await base.Init();
		_dynamicIRModels = new XE_HR_HydratedDynamicIndirectReferenceTransformerModels();
		_staticIRModels = new XE_HR_HydratedStaticIndirectReferenceTransformerModels();
        _signalRWebsocketClient = new XE_HR_LOCATIONS_SignalRWebsocketClient(_hubUriBase + "/XE_HR_LOCATIONS_Hub");
        await _signalRWebsocketClient.InitializeAsync();
    }
    [TestCleanup()]
    public virtual async Task TestCleanup()
    {
        await _signalRWebsocketClient!.DisposeAsync();
    }
	[TestMethod()]
	public async Task GetAllTest()
	{
		// When
		var retData = await _signalRWebsocketClient!.GetAll();
		// Then
		Assert.IsTrue(retData != null && retData.Any());
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task CreateDynamicTest()
	{
		// Given
		var input = _dynamicIRModels!.GetHydratedDynamicXE_HR_LOCATIONS_IR();
		// When
		var retData = await _signalRWebsocketClient!.Create(input);
		// Then
		Assert.IsTrue(retData != null);
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task CreateStaticTest()
	{
		// Given
		var input = _staticIRModels!.GetHydratedStaticXE_HR_LOCATIONS_IR();
		// When
		var retData = await _signalRWebsocketClient!.Create(input);
		// Then
		Assert.IsTrue(retData != null);
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task GetByCITYDynamicTest()
	{
		// Given
		var input = _dynamicIRModels!.GetHydratedDynamicXE_HR_LOCATIONS_IR();
		// When
		var retData = await _signalRWebsocketClient!.GetByCITY(input.CITY ?? String.Empty);
		// Then
		Assert.IsTrue(retData != null && retData.Any());
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task GetByCITYStaticTest()
	{
		// Given
		var input = _staticIRModels!.GetHydratedStaticXE_HR_LOCATIONS_IR();
		// When
		var retData = await _signalRWebsocketClient!.GetByCITY(input.CITY ?? String.Empty);
		// Then
		Assert.IsTrue(retData != null && retData.Any());
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task GetByCOUNTRY_IDDynamicTest()
	{
		// Given
		var input = _dynamicIRModels!.GetHydratedDynamicXE_HR_LOCATIONS_IR();
		// When
		var retData = await _signalRWebsocketClient!.GetByCOUNTRY_ID(input.COUNTRY_ID);
		// Then
		Assert.IsTrue(retData != null && retData.Any());
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task GetByCOUNTRY_IDStaticTest()
	{
		// Given
		var input = _staticIRModels!.GetHydratedStaticXE_HR_LOCATIONS_IR();
		// When
		var retData = await _signalRWebsocketClient!.GetByCOUNTRY_ID(input.COUNTRY_ID);
		// Then
		Assert.IsTrue(retData != null && retData.Any());
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task GetByLOCATION_IDDynamicTest()
	{
		// Given
		var input = _dynamicIRModels!.GetHydratedDynamicXE_HR_LOCATIONS_IR();
		// When
		var retData = await _signalRWebsocketClient!.GetByLOCATION_ID(input.LOCATION_ID_IR ?? String.Empty);
		// Then
		Assert.IsTrue(retData != null && retData.Any());
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task GetByLOCATION_IDStaticTest()
	{
		// Given
		var input = _staticIRModels!.GetHydratedStaticXE_HR_LOCATIONS_IR();
		// When
		var retData = await _signalRWebsocketClient!.GetByLOCATION_ID(input.LOCATION_ID_IR ?? String.Empty);
		// Then
		Assert.IsTrue(retData != null && retData.Any());
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task GetBySTATE_PROVINCEDynamicTest()
	{
		// Given
		var input = _dynamicIRModels!.GetHydratedDynamicXE_HR_LOCATIONS_IR();
		// When
		var retData = await _signalRWebsocketClient!.GetBySTATE_PROVINCE(input.STATE_PROVINCE);
		// Then
		Assert.IsTrue(retData != null && retData.Any());
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task GetBySTATE_PROVINCEStaticTest()
	{
		// Given
		var input = _staticIRModels!.GetHydratedStaticXE_HR_LOCATIONS_IR();
		// When
		var retData = await _signalRWebsocketClient!.GetBySTATE_PROVINCE(input.STATE_PROVINCE);
		// Then
		Assert.IsTrue(retData != null && retData.Any());
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task UpdateByCITYDynamicTest()
	{
		// Given
		var input = _dynamicIRModels!.GetHydratedDynamicXE_HR_LOCATIONS_IR();
		var input2 = _dynamicIRModels!.GetHydratedDynamicXE_HR_LOCATIONS_IR();
		// When
		await _signalRWebsocketClient!.UpdateByCITY(input.CITY ?? String.Empty, input2);
		// Then
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task UpdateByCITYStaticTest()
	{
		// Given
		var input = _staticIRModels!.GetHydratedStaticXE_HR_LOCATIONS_IR();
		// When
		await _signalRWebsocketClient!.UpdateByCITY(input.CITY ?? String.Empty, input);
		// Then
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task UpdateByCOUNTRY_IDDynamicTest()
	{
		// Given
		var input = _dynamicIRModels!.GetHydratedDynamicXE_HR_LOCATIONS_IR();
		var input2 = _dynamicIRModels!.GetHydratedDynamicXE_HR_LOCATIONS_IR();
		// When
		await _signalRWebsocketClient!.UpdateByCOUNTRY_ID(input.COUNTRY_ID, input2);
		// Then
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task UpdateByCOUNTRY_IDStaticTest()
	{
		// Given
		var input = _staticIRModels!.GetHydratedStaticXE_HR_LOCATIONS_IR();
		// When
		await _signalRWebsocketClient!.UpdateByCOUNTRY_ID(input.COUNTRY_ID, input);
		// Then
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task UpdateByLOCATION_IDDynamicTest()
	{
		// Given
		var input = _dynamicIRModels!.GetHydratedDynamicXE_HR_LOCATIONS_IR();
		var input2 = _dynamicIRModels!.GetHydratedDynamicXE_HR_LOCATIONS_IR();
		// When
		await _signalRWebsocketClient!.UpdateByLOCATION_ID(input.LOCATION_ID_IR ?? String.Empty, input2);
		// Then
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task UpdateByLOCATION_IDStaticTest()
	{
		// Given
		var input = _staticIRModels!.GetHydratedStaticXE_HR_LOCATIONS_IR();
		// When
		await _signalRWebsocketClient!.UpdateByLOCATION_ID(input.LOCATION_ID_IR ?? String.Empty, input);
		// Then
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task UpdateBySTATE_PROVINCEDynamicTest()
	{
		// Given
		var input = _dynamicIRModels!.GetHydratedDynamicXE_HR_LOCATIONS_IR();
		var input2 = _dynamicIRModels!.GetHydratedDynamicXE_HR_LOCATIONS_IR();
		// When
		await _signalRWebsocketClient!.UpdateBySTATE_PROVINCE(input.STATE_PROVINCE, input2);
		// Then
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task UpdateBySTATE_PROVINCEStaticTest()
	{
		// Given
		var input = _staticIRModels!.GetHydratedStaticXE_HR_LOCATIONS_IR();
		// When
		await _signalRWebsocketClient!.UpdateBySTATE_PROVINCE(input.STATE_PROVINCE, input);
		// Then
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task DeleteByCITYDynamicTest()
	{
		// Given
		var input = _dynamicIRModels!.GetHydratedDynamicXE_HR_LOCATIONS_IR();
		// When
		await _signalRWebsocketClient!.DeleteByCITY(input.CITY ?? String.Empty);
		// Then
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task DeleteByCITYStaticTest()
	{
		// Given
		var input = _staticIRModels!.GetHydratedStaticXE_HR_LOCATIONS_IR();
		// When
		await _signalRWebsocketClient!.DeleteByCITY(input.CITY ?? String.Empty);
		// Then
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task DeleteByCOUNTRY_IDDynamicTest()
	{
		// Given
		var input = _dynamicIRModels!.GetHydratedDynamicXE_HR_LOCATIONS_IR();
		// When
		await _signalRWebsocketClient!.DeleteByCOUNTRY_ID(input.COUNTRY_ID);
		// Then
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task DeleteByCOUNTRY_IDStaticTest()
	{
		// Given
		var input = _staticIRModels!.GetHydratedStaticXE_HR_LOCATIONS_IR();
		// When
		await _signalRWebsocketClient!.DeleteByCOUNTRY_ID(input.COUNTRY_ID);
		// Then
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task DeleteByLOCATION_IDDynamicTest()
	{
		// Given
		var input = _dynamicIRModels!.GetHydratedDynamicXE_HR_LOCATIONS_IR();
		// When
		await _signalRWebsocketClient!.DeleteByLOCATION_ID(input.LOCATION_ID_IR ?? String.Empty);
		// Then
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task DeleteByLOCATION_IDStaticTest()
	{
		// Given
		var input = _staticIRModels!.GetHydratedStaticXE_HR_LOCATIONS_IR();
		// When
		await _signalRWebsocketClient!.DeleteByLOCATION_ID(input.LOCATION_ID_IR ?? String.Empty);
		// Then
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task DeleteBySTATE_PROVINCEDynamicTest()
	{
		// Given
		var input = _dynamicIRModels!.GetHydratedDynamicXE_HR_LOCATIONS_IR();
		// When
		await _signalRWebsocketClient!.DeleteBySTATE_PROVINCE(input.STATE_PROVINCE);
		// Then
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task DeleteBySTATE_PROVINCEStaticTest()
	{
		// Given
		var input = _staticIRModels!.GetHydratedStaticXE_HR_LOCATIONS_IR();
		// When
		await _signalRWebsocketClient!.DeleteBySTATE_PROVINCE(input.STATE_PROVINCE);
		// Then
		// TODO: Add test cases
	}
}
