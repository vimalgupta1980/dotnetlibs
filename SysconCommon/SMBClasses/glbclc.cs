using System;

namespace SMB.Tables {
	public class glbclc : smbtable {
		/// <summary>
		/// Name                            
		/// </summary>
		[SMBFieldName("clcnme")]
		[SMBFieldDescription("Name")]
		public string clcnme;

		/// <summary>
		/// Description                     
		/// </summary>
		[SMBFieldName("clcdsc")]
		[SMBFieldDescription("Description")]
		public string clcdsc;

		/// <summary>
		/// Expression                      
		/// </summary>
		[SMBFieldName("clcexp")]
		[SMBFieldDescription("Expression")]
		public string clcexp;

		/// <summary>
		/// Lock Edit                       
		/// </summary>
		[SMBFieldName("lckedt")]
		[SMBFieldDescription("Lock Edit")]
		public long lckedt;

		/// <summary>
		/// OMware Lock                     
		/// </summary>
		[SMBFieldName("omwlck")]
		[SMBFieldDescription("OMware Lock")]
		public long omwlck;

	}
}