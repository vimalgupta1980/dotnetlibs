using System;

namespace SMB.Tables {
	public class empabs : smbtable {
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Absence#")]
		public int recnum;

		[SMBFieldName("resabs")]
		[SMBFieldDescription("Description")]
		public string resabs;

	}
}