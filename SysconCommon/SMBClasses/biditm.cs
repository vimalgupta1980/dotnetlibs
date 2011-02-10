using System;
using SysconCommon.Algebras.DataTables;

namespace SMB.Tables {
	public partial class biditm : smbtable {
		/// <summary>
		/// Job#                            
		/// </summary>
		[ColumnOrder(10)]
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Job#")]
		public long recnum;

		/// <summary>
		/// Item#                           
		/// </summary>
		[ColumnOrder(20)]
		[SMBFieldName("itmnum")]
		[SMBFieldDescription("Item#")]
		public long itmnum;

		/// <summary>
		/// Item Code                       
		/// </summary>
		[ColumnOrder(30)]
		[SMBFieldName("itmcde")]
		[SMBFieldDescription("Item Code")]
		public string itmcde;

		/// <summary>
		/// Description                     
		/// </summary>
		[ColumnOrder(40)]
		[SMBFieldName("itmnme")]
		[SMBFieldDescription("Description")]
		public string itmnme;

		/// <summary>
		/// Unit                            
		/// </summary>
		[ColumnOrder(50)]
		[SMBFieldName("untdsc")]
		[SMBFieldDescription("Unit")]
		public string untdsc;

		/// <summary>
		/// Quantity                        
		/// </summary>
		[ColumnOrder(60)]
		[SMBFieldName("bidqty")]
		[SMBFieldDescription("Quantity")]
		public decimal bidqty;

		/// <summary>
		/// Item Type                       
		/// </summary>
		[ColumnOrder(70)]
		[SMBFieldName("itmtyp")]
		[SMBFieldDescription("Item Type")]
		public long itmtyp;

		/// <summary>
		/// Overhead                        
		/// </summary>
		[ColumnOrder(80)]
		[SMBFieldName("ovrhed")]
		[SMBFieldDescription("Overhead")]
		public decimal ovrhed;

		/// <summary>
		/// Profit                          
		/// </summary>
		[ColumnOrder(90)]
		[SMBFieldName("profit")]
		[SMBFieldDescription("Profit")]
		public decimal profit;

		/// <summary>
		/// Notes                           
		/// </summary>
		[ColumnOrder(100)]
		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

	}
}