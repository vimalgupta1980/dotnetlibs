using System;

namespace SMB.Tables {
	public class schtsk : smbtable {
		/// <summary>
		/// Task#                           
		/// </summary>
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Task#")]
		public decimal recnum;

		/// <summary>
		/// Description                     
		/// </summary>
		[SMBFieldName("tsknme")]
		[SMBFieldDescription("Description")]
		public string tsknme;

		/// <summary>
		/// Task Type                       
		/// </summary>
		[SMBFieldName("tsktyp")]
		[SMBFieldDescription("Task Type")]
		public long tsktyp;

		/// <summary>
		/// Notes                           
		/// </summary>
		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

	}
}