using System;
using SysconCommon.Algebras.DataTables;

namespace SMB.Tables {
	public partial class vndcrt : smbtable {
		/// <summary>
		/// Vendor#                         
		/// </summary>
		[ColumnOrder(10)]
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Vendor#")]
		public long recnum;

		/// <summary>
		/// Line#                           
		/// </summary>
		[ColumnOrder(20)]
		[SMBFieldName("linnum")]
		[SMBFieldDescription("Line#")]
		public long linnum;

		/// <summary>
		/// Description                     
		/// </summary>
		[ColumnOrder(30)]
		[SMBFieldName("dscrpt")]
		[SMBFieldDescription("Description")]
		public string dscrpt;

		/// <summary>
		/// Received                        
		/// </summary>
		[ColumnOrder(40)]
		[SMBFieldName("dtercv")]
		[SMBFieldDescription("Received")]
		public DateTime dtercv;

		/// <summary>
		/// Expires                         
		/// </summary>
		[ColumnOrder(50)]
		[SMBFieldName("expdte")]
		[SMBFieldDescription("Expires")]
		public DateTime expdte;

		/// <summary>
		/// Notes                           
		/// </summary>
		[ColumnOrder(60)]
		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

	}
}