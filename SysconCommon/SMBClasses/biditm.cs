using System;

namespace SMB.Tables {
	public class biditm : smbtable {
		/// <summary>
		/// Job#                            
		/// </summary>
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Job#")]
		public long recnum;

		/// <summary>
		/// Item#                           
		/// </summary>
		[SMBFieldName("itmnum")]
		[SMBFieldDescription("Item#")]
		public long itmnum;

		/// <summary>
		/// Item Code                       
		/// </summary>
		[SMBFieldName("itmcde")]
		[SMBFieldDescription("Item Code")]
		public string itmcde;

		/// <summary>
		/// Description                     
		/// </summary>
		[SMBFieldName("itmnme")]
		[SMBFieldDescription("Description")]
		public string itmnme;

		/// <summary>
		/// Unit                            
		/// </summary>
		[SMBFieldName("untdsc")]
		[SMBFieldDescription("Unit")]
		public string untdsc;

		/// <summary>
		/// Quantity                        
		/// </summary>
		[SMBFieldName("bidqty")]
		[SMBFieldDescription("Quantity")]
		public decimal bidqty;

		/// <summary>
		/// Item Type                       
		/// </summary>
		[SMBFieldName("itmtyp")]
		[SMBFieldDescription("Item Type")]
		public long itmtyp;

		/// <summary>
		/// Overhead                        
		/// </summary>
		[SMBFieldName("ovrhed")]
		[SMBFieldDescription("Overhead")]
		public decimal ovrhed;

		/// <summary>
		/// Profit                          
		/// </summary>
		[SMBFieldName("profit")]
		[SMBFieldDescription("Profit")]
		public decimal profit;

		/// <summary>
		/// Notes                           
		/// </summary>
		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

	}
}