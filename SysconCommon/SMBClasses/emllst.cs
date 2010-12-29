using System;

namespace SMB.Tables {
	public class emllst : smbtable {
		/// <summary>
		/// Contact #                       
		/// </summary>
		[SMBFieldName("ent_id")]
		[SMBFieldDescription("Contact #")]
		public long ent_id;

		/// <summary>
		/// Contact Type                    
		/// </summary>
		[SMBFieldName("enttyp")]
		[SMBFieldDescription("Contact Type")]
		public string enttyp;

		/// <summary>
		/// Email Address                   
		/// </summary>
		[SMBFieldName("e_mail")]
		[SMBFieldDescription("Email Address")]
		public string e_mail;

		/// <summary>
		/// Schedule #                      
		/// </summary>
		[SMBFieldName("rpt_id")]
		[SMBFieldDescription("Schedule #")]
		public long rpt_id;

	}
}