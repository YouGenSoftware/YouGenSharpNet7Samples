/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307200257 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Free Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use for evaluation purposes only. ****
**** This comment block must not be removed. ****
 */
using Northwind_BackEndSqlEntities.Entities;
namespace Northwind_FrontEndHttpClient.HttpClients;
public interface INorthwind_dbo_Products_HttpClient
{
	Task<IEnumerable<Northwind_dbo_Products>?> GetAll();
	Task<IEnumerable<Northwind_dbo_Products>?> GetByCategoryID(Int32? categoryID);
	Task<IEnumerable<Northwind_dbo_Products>?> GetByProductID(Int32 productID);
	Task<IEnumerable<Northwind_dbo_Products>?> GetByProductName(String productName);
	Task<IEnumerable<Northwind_dbo_Products>?> GetBySupplierID(Int32? supplierID);
	Task<Northwind_dbo_Products?> Create(Northwind_dbo_Products input);
	Task UpdateByCategoryID(Int32? categoryID, Northwind_dbo_Products input);
	Task UpdateByProductID(Int32 productID, Northwind_dbo_Products input);
	Task UpdateByProductName(String productName, Northwind_dbo_Products input);
	Task UpdateBySupplierID(Int32? supplierID, Northwind_dbo_Products input);
	Task DeleteByCategoryID(Int32? categoryID);
	Task DeleteByProductID(Int32 productID);
	Task DeleteByProductName(String productName);
	Task DeleteBySupplierID(Int32? supplierID);
}
