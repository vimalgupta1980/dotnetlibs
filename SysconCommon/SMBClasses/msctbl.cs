using System;
using SysconCommon.Algebras.DataTables;

namespace SMB.Tables {
	public partial class msctbl : smbtable {
		/// <summary>
		/// Data Name                       
		/// </summary>
		[ColumnOrder(10)]
		[SMBFieldName("dtanme")]
		[SMBFieldDescription("Data Name")]
		public string dtanme;

		/// <summary>
		/// Line Data                       
		/// </summary>
		[ColumnOrder(20)]
		[SMBFieldName("dtalin")]
		[SMBFieldDescription("Line Data")]
		public string dtalin;

	}
}