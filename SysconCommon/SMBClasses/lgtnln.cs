using System;
using SysconCommon.Algebras.DataTables;

namespace SMB.Tables {
	public partial class lgtnln : smbtable {
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
		/// Description                     
		/// </summary>
		[ColumnOrder(30)]
		[SMBFieldName("dscrpt")]
		[SMBFieldDescription("Description")]
		public string dscrpt;

		/// <summary>
		/// Account                         
		/// </summary>
		[ColumnOrder(40)]
		[SMBFieldName("lgract")]
		[SMBFieldDescription("Account")]
		public long lgract;

		/// <summary>
		/// Subaccount                      
		/// </summary>
		[ColumnOrder(50)]
		[SMBFieldName("subact")]
		[SMBFieldDescription("Subaccount")]
		public long subact;

		/// <summary>
		/// Debit Amount                    
		/// </summary>
		[ColumnOrder(60)]
		[SMBFieldName("dbtamt")]
		[SMBFieldDescription("Debit Amount")]
		public decimal dbtamt;

		/// <summary>
		/// Credit Amount                   
		/// </summary>
		[ColumnOrder(70)]
		[SMBFieldName("crdamt")]
		[SMBFieldDescription("Credit Amount")]
		public decimal crdamt;

		/// <summary>
		/// User Defined                    
		/// </summary>
		[ColumnOrder(80)]
		[SMBFieldName("usrdf1")]
		[SMBFieldDescription("User Defined")]
		public string usrdf1;

	}
}