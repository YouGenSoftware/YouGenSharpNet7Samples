/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307200434 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Standard Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
// For reads only
using System.ComponentModel.DataAnnotations.Schema;
namespace Northwind_BackEndSqlEntities.Entities;
/// <summary>
/// SQL Entity Description: View Description: N/A
/// </summary>
public class Northwind_dbo_Products_Above_Average_Price 
{
	public Northwind_dbo_Products_Above_Average_Price()
	{
	} 
	/// <summary>
	/// SQL Data Type: nvarchar Chars: 40 
	/// SQL Column Description: N/A
	/// </summary>
	public virtual String ProductName { get; set; } = null!;
	/// <summary>
	/// SQL Data Type: money Precision: 19 Scale: 4 
	/// SQL Column Description: N/A
	/// </summary>
	public virtual Decimal? UnitPrice { get; set; }
}
