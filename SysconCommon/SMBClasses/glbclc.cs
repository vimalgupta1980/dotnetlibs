using System;

namespace SMB.Tables {
	public class glbclc : smbtable {
		[SMBFieldName("clcnme")]
		[SMBFieldDescription("Name")]
		public string clcnme;

		[SMBFieldName("clcdsc")]
		[SMBFieldDescription("Description")]
		public string clcdsc;

		[SMBFieldName("clcexp")]
		[SMBFieldDescription("Expression")]
		public string clcexp;

		[SMBFieldName("lckedt")]
		[SMBFieldDescription("Lock Edit")]
		public int lckedt;

		[SMBFieldName("omwlck")]
		[SMBFieldDescription("OMware Lock")]
		public int omwlck;

	}
}