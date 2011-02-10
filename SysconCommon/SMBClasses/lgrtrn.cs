using System;
using SysconCommon.Algebras.DataTables;

namespace SMB.Tables {
	public partial class lgrtrn : smbtable {
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
		/// Date                            
		/// </summary>
		[ColumnOrder(30)]
		[SMBFieldName("trndte")]
		[SMBFieldDescription("Date")]
		public DateTime trndte;

		/// <summary>
		/// Order#                          
		/// </summary>
		[ColumnOrder(40)]
		[SMBFieldName("pchord")]
		[SMBFieldDescription("Order#")]
		public string pchord;

		/// <summary>
		/// Description                     
		/// </summary>
		[ColumnOrder(50)]
		[SMBFieldName("dscrpt")]
		[SMBFieldDescription("Description")]
		public string dscrpt;

		/// <summary>
		/// Status                          
		/// </summary>
		[ColumnOrder(60)]
		[SMBFieldName("status")]
		[SMBFieldDescription("Status")]
		public long status;

		/// <summary>
		/// Source                          
		/// </summary>
		[ColumnOrder(70)]
		[SMBFieldName("srcnum")]
		[SMBFieldDescription("Source")]
		public long srcnum;

		/// <summary>
		/// Period                          
		/// </summary>
		[ColumnOrder(80)]
		[SMBFieldName("actprd")]
		[SMBFieldDescription("Period")]
		public long actprd;

		/// <summary>
		/// Entry Date                      
		/// </summary>
		[ColumnOrder(90)]
		[SMBFieldName("entdte")]
		[SMBFieldDescription("Entry Date")]
		public DateTime entdte;

		/// <summary>
		/// Vendor                          
		/// </summary>
		[ColumnOrder(100)]
		[SMBFieldName("vndnum")]
		[SMBFieldDescription("Vendor")]
		public long vndnum;

		/// <summary>
		/// Payee                           
		/// </summary>
		[ColumnOrder(110)]
		[SMBFieldName("payee1")]
		[SMBFieldDescription("Payee")]
		public string payee1;

		/// <summary>
		/// Payee2                          
		/// </summary>
		[ColumnOrder(120)]
		[SMBFieldName("payee2")]
		[SMBFieldDescription("Payee2")]
		public string payee2;

		/// <summary>
		/// Address1                        
		/// </summary>
		[ColumnOrder(130)]
		[SMBFieldName("addrs1")]
		[SMBFieldDescription("Address1")]
		public string addrs1;

		/// <summary>
		/// Address2                        
		/// </summary>
		[ColumnOrder(140)]
		[SMBFieldName("addrs2")]
		[SMBFieldDescription("Address2")]
		public string addrs2;

		/// <summary>
		/// City                            
		/// </summary>
		[ColumnOrder(150)]
		[SMBFieldName("ctynme")]
		[SMBFieldDescription("City")]
		public string ctynme;

		/// <summary>
		/// State                           
		/// </summary>
		[ColumnOrder(160)]
		[SMBFieldName("state_")]
		[SMBFieldDescription("State")]
		public string state_;

		/// <summary>
		/// User Def1                       
		/// </summary>
		[ColumnOrder(170)]
		[SMBFieldName("usrdf1")]
		[SMBFieldDescription("User Def1")]
		public string usrdf1;

		/// <summary>
		/// User Def2                       
		/// </summary>
		[ColumnOrder(180)]
		[SMBFieldName("usrdf2")]
		[SMBFieldDescription("User Def2")]
		public string usrdf2;

		/// <summary>
		/// Archive Rec#                    
		/// </summary>
		[ColumnOrder(190)]
		[SMBFieldName("arcrec")]
		[SMBFieldDescription("Archive Rec#")]
		public long arcrec;

		/// <summary>
		/// User                            
		/// </summary>
		[ColumnOrder(200)]
		[SMBFieldName("usrnme")]
		[SMBFieldDescription("User")]
		public string usrnme;

		/// <summary>
		/// Ledger Ref                      
		/// </summary>
		[ColumnOrder(210)]
		[SMBFieldName("lgrrec")]
		[SMBFieldDescription("Ledger Ref")]
		public long lgrrec;

		/// <summary>
		/// Notes                           
		/// </summary>
		[ColumnOrder(220)]
		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

		/// <summary>
		/// Zip                             
		/// </summary>
		[ColumnOrder(230)]
		[SMBFieldName("zipcde")]
		[SMBFieldDescription("Zip")]
		public string zipcde;

		/// <summary>
		/// Amount                          
		/// </summary>
		[ColumnOrder(240)]
		[SMBFieldName("chkamt")]
		[SMBFieldDescription("Amount")]
		public decimal chkamt;

		/// <summary>
		/// Reconciliation in Process       
		/// </summary>
		[ColumnOrder(250)]
		[SMBFieldName("active")]
		[SMBFieldDescription("Reconciliation in Process")]
		public long active;

		/// <summary>
		/// Job Cost Variance               
		/// </summary>
		[ColumnOrder(260)]
		[SMBFieldName("jobvar")]
		[SMBFieldDescription("Job Cost Variance")]
		public decimal jobvar;

		/// <summary>
		/// Equipment Cost Variance         
		/// </summary>
		[ColumnOrder(270)]
		[SMBFieldName("eqpvar")]
		[SMBFieldDescription("Equipment Cost Variance")]
		public decimal eqpvar;

		/// <summary>
		/// WIP Cost Variance               
		/// </summary>
		[ColumnOrder(280)]
		[SMBFieldName("wipvar")]
		[SMBFieldDescription("WIP Cost Variance")]
		public decimal wipvar;

		/// <summary>
		/// Cleared Credit Card Reconcil.   
		/// </summary>
		[ColumnOrder(290)]
		[SMBFieldName("ccrclr")]
		[SMBFieldDescription("Cleared Credit Card Reconcil.")]
		public long ccrclr;

		/// <summary>
		/// Active in Credit Card Reconcil. 
		/// </summary>
		[ColumnOrder(300)]
		[SMBFieldName("ccract")]
		[SMBFieldDescription("Active in Credit Card Reconcil.")]
		public long ccract;

	}
}