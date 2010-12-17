using System;

namespace SMB.Tables {
	public class brdftg : smbtable {
		[SMBFieldName("prtcls")]
		[SMBFieldDescription("Part Class")]
		public int prtcls;

		[SMBFieldName("cstbdf")]
		[SMBFieldDescription("Cost/1000Bf")]
		public decimal cstbdf;

		[SMBFieldName("bilbdf")]
		[SMBFieldDescription("Bill/1000Bf")]
		public decimal bilbdf;

	}
}