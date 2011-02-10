using System;
using SysconCommon.Algebras.DataTables;

namespace SMB.Tables {
	public partial class dsptch : smbtable {
		/// <summary>
		/// Column#                         
		/// </summary>
		[ColumnOrder(10)]
		[SMBFieldName("column")]
		[SMBFieldDescription("Column#")]
		public long column;

		/// <summary>
		/// Employee                        
		/// </summary>
		[ColumnOrder(20)]
		[SMBFieldName("empnum")]
		[SMBFieldDescription("Employee")]
		public long empnum;

		/// <summary>
		/// Display As                      
		/// </summary>
		[ColumnOrder(30)]
		[SMBFieldName("disply")]
		[SMBFieldDescription("Display As")]
		public string disply;

	}
}