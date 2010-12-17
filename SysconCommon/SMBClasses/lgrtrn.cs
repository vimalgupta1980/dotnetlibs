using System;

namespace SMB.Tables {
	public class lgrtrn : smbtable {
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Record#")]
		public int recnum;

		[SMBFieldName("trnnum")]
		[SMBFieldDescription("Trans#")]
		public string trnnum;

		[SMBFieldName("trndte")]
		[SMBFieldDescription("Date")]
		public DateTime trndte;

		[SMBFieldName("pchord")]
		[SMBFieldDescription("Order#")]
		public string pchord;

		[SMBFieldName("dscrpt")]
		[SMBFieldDescription("Description")]
		public string dscrpt;

		[SMBFieldName("status")]
		[SMBFieldDescription("Status")]
		public int status;

		[SMBFieldName("srcnum")]
		[SMBFieldDescription("Source")]
		public int srcnum;

		[SMBFieldName("actprd")]
		[SMBFieldDescription("Period")]
		public int actprd;

		[SMBFieldName("entdte")]
		[SMBFieldDescription("Entry Date")]
		public DateTime entdte;

		[SMBFieldName("vndnum")]
		[SMBFieldDescription("Vendor")]
		public int vndnum;

		[SMBFieldName("payee1")]
		[SMBFieldDescription("Payee")]
		public string payee1;

		[SMBFieldName("payee2")]
		[SMBFieldDescription("Payee2")]
		public string payee2;

		[SMBFieldName("addrs1")]
		[SMBFieldDescription("Address1")]
		public string addrs1;

		[SMBFieldName("addrs2")]
		[SMBFieldDescription("Address2")]
		public string addrs2;

		[SMBFieldName("ctynme")]
		[SMBFieldDescription("City")]
		public string ctynme;

		[SMBFieldName("state_")]
		[SMBFieldDescription("State")]
		public string state_;

		[SMBFieldName("usrdf1")]
		[SMBFieldDescription("User Def1")]
		public string usrdf1;

		[SMBFieldName("usrdf2")]
		[SMBFieldDescription("User Def2")]
		public string usrdf2;

		[SMBFieldName("arcrec")]
		[SMBFieldDescription("Archive Rec#")]
		public int arcrec;

		[SMBFieldName("usrnme")]
		[SMBFieldDescription("User")]
		public string usrnme;

		[SMBFieldName("lgrrec")]
		[SMBFieldDescription("Ledger Ref")]
		public int lgrrec;

		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

		[SMBFieldName("zipcde")]
		[SMBFieldDescription("Zip")]
		public string zipcde;

		[SMBFieldName("chkamt")]
		[SMBFieldDescription("Amount")]
		public decimal chkamt;

		[SMBFieldName("active")]
		[SMBFieldDescription("Reconciliation in Process")]
		public int active;

		[SMBFieldName("jobvar")]
		[SMBFieldDescription("Job Cost Variance")]
		public decimal jobvar;

		[SMBFieldName("eqpvar")]
		[SMBFieldDescription("Equipment Cost Variance")]
		public decimal eqpvar;

		[SMBFieldName("wipvar")]
		[SMBFieldDescription("WIP Cost Variance")]
		public decimal wipvar;

		[SMBFieldName("ccrclr")]
		[SMBFieldDescription("Cleared Credit Card Reconcil.")]
		public int ccrclr;

		[SMBFieldName("ccract")]
		[SMBFieldDescription("Active in Credit Card Reconcil.")]
		public int ccract;

	}
}