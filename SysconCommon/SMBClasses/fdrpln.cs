using System;

namespace SMB.Tables {
	public class fdrpln : smbtable {
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Record#")]
		public int recnum;

		[SMBFieldName("linnum")]
		[SMBFieldDescription("Line#")]
		public int linnum;

		[SMBFieldName("empnum")]
		[SMBFieldDescription("Employee")]
		public int empnum;

		[SMBFieldName("cstcde")]
		[SMBFieldDescription("Cost Code")]
		public decimal cstcde;

		[SMBFieldName("paytyp")]
		[SMBFieldDescription("Pay Type")]
		public int paytyp;

		[SMBFieldName("paygrp")]
		[SMBFieldDescription("Paygroup")]
		public int paygrp;

		[SMBFieldName("hrspce")]
		[SMBFieldDescription("Hours/Pieces")]
		public decimal hrspce;

		[SMBFieldName("usrdf1")]
		[SMBFieldDescription("User Defined")]
		public string usrdf1;

		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

		[SMBFieldName("absnce")]
		[SMBFieldDescription("Absence Reason")]
		public int absnce;

		[SMBFieldName("reqtrn")]
		[SMBFieldDescription("Required Training")]
		public int reqtrn;

	}
}