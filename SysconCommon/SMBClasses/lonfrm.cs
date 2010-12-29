using System;

namespace SMB.Tables {
	public class lonfrm : smbtable {
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
		/// Lender                          
		/// </summary>
		[SMBFieldName("lndnum")]
		[SMBFieldDescription("Lender")]
		public long lndnum;

		/// <summary>
		/// Loan#                           
		/// </summary>
		[SMBFieldName("lonnum")]
		[SMBFieldDescription("Loan#")]
		public string lonnum;

		/// <summary>
		/// Application#                    
		/// </summary>
		[SMBFieldName("crtnum")]
		[SMBFieldDescription("Application#")]
		public long crtnum;

		/// <summary>
		/// Billing Date                    
		/// </summary>
		[SMBFieldName("period")]
		[SMBFieldDescription("Billing Date")]
		public DateTime period;

		/// <summary>
		/// Description                     
		/// </summary>
		[SMBFieldName("dscrpt")]
		[SMBFieldDescription("Description")]
		public string dscrpt;

		/// <summary>
		/// Submitted                       
		/// </summary>
		[SMBFieldName("subdte")]
		[SMBFieldDescription("Submitted")]
		public DateTime subdte;

		/// <summary>
		/// Approved                        
		/// </summary>
		[SMBFieldName("aprdte")]
		[SMBFieldDescription("Approved")]
		public DateTime aprdte;

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
		/// Scheduled                       
		/// </summary>
		[SMBFieldName("schamt")]
		[SMBFieldDescription("Scheduled")]
		public decimal schamt;

		/// <summary>
		/// Changes                         
		/// </summary>
		[SMBFieldName("chgdte")]
		[SMBFieldDescription("Changes")]
		public decimal chgdte;

		/// <summary>
		/// Contract                        
		/// </summary>
		[SMBFieldName("ctcamt")]
		[SMBFieldDescription("Contract")]
		public decimal ctcamt;

		/// <summary>
		/// Previous                        
		/// </summary>
		[SMBFieldName("prvamt")]
		[SMBFieldDescription("Previous")]
		public decimal prvamt;

		/// <summary>
		/// Current                         
		/// </summary>
		[SMBFieldName("curamt")]
		[SMBFieldDescription("Current")]
		public decimal curamt;

		/// <summary>
		/// % Complete                      
		/// </summary>
		[SMBFieldName("pctcmp")]
		[SMBFieldDescription("% Complete")]
		public decimal pctcmp;

		/// <summary>
		/// Total                           
		/// </summary>
		[SMBFieldName("ttlcmp")]
		[SMBFieldDescription("Total")]
		public decimal ttlcmp;

		/// <summary>
		/// Balance                         
		/// </summary>
		[SMBFieldName("balnce")]
		[SMBFieldDescription("Balance")]
		public decimal balnce;

		/// <summary>
		/// To Complete                     
		/// </summary>
		[SMBFieldName("tocomp")]
		[SMBFieldDescription("To Complete")]
		public decimal tocomp;

		/// <summary>
		/// Status                          
		/// </summary>
		[SMBFieldName("status")]
		[SMBFieldDescription("Status")]
		public long status;

		/// <summary>
		/// Hot List                        
		/// </summary>
		[SMBFieldName("hotlst")]
		[SMBFieldDescription("Hot List")]
		public long hotlst;

		/// <summary>
		/// Notes                           
		/// </summary>
		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

		/// <summary>
		/// Combine Phases                  
		/// </summary>
		[SMBFieldName("cmbphs")]
		[SMBFieldDescription("Combine Phases")]
		public long cmbphs;

	}
}