using System;

namespace SMB.Tables {
	public class paygrp : smbtable {
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Paygroup#")]
		public int recnum;

		[SMBFieldName("grpnme")]
		[SMBFieldDescription("Name")]
		public string grpnme;

		[SMBFieldName("wrkcls")]
		[SMBFieldDescription("Classification")]
		public string wrkcls;

		[SMBFieldName("payrt1")]
		[SMBFieldDescription("Rate1")]
		public decimal payrt1;

		[SMBFieldName("payrt2")]
		[SMBFieldDescription("Rate2")]
		public decimal payrt2;

		[SMBFieldName("payrt3")]
		[SMBFieldDescription("Rate3")]
		public decimal payrt3;

		[SMBFieldName("pcerte")]
		[SMBFieldDescription("Piece Rate")]
		public decimal pcerte;

		[SMBFieldName("uninum")]
		[SMBFieldDescription("Union")]
		public int uninum;

		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

	}
}