using System;
using SysconCommon.Algebras.DataTables;

namespace SMB.Tables {
	public partial class sbmsts : smbtable {
		/// <summary>
		/// Submittal Line Status           
		/// </summary>
		[ColumnOrder(10)]
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Submittal Line Status")]
		public long recnum;

		/// <summary>
		/// Description                     
		/// </summary>
		[ColumnOrder(20)]
		[SMBFieldName("stsnme")]
		[SMBFieldDescription("Description")]
		public string stsnme;

	}
}