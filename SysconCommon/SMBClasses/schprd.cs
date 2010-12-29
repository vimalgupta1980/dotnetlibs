using System;

namespace SMB.Tables {
	public class schprd : smbtable {
		/// <summary>
		/// Record#                         
		/// </summary>
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Record#")]
		public long recnum;

		/// <summary>
		/// Phase Record                    
		/// </summary>
		[SMBFieldName("recphs")]
		[SMBFieldDescription("Phase Record")]
		public long recphs;

		/// <summary>
		/// Task#                           
		/// </summary>
		[SMBFieldName("tsknum")]
		[SMBFieldDescription("Task#")]
		public decimal tsknum;

		/// <summary>
		/// Job                             
		/// </summary>
		[SMBFieldName("jobnum")]
		[SMBFieldDescription("Job")]
		public long jobnum;

		/// <summary>
		/// Phase                           
		/// </summary>
		[SMBFieldName("phsnum")]
		[SMBFieldDescription("Phase")]
		public long phsnum;

		/// <summary>
		/// Predecessor                     
		/// </summary>
		[SMBFieldName("prdnum")]
		[SMBFieldDescription("Predecessor")]
		public decimal prdnum;

		/// <summary>
		/// Relation                        
		/// </summary>
		[SMBFieldName("reltyp")]
		[SMBFieldDescription("Relation")]
		public long reltyp;

		/// <summary>
		/// Lead/Lag                        
		/// </summary>
		[SMBFieldName("ledlag")]
		[SMBFieldDescription("Lead/Lag")]
		public long ledlag;

		/// <summary>
		/// Notes                           
		/// </summary>
		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

	}
}