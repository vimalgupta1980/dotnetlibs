using System;
using SysconCommon.Algebras.DataTables;

namespace SMB.Tables {
	public partial class tsktyp : smbtable {
		/// <summary>
		/// Task Type #                     
		/// </summary>
		[ColumnOrder(10)]
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Task Type #")]
		public long recnum;

		/// <summary>
		/// Description                     
		/// </summary>
		[ColumnOrder(20)]
		[SMBFieldName("tsknme")]
		[SMBFieldDescription("Description")]
		public string tsknme;

		/// <summary>
		/// Task Color                      
		/// </summary>
		[ColumnOrder(30)]
		[SMBFieldName("tskclr")]
		[SMBFieldDescription("Task Color")]
		public string tskclr;

	}
}