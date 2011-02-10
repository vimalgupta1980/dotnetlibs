using System;
using SysconCommon.Algebras.DataTables;

namespace SMB.Tables {
	public partial class jobphs : smbtable {
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
		/// Description                     
		/// </summary>
		[ColumnOrder(30)]
		[SMBFieldName("phsnme")]
		[SMBFieldDescription("Description")]
		public string phsnme;

		/// <summary>
		/// Billing Amount                  
		/// </summary>
		[ColumnOrder(40)]
		[SMBFieldName("bllamt")]
		[SMBFieldDescription("Billing Amount")]
		public decimal bllamt;

		/// <summary>
		/// Retention                       
		/// </summary>
		[ColumnOrder(50)]
		[SMBFieldName("retain")]
		[SMBFieldDescription("Retention")]
		public decimal retain;

		/// <summary>
		/// Model                           
		/// </summary>
		[ColumnOrder(60)]
		[SMBFieldName("mdldsc")]
		[SMBFieldDescription("Model")]
		public string mdldsc;

		/// <summary>
		/// Unit                            
		/// </summary>
		[ColumnOrder(70)]
		[SMBFieldName("untdsc")]
		[SMBFieldDescription("Unit")]
		public string untdsc;

		/// <summary>
		/// Quantity                        
		/// </summary>
		[ColumnOrder(80)]
		[SMBFieldName("untqty")]
		[SMBFieldDescription("Quantity")]
		public decimal untqty;

		/// <summary>
		/// Notes                           
		/// </summary>
		[ColumnOrder(90)]
		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

	}
}