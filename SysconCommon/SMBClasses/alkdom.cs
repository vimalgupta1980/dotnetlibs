using System;
using SysconCommon.Algebras.DataTables;

namespace SMB.Tables {
	public partial class alkdom : smbtable {
		/// <summary>
		/// Employee#                       
		/// </summary>
		[ColumnOrder(10)]
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Employee#")]
		public long recnum;

		/// <summary>
		/// Address 1                       
		/// </summary>
		[ColumnOrder(20)]
		[SMBFieldName("addrss")]
		[SMBFieldDescription("Address 1")]
		public string addrss;

		/// <summary>
		/// Address 2                       
		/// </summary>
		[ColumnOrder(30)]
		[SMBFieldName("addrs2")]
		[SMBFieldDescription("Address 2")]
		public string addrs2;

		/// <summary>
		/// City                            
		/// </summary>
		[ColumnOrder(40)]
		[SMBFieldName("ctynme")]
		[SMBFieldDescription("City")]
		public string ctynme;

		/// <summary>
		/// State                           
		/// </summary>
		[ColumnOrder(50)]
		[SMBFieldName("state_")]
		[SMBFieldDescription("State")]
		public string state_;

		/// <summary>
		/// Zip                             
		/// </summary>
		[ColumnOrder(60)]
		[SMBFieldName("zipcde")]
		[SMBFieldDescription("Zip")]
		public string zipcde;

		/// <summary>
		/// Certificate#                    
		/// </summary>
		[ColumnOrder(70)]
		[SMBFieldName("crtnum")]
		[SMBFieldDescription("Certificate#")]
		public string crtnum;

		/// <summary>
		/// Apprentice%                     
		/// </summary>
		[ColumnOrder(80)]
		[SMBFieldName("apprte")]
		[SMBFieldDescription("Apprentice%")]
		public decimal apprte;

		/// <summary>
		/// Bargaining                      
		/// </summary>
		[ColumnOrder(90)]
		[SMBFieldName("brgagr")]
		[SMBFieldDescription("Bargaining")]
		public string brgagr;

		/// <summary>
		/// Occupation                      
		/// </summary>
		[ColumnOrder(100)]
		[SMBFieldName("occnum")]
		[SMBFieldDescription("Occupation")]
		public string occnum;

		/// <summary>
		/// Area                            
		/// </summary>
		[ColumnOrder(110)]
		[SMBFieldName("arecde")]
		[SMBFieldDescription("Area")]
		public string arecde;

		/// <summary>
		/// License#                        
		/// </summary>
		[ColumnOrder(120)]
		[SMBFieldName("licnum")]
		[SMBFieldDescription("License#")]
		public string licnum;

	}
}