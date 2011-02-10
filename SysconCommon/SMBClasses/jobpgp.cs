using System;
using SysconCommon.Algebras.DataTables;

namespace SMB.Tables {
	public partial class jobpgp : smbtable {
		/// <summary>
		/// Job#                            
		/// </summary>
		[ColumnOrder(10)]
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Job#")]
		public long recnum;

		/// <summary>
		/// Position                        
		/// </summary>
		[ColumnOrder(20)]
		[SMBFieldName("reggrp")]
		[SMBFieldDescription("Position")]
		public long reggrp;

		/// <summary>
		/// Paygroup                        
		/// </summary>
		[ColumnOrder(30)]
		[SMBFieldName("paygrp")]
		[SMBFieldDescription("Paygroup")]
		public long paygrp;

		/// <summary>
		/// Piece Rate                      
		/// </summary>
		[ColumnOrder(40)]
		[SMBFieldName("pcerte")]
		[SMBFieldDescription("Piece Rate")]
		public decimal pcerte;

	}
}