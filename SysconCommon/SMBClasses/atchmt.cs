using System;

namespace SMB.Tables {
	public class atchmt : smbtable {
		/// <summary>
		/// Record#                         
		/// </summary>
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Record#")]
		public long recnum;

		/// <summary>
		/// Attachment Owner's Table        
		/// </summary>
		[SMBFieldName("tblnme")]
		[SMBFieldDescription("Attachment Owner's Table")]
		public string tblnme;

		/// <summary>
		/// Attachment Owner's Record#      
		/// </summary>
		[SMBFieldName("tblrec")]
		[SMBFieldDescription("Attachment Owner's Record#")]
		public long tblrec;

		/// <summary>
		/// Owner's Parent Table            
		/// </summary>
		[SMBFieldName("prntbl")]
		[SMBFieldDescription("Owner's Parent Table")]
		public string prntbl;

		/// <summary>
		/// Owner's Parent Record#          
		/// </summary>
		[SMBFieldName("prnrec")]
		[SMBFieldDescription("Owner's Parent Record#")]
		public long prnrec;

	}
}