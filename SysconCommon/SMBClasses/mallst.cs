using System;

namespace SMB.Tables {
	public class mallst : smbtable {
		/// <summary>
		/// Mail List#                      
		/// </summary>
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Mail List#")]
		public long recnum;

		/// <summary>
		/// List Name                       
		/// </summary>
		[SMBFieldName("lstnme")]
		[SMBFieldDescription("List Name")]
		public string lstnme;

	}
}