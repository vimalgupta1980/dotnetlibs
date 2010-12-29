using System;

namespace SMB.Tables {
	public class msctbl : smbtable {
		/// <summary>
		/// Data Name                       
		/// </summary>
		[SMBFieldName("dtanme")]
		[SMBFieldDescription("Data Name")]
		public string dtanme;

		/// <summary>
		/// Line Data                       
		/// </summary>
		[SMBFieldName("dtalin")]
		[SMBFieldDescription("Line Data")]
		public string dtalin;

	}
}