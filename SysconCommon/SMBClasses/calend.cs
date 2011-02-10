using System;
using SysconCommon.Algebras.DataTables;

namespace SMB.Tables {
	public partial class calend : smbtable {
		/// <summary>
		/// Date                            
		/// </summary>
		[ColumnOrder(10)]
		[SMBFieldName("caldte")]
		[SMBFieldDescription("Date")]
		public DateTime caldte;

		/// <summary>
		/// Status                          
		/// </summary>
		[ColumnOrder(20)]
		[SMBFieldName("wrksts")]
		[SMBFieldDescription("Status")]
		public long wrksts;

		/// <summary>
		/// Notes                           
		/// </summary>
		[ColumnOrder(30)]
		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

		/// <summary>
		/// Description                     
		/// </summary>
		[ColumnOrder(40)]
		[SMBFieldName("daydsc")]
		[SMBFieldDescription("Description")]
		public string daydsc;

	}
}