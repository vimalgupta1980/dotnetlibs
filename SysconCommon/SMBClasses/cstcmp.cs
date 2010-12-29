using System;

namespace SMB.Tables {
	public class cstcmp : smbtable {
		/// <summary>
		/// Job#                            
		/// </summary>
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Job#")]
		public long recnum;

		/// <summary>
		/// Labor Burden                    
		/// </summary>
		[SMBFieldName("lbrbur")]
		[SMBFieldDescription("Labor Burden")]
		public decimal lbrbur;

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
		/// Notes                           
		/// </summary>
		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

	}
}