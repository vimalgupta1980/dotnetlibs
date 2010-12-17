using System;

namespace SMB.Tables {
	public class jobmnu : smbtable {
		[SMBFieldName("userid")]
		[SMBFieldDescription("User Name")]
		public string userid;

		[SMBFieldName("menu1")]
		[SMBFieldDescription("First Level Menu Number")]
		public int menu1 ;

		[SMBFieldName("menu2")]
		[SMBFieldDescription("Second Level Menu Number")]
		public int menu2 ;

		[SMBFieldName("menu3")]
		[SMBFieldDescription("Third Level Menu Number")]
		public int menu3 ;

		[SMBFieldName("mnudsc")]
		[SMBFieldDescription("Menu Description")]
		public string mnudsc;

	}
}