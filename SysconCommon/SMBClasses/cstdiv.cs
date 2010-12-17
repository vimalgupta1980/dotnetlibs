using System;

namespace SMB.Tables {
	public class cstdiv : smbtable {
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Division#")]
		public int recnum;

		[SMBFieldName("divnme")]
		[SMBFieldDescription("Description")]
		public string divnme;

	}
}