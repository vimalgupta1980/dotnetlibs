using System;
using SysconCommon.Algebras.DataTables;

namespace SMB.Tables {
	public partial class tkflin : smbtable {
		/// <summary>
		/// Job#                            
		/// </summary>
		[ColumnOrder(10)]
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Job#")]
		public long recnum;

		/// <summary>
		/// Bid Item#                       
		/// </summary>
		[ColumnOrder(20)]
		[SMBFieldName("itmnum")]
		[SMBFieldDescription("Bid Item#")]
		public long itmnum;

		/// <summary>
		/// Phase#                          
		/// </summary>
		[ColumnOrder(30)]
		[SMBFieldName("phsnum")]
		[SMBFieldDescription("Phase#")]
		public long phsnum;

		/// <summary>
		/// Line#                           
		/// </summary>
		[ColumnOrder(40)]
		[SMBFieldName("linnum")]
		[SMBFieldDescription("Line#")]
		public long linnum;

		/// <summary>
		/// Assembly#                       
		/// </summary>
		[ColumnOrder(50)]
		[SMBFieldName("asmnum")]
		[SMBFieldDescription("Assembly#")]
		public long asmnum;

		/// <summary>
		///                                 
		/// </summary>
		[ColumnOrder(60)]
		[SMBFieldName("asmchk")]
		[SMBFieldDescription("")]
		public long asmchk;

		/// <summary>
		/// Part#                           
		/// </summary>
		[ColumnOrder(70)]
		[SMBFieldName("prtnum")]
		[SMBFieldDescription("Part#")]
		public long prtnum;

		/// <summary>
		/// Description                     
		/// </summary>
		[ColumnOrder(80)]
		[SMBFieldName("prtdsc")]
		[SMBFieldDescription("Description")]
		public string prtdsc;

		/// <summary>
		/// Alpha Part#                     
		/// </summary>
		[ColumnOrder(90)]
		[SMBFieldName("alpnum")]
		[SMBFieldDescription("Alpha Part#")]
		public string alpnum;

		/// <summary>
		/// Unit                            
		/// </summary>
		[ColumnOrder(100)]
		[SMBFieldName("untdsc")]
		[SMBFieldDescription("Unit")]
		public string untdsc;

		/// <summary>
		/// Quantity                        
		/// </summary>
		[ColumnOrder(110)]
		[SMBFieldName("linqty")]
		[SMBFieldDescription("Quantity")]
		public decimal linqty;

		/// <summary>
		/// Cost                            
		/// </summary>
		[ColumnOrder(120)]
		[SMBFieldName("linprc")]
		[SMBFieldDescription("Cost")]
		public decimal linprc;

		/// <summary>
		///                                 
		/// </summary>
		[ColumnOrder(130)]
		[SMBFieldName("linlck")]
		[SMBFieldDescription("")]
		public bool linlck;

		/// <summary>
		/// Formula                         
		/// </summary>
		[ColumnOrder(140)]
		[SMBFieldName("qtyfrm")]
		[SMBFieldDescription("Formula")]
		public string qtyfrm;

		/// <summary>
		/// Ext Quantity                    
		/// </summary>
		[ColumnOrder(150)]
		[SMBFieldName("extqty")]
		[SMBFieldDescription("Ext Quantity")]
		public decimal extqty;

		/// <summary>
		/// Ext Cost                        
		/// </summary>
		[ColumnOrder(160)]
		[SMBFieldName("extttl")]
		[SMBFieldDescription("Ext Cost")]
		public decimal extttl;

		/// <summary>
		/// Tax District                    
		/// </summary>
		[ColumnOrder(170)]
		[SMBFieldName("taxdst")]
		[SMBFieldDescription("Tax District")]
		public long taxdst;

		/// <summary>
		/// Sales Tax                       
		/// </summary>
		[ColumnOrder(180)]
		[SMBFieldName("slstax")]
		[SMBFieldDescription("Sales Tax")]
		public decimal slstax;

		/// <summary>
		/// O/H Rate                        
		/// </summary>
		[ColumnOrder(190)]
		[SMBFieldName("ovhmrk")]
		[SMBFieldDescription("O/H Rate")]
		public decimal ovhmrk;

		/// <summary>
		/// Overhead                        
		/// </summary>
		[ColumnOrder(200)]
		[SMBFieldName("ovhamt")]
		[SMBFieldDescription("Overhead")]
		public decimal ovhamt;

		/// <summary>
		/// Profit Rate                     
		/// </summary>
		[ColumnOrder(210)]
		[SMBFieldName("pftmrk")]
		[SMBFieldDescription("Profit Rate")]
		public decimal pftmrk;

		/// <summary>
		/// Profit                          
		/// </summary>
		[ColumnOrder(220)]
		[SMBFieldName("pftamt")]
		[SMBFieldDescription("Profit")]
		public decimal pftamt;

		/// <summary>
		/// Ext Price                       
		/// </summary>
		[ColumnOrder(230)]
		[SMBFieldName("bidprc")]
		[SMBFieldDescription("Ext Price")]
		public decimal bidprc;

		/// <summary>
		/// Vendor                          
		/// </summary>
		[ColumnOrder(240)]
		[SMBFieldName("prmvnd")]
		[SMBFieldDescription("Vendor")]
		public long prmvnd;

		/// <summary>
		/// Cost Code                       
		/// </summary>
		[ColumnOrder(250)]
		[SMBFieldName("cstcde")]
		[SMBFieldDescription("Cost Code")]
		public decimal cstcde;

		/// <summary>
		/// Cost Type                       
		/// </summary>
		[ColumnOrder(260)]
		[SMBFieldName("csttyp")]
		[SMBFieldDescription("Cost Type")]
		public long csttyp;

		/// <summary>
		/// Task                            
		/// </summary>
		[ColumnOrder(270)]
		[SMBFieldName("tsknum")]
		[SMBFieldDescription("Task")]
		public decimal tsknum;

		/// <summary>
		/// Inventory Location              
		/// </summary>
		[ColumnOrder(280)]
		[SMBFieldName("invloc")]
		[SMBFieldDescription("Inventory Location")]
		public long invloc;

		/// <summary>
		/// User Defined                    
		/// </summary>
		[ColumnOrder(290)]
		[SMBFieldName("usrdf1")]
		[SMBFieldDescription("User Defined")]
		public string usrdf1;

		/// <summary>
		/// Notes                           
		/// </summary>
		[ColumnOrder(300)]
		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

		/// <summary>
		/// Export Notes                    
		/// </summary>
		[ColumnOrder(310)]
		[SMBFieldName("expnte")]
		[SMBFieldDescription("Export Notes")]
		public string expnte;

	}
}