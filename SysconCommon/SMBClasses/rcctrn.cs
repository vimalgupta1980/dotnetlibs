using System;
using SysconCommon.Algebras.DataTables;

namespace SMB.Tables {
	public partial class rcctrn : smbtable {
		/// <summary>
		/// Record#                         
		/// </summary>
		[ColumnOrder(10)]
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Record#")]
		public long recnum;

		/// <summary>
		/// Trans#                          
		/// </summary>
		[ColumnOrder(20)]
		[SMBFieldName("trnnum")]
		[SMBFieldDescription("Trans#")]
		public string trnnum;

		/// <summary>
		/// Next Date                       
		/// </summary>
		[ColumnOrder(30)]
		[SMBFieldName("trndte")]
		[SMBFieldDescription("Next Date")]
		public DateTime trndte;

		/// <summary>
		/// Description                     
		/// </summary>
		[ColumnOrder(40)]
		[SMBFieldName("dscrpt")]
		[SMBFieldDescription("Description")]
		public string dscrpt;

		/// <summary>
		/// User Def1                       
		/// </summary>
		[ColumnOrder(50)]
		[SMBFieldName("usrdf1")]
		[SMBFieldDescription("User Def1")]
		public string usrdf1;

		/// <summary>
		/// User Def2                       
		/// </summary>
		[ColumnOrder(60)]
		[SMBFieldName("usrdf2")]
		[SMBFieldDescription("User Def2")]
		public string usrdf2;

		/// <summary>
		/// Vendor#                         
		/// </summary>
		[ColumnOrder(70)]
		[SMBFieldName("vndnum")]
		[SMBFieldDescription("Vendor#")]
		public long vndnum;

		/// <summary>
		/// Payee                           
		/// </summary>
		[ColumnOrder(80)]
		[SMBFieldName("payee1")]
		[SMBFieldDescription("Payee")]
		public string payee1;

		/// <summary>
		/// Payee2                          
		/// </summary>
		[ColumnOrder(90)]
		[SMBFieldName("payee2")]
		[SMBFieldDescription("Payee2")]
		public string payee2;

		/// <summary>
		/// Address 1                       
		/// </summary>
		[ColumnOrder(100)]
		[SMBFieldName("addrs1")]
		[SMBFieldDescription("Address 1")]
		public string addrs1;

		/// <summary>
		/// Address 2                       
		/// </summary>
		[ColumnOrder(110)]
		[SMBFieldName("addrs2")]
		[SMBFieldDescription("Address 2")]
		public string addrs2;

		/// <summary>
		/// City                            
		/// </summary>
		[ColumnOrder(120)]
		[SMBFieldName("ctynme")]
		[SMBFieldDescription("City")]
		public string ctynme;

		/// <summary>
		/// State                           
		/// </summary>
		[ColumnOrder(130)]
		[SMBFieldName("state_")]
		[SMBFieldDescription("State")]
		public string state_;

		/// <summary>
		/// User                            
		/// </summary>
		[ColumnOrder(140)]
		[SMBFieldName("usrnme")]
		[SMBFieldDescription("User")]
		public string usrnme;

		/// <summary>
		/// Entered                         
		/// </summary>
		[ColumnOrder(150)]
		[SMBFieldName("entdte")]
		[SMBFieldDescription("Entered")]
		public DateTime entdte;

		/// <summary>
		/// Notes                           
		/// </summary>
		[ColumnOrder(160)]
		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

		/// <summary>
		/// Zip                             
		/// </summary>
		[ColumnOrder(170)]
		[SMBFieldName("zipcde")]
		[SMBFieldDescription("Zip")]
		public string zipcde;

	}
}