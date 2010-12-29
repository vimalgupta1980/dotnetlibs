using System;

namespace SMB.Tables {
	public class sbmsts : smbtable {
		/// <summary>
		/// Submittal Line Status           
		/// </summary>
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Submittal Line Status")]
		public long recnum;

		/// <summary>
		/// Description                     
		/// </summary>
		[SMBFieldName("stsnme")]
		[SMBFieldDescription("Description")]
		public string stsnme;

	}
}