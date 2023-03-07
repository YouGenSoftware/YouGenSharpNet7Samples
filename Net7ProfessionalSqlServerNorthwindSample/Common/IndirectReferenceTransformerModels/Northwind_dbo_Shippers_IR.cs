/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307200541 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Professional Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
namespace Northwind_Common.IndirectReferenceTransformerModels;
/// <summary>
/// Sql Entity Description: Indirect Referenced Model Description: N/A
/// </summary>
public class Northwind_dbo_Shippers_IR
{
	public Northwind_dbo_Shippers_IR() 
	{
	} 
	public Northwind_dbo_Shippers_IR(
		String? shipperID_IR_,
		String? companyName_,
		String? phone_
	)
	{
		_shipperID_IR = shipperID_IR_;
		ShipperID_IR_OriginalValue = shipperID_IR_;
		_companyName = companyName_;
		CompanyName_OriginalValue = companyName_;
		_phone = phone_;
		Phone_OriginalValue = phone_;
		PrimaryKeyEncryptedForUpdateDeleteIdentification = shipperID_IR_;
	}
	[JsonConstructor]
	public Northwind_dbo_Shippers_IR(
		String? ShipperID_IR,
		String? ShipperID_IR_OriginalValue,
		Boolean ShipperID_IR_HasBeenChanged,
		String CompanyName,
		String CompanyName_OriginalValue,
		Boolean CompanyName_HasBeenChanged,
		String? Phone,
		String? Phone_OriginalValue,
		Boolean Phone_HasBeenChanged,
		String? PrimaryKeyEncryptedForUpdateDeleteIdentification,
		String? PrimaryKeyHashedForUniqueObjectComparison
	)
	{
		this.ShipperID_IR = ShipperID_IR;
		this.ShipperID_IR_OriginalValue = ShipperID_IR_OriginalValue;
		this.ShipperID_IR_HasBeenChanged = ShipperID_IR_HasBeenChanged;
		this.CompanyName = CompanyName;
		this.CompanyName_OriginalValue = CompanyName_OriginalValue;
		this.CompanyName_HasBeenChanged = CompanyName_HasBeenChanged;
		this.Phone = Phone;
		this.Phone_OriginalValue = Phone_OriginalValue;
		this.Phone_HasBeenChanged = Phone_HasBeenChanged;
		this.PrimaryKeyEncryptedForUpdateDeleteIdentification = PrimaryKeyEncryptedForUpdateDeleteIdentification;
		this.PrimaryKeyHashedForUniqueObjectComparison = PrimaryKeyHashedForUniqueObjectComparison;
	}
	/// <summary>
	/// SQL Column Description: Primary key encrypted value for update and delete identification purposes
	/// </summary>
	public String? PrimaryKeyEncryptedForUpdateDeleteIdentification { get; set; }
	/// <summary>
	/// SQL Column Description: Primary key hashed value for uniue object comparison purposes
	/// </summary>
	public String? PrimaryKeyHashedForUniqueObjectComparison { get; set; }
	/// <summary>
	/// SQL Column Description: N/A
	/// </summary>
	public String? ShipperID_IR
	{
		get => _shipperID_IR;
		set
		{
			_shipperID_IR = value;
			ShipperID_IR_HasBeenChanged = _shipperID_IR == ShipperID_IR_OriginalValue ? false : true;
		}
	}
	private String? _shipperID_IR;
	public String? ShipperID_IR_OriginalValue { get; private set; }
	public Boolean ShipperID_IR_HasBeenChanged { get; private set; }
	/// <summary>
	/// SQL Column Description: N/A
	/// </summary>
	public String? CompanyName
	{
		get => _companyName;
		set
		{
			_companyName = value;
			CompanyName_HasBeenChanged = _companyName == CompanyName_OriginalValue ? false : true;
		}
	}
	private String? _companyName;
	public String? CompanyName_OriginalValue  { get; private set; }
	public Boolean CompanyName_HasBeenChanged  { get; private set; }
	/// <summary>
	/// SQL Column Description: N/A
	/// </summary>
	public String? Phone
	{
		get => _phone;
		set
		{
			_phone = value;
			Phone_HasBeenChanged = _phone == Phone_OriginalValue ? false : true;
		}
	}
	private String? _phone;
	public String? Phone_OriginalValue  { get; private set; }
	public Boolean Phone_HasBeenChanged  { get; private set; }
	/// <summary>
	/// Entities that reference this entity by foreign key
	/// </summary>
	/// <example>null</example>
	public virtual ICollection<Northwind_dbo_Orders_IR>?FK_Orders_Shippers_RefBy_IR { get; set; } = new HashSet<Northwind_dbo_Orders_IR>();
}