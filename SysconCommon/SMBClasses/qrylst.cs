using System;

namespace SMB.Tables {
	public class qrylst : smbtable {
		/// <summary>
		/// Table Name                      
		/// </summary>
		[SMBFieldName("tblnme")]
		[SMBFieldDescription("Table Name")]
		public string tblnme;

		/// <summary>
		/// Query Name                      
		/// </summary>
		[SMBFieldName("qrynme")]
		[SMBFieldDescription("Query Name")]
		public string qrynme;

		/// <summary>
		/// Query Tables                    
		/// </summary>
		[SMBFieldName("qrytbl")]
		[SMBFieldDescription("Query Tables")]
		public string qrytbl;

		/// <summary>
		/// Query Parts                     
		/// </summary>
		[SMBFieldName("qryfld")]
		[SMBFieldDescription("Query Parts")]
		public string qryfld;

		/// <summary>
		/// Query Sort                      
		/// </summary>
		[SMBFieldName("qrysrt")]
		[SMBFieldDescription("Query Sort")]
		public string qrysrt;

		/// <summary>
		/// Query Group                     
		/// </summary>
		[SMBFieldName("qrygrp")]
		[SMBFieldDescription("Query Group")]
		public string qrygrp;

		/// <summary>
		/// Query Select                    
		/// </summary>
		[SMBFieldName("qrysel")]
		[SMBFieldDescription("Query Select")]
		public string qrysel;

		/// <summary>
		/// Query Criteria                  
		/// </summary>
		[SMBFieldName("qrycrt")]
		[SMBFieldDescription("Query Criteria")]
		public string qrycrt;

		/// <summary>
		/// Omware Lock                     
		/// </summary>
		[SMBFieldName("omwlck")]
		[SMBFieldDescription("Omware Lock")]
		public long omwlck;

	}
}