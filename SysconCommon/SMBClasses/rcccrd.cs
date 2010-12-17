using System;

namespace SMB.Tables {
	public class rcccrd : smbtable {
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Record#")]
		public int recnum;

		[SMBFieldName("issuer")]
		[SMBFieldDescription("Card Issuer Account")]
		public int issuer;

		[SMBFieldName("crdcrd")]
		[SMBFieldDescription("Credit Card")]
		public int crdcrd;

		[SMBFieldName("payee1")]
		[SMBFieldDescription("Payee Name")]
		public string payee1;

		[SMBFieldName("nxtdte")]
		[SMBFieldDescription("Next Date")]
		public DateTime nxtdte;

		[SMBFieldName("lstpst")]
		[SMBFieldDescription("Last Posted")]
		public DateTime lstpst;

		[SMBFieldName("dscrpt")]
		[SMBFieldDescription("Description")]
		public string dscrpt;

		[SMBFieldName("usrdf1")]
		[SMBFieldDescription("User Defined 1")]
		public string usrdf1;

		[SMBFieldName("usrdf2")]
		[SMBFieldDescription("User Defined 2")]
		public string usrdf2;

		[SMBFieldName("actnum")]
		[SMBFieldDescription("Account")]
		public int actnum;

		[SMBFieldName("subact")]
		[SMBFieldDescription("Subaccount")]
		public int subact;

		[SMBFieldName("amount")]
		[SMBFieldDescription("Amount")]
		public decimal amount;

		[SMBFieldName("usrnme")]
		[SMBFieldDescription("User Name")]
		public string usrnme;

		[SMBFieldName("edtdte")]
		[SMBFieldDescription("Edited Date")]
		public DateTime edtdte;

		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

	}
}