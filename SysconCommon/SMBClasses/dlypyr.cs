using System;

namespace SMB.Tables {
	public class dlypyr : smbtable {
		[SMBFieldName("paydte")]
		[SMBFieldDescription("Date")]
		public DateTime paydte;

		[SMBFieldName("linnum")]
		[SMBFieldDescription("Line#")]
		public int linnum;

		[SMBFieldName("empnum")]
		[SMBFieldDescription("Employee")]
		public int empnum;

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
		[SMBFieldDescription("Locality")]
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

		[SMBFieldName("payhrs")]
		[SMBFieldDescription("Hours")]
		public decimal payhrs;

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

		[SMBFieldName("opreqp")]
		[SMBFieldDescription("Oper Equipment")]
		public int opreqp;

		[SMBFieldName("eqpunt")]
		[SMBFieldDescription("Cost Unit")]
		public int eqpunt;

		[SMBFieldName("oprhrs")]
		[SMBFieldDescription("Operated")]
		public decimal oprhrs;

		[SMBFieldName("stdhrs")]
		[SMBFieldDescription("Standby")]
		public decimal stdhrs;

		[SMBFieldName("idlhrs")]
		[SMBFieldDescription("Idle")]
		public decimal idlhrs;

		[SMBFieldName("bllunt")]
		[SMBFieldDescription("Rental Unit")]
		public int bllunt;

		[SMBFieldName("oprbll")]
		[SMBFieldDescription("Operated Rental")]
		public decimal oprbll;

		[SMBFieldName("stdbll")]
		[SMBFieldDescription("Standby Rental")]
		public decimal stdbll;

		[SMBFieldName("idlbll")]
		[SMBFieldDescription("Idle Rental")]
		public decimal idlbll;

		[SMBFieldName("usrdf1")]
		[SMBFieldDescription("User Defined")]
		public string usrdf1;

		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

		[SMBFieldName("absnce")]
		[SMBFieldDescription("Absence")]
		public int absnce;

	}
}