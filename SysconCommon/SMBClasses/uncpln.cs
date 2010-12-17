using System;

namespace SMB.Tables {
	public class uncpln : smbtable {
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

		[SMBFieldName("bdgcst")]
		[SMBFieldDescription("Budget Cost")]
		public decimal bdgcst;

		[SMBFieldName("bdgunt")]
		[SMBFieldDescription("Budget Units")]
		public decimal bdgunt;

		[SMBFieldName("cstdte")]
		[SMBFieldDescription("Cost to Date")]
		public decimal cstdte;

		[SMBFieldName("untcmp")]
		[SMBFieldDescription("Units Comp")]
		public decimal untcmp;

		[SMBFieldName("bdgprc")]
		[SMBFieldDescription("Bdg. $/Unit")]
		public decimal bdgprc;

		[SMBFieldName("actprc")]
		[SMBFieldDescription("Act. $/Unit")]
		public decimal actprc;

		[SMBFieldName("ovrund")]
		[SMBFieldDescription("O/(U) /Unit")]
		public decimal ovrund;

		[SMBFieldName("untrem")]
		[SMBFieldDescription("Units Remain")]
		public decimal untrem;

		[SMBFieldName("cstcmp")]
		[SMBFieldDescription("Cost to Comp")]
		public decimal cstcmp;

		[SMBFieldName("ovrttl")]
		[SMBFieldDescription("Over/(Under)")]
		public decimal ovrttl;

		[SMBFieldName("usrdf1")]
		[SMBFieldDescription("User Defined")]
		public string usrdf1;

		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

	}
}