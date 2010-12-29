using System;

namespace SMB.Tables {
	public class prtcls : smbtable {
		/// <summary>
		/// Class#                          
		/// </summary>
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Class#")]
		public long recnum;

		/// <summary>
		/// Class Name                      
		/// </summary>
		[SMBFieldName("clsnme")]
		[SMBFieldDescription("Class Name")]
		public string clsnme;

		/// <summary>
		/// Indent                          
		/// </summary>
		[SMBFieldName("indent")]
		[SMBFieldDescription("Indent")]
		public long indent;

		/// <summary>
		/// Class Parent#                   
		/// </summary>
		[SMBFieldName("parcls")]
		[SMBFieldDescription("Class Parent#")]
		public long parcls;

		/// <summary>
		/// Class Has Children              
		/// </summary>
		[SMBFieldName("haskid")]
		[SMBFieldDescription("Class Has Children")]
		public long haskid;

	}
}