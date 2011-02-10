using System;
using SysconCommon.Algebras.DataTables;

namespace SMB.Tables {
	public partial class schtsk : smbtable {
		/// <summary>
		/// Task#                           
		/// </summary>
		[ColumnOrder(10)]
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Task#")]
		public decimal recnum;

		/// <summary>
		/// Description                     
		/// </summary>
		[ColumnOrder(20)]
		[SMBFieldName("tsknme")]
		[SMBFieldDescription("Description")]
		public string tsknme;

		/// <summary>
		/// Task Type                       
		/// </summary>
		[ColumnOrder(30)]
		[SMBFieldName("tsktyp")]
		[SMBFieldDescription("Task Type")]
		public long tsktyp;

		/// <summary>
		/// Notes                           
		/// </summary>
		[ColumnOrder(40)]
		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

	}
}