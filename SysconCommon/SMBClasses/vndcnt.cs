using System;

namespace SMB.Tables {
	public class vndcnt : smbtable {
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Vendor#")]
		public int recnum;

		[SMBFieldName("linnum")]
		[SMBFieldDescription("Line#")]
		public int linnum;

		[SMBFieldName("cntnme")]
		[SMBFieldDescription("Contact Name")]
		public string cntnme;

		[SMBFieldName("jobttl")]
		[SMBFieldDescription("Job Title")]
		public string jobttl;

		[SMBFieldName("phnnum")]
		[SMBFieldDescription("Phone#")]
		public string phnnum;

		[SMBFieldName("phnext")]
		[SMBFieldDescription("Extension")]
		public string phnext;

		[SMBFieldName("e_mail")]
		[SMBFieldDescription("Email")]
		public string e_mail;

		[SMBFieldName("cllphn")]
		[SMBFieldDescription("Cell Phone#")]
		public string cllphn;

		[SMBFieldName("faxnum")]
		[SMBFieldDescription("Fax#")]
		public string faxnum;

		[SMBFieldName("othphn")]
		[SMBFieldDescription("Other#")]
		public string othphn;

		[SMBFieldName("othdsc")]
		[SMBFieldDescription("Other Description")]
		public string othdsc;

		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

		[SMBFieldName("linref")]
		[SMBFieldDescription("Line Reference")]
		public string linref;

		[SMBFieldName("msolid")]
		[SMBFieldDescription("Outllook ID")]
		public string msolid;

	}
}