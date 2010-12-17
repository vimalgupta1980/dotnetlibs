using System;

namespace SMB.Tables {
	public class tmcdln : smbtable {
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Record #")]
		public int recnum;

		[SMBFieldName("linnum")]
		[SMBFieldDescription("Line#")]
		public int linnum;

		[SMBFieldName("dtewrk")]
		[SMBFieldDescription("Date")]
		public DateTime dtewrk;

		[SMBFieldName("daywrk")]
		[SMBFieldDescription("Day")]
		public string daywrk;

		[SMBFieldName("dscrpt")]
		[SMBFieldDescription("Description")]
		public string dscrpt;

		[SMBFieldName("wrkord")]
		[SMBFieldDescription("Service Order#")]
		public string wrkord;

		[SMBFieldName("jobnum")]
		[SMBFieldDescription("Job")]
		public int jobnum;

		[SMBFieldName("eqpnum")]
		[SMBFieldDescription("Equip Repaired")]
		public int eqpnum;

		[SMBFieldName("loctax")]
		[SMBFieldDescription("Locale")]
		public int loctax;

		[SMBFieldName("phsnum")]
		[SMBFieldDescription("Phase")]
		public int phsnum;

		[SMBFieldName("cstcde")]
		[SMBFieldDescription("Cost Code")]
		public decimal cstcde;

		[SMBFieldName("paytyp")]
		[SMBFieldDescription("Pay Type")]
		public int paytyp;

		[SMBFieldName("paygrp")]
		[SMBFieldDescription("Paygroup")]
		public int paygrp;

		[SMBFieldName("payrte")]
		[SMBFieldDescription("Pay Rate")]
		public decimal payrte;

		[SMBFieldName("hrswrk")]
		[SMBFieldDescription("Hours")]
		public decimal hrswrk;

		[SMBFieldName("pcerte")]
		[SMBFieldDescription("Piece Rate")]
		public decimal pcerte;

		[SMBFieldName("pieces")]
		[SMBFieldDescription("Pieces")]
		public decimal pieces;

		[SMBFieldName("cmpcde")]
		[SMBFieldDescription("Comp Code")]
		public int cmpcde;

		[SMBFieldName("dptmnt")]
		[SMBFieldDescription("Department")]
		public int dptmnt;

		[SMBFieldName("jobcst")]
		[SMBFieldDescription("Job Cost")]
		public decimal jobcst;

		[SMBFieldName("cmpsub")]
		[SMBFieldDescription("Sub Rate")]
		public decimal cmpsub;

		[SMBFieldName("bensub")]
		[SMBFieldDescription("Sub Benefit")]
		public decimal bensub;

		[SMBFieldName("cmpwge")]
		[SMBFieldDescription("Comp Wage")]
		public decimal cmpwge;

		[SMBFieldName("cmpgrs")]
		[SMBFieldDescription("Comp Gross")]
		public decimal cmpgrs;

		[SMBFieldName("absnce")]
		[SMBFieldDescription("Absence")]
		public int absnce;

		[SMBFieldName("usrdf1")]
		[SMBFieldDescription("User Defined")]
		public string usrdf1;

		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

	}
}