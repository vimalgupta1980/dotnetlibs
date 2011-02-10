using System;
using SysconCommon.Algebras.DataTables;

namespace SMB.Tables {
	public partial class acppmt : smbtable {
		/// <summary>
		/// Record#                         
		/// </summary>
		[ColumnOrder(10)]
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Record#")]
		public long recnum;

		/// <summary>
		/// Description                     
		/// </summary>
		[ColumnOrder(20)]
		[SMBFieldName("dscrpt")]
		[SMBFieldDescription("Description")]
		public string dscrpt;

		/// <summary>
		/// Trans#                          
		/// </summary>
		[ColumnOrder(30)]
		[SMBFieldName("chknum")]
		[SMBFieldDescription("Trans#")]
		public string chknum;

		/// <summary>
		/// Date                            
		/// </summary>
		[ColumnOrder(40)]
		[SMBFieldName("chkdte")]
		[SMBFieldDescription("Date")]
		public DateTime chkdte;

		/// <summary>
		/// Period                          
		/// </summary>
		[ColumnOrder(50)]
		[SMBFieldName("actper")]
		[SMBFieldDescription("Period")]
		public long actper;

		/// <summary>
		/// Amount Paid                     
		/// </summary>
		[ColumnOrder(60)]
		[SMBFieldName("amount")]
		[SMBFieldDescription("Amount Paid")]
		public decimal amount;

		/// <summary>
		/// Discount Taken                  
		/// </summary>
		[ColumnOrder(70)]
		[SMBFieldName("dsctkn")]
		[SMBFieldDescription("Discount Taken")]
		public decimal dsctkn;

		/// <summary>
		/// Credit Taken                    
		/// </summary>
		[ColumnOrder(80)]
		[SMBFieldName("aplcrd")]
		[SMBFieldDescription("Credit Taken")]
		public decimal aplcrd;

		/// <summary>
		/// Ledger Ref#                     
		/// </summary>
		[ColumnOrder(90)]
		[SMBFieldName("lgrrec")]
		[SMBFieldDescription("Ledger Ref#")]
		public long lgrrec;

	}
}