using System;

namespace SMB.Tables {
	public class grdvew : smbtable {
		/// <summary>
		/// Grid View Option/User           
		/// </summary>
		[SMBFieldName("vewnme")]
		[SMBFieldDescription("Grid View Option/User")]
		public string vewnme;

		/// <summary>
		/// Grid View Data                  
		/// </summary>
		[SMBFieldName("vewdta")]
		[SMBFieldDescription("Grid View Data")]
		public string vewdta;

		/// <summary>
		/// OMware Lock                     
		/// </summary>
		[SMBFieldName("omwlck")]
		[SMBFieldDescription("OMware Lock")]
		public long omwlck;

	}
}