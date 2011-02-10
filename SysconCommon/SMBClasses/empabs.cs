using System;
using SysconCommon.Algebras.DataTables;

namespace SMB.Tables {
	public partial class empabs : smbtable {
		/// <summary>
		/// Absence#                        
		/// </summary>
		[ColumnOrder(10)]
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Absence#")]
		public long recnum;

		/// <summary>
		/// Description                     
		/// </summary>
		[ColumnOrder(20)]
		[SMBFieldName("resabs")]
		[SMBFieldDescription("Description")]
		public string resabs;

	}
}