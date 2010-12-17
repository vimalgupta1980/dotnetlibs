using System;

namespace SMB.Tables {
	public class emllst : smbtable {
		[SMBFieldName("ent_id")]
		[SMBFieldDescription("Contact #")]
		public int ent_id;

		[SMBFieldName("enttyp")]
		[SMBFieldDescription("Contact Type")]
		public string enttyp;

		[SMBFieldName("e_mail")]
		[SMBFieldDescription("Email Address")]
		public string e_mail;

		[SMBFieldName("rpt_id")]
		[SMBFieldDescription("Schedule #")]
		public int rpt_id;

	}
}