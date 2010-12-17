using System;

namespace SMB.Tables {
	public class rptscd : smbtable {
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Schedule ID")]
		public int recnum;

		[SMBFieldName("rptttl")]
		[SMBFieldDescription("Report Title")]
		public string rptttl;

		[SMBFieldName("rptkey")]
		[SMBFieldDescription("Report RPF File")]
		public string rptkey;

		[SMBFieldName("userid")]
		[SMBFieldDescription("User Name")]
		public string userid;

		[SMBFieldName("creatd")]
		[SMBFieldDescription("Date Created")]
		public DateTime creatd;

		[SMBFieldName("scedul")]
		[SMBFieldDescription("Scheduled")]
		public string scedul;

		[SMBFieldName("output")]
		[SMBFieldDescription("Printer")]
		public string output;

		[SMBFieldName("rptdrv")]
		[SMBFieldDescription("Report Drive")]
		public string rptdrv;

		[SMBFieldName("rptfrm")]
		[SMBFieldDescription("Report Form Design")]
		public string rptfrm;

		[SMBFieldName("dtafld")]
		[SMBFieldDescription("Report Criteria")]
		public string dtafld;

		[SMBFieldName("rptdft")]
		[SMBFieldDescription("Reporting Defaults")]
		public string rptdft;

		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Email Message")]
		public string ntetxt;

		[SMBFieldName("subjct")]
		[SMBFieldDescription("Subject Line")]
		public string subjct;

		[SMBFieldName("tskgid")]
		[SMBFieldDescription("Task GUID")]
		public string tskgid;

		[SMBFieldName("mchnam")]
		[SMBFieldDescription("Machine Name")]
		public string mchnam;

		[SMBFieldName("sndcpy")]
		[SMBFieldDescription("Send Copy")]
		public string sndcpy;

		[SMBFieldName("rceipt")]
		[SMBFieldDescription("Read Receipt")]
		public string rceipt;

		[SMBFieldName("implvl")]
		[SMBFieldDescription("Importance Level")]
		public int implvl;

	}
}