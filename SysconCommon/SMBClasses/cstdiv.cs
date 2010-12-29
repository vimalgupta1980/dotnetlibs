using System;

namespace SMB.Tables {
	public class cstdiv : smbtable {
		/// <summary>
		/// Division#                       
		/// </summary>
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Division#")]
		public long recnum;

		/// <summary>
		/// Description                     
		/// </summary>
		[SMBFieldName("divnme")]
		[SMBFieldDescription("Description")]
		public string divnme;

	}
}