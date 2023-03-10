/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307200541 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Professional Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
using Microsoft.AspNetCore.WebUtilities;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Northwind_Common.IndirectReferenceTransformerModels;
namespace Northwind_FrontEndHttpClient.HttpClients;
public class Northwind_dbo_Employees_HttpClient : HttpClientBase, INorthwind_dbo_Employees_HttpClient
{
	public Northwind_dbo_Employees_HttpClient(HttpClient httpClient) : base(httpClient)
    {            
    }
	public async Task<IEnumerable<Northwind_dbo_Employees_IR>?> GetByBestMatchedQueryPattern(Northwind_dbo_Employees_IR input)
	{
		if (input == null) return null;
		IEnumerable<Northwind_dbo_Employees_IR>? retData;
		if (input.LastName_HasBeenChanged) retData = await GetByLastName(input.LastName ?? String.Empty);
		else if (input.EmployeeID_IR_HasBeenChanged) retData = await GetByEmployeeID(input.EmployeeID_IR ?? default);
		else if (input.PostalCode_HasBeenChanged) retData = await GetByPostalCode(input.PostalCode);
		else retData = await GetAll();
		return retData == null ? null : retData.Where(x => WhereAllFilledFields(x, input));
	}
	private static Boolean WhereAllFilledFields(Northwind_dbo_Employees_IR record, Northwind_dbo_Employees_IR filter)
	{
		 // unencrypted properties only
		return			(!filter.LastName_HasBeenChanged || record.LastName == filter.LastName) &&
			(!filter.FirstName_HasBeenChanged || record.FirstName == filter.FirstName) &&
			(!filter.Title_HasBeenChanged || record.Title == filter.Title) &&
			(!filter.TitleOfCourtesy_HasBeenChanged || record.TitleOfCourtesy == filter.TitleOfCourtesy) &&
			(!filter.BirthDate_HasBeenChanged || record.BirthDate == filter.BirthDate) &&
			(!filter.HireDate_HasBeenChanged || record.HireDate == filter.HireDate) &&
			(!filter.Address_HasBeenChanged || record.Address == filter.Address) &&
			(!filter.City_HasBeenChanged || record.City == filter.City) &&
			(!filter.Region_HasBeenChanged || record.Region == filter.Region) &&
			(!filter.PostalCode_HasBeenChanged || record.PostalCode == filter.PostalCode) &&
			(!filter.Country_HasBeenChanged || record.Country == filter.Country) &&
			(!filter.HomePhone_HasBeenChanged || record.HomePhone == filter.HomePhone) &&
			(!filter.Extension_HasBeenChanged || record.Extension == filter.Extension) &&
			(!filter.Photo_HasBeenChanged || record.Photo == filter.Photo) &&
			(!filter.Notes_HasBeenChanged || record.Notes == filter.Notes) &&
			(!filter.PhotoPath_HasBeenChanged || record.PhotoPath == filter.PhotoPath);
	}
	public async Task<IEnumerable<Northwind_dbo_Employees_IR>?> GetAll()
	{
		var result = await _httpClient.GetAsync(_httpClient.BaseAddress!.ToString() + "Northwind_dbo_Employees/GetAll");
		result.EnsureSuccessStatusCode();
		var content = await result.Content.ReadAsStringAsync();
		return content == String.Empty ? null : JsonConvert.DeserializeObject<IEnumerable<Northwind_dbo_Employees_IR>?>(content, _jsonSerializationSettings);
	}
	public async Task<IEnumerable<Northwind_dbo_Employees_IR>?> GetByLastName(String lastName)
	{
		var uri = GetUriForParamsLastName("Northwind_dbo_Employees/GetByLastName", lastName);
		var result = await _httpClient.GetAsync(uri);
		result.EnsureSuccessStatusCode();
		var content = await result.Content.ReadAsStringAsync();
		return content == String.Empty ? null : JsonConvert.DeserializeObject<IEnumerable<Northwind_dbo_Employees_IR>?>(content, _jsonSerializationSettings);
	}
	public async Task<IEnumerable<Northwind_dbo_Employees_IR>?> GetByEmployeeID(String? employeeID_IR)
	{
		var uri = GetUriForParamsEmployeeID("Northwind_dbo_Employees/GetByEmployeeID", employeeID_IR);
		var result = await _httpClient.GetAsync(uri);
		result.EnsureSuccessStatusCode();
		var content = await result.Content.ReadAsStringAsync();
		return content == String.Empty ? null : JsonConvert.DeserializeObject<IEnumerable<Northwind_dbo_Employees_IR>?>(content, _jsonSerializationSettings);
	}
	public async Task<IEnumerable<Northwind_dbo_Employees_IR>?> GetByPostalCode(String? postalCode)
	{
		var uri = GetUriForParamsPostalCode("Northwind_dbo_Employees/GetByPostalCode", postalCode);
		var result = await _httpClient.GetAsync(uri);
		result.EnsureSuccessStatusCode();
		var content = await result.Content.ReadAsStringAsync();
		return content == String.Empty ? null : JsonConvert.DeserializeObject<IEnumerable<Northwind_dbo_Employees_IR>?>(content, _jsonSerializationSettings);
	}
	public async Task<Northwind_dbo_Employees_IR?> Create(Northwind_dbo_Employees_IR input)
	{
		var serializedInput = JsonConvert.SerializeObject(input, _jsonSerializationSettings);
		var result = await _httpClient.PostAsync(_httpClient.BaseAddress!.ToString() + "Northwind_dbo_Employees/Create", new StringContent(serializedInput, Encoding.UTF8, "application/json"));
		result.EnsureSuccessStatusCode();
		var content = await result.Content.ReadAsStringAsync();
		return content == String.Empty ? null : JsonConvert.DeserializeObject<Northwind_dbo_Employees_IR?>(content, _jsonSerializationSettings);
	}
	public async Task UpdateByEncodedPrimaryKey(String? encodedPrimaryKey, Northwind_dbo_Employees_IR updateModel)
	{
		if (encodedPrimaryKey == null || updateModel == null) return;
		var inputSplits = encodedPrimaryKey.Split((Char)27);
		await UpdateByEmployeeID(inputSplits[0], updateModel);
	}
	public async Task UpdateByLastName(String lastName, Northwind_dbo_Employees_IR input)
	{
		var uri = GetUriForParamsLastName("Northwind_dbo_Employees/UpdateByLastName", lastName);
		var serializedInput = JsonConvert.SerializeObject(input, _jsonSerializationSettings);
		var result = await _httpClient.PutAsync(uri, new StringContent(serializedInput, Encoding.UTF8, "application/json"));
		result.EnsureSuccessStatusCode();
	}
	public async Task UpdateByEmployeeID(String? employeeID_IR, Northwind_dbo_Employees_IR input)
	{
		var uri = GetUriForParamsEmployeeID("Northwind_dbo_Employees/UpdateByEmployeeID", employeeID_IR);
		var serializedInput = JsonConvert.SerializeObject(input, _jsonSerializationSettings);
		var result = await _httpClient.PutAsync(uri, new StringContent(serializedInput, Encoding.UTF8, "application/json"));
		result.EnsureSuccessStatusCode();
	}
	public async Task UpdateByPostalCode(String? postalCode, Northwind_dbo_Employees_IR input)
	{
		var uri = GetUriForParamsPostalCode("Northwind_dbo_Employees/UpdateByPostalCode", postalCode);
		var serializedInput = JsonConvert.SerializeObject(input, _jsonSerializationSettings);
		var result = await _httpClient.PutAsync(uri, new StringContent(serializedInput, Encoding.UTF8, "application/json"));
		result.EnsureSuccessStatusCode();
	}
	public async Task DeleteByEncodedPrimaryKey(String? input)
	{
		if (input == null) return;
		var inputSplits = input.Split((Char)27);
		await DeleteByEmployeeID(inputSplits[0]);
	}
	public async Task DeleteByLastName(String lastName)
	{
		var uri = GetUriForParamsLastName("Northwind_dbo_Employees/DeleteByLastName", lastName);
		var result = await _httpClient.DeleteAsync(uri);
		result.EnsureSuccessStatusCode();
	}
	public async Task DeleteByEmployeeID(String? employeeID_IR)
	{
		var uri = GetUriForParamsEmployeeID("Northwind_dbo_Employees/DeleteByEmployeeID", employeeID_IR);
		var result = await _httpClient.DeleteAsync(uri);
		result.EnsureSuccessStatusCode();
	}
	public async Task DeleteByPostalCode(String? postalCode)
	{
		var uri = GetUriForParamsPostalCode("Northwind_dbo_Employees/DeleteByPostalCode", postalCode);
		var result = await _httpClient.DeleteAsync(uri);
		result.EnsureSuccessStatusCode();
	}
	private String GetUriForParamsLastName(String path, String lastName)
	{
		var query = new Dictionary<String,String>();
		query["lastName"] = lastName;
		return QueryHelpers.AddQueryString(_uriBuilder.Uri.ToString() + path, query);
	}
	private String GetUriForParamsEmployeeID(String path, String? employeeID_IR)
	{
		var query = new Dictionary<String,String>();
		query["employeeID_IR"] = employeeID_IR ?? String.Empty;
		return QueryHelpers.AddQueryString(_uriBuilder.Uri.ToString() + path, query);
	}
	private String GetUriForParamsPostalCode(String path, String? postalCode)
	{
		var query = new Dictionary<String,String>();
		query["postalCode"] = postalCode ?? String.Empty;
		return QueryHelpers.AddQueryString(_uriBuilder.Uri.ToString() + path, query);
	}
}
