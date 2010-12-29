using System;

namespace SMB.Tables {
	public class attdtl : smbtable {
		/// <summary>
		/// Record#                         
		/// </summary>
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Record#")]
		public long recnum;

		/// <summary>
		/// Attachment File/Link            
		/// </summary>
		[SMBFieldName("target")]
		[SMBFieldDescription("Attachment File/Link")]
		public string target;

		/// <summary>
		/// Description of Attachment       
		/// </summary>
		[SMBFieldName("dscrpt")]
		[SMBFieldDescription("Description of Attachment")]
		public string dscrpt;

		/// <summary>
		/// User Who Added Attachment       
		/// </summary>
		[SMBFieldName("attusr")]
		[SMBFieldDescription("User Who Added Attachment")]
		public string attusr;

		/// <summary>
		/// Date Attachment Was Added       
		/// </summary>
		[SMBFieldName("attdte")]
		[SMBFieldDescription("Date Attachment Was Added")]
		public DateTime attdte;

	}
}