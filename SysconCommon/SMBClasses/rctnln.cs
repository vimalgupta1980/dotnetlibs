using System;

namespace SMB.Tables {
	public class rctnln : smbtable {
		/// <summary>
		/// Record#                         
		/// </summary>
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Record#")]
		public long recnum;

		/// <summary>
		/// Line#                           
		/// </summary>
		[SMBFieldName("linnum")]
		[SMBFieldDescription("Line#")]
		public long linnum;

		/// <summary>
		/// Description                     
		/// </summary>
		[SMBFieldName("dscrpt")]
		[SMBFieldDescription("Description")]
		public string dscrpt;

		/// <summary>
		/// Account                         
		/// </summary>
		[SMBFieldName("lgract")]
		[SMBFieldDescription("Account")]
		public long lgract;

		/// <summary>
		/// Subaccount                      
		/// </summary>
		[SMBFieldName("lgrsub")]
		[SMBFieldDescription("Subaccount")]
		public long lgrsub;

		/// <summary>
		/// Debit Amount                    
		/// </summary>
		[SMBFieldName("dbtamt")]
		[SMBFieldDescription("Debit Amount")]
		public decimal dbtamt;

		/// <summary>
		/// Credit Amount                   
		/// </summary>
		[SMBFieldName("crdamt")]
		[SMBFieldDescription("Credit Amount")]
		public decimal crdamt;

		/// <summary>
		/// User Defined                    
		/// </summary>
		[SMBFieldName("usrdf1")]
		[SMBFieldDescription("User Defined")]
		public string usrdf1;

	}
}