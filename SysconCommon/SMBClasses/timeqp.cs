using System;
using SysconCommon.Algebras.DataTables;

namespace SMB.Tables {
	public partial class timeqp : smbtable {
		/// <summary>
		/// Record#                         
		/// </summary>
		[ColumnOrder(10)]
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Record#")]
		public long recnum;

		/// <summary>
		/// Rate Table Description          
		/// </summary>
		[ColumnOrder(20)]
		[SMBFieldName("tbldsc")]
		[SMBFieldDescription("Rate Table Description")]
		public string tbldsc;

		/// <summary>
		/// Edit Date                       
		/// </summary>
		[ColumnOrder(30)]
		[SMBFieldName("edtdte")]
		[SMBFieldDescription("Edit Date")]
		public DateTime edtdte;

		/// <summary>
		/// Lock Edit                       
		/// </summary>
		[ColumnOrder(40)]
		[SMBFieldName("lckedt")]
		[SMBFieldDescription("Lock Edit")]
		public long lckedt;

		/// <summary>
		/// User                            
		/// </summary>
		[ColumnOrder(50)]
		[SMBFieldName("usrnme")]
		[SMBFieldDescription("User")]
		public string usrnme;

		/// <summary>
		/// Notes                           
		/// </summary>
		[ColumnOrder(60)]
		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

	}
}