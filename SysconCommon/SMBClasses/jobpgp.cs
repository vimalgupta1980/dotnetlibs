using System;

namespace SMB.Tables {
	public class jobpgp : smbtable {
		/// <summary>
		/// Job#                            
		/// </summary>
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Job#")]
		public long recnum;

		/// <summary>
		/// Position                        
		/// </summary>
		[SMBFieldName("reggrp")]
		[SMBFieldDescription("Position")]
		public long reggrp;

		/// <summary>
		/// Paygroup                        
		/// </summary>
		[SMBFieldName("paygrp")]
		[SMBFieldDescription("Paygroup")]
		public long paygrp;

		/// <summary>
		/// Piece Rate                      
		/// </summary>
		[SMBFieldName("pcerte")]
		[SMBFieldDescription("Piece Rate")]
		public decimal pcerte;

	}
}