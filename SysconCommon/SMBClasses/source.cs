using System;

namespace SMB.Tables {
	public class source : smbtable {
		/// <summary>
		/// Source                          
		/// </summary>
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Source")]
		public long recnum;

		/// <summary>
		/// Name                            
		/// </summary>
		[SMBFieldName("srcnme")]
		[SMBFieldDescription("Name")]
		public string srcnme;

		/// <summary>
		/// Description                     
		/// </summary>
		[SMBFieldName("srcdsc")]
		[SMBFieldDescription("Description")]
		public string srcdsc;

	}
}