using System;

namespace SMB.Tables {
	public class timemp : smbtable {
		/// <summary>
		/// Record#                         
		/// </summary>
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Record#")]
		public long recnum;

		/// <summary>
		/// Rate Table Description          
		/// </summary>
		[SMBFieldName("tbldsc")]
		[SMBFieldDescription("Rate Table Description")]
		public string tbldsc;

		/// <summary>
		/// Edit Date                       
		/// </summary>
		[SMBFieldName("edtdte")]
		[SMBFieldDescription("Edit Date")]
		public DateTime edtdte;

		/// <summary>
		/// Lock Edit                       
		/// </summary>
		[SMBFieldName("lckedt")]
		[SMBFieldDescription("Lock Edit")]
		public long lckedt;

		/// <summary>
		/// Edit User                       
		/// </summary>
		[SMBFieldName("usrnme")]
		[SMBFieldDescription("Edit User")]
		public string usrnme;

		/// <summary>
		/// Notes                           
		/// </summary>
		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

	}
}