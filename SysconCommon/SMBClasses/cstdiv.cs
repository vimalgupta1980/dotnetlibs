using System;
using SysconCommon.Algebras.DataTables;

namespace SMB.Tables {
	public partial class cstdiv : smbtable {
		/// <summary>
		/// Division#                       
		/// </summary>
		[ColumnOrder(10)]
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Division#")]
		public long recnum;

		/// <summary>
		/// Description                     
		/// </summary>
		[ColumnOrder(20)]
		[SMBFieldName("divnme")]
		[SMBFieldDescription("Description")]
		public string divnme;

	}
}