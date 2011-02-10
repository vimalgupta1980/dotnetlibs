using System;
using SysconCommon.Algebras.DataTables;

namespace SMB.Tables {
	public partial class paygrp : smbtable {
		/// <summary>
		/// Paygroup#                       
		/// </summary>
		[ColumnOrder(10)]
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Paygroup#")]
		public long recnum;

		/// <summary>
		/// Name                            
		/// </summary>
		[ColumnOrder(20)]
		[SMBFieldName("grpnme")]
		[SMBFieldDescription("Name")]
		public string grpnme;

		/// <summary>
		/// Classification                  
		/// </summary>
		[ColumnOrder(30)]
		[SMBFieldName("wrkcls")]
		[SMBFieldDescription("Classification")]
		public string wrkcls;

		/// <summary>
		/// Rate1                           
		/// </summary>
		[ColumnOrder(40)]
		[SMBFieldName("payrt1")]
		[SMBFieldDescription("Rate1")]
		public decimal payrt1;

		/// <summary>
		/// Rate2                           
		/// </summary>
		[ColumnOrder(50)]
		[SMBFieldName("payrt2")]
		[SMBFieldDescription("Rate2")]
		public decimal payrt2;

		/// <summary>
		/// Rate3                           
		/// </summary>
		[ColumnOrder(60)]
		[SMBFieldName("payrt3")]
		[SMBFieldDescription("Rate3")]
		public decimal payrt3;

		/// <summary>
		/// Piece Rate                      
		/// </summary>
		[ColumnOrder(70)]
		[SMBFieldName("pcerte")]
		[SMBFieldDescription("Piece Rate")]
		public decimal pcerte;

		/// <summary>
		/// Union                           
		/// </summary>
		[ColumnOrder(80)]
		[SMBFieldName("uninum")]
		[SMBFieldDescription("Union")]
		public long uninum;

		/// <summary>
		/// Notes                           
		/// </summary>
		[ColumnOrder(90)]
		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

	}
}