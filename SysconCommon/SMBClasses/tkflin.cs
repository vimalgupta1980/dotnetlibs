using System;

namespace SMB.Tables {
	public class tkflin : smbtable {
		/// <summary>
		/// Job#                            
		/// </summary>
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Job#")]
		public long recnum;

		/// <summary>
		/// Bid Item#                       
		/// </summary>
		[SMBFieldName("itmnum")]
		[SMBFieldDescription("Bid Item#")]
		public long itmnum;

		/// <summary>
		/// Phase#                          
		/// </summary>
		[SMBFieldName("phsnum")]
		[SMBFieldDescription("Phase#")]
		public long phsnum;

		/// <summary>
		/// Line#                           
		/// </summary>
		[SMBFieldName("linnum")]
		[SMBFieldDescription("Line#")]
		public long linnum;

		/// <summary>
		/// Assembly#                       
		/// </summary>
		[SMBFieldName("asmnum")]
		[SMBFieldDescription("Assembly#")]
		public long asmnum;

		/// <summary>
		///                                 
		/// </summary>
		[SMBFieldName("asmchk")]
		[SMBFieldDescription("")]
		public long asmchk;

		/// <summary>
		/// Part#                           
		/// </summary>
		[SMBFieldName("prtnum")]
		[SMBFieldDescription("Part#")]
		public long prtnum;

		/// <summary>
		/// Description                     
		/// </summary>
		[SMBFieldName("prtdsc")]
		[SMBFieldDescription("Description")]
		public string prtdsc;

		/// <summary>
		/// Alpha Part#                     
		/// </summary>
		[SMBFieldName("alpnum")]
		[SMBFieldDescription("Alpha Part#")]
		public string alpnum;

		/// <summary>
		/// Unit                            
		/// </summary>
		[SMBFieldName("untdsc")]
		[SMBFieldDescription("Unit")]
		public string untdsc;

		/// <summary>
		/// Quantity                        
		/// </summary>
		[SMBFieldName("linqty")]
		[SMBFieldDescription("Quantity")]
		public decimal linqty;

		/// <summary>
		/// Cost                            
		/// </summary>
		[SMBFieldName("linprc")]
		[SMBFieldDescription("Cost")]
		public decimal linprc;

		/// <summary>
		///                                 
		/// </summary>
		[SMBFieldName("linlck")]
		[SMBFieldDescription("")]
		public bool linlck;

		/// <summary>
		/// Formula                         
		/// </summary>
		[SMBFieldName("qtyfrm")]
		[SMBFieldDescription("Formula")]
		public string qtyfrm;

		/// <summary>
		/// Ext Quantity                    
		/// </summary>
		[SMBFieldName("extqty")]
		[SMBFieldDescription("Ext Quantity")]
		public decimal extqty;

		/// <summary>
		/// Ext Cost                        
		/// </summary>
		[SMBFieldName("extttl")]
		[SMBFieldDescription("Ext Cost")]
		public decimal extttl;

		/// <summary>
		/// Tax District                    
		/// </summary>
		[SMBFieldName("taxdst")]
		[SMBFieldDescription("Tax District")]
		public long taxdst;

		/// <summary>
		/// Sales Tax                       
		/// </summary>
		[SMBFieldName("slstax")]
		[SMBFieldDescription("Sales Tax")]
		public decimal slstax;

		/// <summary>
		/// O/H Rate                        
		/// </summary>
		[SMBFieldName("ovhmrk")]
		[SMBFieldDescription("O/H Rate")]
		public decimal ovhmrk;

		/// <summary>
		/// Overhead                        
		/// </summary>
		[SMBFieldName("ovhamt")]
		[SMBFieldDescription("Overhead")]
		public decimal ovhamt;

		/// <summary>
		/// Profit Rate                     
		/// </summary>
		[SMBFieldName("pftmrk")]
		[SMBFieldDescription("Profit Rate")]
		public decimal pftmrk;

		/// <summary>
		/// Profit                          
		/// </summary>
		[SMBFieldName("pftamt")]
		[SMBFieldDescription("Profit")]
		public decimal pftamt;

		/// <summary>
		/// Ext Price                       
		/// </summary>
		[SMBFieldName("bidprc")]
		[SMBFieldDescription("Ext Price")]
		public decimal bidprc;

		/// <summary>
		/// Vendor                          
		/// </summary>
		[SMBFieldName("prmvnd")]
		[SMBFieldDescription("Vendor")]
		public long prmvnd;

		/// <summary>
		/// Cost Code                       
		/// </summary>
		[SMBFieldName("cstcde")]
		[SMBFieldDescription("Cost Code")]
		public decimal cstcde;

		/// <summary>
		/// Cost Type                       
		/// </summary>
		[SMBFieldName("csttyp")]
		[SMBFieldDescription("Cost Type")]
		public long csttyp;

		/// <summary>
		/// Task                            
		/// </summary>
		[SMBFieldName("tsknum")]
		[SMBFieldDescription("Task")]
		public decimal tsknum;

		/// <summary>
		/// Inventory Location              
		/// </summary>
		[SMBFieldName("invloc")]
		[SMBFieldDescription("Inventory Location")]
		public long invloc;

		/// <summary>
		/// User Defined                    
		/// </summary>
		[SMBFieldName("usrdf1")]
		[SMBFieldDescription("User Defined")]
		public string usrdf1;

		/// <summary>
		/// Notes                           
		/// </summary>
		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

		/// <summary>
		/// Export Notes                    
		/// </summary>
		[SMBFieldName("expnte")]
		[SMBFieldDescription("Export Notes")]
		public string expnte;

	}
}