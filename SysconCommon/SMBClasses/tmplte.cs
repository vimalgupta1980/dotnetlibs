using System;

namespace SMB.Tables {
	public class tmplte : smbtable {
		[SMBFieldName("dtanme")]
		[SMBFieldDescription("Template Name")]
		public string dtanme;

		[SMBFieldName("dtalin")]
		[SMBFieldDescription("Line Data")]
		public string dtalin;

	}
}