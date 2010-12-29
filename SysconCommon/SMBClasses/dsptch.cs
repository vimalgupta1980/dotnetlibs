using System;

namespace SMB.Tables {
	public class dsptch : smbtable {
		/// <summary>
		/// Column#                         
		/// </summary>
		[SMBFieldName("column")]
		[SMBFieldDescription("Column#")]
		public long column;

		/// <summary>
		/// Employee                        
		/// </summary>
		[SMBFieldName("empnum")]
		[SMBFieldDescription("Employee")]
		public long empnum;

		/// <summary>
		/// Display As                      
		/// </summary>
		[SMBFieldName("disply")]
		[SMBFieldDescription("Display As")]
		public string disply;

	}
}