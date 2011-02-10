using System;
using SysconCommon.Algebras.DataTables;

namespace SMB.Tables {
	public partial class calnte : smbtable {
		/// <summary>
		/// Date                            
		/// </summary>
		[ColumnOrder(10)]
		[SMBFieldName("caldte")]
		[SMBFieldDescription("Date")]
		public DateTime caldte;

		/// <summary>
		/// Start                           
		/// </summary>
		[ColumnOrder(20)]
		[SMBFieldName("caltim")]
		[SMBFieldDescription("Start")]
		public DateTime caltim;

		/// <summary>
		/// End                             
		/// </summary>
		[ColumnOrder(30)]
		[SMBFieldName("endtim")]
		[SMBFieldDescription("End")]
		public DateTime endtim;

		/// <summary>
		/// Appt. Type                      
		/// </summary>
		[ColumnOrder(40)]
		[SMBFieldName("apttyp")]
		[SMBFieldDescription("Appt. Type")]
		public long apttyp;

		/// <summary>
		/// Employee                        
		/// </summary>
		[ColumnOrder(50)]
		[SMBFieldName("empnum")]
		[SMBFieldDescription("Employee")]
		public long empnum;

		/// <summary>
		/// Client                          
		/// </summary>
		[ColumnOrder(60)]
		[SMBFieldName("clnnum")]
		[SMBFieldDescription("Client")]
		public long clnnum;

		/// <summary>
		/// Notes                           
		/// </summary>
		[ColumnOrder(70)]
		[SMBFieldName("caltxt")]
		[SMBFieldDescription("Notes")]
		public string caltxt;

	}
}