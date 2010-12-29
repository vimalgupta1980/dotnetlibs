using System;

namespace SMB.Tables {
	public class csttyp : smbtable {
		/// <summary>
		/// Cost Type#                      
		/// </summary>
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Cost Type#")]
		public long recnum;

		/// <summary>
		/// Type Name                       
		/// </summary>
		[SMBFieldName("typnme")]
		[SMBFieldDescription("Type Name")]
		public string typnme;

	}
}