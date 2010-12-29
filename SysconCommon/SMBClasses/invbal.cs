using System;

namespace SMB.Tables {
	public class invbal : smbtable {
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
		/// Quantity Remaining              
		/// </summary>
		[SMBFieldName("qtyrmn")]
		[SMBFieldDescription("Quantity Remaining")]
		public decimal qtyrmn;

		/// <summary>
		/// Transaction Date                
		/// </summary>
		[SMBFieldName("trndte")]
		[SMBFieldDescription("Transaction Date")]
		public DateTime trndte;

		/// <summary>
		/// Transaction Time                
		/// </summary>
		[SMBFieldName("trntme")]
		[SMBFieldDescription("Transaction Time")]
		public long trntme;

		/// <summary>
		/// Part Price                      
		/// </summary>
		[SMBFieldName("prtprc")]
		[SMBFieldDescription("Part Price")]
		public decimal prtprc;

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