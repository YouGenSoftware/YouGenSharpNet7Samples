/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307202958 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Enterprise Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
namespace XE_HR_Common.IndirectReferenceTransformerModels;
/// <summary>
/// Sql Entity Description: Model Description: Stored Procedure Output Model Query 1
/// </summary>
public class XE_HR_PACKAGE1_PARAMOUTCURSORS_OM_Query1_IR
{
	public XE_HR_PACKAGE1_PARAMOUTCURSORS_OM_Query1_IR() 
	{
	} 
	public XE_HR_PACKAGE1_PARAMOUTCURSORS_OM_Query1_IR(
		String? eMPLOYEE_ID_IR_,
		String sTART_DATE_,
		String eND_DATE_,
		String jOB_ID_,
		String? dEPARTMENT_ID_IR_
	)
	{
		EMPLOYEE_ID_IR = eMPLOYEE_ID_IR_;
		START_DATE = sTART_DATE_;
		END_DATE = eND_DATE_;
		JOB_ID = jOB_ID_;
		DEPARTMENT_ID_IR = dEPARTMENT_ID_IR_;
	}
	[JsonConstructor]
	public XE_HR_PACKAGE1_PARAMOUTCURSORS_OM_Query1_IR(
		String? EMPLOYEE_ID_IR,
		String? EMPLOYEE_ID_IR_OriginalValue,
		Boolean EMPLOYEE_ID_IR_HasBeenChanged,
		String? START_DATE,
		String? START_DATE_OriginalValue,
		Boolean START_DATE_HasBeenChanged,
		String? END_DATE,
		String? END_DATE_OriginalValue,
		Boolean END_DATE_HasBeenChanged,
		String? JOB_ID,
		String? JOB_ID_OriginalValue,
		Boolean JOB_ID_HasBeenChanged,
		String? DEPARTMENT_ID_IR,
		String? DEPARTMENT_ID_IR_OriginalValue,
		Boolean DEPARTMENT_ID_IR_HasBeenChanged
	)
	{
		this.EMPLOYEE_ID_IR = EMPLOYEE_ID_IR;
		this.EMPLOYEE_ID_IR_OriginalValue = EMPLOYEE_ID_IR_OriginalValue;
		this.EMPLOYEE_ID_IR_HasBeenChanged = EMPLOYEE_ID_IR_HasBeenChanged;
		this.START_DATE = START_DATE;
		this.START_DATE_OriginalValue = START_DATE_OriginalValue;
		this.START_DATE_HasBeenChanged = START_DATE_HasBeenChanged;
		this.END_DATE = END_DATE;
		this.END_DATE_OriginalValue = END_DATE_OriginalValue;
		this.END_DATE_HasBeenChanged = END_DATE_HasBeenChanged;
		this.JOB_ID = JOB_ID;
		this.JOB_ID_OriginalValue = JOB_ID_OriginalValue;
		this.JOB_ID_HasBeenChanged = JOB_ID_HasBeenChanged;
		this.DEPARTMENT_ID_IR = DEPARTMENT_ID_IR;
		this.DEPARTMENT_ID_IR_OriginalValue = DEPARTMENT_ID_IR_OriginalValue;
		this.DEPARTMENT_ID_IR_HasBeenChanged = DEPARTMENT_ID_IR_HasBeenChanged;
	}
	public String? EMPLOYEE_ID_IR
	{
		get => _eMPLOYEE_ID_IR;
		set
		{
			_eMPLOYEE_ID_IR = value;
			EMPLOYEE_ID_IR_HasBeenChanged = _eMPLOYEE_ID_IR == EMPLOYEE_ID_IR_OriginalValue ? false : true;
		}
	}
	private String? _eMPLOYEE_ID_IR;
	public String? EMPLOYEE_ID_IR_OriginalValue { get; private set; }
	public Boolean EMPLOYEE_ID_IR_HasBeenChanged { get; private set; }
	public String? START_DATE
	{
		get => _sTART_DATE;
		set
		{
			_sTART_DATE = value;
			START_DATE_HasBeenChanged = _sTART_DATE == START_DATE_OriginalValue ? false : true;
		}
	}
	private String? _sTART_DATE;
	public String? START_DATE_OriginalValue { get; private set; }
	public Boolean START_DATE_HasBeenChanged { get; private set; }
	public String? END_DATE
	{
		get => _eND_DATE;
		set
		{
			_eND_DATE = value;
			END_DATE_HasBeenChanged = _eND_DATE == END_DATE_OriginalValue ? false : true;
		}
	}
	private String? _eND_DATE;
	public String? END_DATE_OriginalValue { get; private set; }
	public Boolean END_DATE_HasBeenChanged { get; private set; }
	public String? JOB_ID
	{
		get => _jOB_ID;
		set
		{
			_jOB_ID = value;
			JOB_ID_HasBeenChanged = _jOB_ID == JOB_ID_OriginalValue ? false : true;
		}
	}
	private String? _jOB_ID;
	public String? JOB_ID_OriginalValue { get; private set; }
	public Boolean JOB_ID_HasBeenChanged { get; private set; }
	public String? DEPARTMENT_ID_IR
	{
		get => _dEPARTMENT_ID_IR;
		set
		{
			_dEPARTMENT_ID_IR = value;
			DEPARTMENT_ID_IR_HasBeenChanged = _dEPARTMENT_ID_IR == DEPARTMENT_ID_IR_OriginalValue ? false : true;
		}
	}
	private String? _dEPARTMENT_ID_IR;
	public String? DEPARTMENT_ID_IR_OriginalValue { get; private set; }
	public Boolean DEPARTMENT_ID_IR_HasBeenChanged { get; private set; }
}