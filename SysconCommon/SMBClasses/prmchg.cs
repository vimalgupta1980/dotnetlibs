using System;
using SysconCommon.Algebras.DataTables;

namespace SMB.Tables {
	public partial class prmchg : smbtable {
		/// <summary>
		/// Record#                         
		/// </summary>
		[ColumnOrder(10)]
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Record#")]
		public long recnum;

		/// <summary>
		/// Change#                         
		/// </summary>
		[ColumnOrder(20)]
		[SMBFieldName("chgnum")]
		[SMBFieldDescription("Change#")]
		public string chgnum;

		/// <summary>
		/// Date                            
		/// </summary>
		[ColumnOrder(30)]
		[SMBFieldName("chgdte")]
		[SMBFieldDescription("Date")]
		public DateTime chgdte;

		/// <summary>
		/// Job                             
		/// </summary>
		[ColumnOrder(40)]
		[SMBFieldName("jobnum")]
		[SMBFieldDescription("Job")]
		public long jobnum;

		/// <summary>
		/// Phase                           
		/// </summary>
		[ColumnOrder(50)]
		[SMBFieldName("phsnum")]
		[SMBFieldDescription("Phase")]
		public long phsnum;

		/// <summary>
		/// Description                     
		/// </summary>
		[ColumnOrder(60)]
		[SMBFieldName("dscrpt")]
		[SMBFieldDescription("Description")]
		public string dscrpt;

		/// <summary>
		/// Reason                          
		/// </summary>
		[ColumnOrder(70)]
		[SMBFieldName("reason")]
		[SMBFieldDescription("Reason")]
		public string reason;

		/// <summary>
		/// User Def1                       
		/// </summary>
		[ColumnOrder(80)]
		[SMBFieldName("usrdf1")]
		[SMBFieldDescription("User Def1")]
		public string usrdf1;

		/// <summary>
		/// User Def2                       
		/// </summary>
		[ColumnOrder(90)]
		[SMBFieldName("usrdf2")]
		[SMBFieldDescription("User Def2")]
		public string usrdf2;

		/// <summary>
		/// Client PO#                      
		/// </summary>
		[ColumnOrder(100)]
		[SMBFieldName("pchord")]
		[SMBFieldDescription("Client PO#")]
		public string pchord;

		/// <summary>
		/// Submitted                       
		/// </summary>
		[ColumnOrder(110)]
		[SMBFieldName("subdte")]
		[SMBFieldDescription("Submitted")]
		public DateTime subdte;

		/// <summary>
		/// Approved                        
		/// </summary>
		[ColumnOrder(120)]
		[SMBFieldName("aprdte")]
		[SMBFieldDescription("Approved")]
		public DateTime aprdte;

		/// <summary>
		/// Invoiced                        
		/// </summary>
		[ColumnOrder(130)]
		[SMBFieldName("invdte")]
		[SMBFieldDescription("Invoiced")]
		public DateTime invdte;

		/// <summary>
		/// Delay Requested                 
		/// </summary>
		[ColumnOrder(140)]
		[SMBFieldName("delreq")]
		[SMBFieldDescription("Delay Requested")]
		public long delreq;

		/// <summary>
		/// Delay Approved                  
		/// </summary>
		[ColumnOrder(150)]
		[SMBFieldName("dysdly")]
		[SMBFieldDescription("Delay Approved")]
		public long dysdly;

		/// <summary>
		/// CO Type                         
		/// </summary>
		[ColumnOrder(160)]
		[SMBFieldName("chgtyp")]
		[SMBFieldDescription("CO Type")]
		public long chgtyp;

		/// <summary>
		/// Status                          
		/// </summary>
		[ColumnOrder(170)]
		[SMBFieldName("status")]
		[SMBFieldDescription("Status")]
		public long status;

		/// <summary>
		/// Submit to                       
		/// </summary>
		[ColumnOrder(180)]
		[SMBFieldName("submto")]
		[SMBFieldDescription("Submit to")]
		public string submto;

		/// <summary>
		/// Submit by                       
		/// </summary>
		[ColumnOrder(190)]
		[SMBFieldName("submby")]
		[SMBFieldDescription("Submit by")]
		public long submby;

		/// <summary>
		/// Requested Amount                
		/// </summary>
		[ColumnOrder(200)]
		[SMBFieldName("reqamt")]
		[SMBFieldDescription("Requested Amount")]
		public decimal reqamt;

		/// <summary>
		/// Approved Amount                 
		/// </summary>
		[ColumnOrder(210)]
		[SMBFieldName("appamt")]
		[SMBFieldDescription("Approved Amount")]
		public decimal appamt;

		/// <summary>
		/// Cost Amount                     
		/// </summary>
		[ColumnOrder(220)]
		[SMBFieldName("cstamt")]
		[SMBFieldDescription("Cost Amount")]
		public decimal cstamt;

		/// <summary>
		/// Overhead Amount                 
		/// </summary>
		[ColumnOrder(230)]
		[SMBFieldName("ovhamt")]
		[SMBFieldDescription("Overhead Amount")]
		public decimal ovhamt;

		/// <summary>
		/// Profit Amount                   
		/// </summary>
		[ColumnOrder(240)]
		[SMBFieldName("pftamt")]
		[SMBFieldDescription("Profit Amount")]
		public decimal pftamt;

		/// <summary>
		/// Req. Profit Amount              
		/// </summary>
		[ColumnOrder(250)]
		[SMBFieldName("reqpft")]
		[SMBFieldDescription("Req. Profit Amount")]
		public decimal reqpft;

		/// <summary>
		/// Entered                         
		/// </summary>
		[ColumnOrder(260)]
		[SMBFieldName("entdte")]
		[SMBFieldDescription("Entered")]
		public DateTime entdte;

		/// <summary>
		/// User                            
		/// </summary>
		[ColumnOrder(270)]
		[SMBFieldName("usrnme")]
		[SMBFieldDescription("User")]
		public string usrnme;

		/// <summary>
		/// Scope                           
		/// </summary>
		[ColumnOrder(280)]
		[SMBFieldName("chgscp")]
		[SMBFieldDescription("Scope")]
		public string chgscp;

		/// <summary>
		/// Hot List                        
		/// </summary>
		[ColumnOrder(290)]
		[SMBFieldName("hotlst")]
		[SMBFieldDescription("Hot List")]
		public long hotlst;

		/// <summary>
		/// Lock Edit                       
		/// </summary>
		[ColumnOrder(300)]
		[SMBFieldName("lckedt")]
		[SMBFieldDescription("Lock Edit")]
		public long lckedt;

		/// <summary>
		/// Period                          
		/// </summary>
		[ColumnOrder(310)]
		[SMBFieldName("actper")]
		[SMBFieldDescription("Period")]
		public long actper;

		/// <summary>
		/// Gross Margin                    
		/// </summary>
		[ColumnOrder(320)]
		[SMBFieldName("mrgamt")]
		[SMBFieldDescription("Gross Margin")]
		public decimal mrgamt;

		/// <summary>
		/// Req. Gross Margin               
		/// </summary>
		[ColumnOrder(330)]
		[SMBFieldName("reqmrg")]
		[SMBFieldDescription("Req. Gross Margin")]
		public decimal reqmrg;

		/// <summary>
		/// Estimated Total                 
		/// </summary>
		[ColumnOrder(340)]
		[SMBFieldName("estamt")]
		[SMBFieldDescription("Estimated Total")]
		public decimal estamt;

		/// <summary>
		/// Estimated O/H                   
		/// </summary>
		[ColumnOrder(350)]
		[SMBFieldName("estovh")]
		[SMBFieldDescription("Estimated O/H")]
		public decimal estovh;

		/// <summary>
		/// Upgrade                         
		/// </summary>
		[ColumnOrder(360)]
		[SMBFieldName("upgrde")]
		[SMBFieldDescription("Upgrade")]
		public long upgrde;

		/// <summary>
		/// Notes                           
		/// </summary>
		[ColumnOrder(370)]
		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

	}
}