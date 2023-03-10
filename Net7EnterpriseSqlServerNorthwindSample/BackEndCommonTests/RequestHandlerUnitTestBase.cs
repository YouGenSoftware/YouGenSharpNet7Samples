/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307200636 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Enterprise Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.IO;
using Newtonsoft.Json;
using Northwind_BackEndCommon.Services;
namespace Northwind_BackEndCommonTests;
public class RequestHandlerUnitTestBase : TestBase
{
	protected IEncryptionDecryptionService? _encryptionDecryptionService;
	[TestInitialize()]
    public override void Init()
    {
		base.Init();
		_encryptionDecryptionService = new EncryptionDecryptionService(_customAppSettings!.EncryptDecryptKey!);	    
	}
}
