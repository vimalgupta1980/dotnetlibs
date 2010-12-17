using System;

namespace SMB.Tables {
	public class apivln : smbtable {
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

		[SMBFieldName("actnum")]
		[SMBFieldDescription("Account")]
		public int actnum;

		[SMBFieldName("subact")]
		[SMBFieldDescription("Subaccount")]
		public int subact;

		[SMBFieldName("invloc")]
		[SMBFieldDescription("Location")]
		public int invloc;

		[SMBFieldName("sernum")]
		[SMBFieldDescription("Part Serial#")]
		public string sernum;

		[SMBFieldName("usrdf1")]
		[SMBFieldDescription("User Defined")]
		public string usrdf1;

		[SMBFieldName("linref")]
		[SMBFieldDescription("Subcontract Line Reference #")]
		public string linref;

	}
}