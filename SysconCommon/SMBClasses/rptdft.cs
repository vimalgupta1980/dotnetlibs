using System;

namespace SMB.Tables {
	public class rptdft : smbtable {
		[SMBFieldName("rptnme")]
		[SMBFieldDescription("Report Name")]
		public string rptnme;

		[SMBFieldName("dftdta")]
		[SMBFieldDescription("Default Data")]
		public string dftdta;

	}
}