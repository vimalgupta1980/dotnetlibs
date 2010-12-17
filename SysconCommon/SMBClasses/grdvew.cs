using System;

namespace SMB.Tables {
	public class grdvew : smbtable {
		[SMBFieldName("vewnme")]
		[SMBFieldDescription("Grid View Option/User")]
		public string vewnme;

		[SMBFieldName("vewdta")]
		[SMBFieldDescription("Grid View Data")]
		public string vewdta;

		[SMBFieldName("omwlck")]
		[SMBFieldDescription("OMware Lock")]
		public int omwlck;

	}
}