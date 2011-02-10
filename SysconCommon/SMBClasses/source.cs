using System;
using SysconCommon.Algebras.DataTables;

namespace SMB.Tables {
	public partial class source : smbtable {
		/// <summary>
		/// Source                          
		/// </summary>
		[ColumnOrder(10)]
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Source")]
		public long recnum;

		/// <summary>
		/// Name                            
		/// </summary>
		[ColumnOrder(20)]
		[SMBFieldName("srcnme")]
		[SMBFieldDescription("Name")]
		public string srcnme;

		/// <summary>
		/// Description                     
		/// </summary>
		[ColumnOrder(30)]
		[SMBFieldName("srcdsc")]
		[SMBFieldDescription("Description")]
		public string srcdsc;

	}
}