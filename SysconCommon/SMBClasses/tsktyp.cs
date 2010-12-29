using System;

namespace SMB.Tables {
	public class tsktyp : smbtable {
		/// <summary>
		/// Task Type #                     
		/// </summary>
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Task Type #")]
		public long recnum;

		/// <summary>
		/// Description                     
		/// </summary>
		[SMBFieldName("tsknme")]
		[SMBFieldDescription("Description")]
		public string tsknme;

		/// <summary>
		/// Task Color                      
		/// </summary>
		[SMBFieldName("tskclr")]
		[SMBFieldDescription("Task Color")]
		public string tskclr;

	}
}