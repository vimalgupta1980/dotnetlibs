using System;

namespace SMB.Tables {
	public class crcard : smbtable {
		/// <summary>
		/// Credit Card Issuer              
		/// </summary>
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Credit Card Issuer")]
		public long recnum;

		/// <summary>
		/// Payee                           
		/// </summary>
		[SMBFieldName("payee1")]
		[SMBFieldDescription("Payee")]
		public string payee1;

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

	}
}