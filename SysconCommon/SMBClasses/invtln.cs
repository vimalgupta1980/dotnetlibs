using System;

namespace SMB.Tables {
	public class invtln : smbtable {
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Record#")]
		public int recnum;

		[SMBFieldName("linnum")]
		[SMBFieldDescription("Line#")]
		public int linnum;

		[SMBFieldName("prtnum")]
		[SMBFieldDescription("Part")]
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

		[SMBFieldName("invqty")]
		[SMBFieldDescription("Quantity")]
		public decimal invqty;

		[SMBFieldName("invcst")]
		[SMBFieldDescription("Cost")]
		public decimal invcst;

		[SMBFieldName("invttl")]
		[SMBFieldDescription("Total")]
		public decimal invttl;

		[SMBFieldName("serial")]
		[SMBFieldDescription("Serial#")]
		public string serial;

		[SMBFieldName("invloc")]
		[SMBFieldDescription("Source")]
		public int invloc;

		[SMBFieldName("dbtact")]
		[SMBFieldDescription("Account")]
		public int dbtact;

		[SMBFieldName("dbtsub")]
		[SMBFieldDescription("Subaccount")]
		public int dbtsub;

		[SMBFieldName("dstloc")]
		[SMBFieldDescription("Destination")]
		public int dstloc;

		[SMBFieldName("usrdf1")]
		[SMBFieldDescription("User Defined")]
		public string usrdf1;

		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

	}
}