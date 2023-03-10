/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307200541 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Professional Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
// For reads only
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
namespace Northwind_Common.IndirectReferenceTransformerModels;
/// <summary>
/// Sql Entity Description: Indirect Referenced Model Description: N/A
/// </summary>
public class Northwind_dbo_Alphabetical_list_of_products_IR
{
	public Northwind_dbo_Alphabetical_list_of_products_IR() 
	{
	} 
	public Northwind_dbo_Alphabetical_list_of_products_IR(
		String? productID_IR_,
		String? productName_,
		String? supplierID_IR_,
		String? categoryID_IR_,
		String? quantityPerUnit_,
		Decimal? unitPrice_,
		Int16? unitsInStock_,
		Int16? unitsOnOrder_,
		Int16? reorderLevel_,
		Boolean? discontinued_,
		String? categoryName_
	)
	{
		_productID_IR = productID_IR_;
		ProductID_IR_OriginalValue = productID_IR_;
		_productName = productName_;
		ProductName_OriginalValue = productName_;
		_supplierID_IR = supplierID_IR_;
		SupplierID_IR_OriginalValue = supplierID_IR_;
		_categoryID_IR = categoryID_IR_;
		CategoryID_IR_OriginalValue = categoryID_IR_;
		_quantityPerUnit = quantityPerUnit_;
		QuantityPerUnit_OriginalValue = quantityPerUnit_;
		_unitPrice = unitPrice_;
		UnitPrice_OriginalValue = unitPrice_;
		_unitsInStock = unitsInStock_;
		UnitsInStock_OriginalValue = unitsInStock_;
		_unitsOnOrder = unitsOnOrder_;
		UnitsOnOrder_OriginalValue = unitsOnOrder_;
		_reorderLevel = reorderLevel_;
		ReorderLevel_OriginalValue = reorderLevel_;
		_discontinued = discontinued_;
		Discontinued_OriginalValue = discontinued_;
		_categoryName = categoryName_;
		CategoryName_OriginalValue = categoryName_;
	}
	[JsonConstructor]
	public Northwind_dbo_Alphabetical_list_of_products_IR(
		String? ProductID_IR,
		String? ProductID_IR_OriginalValue,
		Boolean ProductID_IR_HasBeenChanged,
		String? ProductName,
		String? ProductName_OriginalValue,
		Boolean ProductName_HasBeenChanged,
		String? SupplierID_IR,
		String? SupplierID_IR_OriginalValue,
		Boolean SupplierID_IR_HasBeenChanged,
		String? CategoryID_IR,
		String? CategoryID_IR_OriginalValue,
		Boolean CategoryID_IR_HasBeenChanged,
		String? QuantityPerUnit,
		String? QuantityPerUnit_OriginalValue,
		Boolean QuantityPerUnit_HasBeenChanged,
		Decimal? UnitPrice,
		Decimal? UnitPrice_OriginalValue,
		Boolean UnitPrice_HasBeenChanged,
		Int16? UnitsInStock,
		Int16? UnitsInStock_OriginalValue,
		Boolean UnitsInStock_HasBeenChanged,
		Int16? UnitsOnOrder,
		Int16? UnitsOnOrder_OriginalValue,
		Boolean UnitsOnOrder_HasBeenChanged,
		Int16? ReorderLevel,
		Int16? ReorderLevel_OriginalValue,
		Boolean ReorderLevel_HasBeenChanged,
		Boolean? Discontinued,
		Boolean? Discontinued_OriginalValue,
		Boolean Discontinued_HasBeenChanged,
		String? CategoryName,
		String? CategoryName_OriginalValue,
		Boolean CategoryName_HasBeenChanged
	)
	{
		this.ProductID_IR = ProductID_IR;
		this.ProductID_IR_OriginalValue = ProductID_IR_OriginalValue;
		this.ProductID_IR_HasBeenChanged = ProductID_IR_HasBeenChanged;
		this.ProductName = ProductName;
		this.ProductName_OriginalValue = ProductName_OriginalValue;
		this.ProductName_HasBeenChanged = ProductName_HasBeenChanged;
		this.SupplierID_IR = SupplierID_IR;
		this.SupplierID_IR_OriginalValue = SupplierID_IR_OriginalValue;
		this.SupplierID_IR_HasBeenChanged = SupplierID_IR_HasBeenChanged;
		this.CategoryID_IR = CategoryID_IR;
		this.CategoryID_IR_OriginalValue = CategoryID_IR_OriginalValue;
		this.CategoryID_IR_HasBeenChanged = CategoryID_IR_HasBeenChanged;
		this.QuantityPerUnit = QuantityPerUnit;
		this.QuantityPerUnit_OriginalValue = QuantityPerUnit_OriginalValue;
		this.QuantityPerUnit_HasBeenChanged = QuantityPerUnit_HasBeenChanged;
		this.UnitPrice = UnitPrice;
		this.UnitPrice_OriginalValue = UnitPrice_OriginalValue;
		this.UnitPrice_HasBeenChanged = UnitPrice_HasBeenChanged;
		this.UnitsInStock = UnitsInStock;
		this.UnitsInStock_OriginalValue = UnitsInStock_OriginalValue;
		this.UnitsInStock_HasBeenChanged = UnitsInStock_HasBeenChanged;
		this.UnitsOnOrder = UnitsOnOrder;
		this.UnitsOnOrder_OriginalValue = UnitsOnOrder_OriginalValue;
		this.UnitsOnOrder_HasBeenChanged = UnitsOnOrder_HasBeenChanged;
		this.ReorderLevel = ReorderLevel;
		this.ReorderLevel_OriginalValue = ReorderLevel_OriginalValue;
		this.ReorderLevel_HasBeenChanged = ReorderLevel_HasBeenChanged;
		this.Discontinued = Discontinued;
		this.Discontinued_OriginalValue = Discontinued_OriginalValue;
		this.Discontinued_HasBeenChanged = Discontinued_HasBeenChanged;
		this.CategoryName = CategoryName;
		this.CategoryName_OriginalValue = CategoryName_OriginalValue;
		this.CategoryName_HasBeenChanged = CategoryName_HasBeenChanged;
	}
	/// <summary>
	/// SQL Column Description: N/A
	/// </summary>
	public String? ProductID_IR
	{
		get => _productID_IR;
		set
		{
			_productID_IR = value;
			ProductID_IR_HasBeenChanged = _productID_IR == ProductID_IR_OriginalValue ? false : true;
		}
	}
	private String? _productID_IR;
	public String? ProductID_IR_OriginalValue { get; private set; }
	public Boolean ProductID_IR_HasBeenChanged { get; private set; }
	/// <summary>
	/// SQL Column Description: N/A
	/// </summary>
	public String? ProductName
	{
		get => _productName;
		set
		{
			_productName = value;
			ProductName_HasBeenChanged = _productName == ProductName_OriginalValue ? false : true;
		}
	}
	private String? _productName;
	public String? ProductName_OriginalValue { get; private set; }
	public Boolean ProductName_HasBeenChanged { get; private set; }
	/// <summary>
	/// SQL Column Description: N/A
	/// </summary>
	public String? SupplierID_IR
	{
		get => _supplierID_IR;
		set
		{
			_supplierID_IR = value;
			SupplierID_IR_HasBeenChanged = _supplierID_IR == SupplierID_IR_OriginalValue ? false : true;
		}
	}
	private String? _supplierID_IR;
	public String? SupplierID_IR_OriginalValue { get; private set; }
	public Boolean SupplierID_IR_HasBeenChanged { get; private set; }
	/// <summary>
	/// SQL Column Description: N/A
	/// </summary>
	public String? CategoryID_IR
	{
		get => _categoryID_IR;
		set
		{
			_categoryID_IR = value;
			CategoryID_IR_HasBeenChanged = _categoryID_IR == CategoryID_IR_OriginalValue ? false : true;
		}
	}
	private String? _categoryID_IR;
	public String? CategoryID_IR_OriginalValue { get; private set; }
	public Boolean CategoryID_IR_HasBeenChanged { get; private set; }
	/// <summary>
	/// SQL Column Description: N/A
	/// </summary>
	public String? QuantityPerUnit
	{
		get => _quantityPerUnit;
		set
		{
			_quantityPerUnit = value;
			QuantityPerUnit_HasBeenChanged = _quantityPerUnit == QuantityPerUnit_OriginalValue ? false : true;
		}
	}
	private String? _quantityPerUnit;
	public String? QuantityPerUnit_OriginalValue { get; private set; }
	public Boolean QuantityPerUnit_HasBeenChanged { get; private set; }
	/// <summary>
	/// SQL Column Description: N/A
	/// </summary>
	public Decimal? UnitPrice
	{
		get => _unitPrice;
		set
		{
			_unitPrice = value;
			UnitPrice_HasBeenChanged = _unitPrice == UnitPrice_OriginalValue ? false : true;
		}
	}
	private Decimal? _unitPrice;
	public Decimal? UnitPrice_OriginalValue { get; private set; }
	public Boolean UnitPrice_HasBeenChanged { get; private set; }
	/// <summary>
	/// SQL Column Description: N/A
	/// </summary>
	public Int16? UnitsInStock
	{
		get => _unitsInStock;
		set
		{
			_unitsInStock = value;
			UnitsInStock_HasBeenChanged = _unitsInStock == UnitsInStock_OriginalValue ? false : true;
		}
	}
	private Int16? _unitsInStock;
	public Int16? UnitsInStock_OriginalValue { get; private set; }
	public Boolean UnitsInStock_HasBeenChanged { get; private set; }
	/// <summary>
	/// SQL Column Description: N/A
	/// </summary>
	public Int16? UnitsOnOrder
	{
		get => _unitsOnOrder;
		set
		{
			_unitsOnOrder = value;
			UnitsOnOrder_HasBeenChanged = _unitsOnOrder == UnitsOnOrder_OriginalValue ? false : true;
		}
	}
	private Int16? _unitsOnOrder;
	public Int16? UnitsOnOrder_OriginalValue { get; private set; }
	public Boolean UnitsOnOrder_HasBeenChanged { get; private set; }
	/// <summary>
	/// SQL Column Description: N/A
	/// </summary>
	public Int16? ReorderLevel
	{
		get => _reorderLevel;
		set
		{
			_reorderLevel = value;
			ReorderLevel_HasBeenChanged = _reorderLevel == ReorderLevel_OriginalValue ? false : true;
		}
	}
	private Int16? _reorderLevel;
	public Int16? ReorderLevel_OriginalValue { get; private set; }
	public Boolean ReorderLevel_HasBeenChanged { get; private set; }
	/// <summary>
	/// SQL Column Description: N/A
	/// </summary>
	public Boolean? Discontinued
	{
		get => _discontinued;
		set
		{
			_discontinued = value;
			Discontinued_HasBeenChanged = _discontinued == Discontinued_OriginalValue ? false : true;
		}
	}
	private Boolean? _discontinued;
	public Boolean? Discontinued_OriginalValue { get; private set; }
	public Boolean Discontinued_HasBeenChanged { get; private set; }
	/// <summary>
	/// SQL Column Description: N/A
	/// </summary>
	public String? CategoryName
	{
		get => _categoryName;
		set
		{
			_categoryName = value;
			CategoryName_HasBeenChanged = _categoryName == CategoryName_OriginalValue ? false : true;
		}
	}
	private String? _categoryName;
	public String? CategoryName_OriginalValue { get; private set; }
	public Boolean CategoryName_HasBeenChanged { get; private set; }
}
