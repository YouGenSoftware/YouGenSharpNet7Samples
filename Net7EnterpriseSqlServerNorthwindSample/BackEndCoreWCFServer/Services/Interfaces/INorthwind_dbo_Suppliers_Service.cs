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
public interface INorthwind_dbo_Suppliers_Service
{
	[OperationContract]
	Task<IEnumerable<Northwind_dbo_Suppliers_IR>?> GetAll();
	[OperationContract]
	Task<IEnumerable<Northwind_dbo_Suppliers_IR>?> GetByCompanyName(String companyName);
	[OperationContract]
	Task<IEnumerable<Northwind_dbo_Suppliers_IR>?> GetBySupplierID(String? supplierID_IR);
	[OperationContract]
	Task<IEnumerable<Northwind_dbo_Suppliers_IR>?> GetByPostalCode(String? postalCode);
	[OperationContract]
	Task<Northwind_dbo_Suppliers_IR?> Create(Northwind_dbo_Suppliers_IR input);
	[OperationContract]
	Task UpdateByCompanyName(String companyName, Northwind_dbo_Suppliers_IR input);
	[OperationContract]
	Task UpdateBySupplierID(String? supplierID_IR, Northwind_dbo_Suppliers_IR input);
	[OperationContract]
	Task UpdateByPostalCode(String? postalCode, Northwind_dbo_Suppliers_IR input);
	[OperationContract]
	Task DeleteByCompanyName(String companyName);
	[OperationContract]
	Task DeleteBySupplierID(String? supplierID_IR);
	[OperationContract]
	Task DeleteByPostalCode(String? postalCode);
}
