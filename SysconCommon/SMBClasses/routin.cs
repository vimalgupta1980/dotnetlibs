using System;

namespace SMB.Tables {
	public class routin : smbtable {
		[SMBFieldName("rourec")]
		[SMBFieldDescription("Record#")]
		public int rourec;

		[SMBFieldName("linnum")]
		[SMBFieldDescription("Line#")]
		public int linnum;

		[SMBFieldName("routbl")]
		[SMBFieldDescription("Routing Table")]
		public string routbl;

		[SMBFieldName("routto")]
		[SMBFieldDescription("Routed To")]
		public string routto;

		[SMBFieldName("dscrpt")]
		[SMBFieldDescription("Description")]
		public string dscrpt;

		[SMBFieldName("sentdt")]
		[SMBFieldDescription("Date Sent")]
		public DateTime sentdt;

		[SMBFieldName("needdt")]
		[SMBFieldDescription("Date Needed by")]
		public DateTime needdt;

		[SMBFieldName("retdte")]
		[SMBFieldDescription("Date Returned")]
		public DateTime retdte;

		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

	}
}