using System;

namespace SMB.Tables {
	public class glbvar : smbtable {
		/// <summary>
		/// Job#                            
		/// </summary>
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Job#")]
		public long recnum;

		/// <summary>
		/// Description                     
		/// </summary>
		[SMBFieldName("dscrpt")]
		[SMBFieldDescription("Description")]
		public string dscrpt;

		/// <summary>
		/// Variable Name                   
		/// </summary>
		[SMBFieldName("abvnme")]
		[SMBFieldDescription("Variable Name")]
		public string abvnme;

		/// <summary>
		/// Unit                            
		/// </summary>
		[SMBFieldName("untdsc")]
		[SMBFieldDescription("Unit")]
		public string untdsc;

		/// <summary>
		/// Value                           
		/// </summary>
		[SMBFieldName("glbval")]
		[SMBFieldDescription("Value")]
		public decimal glbval;

		/// <summary>
		/// Notes                           
		/// </summary>
		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

	}
}