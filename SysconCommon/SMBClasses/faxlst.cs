using System;
using SysconCommon.Algebras.DataTables;

namespace SMB.Tables {
	public partial class faxlst : smbtable {
		/// <summary>
		/// Contact #                       
		/// </summary>
		[ColumnOrder(10)]
		[SMBFieldName("ent_id")]
		[SMBFieldDescription("Contact #")]
		public long ent_id;

		/// <summary>
		/// Contact Typ                     
		/// </summary>
		[ColumnOrder(20)]
		[SMBFieldName("enttyp")]
		[SMBFieldDescription("Contact Typ")]
		public string enttyp;

		/// <summary>
		/// Fax Number                      
		/// </summary>
		[ColumnOrder(30)]
		[SMBFieldName("faxnum")]
		[SMBFieldDescription("Fax Number")]
		public string faxnum;

		/// <summary>
		/// Schedule #                      
		/// </summary>
		[ColumnOrder(40)]
		[SMBFieldName("rpt_id")]
		[SMBFieldDescription("Schedule #")]
		public long rpt_id;

	}
}