using System;

namespace SMB.Tables {
	public class plnrcv : smbtable {
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Record#")]
		public int recnum;

		[SMBFieldName("linnum")]
		[SMBFieldDescription("Line#")]
		public int linnum;

		[SMBFieldName("vendor")]
		[SMBFieldDescription("Subcontractor")]
		public int vendor;

		[SMBFieldName("contct")]
		[SMBFieldDescription("Contact")]
		public string contct;

		[SMBFieldName("numcpy")]
		[SMBFieldDescription("Copies")]
		public int numcpy;

		[SMBFieldName("dtegiv")]
		[SMBFieldDescription("Date Sent")]
		public DateTime dtegiv;

		[SMBFieldName("depamt")]
		[SMBFieldDescription("Deposit")]
		public decimal depamt;

		[SMBFieldName("dtertn")]
		[SMBFieldDescription("Date Returned")]
		public DateTime dtertn;

		[SMBFieldName("usrdf1")]
		[SMBFieldDescription("User Defined")]
		public string usrdf1;

		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

	}
}