using System;

namespace SMB.Tables {
	public class sbmtln : smbtable {
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Record#")]
		public int recnum;

		[SMBFieldName("linnum")]
		[SMBFieldDescription("Line#")]
		public int linnum;

		[SMBFieldName("itmnum")]
		[SMBFieldDescription("Item")]
		public string itmnum;

		[SMBFieldName("dscrpt")]
		[SMBFieldDescription("Description")]
		public string dscrpt;

		[SMBFieldName("actreq")]
		[SMBFieldDescription("Action Required")]
		public string actreq;

		[SMBFieldName("reqdte")]
		[SMBFieldDescription("Date Required")]
		public DateTime reqdte;

		[SMBFieldName("sbmsts")]
		[SMBFieldDescription("Status")]
		public int sbmsts;

		[SMBFieldName("usrdf1")]
		[SMBFieldDescription("User Defined")]
		public string usrdf1;

		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

	}
}