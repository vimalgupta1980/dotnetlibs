using System;

namespace SMB.Tables {
	public class srvrte : smbtable {
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Service Route#")]
		public int recnum;

		[SMBFieldName("rtenme")]
		[SMBFieldDescription("Route Name")]
		public string rtenme;

		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

	}
}