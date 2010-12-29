using System;

namespace SMB.Tables {
	public class srvpmt : smbtable {
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
		/// Amount                          
		/// </summary>
		[SMBFieldName("amount")]
		[SMBFieldDescription("Amount")]
		public decimal amount;

		/// <summary>
		/// Discount                        
		/// </summary>
		[SMBFieldName("dsctkn")]
		[SMBFieldDescription("Discount")]
		public decimal dsctkn;

		/// <summary>
		/// Credit                          
		/// </summary>
		[SMBFieldName("aplcrd")]
		[SMBFieldDescription("Credit")]
		public decimal aplcrd;

		/// <summary>
		/// Ledger Ref#                     
		/// </summary>
		[SMBFieldName("lgrrec")]
		[SMBFieldDescription("Ledger Ref#")]
		public long lgrrec;

	}
}