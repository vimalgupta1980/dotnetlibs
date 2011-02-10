using System;
using SysconCommon.Algebras.DataTables;

namespace SMB.Tables {
	public partial class emllst : smbtable {
		/// <summary>
		/// Contact #                       
		/// </summary>
		[ColumnOrder(10)]
		[SMBFieldName("ent_id")]
		[SMBFieldDescription("Contact #")]
		public long ent_id;

		/// <summary>
		/// Contact Type                    
		/// </summary>
		[ColumnOrder(20)]
		[SMBFieldName("enttyp")]
		[SMBFieldDescription("Contact Type")]
		public string enttyp;

		/// <summary>
		/// Email Address                   
		/// </summary>
		[ColumnOrder(30)]
		[SMBFieldName("e_mail")]
		[SMBFieldDescription("Email Address")]
		public string e_mail;

		/// <summary>
		/// Schedule #                      
		/// </summary>
		[ColumnOrder(40)]
		[SMBFieldName("rpt_id")]
		[SMBFieldDescription("Schedule #")]
		public long rpt_id;

	}
}