using System;
using SysconCommon.Algebras.DataTables;

namespace SMB.Tables {
	public partial class empqtd : smbtable {
		/// <summary>
		/// Employee#                       
		/// </summary>
		[ColumnOrder(10)]
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Employee#")]
		public long recnum;

		/// <summary>
		/// Calculation                     
		/// </summary>
		[ColumnOrder(20)]
		[SMBFieldName("clcnum")]
		[SMBFieldDescription("Calculation")]
		public long clcnum;

		/// <summary>
		/// Rate                            
		/// </summary>
		[ColumnOrder(30)]
		[SMBFieldName("dedrte")]
		[SMBFieldDescription("Rate")]
		public decimal dedrte;

		/// <summary>
		/// Maximum                         
		/// </summary>
		[ColumnOrder(40)]
		[SMBFieldName("dedmax")]
		[SMBFieldDescription("Maximum")]
		public decimal dedmax;

		/// <summary>
		/// Marital                         
		/// </summary>
		[ColumnOrder(50)]
		[SMBFieldName("mrtsts")]
		[SMBFieldDescription("Marital")]
		public long mrtsts;

		/// <summary>
		/// Std Allow                       
		/// </summary>
		[ColumnOrder(60)]
		[SMBFieldName("allows")]
		[SMBFieldDescription("Std Allow")]
		public long allows;

		/// <summary>
		/// Add Allow                       
		/// </summary>
		[ColumnOrder(70)]
		[SMBFieldName("addall")]
		[SMBFieldDescription("Add Allow")]
		public long addall;

		/// <summary>
		/// Table#                          
		/// </summary>
		[ColumnOrder(80)]
		[SMBFieldName("tblnum")]
		[SMBFieldDescription("Table#")]
		public long tblnum;

		/// <summary>
		/// Add W/H                         
		/// </summary>
		[ColumnOrder(90)]
		[SMBFieldName("addste")]
		[SMBFieldDescription("Add W/H")]
		public decimal addste;

		/// <summary>
		/// Offset                          
		/// </summary>
		[ColumnOrder(100)]
		[SMBFieldName("offset")]
		[SMBFieldDescription("Offset")]
		public decimal offset;

		/// <summary>
		/// Quarter 1                       
		/// </summary>
		[ColumnOrder(110)]
		[SMBFieldName("fstqtr")]
		[SMBFieldDescription("Quarter 1")]
		public decimal fstqtr;

		/// <summary>
		/// Quarter 2                       
		/// </summary>
		[ColumnOrder(120)]
		[SMBFieldName("scdqtr")]
		[SMBFieldDescription("Quarter 2")]
		public decimal scdqtr;

		/// <summary>
		/// Quarter 3                       
		/// </summary>
		[ColumnOrder(130)]
		[SMBFieldName("thdqtr")]
		[SMBFieldDescription("Quarter 3")]
		public decimal thdqtr;

		/// <summary>
		/// Quarter 4                       
		/// </summary>
		[ColumnOrder(140)]
		[SMBFieldName("fthqtr")]
		[SMBFieldDescription("Quarter 4")]
		public decimal fthqtr;

	}
}