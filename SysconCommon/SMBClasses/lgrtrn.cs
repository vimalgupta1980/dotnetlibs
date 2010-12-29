using System;

namespace SMB.Tables {
	public class lgrtrn : smbtable {
		/// <summary>
		/// Record#                         
		/// </summary>
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Record#")]
		public long recnum;

		/// <summary>
		/// Trans#                          
		/// </summary>
		[SMBFieldName("trnnum")]
		[SMBFieldDescription("Trans#")]
		public string trnnum;

		/// <summary>
		/// Date                            
		/// </summary>
		[SMBFieldName("trndte")]
		[SMBFieldDescription("Date")]
		public DateTime trndte;

		/// <summary>
		/// Order#                          
		/// </summary>
		[SMBFieldName("pchord")]
		[SMBFieldDescription("Order#")]
		public string pchord;

		/// <summary>
		/// Description                     
		/// </summary>
		[SMBFieldName("dscrpt")]
		[SMBFieldDescription("Description")]
		public string dscrpt;

		/// <summary>
		/// Status                          
		/// </summary>
		[SMBFieldName("status")]
		[SMBFieldDescription("Status")]
		public long status;

		/// <summary>
		/// Source                          
		/// </summary>
		[SMBFieldName("srcnum")]
		[SMBFieldDescription("Source")]
		public long srcnum;

		/// <summary>
		/// Period                          
		/// </summary>
		[SMBFieldName("actprd")]
		[SMBFieldDescription("Period")]
		public long actprd;

		/// <summary>
		/// Entry Date                      
		/// </summary>
		[SMBFieldName("entdte")]
		[SMBFieldDescription("Entry Date")]
		public DateTime entdte;

		/// <summary>
		/// Vendor                          
		/// </summary>
		[SMBFieldName("vndnum")]
		[SMBFieldDescription("Vendor")]
		public long vndnum;

		/// <summary>
		/// Payee                           
		/// </summary>
		[SMBFieldName("payee1")]
		[SMBFieldDescription("Payee")]
		public string payee1;

		/// <summary>
		/// Payee2                          
		/// </summary>
		[SMBFieldName("payee2")]
		[SMBFieldDescription("Payee2")]
		public string payee2;

		/// <summary>
		/// Address1                        
		/// </summary>
		[SMBFieldName("addrs1")]
		[SMBFieldDescription("Address1")]
		public string addrs1;

		/// <summary>
		/// Address2                        
		/// </summary>
		[SMBFieldName("addrs2")]
		[SMBFieldDescription("Address2")]
		public string addrs2;

		/// <summary>
		/// City                            
		/// </summary>
		[SMBFieldName("ctynme")]
		[SMBFieldDescription("City")]
		public string ctynme;

		/// <summary>
		/// State                           
		/// </summary>
		[SMBFieldName("state_")]
		[SMBFieldDescription("State")]
		public string state_;

		/// <summary>
		/// User Def1                       
		/// </summary>
		[SMBFieldName("usrdf1")]
		[SMBFieldDescription("User Def1")]
		public string usrdf1;

		/// <summary>
		/// User Def2                       
		/// </summary>
		[SMBFieldName("usrdf2")]
		[SMBFieldDescription("User Def2")]
		public string usrdf2;

		/// <summary>
		/// Archive Rec#                    
		/// </summary>
		[SMBFieldName("arcrec")]
		[SMBFieldDescription("Archive Rec#")]
		public long arcrec;

		/// <summary>
		/// User                            
		/// </summary>
		[SMBFieldName("usrnme")]
		[SMBFieldDescription("User")]
		public string usrnme;

		/// <summary>
		/// Ledger Ref                      
		/// </summary>
		[SMBFieldName("lgrrec")]
		[SMBFieldDescription("Ledger Ref")]
		public long lgrrec;

		/// <summary>
		/// Notes                           
		/// </summary>
		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

		/// <summary>
		/// Zip                             
		/// </summary>
		[SMBFieldName("zipcde")]
		[SMBFieldDescription("Zip")]
		public string zipcde;

		/// <summary>
		/// Amount                          
		/// </summary>
		[SMBFieldName("chkamt")]
		[SMBFieldDescription("Amount")]
		public decimal chkamt;

		/// <summary>
		/// Reconciliation in Process       
		/// </summary>
		[SMBFieldName("active")]
		[SMBFieldDescription("Reconciliation in Process")]
		public long active;

		/// <summary>
		/// Job Cost Variance               
		/// </summary>
		[SMBFieldName("jobvar")]
		[SMBFieldDescription("Job Cost Variance")]
		public decimal jobvar;

		/// <summary>
		/// Equipment Cost Variance         
		/// </summary>
		[SMBFieldName("eqpvar")]
		[SMBFieldDescription("Equipment Cost Variance")]
		public decimal eqpvar;

		/// <summary>
		/// WIP Cost Variance               
		/// </summary>
		[SMBFieldName("wipvar")]
		[SMBFieldDescription("WIP Cost Variance")]
		public decimal wipvar;

		/// <summary>
		/// Cleared Credit Card Reconcil.   
		/// </summary>
		[SMBFieldName("ccrclr")]
		[SMBFieldDescription("Cleared Credit Card Reconcil.")]
		public long ccrclr;

		/// <summary>
		/// Active in Credit Card Reconcil. 
		/// </summary>
		[SMBFieldName("ccract")]
		[SMBFieldDescription("Active in Credit Card Reconcil.")]
		public long ccract;

	}
}