using System;

namespace SMB.Tables {
	public class acppmt : smbtable {
		/// <summary>
		/// Record#                         
		/// </summary>
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Record#")]
		public long recnum;

		/// <summary>
		/// Description                     
		/// </summary>
		[SMBFieldName("dscrpt")]
		[SMBFieldDescription("Description")]
		public string dscrpt;

		/// <summary>
		/// Trans#                          
		/// </summary>
		[SMBFieldName("chknum")]
		[SMBFieldDescription("Trans#")]
		public string chknum;

		/// <summary>
		/// Date                            
		/// </summary>
		[SMBFieldName("chkdte")]
		[SMBFieldDescription("Date")]
		public DateTime chkdte;

		/// <summary>
		/// Period                          
		/// </summary>
		[SMBFieldName("actper")]
		[SMBFieldDescription("Period")]
		public long actper;

		/// <summary>
		/// Amount Paid                     
		/// </summary>
		[SMBFieldName("amount")]
		[SMBFieldDescription("Amount Paid")]
		public decimal amount;

		/// <summary>
		/// Discount Taken                  
		/// </summary>
		[SMBFieldName("dsctkn")]
		[SMBFieldDescription("Discount Taken")]
		public decimal dsctkn;

		/// <summary>
		/// Credit Taken                    
		/// </summary>
		[SMBFieldName("aplcrd")]
		[SMBFieldDescription("Credit Taken")]
		public decimal aplcrd;

		/// <summary>
		/// Ledger Ref#                     
		/// </summary>
		[SMBFieldName("lgrrec")]
		[SMBFieldDescription("Ledger Ref#")]
		public long lgrrec;

	}
}