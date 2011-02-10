using System;
using SysconCommon.Algebras.DataTables;

namespace SMB.Tables {
	public partial class tkfprt : smbtable {
		/// <summary>
		/// Part#                           
		/// </summary>
		[ColumnOrder(10)]
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Part#")]
		public long recnum;

		/// <summary>
		/// Description                     
		/// </summary>
		[ColumnOrder(20)]
		[SMBFieldName("prtnme")]
		[SMBFieldDescription("Description")]
		public string prtnme;

		/// <summary>
		/// Unit                            
		/// </summary>
		[ColumnOrder(30)]
		[SMBFieldName("prtunt")]
		[SMBFieldDescription("Unit")]
		public string prtunt;

		/// <summary>
		/// Bin#                            
		/// </summary>
		[ColumnOrder(40)]
		[SMBFieldName("binnum")]
		[SMBFieldDescription("Bin#")]
		public string binnum;

		/// <summary>
		/// Alpha Part#                     
		/// </summary>
		[ColumnOrder(50)]
		[SMBFieldName("alpnum")]
		[SMBFieldDescription("Alpha Part#")]
		public string alpnum;

		/// <summary>
		/// MSDS#                           
		/// </summary>
		[ColumnOrder(60)]
		[SMBFieldName("msdsnm")]
		[SMBFieldDescription("MSDS#")]
		public string msdsnm;

		/// <summary>
		/// Manufacturer                    
		/// </summary>
		[ColumnOrder(70)]
		[SMBFieldName("mannme")]
		[SMBFieldDescription("Manufacturer")]
		public string mannme;

		/// <summary>
		/// Man Part#                       
		/// </summary>
		[ColumnOrder(80)]
		[SMBFieldName("mannum")]
		[SMBFieldDescription("Man Part#")]
		public string mannum;

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
		/// Cost Code                       
		/// </summary>
		[ColumnOrder(110)]
		[SMBFieldName("cstcde")]
		[SMBFieldDescription("Cost Code")]
		public decimal cstcde;

		/// <summary>
		/// Cost Type                       
		/// </summary>
		[ColumnOrder(120)]
		[SMBFieldName("csttyp")]
		[SMBFieldDescription("Cost Type")]
		public long csttyp;

		/// <summary>
		/// Task                            
		/// </summary>
		[ColumnOrder(130)]
		[SMBFieldName("prttsk")]
		[SMBFieldDescription("Task")]
		public decimal prttsk;

		/// <summary>
		/// Part Class                      
		/// </summary>
		[ColumnOrder(140)]
		[SMBFieldName("prtcls")]
		[SMBFieldDescription("Part Class")]
		public long prtcls;

		/// <summary>
		/// Default Location                
		/// </summary>
		[ColumnOrder(150)]
		[SMBFieldName("dftloc")]
		[SMBFieldDescription("Default Location")]
		public long dftloc;

		/// <summary>
		/// Last Updated                    
		/// </summary>
		[ColumnOrder(160)]
		[SMBFieldName("lstupd")]
		[SMBFieldDescription("Last Updated")]
		public DateTime lstupd;

		/// <summary>
		/// Reorder Quantity                
		/// </summary>
		[ColumnOrder(170)]
		[SMBFieldName("reordr")]
		[SMBFieldDescription("Reorder Quantity")]
		public decimal reordr;

		/// <summary>
		/// Minimum Order Qty               
		/// </summary>
		[ColumnOrder(180)]
		[SMBFieldName("minord")]
		[SMBFieldDescription("Minimum Order Qty")]
		public decimal minord;

		/// <summary>
		/// Package Quantity                
		/// </summary>
		[ColumnOrder(190)]
		[SMBFieldName("pkgqty")]
		[SMBFieldDescription("Package Quantity")]
		public decimal pkgqty;

		/// <summary>
		/// Unit Weight                     
		/// </summary>
		[ColumnOrder(200)]
		[SMBFieldName("prtwgt")]
		[SMBFieldDescription("Unit Weight")]
		public decimal prtwgt;

		/// <summary>
		/// Average Cost                    
		/// </summary>
		[ColumnOrder(210)]
		[SMBFieldName("avgcst")]
		[SMBFieldDescription("Average Cost")]
		public decimal avgcst;

		/// <summary>
		/// Default Cost                    
		/// </summary>
		[ColumnOrder(220)]
		[SMBFieldName("prtcst")]
		[SMBFieldDescription("Default Cost")]
		public decimal prtcst;

		/// <summary>
		/// Quantity                        
		/// </summary>
		[ColumnOrder(230)]
		[SMBFieldName("labunt")]
		[SMBFieldDescription("Quantity")]
		public decimal labunt;

		/// <summary>
		/// Billing Amount                  
		/// </summary>
		[ColumnOrder(240)]
		[SMBFieldName("prtbil")]
		[SMBFieldDescription("Billing Amount")]
		public decimal prtbil;

		/// <summary>
		/// Quantity on Hand                
		/// </summary>
		[ColumnOrder(250)]
		[SMBFieldName("qtyohn")]
		[SMBFieldDescription("Quantity on Hand")]
		public decimal qtyohn;

		/// <summary>
		/// Stock Item                      
		/// </summary>
		[ColumnOrder(260)]
		[SMBFieldName("stkitm")]
		[SMBFieldDescription("Stock Item")]
		public long stkitm;

		/// <summary>
		/// Serialized Item                 
		/// </summary>
		[ColumnOrder(270)]
		[SMBFieldName("serinv")]
		[SMBFieldDescription("Serialized Item")]
		public long serinv;

		/// <summary>
		/// Markup %                        
		/// </summary>
		[ColumnOrder(280)]
		[SMBFieldName("mrkupr")]
		[SMBFieldDescription("Markup %")]
		public decimal mrkupr;

		/// <summary>
		/// Labor Part#                     
		/// </summary>
		[ColumnOrder(290)]
		[SMBFieldName("labnum")]
		[SMBFieldDescription("Labor Part#")]
		public long labnum;

		/// <summary>
		/// Notes                           
		/// </summary>
		[ColumnOrder(300)]
		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

		/// <summary>
		/// Service Equipment Item          
		/// </summary>
		[ColumnOrder(310)]
		[SMBFieldName("srvprt")]
		[SMBFieldDescription("Service Equipment Item")]
		public long srvprt;

		/// <summary>
		/// OEM Warranty Duration           
		/// </summary>
		[ColumnOrder(320)]
		[SMBFieldName("oemdur")]
		[SMBFieldDescription("OEM Warranty Duration")]
		public long oemdur;

		/// <summary>
		/// Required from Inv.              
		/// </summary>
		[ColumnOrder(330)]
		[SMBFieldName("reqivt")]
		[SMBFieldDescription("Required from Inv.")]
		public long reqivt;

	}
}