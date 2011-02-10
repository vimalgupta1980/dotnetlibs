using System;
using SysconCommon.Algebras.DataTables;

namespace SMB.Tables {
	public partial class subcon : smbtable {
		/// <summary>
		/// Record#                         
		/// </summary>
		[ColumnOrder(10)]
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Record#")]
		public long recnum;

		/// <summary>
		/// Subcontract#                    
		/// </summary>
		[ColumnOrder(20)]
		[SMBFieldName("ctcnum")]
		[SMBFieldDescription("Subcontract#")]
		public string ctcnum;

		/// <summary>
		/// Division                        
		/// </summary>
		[ColumnOrder(30)]
		[SMBFieldName("divnum")]
		[SMBFieldDescription("Division")]
		public long divnum;

		/// <summary>
		/// Vendor                          
		/// </summary>
		[ColumnOrder(40)]
		[SMBFieldName("vndnum")]
		[SMBFieldDescription("Vendor")]
		public long vndnum;

		/// <summary>
		/// Job                             
		/// </summary>
		[ColumnOrder(50)]
		[SMBFieldName("jobnum")]
		[SMBFieldDescription("Job")]
		public long jobnum;

		/// <summary>
		/// Phase                           
		/// </summary>
		[ColumnOrder(60)]
		[SMBFieldName("phsnum")]
		[SMBFieldDescription("Phase")]
		public long phsnum;

		/// <summary>
		/// Description                     
		/// </summary>
		[ColumnOrder(70)]
		[SMBFieldName("dscrpt")]
		[SMBFieldDescription("Description")]
		public string dscrpt;

		/// <summary>
		/// Tax District                    
		/// </summary>
		[ColumnOrder(80)]
		[SMBFieldName("taxdst")]
		[SMBFieldDescription("Tax District")]
		public long taxdst;

		/// <summary>
		/// User Def1                       
		/// </summary>
		[ColumnOrder(90)]
		[SMBFieldName("usrdf1")]
		[SMBFieldDescription("User Def1")]
		public string usrdf1;

		/// <summary>
		/// User Def2                       
		/// </summary>
		[ColumnOrder(100)]
		[SMBFieldName("usrdf2")]
		[SMBFieldDescription("User Def2")]
		public string usrdf2;

		/// <summary>
		/// Status                          
		/// </summary>
		[ColumnOrder(110)]
		[SMBFieldName("status")]
		[SMBFieldDescription("Status")]
		public long status;

		/// <summary>
		/// Type                            
		/// </summary>
		[ColumnOrder(120)]
		[SMBFieldName("contyp")]
		[SMBFieldDescription("Type")]
		public long contyp;

		/// <summary>
		/// Retention                       
		/// </summary>
		[ColumnOrder(130)]
		[SMBFieldName("rtnrte")]
		[SMBFieldDescription("Retention")]
		public decimal rtnrte;

		/// <summary>
		/// Bid Bond                        
		/// </summary>
		[ColumnOrder(140)]
		[SMBFieldName("pmtbnd")]
		[SMBFieldDescription("Bid Bond")]
		public decimal pmtbnd;

		/// <summary>
		/// Perf Bond                       
		/// </summary>
		[ColumnOrder(150)]
		[SMBFieldName("prfbnd")]
		[SMBFieldDescription("Perf Bond")]
		public decimal prfbnd;

		/// <summary>
		/// Approved                        
		/// </summary>
		[ColumnOrder(160)]
		[SMBFieldName("appdte")]
		[SMBFieldDescription("Approved")]
		public DateTime appdte;

		/// <summary>
		/// Contract Date                   
		/// </summary>
		[ColumnOrder(170)]
		[SMBFieldName("condte")]
		[SMBFieldDescription("Contract Date")]
		public DateTime condte;

		/// <summary>
		/// Original Start                  
		/// </summary>
		[ColumnOrder(180)]
		[SMBFieldName("orgstr")]
		[SMBFieldDescription("Original Start")]
		public DateTime orgstr;

		/// <summary>
		/// Original Finish                 
		/// </summary>
		[ColumnOrder(190)]
		[SMBFieldName("orgfin")]
		[SMBFieldDescription("Original Finish")]
		public DateTime orgfin;

		/// <summary>
		/// Actual Start                    
		/// </summary>
		[ColumnOrder(200)]
		[SMBFieldName("strdte")]
		[SMBFieldDescription("Actual Start")]
		public DateTime strdte;

		/// <summary>
		/// Subst Complete                  
		/// </summary>
		[ColumnOrder(210)]
		[SMBFieldName("subcmp")]
		[SMBFieldDescription("Subst Complete")]
		public DateTime subcmp;

		/// <summary>
		/// Finish Date                     
		/// </summary>
		[ColumnOrder(220)]
		[SMBFieldName("findte")]
		[SMBFieldDescription("Finish Date")]
		public DateTime findte;

		/// <summary>
		/// Hot List                        
		/// </summary>
		[ColumnOrder(230)]
		[SMBFieldName("hotlst")]
		[SMBFieldDescription("Hot List")]
		public long hotlst;

		/// <summary>
		/// Hold Pay                        
		/// </summary>
		[ColumnOrder(240)]
		[SMBFieldName("paysts")]
		[SMBFieldDescription("Hold Pay")]
		public long paysts;

		/// <summary>
		/// Lock Edit                       
		/// </summary>
		[ColumnOrder(250)]
		[SMBFieldName("lckedt")]
		[SMBFieldDescription("Lock Edit")]
		public long lckedt;

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
		/// Original Subcontract Total      
		/// </summary>
		[ColumnOrder(280)]
		[SMBFieldName("cntttl")]
		[SMBFieldDescription("Original Subcontract Total")]
		public decimal cntttl;

		/// <summary>
		/// Changes Total                   
		/// </summary>
		[ColumnOrder(290)]
		[SMBFieldName("chgttl")]
		[SMBFieldDescription("Changes Total")]
		public decimal chgttl;

		/// <summary>
		/// New Subcontract Total           
		/// </summary>
		[ColumnOrder(300)]
		[SMBFieldName("ctcttl")]
		[SMBFieldDescription("New Subcontract Total")]
		public decimal ctcttl;

		/// <summary>
		/// Sales Tax Total                 
		/// </summary>
		[ColumnOrder(310)]
		[SMBFieldName("taxttl")]
		[SMBFieldDescription("Sales Tax Total")]
		public decimal taxttl;

		/// <summary>
		/// Invoiced Total                  
		/// </summary>
		[ColumnOrder(320)]
		[SMBFieldName("invttl")]
		[SMBFieldDescription("Invoiced Total")]
		public decimal invttl;

		/// <summary>
		/// Remaining Total                 
		/// </summary>
		[ColumnOrder(330)]
		[SMBFieldName("balttl")]
		[SMBFieldDescription("Remaining Total")]
		public decimal balttl;

		/// <summary>
		/// Notes                           
		/// </summary>
		[ColumnOrder(340)]
		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

	}
}