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
/// Sql Entity Description: Model Description: Stored Procedure Input Model
/// </summary>
public class XE_HR_PACKAGE1_OPEN_ONE_CURSOR_IM_IR
{
	public XE_HR_PACKAGE1_OPEN_ONE_CURSOR_IM_IR() 
	{
	} 
	public XE_HR_PACKAGE1_OPEN_ONE_CURSOR_IM_IR(
		Int32? n_EMPNO_
	)
	{
		N_EMPNO = n_EMPNO_;
	}
	[JsonConstructor]
	public XE_HR_PACKAGE1_OPEN_ONE_CURSOR_IM_IR(
		Int32? N_EMPNO,
		Int32? N_EMPNO_OriginalValue,
		Boolean N_EMPNO_HasBeenChanged
	)
	{
		this.N_EMPNO = N_EMPNO;
		this.N_EMPNO_OriginalValue = N_EMPNO_OriginalValue;
		this.N_EMPNO_HasBeenChanged = N_EMPNO_HasBeenChanged;
	}
	public Int32? N_EMPNO
	{
		get => _n_EMPNO;
		set
		{
			_n_EMPNO = value;
			N_EMPNO_HasBeenChanged = _n_EMPNO == N_EMPNO_OriginalValue ? false : true;
		}
	}
	private Int32? _n_EMPNO;
	public Int32? N_EMPNO_OriginalValue { get; private set; }
	public Boolean N_EMPNO_HasBeenChanged { get; private set; }
}