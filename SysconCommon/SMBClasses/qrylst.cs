using System;
using SysconCommon.Algebras.DataTables;

namespace SMB.Tables {
	public partial class qrylst : smbtable {
		/// <summary>
		/// Table Name                      
		/// </summary>
		[ColumnOrder(10)]
		[SMBFieldName("tblnme")]
		[SMBFieldDescription("Table Name")]
		public string tblnme;

		/// <summary>
		/// Query Name                      
		/// </summary>
		[ColumnOrder(20)]
		[SMBFieldName("qrynme")]
		[SMBFieldDescription("Query Name")]
		public string qrynme;

		/// <summary>
		/// Query Tables                    
		/// </summary>
		[ColumnOrder(30)]
		[SMBFieldName("qrytbl")]
		[SMBFieldDescription("Query Tables")]
		public string qrytbl;

		/// <summary>
		/// Query Parts                     
		/// </summary>
		[ColumnOrder(40)]
		[SMBFieldName("qryfld")]
		[SMBFieldDescription("Query Parts")]
		public string qryfld;

		/// <summary>
		/// Query Sort                      
		/// </summary>
		[ColumnOrder(50)]
		[SMBFieldName("qrysrt")]
		[SMBFieldDescription("Query Sort")]
		public string qrysrt;

		/// <summary>
		/// Query Group                     
		/// </summary>
		[ColumnOrder(60)]
		[SMBFieldName("qrygrp")]
		[SMBFieldDescription("Query Group")]
		public string qrygrp;

		/// <summary>
		/// Query Select                    
		/// </summary>
		[ColumnOrder(70)]
		[SMBFieldName("qrysel")]
		[SMBFieldDescription("Query Select")]
		public string qrysel;

		/// <summary>
		/// Query Criteria                  
		/// </summary>
		[ColumnOrder(80)]
		[SMBFieldName("qrycrt")]
		[SMBFieldDescription("Query Criteria")]
		public string qrycrt;

		/// <summary>
		/// Omware Lock                     
		/// </summary>
		[ColumnOrder(90)]
		[SMBFieldName("omwlck")]
		[SMBFieldDescription("Omware Lock")]
		public long omwlck;

	}
}