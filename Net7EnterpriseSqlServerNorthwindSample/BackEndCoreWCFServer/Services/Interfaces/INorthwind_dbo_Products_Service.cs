/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307200636 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Enterprise Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
using Northwind_Common.IndirectReferenceTransformerModels;
namespace Northwind_BackEndCoreWCFServer.Services;
[ServiceContract]
public interface INorthwind_dbo_Products_Service
{
	[OperationContract]
	Task<IEnumerable<Northwind_dbo_Products_IR>?> GetAll();
	[OperationContract]
	Task<IEnumerable<Northwind_dbo_Products_IR>?> GetByCategoryID(String? categoryID_IR);
	[OperationContract]
	Task<IEnumerable<Northwind_dbo_Products_IR>?> GetByProductID(String? productID_IR);
	[OperationContract]
	Task<IEnumerable<Northwind_dbo_Products_IR>?> GetByProductName(String productName);
	[OperationContract]
	Task<IEnumerable<Northwind_dbo_Products_IR>?> GetBySupplierID(String? supplierID_IR);
	[OperationContract]
	Task<Northwind_dbo_Products_IR?> Create(Northwind_dbo_Products_IR input);
	[OperationContract]
	Task UpdateByCategoryID(String? categoryID_IR, Northwind_dbo_Products_IR input);
	[OperationContract]
	Task UpdateByProductID(String? productID_IR, Northwind_dbo_Products_IR input);
	[OperationContract]
	Task UpdateByProductName(String productName, Northwind_dbo_Products_IR input);
	[OperationContract]
	Task UpdateBySupplierID(String? supplierID_IR, Northwind_dbo_Products_IR input);
	[OperationContract]
	Task DeleteByCategoryID(String? categoryID_IR);
	[OperationContract]
	Task DeleteByProductID(String? productID_IR);
	[OperationContract]
	Task DeleteByProductName(String productName);
	[OperationContract]
	Task DeleteBySupplierID(String? supplierID_IR);
}
