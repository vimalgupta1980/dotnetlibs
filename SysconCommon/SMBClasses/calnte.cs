using System;

namespace SMB.Tables {
	public class calnte : smbtable {
		/// <summary>
		/// Date                            
		/// </summary>
		[SMBFieldName("caldte")]
		[SMBFieldDescription("Date")]
		public DateTime caldte;

		/// <summary>
		/// Start                           
		/// </summary>
		[SMBFieldName("caltim")]
		[SMBFieldDescription("Start")]
		public DateTime caltim;

		/// <summary>
		/// End                             
		/// </summary>
		[SMBFieldName("endtim")]
		[SMBFieldDescription("End")]
		public DateTime endtim;

		/// <summary>
		/// Appt. Type                      
		/// </summary>
		[SMBFieldName("apttyp")]
		[SMBFieldDescription("Appt. Type")]
		public long apttyp;

		/// <summary>
		/// Employee                        
		/// </summary>
		[SMBFieldName("empnum")]
		[SMBFieldDescription("Employee")]
		public long empnum;

		/// <summary>
		/// Client                          
		/// </summary>
		[SMBFieldName("clnnum")]
		[SMBFieldDescription("Client")]
		public long clnnum;

		/// <summary>
		/// Notes                           
		/// </summary>
		[SMBFieldName("caltxt")]
		[SMBFieldDescription("Notes")]
		public string caltxt;

	}
}