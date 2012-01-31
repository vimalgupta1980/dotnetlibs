using System;
using SysconCommon.Algebras.DataTables;

namespace SMB.Tables {
	public partial class aiafrm : smbtable {
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
		/// Architect                       
		/// </summary>
		[ColumnOrder(40)]
		[SMBFieldName("achnum")]
		[SMBFieldDescription("Architect")]
		public long achnum;

		/// <summary>
		/// Architect's Job#                
		/// </summary>
		[ColumnOrder(50)]
		[SMBFieldName("achjob")]
		[SMBFieldDescription("Architect's Job#")]
		public string achjob;

		/// <summary>
		/// Application#                    
		/// </summary>
		[ColumnOrder(60)]
		[SMBFieldName("appnum")]
		[SMBFieldDescription("Application#")]
		public long appnum;

		/// <summary>
		/// Billing Date                    
		/// </summary>
		[ColumnOrder(70)]
		[SMBFieldName("period")]
		[SMBFieldDescription("Billing Date")]
		public DateTime period;

		/// <summary>
		/// Primary Ret. Rate               
		/// </summary>
		[ColumnOrder(80)]
		[SMBFieldName("retain")]
		[SMBFieldDescription("Primary Ret. Rate")]
		public decimal retain;

		/// <summary>
		/// Net Prev Billings               
		/// </summary>
		[ColumnOrder(90)]
		[SMBFieldName("prvbil")]
		[SMBFieldDescription("Net Prev Billings")]
		public decimal prvbil;

		/// <summary>
		/// Prev Retention                  
		/// </summary>
		[ColumnOrder(100)]
		[SMBFieldName("prvret")]
		[SMBFieldDescription("Prev Retention")]
		public decimal prvret;

		/// <summary>
		/// Max Retention                   
		/// </summary>
		[ColumnOrder(110)]
		[SMBFieldName("maxret")]
		[SMBFieldDescription("Max Retention")]
		public decimal maxret;

		/// <summary>
		/// Description                     
		/// </summary>
		[ColumnOrder(120)]
		[SMBFieldName("dscrpt")]
		[SMBFieldDescription("Description")]
		public string dscrpt;

		/// <summary>
		/// Income Account                  
		/// </summary>
		[ColumnOrder(130)]
		[SMBFieldName("incact")]
		[SMBFieldDescription("Income Account")]
		public long incact;

		/// <summary>
		/// Subaccount                      
		/// </summary>
		[ColumnOrder(140)]
		[SMBFieldName("incsub")]
		[SMBFieldDescription("Subaccount")]
		public long incsub;

		/// <summary>
		/// Tax District                    
		/// </summary>
		[ColumnOrder(150)]
		[SMBFieldName("taxdst")]
		[SMBFieldDescription("Tax District")]
		public long taxdst;

		/// <summary>
		/// Total Scheduled                 
		/// </summary>
		[ColumnOrder(160)]
		[SMBFieldName("schttl")]
		[SMBFieldDescription("Total Scheduled")]
		public decimal schttl;

		/// <summary>
		/// Total Changes                   
		/// </summary>
		[ColumnOrder(170)]
		[SMBFieldName("chgttl")]
		[SMBFieldDescription("Total Changes")]
		public decimal chgttl;

		/// <summary>
		/// Total Contract                  
		/// </summary>
		[ColumnOrder(180)]
		[SMBFieldName("conttl")]
		[SMBFieldDescription("Total Contract")]
		public decimal conttl;

		/// <summary>
		/// Total Previous                  
		/// </summary>
		[ColumnOrder(190)]
		[SMBFieldName("prvttl")]
		[SMBFieldDescription("Total Previous")]
		public decimal prvttl;

		/// <summary>
		/// Total Current                   
		/// </summary>
		[ColumnOrder(200)]
		[SMBFieldName("curttl")]
		[SMBFieldDescription("Total Current")]
		public decimal curttl;

		/// <summary>
		/// Total Stored                    
		/// </summary>
		[ColumnOrder(210)]
		[SMBFieldName("strttl")]
		[SMBFieldDescription("Total Stored")]
		public decimal strttl;

		/// <summary>
		/// Total Comp                      
		/// </summary>
		[ColumnOrder(220)]
		[SMBFieldName("cmpttl")]
		[SMBFieldDescription("Total Comp")]
		public decimal cmpttl;

		/// <summary>
		/// % Complete                      
		/// </summary>
		[ColumnOrder(230)]
		[SMBFieldName("pctcmp")]
		[SMBFieldDescription("% Complete")]
		public decimal pctcmp;

		/// <summary>
		/// Total Balance                   
		/// </summary>
		[ColumnOrder(240)]
		[SMBFieldName("balttl")]
		[SMBFieldDescription("Total Balance")]
		public decimal balttl;

		/// <summary>
		/// Total Retention                 
		/// </summary>
		[ColumnOrder(250)]
		[SMBFieldName("retttl")]
		[SMBFieldDescription("Total Retention")]
		public decimal retttl;

		/// <summary>
		/// Total Earned                    
		/// </summary>
		[ColumnOrder(260)]
		[SMBFieldName("ttlern")]
		[SMBFieldDescription("Total Earned")]
		public decimal ttlern;

		/// <summary>
		/// Current Due                     
		/// </summary>
		[ColumnOrder(270)]
		[SMBFieldName("crtdue")]
		[SMBFieldDescription("Current Due")]
		public decimal crtdue;

		/// <summary>
		/// Contract Bal                    
		/// </summary>
		[ColumnOrder(280)]
		[SMBFieldName("balcon")]
		[SMBFieldDescription("Contract Bal")]
		public decimal balcon;

		/// <summary>
		/// Submitted                       
		/// </summary>
		[ColumnOrder(290)]
		[SMBFieldName("subdte")]
		[SMBFieldDescription("Submitted")]
		public DateTime subdte;

		/// <summary>
		/// Approved                        
		/// </summary>
		[ColumnOrder(300)]
		[SMBFieldName("appdte")]
		[SMBFieldDescription("Approved")]
		public DateTime appdte;

		/// <summary>
		/// Material Ret. Rate              
		/// </summary>
		[ColumnOrder(310)]
		[SMBFieldName("matret")]
		[SMBFieldDescription("Material Ret. Rate")]
		public decimal matret;

		/// <summary>
		/// User Def 1                      
		/// </summary>
		[ColumnOrder(320)]
		[SMBFieldName("usrdf1")]
		[SMBFieldDescription("User Def 1")]
		public string usrdf1;

		/// <summary>
		/// User Def 2                      
		/// </summary>
		[ColumnOrder(330)]
		[SMBFieldName("usrdf2")]
		[SMBFieldDescription("User Def 2")]
		public string usrdf2;

		/// <summary>
		/// Total Taxable                   
		/// </summary>
		[ColumnOrder(340)]
		[SMBFieldName("taxabl")]
		[SMBFieldDescription("Total Taxable")]
		public decimal taxabl;

		/// <summary>
		/// Total Non-Tax                   
		/// </summary>
		[ColumnOrder(350)]
		[SMBFieldName("nontax")]
		[SMBFieldDescription("Total Non-Tax")]
		public decimal nontax;

		/// <summary>
		/// Sales Tax                       
		/// </summary>
		[ColumnOrder(360)]
		[SMBFieldName("slstax")]
		[SMBFieldDescription("Sales Tax")]
		public decimal slstax;

		/// <summary>
		/// Invoice Amount                  
		/// </summary>
		[ColumnOrder(370)]
		[SMBFieldName("invttl")]
		[SMBFieldDescription("Invoice Amount")]
		public decimal invttl;

		/// <summary>
		/// Status                          
		/// </summary>
		[ColumnOrder(380)]
		[SMBFieldName("status")]
		[SMBFieldDescription("Status")]
		public long status;

		/// <summary>
		/// Billing Basis                   
		/// </summary>
		[ColumnOrder(390)]
		[SMBFieldName("bllbas")]
		[SMBFieldDescription("Billing Basis")]
		public long bllbas;

		/// <summary>
		/// Earned Less Retention           
		/// </summary>
		[ColumnOrder(400)]
		[SMBFieldName("erlsrt")]
		[SMBFieldDescription("Earned Less Retention")]
		public decimal erlsrt;

		/// <summary>
		/// Balance to Finish               
		/// </summary>
		[ColumnOrder(410)]
		[SMBFieldName("balfin")]
		[SMBFieldDescription("Balance to Finish")]
		public decimal balfin;

		/// <summary>
		/// Ledger Ref#                     
		/// </summary>
		[ColumnOrder(420)]
		[SMBFieldName("lgrrec")]
		[SMBFieldDescription("Ledger Ref#")]
		public long lgrrec;

		/// <summary>
		/// Secondary Ret. Rate             
		/// </summary>
		[ColumnOrder(430)]
		[SMBFieldName("secrte")]
		[SMBFieldDescription("Secondary Ret. Rate")]
		public decimal secrte;

		/// <summary>
		/// Primary Retention               
		/// </summary>
		[ColumnOrder(440)]
		[SMBFieldName("prmret")]
		[SMBFieldDescription("Primary Retention")]
		public decimal prmret;

		/// <summary>
		/// Retention Total                 
		/// </summary>
		[ColumnOrder(450)]
		[SMBFieldName("ttlret")]
		[SMBFieldDescription("Retention Total")]
		public decimal ttlret;

		/// <summary>
		/// Hot List                        
		/// </summary>
		[ColumnOrder(460)]
		[SMBFieldName("hotlst")]
		[SMBFieldDescription("Hot List")]
		public long hotlst;

		/// <summary>
		/// Notes                           
		/// </summary>
		[ColumnOrder(470)]
		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

		/// <summary>
		/// Summarize Phases                  
		/// </summary>
		[ColumnOrder(480)]
		[SMBFieldName("cmbphs")]
		[SMBFieldDescription("Summarize Phases")]
		public long cmbphs;

	}
}