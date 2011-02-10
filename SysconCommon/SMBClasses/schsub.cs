using System;
using SysconCommon.Algebras.DataTables;

namespace SMB.Tables {
	public partial class schsub : smbtable {
		/// <summary>
		/// Job#                            
		/// </summary>
		[ColumnOrder(10)]
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Job#")]
		public long recnum;

		/// <summary>
		/// Phase#                          
		/// </summary>
		[ColumnOrder(20)]
		[SMBFieldName("phsnum")]
		[SMBFieldDescription("Phase#")]
		public long phsnum;

		/// <summary>
		/// Task#                           
		/// </summary>
		[ColumnOrder(30)]
		[SMBFieldName("tsknum")]
		[SMBFieldDescription("Task#")]
		public decimal tsknum;

		/// <summary>
		/// Subcontractor                   
		/// </summary>
		[ColumnOrder(40)]
		[SMBFieldName("subnum")]
		[SMBFieldDescription("Subcontractor")]
		public long subnum;

		/// <summary>
		/// Start Time                      
		/// </summary>
		[ColumnOrder(50)]
		[SMBFieldName("strtme")]
		[SMBFieldDescription("Start Time")]
		public DateTime strtme;

		/// <summary>
		/// End Time                        
		/// </summary>
		[ColumnOrder(60)]
		[SMBFieldName("endtme")]
		[SMBFieldDescription("End Time")]
		public DateTime endtme;

		/// <summary>
		/// Notes                           
		/// </summary>
		[ColumnOrder(70)]
		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

	}
}