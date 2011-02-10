using System;
using SysconCommon.Algebras.DataTables;

namespace SMB.Tables {
	public partial class dptmnt : smbtable {
		/// <summary>
		/// Department#                     
		/// </summary>
		[ColumnOrder(10)]
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Department#")]
		public long recnum;

		/// <summary>
		/// Department Name                 
		/// </summary>
		[ColumnOrder(20)]
		[SMBFieldName("dptnme")]
		[SMBFieldDescription("Department Name")]
		public string dptnme;

		/// <summary>
		/// Notes                           
		/// </summary>
		[ColumnOrder(30)]
		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

	}
}