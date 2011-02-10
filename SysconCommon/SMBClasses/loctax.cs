using System;
using SysconCommon.Algebras.DataTables;

namespace SMB.Tables {
	public partial class loctax : smbtable {
		/// <summary>
		/// District#                       
		/// </summary>
		[ColumnOrder(10)]
		[SMBFieldName("recnum")]
		[SMBFieldDescription("District#")]
		public long recnum;

		/// <summary>
		/// District Name                   
		/// </summary>
		[ColumnOrder(20)]
		[SMBFieldName("dscrpt")]
		[SMBFieldDescription("District Name")]
		public string dscrpt;

		/// <summary>
		/// Resident Rate                   
		/// </summary>
		[ColumnOrder(30)]
		[SMBFieldName("resrte")]
		[SMBFieldDescription("Resident Rate")]
		public decimal resrte;

		/// <summary>
		/// Non-Res Rate                    
		/// </summary>
		[ColumnOrder(40)]
		[SMBFieldName("nonrte")]
		[SMBFieldDescription("Non-Res Rate")]
		public decimal nonrte;

		/// <summary>
		/// Tax State                       
		/// </summary>
		[ColumnOrder(50)]
		[SMBFieldName("inctax")]
		[SMBFieldDescription("Tax State")]
		public string inctax;

	}
}