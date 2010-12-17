using System;

namespace SMB.Tables {
	public class usrlst : smbtable {
		[SMBFieldName("usrnme")]
		[SMBFieldDescription("User Name")]
		public string usrnme;

		[SMBFieldName("usrpsw")]
		[SMBFieldDescription("Password")]
		public string usrpsw;

		[SMBFieldName("licgrp")]
		[SMBFieldDescription("License Group")]
		public string licgrp;

		[SMBFieldName("group1")]
		[SMBFieldDescription("Group 1")]
		public int group1;

		[SMBFieldName("group2")]
		[SMBFieldDescription("Group 2")]
		public int group2;

		[SMBFieldName("group3")]
		[SMBFieldDescription("Group 3")]
		public int group3;

		[SMBFieldName("group4")]
		[SMBFieldDescription("Group 4")]
		public int group4;

		[SMBFieldName("group5")]
		[SMBFieldDescription("Group 5")]
		public int group5;

	}
}