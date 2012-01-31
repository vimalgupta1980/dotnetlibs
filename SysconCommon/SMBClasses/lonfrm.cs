using System;
using SysconCommon.Algebras.DataTables;

namespace SMB.Tables {
	public partial class lonfrm : smbtable {
		/// <summary>
		/// Record#                         
		/// </summary>
		[ColumnOrder(10)]
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Record#")]
		public long recnum;

		/// <summary>
		/// Job                             
		/// </summary>
		[ColumnOrder(20)]
		[SMBFieldName("jobnum")]
		[SMBFieldDescription("Job")]
		public long jobnum;

		/// <summary>
		/// Phase                           
		/// </summary>
		[ColumnOrder(30)]
		[SMBFieldName("phsnum")]
		[SMBFieldDescription("Phase")]
		public long phsnum;

		/// <summary>
		/// Lender                          
		/// </summary>
		[ColumnOrder(40)]
		[SMBFieldName("lndnum")]
		[SMBFieldDescription("Lender")]
		public long lndnum;

		/// <summary>
		/// Loan#                           
		/// </summary>
		[ColumnOrder(50)]
		[SMBFieldName("lonnum")]
		[SMBFieldDescription("Loan#")]
		public string lonnum;

		/// <summary>
		/// Application#                    
		/// </summary>
		[ColumnOrder(60)]
		[SMBFieldName("crtnum")]
		[SMBFieldDescription("Application#")]
		public long crtnum;

		/// <summary>
		/// Billing Date                    
		/// </summary>
		[ColumnOrder(70)]
		[SMBFieldName("period")]
		[SMBFieldDescription("Billing Date")]
		public DateTime period;

		/// <summary>
		/// Description                     
		/// </summary>
		[ColumnOrder(80)]
		[SMBFieldName("dscrpt")]
		[SMBFieldDescription("Description")]
		public string dscrpt;

		/// <summary>
		/// Submitted                       
		/// </summary>
		[ColumnOrder(90)]
		[SMBFieldName("subdte")]
		[SMBFieldDescription("Submitted")]
		public DateTime subdte;

		/// <summary>
		/// Approved                        
		/// </summary>
		[ColumnOrder(100)]
		[SMBFieldName("aprdte")]
		[SMBFieldDescription("Approved")]
		public DateTime aprdte;

		/// <summary>
		/// User Def1                       
		/// </summary>
		[ColumnOrder(110)]
		[SMBFieldName("usrdf1")]
		[SMBFieldDescription("User Def1")]
		public string usrdf1;

		/// <summary>
		/// User Def2                       
		/// </summary>
		[ColumnOrder(120)]
		[SMBFieldName("usrdf2")]
		[SMBFieldDescription("User Def2")]
		public string usrdf2;

		/// <summary>
		/// Scheduled                       
		/// </summary>
		[ColumnOrder(130)]
		[SMBFieldName("schamt")]
		[SMBFieldDescription("Scheduled")]
		public decimal schamt;

		/// <summary>
		/// Changes                         
		/// </summary>
		[ColumnOrder(140)]
		[SMBFieldName("chgdte")]
		[SMBFieldDescription("Changes")]
		public decimal chgdte;

		/// <summary>
		/// Contract                        
		/// </summary>
		[ColumnOrder(150)]
		[SMBFieldName("ctcamt")]
		[SMBFieldDescription("Contract")]
		public decimal ctcamt;

		/// <summary>
		/// Previous                        
		/// </summary>
		[ColumnOrder(160)]
		[SMBFieldName("prvamt")]
		[SMBFieldDescription("Previous")]
		public decimal prvamt;

		/// <summary>
		/// Current                         
		/// </summary>
		[ColumnOrder(170)]
		[SMBFieldName("curamt")]
		[SMBFieldDescription("Current")]
		public decimal curamt;

		/// <summary>
		/// % Complete                      
		/// </summary>
		[ColumnOrder(180)]
		[SMBFieldName("pctcmp")]
		[SMBFieldDescription("% Complete")]
		public decimal pctcmp;

		/// <summary>
		/// Total                           
		/// </summary>
		[ColumnOrder(190)]
		[SMBFieldName("ttlcmp")]
		[SMBFieldDescription("Total")]
		public decimal ttlcmp;

		/// <summary>
		/// Balance                         
		/// </summary>
		[ColumnOrder(200)]
		[SMBFieldName("balnce")]
		[SMBFieldDescription("Balance")]
		public decimal balnce;

		/// <summary>
		/// To Complete                     
		/// </summary>
		[ColumnOrder(210)]
		[SMBFieldName("tocomp")]
		[SMBFieldDescription("To Complete")]
		public decimal tocomp;

		/// <summary>
		/// Status                          
		/// </summary>
		[ColumnOrder(220)]
		[SMBFieldName("status")]
		[SMBFieldDescription("Status")]
		public long status;

		/// <summary>
		/// Hot List                        
		/// </summary>
		[ColumnOrder(230)]
		[SMBFieldName("hotlst")]
		[SMBFieldDescription("Hot List")]
		public long hotlst;

		/// <summary>
		/// Notes                           
		/// </summary>
		[ColumnOrder(240)]
		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

		/// <summary>
		/// Summarize Phases                  
		/// </summary>
		[ColumnOrder(250)]
		[SMBFieldName("cmbphs")]
		[SMBFieldDescription("Summarize Phases")]
		public long cmbphs;

	}
}