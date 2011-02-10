using System;
using SysconCommon.Algebras.DataTables;

namespace SMB.Tables {
	public partial class conlst : smbtable {
		/// <summary>
		/// Contract#                       
		/// </summary>
		[ColumnOrder(10)]
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Contract#")]
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