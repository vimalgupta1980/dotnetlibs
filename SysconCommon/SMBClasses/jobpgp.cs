using System;

namespace SMB.Tables {
	public class jobpgp : smbtable {
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Job#")]
		public int recnum;

		[SMBFieldName("reggrp")]
		[SMBFieldDescription("Position")]
		public int reggrp;

		[SMBFieldName("paygrp")]
		[SMBFieldDescription("Paygroup")]
		public int paygrp;

		[SMBFieldName("pcerte")]
		[SMBFieldDescription("Piece Rate")]
		public decimal pcerte;

	}
}