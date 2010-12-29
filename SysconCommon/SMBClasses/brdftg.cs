using System;

namespace SMB.Tables {
	public class brdftg : smbtable {
		/// <summary>
		/// Part Class                      
		/// </summary>
		[SMBFieldName("prtcls")]
		[SMBFieldDescription("Part Class")]
		public long prtcls;

		/// <summary>
		/// Cost/1000Bf                     
		/// </summary>
		[SMBFieldName("cstbdf")]
		[SMBFieldDescription("Cost/1000Bf")]
		public decimal cstbdf;

		/// <summary>
		/// Bill/1000Bf                     
		/// </summary>
		[SMBFieldName("bilbdf")]
		[SMBFieldDescription("Bill/1000Bf")]
		public decimal bilbdf;

	}
}