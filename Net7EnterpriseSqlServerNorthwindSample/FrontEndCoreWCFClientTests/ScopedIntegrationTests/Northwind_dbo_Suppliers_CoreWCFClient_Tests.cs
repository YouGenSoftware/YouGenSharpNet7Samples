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
public class Northwind_dbo_Suppliers_WCFClient_Tests : CoreWCFServiceClientTestBase
{    
	protected INorthwind_dbo_Suppliers_Service? _serviceClient;    
    protected EndpointAddress? _endpointAddress; 
	private Northwind_HydratedDynamicIndirectReferenceTransformerModels? _dynamicIRModels;
	private Northwind_HydratedStaticIndirectReferenceTransformerModels? _staticIRModels;
	[TestInitialize()]
    public override void Init()
    {
        base.Init();
		_dynamicIRModels = new Northwind_HydratedDynamicIndirectReferenceTransformerModels();
		_staticIRModels = new Northwind_HydratedStaticIndirectReferenceTransformerModels();
        _endpointAddress = new EndpointAddress(_baseAddress! + "/Northwind_dbo_Suppliers_Service");
        _serviceClient = new Northwind_dbo_Suppliers_ServiceClient(_binding!, _endpointAddress!);
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
		var input = (Northwind_dbo_Suppliers_IR)(object)_dynamicIRModels!.GetHydratedDynamicNorthwind_dbo_Suppliers_IR();
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
		var input = (Northwind_dbo_Suppliers_IR)(object)_staticIRModels!.GetHydratedStaticNorthwind_dbo_Suppliers_IR();
		// When
		var retData = await _serviceClient!.CreateAsync(input);
		// Then
		Assert.IsTrue(retData != null);
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task GetByCompanyNameDynamicTest()
	{
		// Given
		var input = (Northwind_dbo_Suppliers_IR)(object)_dynamicIRModels!.GetHydratedDynamicNorthwind_dbo_Suppliers_IR();
		// When
		var retData = await _serviceClient!.GetByCompanyNameAsync(input.CompanyName ?? String.Empty);
		// Then
		Assert.IsTrue(retData != null && retData.Any());
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task GetByCompanyNameStaticTest()
	{
		// Given
		var input = (Northwind_dbo_Suppliers_IR)(object)_staticIRModels!.GetHydratedStaticNorthwind_dbo_Suppliers_IR();
		// When
		var retData = await _serviceClient!.GetByCompanyNameAsync(input.CompanyName ?? String.Empty);
		// Then
		Assert.IsTrue(retData != null && retData.Any());
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task GetBySupplierIDDynamicTest()
	{
		// Given
		var input = (Northwind_dbo_Suppliers_IR)(object)_dynamicIRModels!.GetHydratedDynamicNorthwind_dbo_Suppliers_IR();
		// When
		var retData = await _serviceClient!.GetBySupplierIDAsync(input.SupplierID_IR ?? String.Empty);
		// Then
		Assert.IsTrue(retData != null && retData.Any());
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task GetBySupplierIDStaticTest()
	{
		// Given
		var input = (Northwind_dbo_Suppliers_IR)(object)_staticIRModels!.GetHydratedStaticNorthwind_dbo_Suppliers_IR();
		// When
		var retData = await _serviceClient!.GetBySupplierIDAsync(input.SupplierID_IR ?? String.Empty);
		// Then
		Assert.IsTrue(retData != null && retData.Any());
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task GetByPostalCodeDynamicTest()
	{
		// Given
		var input = (Northwind_dbo_Suppliers_IR)(object)_dynamicIRModels!.GetHydratedDynamicNorthwind_dbo_Suppliers_IR();
		// When
		var retData = await _serviceClient!.GetByPostalCodeAsync(input.PostalCode);
		// Then
		Assert.IsTrue(retData != null && retData.Any());
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task GetByPostalCodeStaticTest()
	{
		// Given
		var input = (Northwind_dbo_Suppliers_IR)(object)_staticIRModels!.GetHydratedStaticNorthwind_dbo_Suppliers_IR();
		// When
		var retData = await _serviceClient!.GetByPostalCodeAsync(input.PostalCode);
		// Then
		Assert.IsTrue(retData != null && retData.Any());
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task UpdateByCompanyNameDynamicTest()
	{
		// Given
		var input = (Northwind_dbo_Suppliers_IR)(object)_dynamicIRModels!.GetHydratedDynamicNorthwind_dbo_Suppliers_IR();
		var input2 = (Northwind_dbo_Suppliers_IR)(object)_dynamicIRModels!.GetHydratedDynamicNorthwind_dbo_Suppliers_IR();
		// When
		await _serviceClient!.UpdateByCompanyNameAsync(input.CompanyName ?? String.Empty, input2);
		// Then
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task UpdateByCompanyNameStaticTest()
	{
		// Given
		var input = (Northwind_dbo_Suppliers_IR)(object)_staticIRModels!.GetHydratedStaticNorthwind_dbo_Suppliers_IR();
		// When
		await _serviceClient!.UpdateByCompanyNameAsync(input.CompanyName ?? String.Empty, input);
		// Then
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task UpdateBySupplierIDDynamicTest()
	{
		// Given
		var input = (Northwind_dbo_Suppliers_IR)(object)_dynamicIRModels!.GetHydratedDynamicNorthwind_dbo_Suppliers_IR();
		var input2 = (Northwind_dbo_Suppliers_IR)(object)_dynamicIRModels!.GetHydratedDynamicNorthwind_dbo_Suppliers_IR();
		// When
		await _serviceClient!.UpdateBySupplierIDAsync(input.SupplierID_IR ?? String.Empty, input2);
		// Then
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task UpdateBySupplierIDStaticTest()
	{
		// Given
		var input = (Northwind_dbo_Suppliers_IR)(object)_staticIRModels!.GetHydratedStaticNorthwind_dbo_Suppliers_IR();
		// When
		await _serviceClient!.UpdateBySupplierIDAsync(input.SupplierID_IR ?? String.Empty, input);
		// Then
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task UpdateByPostalCodeDynamicTest()
	{
		// Given
		var input = (Northwind_dbo_Suppliers_IR)(object)_dynamicIRModels!.GetHydratedDynamicNorthwind_dbo_Suppliers_IR();
		var input2 = (Northwind_dbo_Suppliers_IR)(object)_dynamicIRModels!.GetHydratedDynamicNorthwind_dbo_Suppliers_IR();
		// When
		await _serviceClient!.UpdateByPostalCodeAsync(input.PostalCode, input2);
		// Then
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task UpdateByPostalCodeStaticTest()
	{
		// Given
		var input = (Northwind_dbo_Suppliers_IR)(object)_staticIRModels!.GetHydratedStaticNorthwind_dbo_Suppliers_IR();
		// When
		await _serviceClient!.UpdateByPostalCodeAsync(input.PostalCode, input);
		// Then
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task DeleteByCompanyNameDynamicTest()
	{
		// Given
		var input = (Northwind_dbo_Suppliers_IR)(object)_dynamicIRModels!.GetHydratedDynamicNorthwind_dbo_Suppliers_IR();
		// When
		await _serviceClient!.DeleteByCompanyNameAsync(input.CompanyName ?? String.Empty);
		// Then
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task DeleteByCompanyNameStaticTest()
	{
		// Given
		var input = (Northwind_dbo_Suppliers_IR)(object)_staticIRModels!.GetHydratedStaticNorthwind_dbo_Suppliers_IR();
		// When
		await _serviceClient!.DeleteByCompanyNameAsync(input.CompanyName ?? String.Empty);
		// Then
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task DeleteBySupplierIDDynamicTest()
	{
		// Given
		var input = (Northwind_dbo_Suppliers_IR)(object)_dynamicIRModels!.GetHydratedDynamicNorthwind_dbo_Suppliers_IR();
		// When
		await _serviceClient!.DeleteBySupplierIDAsync(input.SupplierID_IR ?? String.Empty);
		// Then
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task DeleteBySupplierIDStaticTest()
	{
		// Given
		var input = (Northwind_dbo_Suppliers_IR)(object)_staticIRModels!.GetHydratedStaticNorthwind_dbo_Suppliers_IR();
		// When
		await _serviceClient!.DeleteBySupplierIDAsync(input.SupplierID_IR ?? String.Empty);
		// Then
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task DeleteByPostalCodeDynamicTest()
	{
		// Given
		var input = (Northwind_dbo_Suppliers_IR)(object)_dynamicIRModels!.GetHydratedDynamicNorthwind_dbo_Suppliers_IR();
		// When
		await _serviceClient!.DeleteByPostalCodeAsync(input.PostalCode);
		// Then
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task DeleteByPostalCodeStaticTest()
	{
		// Given
		var input = (Northwind_dbo_Suppliers_IR)(object)_staticIRModels!.GetHydratedStaticNorthwind_dbo_Suppliers_IR();
		// When
		await _serviceClient!.DeleteByPostalCodeAsync(input.PostalCode);
		// Then
		// TODO: Add test cases
	}
}