using System;

namespace SMB.Tables {
	public class benfit : smbtable {
		/// <summary>
		/// Paygroup#                       
		/// </summary>
		[SMBFieldName("paygrp")]
		[SMBFieldDescription("Paygroup#")]
		public long paygrp;

		/// <summary>
		/// Calculation                     
		/// </summary>
		[SMBFieldName("dednum")]
		[SMBFieldDescription("Calculation")]
		public long dednum;

		/// <summary>
		/// Rate                            
		/// </summary>
		[SMBFieldName("dedrte")]
		[SMBFieldDescription("Rate")]
		public decimal dedrte;

	}
}