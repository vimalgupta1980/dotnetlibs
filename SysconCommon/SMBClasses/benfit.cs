using System;
using SysconCommon.Algebras.DataTables;

namespace SMB.Tables {
	public partial class benfit : smbtable {
		/// <summary>
		/// Paygroup#                       
		/// </summary>
		[ColumnOrder(10)]
		[SMBFieldName("paygrp")]
		[SMBFieldDescription("Paygroup#")]
		public long paygrp;

		/// <summary>
		/// Calculation                     
		/// </summary>
		[ColumnOrder(20)]
		[SMBFieldName("dednum")]
		[SMBFieldDescription("Calculation")]
		public long dednum;

		/// <summary>
		/// Rate                            
		/// </summary>
		[ColumnOrder(30)]
		[SMBFieldName("dedrte")]
		[SMBFieldDescription("Rate")]
		public decimal dedrte;

	}
}