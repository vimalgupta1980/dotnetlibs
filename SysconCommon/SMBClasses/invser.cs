using System;

namespace SMB.Tables {
	public class invser : smbtable {
		/// <summary>
		/// Part#                           
		/// </summary>
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Part#")]
		public long recnum;

		/// <summary>
		/// Location                        
		/// </summary>
		[SMBFieldName("locnum")]
		[SMBFieldDescription("Location")]
		public long locnum;

		/// <summary>
		/// Serial#                         
		/// </summary>
		[SMBFieldName("sernum")]
		[SMBFieldDescription("Serial#")]
		public string sernum;

		/// <summary>
		/// Stocked Date                    
		/// </summary>
		[SMBFieldName("stkdte")]
		[SMBFieldDescription("Stocked Date")]
		public DateTime stkdte;

	}
}