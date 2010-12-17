using System;

namespace SMB.Tables {
	public class attdtl : smbtable {
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Record#")]
		public int recnum;

		[SMBFieldName("target")]
		[SMBFieldDescription("Attachment File/Link")]
		public string target;

		[SMBFieldName("dscrpt")]
		[SMBFieldDescription("Description of Attachment")]
		public string dscrpt;

		[SMBFieldName("attusr")]
		[SMBFieldDescription("User Who Added Attachment")]
		public string attusr;

		[SMBFieldName("attdte")]
		[SMBFieldDescription("Date Attachment Was Added")]
		public DateTime attdte;

	}
}