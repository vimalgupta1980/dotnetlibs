using System;
using SysconCommon.Algebras.DataTables;

namespace SMB.Tables {
	public partial class fdrpun : smbtable {
		/// <summary>
		/// Record#                         
		/// </summary>
		[ColumnOrder(10)]
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Record#")]
		public long recnum;

		/// <summary>
		/// Line#                           
		/// </summary>
		[ColumnOrder(20)]
		[SMBFieldName("linnum")]
		[SMBFieldDescription("Line#")]
		public long linnum;

		/// <summary>
		/// Bid Item                        
		/// </summary>
		[ColumnOrder(30)]
		[SMBFieldName("itmnum")]
		[SMBFieldDescription("Bid Item")]
		public long itmnum;

		/// <summary>
		/// Item Code                       
		/// </summary>
		[ColumnOrder(40)]
		[SMBFieldName("itmcde")]
		[SMBFieldDescription("Item Code")]
		public string itmcde;

		/// <summary>
		/// Unit                            
		/// </summary>
		[ColumnOrder(50)]
		[SMBFieldName("untdsc")]
		[SMBFieldDescription("Unit")]
		public string untdsc;

		/// <summary>
		/// Completed Today                 
		/// </summary>
		[ColumnOrder(60)]
		[SMBFieldName("cmptdy")]
		[SMBFieldDescription("Completed Today")]
		public decimal cmptdy;

	}
}