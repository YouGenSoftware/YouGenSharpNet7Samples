/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307202958 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Enterprise Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
namespace XE_HR_BackEndSqlEntities.Entities;
	/// <summary>
	/// SQL Entity Description: Stored Procedure Output Query Model
	/// </summary>
public class XE_HR_PACKAGE1_PARAMOUTCURSORS_OM_Query1
{
	public XE_HR_PACKAGE1_PARAMOUTCURSORS_OM_Query1()
	{
	}
	public XE_HR_PACKAGE1_PARAMOUTCURSORS_OM_Query1(
		Decimal eMPLOYEE_ID_,
		String sTART_DATE_,
		String eND_DATE_,
		String jOB_ID_,
		Decimal? dEPARTMENT_ID_
	)
	{
		EMPLOYEE_ID = eMPLOYEE_ID_;
		START_DATE = sTART_DATE_;
		END_DATE = eND_DATE_;
		JOB_ID = jOB_ID_;
		DEPARTMENT_ID = dEPARTMENT_ID_;
	}
	/// <summary>
	/// SQL Data Type: NUMBER Chars: 22 Precision: 6 
	/// </summary>
	public virtual Decimal EMPLOYEE_ID { get; set; }
	/// <summary>
	/// SQL Data Type: DATE Chars: 7 
	/// </summary>
	public virtual String START_DATE { get; set; } = null!;
	/// <summary>
	/// SQL Data Type: DATE Chars: 7 
	/// </summary>
	public virtual String END_DATE { get; set; } = null!;
	/// <summary>
	/// SQL Data Type: VARCHAR2 Chars: 10 
	/// </summary>
	public virtual String JOB_ID { get; set; } = null!;
	/// <summary>
	/// SQL Data Type: NUMBER Chars: 22 Precision: 4 
	/// </summary>
	public virtual Decimal? DEPARTMENT_ID { get; set; }
}
