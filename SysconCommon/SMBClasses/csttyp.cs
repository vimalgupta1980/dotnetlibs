using System;
using SysconCommon.Algebras.DataTables;

namespace SMB.Tables {
	public partial class csttyp : smbtable {
		/// <summary>
		/// Cost Type#                      
		/// </summary>
		[ColumnOrder(10)]
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Cost Type#")]
		public long recnum;

		/// <summary>
		/// Type Name                       
		/// </summary>
		[ColumnOrder(20)]
		[SMBFieldName("typnme")]
		[SMBFieldDescription("Type Name")]
		public string typnme;

	}
}