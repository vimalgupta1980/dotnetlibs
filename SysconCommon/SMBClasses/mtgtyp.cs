using System;
using SysconCommon.Algebras.DataTables;

namespace SMB.Tables {
	public partial class mtgtyp : smbtable {
		/// <summary>
		/// Type#                           
		/// </summary>
		[ColumnOrder(10)]
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Type#")]
		public long recnum;

		/// <summary>
		/// Type Name                       
		/// </summary>
		[ColumnOrder(20)]
		[SMBFieldName("dscrpt")]
		[SMBFieldDescription("Type Name")]
		public string dscrpt;

	}
}