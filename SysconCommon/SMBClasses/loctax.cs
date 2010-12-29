using System;

namespace SMB.Tables {
	public class loctax : smbtable {
		/// <summary>
		/// District#                       
		/// </summary>
		[SMBFieldName("recnum")]
		[SMBFieldDescription("District#")]
		public long recnum;

		/// <summary>
		/// District Name                   
		/// </summary>
		[SMBFieldName("dscrpt")]
		[SMBFieldDescription("District Name")]
		public string dscrpt;

		/// <summary>
		/// Resident Rate                   
		/// </summary>
		[SMBFieldName("resrte")]
		[SMBFieldDescription("Resident Rate")]
		public decimal resrte;

		/// <summary>
		/// Non-Res Rate                    
		/// </summary>
		[SMBFieldName("nonrte")]
		[SMBFieldDescription("Non-Res Rate")]
		public decimal nonrte;

		/// <summary>
		/// Tax State                       
		/// </summary>
		[SMBFieldName("inctax")]
		[SMBFieldDescription("Tax State")]
		public string inctax;

	}
}