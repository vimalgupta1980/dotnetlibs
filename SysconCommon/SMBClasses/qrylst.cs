using System;

namespace SMB.Tables {
	public class qrylst : smbtable {
		[SMBFieldName("tblnme")]
		[SMBFieldDescription("Table Name")]
		public string tblnme;

		[SMBFieldName("qrynme")]
		[SMBFieldDescription("Query Name")]
		public string qrynme;

		[SMBFieldName("qrytbl")]
		[SMBFieldDescription("Query Tables")]
		public string qrytbl;

		[SMBFieldName("qryfld")]
		[SMBFieldDescription("Query Parts")]
		public string qryfld;

		[SMBFieldName("qrysrt")]
		[SMBFieldDescription("Query Sort")]
		public string qrysrt;

		[SMBFieldName("qrygrp")]
		[SMBFieldDescription("Query Group")]
		public string qrygrp;

		[SMBFieldName("qrysel")]
		[SMBFieldDescription("Query Select")]
		public string qrysel;

		[SMBFieldName("qrycrt")]
		[SMBFieldDescription("Query Criteria")]
		public string qrycrt;

		[SMBFieldName("omwlck")]
		[SMBFieldDescription("Omware Lock")]
		public int omwlck;

	}
}