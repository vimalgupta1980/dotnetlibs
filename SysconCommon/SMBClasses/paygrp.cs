using System;

namespace SMB.Tables {
	public class paygrp : smbtable {
		/// <summary>
		/// Paygroup#                       
		/// </summary>
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Paygroup#")]
		public long recnum;

		/// <summary>
		/// Name                            
		/// </summary>
		[SMBFieldName("grpnme")]
		[SMBFieldDescription("Name")]
		public string grpnme;

		/// <summary>
		/// Classification                  
		/// </summary>
		[SMBFieldName("wrkcls")]
		[SMBFieldDescription("Classification")]
		public string wrkcls;

		/// <summary>
		/// Rate1                           
		/// </summary>
		[SMBFieldName("payrt1")]
		[SMBFieldDescription("Rate1")]
		public decimal payrt1;

		/// <summary>
		/// Rate2                           
		/// </summary>
		[SMBFieldName("payrt2")]
		[SMBFieldDescription("Rate2")]
		public decimal payrt2;

		/// <summary>
		/// Rate3                           
		/// </summary>
		[SMBFieldName("payrt3")]
		[SMBFieldDescription("Rate3")]
		public decimal payrt3;

		/// <summary>
		/// Piece Rate                      
		/// </summary>
		[SMBFieldName("pcerte")]
		[SMBFieldDescription("Piece Rate")]
		public decimal pcerte;

		/// <summary>
		/// Union                           
		/// </summary>
		[SMBFieldName("uninum")]
		[SMBFieldDescription("Union")]
		public long uninum;

		/// <summary>
		/// Notes                           
		/// </summary>
		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

	}
}