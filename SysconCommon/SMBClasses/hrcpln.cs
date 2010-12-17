using System;

namespace SMB.Tables {
	public class hrcpln : smbtable {
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Job#")]
		public int recnum;

		[SMBFieldName("phsnum")]
		[SMBFieldDescription("Phase")]
		public int phsnum;

		[SMBFieldName("linnum")]
		[SMBFieldDescription("Line#")]
		public int linnum;

		[SMBFieldName("cstcde")]
		[SMBFieldDescription("Cost Code")]
		public decimal cstcde;

		[SMBFieldName("bdghrs")]
		[SMBFieldDescription("Budget Hours")]
		public decimal bdghrs;

		[SMBFieldName("hrsdte")]
		[SMBFieldDescription("Hours to Date")]
		public decimal hrsdte;

		[SMBFieldName("pctcmp")]
		[SMBFieldDescription("% Comp")]
		public decimal pctcmp;

		[SMBFieldName("actcmp")]
		[SMBFieldDescription("% Actual")]
		public decimal actcmp;

		[SMBFieldName("hrscmp")]
		[SMBFieldDescription("Hours to Comp")]
		public decimal hrscmp;

		[SMBFieldName("ovrund")]
		[SMBFieldDescription("Over/(Under)")]
		public decimal ovrund;

		[SMBFieldName("usrdf1")]
		[SMBFieldDescription("User Defined")]
		public string usrdf1;

		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

	}
}