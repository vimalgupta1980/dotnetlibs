using System;

namespace SMB.Tables {
	public class faxlst : smbtable {
		/// <summary>
		/// Contact #                       
		/// </summary>
		[SMBFieldName("ent_id")]
		[SMBFieldDescription("Contact #")]
		public long ent_id;

		/// <summary>
		/// Contact Typ                     
		/// </summary>
		[SMBFieldName("enttyp")]
		[SMBFieldDescription("Contact Typ")]
		public string enttyp;

		/// <summary>
		/// Fax Number                      
		/// </summary>
		[SMBFieldName("faxnum")]
		[SMBFieldDescription("Fax Number")]
		public string faxnum;

		/// <summary>
		/// Schedule #                      
		/// </summary>
		[SMBFieldName("rpt_id")]
		[SMBFieldDescription("Schedule #")]
		public long rpt_id;

	}
}