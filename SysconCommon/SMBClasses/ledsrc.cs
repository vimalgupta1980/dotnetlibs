using System;
using SysconCommon.Algebras.DataTables;

namespace SMB.Tables {
	public partial class ledsrc : smbtable {
		/// <summary>
		/// Lead Source#                    
		/// </summary>
		[ColumnOrder(10)]
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Lead Source#")]
		public long recnum;

		/// <summary>
		/// Source Name                     
		/// </summary>
		[ColumnOrder(20)]
		[SMBFieldName("srcnme")]
		[SMBFieldDescription("Source Name")]
		public string srcnme;

	}
}