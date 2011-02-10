using System;
using SysconCommon.Algebras.DataTables;

namespace SMB.Tables {
	public partial class propsl : smbtable {
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
		/// Hot List                        
		/// </summary>
		[ColumnOrder(30)]
		[SMBFieldName("hotlst")]
		[SMBFieldDescription("Hot List")]
		public long hotlst;

		/// <summary>
		/// Edit Date                       
		/// </summary>
		[ColumnOrder(40)]
		[SMBFieldName("edtdte")]
		[SMBFieldDescription("Edit Date")]
		public DateTime edtdte;

		/// <summary>
		/// User Name                       
		/// </summary>
		[ColumnOrder(50)]
		[SMBFieldName("usrnme")]
		[SMBFieldDescription("User Name")]
		public string usrnme;

		/// <summary>
		/// Proposal Basis                  
		/// </summary>
		[ColumnOrder(60)]
		[SMBFieldName("colshw")]
		[SMBFieldDescription("Proposal Basis")]
		public long colshw;

		/// <summary>
		/// Notes                           
		/// </summary>
		[ColumnOrder(70)]
		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

	}
}