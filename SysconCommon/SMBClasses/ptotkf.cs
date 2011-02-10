using System;
using SysconCommon.Algebras.DataTables;

namespace SMB.Tables {
	public partial class ptotkf : smbtable {
		/// <summary>
		/// Job#                            
		/// </summary>
		[ColumnOrder(10)]
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Job#")]
		public long recnum;

		/// <summary>
		/// Material Overhead               
		/// </summary>
		[ColumnOrder(20)]
		[SMBFieldName("matovh")]
		[SMBFieldDescription("Material Overhead")]
		public decimal matovh;

		/// <summary>
		/// Material Profit                 
		/// </summary>
		[ColumnOrder(30)]
		[SMBFieldName("matpft")]
		[SMBFieldDescription("Material Profit")]
		public decimal matpft;

		/// <summary>
		/// Labor Overhead                  
		/// </summary>
		[ColumnOrder(40)]
		[SMBFieldName("labovh")]
		[SMBFieldDescription("Labor Overhead")]
		public decimal labovh;

		/// <summary>
		/// Labor Profit                    
		/// </summary>
		[ColumnOrder(50)]
		[SMBFieldName("labpft")]
		[SMBFieldDescription("Labor Profit")]
		public decimal labpft;

		/// <summary>
		/// Equipment Overhead              
		/// </summary>
		[ColumnOrder(60)]
		[SMBFieldName("eqpovh")]
		[SMBFieldDescription("Equipment Overhead")]
		public decimal eqpovh;

		/// <summary>
		/// Equipment Profit                
		/// </summary>
		[ColumnOrder(70)]
		[SMBFieldName("eqppft")]
		[SMBFieldDescription("Equipment Profit")]
		public decimal eqppft;

		/// <summary>
		/// Subcontract Overhead            
		/// </summary>
		[ColumnOrder(80)]
		[SMBFieldName("subovh")]
		[SMBFieldDescription("Subcontract Overhead")]
		public decimal subovh;

		/// <summary>
		/// Subcontract Profit              
		/// </summary>
		[ColumnOrder(90)]
		[SMBFieldName("subpft")]
		[SMBFieldDescription("Subcontract Profit")]
		public decimal subpft;

		/// <summary>
		/// Other Overhead                  
		/// </summary>
		[ColumnOrder(100)]
		[SMBFieldName("otrovh")]
		[SMBFieldDescription("Other Overhead")]
		public decimal otrovh;

		/// <summary>
		/// Other Profit                    
		/// </summary>
		[ColumnOrder(110)]
		[SMBFieldName("otrpft")]
		[SMBFieldDescription("Other Profit")]
		public decimal otrpft;

		/// <summary>
		/// User Def Type 6  Overhead       
		/// </summary>
		[ColumnOrder(120)]
		[SMBFieldName("cs6ovh")]
		[SMBFieldDescription("User Def Type 6  Overhead")]
		public decimal cs6ovh;

		/// <summary>
		/// User Def Type 6  Profit         
		/// </summary>
		[ColumnOrder(130)]
		[SMBFieldName("cs6pft")]
		[SMBFieldDescription("User Def Type 6  Profit")]
		public decimal cs6pft;

		/// <summary>
		/// User Def Type 7  Overhead       
		/// </summary>
		[ColumnOrder(140)]
		[SMBFieldName("cs7ovh")]
		[SMBFieldDescription("User Def Type 7  Overhead")]
		public decimal cs7ovh;

		/// <summary>
		/// User Def Type 7  Profit         
		/// </summary>
		[ColumnOrder(150)]
		[SMBFieldName("cs7pft")]
		[SMBFieldDescription("User Def Type 7  Profit")]
		public decimal cs7pft;

		/// <summary>
		/// User Def Type 8  Overhead       
		/// </summary>
		[ColumnOrder(160)]
		[SMBFieldName("cs8ovh")]
		[SMBFieldDescription("User Def Type 8  Overhead")]
		public decimal cs8ovh;

		/// <summary>
		/// User Def Type 8  Profit         
		/// </summary>
		[ColumnOrder(170)]
		[SMBFieldName("cs8pft")]
		[SMBFieldDescription("User Def Type 8  Profit")]
		public decimal cs8pft;

		/// <summary>
		/// User Def Type 9  Overhead       
		/// </summary>
		[ColumnOrder(180)]
		[SMBFieldName("cs9ovh")]
		[SMBFieldDescription("User Def Type 9  Overhead")]
		public decimal cs9ovh;

		/// <summary>
		/// User Def Type 9  Profit         
		/// </summary>
		[ColumnOrder(190)]
		[SMBFieldName("cs9pft")]
		[SMBFieldDescription("User Def Type 9  Profit")]
		public decimal cs9pft;

		/// <summary>
		/// Last Edit                       
		/// </summary>
		[ColumnOrder(200)]
		[SMBFieldName("edtdte")]
		[SMBFieldDescription("Last Edit")]
		public DateTime edtdte;

		/// <summary>
		/// User                            
		/// </summary>
		[ColumnOrder(210)]
		[SMBFieldName("usrnme")]
		[SMBFieldDescription("User")]
		public string usrnme;

		/// <summary>
		/// Part Price                      
		/// </summary>
		[ColumnOrder(220)]
		[SMBFieldName("prtprc")]
		[SMBFieldDescription("Part Price")]
		public long prtprc;

		/// <summary>
		/// Payroll Subject Percent         
		/// </summary>
		[ColumnOrder(230)]
		[SMBFieldName("paysbj")]
		[SMBFieldDescription("Payroll Subject Percent")]
		public decimal paysbj;

		/// <summary>
		/// Subcontract Subject Percent     
		/// </summary>
		[ColumnOrder(240)]
		[SMBFieldName("subsbj")]
		[SMBFieldDescription("Subcontract Subject Percent")]
		public decimal subsbj;

		/// <summary>
		/// Bid Subject Percent             
		/// </summary>
		[ColumnOrder(250)]
		[SMBFieldName("bidsbj")]
		[SMBFieldDescription("Bid Subject Percent")]
		public decimal bidsbj;

		/// <summary>
		/// Tax Subject Percent             
		/// </summary>
		[ColumnOrder(260)]
		[SMBFieldName("taxsbj")]
		[SMBFieldDescription("Tax Subject Percent")]
		public decimal taxsbj;

		/// <summary>
		/// Bonding Limit 1                 
		/// </summary>
		[ColumnOrder(270)]
		[SMBFieldName("bndlt1")]
		[SMBFieldDescription("Bonding Limit 1")]
		public long bndlt1;

		/// <summary>
		/// Bonding Limit 2                 
		/// </summary>
		[ColumnOrder(280)]
		[SMBFieldName("bndlt2")]
		[SMBFieldDescription("Bonding Limit 2")]
		public long bndlt2;

		/// <summary>
		/// Bonding Limit 3                 
		/// </summary>
		[ColumnOrder(290)]
		[SMBFieldName("bndlt3")]
		[SMBFieldDescription("Bonding Limit 3")]
		public long bndlt3;

		/// <summary>
		/// Payroll Rate                    
		/// </summary>
		[ColumnOrder(300)]
		[SMBFieldName("payrte")]
		[SMBFieldDescription("Payroll Rate")]
		public decimal payrte;

		/// <summary>
		/// Subcontract Rate                
		/// </summary>
		[ColumnOrder(310)]
		[SMBFieldName("subrte")]
		[SMBFieldDescription("Subcontract Rate")]
		public decimal subrte;

		/// <summary>
		/// Bid Rate                        
		/// </summary>
		[ColumnOrder(320)]
		[SMBFieldName("bidrte")]
		[SMBFieldDescription("Bid Rate")]
		public decimal bidrte;

		/// <summary>
		/// Tax Rate                        
		/// </summary>
		[ColumnOrder(330)]
		[SMBFieldName("taxrte")]
		[SMBFieldDescription("Tax Rate")]
		public decimal taxrte;

		/// <summary>
		/// Limit 1 Rate                    
		/// </summary>
		[ColumnOrder(340)]
		[SMBFieldName("lt1rte")]
		[SMBFieldDescription("Limit 1 Rate")]
		public decimal lt1rte;

		/// <summary>
		/// Limit 2 Rate                    
		/// </summary>
		[ColumnOrder(350)]
		[SMBFieldName("lt2rte")]
		[SMBFieldDescription("Limit 2 Rate")]
		public decimal lt2rte;

		/// <summary>
		/// Limit 3 Rate                    
		/// </summary>
		[ColumnOrder(360)]
		[SMBFieldName("lt3rte")]
		[SMBFieldDescription("Limit 3 Rate")]
		public decimal lt3rte;

		/// <summary>
		/// Payroll Summary Amount          
		/// </summary>
		[ColumnOrder(370)]
		[SMBFieldName("payamt")]
		[SMBFieldDescription("Payroll Summary Amount")]
		public decimal payamt;

		/// <summary>
		/// Subcontract Summary Amount      
		/// </summary>
		[ColumnOrder(380)]
		[SMBFieldName("subamt")]
		[SMBFieldDescription("Subcontract Summary Amount")]
		public decimal subamt;

		/// <summary>
		/// Bid Summary Amount              
		/// </summary>
		[ColumnOrder(390)]
		[SMBFieldName("bidamt")]
		[SMBFieldDescription("Bid Summary Amount")]
		public decimal bidamt;

		/// <summary>
		/// Tax Summary Amount              
		/// </summary>
		[ColumnOrder(400)]
		[SMBFieldName("taxamt")]
		[SMBFieldDescription("Tax Summary Amount")]
		public decimal taxamt;

		/// <summary>
		/// Limit 1 Summary Amount          
		/// </summary>
		[ColumnOrder(410)]
		[SMBFieldName("lt1amt")]
		[SMBFieldDescription("Limit 1 Summary Amount")]
		public decimal lt1amt;

		/// <summary>
		/// Limit 2 Summary Amount          
		/// </summary>
		[ColumnOrder(420)]
		[SMBFieldName("lt2amt")]
		[SMBFieldDescription("Limit 2 Summary Amount")]
		public decimal lt2amt;

		/// <summary>
		/// Limit 3 Summary Amount          
		/// </summary>
		[ColumnOrder(430)]
		[SMBFieldName("lt3amt")]
		[SMBFieldDescription("Limit 3 Summary Amount")]
		public decimal lt3amt;

		/// <summary>
		/// Insurance Cost Type             
		/// </summary>
		[ColumnOrder(440)]
		[SMBFieldName("instyp")]
		[SMBFieldDescription("Insurance Cost Type")]
		public long instyp;

		/// <summary>
		/// Insurance Cost Code             
		/// </summary>
		[ColumnOrder(450)]
		[SMBFieldName("inscde")]
		[SMBFieldDescription("Insurance Cost Code")]
		public decimal inscde;

		/// <summary>
		/// Tax Cost Type                   
		/// </summary>
		[ColumnOrder(460)]
		[SMBFieldName("taxtyp")]
		[SMBFieldDescription("Tax Cost Type")]
		public long taxtyp;

		/// <summary>
		/// Tax Cost Code                   
		/// </summary>
		[ColumnOrder(470)]
		[SMBFieldName("taxcde")]
		[SMBFieldDescription("Tax Cost Code")]
		public decimal taxcde;

		/// <summary>
		/// Bonding Cost Type               
		/// </summary>
		[ColumnOrder(480)]
		[SMBFieldName("bndtyp")]
		[SMBFieldDescription("Bonding Cost Type")]
		public long bndtyp;

		/// <summary>
		/// Bonding Cost Code               
		/// </summary>
		[ColumnOrder(490)]
		[SMBFieldName("bndcde")]
		[SMBFieldDescription("Bonding Cost Code")]
		public decimal bndcde;

		/// <summary>
		/// Insurance Include in Budget     
		/// </summary>
		[ColumnOrder(500)]
		[SMBFieldName("insinc")]
		[SMBFieldDescription("Insurance Include in Budget")]
		public long insinc;

		/// <summary>
		/// Tax Include in Budget           
		/// </summary>
		[ColumnOrder(510)]
		[SMBFieldName("taxinc")]
		[SMBFieldDescription("Tax Include in Budget")]
		public long taxinc;

		/// <summary>
		/// Bonding Include in Budget       
		/// </summary>
		[ColumnOrder(520)]
		[SMBFieldName("bndinc")]
		[SMBFieldDescription("Bonding Include in Budget")]
		public long bndinc;

		/// <summary>
		/// Insurance Bid Item              
		/// </summary>
		[ColumnOrder(530)]
		[SMBFieldName("insitm")]
		[SMBFieldDescription("Insurance Bid Item")]
		public long insitm;

		/// <summary>
		/// Insurance Phase                 
		/// </summary>
		[ColumnOrder(540)]
		[SMBFieldName("insphs")]
		[SMBFieldDescription("Insurance Phase")]
		public long insphs;

		/// <summary>
		/// Tax Bid Item                    
		/// </summary>
		[ColumnOrder(550)]
		[SMBFieldName("taxitm")]
		[SMBFieldDescription("Tax Bid Item")]
		public long taxitm;

		/// <summary>
		/// Tax Phase                       
		/// </summary>
		[ColumnOrder(560)]
		[SMBFieldName("taxphs")]
		[SMBFieldDescription("Tax Phase")]
		public long taxphs;

		/// <summary>
		/// Bonding Bid Item                
		/// </summary>
		[ColumnOrder(570)]
		[SMBFieldName("bnditm")]
		[SMBFieldDescription("Bonding Bid Item")]
		public long bnditm;

		/// <summary>
		/// Bonding Phase                   
		/// </summary>
		[ColumnOrder(580)]
		[SMBFieldName("bndphs")]
		[SMBFieldDescription("Bonding Phase")]
		public long bndphs;

		/// <summary>
		/// Notes                           
		/// </summary>
		[ColumnOrder(590)]
		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

		/// <summary>
		/// Current Editor                  
		/// </summary>
		[ColumnOrder(600)]
		[SMBFieldName("edtnme")]
		[SMBFieldDescription("Current Editor")]
		public string edtnme;

		/// <summary>
		/// Margin/Markup Option            
		/// </summary>
		[ColumnOrder(610)]
		[SMBFieldName("mrgmrk")]
		[SMBFieldDescription("Margin/Markup Option")]
		public long mrgmrk;

		/// <summary>
		/// Gross Margin Override           
		/// </summary>
		[ColumnOrder(620)]
		[SMBFieldName("mrgovr")]
		[SMBFieldDescription("Gross Margin Override")]
		public decimal mrgovr;

		/// <summary>
		/// Markup %                        
		/// </summary>
		[ColumnOrder(630)]
		[SMBFieldName("mrkrte")]
		[SMBFieldDescription("Markup %")]
		public decimal mrkrte;

		/// <summary>
		/// Dollar Markup                   
		/// </summary>
		[ColumnOrder(640)]
		[SMBFieldName("mrkdlr")]
		[SMBFieldDescription("Dollar Markup")]
		public decimal mrkdlr;

		/// <summary>
		/// Bid Amount                      
		/// </summary>
		[ColumnOrder(650)]
		[SMBFieldName("bidovr")]
		[SMBFieldDescription("Bid Amount")]
		public decimal bidovr;

		/// <summary>
		/// Lock Bid Amount                 
		/// </summary>
		[ColumnOrder(660)]
		[SMBFieldName("lckbid")]
		[SMBFieldDescription("Lock Bid Amount")]
		public long lckbid;

		/// <summary>
		/// Work Order Exports              
		/// </summary>
		[ColumnOrder(670)]
		[SMBFieldName("wrkord")]
		[SMBFieldDescription("Work Order Exports")]
		public string wrkord;

	}
}