using System;

namespace SMB.Tables {
	public class rcarln : smbtable {
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Record#")]
		public int recnum;

		[SMBFieldName("linnum")]
		[SMBFieldDescription("Line#")]
		public int linnum;

		[SMBFieldName("prtnum")]
		[SMBFieldDescription("Part#")]
		public int prtnum;

		[SMBFieldName("dscrpt")]
		[SMBFieldDescription("Description")]
		public string dscrpt;

		[SMBFieldName("alpnum")]
		[SMBFieldDescription("Alpha Part#")]
		public string alpnum;

		[SMBFieldName("untdsc")]
		[SMBFieldDescription("Unit")]
		public string untdsc;

		[SMBFieldName("linqty")]
		[SMBFieldDescription("Quantity")]
		public decimal linqty;

		[SMBFieldName("linprc")]
		[SMBFieldDescription("Price")]
		public decimal linprc;

		[SMBFieldName("extprc")]
		[SMBFieldDescription("Total")]
		public decimal extprc;

		[SMBFieldName("lgract")]
		[SMBFieldDescription("Account")]
		public int lgract;

		[SMBFieldName("subact")]
		[SMBFieldDescription("Subaccount")]
		public int subact;

		[SMBFieldName("cstcde")]
		[SMBFieldDescription("Cost Code")]
		public decimal cstcde;

		[SMBFieldName("usrdf1")]
		[SMBFieldDescription("User Defined")]
		public string usrdf1;

		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

	}
}