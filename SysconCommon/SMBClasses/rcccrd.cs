using System;

namespace SMB.Tables {
	public class rcccrd : smbtable {
		/// <summary>
		/// Record#                         
		/// </summary>
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Record#")]
		public long recnum;

		/// <summary>
		/// Card Issuer Account             
		/// </summary>
		[SMBFieldName("issuer")]
		[SMBFieldDescription("Card Issuer Account")]
		public long issuer;

		/// <summary>
		/// Credit Card                     
		/// </summary>
		[SMBFieldName("crdcrd")]
		[SMBFieldDescription("Credit Card")]
		public long crdcrd;

		/// <summary>
		/// Payee Name                      
		/// </summary>
		[SMBFieldName("payee1")]
		[SMBFieldDescription("Payee Name")]
		public string payee1;

		/// <summary>
		/// Next Date                       
		/// </summary>
		[SMBFieldName("nxtdte")]
		[SMBFieldDescription("Next Date")]
		public DateTime nxtdte;

		/// <summary>
		/// Last Posted                     
		/// </summary>
		[SMBFieldName("lstpst")]
		[SMBFieldDescription("Last Posted")]
		public DateTime lstpst;

		/// <summary>
		/// Description                     
		/// </summary>
		[SMBFieldName("dscrpt")]
		[SMBFieldDescription("Description")]
		public string dscrpt;

		/// <summary>
		/// User Defined 1                  
		/// </summary>
		[SMBFieldName("usrdf1")]
		[SMBFieldDescription("User Defined 1")]
		public string usrdf1;

		/// <summary>
		/// User Defined 2                  
		/// </summary>
		[SMBFieldName("usrdf2")]
		[SMBFieldDescription("User Defined 2")]
		public string usrdf2;

		/// <summary>
		/// Account                         
		/// </summary>
		[SMBFieldName("actnum")]
		[SMBFieldDescription("Account")]
		public long actnum;

		/// <summary>
		/// Subaccount                      
		/// </summary>
		[SMBFieldName("subact")]
		[SMBFieldDescription("Subaccount")]
		public long subact;

		/// <summary>
		/// Amount                          
		/// </summary>
		[SMBFieldName("amount")]
		[SMBFieldDescription("Amount")]
		public decimal amount;

		/// <summary>
		/// User Name                       
		/// </summary>
		[SMBFieldName("usrnme")]
		[SMBFieldDescription("User Name")]
		public string usrnme;

		/// <summary>
		/// Edited Date                     
		/// </summary>
		[SMBFieldName("edtdte")]
		[SMBFieldDescription("Edited Date")]
		public DateTime edtdte;

		/// <summary>
		/// Notes                           
		/// </summary>
		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

	}
}