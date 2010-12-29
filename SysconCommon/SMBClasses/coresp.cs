using System;

namespace SMB.Tables {
	public class coresp : smbtable {
		/// <summary>
		/// Record#                         
		/// </summary>
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Record#")]
		public long recnum;

		/// <summary>
		/// Job                             
		/// </summary>
		[SMBFieldName("jobnum")]
		[SMBFieldDescription("Job")]
		public long jobnum;

		/// <summary>
		/// Phase                           
		/// </summary>
		[SMBFieldName("phsnum")]
		[SMBFieldDescription("Phase")]
		public long phsnum;

		/// <summary>
		/// Division                        
		/// </summary>
		[SMBFieldName("divnum")]
		[SMBFieldDescription("Division")]
		public long divnum;

		/// <summary>
		/// Description                     
		/// </summary>
		[SMBFieldName("dscrpt")]
		[SMBFieldDescription("Description")]
		public string dscrpt;

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
		/// Client                          
		/// </summary>
		[SMBFieldName("clnnum")]
		[SMBFieldDescription("Client")]
		public long clnnum;

		/// <summary>
		/// Vendor                          
		/// </summary>
		[SMBFieldName("vndnum")]
		[SMBFieldDescription("Vendor")]
		public long vndnum;

		/// <summary>
		/// Attention                       
		/// </summary>
		[SMBFieldName("attion")]
		[SMBFieldDescription("Attention")]
		public string attion;

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
		/// Zip                             
		/// </summary>
		[SMBFieldName("zipcde")]
		[SMBFieldDescription("Zip")]
		public string zipcde;

		/// <summary>
		/// Status                          
		/// </summary>
		[SMBFieldName("status")]
		[SMBFieldDescription("Status")]
		public long status;

		/// <summary>
		/// Type                            
		/// </summary>
		[SMBFieldName("cortyp")]
		[SMBFieldDescription("Type")]
		public long cortyp;

		/// <summary>
		/// Sent                            
		/// </summary>
		[SMBFieldName("sntdte")]
		[SMBFieldDescription("Sent")]
		public DateTime sntdte;

		/// <summary>
		/// Received                        
		/// </summary>
		[SMBFieldName("recdte")]
		[SMBFieldDescription("Received")]
		public DateTime recdte;

		/// <summary>
		/// Sent by                         
		/// </summary>
		[SMBFieldName("empnum")]
		[SMBFieldDescription("Sent by")]
		public long empnum;

		/// <summary>
		/// Sent Via                        
		/// </summary>
		[SMBFieldName("sntvia")]
		[SMBFieldDescription("Sent Via")]
		public string sntvia;

		/// <summary>
		/// Text                            
		/// </summary>
		[SMBFieldName("cortxt")]
		[SMBFieldDescription("Text")]
		public string cortxt;

		/// <summary>
		/// Entered                         
		/// </summary>
		[SMBFieldName("entdte")]
		[SMBFieldDescription("Entered")]
		public DateTime entdte;

		/// <summary>
		/// User                            
		/// </summary>
		[SMBFieldName("usrnme")]
		[SMBFieldDescription("User")]
		public string usrnme;

		/// <summary>
		/// Hot List                        
		/// </summary>
		[SMBFieldName("hotlst")]
		[SMBFieldDescription("Hot List")]
		public long hotlst;

		/// <summary>
		/// Lock Edit                       
		/// </summary>
		[SMBFieldName("lckedt")]
		[SMBFieldDescription("Lock Edit")]
		public long lckedt;

		/// <summary>
		/// Notes                           
		/// </summary>
		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

	}
}