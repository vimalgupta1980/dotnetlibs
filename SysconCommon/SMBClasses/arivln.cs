using System;
using SysconCommon.Algebras.DataTables;

namespace SMB.Tables {
	public partial class arivln : smbtable {
		/// <summary>
		/// Record#                         
		/// </summary>
		[ColumnOrder(10)]
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Record#")]
		public long recnum;

		/// <summary>
		/// Line#                           
		/// </summary>
		[ColumnOrder(20)]
		[SMBFieldName("linnum")]
		[SMBFieldDescription("Line#")]
		public long linnum;

		/// <summary>
		/// Part#                           
		/// </summary>
		[ColumnOrder(30)]
		[SMBFieldName("prtnum")]
		[SMBFieldDescription("Part#")]
		public long prtnum;

		/// <summary>
		/// Description                     
		/// </summary>
		[ColumnOrder(40)]
		[SMBFieldName("dscrpt")]
		[SMBFieldDescription("Description")]
		public string dscrpt;

		/// <summary>
		/// Alpha Part#                     
		/// </summary>
		[ColumnOrder(50)]
		[SMBFieldName("alpnum")]
		[SMBFieldDescription("Alpha Part#")]
		public string alpnum;

		/// <summary>
		/// Unit                            
		/// </summary>
		[ColumnOrder(60)]
		[SMBFieldName("untdsc")]
		[SMBFieldDescription("Unit")]
		public string untdsc;

		/// <summary>
		/// Quantity                        
		/// </summary>
		[ColumnOrder(70)]
		[SMBFieldName("linqty")]
		[SMBFieldDescription("Quantity")]
		public decimal linqty;

		/// <summary>
		/// Price                           
		/// </summary>
		[ColumnOrder(80)]
		[SMBFieldName("linprc")]
		[SMBFieldDescription("Price")]
		public decimal linprc;

		/// <summary>
		/// Total                           
		/// </summary>
		[ColumnOrder(90)]
		[SMBFieldName("extprc")]
		[SMBFieldDescription("Total")]
		public decimal extprc;

		/// <summary>
		/// Account                         
		/// </summary>
		[ColumnOrder(100)]
		[SMBFieldName("lgract")]
		[SMBFieldDescription("Account")]
		public long lgract;

		/// <summary>
		/// Subaccount                      
		/// </summary>
		[ColumnOrder(110)]
		[SMBFieldName("subact")]
		[SMBFieldDescription("Subaccount")]
		public long subact;

		/// <summary>
		/// Cost Code                       
		/// </summary>
		[ColumnOrder(120)]
		[SMBFieldName("cstcde")]
		[SMBFieldDescription("Cost Code")]
		public decimal cstcde;

		/// <summary>
		/// User Defined                    
		/// </summary>
		[ColumnOrder(130)]
		[SMBFieldName("usrdf1")]
		[SMBFieldDescription("User Defined")]
		public string usrdf1;

		/// <summary>
		/// Notes                           
		/// </summary>
		[ColumnOrder(140)]
		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

	}
}