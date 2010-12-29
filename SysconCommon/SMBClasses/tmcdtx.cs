using System;

namespace SMB.Tables {
	public class tmcdtx : smbtable {
		/// <summary>
		/// Record#                         
		/// </summary>
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Record#")]
		public long recnum;

		/// <summary>
		/// Site Locale                     
		/// </summary>
		[SMBFieldName("locale")]
		[SMBFieldDescription("Site Locale")]
		public long locale;

		/// <summary>
		/// Site Wages                      
		/// </summary>
		[SMBFieldName("wgettl")]
		[SMBFieldDescription("Site Wages")]
		public decimal wgettl;

		/// <summary>
		/// Site Tax Rate                   
		/// </summary>
		[SMBFieldName("locrte")]
		[SMBFieldDescription("Site Tax Rate")]
		public decimal locrte;

		/// <summary>
		/// Site Tax                        
		/// </summary>
		[SMBFieldName("loctax")]
		[SMBFieldDescription("Site Tax")]
		public decimal loctax;

		/// <summary>
		/// Res. Locale                     
		/// </summary>
		[SMBFieldName("resloc")]
		[SMBFieldDescription("Res. Locale")]
		public long resloc;

		/// <summary>
		/// Res. Tax Rate                   
		/// </summary>
		[SMBFieldName("resrte")]
		[SMBFieldDescription("Res. Tax Rate")]
		public decimal resrte;

		/// <summary>
		/// Effective Rate                  
		/// </summary>
		[SMBFieldName("effrte")]
		[SMBFieldDescription("Effective Rate")]
		public decimal effrte;

		/// <summary>
		/// Res. Tax                        
		/// </summary>
		[SMBFieldName("restax")]
		[SMBFieldDescription("Res. Tax")]
		public decimal restax;

	}
}