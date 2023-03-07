/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307202757 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Free Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use for evaluation purposes only. ****
**** This comment block must not be removed. ****
 */
// For reads only
using System.ComponentModel.DataAnnotations.Schema;
namespace XE_HR_BackEndSqlEntities.Entities;
/// <summary>
/// SQL Entity Description: View Description: N/A
/// </summary>
public class XE_HR_EMP_DETAILS_VIEW 
{
	public XE_HR_EMP_DETAILS_VIEW()
	{
	} 
	/// <summary>
	/// SQL Data Type: NUMBER Chars: 6 Precision: 6 Scale: 0 
	/// SQL Column Description: N/A
	/// </summary>
	public virtual Int32 EMPLOYEE_ID { get; set; }
	/// <summary>
	/// SQL Data Type: VARCHAR2 Chars: 10 
	/// SQL Column Description: N/A
	/// </summary>
	public virtual String JOB_ID { get; set; } = null!;
	/// <summary>
	/// SQL Data Type: NUMBER Chars: 6 Precision: 6 Scale: 0 
	/// SQL Column Description: N/A
	/// </summary>
	public virtual Int32? MANAGER_ID { get; set; }
	/// <summary>
	/// SQL Data Type: NUMBER Chars: 4 Precision: 4 Scale: 0 
	/// SQL Column Description: N/A
	/// </summary>
	public virtual Int32? DEPARTMENT_ID { get; set; }
	/// <summary>
	/// SQL Data Type: NUMBER Chars: 4 Precision: 4 Scale: 0 
	/// SQL Column Description: N/A
	/// </summary>
	public virtual Int32? LOCATION_ID { get; set; }
	/// <summary>
	/// SQL Data Type: CHAR Chars: 2 
	/// SQL Column Description: N/A
	/// </summary>
	public virtual String? COUNTRY_ID { get; set; }
	/// <summary>
	/// SQL Data Type: VARCHAR2 Chars: 20 
	/// SQL Column Description: N/A
	/// </summary>
	public virtual String? FIRST_NAME { get; set; }
	/// <summary>
	/// SQL Data Type: VARCHAR2 Chars: 25 
	/// SQL Column Description: N/A
	/// </summary>
	public virtual String LAST_NAME { get; set; } = null!;
	/// <summary>
	/// SQL Data Type: NUMBER Chars: 9 Precision: 8 Scale: 2 
	/// SQL Column Description: N/A
	/// </summary>
	public virtual Decimal? SALARY { get; set; }
	/// <summary>
	/// SQL Data Type: NUMBER Chars: 3 Precision: 2 Scale: 2 
	/// SQL Column Description: N/A
	/// </summary>
	public virtual Decimal? COMMISSION_PCT { get; set; }
	/// <summary>
	/// SQL Data Type: VARCHAR2 Chars: 30 
	/// SQL Column Description: N/A
	/// </summary>
	public virtual String DEPARTMENT_NAME { get; set; } = null!;
	/// <summary>
	/// SQL Data Type: VARCHAR2 Chars: 35 
	/// SQL Column Description: N/A
	/// </summary>
	public virtual String JOB_TITLE { get; set; } = null!;
	/// <summary>
	/// SQL Data Type: VARCHAR2 Chars: 30 
	/// SQL Column Description: N/A
	/// </summary>
	public virtual String CITY { get; set; } = null!;
	/// <summary>
	/// SQL Data Type: VARCHAR2 Chars: 25 
	/// SQL Column Description: N/A
	/// </summary>
	public virtual String? STATE_PROVINCE { get; set; }
	/// <summary>
	/// SQL Data Type: VARCHAR2 Chars: 40 
	/// SQL Column Description: N/A
	/// </summary>
	public virtual String? COUNTRY_NAME { get; set; }
	/// <summary>
	/// SQL Data Type: VARCHAR2 Chars: 25 
	/// SQL Column Description: N/A
	/// </summary>
	public virtual String? REGION_NAME { get; set; }
}