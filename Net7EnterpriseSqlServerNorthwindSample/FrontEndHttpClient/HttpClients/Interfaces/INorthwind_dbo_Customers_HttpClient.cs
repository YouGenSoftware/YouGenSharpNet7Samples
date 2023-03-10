/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307200636 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Enterprise Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
using Northwind_Common.IndirectReferenceTransformerModels;
namespace Northwind_FrontEndHttpClient.HttpClients;
public interface INorthwind_dbo_Customers_HttpClient
{
	Task<IEnumerable<Northwind_dbo_Customers_IR>?> GetAll();
	Task<IEnumerable<Northwind_dbo_Customers_IR>?> GetByBestMatchedQueryPattern(Northwind_dbo_Customers_IR input);
	Task<IEnumerable<Northwind_dbo_Customers_IR>?> GetByCity(String? city);
	Task<IEnumerable<Northwind_dbo_Customers_IR>?> GetByCompanyName(String companyName);
	Task<IEnumerable<Northwind_dbo_Customers_IR>?> GetByCustomerID(String customerID);
	Task<IEnumerable<Northwind_dbo_Customers_IR>?> GetByPostalCode(String? postalCode);
	Task<IEnumerable<Northwind_dbo_Customers_IR>?> GetByRegion(String? region);
	Task<Northwind_dbo_Customers_IR?> Create(Northwind_dbo_Customers_IR input);
	Task UpdateByCity(String? city, Northwind_dbo_Customers_IR input);
	Task UpdateByCompanyName(String companyName, Northwind_dbo_Customers_IR input);
	Task UpdateByCustomerID(String customerID, Northwind_dbo_Customers_IR input);
	Task UpdateByPostalCode(String? postalCode, Northwind_dbo_Customers_IR input);
	Task UpdateByRegion(String? region, Northwind_dbo_Customers_IR input);
	Task DeleteByCity(String? city);
	Task DeleteByCompanyName(String companyName);
	Task DeleteByCustomerID(String customerID);
	Task DeleteByPostalCode(String? postalCode);
	Task DeleteByRegion(String? region);
}
