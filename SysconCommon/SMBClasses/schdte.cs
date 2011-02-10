using System;
using SysconCommon.Algebras.DataTables;

namespace SMB.Tables {
	public partial class schdte : smbtable {
		/// <summary>
		/// Job#                            
		/// </summary>
		[ColumnOrder(10)]
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Job#")]
		public long recnum;

		/// <summary>
		/// Phase#                          
		/// </summary>
		[ColumnOrder(20)]
		[SMBFieldName("phsnum")]
		[SMBFieldDescription("Phase#")]
		public long phsnum;

		/// <summary>
		/// Task#                           
		/// </summary>
		[ColumnOrder(30)]
		[SMBFieldName("tsknum")]
		[SMBFieldDescription("Task#")]
		public decimal tsknum;

		/// <summary>
		/// Date                            
		/// </summary>
		[ColumnOrder(40)]
		[SMBFieldName("schdte")]
		[SMBFieldDescription("Date")]
		public DateTime _schdte;

	}
}