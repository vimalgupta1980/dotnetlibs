using System;
using SysconCommon.Algebras.DataTables;

namespace SMB.Tables {
	public partial class untprp : smbtable {
		/// <summary>
		/// Job#                            
		/// </summary>
		[ColumnOrder(10)]
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Job#")]
		public long recnum;

		/// <summary>
		/// Lock Edit                       
		/// </summary>
		[ColumnOrder(20)]
		[SMBFieldName("lckedt")]
		[SMBFieldDescription("Lock Edit")]
		public long lckedt;

		/// <summary>
		/// Edit Date                       
		/// </summary>
		[ColumnOrder(30)]
		[SMBFieldName("edtdte")]
		[SMBFieldDescription("Edit Date")]
		public DateTime edtdte;

		/// <summary>
		/// User Name                       
		/// </summary>
		[ColumnOrder(40)]
		[SMBFieldName("usrnme")]
		[SMBFieldDescription("User Name")]
		public string usrnme;

		/// <summary>
		/// Total Proposal                  
		/// </summary>
		[ColumnOrder(50)]
		[SMBFieldName("ttlcst")]
		[SMBFieldDescription("Total Proposal")]
		public decimal ttlcst;

		/// <summary>
		/// Hot List                        
		/// </summary>
		[ColumnOrder(60)]
		[SMBFieldName("hotlst")]
		[SMBFieldDescription("Hot List")]
		public long hotlst;

		/// <summary>
		/// Notes                           
		/// </summary>
		[ColumnOrder(70)]
		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

	}
}