/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307202958 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Enterprise Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
using System.ComponentModel.DataAnnotations.Schema;
namespace XE_HR_BackEndSqlEntities.Entities;
/// <summary>
/// SQL Entity Description: Table Description: N/A
/// </summary>
public class XE_HR_LOCATIONS 
{
	public XE_HR_LOCATIONS()
	{
	} 
	public XE_HR_LOCATIONS(
		Int32 lOCATION_ID_,
		String? sTREET_ADDRESS_,
		String? pOSTAL_CODE_,
		String cITY_,
		String? sTATE_PROVINCE_,
		String? cOUNTRY_ID_
	)
	{
		LOCATION_ID = lOCATION_ID_;
		STREET_ADDRESS = sTREET_ADDRESS_;
		POSTAL_CODE = pOSTAL_CODE_;
		CITY = cITY_;
		STATE_PROVINCE = sTATE_PROVINCE_;
		COUNTRY_ID = cOUNTRY_ID_;
	}
	/// <summary>
	/// Primary Key Column
	/// SQL Data Type: NUMBER Chars: 4 Precision: 4 Scale: 0 
	/// SQL Default Value: N/A
	/// SQL Column Description: Primary key of locations table
	/// </summary>
	public virtual Int32 LOCATION_ID { get; set; }
	/// <summary>
	/// SQL Data Type: VARCHAR2 Chars: 40 
	/// SQL Default Value: N/A
	/// SQL Column Description: Street address of an office, warehouse, or production site of a company.Contains building number and street name
	/// </summary>
	public virtual String? STREET_ADDRESS { get; set; }
	/// <summary>
	/// SQL Data Type: VARCHAR2 Chars: 12 
	/// SQL Default Value: N/A
	/// SQL Column Description: Postal code of the location of an office, warehouse, or production site of a company. 
	/// </summary>
	public virtual String? POSTAL_CODE { get; set; }
	/// <summary>
	/// SQL Data Type: VARCHAR2 Chars: 30 
	/// SQL Default Value: N/A
	/// SQL Column Description: A not null column that shows city where an office, warehouse, or production site of a company is located. 
	/// </summary>
	public virtual String CITY { get; set; } = null!;
	/// <summary>
	/// SQL Data Type: VARCHAR2 Chars: 25 
	/// SQL Default Value: N/A
	/// SQL Column Description: State or Province where an office, warehouse, or production site of a company is located.
	/// </summary>
	public virtual String? STATE_PROVINCE { get; set; }
	/// <summary>
	/// Foreign Key Column
	/// SQL Data Type: CHAR Chars: 2 
	/// SQL Default Value: N/A
	/// SQL Column Description: Country where an office, warehouse, or production site of a company islocated. Foreign key to country_id column of the countries table.
	/// </summary>
	public virtual String? COUNTRY_ID { get; set; }
	/// <summary>
	/// Foreign key entity
	/// </summary>
	/// <example>null</example>
	public virtual XE_HR_COUNTRIES? LOC_C_ID_FK_Ref { get; set; }
	/// <summary>
	/// Entities that reference this entity by foreign key
	/// </summary>
	/// <example>null</example>
	public virtual ICollection<XE_HR_DEPARTMENTS>?DEPT_LOC_FK_RefBy { get; set; } = new HashSet<XE_HR_DEPARTMENTS>();
}
