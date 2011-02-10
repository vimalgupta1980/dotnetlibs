using System;
using SysconCommon.Algebras.DataTables;

namespace SMB.Tables {
	public partial class rcccrd : smbtable {
		/// <summary>
		/// Record#                         
		/// </summary>
		[ColumnOrder(10)]
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Record#")]
		public long recnum;

		/// <summary>
		/// Card Issuer Account             
		/// </summary>
		[ColumnOrder(20)]
		[SMBFieldName("issuer")]
		[SMBFieldDescription("Card Issuer Account")]
		public long issuer;

		/// <summary>
		/// Credit Card                     
		/// </summary>
		[ColumnOrder(30)]
		[SMBFieldName("crdcrd")]
		[SMBFieldDescription("Credit Card")]
		public long crdcrd;

		/// <summary>
		/// Payee Name                      
		/// </summary>
		[ColumnOrder(40)]
		[SMBFieldName("payee1")]
		[SMBFieldDescription("Payee Name")]
		public string payee1;

		/// <summary>
		/// Next Date                       
		/// </summary>
		[ColumnOrder(50)]
		[SMBFieldName("nxtdte")]
		[SMBFieldDescription("Next Date")]
		public DateTime nxtdte;

		/// <summary>
		/// Last Posted                     
		/// </summary>
		[ColumnOrder(60)]
		[SMBFieldName("lstpst")]
		[SMBFieldDescription("Last Posted")]
		public DateTime lstpst;

		/// <summary>
		/// Description                     
		/// </summary>
		[ColumnOrder(70)]
		[SMBFieldName("dscrpt")]
		[SMBFieldDescription("Description")]
		public string dscrpt;

		/// <summary>
		/// User Defined 1                  
		/// </summary>
		[ColumnOrder(80)]
		[SMBFieldName("usrdf1")]
		[SMBFieldDescription("User Defined 1")]
		public string usrdf1;

		/// <summary>
		/// User Defined 2                  
		/// </summary>
		[ColumnOrder(90)]
		[SMBFieldName("usrdf2")]
		[SMBFieldDescription("User Defined 2")]
		public string usrdf2;

		/// <summary>
		/// Account                         
		/// </summary>
		[ColumnOrder(100)]
		[SMBFieldName("actnum")]
		[SMBFieldDescription("Account")]
		public long actnum;

		/// <summary>
		/// Subaccount                      
		/// </summary>
		[ColumnOrder(110)]
		[SMBFieldName("subact")]
		[SMBFieldDescription("Subaccount")]
		public long subact;

		/// <summary>
		/// Amount                          
		/// </summary>
		[ColumnOrder(120)]
		[SMBFieldName("amount")]
		[SMBFieldDescription("Amount")]
		public decimal amount;

		/// <summary>
		/// User Name                       
		/// </summary>
		[ColumnOrder(130)]
		[SMBFieldName("usrnme")]
		[SMBFieldDescription("User Name")]
		public string usrnme;

		/// <summary>
		/// Edited Date                     
		/// </summary>
		[ColumnOrder(140)]
		[SMBFieldName("edtdte")]
		[SMBFieldDescription("Edited Date")]
		public DateTime edtdte;

		/// <summary>
		/// Notes                           
		/// </summary>
		[ColumnOrder(150)]
		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

	}
}