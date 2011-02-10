using System;
using SysconCommon.Algebras.DataTables;

namespace SMB.Tables {
	public partial class schprd : smbtable {
		/// <summary>
		/// Record#                         
		/// </summary>
		[ColumnOrder(10)]
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Record#")]
		public long recnum;

		/// <summary>
		/// Phase Record                    
		/// </summary>
		[ColumnOrder(20)]
		[SMBFieldName("recphs")]
		[SMBFieldDescription("Phase Record")]
		public long recphs;

		/// <summary>
		/// Task#                           
		/// </summary>
		[ColumnOrder(30)]
		[SMBFieldName("tsknum")]
		[SMBFieldDescription("Task#")]
		public decimal tsknum;

		/// <summary>
		/// Job                             
		/// </summary>
		[ColumnOrder(40)]
		[SMBFieldName("jobnum")]
		[SMBFieldDescription("Job")]
		public long jobnum;

		/// <summary>
		/// Phase                           
		/// </summary>
		[ColumnOrder(50)]
		[SMBFieldName("phsnum")]
		[SMBFieldDescription("Phase")]
		public long phsnum;

		/// <summary>
		/// Predecessor                     
		/// </summary>
		[ColumnOrder(60)]
		[SMBFieldName("prdnum")]
		[SMBFieldDescription("Predecessor")]
		public decimal prdnum;

		/// <summary>
		/// Relation                        
		/// </summary>
		[ColumnOrder(70)]
		[SMBFieldName("reltyp")]
		[SMBFieldDescription("Relation")]
		public long reltyp;

		/// <summary>
		/// Lead/Lag                        
		/// </summary>
		[ColumnOrder(80)]
		[SMBFieldName("ledlag")]
		[SMBFieldDescription("Lead/Lag")]
		public long ledlag;

		/// <summary>
		/// Notes                           
		/// </summary>
		[ColumnOrder(90)]
		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

	}
}