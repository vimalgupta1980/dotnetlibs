using System;

namespace SMB.Tables {
	public class payrec : smbtable {
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Record#")]
		public int recnum;

		[SMBFieldName("empnum")]
		[SMBFieldDescription("Employee")]
		public int empnum;

		[SMBFieldName("strprd")]
		[SMBFieldDescription("Period Start")]
		public DateTime strprd;

		[SMBFieldName("payprd")]
		[SMBFieldDescription("Period End")]
		public DateTime payprd;

		[SMBFieldName("chknum")]
		[SMBFieldDescription("Check#")]
		public string chknum;

		[SMBFieldName("chkdte")]
		[SMBFieldDescription("Check Date")]
		public DateTime chkdte;

		[SMBFieldName("taxste")]
		[SMBFieldDescription("State")]
		public string taxste;

		[SMBFieldName("salary")]
		[SMBFieldDescription("Salary")]
		public decimal salary;

		[SMBFieldName("payrt1")]
		[SMBFieldDescription("Standard Regular Rate")]
		public decimal payrt1;

		[SMBFieldName("payrt2")]
		[SMBFieldDescription("Standard Overtime Rate")]
		public decimal payrt2;

		[SMBFieldName("payrt3")]
		[SMBFieldDescription("Standard Premium Rate")]
		public decimal payrt3;

		[SMBFieldName("advnce")]
		[SMBFieldDescription("Advance")]
		public decimal advnce;

		[SMBFieldName("paytyp")]
		[SMBFieldDescription("Payroll Type")]
		public int paytyp;

		[SMBFieldName("status")]
		[SMBFieldDescription("Status")]
		public int status;

		[SMBFieldName("qtrnum")]
		[SMBFieldDescription("Quarter")]
		public int qtrnum;

		[SMBFieldName("reghrs")]
		[SMBFieldDescription("Regular Hrs")]
		public decimal reghrs;

		[SMBFieldName("ovthrs")]
		[SMBFieldDescription("Overtime Hrs")]
		public decimal ovthrs;

		[SMBFieldName("prmhrs")]
		[SMBFieldDescription("Premium Hrs")]
		public decimal prmhrs;

		[SMBFieldName("sckhrs")]
		[SMBFieldDescription("Sick Hrs")]
		public decimal sckhrs;

		[SMBFieldName("vachrs")]
		[SMBFieldDescription("Vacation Hrs")]
		public decimal vachrs;

		[SMBFieldName("holhrs")]
		[SMBFieldDescription("Holiday Hrs")]
		public decimal holhrs;

		[SMBFieldName("pieces")]
		[SMBFieldDescription("Pieces")]
		public decimal pieces;

		[SMBFieldName("ttlhrs")]
		[SMBFieldDescription("Total Hrs")]
		public decimal ttlhrs;

		[SMBFieldName("regpay")]
		[SMBFieldDescription("Reg Pay")]
		public decimal regpay;

		[SMBFieldName("ovtpay")]
		[SMBFieldDescription("Ovt Pay")]
		public decimal ovtpay;

		[SMBFieldName("prmpay")]
		[SMBFieldDescription("Prem Pay")]
		public decimal prmpay;

		[SMBFieldName("sckpay")]
		[SMBFieldDescription("Sick Pay")]
		public decimal sckpay;

		[SMBFieldName("vacpay")]
		[SMBFieldDescription("Vac Pay")]
		public decimal vacpay;

		[SMBFieldName("holpay")]
		[SMBFieldDescription("Hol Pay")]
		public decimal holpay;

		[SMBFieldName("pcerte")]
		[SMBFieldDescription("Piece Pay")]
		public decimal pcerte;

		[SMBFieldName("perdim")]
		[SMBFieldDescription("Per Diem")]
		public decimal perdim;

		[SMBFieldName("mscpay")]
		[SMBFieldDescription("Msc Pay")]
		public decimal mscpay;

		[SMBFieldName("grspay")]
		[SMBFieldDescription("Gross Pay")]
		public decimal grspay;

		[SMBFieldName("dedttl")]
		[SMBFieldDescription("Deduct Total")]
		public decimal dedttl;

		[SMBFieldName("addttl")]
		[SMBFieldDescription("Add Total")]
		public decimal addttl;

		[SMBFieldName("netpay")]
		[SMBFieldDescription("Net Pay")]
		public decimal netpay;

		[SMBFieldName("entdte")]
		[SMBFieldDescription("Entry Date")]
		public DateTime entdte;

		[SMBFieldName("pcpyrt")]
		[SMBFieldDescription("Hourly Rate for Pieces")]
		public decimal pcpyrt;

		[SMBFieldName("dirdep")]
		[SMBFieldDescription("Use Direct Deposit")]
		public int dirdep;

		[SMBFieldName("lgrrec")]
		[SMBFieldDescription("Ledger Ref#")]
		public int lgrrec;

		[SMBFieldName("usrnme")]
		[SMBFieldDescription("User Name")]
		public string usrnme;

		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

		[SMBFieldName("ddpbch")]
		[SMBFieldDescription("Direct Dep. Batch#")]
		public int ddpbch;

	}
}