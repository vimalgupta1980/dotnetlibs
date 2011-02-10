using System;
using SysconCommon.Algebras.DataTables;

namespace SMB.Tables {
	public partial class mallst : smbtable {
		/// <summary>
		/// Mail List#                      
		/// </summary>
		[ColumnOrder(10)]
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Mail List#")]
		public long recnum;

		/// <summary>
		/// List Name                       
		/// </summary>
		[ColumnOrder(20)]
		[SMBFieldName("lstnme")]
		[SMBFieldDescription("List Name")]
		public string lstnme;

	}
}