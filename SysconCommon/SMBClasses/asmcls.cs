using System;

namespace SMB.Tables {
	public class asmcls : smbtable {
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Class#")]
		public int recnum;

		[SMBFieldName("clsnme")]
		[SMBFieldDescription("Class Name")]
		public string clsnme;

		[SMBFieldName("indent")]
		[SMBFieldDescription("Indention Level")]
		public int indent;

		[SMBFieldName("parcls")]
		[SMBFieldDescription("Class Parent#")]
		public int parcls;

		[SMBFieldName("haskid")]
		[SMBFieldDescription("Class Has Children")]
		public int haskid;

	}
}