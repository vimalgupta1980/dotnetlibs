using System;

namespace SMB.Tables {
	public class untlin : smbtable {
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Record#")]
		public int recnum;

		[SMBFieldName("linnum")]
		[SMBFieldDescription("Line#")]
		public int linnum;

		[SMBFieldName("biditm")]
		[SMBFieldDescription("Bid Item")]
		public int biditm;

		[SMBFieldName("itmcde")]
		[SMBFieldDescription("Item Code")]
		public string itmcde;

		[SMBFieldName("itmnme")]
		[SMBFieldDescription("Description")]
		public string itmnme;

		[SMBFieldName("untdsc")]
		[SMBFieldDescription("Unit")]
		public string untdsc;

		[SMBFieldName("untcst")]
		[SMBFieldDescription("Unit Price")]
		public decimal untcst;

		[SMBFieldName("schamt")]
		[SMBFieldDescription("Sched. Qty")]
		public decimal schamt;

		[SMBFieldName("schval")]
		[SMBFieldDescription("Sched. $")]
		public decimal schval;

		[SMBFieldName("chgamt")]
		[SMBFieldDescription("Change Qty")]
		public decimal chgamt;

		[SMBFieldName("chgval")]
		[SMBFieldDescription("Change $")]
		public decimal chgval;

		[SMBFieldName("newcon")]
		[SMBFieldDescription("Contract Qty")]
		public decimal newcon;

		[SMBFieldName("cntval")]
		[SMBFieldDescription("Contract $")]
		public decimal cntval;

		[SMBFieldName("prvbll")]
		[SMBFieldDescription("Previous Qty")]
		public decimal prvbll;

		[SMBFieldName("prvval")]
		[SMBFieldDescription("Previous $")]
		public decimal prvval;

		[SMBFieldName("curbll")]
		[SMBFieldDescription("Current Qty")]
		public decimal curbll;

		[SMBFieldName("curval")]
		[SMBFieldDescription("Current $")]
		public decimal curval;

		[SMBFieldName("ttlcmp")]
		[SMBFieldDescription("Total Qty")]
		public decimal ttlcmp;

		[SMBFieldName("totval")]
		[SMBFieldDescription("Total $")]
		public decimal totval;

		[SMBFieldName("balfin")]
		[SMBFieldDescription("Balance Qty")]
		public decimal balfin;

		[SMBFieldName("remval")]
		[SMBFieldDescription("Balance $")]
		public decimal remval;

		[SMBFieldName("retrte")]
		[SMBFieldDescription("Ret. Rate")]
		public decimal retrte;

		[SMBFieldName("retamt")]
		[SMBFieldDescription("Retention")]
		public decimal retamt;

		[SMBFieldName("usrdf1")]
		[SMBFieldDescription("User Defined")]
		public string usrdf1;

		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

	}
}