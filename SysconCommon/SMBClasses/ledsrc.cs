using System;

namespace SMB.Tables {
	public class ledsrc : smbtable {
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Lead Source#")]
		public int recnum;

		[SMBFieldName("srcnme")]
		[SMBFieldDescription("Source Name")]
		public string srcnme;

	}
}