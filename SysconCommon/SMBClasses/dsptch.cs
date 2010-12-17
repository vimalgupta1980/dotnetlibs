using System;

namespace SMB.Tables {
	public class dsptch : smbtable {
		[SMBFieldName("column")]
		[SMBFieldDescription("Column#")]
		public int column;

		[SMBFieldName("empnum")]
		[SMBFieldDescription("Employee")]
		public int empnum;

		[SMBFieldName("disply")]
		[SMBFieldDescription("Display As")]
		public string disply;

	}
}