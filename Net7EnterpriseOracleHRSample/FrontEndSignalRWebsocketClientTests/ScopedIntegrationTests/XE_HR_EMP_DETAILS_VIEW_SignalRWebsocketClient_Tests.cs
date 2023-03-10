/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307202958 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Enterprise Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
using Microsoft.VisualStudio.TestTools.UnitTesting;
using XE_HR_FrontEndSignalRWebsocketClient.SignalRWebsocketClients;
using XE_HR_FrontEndSignalRWebsocketClientTests;
namespace XE_HR_FrontEndSignalRWebsocketClientTests.ScopedIntegrationTests;
[TestClass()]
public class XE_HR_EMP_DETAILS_VIEW_SignalRWebsocketClient_Tests : SignalRWebsocketClientTestBase
{   
	protected IXE_HR_EMP_DETAILS_VIEW_SignalRWebsocketClient? _signalRWebsocketClient;
	[TestInitialize()]
    public override async Task Init()
    {
        await base.Init();
        _signalRWebsocketClient = new XE_HR_EMP_DETAILS_VIEW_SignalRWebsocketClient(_hubUriBase + "/XE_HR_EMP_DETAILS_VIEW_Hub");
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
}
