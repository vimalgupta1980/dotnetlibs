using System;
using SysconCommon.Algebras.DataTables;

namespace SMB.Tables {
	public partial class trntyp : smbtable {
		/// <summary>
		/// Training Type#                  
		/// </summary>
		[ColumnOrder(10)]
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Training Type#")]
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