using System;
using SysconCommon.Algebras.DataTables;

namespace SMB.Tables {
	public partial class apttyp : smbtable {
		/// <summary>
		/// Appointment#                    
		/// </summary>
		[ColumnOrder(10)]
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Appointment#")]
		public long recnum;

		/// <summary>
		/// Description                     
		/// </summary>
		[ColumnOrder(20)]
		[SMBFieldName("dscrpt")]
		[SMBFieldDescription("Description")]
		public string dscrpt;

	}
}