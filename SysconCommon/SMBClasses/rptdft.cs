using System;

namespace SMB.Tables {
	public class rptdft : smbtable {
		/// <summary>
		/// Report Name                     
		/// </summary>
		[SMBFieldName("rptnme")]
		[SMBFieldDescription("Report Name")]
		public string rptnme;

		/// <summary>
		/// Default Data                    
		/// </summary>
		[SMBFieldName("dftdta")]
		[SMBFieldDescription("Default Data")]
		public string dftdta;

	}
}