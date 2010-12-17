using System;

namespace SMB.Tables {
	public class cscpln : smbtable {
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

		[SMBFieldName("bdgttl")]
		[SMBFieldDescription("Budget")]
		public decimal bdgttl;

		[SMBFieldName("cstdte")]
		[SMBFieldDescription("Cost to Date")]
		public decimal cstdte;

		[SMBFieldName("pctcst")]
		[SMBFieldDescription("% Comp")]
		public decimal pctcst;

		[SMBFieldName("actcmp")]
		[SMBFieldDescription("% Actual")]
		public decimal actcmp;

		[SMBFieldName("cstcmp")]
		[SMBFieldDescription("Cost to Comp")]
		public decimal cstcmp;

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