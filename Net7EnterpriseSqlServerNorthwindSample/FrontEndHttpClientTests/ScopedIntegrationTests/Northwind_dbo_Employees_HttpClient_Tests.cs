/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307200636 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Enterprise Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Northwind_Common.IndirectReferenceTransformerModels;
using Northwind_FrontEndHttpClient.HttpClients;
using Northwind_FrontEndHttpClientTests;
using Northwind_CommonTests.HydratedDynamicIndirectReferenceTransformerModels;
using Northwind_CommonTests.HydratedStaticIndirectReferenceTransformerModels;
namespace Northwind_FrontEndHttpClientTests.ScopedIntegrationTests;
[TestClass()]
public class Northwind_dbo_Employees_HttpClient_Tests : HttpClientTestBase
{
	protected INorthwind_dbo_Employees_HttpClient? _specificHttpClient;
	private Northwind_HydratedDynamicIndirectReferenceTransformerModels? _dynamicIRModels;
	private Northwind_HydratedStaticIndirectReferenceTransformerModels? _staticIRModels;
	[TestInitialize()]
    public override void Init()
    {
        base.Init();
		_dynamicIRModels = new Northwind_HydratedDynamicIndirectReferenceTransformerModels();
		_staticIRModels = new Northwind_HydratedStaticIndirectReferenceTransformerModels();
        _specificHttpClient = new Northwind_dbo_Employees_HttpClient(_httpClient!);
    }
	[TestMethod()]
	public async Task GetAllTest()
	{
		// When
		var retData = await _specificHttpClient!.GetAll();
		// Then
		Assert.IsTrue(retData != null && retData.Any());
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task CreateDynamicTest()
	{
		// Given
		var input = _dynamicIRModels!.GetHydratedDynamicNorthwind_dbo_Employees_IR();
		// When
		var retData = await _specificHttpClient!.Create(input);
		// Then
		Assert.IsTrue(retData != null);
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task CreateStaticTest()
	{
		// Given
		var input = _staticIRModels!.GetHydratedStaticNorthwind_dbo_Employees_IR();
		// When
		var retData = await _specificHttpClient!.Create(input);
		// Then
		Assert.IsTrue(retData != null);
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task GetByLastNameDynamicTest()
	{
		// Given
		var input = _dynamicIRModels!.GetHydratedDynamicNorthwind_dbo_Employees_IR();
		// When
		var retData = await _specificHttpClient!.GetByLastName(input.LastName ?? String.Empty);
		// Then
		Assert.IsTrue(retData != null && retData.Any());
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task GetByLastNameStaticTest()
	{
		// Given
		var input = _staticIRModels!.GetHydratedStaticNorthwind_dbo_Employees_IR();
		// When
		var retData = await _specificHttpClient!.GetByLastName(input.LastName ?? String.Empty);
		// Then
		Assert.IsTrue(retData != null && retData.Any());
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task GetByEmployeeIDDynamicTest()
	{
		// Given
		var input = _dynamicIRModels!.GetHydratedDynamicNorthwind_dbo_Employees_IR();
		// When
		var retData = await _specificHttpClient!.GetByEmployeeID(input.EmployeeID_IR ?? String.Empty);
		// Then
		Assert.IsTrue(retData != null && retData.Any());
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task GetByEmployeeIDStaticTest()
	{
		// Given
		var input = _staticIRModels!.GetHydratedStaticNorthwind_dbo_Employees_IR();
		// When
		var retData = await _specificHttpClient!.GetByEmployeeID(input.EmployeeID_IR ?? String.Empty);
		// Then
		Assert.IsTrue(retData != null && retData.Any());
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task GetByPostalCodeDynamicTest()
	{
		// Given
		var input = _dynamicIRModels!.GetHydratedDynamicNorthwind_dbo_Employees_IR();
		// When
		var retData = await _specificHttpClient!.GetByPostalCode(input.PostalCode);
		// Then
		Assert.IsTrue(retData != null && retData.Any());
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task GetByPostalCodeStaticTest()
	{
		// Given
		var input = _staticIRModels!.GetHydratedStaticNorthwind_dbo_Employees_IR();
		// When
		var retData = await _specificHttpClient!.GetByPostalCode(input.PostalCode);
		// Then
		Assert.IsTrue(retData != null && retData.Any());
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task UpdateByLastNameDynamicTest()
	{
		// Given
		var input = _dynamicIRModels!.GetHydratedDynamicNorthwind_dbo_Employees_IR();
		var input2 = _dynamicIRModels!.GetHydratedDynamicNorthwind_dbo_Employees_IR();
		// When
		await _specificHttpClient!.UpdateByLastName(input.LastName ?? String.Empty, input2);
		// Then
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task UpdateByLastNameStaticTest()
	{
		// Given
		var input = _staticIRModels!.GetHydratedStaticNorthwind_dbo_Employees_IR();
		// When
		await _specificHttpClient!.UpdateByLastName(input.LastName ?? String.Empty, input);
		// Then
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task UpdateByEmployeeIDDynamicTest()
	{
		// Given
		var input = _dynamicIRModels!.GetHydratedDynamicNorthwind_dbo_Employees_IR();
		var input2 = _dynamicIRModels!.GetHydratedDynamicNorthwind_dbo_Employees_IR();
		// When
		await _specificHttpClient!.UpdateByEmployeeID(input.EmployeeID_IR ?? String.Empty, input2);
		// Then
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task UpdateByEmployeeIDStaticTest()
	{
		// Given
		var input = _staticIRModels!.GetHydratedStaticNorthwind_dbo_Employees_IR();
		// When
		await _specificHttpClient!.UpdateByEmployeeID(input.EmployeeID_IR ?? String.Empty, input);
		// Then
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task UpdateByPostalCodeDynamicTest()
	{
		// Given
		var input = _dynamicIRModels!.GetHydratedDynamicNorthwind_dbo_Employees_IR();
		var input2 = _dynamicIRModels!.GetHydratedDynamicNorthwind_dbo_Employees_IR();
		// When
		await _specificHttpClient!.UpdateByPostalCode(input.PostalCode, input2);
		// Then
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task UpdateByPostalCodeStaticTest()
	{
		// Given
		var input = _staticIRModels!.GetHydratedStaticNorthwind_dbo_Employees_IR();
		// When
		await _specificHttpClient!.UpdateByPostalCode(input.PostalCode, input);
		// Then
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task DeleteByLastNameDynamicTest()
	{
		// Given
		var input = _dynamicIRModels!.GetHydratedDynamicNorthwind_dbo_Employees_IR();
		// When
		await _specificHttpClient!.DeleteByLastName(input.LastName ?? String.Empty);
		// Then
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task DeleteByLastNameStaticTest()
	{
		// Given
		var input = _staticIRModels!.GetHydratedStaticNorthwind_dbo_Employees_IR();
		// When
		await _specificHttpClient!.DeleteByLastName(input.LastName ?? String.Empty);
		// Then
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task DeleteByEmployeeIDDynamicTest()
	{
		// Given
		var input = _dynamicIRModels!.GetHydratedDynamicNorthwind_dbo_Employees_IR();
		// When
		await _specificHttpClient!.DeleteByEmployeeID(input.EmployeeID_IR ?? String.Empty);
		// Then
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task DeleteByEmployeeIDStaticTest()
	{
		// Given
		var input = _staticIRModels!.GetHydratedStaticNorthwind_dbo_Employees_IR();
		// When
		await _specificHttpClient!.DeleteByEmployeeID(input.EmployeeID_IR ?? String.Empty);
		// Then
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task DeleteByPostalCodeDynamicTest()
	{
		// Given
		var input = _dynamicIRModels!.GetHydratedDynamicNorthwind_dbo_Employees_IR();
		// When
		await _specificHttpClient!.DeleteByPostalCode(input.PostalCode);
		// Then
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task DeleteByPostalCodeStaticTest()
	{
		// Given
		var input = _staticIRModels!.GetHydratedStaticNorthwind_dbo_Employees_IR();
		// When
		await _specificHttpClient!.DeleteByPostalCode(input.PostalCode);
		// Then
		// TODO: Add test cases
	}
}
