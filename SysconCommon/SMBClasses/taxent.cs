using System;

namespace SMB.Tables {
	public class taxent : smbtable {
		/// <summary>
		/// Tax Entity#                     
		/// </summary>
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Tax Entity#")]
		public long recnum;

		/// <summary>
		/// Entity Name                     
		/// </summary>
		[SMBFieldName("entnme")]
		[SMBFieldDescription("Entity Name")]
		public string entnme;

		/// <summary>
		/// Remit To                        
		/// </summary>
		[SMBFieldName("paynme")]
		[SMBFieldDescription("Remit To")]
		public string paynme;

		/// <summary>
		/// Address 1                       
		/// </summary>
		[SMBFieldName("addrs1")]
		[SMBFieldDescription("Address 1")]
		public string addrs1;

		/// <summary>
		/// Address 2                       
		/// </summary>
		[SMBFieldName("addrs2")]
		[SMBFieldDescription("Address 2")]
		public string addrs2;

		/// <summary>
		/// City                            
		/// </summary>
		[SMBFieldName("ctynme")]
		[SMBFieldDescription("City")]
		public string ctynme;

		/// <summary>
		/// State                           
		/// </summary>
		[SMBFieldName("state_")]
		[SMBFieldDescription("State")]
		public string state_;

		/// <summary>
		/// Zip                             
		/// </summary>
		[SMBFieldName("zipcde")]
		[SMBFieldDescription("Zip")]
		public string zipcde;

		/// <summary>
		/// Tax Rate                        
		/// </summary>
		[SMBFieldName("taxrt1")]
		[SMBFieldDescription("Tax Rate")]
		public decimal taxrt1;

		/// <summary>
		/// Billing Limit                   
		/// </summary>
		[SMBFieldName("limit1")]
		[SMBFieldDescription("Billing Limit")]
		public decimal limit1;

		/// <summary>
		/// Limit Type                      
		/// </summary>
		[SMBFieldName("lmtyp1")]
		[SMBFieldDescription("Limit Type")]
		public long lmtyp1;

		/// <summary>
		/// Notes                           
		/// </summary>
		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

	}
}