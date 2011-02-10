using System;
using SysconCommon.Algebras.DataTables;

namespace SMB.Tables {
	public partial class grplst : smbtable {
		/// <summary>
		/// Group#                          
		/// </summary>
		[ColumnOrder(10)]
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Group#")]
		public long recnum;

		/// <summary>
		/// Group Name                      
		/// </summary>
		[ColumnOrder(20)]
		[SMBFieldName("grpnme")]
		[SMBFieldDescription("Group Name")]
		public string grpnme;

		/// <summary>
		/// Notes                           
		/// </summary>
		[ColumnOrder(30)]
		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

	}
}