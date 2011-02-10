using System;
using SysconCommon.Algebras.DataTables;

namespace SMB.Tables {
	public partial class rcapjb : smbtable {
		/// <summary>
		/// Record#                         
		/// </summary>
		[ColumnOrder(10)]
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Record#")]
		public long recnum;

		/// <summary>
		/// Work Order                      
		/// </summary>
		[ColumnOrder(20)]
		[SMBFieldName("wrkord")]
		[SMBFieldDescription("Work Order")]
		public string wrkord;

		/// <summary>
		/// Job                             
		/// </summary>
		[ColumnOrder(30)]
		[SMBFieldName("jobnum")]
		[SMBFieldDescription("Job")]
		public long jobnum;

		/// <summary>
		/// Description                     
		/// </summary>
		[ColumnOrder(40)]
		[SMBFieldName("dscrpt")]
		[SMBFieldDescription("Description")]
		public string dscrpt;

		/// <summary>
		/// Phase                           
		/// </summary>
		[ColumnOrder(50)]
		[SMBFieldName("phsnum")]
		[SMBFieldDescription("Phase")]
		public long phsnum;

		/// <summary>
		/// Cost Code                       
		/// </summary>
		[ColumnOrder(60)]
		[SMBFieldName("cstcde")]
		[SMBFieldDescription("Cost Code")]
		public decimal cstcde;

		/// <summary>
		/// Cost Type                       
		/// </summary>
		[ColumnOrder(70)]
		[SMBFieldName("csttyp")]
		[SMBFieldDescription("Cost Type")]
		public long csttyp;

		/// <summary>
		/// Cost                            
		/// </summary>
		[ColumnOrder(80)]
		[SMBFieldName("cstamt")]
		[SMBFieldDescription("Cost")]
		public decimal cstamt;

		/// <summary>
		/// Notes                           
		/// </summary>
		[ColumnOrder(90)]
		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

	}
}