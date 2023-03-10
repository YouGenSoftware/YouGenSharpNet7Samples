/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307200636 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Enterprise Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.ServiceModel;
using System.ServiceModel.Channels;
using Northwind_Common.IndirectReferenceTransformerModels;
using Northwind_FrontEndCoreWCFClient.CoreWCFClients;
using Northwind_FrontEndCoreWCFClientTests;
using Northwind_CommonTests.HydratedDynamicIndirectReferenceTransformerModels;
using Northwind_CommonTests.HydratedStaticIndirectReferenceTransformerModels;
namespace Northwind_FrontEndCoreWCFClientTests.ScopedIntegrationTests;
[TestClass()]
public class Northwind_dbo_CustomerCustomerDemo_WCFClient_Tests : CoreWCFServiceClientTestBase
{    
	protected INorthwind_dbo_CustomerCustomerDemo_Service? _serviceClient;    
    protected EndpointAddress? _endpointAddress; 
	private Northwind_HydratedDynamicIndirectReferenceTransformerModels? _dynamicIRModels;
	private Northwind_HydratedStaticIndirectReferenceTransformerModels? _staticIRModels;
	[TestInitialize()]
    public override void Init()
    {
        base.Init();
		_dynamicIRModels = new Northwind_HydratedDynamicIndirectReferenceTransformerModels();
		_staticIRModels = new Northwind_HydratedStaticIndirectReferenceTransformerModels();
        _endpointAddress = new EndpointAddress(_baseAddress! + "/Northwind_dbo_CustomerCustomerDemo_Service");
        _serviceClient = new Northwind_dbo_CustomerCustomerDemo_ServiceClient(_binding!, _endpointAddress!);
    }
	[TestMethod()]
	public async Task GetAllTest()
	{
		// When
		var retData = await _serviceClient!.GetAllAsync();
		// Then
		Assert.IsTrue(retData != null && retData.Any());
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task CreateDynamicTest()
	{
		// Given
		var input = (Northwind_dbo_CustomerCustomerDemo_IR)(object)_dynamicIRModels!.GetHydratedDynamicNorthwind_dbo_CustomerCustomerDemo_IR();
		// When
		var retData = await _serviceClient!.CreateAsync(input);
		// Then
		Assert.IsTrue(retData != null);
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task CreateStaticTest()
	{
		// Given
		var input = (Northwind_dbo_CustomerCustomerDemo_IR)(object)_staticIRModels!.GetHydratedStaticNorthwind_dbo_CustomerCustomerDemo_IR();
		// When
		var retData = await _serviceClient!.CreateAsync(input);
		// Then
		Assert.IsTrue(retData != null);
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task GetByCustomerIDAndCustomerTypeIDDynamicTest()
	{
		// Given
		var input = (Northwind_dbo_CustomerCustomerDemo_IR)(object)_dynamicIRModels!.GetHydratedDynamicNorthwind_dbo_CustomerCustomerDemo_IR();
		// When
		var retData = await _serviceClient!.GetByCustomerIDAndCustomerTypeIDAsync(input.CustomerID ?? String.Empty, input.CustomerTypeID ?? String.Empty);
		// Then
		Assert.IsTrue(retData != null && retData.Any());
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task GetByCustomerIDAndCustomerTypeIDStaticTest()
	{
		// Given
		var input = (Northwind_dbo_CustomerCustomerDemo_IR)(object)_staticIRModels!.GetHydratedStaticNorthwind_dbo_CustomerCustomerDemo_IR();
		// When
		var retData = await _serviceClient!.GetByCustomerIDAndCustomerTypeIDAsync(input.CustomerID ?? String.Empty, input.CustomerTypeID ?? String.Empty);
		// Then
		Assert.IsTrue(retData != null && retData.Any());
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task UpdateByCustomerIDAndCustomerTypeIDDynamicTest()
	{
		// Given
		var input = (Northwind_dbo_CustomerCustomerDemo_IR)(object)_dynamicIRModels!.GetHydratedDynamicNorthwind_dbo_CustomerCustomerDemo_IR();
		var input2 = (Northwind_dbo_CustomerCustomerDemo_IR)(object)_dynamicIRModels!.GetHydratedDynamicNorthwind_dbo_CustomerCustomerDemo_IR();
		// When
		await _serviceClient!.UpdateByCustomerIDAndCustomerTypeIDAsync(input.CustomerID ?? String.Empty, input.CustomerTypeID ?? String.Empty, input2);
		// Then
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task UpdateByCustomerIDAndCustomerTypeIDStaticTest()
	{
		// Given
		var input = (Northwind_dbo_CustomerCustomerDemo_IR)(object)_staticIRModels!.GetHydratedStaticNorthwind_dbo_CustomerCustomerDemo_IR();
		// When
		await _serviceClient!.UpdateByCustomerIDAndCustomerTypeIDAsync(input.CustomerID ?? String.Empty, input.CustomerTypeID ?? String.Empty, input);
		// Then
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task DeleteByCustomerIDAndCustomerTypeIDDynamicTest()
	{
		// Given
		var input = (Northwind_dbo_CustomerCustomerDemo_IR)(object)_dynamicIRModels!.GetHydratedDynamicNorthwind_dbo_CustomerCustomerDemo_IR();
		// When
		await _serviceClient!.DeleteByCustomerIDAndCustomerTypeIDAsync(input.CustomerID ?? String.Empty, input.CustomerTypeID ?? String.Empty);
		// Then
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task DeleteByCustomerIDAndCustomerTypeIDStaticTest()
	{
		// Given
		var input = (Northwind_dbo_CustomerCustomerDemo_IR)(object)_staticIRModels!.GetHydratedStaticNorthwind_dbo_CustomerCustomerDemo_IR();
		// When
		await _serviceClient!.DeleteByCustomerIDAndCustomerTypeIDAsync(input.CustomerID ?? String.Empty, input.CustomerTypeID ?? String.Empty);
		// Then
		// TODO: Add test cases
	}
}
