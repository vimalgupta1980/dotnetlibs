using System;

namespace SMB.Tables {
	public class aialin : smbtable {
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Record#")]
		public int recnum;

		[SMBFieldName("linnum")]
		[SMBFieldDescription("Line#")]
		public int linnum;

		[SMBFieldName("divnum")]
		[SMBFieldDescription("Division")]
		public int divnum;

		[SMBFieldName("cstcde")]
		[SMBFieldDescription("Cost Code")]
		public decimal cstcde;

		[SMBFieldName("dscrpt")]
		[SMBFieldDescription("Description")]
		public string dscrpt;

		[SMBFieldName("vndnum")]
		[SMBFieldDescription("Vendor")]
		public int vndnum;

		[SMBFieldName("schamt")]
		[SMBFieldDescription("Scheduled")]
		public decimal schamt;

		[SMBFieldName("chgamt")]
		[SMBFieldDescription("Changes")]
		public decimal chgamt;

		[SMBFieldName("newcon")]
		[SMBFieldDescription("Contract")]
		public decimal newcon;

		[SMBFieldName("prvbll")]
		[SMBFieldDescription("Prev. Comp.")]
		public decimal prvbll;

		[SMBFieldName("curbll")]
		[SMBFieldDescription("Current Comp.")]
		public decimal curbll;

		[SMBFieldName("retrte")]
		[SMBFieldDescription("Ret. Rate")]
		public decimal retrte;

		[SMBFieldName("curret")]
		[SMBFieldDescription("Comp. Ret.")]
		public decimal curret;

		[SMBFieldName("prvstr")]
		[SMBFieldDescription("Prev. Stored")]
		public decimal prvstr;

		[SMBFieldName("curstr")]
		[SMBFieldDescription("Current Stored")]
		public decimal curstr;

		[SMBFieldName("strmat")]
		[SMBFieldDescription("Total Stored")]
		public decimal strmat;

		[SMBFieldName("strret")]
		[SMBFieldDescription("Stored Ret.")]
		public decimal strret;

		[SMBFieldName("ttlcmp")]
		[SMBFieldDescription("Total Comp.")]
		public decimal ttlcmp;

		[SMBFieldName("pctcmp")]
		[SMBFieldDescription("% Comp")]
		public decimal pctcmp;

		[SMBFieldName("balfin")]
		[SMBFieldDescription("Balance")]
		public decimal balfin;

		[SMBFieldName("retamt")]
		[SMBFieldDescription("Total Ret.")]
		public decimal retamt;

		[SMBFieldName("usrdf1")]
		[SMBFieldDescription("User Defined")]
		public string usrdf1;

		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

	}
}