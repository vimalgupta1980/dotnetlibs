using System;

namespace SMB.Tables {
	public class prmchg : smbtable {
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Record#")]
		public int recnum;

		[SMBFieldName("chgnum")]
		[SMBFieldDescription("Change#")]
		public string chgnum;

		[SMBFieldName("chgdte")]
		[SMBFieldDescription("Date")]
		public DateTime chgdte;

		[SMBFieldName("jobnum")]
		[SMBFieldDescription("Job")]
		public int jobnum;

		[SMBFieldName("phsnum")]
		[SMBFieldDescription("Phase")]
		public int phsnum;

		[SMBFieldName("dscrpt")]
		[SMBFieldDescription("Description")]
		public string dscrpt;

		[SMBFieldName("reason")]
		[SMBFieldDescription("Reason")]
		public string reason;

		[SMBFieldName("usrdf1")]
		[SMBFieldDescription("User Def1")]
		public string usrdf1;

		[SMBFieldName("usrdf2")]
		[SMBFieldDescription("User Def2")]
		public string usrdf2;

		[SMBFieldName("pchord")]
		[SMBFieldDescription("Client PO#")]
		public string pchord;

		[SMBFieldName("subdte")]
		[SMBFieldDescription("Submitted")]
		public DateTime subdte;

		[SMBFieldName("aprdte")]
		[SMBFieldDescription("Approved")]
		public DateTime aprdte;

		[SMBFieldName("invdte")]
		[SMBFieldDescription("Invoiced")]
		public DateTime invdte;

		[SMBFieldName("delreq")]
		[SMBFieldDescription("Delay Requested")]
		public int delreq;

		[SMBFieldName("dysdly")]
		[SMBFieldDescription("Delay Approved")]
		public int dysdly;

		[SMBFieldName("chgtyp")]
		[SMBFieldDescription("CO Type")]
		public int chgtyp;

		[SMBFieldName("status")]
		[SMBFieldDescription("Status")]
		public int status;

		[SMBFieldName("submto")]
		[SMBFieldDescription("Submit to")]
		public string submto;

		[SMBFieldName("submby")]
		[SMBFieldDescription("Submit by")]
		public int submby;

		[SMBFieldName("reqamt")]
		[SMBFieldDescription("Requested Amount")]
		public decimal reqamt;

		[SMBFieldName("appamt")]
		[SMBFieldDescription("Approved Amount")]
		public decimal appamt;

		[SMBFieldName("cstamt")]
		[SMBFieldDescription("Cost Amount")]
		public decimal cstamt;

		[SMBFieldName("ovhamt")]
		[SMBFieldDescription("Overhead Amount")]
		public decimal ovhamt;

		[SMBFieldName("pftamt")]
		[SMBFieldDescription("Profit Amount")]
		public decimal pftamt;

		[SMBFieldName("reqpft")]
		[SMBFieldDescription("Req. Profit Amount")]
		public decimal reqpft;

		[SMBFieldName("entdte")]
		[SMBFieldDescription("Entered")]
		public DateTime entdte;

		[SMBFieldName("usrnme")]
		[SMBFieldDescription("User")]
		public string usrnme;

		[SMBFieldName("chgscp")]
		[SMBFieldDescription("Scope")]
		public string chgscp;

		[SMBFieldName("hotlst")]
		[SMBFieldDescription("Hot List")]
		public int hotlst;

		[SMBFieldName("lckedt")]
		[SMBFieldDescription("Lock Edit")]
		public int lckedt;

		[SMBFieldName("actper")]
		[SMBFieldDescription("Period")]
		public int actper;

		[SMBFieldName("mrgamt")]
		[SMBFieldDescription("Gross Margin")]
		public decimal mrgamt;

		[SMBFieldName("reqmrg")]
		[SMBFieldDescription("Req. Gross Margin")]
		public decimal reqmrg;

		[SMBFieldName("estamt")]
		[SMBFieldDescription("Estimated Total")]
		public decimal estamt;

		[SMBFieldName("estovh")]
		[SMBFieldDescription("Estimated O/H")]
		public decimal estovh;

		[SMBFieldName("upgrde")]
		[SMBFieldDescription("Upgrade")]
		public int upgrde;

		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

	}
}