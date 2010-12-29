using System;

namespace SMB.Tables {
	public class schedl : smbtable {
		/// <summary>
		/// Job#                            
		/// </summary>
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Job#")]
		public long recnum;

		/// <summary>
		/// Phase                           
		/// </summary>
		[SMBFieldName("schphs")]
		[SMBFieldDescription("Phase")]
		public long schphs;

		/// <summary>
		/// Edit Date                       
		/// </summary>
		[SMBFieldName("edtdte")]
		[SMBFieldDescription("Edit Date")]
		public DateTime edtdte;

		/// <summary>
		/// User                            
		/// </summary>
		[SMBFieldName("usrnme")]
		[SMBFieldDescription("User")]
		public string usrnme;

		/// <summary>
		/// First Date                      
		/// </summary>
		[SMBFieldName("strdte")]
		[SMBFieldDescription("First Date")]
		public DateTime strdte;

		/// <summary>
		/// Last Date                       
		/// </summary>
		[SMBFieldName("findte")]
		[SMBFieldDescription("Last Date")]
		public DateTime findte;

		/// <summary>
		/// Check Boxes                     
		/// </summary>
		[SMBFieldName("chkbox")]
		[SMBFieldDescription("Check Boxes")]
		public string chkbox;

		/// <summary>
		/// Notes                           
		/// </summary>
		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

		/// <summary>
		/// Work Days                       
		/// </summary>
		[SMBFieldName("wrkdys")]
		[SMBFieldDescription("Work Days")]
		public long wrkdys;

		/// <summary>
		/// Calendar Days                   
		/// </summary>
		[SMBFieldName("caldys")]
		[SMBFieldDescription("Calendar Days")]
		public long caldys;

	}
}