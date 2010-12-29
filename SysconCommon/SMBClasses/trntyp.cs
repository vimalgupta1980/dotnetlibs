using System;

namespace SMB.Tables {
	public class trntyp : smbtable {
		/// <summary>
		/// Training Type#                  
		/// </summary>
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Training Type#")]
		public long recnum;

		/// <summary>
		/// Type Name                       
		/// </summary>
		[SMBFieldName("typnme")]
		[SMBFieldDescription("Type Name")]
		public string typnme;

	}
}