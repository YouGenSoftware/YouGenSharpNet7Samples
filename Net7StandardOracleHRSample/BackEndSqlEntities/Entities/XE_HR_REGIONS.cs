/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307202848 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Standard Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
using System.ComponentModel.DataAnnotations.Schema;
namespace XE_HR_BackEndSqlEntities.Entities;
/// <summary>
/// SQL Entity Description: Table Description: N/A
/// </summary>
public class XE_HR_REGIONS 
{
	public XE_HR_REGIONS()
	{
	} 
	/// <summary>
	/// Primary Key Column
	/// SQL Data Type: NUMBER 
	/// SQL Default Value: N/A
	/// SQL Column Description: N/A
	/// </summary>
	public virtual Int32 REGION_ID { get; set; }
	/// <summary>
	/// SQL Data Type: VARCHAR2 Chars: 25 
	/// SQL Default Value: N/A
	/// SQL Column Description: N/A
	/// </summary>
	public virtual String? REGION_NAME { get; set; }
	/// <summary>
	/// Entities that reference this entity by foreign key
	/// </summary>
	/// <example>null</example>
	public virtual ICollection<XE_HR_COUNTRIES>?COUNTR_REG_FK_RefBy { get; set; } = new HashSet<XE_HR_COUNTRIES>();
}