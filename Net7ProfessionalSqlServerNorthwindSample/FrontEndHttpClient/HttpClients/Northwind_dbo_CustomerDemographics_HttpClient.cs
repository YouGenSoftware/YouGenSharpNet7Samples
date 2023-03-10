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
public class Northwind_dbo_CustomerDemographics_HttpClient : HttpClientBase, INorthwind_dbo_CustomerDemographics_HttpClient
{
	public Northwind_dbo_CustomerDemographics_HttpClient(HttpClient httpClient) : base(httpClient)
    {            
    }
	public async Task<IEnumerable<Northwind_dbo_CustomerDemographics_IR>?> GetByBestMatchedQueryPattern(Northwind_dbo_CustomerDemographics_IR input)
	{
		if (input == null) return null;
		IEnumerable<Northwind_dbo_CustomerDemographics_IR>? retData;
		if (input.CustomerTypeID_HasBeenChanged) retData = await GetByCustomerTypeID(input.CustomerTypeID ?? String.Empty);
		else retData = await GetAll();
		return retData == null ? null : retData.Where(x => WhereAllFilledFields(x, input));
	}
	private static Boolean WhereAllFilledFields(Northwind_dbo_CustomerDemographics_IR record, Northwind_dbo_CustomerDemographics_IR filter)
	{
		 // unencrypted properties only
		return			(!filter.CustomerDesc_HasBeenChanged || record.CustomerDesc == filter.CustomerDesc);
	}
	public async Task<IEnumerable<Northwind_dbo_CustomerDemographics_IR>?> GetAll()
	{
		var result = await _httpClient.GetAsync(_httpClient.BaseAddress!.ToString() + "Northwind_dbo_CustomerDemographics/GetAll");
		result.EnsureSuccessStatusCode();
		var content = await result.Content.ReadAsStringAsync();
		return content == String.Empty ? null : JsonConvert.DeserializeObject<IEnumerable<Northwind_dbo_CustomerDemographics_IR>?>(content, _jsonSerializationSettings);
	}
	public async Task<IEnumerable<Northwind_dbo_CustomerDemographics_IR>?> GetByCustomerTypeID(String customerTypeID)
	{
		var uri = GetUriForParamsCustomerTypeID("Northwind_dbo_CustomerDemographics/GetByCustomerTypeID", customerTypeID);
		var result = await _httpClient.GetAsync(uri);
		result.EnsureSuccessStatusCode();
		var content = await result.Content.ReadAsStringAsync();
		return content == String.Empty ? null : JsonConvert.DeserializeObject<IEnumerable<Northwind_dbo_CustomerDemographics_IR>?>(content, _jsonSerializationSettings);
	}
	public async Task<Northwind_dbo_CustomerDemographics_IR?> Create(Northwind_dbo_CustomerDemographics_IR input)
	{
		var serializedInput = JsonConvert.SerializeObject(input, _jsonSerializationSettings);
		var result = await _httpClient.PostAsync(_httpClient.BaseAddress!.ToString() + "Northwind_dbo_CustomerDemographics/Create", new StringContent(serializedInput, Encoding.UTF8, "application/json"));
		result.EnsureSuccessStatusCode();
		var content = await result.Content.ReadAsStringAsync();
		return content == String.Empty ? null : JsonConvert.DeserializeObject<Northwind_dbo_CustomerDemographics_IR?>(content, _jsonSerializationSettings);
	}
	public async Task UpdateByEncodedPrimaryKey(String? encodedPrimaryKey, Northwind_dbo_CustomerDemographics_IR updateModel)
	{
		if (encodedPrimaryKey == null || updateModel == null) return;
		var inputSplits = encodedPrimaryKey.Split((Char)27);
		await UpdateByCustomerTypeID(inputSplits[0], updateModel);
	}
	public async Task UpdateByCustomerTypeID(String customerTypeID, Northwind_dbo_CustomerDemographics_IR input)
	{
		var uri = GetUriForParamsCustomerTypeID("Northwind_dbo_CustomerDemographics/UpdateByCustomerTypeID", customerTypeID);
		var serializedInput = JsonConvert.SerializeObject(input, _jsonSerializationSettings);
		var result = await _httpClient.PutAsync(uri, new StringContent(serializedInput, Encoding.UTF8, "application/json"));
		result.EnsureSuccessStatusCode();
	}
	public async Task DeleteByEncodedPrimaryKey(String? input)
	{
		if (input == null) return;
		var inputSplits = input.Split((Char)27);
		await DeleteByCustomerTypeID(inputSplits[0]);
	}
	public async Task DeleteByCustomerTypeID(String customerTypeID)
	{
		var uri = GetUriForParamsCustomerTypeID("Northwind_dbo_CustomerDemographics/DeleteByCustomerTypeID", customerTypeID);
		var result = await _httpClient.DeleteAsync(uri);
		result.EnsureSuccessStatusCode();
	}
	private String GetUriForParamsCustomerTypeID(String path, String customerTypeID)
	{
		var query = new Dictionary<String,String>();
		query["customerTypeID"] = customerTypeID;
		return QueryHelpers.AddQueryString(_uriBuilder.Uri.ToString() + path, query);
	}
}
