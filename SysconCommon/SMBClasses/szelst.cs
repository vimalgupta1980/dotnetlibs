using System;
using SysconCommon.Algebras.DataTables;

namespace SMB.Tables {
	public partial class szelst : smbtable {
		/// <summary>
		/// Client Size#                    
		/// </summary>
		[ColumnOrder(10)]
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Client Size#")]
		public long recnum;

		/// <summary>
		/// Size Description                
		/// </summary>
		[ColumnOrder(20)]
		[SMBFieldName("dscrpt")]
		[SMBFieldDescription("Size Description")]
		public string dscrpt;

	}
}