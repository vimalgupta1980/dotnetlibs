using System;

namespace SMB.Tables {
	public class srtxdt : smbtable {
		/// <summary>
		/// Record#                         
		/// </summary>
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Record#")]
		public long recnum;

		/// <summary>
		/// Tax Entity                      
		/// </summary>
		[SMBFieldName("taxent")]
		[SMBFieldDescription("Tax Entity")]
		public long taxent;

		/// <summary>
		/// Subject to Tax                  
		/// </summary>
		[SMBFieldName("sbjtax")]
		[SMBFieldDescription("Subject to Tax")]
		public decimal sbjtax;

		/// <summary>
		/// Tax Rate                        
		/// </summary>
		[SMBFieldName("taxrte")]
		[SMBFieldDescription("Tax Rate")]
		public decimal taxrte;

		/// <summary>
		/// Tax Amount                      
		/// </summary>
		[SMBFieldName("taxamt")]
		[SMBFieldDescription("Tax Amount")]
		public decimal taxamt;

	}
}