using System;
using SysconCommon.Algebras.DataTables;

namespace SMB.Tables {
	public partial class clnsts : smbtable {
		/// <summary>
		/// Client Status#                  
		/// </summary>
		[ColumnOrder(10)]
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Client Status#")]
		public long recnum;

		/// <summary>
		/// Status Name                     
		/// </summary>
		[ColumnOrder(20)]
		[SMBFieldName("stsnme")]
		[SMBFieldDescription("Status Name")]
		public string stsnme;

	}
}