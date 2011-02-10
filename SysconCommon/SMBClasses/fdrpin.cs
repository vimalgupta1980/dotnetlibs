using System;
using SysconCommon.Algebras.DataTables;

namespace SMB.Tables {
	public partial class fdrpin : smbtable {
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
		/// Incident Type                   
		/// </summary>
		[ColumnOrder(30)]
		[SMBFieldName("inctyp")]
		[SMBFieldDescription("Incident Type")]
		public long inctyp;

		/// <summary>
		/// Description                     
		/// </summary>
		[ColumnOrder(40)]
		[SMBFieldName("dscrpt")]
		[SMBFieldDescription("Description")]
		public string dscrpt;

		/// <summary>
		/// Time                            
		/// </summary>
		[ColumnOrder(50)]
		[SMBFieldName("inctim")]
		[SMBFieldDescription("Time")]
		public DateTime inctim;

		/// <summary>
		/// Notes                           
		/// </summary>
		[ColumnOrder(60)]
		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

	}
}