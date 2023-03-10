/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307202958 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Enterprise Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
using Microsoft.AspNetCore.SignalR.Client;
using XE_HR_Common.IndirectReferenceTransformerModels;
namespace XE_HR_FrontEndSignalRWebsocketClient.SignalRWebsocketClients;
public class XE_HR_COUNTRIES_SignalRWebsocketClient : SignalRWebsocketClientBase, IXE_HR_COUNTRIES_SignalRWebsocketClient, IAsyncDisposable
{
	public XE_HR_COUNTRIES_SignalRWebsocketClient(String hubUrl) : base(hubUrl)
    {
    }
	public async Task<IEnumerable<XE_HR_COUNTRIES_IR>?> GetByBestMatchedQueryPattern(XE_HR_COUNTRIES_IR input)
	{
		if (input == null) return null;
		IEnumerable<XE_HR_COUNTRIES_IR>? retData;
		if (input.COUNTRY_ID_HasBeenChanged) retData = await GetByCOUNTRY_ID(input.COUNTRY_ID ?? String.Empty);
		else retData = await GetAll();
		return retData == null ? null : retData.Where(x => WhereAllFilledFields(x, input));
	}
	private static Boolean WhereAllFilledFields(XE_HR_COUNTRIES_IR record, XE_HR_COUNTRIES_IR filter)
	{
		 // unencrypted properties only
		return			(!filter.COUNTRY_NAME_HasBeenChanged || record.COUNTRY_NAME == filter.COUNTRY_NAME);
	}
	public async Task<IEnumerable<XE_HR_COUNTRIES_IR>?> GetAll()
	{
		return await _hubConnection.InvokeAsync<IEnumerable<XE_HR_COUNTRIES_IR>?>("GetAll");
	}
	public async Task<IEnumerable<XE_HR_COUNTRIES_IR>?> GetByCOUNTRY_ID(String cOUNTRY_ID)
	{
		return await _hubConnection.InvokeAsync<IEnumerable<XE_HR_COUNTRIES_IR>?>("GetByCOUNTRY_ID", cOUNTRY_ID);
	}
	public async Task<XE_HR_COUNTRIES_IR?> Create(XE_HR_COUNTRIES_IR input)
	{
		return await _hubConnection.InvokeAsync<XE_HR_COUNTRIES_IR?>("Create", input);
	}
	public async Task UpdateByEncodedPrimaryKey(String? encodedPrimaryKey, XE_HR_COUNTRIES_IR updateModel)
	{
		if (encodedPrimaryKey == null || updateModel == null) return;
		var inputSplits = encodedPrimaryKey.Split((Char)27);
		await UpdateByCOUNTRY_ID(inputSplits[0], updateModel);
	}
	public async Task UpdateByCOUNTRY_ID(String cOUNTRY_ID, XE_HR_COUNTRIES_IR input)
	{
		await _hubConnection.InvokeAsync("UpdateByCOUNTRY_ID", cOUNTRY_ID, input);
	}
	public async Task DeleteByEncodedPrimaryKey(String? input)
	{
		if (input == null) return;
		var inputSplits = input.Split((Char)27);
		await DeleteByCOUNTRY_ID(inputSplits[0]);
	}
	public async Task DeleteByCOUNTRY_ID(String cOUNTRY_ID)
	{
		await _hubConnection.InvokeAsync("DeleteByCOUNTRY_ID", cOUNTRY_ID);
	}
    public async Task InitializeAsync()
    {
        await base.EstablishConnection();
    }
    public Boolean GetStatus()
    {
        return base.Initiated;
    }
    public async ValueTask DisposeAsync()
    {
        await base.TerminateConnection();
        GC.SuppressFinalize(this);
    }
}
