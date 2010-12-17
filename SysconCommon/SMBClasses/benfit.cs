using System;

namespace SMB.Tables {
	public class benfit : smbtable {
		[SMBFieldName("paygrp")]
		[SMBFieldDescription("Paygroup#")]
		public int paygrp;

		[SMBFieldName("dednum")]
		[SMBFieldDescription("Calculation")]
		public int dednum;

		[SMBFieldName("dedrte")]
		[SMBFieldDescription("Rate")]
		public decimal dedrte;

	}
}