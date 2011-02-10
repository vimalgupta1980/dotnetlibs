using System;
using SysconCommon.Algebras.DataTables;

namespace SMB.Tables {
	public partial class srvgeo : smbtable {
		/// <summary>
		/// Area#                           
		/// </summary>
		[ColumnOrder(10)]
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Area#")]
		public long recnum;

		/// <summary>
		/// Description                     
		/// </summary>
		[ColumnOrder(20)]
		[SMBFieldName("dscrpt")]
		[SMBFieldDescription("Description")]
		public string dscrpt;

		/// <summary>
		/// Dispatch Color                  
		/// </summary>
		[ColumnOrder(30)]
		[SMBFieldName("geoclr")]
		[SMBFieldDescription("Dispatch Color")]
		public string geoclr;

	}
}