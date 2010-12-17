using System;

namespace SMB.Tables {
	public class sbcgln : smbtable {
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Record#")]
		public int recnum;

		[SMBFieldName("linnum")]
		[SMBFieldDescription("Line#")]
		public int linnum;

		[SMBFieldName("dscrpt")]
		[SMBFieldDescription("Description")]
		public string dscrpt;

		[SMBFieldName("chghrs")]
		[SMBFieldDescription("Budget Hours")]
		public decimal chghrs;

		[SMBFieldName("chgunt")]
		[SMBFieldDescription("Budget Units")]
		public decimal chgunt;

		[SMBFieldName("bdgprc")]
		[SMBFieldDescription("Budget Amount")]
		public decimal bdgprc;

		[SMBFieldName("vndnum")]
		[SMBFieldDescription("Vendor")]
		public int vndnum;

		[SMBFieldName("vndctc")]
		[SMBFieldDescription("Subcontract")]
		public int vndctc;

		[SMBFieldName("ctclin")]
		[SMBFieldDescription("Subcontract Line")]
		public int ctclin;

		[SMBFieldName("chgnum")]
		[SMBFieldDescription("Change#")]
		public string chgnum;

		[SMBFieldName("chgsts")]
		[SMBFieldDescription("Status")]
		public int chgsts;

		[SMBFieldName("chgdte")]
		[SMBFieldDescription("Date")]
		public DateTime chgdte;

		[SMBFieldName("cstcde")]
		[SMBFieldDescription("Cost Code")]
		public decimal cstcde;

		[SMBFieldName("csttyp")]
		[SMBFieldDescription("Cost Type")]
		public int csttyp;

		[SMBFieldName("usrdf1")]
		[SMBFieldDescription("User Defined")]
		public string usrdf1;

		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Change Order Notes")]
		public string ntetxt;

		[SMBFieldName("linref")]
		[SMBFieldDescription("Subcontract Line Reference #")]
		public string linref;

	}
}