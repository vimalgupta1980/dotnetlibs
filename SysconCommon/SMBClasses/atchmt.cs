using System;

namespace SMB.Tables {
	public class atchmt : smbtable {
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Record#")]
		public int recnum;

		[SMBFieldName("tblnme")]
		[SMBFieldDescription("Attachment Owner's Table")]
		public string tblnme;

		[SMBFieldName("tblrec")]
		[SMBFieldDescription("Attachment Owner's Record#")]
		public int tblrec;

		[SMBFieldName("prntbl")]
		[SMBFieldDescription("Owner's Parent Table")]
		public string prntbl;

		[SMBFieldName("prnrec")]
		[SMBFieldDescription("Owner's Parent Record#")]
		public int prnrec;

	}
}