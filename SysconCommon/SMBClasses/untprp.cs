using System;

namespace SMB.Tables {
	public class untprp : smbtable {
		/// <summary>
		/// Job#                            
		/// </summary>
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Job#")]
		public long recnum;

		/// <summary>
		/// Lock Edit                       
		/// </summary>
		[SMBFieldName("lckedt")]
		[SMBFieldDescription("Lock Edit")]
		public long lckedt;

		/// <summary>
		/// Edit Date                       
		/// </summary>
		[SMBFieldName("edtdte")]
		[SMBFieldDescription("Edit Date")]
		public DateTime edtdte;

		/// <summary>
		/// User Name                       
		/// </summary>
		[SMBFieldName("usrnme")]
		[SMBFieldDescription("User Name")]
		public string usrnme;

		/// <summary>
		/// Total Proposal                  
		/// </summary>
		[SMBFieldName("ttlcst")]
		[SMBFieldDescription("Total Proposal")]
		public decimal ttlcst;

		/// <summary>
		/// Hot List                        
		/// </summary>
		[SMBFieldName("hotlst")]
		[SMBFieldDescription("Hot List")]
		public long hotlst;

		/// <summary>
		/// Notes                           
		/// </summary>
		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

	}
}