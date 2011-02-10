using System;
using SysconCommon.Algebras.DataTables;

namespace SMB.Tables {
	public partial class vndtyp : smbtable {
		/// <summary>
		/// Vendor Type#                    
		/// </summary>
		[ColumnOrder(10)]
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Vendor Type#")]
		public long recnum;

		/// <summary>
		/// Type Name                       
		/// </summary>
		[ColumnOrder(20)]
		[SMBFieldName("typnme")]
		[SMBFieldDescription("Type Name")]
		public string typnme;

		/// <summary>
		/// Notes                           
		/// </summary>
		[ColumnOrder(30)]
		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

	}
}