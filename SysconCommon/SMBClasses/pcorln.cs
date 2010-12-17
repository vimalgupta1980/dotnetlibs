using System;

namespace SMB.Tables {
	public class pcorln : smbtable {
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Record#")]
		public int recnum;

		[SMBFieldName("linnum")]
		[SMBFieldDescription("Line#")]
		public int linnum;

		[SMBFieldName("prtnum")]
		[SMBFieldDescription("Part#")]
		public int prtnum;

		[SMBFieldName("prtdsc")]
		[SMBFieldDescription("Description")]
		public string prtdsc;

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

		[SMBFieldName("extttl")]
		[SMBFieldDescription("Total")]
		public decimal extttl;

		[SMBFieldName("rcvdte")]
		[SMBFieldDescription("To Date")]
		public decimal rcvdte;

		[SMBFieldName("currnt")]
		[SMBFieldDescription("Current")]
		public decimal currnt;

		[SMBFieldName("cancel")]
		[SMBFieldDescription("Canceled")]
		public decimal cancel;

		[SMBFieldName("cstcde")]
		[SMBFieldDescription("Cost Code")]
		public decimal cstcde;

		[SMBFieldName("csttyp")]
		[SMBFieldDescription("Cost Type")]
		public int csttyp;

		[SMBFieldName("invloc")]
		[SMBFieldDescription("Inventory Location")]
		public int invloc;

		[SMBFieldName("lgract")]
		[SMBFieldDescription("Account")]
		public int lgract;

		[SMBFieldName("subact")]
		[SMBFieldDescription("Subaccount")]
		public int subact;

		[SMBFieldName("usrdf1")]
		[SMBFieldDescription("User Defined")]
		public string usrdf1;

		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

	}
}