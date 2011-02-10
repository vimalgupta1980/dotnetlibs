using System;
using SysconCommon.Algebras.DataTables;

namespace SMB.Tables {
	public partial class srcnlc : smbtable {
		/// <summary>
		/// Record#                         
		/// </summary>
		[ColumnOrder(10)]
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Record#")]
		public long recnum;

		/// <summary>
		/// Line#                           
		/// </summary>
		[ColumnOrder(20)]
		[SMBFieldName("linnum")]
		[SMBFieldDescription("Line#")]
		public long linnum;

		/// <summary>
		/// Location                        
		/// </summary>
		[ColumnOrder(30)]
		[SMBFieldName("locnum")]
		[SMBFieldDescription("Location")]
		public long locnum;

	}
}