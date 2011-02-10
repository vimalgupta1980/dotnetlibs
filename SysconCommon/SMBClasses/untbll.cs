using System;
using SysconCommon.Algebras.DataTables;

namespace SMB.Tables {
	public partial class untbll : smbtable {
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
		/// Description                     
		/// </summary>
		[ColumnOrder(40)]
		[SMBFieldName("dscrpt")]
		[SMBFieldDescription("Description")]
		public string dscrpt;

		/// <summary>
		/// Architect                       
		/// </summary>
		[ColumnOrder(50)]
		[SMBFieldName("achnum")]
		[SMBFieldDescription("Architect")]
		public long achnum;

		/// <summary>
		/// Architect's Job#                
		/// </summary>
		[ColumnOrder(60)]
		[SMBFieldName("achjob")]
		[SMBFieldDescription("Architect's Job#")]
		public string achjob;

		/// <summary>
		/// Application#                    
		/// </summary>
		[ColumnOrder(70)]
		[SMBFieldName("appnum")]
		[SMBFieldDescription("Application#")]
		public long appnum;

		/// <summary>
		/// Billing Date                    
		/// </summary>
		[ColumnOrder(80)]
		[SMBFieldName("period")]
		[SMBFieldDescription("Billing Date")]
		public DateTime period;

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
		[SMBFieldName("appdte")]
		[SMBFieldDescription("Approved")]
		public DateTime appdte;

		/// <summary>
		/// Retention Rate                  
		/// </summary>
		[ColumnOrder(110)]
		[SMBFieldName("retain")]
		[SMBFieldDescription("Retention Rate")]
		public decimal retain;

		/// <summary>
		/// Net Prev Billings               
		/// </summary>
		[ColumnOrder(120)]
		[SMBFieldName("prvbil")]
		[SMBFieldDescription("Net Prev Billings")]
		public decimal prvbil;

		/// <summary>
		/// Prev Retention                  
		/// </summary>
		[ColumnOrder(130)]
		[SMBFieldName("prvret")]
		[SMBFieldDescription("Prev Retention")]
		public decimal prvret;

		/// <summary>
		/// Income Account                  
		/// </summary>
		[ColumnOrder(140)]
		[SMBFieldName("incact")]
		[SMBFieldDescription("Income Account")]
		public long incact;

		/// <summary>
		/// Subaccount                      
		/// </summary>
		[ColumnOrder(150)]
		[SMBFieldName("incsub")]
		[SMBFieldDescription("Subaccount")]
		public long incsub;

		/// <summary>
		/// Tax District                    
		/// </summary>
		[ColumnOrder(160)]
		[SMBFieldName("taxdst")]
		[SMBFieldDescription("Tax District")]
		public long taxdst;

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
		/// Scheduled                       
		/// </summary>
		[ColumnOrder(190)]
		[SMBFieldName("schttl")]
		[SMBFieldDescription("Scheduled")]
		public decimal schttl;

		/// <summary>
		/// Changes                         
		/// </summary>
		[ColumnOrder(200)]
		[SMBFieldName("chgttl")]
		[SMBFieldDescription("Changes")]
		public decimal chgttl;

		/// <summary>
		/// Contract                        
		/// </summary>
		[ColumnOrder(210)]
		[SMBFieldName("conttl")]
		[SMBFieldDescription("Contract")]
		public decimal conttl;

		/// <summary>
		/// Previous                        
		/// </summary>
		[ColumnOrder(220)]
		[SMBFieldName("prvttl")]
		[SMBFieldDescription("Previous")]
		public decimal prvttl;

		/// <summary>
		/// Current                         
		/// </summary>
		[ColumnOrder(230)]
		[SMBFieldName("curttl")]
		[SMBFieldDescription("Current")]
		public decimal curttl;

		/// <summary>
		/// Total                           
		/// </summary>
		[ColumnOrder(240)]
		[SMBFieldName("cmpttl")]
		[SMBFieldDescription("Total")]
		public decimal cmpttl;

		/// <summary>
		/// Balance                         
		/// </summary>
		[ColumnOrder(250)]
		[SMBFieldName("balttl")]
		[SMBFieldDescription("Balance")]
		public decimal balttl;

		/// <summary>
		/// Retention                       
		/// </summary>
		[ColumnOrder(260)]
		[SMBFieldName("retttl")]
		[SMBFieldDescription("Retention")]
		public decimal retttl;

		/// <summary>
		/// Total Earned                    
		/// </summary>
		[ColumnOrder(270)]
		[SMBFieldName("ttlern")]
		[SMBFieldDescription("Total Earned")]
		public decimal ttlern;

		/// <summary>
		/// Current Due                     
		/// </summary>
		[ColumnOrder(280)]
		[SMBFieldName("crtdue")]
		[SMBFieldDescription("Current Due")]
		public decimal crtdue;

		/// <summary>
		/// Contract Balance                
		/// </summary>
		[ColumnOrder(290)]
		[SMBFieldName("balcon")]
		[SMBFieldDescription("Contract Balance")]
		public decimal balcon;

		/// <summary>
		/// Status                          
		/// </summary>
		[ColumnOrder(300)]
		[SMBFieldName("status")]
		[SMBFieldDescription("Status")]
		public long status;

		/// <summary>
		/// Earned Less Retention           
		/// </summary>
		[ColumnOrder(310)]
		[SMBFieldName("erlsrt")]
		[SMBFieldDescription("Earned Less Retention")]
		public decimal erlsrt;

		/// <summary>
		/// Sales Tax                       
		/// </summary>
		[ColumnOrder(320)]
		[SMBFieldName("slstax")]
		[SMBFieldDescription("Sales Tax")]
		public decimal slstax;

		/// <summary>
		/// Taxable                         
		/// </summary>
		[ColumnOrder(330)]
		[SMBFieldName("taxabl")]
		[SMBFieldDescription("Taxable")]
		public decimal taxabl;

		/// <summary>
		/// Non-Taxable                     
		/// </summary>
		[ColumnOrder(340)]
		[SMBFieldName("nontax")]
		[SMBFieldDescription("Non-Taxable")]
		public decimal nontax;

		/// <summary>
		/// Invoice Total                   
		/// </summary>
		[ColumnOrder(350)]
		[SMBFieldName("invttl")]
		[SMBFieldDescription("Invoice Total")]
		public decimal invttl;

		/// <summary>
		/// Ledger Ref#                     
		/// </summary>
		[ColumnOrder(360)]
		[SMBFieldName("lgrrec")]
		[SMBFieldDescription("Ledger Ref#")]
		public decimal lgrrec;

		/// <summary>
		/// Hot List                        
		/// </summary>
		[ColumnOrder(370)]
		[SMBFieldName("hotlst")]
		[SMBFieldDescription("Hot List")]
		public long hotlst;

		/// <summary>
		/// Notes                           
		/// </summary>
		[ColumnOrder(380)]
		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

		/// <summary>
		/// Combine Phases                  
		/// </summary>
		[ColumnOrder(390)]
		[SMBFieldName("cmbphs")]
		[SMBFieldDescription("Combine Phases")]
		public long cmbphs;

	}
}