using System;
using SysconCommon.Algebras.DataTables;

namespace SMB.Tables {
	public partial class referl : smbtable {
		/// <summary>
		/// Client                          
		/// </summary>
		[ColumnOrder(10)]
		[SMBFieldName("clnnum")]
		[SMBFieldDescription("Client")]
		public long clnnum;

		/// <summary>
		/// Referred                        
		/// </summary>
		[ColumnOrder(20)]
		[SMBFieldName("referd")]
		[SMBFieldDescription("Referred")]
		public long referd;

		/// <summary>
		/// Date                            
		/// </summary>
		[ColumnOrder(30)]
		[SMBFieldName("refdte")]
		[SMBFieldDescription("Date")]
		public DateTime refdte;

		/// <summary>
		/// Notes                           
		/// </summary>
		[ColumnOrder(40)]
		[SMBFieldName("refnte")]
		[SMBFieldDescription("Notes")]
		public string refnte;

	}
}