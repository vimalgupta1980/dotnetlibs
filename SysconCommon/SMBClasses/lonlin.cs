using System;

namespace SMB.Tables {
	public class lonlin : smbtable {
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Job#")]
		public int recnum;

		[SMBFieldName("linnum")]
		[SMBFieldDescription("Line#")]
		public int linnum;

		[SMBFieldName("cstcde")]
		[SMBFieldDescription("Cost Code")]
		public decimal cstcde;

		[SMBFieldName("cdenme")]
		[SMBFieldDescription("Description")]
		public string cdenme;

		[SMBFieldName("vndnum")]
		[SMBFieldDescription("Vendor")]
		public int vndnum;

		[SMBFieldName("schamt")]
		[SMBFieldDescription("Scheduled")]
		public decimal schamt;

		[SMBFieldName("chgord")]
		[SMBFieldDescription("Changes")]
		public decimal chgord;

		[SMBFieldName("newcon")]
		[SMBFieldDescription("Contract")]
		public decimal newcon;

		[SMBFieldName("prvbll")]
		[SMBFieldDescription("Previous")]
		public decimal prvbll;

		[SMBFieldName("curbll")]
		[SMBFieldDescription("Current")]
		public decimal curbll;

		[SMBFieldName("pctcmp")]
		[SMBFieldDescription("% Comp")]
		public decimal pctcmp;

		[SMBFieldName("ttlcmp")]
		[SMBFieldDescription("Total")]
		public decimal ttlcmp;

		[SMBFieldName("balcon")]
		[SMBFieldDescription("Balance")]
		public decimal balcon;

		[SMBFieldName("usrdf1")]
		[SMBFieldDescription("User Defined")]
		public string usrdf1;

		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

	}
}