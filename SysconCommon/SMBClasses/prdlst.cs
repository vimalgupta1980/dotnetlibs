using System;
using SysconCommon.Algebras.DataTables;

namespace SMB.Tables {
	public partial class prdlst : smbtable {
		/// <summary>
		/// Product#                        
		/// </summary>
		[ColumnOrder(10)]
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Product#")]
		public long recnum;

		/// <summary>
		/// Description                     
		/// </summary>
		[ColumnOrder(20)]
		[SMBFieldName("dscrpt")]
		[SMBFieldDescription("Description")]
		public string dscrpt;

	}
}