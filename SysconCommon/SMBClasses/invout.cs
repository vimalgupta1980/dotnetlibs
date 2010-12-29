using System;

namespace SMB.Tables {
	public class invout : smbtable {
		/// <summary>
		/// Record#                         
		/// </summary>
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Record#")]
		public long recnum;

		/// <summary>
		/// Part#                           
		/// </summary>
		[SMBFieldName("prtnum")]
		[SMBFieldDescription("Part#")]
		public long prtnum;

		/// <summary>
		/// Quantity                        
		/// </summary>
		[SMBFieldName("trnqty")]
		[SMBFieldDescription("Quantity")]
		public decimal trnqty;

		/// <summary>
		/// Transaction Date                
		/// </summary>
		[SMBFieldName("trndte")]
		[SMBFieldDescription("Transaction Date")]
		public DateTime trndte;

		/// <summary>
		/// Transaction Type                
		/// </summary>
		[SMBFieldName("trntyp")]
		[SMBFieldDescription("Transaction Type")]
		public long trntyp;

		/// <summary>
		/// Source                          
		/// </summary>
		[SMBFieldName("srcnum")]
		[SMBFieldDescription("Source")]
		public long srcnum;

		/// <summary>
		/// Link#                           
		/// </summary>
		[SMBFieldName("lgrref")]
		[SMBFieldDescription("Link#")]
		public long lgrref;

	}
}