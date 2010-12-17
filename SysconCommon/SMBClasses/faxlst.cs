using System;

namespace SMB.Tables {
	public class faxlst : smbtable {
		[SMBFieldName("ent_id")]
		[SMBFieldDescription("Contact #")]
		public int ent_id;

		[SMBFieldName("enttyp")]
		[SMBFieldDescription("Contact Typ")]
		public string enttyp;

		[SMBFieldName("faxnum")]
		[SMBFieldDescription("Fax Number")]
		public string faxnum;

		[SMBFieldName("rpt_id")]
		[SMBFieldDescription("Schedule #")]
		public int rpt_id;

	}
}