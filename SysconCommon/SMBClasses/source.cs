using System;

namespace SMB.Tables {
	public class source : smbtable {
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Source")]
		public int recnum;

		[SMBFieldName("srcnme")]
		[SMBFieldDescription("Name")]
		public string srcnme;

		[SMBFieldName("srcdsc")]
		[SMBFieldDescription("Description")]
		public string srcdsc;

	}
}