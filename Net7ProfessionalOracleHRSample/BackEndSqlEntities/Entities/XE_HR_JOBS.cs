/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307202926 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Professional Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
using System.ComponentModel.DataAnnotations.Schema;
namespace XE_HR_BackEndSqlEntities.Entities;
/// <summary>
/// SQL Entity Description: Table Description: jobs table with job titles and salary ranges. Contains 19 rows.References with employees and job_history table.
/// </summary>
public class XE_HR_JOBS 
{
	public XE_HR_JOBS()
	{
	} 
	public XE_HR_JOBS(
		String jOB_ID_,
		String jOB_TITLE_,
		Int32? mIN_SALARY_,
		Int32? mAX_SALARY_
	)
	{
		JOB_ID = jOB_ID_;
		JOB_TITLE = jOB_TITLE_;
		MIN_SALARY = mIN_SALARY_;
		MAX_SALARY = mAX_SALARY_;
	}
	/// <summary>
	/// Primary Key Column
	/// SQL Data Type: VARCHAR2 Chars: 10 
	/// SQL Default Value: N/A
	/// SQL Column Description: Primary key of jobs table.
	/// </summary>
	public virtual String JOB_ID { get; set; } = null!;
	/// <summary>
	/// SQL Data Type: VARCHAR2 Chars: 35 
	/// SQL Default Value: N/A
	/// SQL Column Description: A not null column that shows job title, e.g. AD_VP, FI_ACCOUNTANT
	/// </summary>
	public virtual String JOB_TITLE { get; set; } = null!;
	/// <summary>
	/// SQL Data Type: NUMBER Chars: 6 Precision: 6 Scale: 0 
	/// SQL Default Value: N/A
	/// SQL Column Description: Minimum salary for a job title.
	/// </summary>
	public virtual Int32? MIN_SALARY { get; set; }
	/// <summary>
	/// SQL Data Type: NUMBER Chars: 6 Precision: 6 Scale: 0 
	/// SQL Default Value: N/A
	/// SQL Column Description: Maximum salary for a job title
	/// </summary>
	public virtual Int32? MAX_SALARY { get; set; }
	/// <summary>
	/// Entities that reference this entity by foreign key
	/// </summary>
	/// <example>null</example>
	public virtual ICollection<XE_HR_EMPLOYEES>?EMP_JOB_FK_RefBy { get; set; } = new HashSet<XE_HR_EMPLOYEES>();
	public virtual ICollection<XE_HR_JOB_HISTORY>?JHIST_JOB_FK_RefBy { get; set; } = new HashSet<XE_HR_JOB_HISTORY>();
}
