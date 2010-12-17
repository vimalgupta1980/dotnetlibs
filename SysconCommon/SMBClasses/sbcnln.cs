using System;

namespace SMB.Tables {
	public class sbcnln : smbtable {
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Record#")]
		public int recnum;

		[SMBFieldName("linnum")]
		[SMBFieldDescription("Line#")]
		public int linnum;

		[SMBFieldName("dscrpt")]
		[SMBFieldDescription("Description")]
		public string dscrpt;

		[SMBFieldName("cstcde")]
		[SMBFieldDescription("Cost Code")]
		public decimal cstcde;

		[SMBFieldName("csttyp")]
		[SMBFieldDescription("Cost Type")]
		public int csttyp;

		[SMBFieldName("amount")]
		[SMBFieldDescription("Original Contract")]
		public decimal amount;

		[SMBFieldName("change")]
		[SMBFieldDescription("Changes")]
		public decimal change;

		[SMBFieldName("cntrct")]
		[SMBFieldDescription("New Contract")]
		public decimal cntrct;

		[SMBFieldName("billed")]
		[SMBFieldDescription("Invoiced")]
		public decimal billed;

		[SMBFieldName("remain")]
		[SMBFieldDescription("Remaining")]
		public decimal remain;

		[SMBFieldName("usrdf1")]
		[SMBFieldDescription("User Defined")]
		public string usrdf1;

		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

		[SMBFieldName("linref")]
		[SMBFieldDescription("Subcontract Line Reference #")]
		public string linref;

	}
}