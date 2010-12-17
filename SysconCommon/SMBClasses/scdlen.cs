using System;

namespace SMB.Tables {
	public class scdlen : smbtable {
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Job#")]
		public int recnum;

		[SMBFieldName("linnum")]
		[SMBFieldDescription("Line#")]
		public int linnum;

		[SMBFieldName("lennum")]
		[SMBFieldDescription("Prelien#")]
		public string lennum;

		[SMBFieldName("vndnum")]
		[SMBFieldDescription("Vendor")]
		public int vndnum;

		[SMBFieldName("scdvnd")]
		[SMBFieldDescription("Second Vendor")]
		public int scdvnd;

		[SMBFieldName("dtercd")]
		[SMBFieldDescription("Date Rcvd")]
		public DateTime dtercd;

		[SMBFieldName("fstdte")]
		[SMBFieldDescription("First Date")]
		public DateTime fstdte;

		[SMBFieldName("lstdte")]
		[SMBFieldDescription("Last Date")]
		public DateTime lstdte;

		[SMBFieldName("findte")]
		[SMBFieldDescription("Final Date")]
		public DateTime findte;

		[SMBFieldName("usrdf1")]
		[SMBFieldDescription("User Defined")]
		public string usrdf1;

		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

	}
}