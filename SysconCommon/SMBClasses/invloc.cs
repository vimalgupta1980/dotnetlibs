using System;

namespace SMB.Tables {
	public class invloc : smbtable {
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Inv. Location#")]
		public int recnum;

		[SMBFieldName("locnme")]
		[SMBFieldDescription("Location Name")]
		public string locnme;

		[SMBFieldName("empnum")]
		[SMBFieldDescription("Employee")]
		public int empnum;

	}
}