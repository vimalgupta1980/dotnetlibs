using System;

namespace SMB.Tables {
	public class invser : smbtable {
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Part#")]
		public int recnum;

		[SMBFieldName("locnum")]
		[SMBFieldDescription("Location")]
		public int locnum;

		[SMBFieldName("sernum")]
		[SMBFieldDescription("Serial#")]
		public string sernum;

		[SMBFieldName("stkdte")]
		[SMBFieldDescription("Stocked Date")]
		public DateTime stkdte;

	}
}