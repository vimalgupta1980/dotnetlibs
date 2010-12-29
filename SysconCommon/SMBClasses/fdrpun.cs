using System;

namespace SMB.Tables {
	public class fdrpun : smbtable {
		/// <summary>
		/// Record#                         
		/// </summary>
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Record#")]
		public long recnum;

		/// <summary>
		/// Line#                           
		/// </summary>
		[SMBFieldName("linnum")]
		[SMBFieldDescription("Line#")]
		public long linnum;

		/// <summary>
		/// Bid Item                        
		/// </summary>
		[SMBFieldName("itmnum")]
		[SMBFieldDescription("Bid Item")]
		public long itmnum;

		/// <summary>
		/// Item Code                       
		/// </summary>
		[SMBFieldName("itmcde")]
		[SMBFieldDescription("Item Code")]
		public string itmcde;

		/// <summary>
		/// Unit                            
		/// </summary>
		[SMBFieldName("untdsc")]
		[SMBFieldDescription("Unit")]
		public string untdsc;

		/// <summary>
		/// Completed Today                 
		/// </summary>
		[SMBFieldName("cmptdy")]
		[SMBFieldDescription("Completed Today")]
		public decimal cmptdy;

	}
}