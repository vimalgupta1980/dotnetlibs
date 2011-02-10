using System;
using SysconCommon.Algebras.DataTables;

namespace SMB.Tables {
	public partial class lictyp : smbtable {
		/// <summary>
		/// License#                        
		/// </summary>
		[ColumnOrder(10)]
		[SMBFieldName("recnum")]
		[SMBFieldDescription("License#")]
		public long recnum;

		/// <summary>
		/// License Type                    
		/// </summary>
		[ColumnOrder(20)]
		[SMBFieldName("typnme")]
		[SMBFieldDescription("License Type")]
		public string typnme;

	}
}