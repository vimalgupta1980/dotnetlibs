using System;

namespace SMB.Tables {
	public class schprd : smbtable {
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Record#")]
		public int recnum;

		[SMBFieldName("recphs")]
		[SMBFieldDescription("Phase Record")]
		public int recphs;

		[SMBFieldName("tsknum")]
		[SMBFieldDescription("Task#")]
		public decimal tsknum;

		[SMBFieldName("jobnum")]
		[SMBFieldDescription("Job")]
		public int jobnum;

		[SMBFieldName("phsnum")]
		[SMBFieldDescription("Phase")]
		public int phsnum;

		[SMBFieldName("prdnum")]
		[SMBFieldDescription("Predecessor")]
		public decimal prdnum;

		[SMBFieldName("reltyp")]
		[SMBFieldDescription("Relation")]
		public int reltyp;

		[SMBFieldName("ledlag")]
		[SMBFieldDescription("Lead/Lag")]
		public int ledlag;

		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

	}
}