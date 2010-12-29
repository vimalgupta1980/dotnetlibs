using System;

namespace SMB.Tables {
	public class empqtd : smbtable {
		/// <summary>
		/// Employee#                       
		/// </summary>
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Employee#")]
		public long recnum;

		/// <summary>
		/// Calculation                     
		/// </summary>
		[SMBFieldName("clcnum")]
		[SMBFieldDescription("Calculation")]
		public long clcnum;

		/// <summary>
		/// Rate                            
		/// </summary>
		[SMBFieldName("dedrte")]
		[SMBFieldDescription("Rate")]
		public decimal dedrte;

		/// <summary>
		/// Maximum                         
		/// </summary>
		[SMBFieldName("dedmax")]
		[SMBFieldDescription("Maximum")]
		public decimal dedmax;

		/// <summary>
		/// Marital                         
		/// </summary>
		[SMBFieldName("mrtsts")]
		[SMBFieldDescription("Marital")]
		public long mrtsts;

		/// <summary>
		/// Std Allow                       
		/// </summary>
		[SMBFieldName("allows")]
		[SMBFieldDescription("Std Allow")]
		public long allows;

		/// <summary>
		/// Add Allow                       
		/// </summary>
		[SMBFieldName("addall")]
		[SMBFieldDescription("Add Allow")]
		public long addall;

		/// <summary>
		/// Table#                          
		/// </summary>
		[SMBFieldName("tblnum")]
		[SMBFieldDescription("Table#")]
		public long tblnum;

		/// <summary>
		/// Add W/H                         
		/// </summary>
		[SMBFieldName("addste")]
		[SMBFieldDescription("Add W/H")]
		public decimal addste;

		/// <summary>
		/// Offset                          
		/// </summary>
		[SMBFieldName("offset")]
		[SMBFieldDescription("Offset")]
		public decimal offset;

		/// <summary>
		/// Quarter 1                       
		/// </summary>
		[SMBFieldName("fstqtr")]
		[SMBFieldDescription("Quarter 1")]
		public decimal fstqtr;

		/// <summary>
		/// Quarter 2                       
		/// </summary>
		[SMBFieldName("scdqtr")]
		[SMBFieldDescription("Quarter 2")]
		public decimal scdqtr;

		/// <summary>
		/// Quarter 3                       
		/// </summary>
		[SMBFieldName("thdqtr")]
		[SMBFieldDescription("Quarter 3")]
		public decimal thdqtr;

		/// <summary>
		/// Quarter 4                       
		/// </summary>
		[SMBFieldName("fthqtr")]
		[SMBFieldDescription("Quarter 4")]
		public decimal fthqtr;

	}
}