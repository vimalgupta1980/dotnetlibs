using System;

namespace SMB.Tables {
	public class eqptyp : smbtable {
		/// <summary>
		/// Equip Type#                     
		/// </summary>
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Equip Type#")]
		public long recnum;

		/// <summary>
		/// Type Name                       
		/// </summary>
		[SMBFieldName("typnme")]
		[SMBFieldDescription("Type Name")]
		public string typnme;

		/// <summary>
		/// Notes                           
		/// </summary>
		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

	}
}