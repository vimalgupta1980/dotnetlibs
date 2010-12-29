using System;

namespace SMB.Tables {
	public class tkfprt : smbtable {
		/// <summary>
		/// Part#                           
		/// </summary>
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Part#")]
		public long recnum;

		/// <summary>
		/// Description                     
		/// </summary>
		[SMBFieldName("prtnme")]
		[SMBFieldDescription("Description")]
		public string prtnme;

		/// <summary>
		/// Unit                            
		/// </summary>
		[SMBFieldName("prtunt")]
		[SMBFieldDescription("Unit")]
		public string prtunt;

		/// <summary>
		/// Bin#                            
		/// </summary>
		[SMBFieldName("binnum")]
		[SMBFieldDescription("Bin#")]
		public string binnum;

		/// <summary>
		/// Alpha Part#                     
		/// </summary>
		[SMBFieldName("alpnum")]
		[SMBFieldDescription("Alpha Part#")]
		public string alpnum;

		/// <summary>
		/// MSDS#                           
		/// </summary>
		[SMBFieldName("msdsnm")]
		[SMBFieldDescription("MSDS#")]
		public string msdsnm;

		/// <summary>
		/// Manufacturer                    
		/// </summary>
		[SMBFieldName("mannme")]
		[SMBFieldDescription("Manufacturer")]
		public string mannme;

		/// <summary>
		/// Man Part#                       
		/// </summary>
		[SMBFieldName("mannum")]
		[SMBFieldDescription("Man Part#")]
		public string mannum;

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
		[SMBFieldName("prttsk")]
		[SMBFieldDescription("Task")]
		public decimal prttsk;

		/// <summary>
		/// Part Class                      
		/// </summary>
		[SMBFieldName("prtcls")]
		[SMBFieldDescription("Part Class")]
		public long prtcls;

		/// <summary>
		/// Default Location                
		/// </summary>
		[SMBFieldName("dftloc")]
		[SMBFieldDescription("Default Location")]
		public long dftloc;

		/// <summary>
		/// Last Updated                    
		/// </summary>
		[SMBFieldName("lstupd")]
		[SMBFieldDescription("Last Updated")]
		public DateTime lstupd;

		/// <summary>
		/// Reorder Quantity                
		/// </summary>
		[SMBFieldName("reordr")]
		[SMBFieldDescription("Reorder Quantity")]
		public decimal reordr;

		/// <summary>
		/// Minimum Order Qty               
		/// </summary>
		[SMBFieldName("minord")]
		[SMBFieldDescription("Minimum Order Qty")]
		public decimal minord;

		/// <summary>
		/// Package Quantity                
		/// </summary>
		[SMBFieldName("pkgqty")]
		[SMBFieldDescription("Package Quantity")]
		public decimal pkgqty;

		/// <summary>
		/// Unit Weight                     
		/// </summary>
		[SMBFieldName("prtwgt")]
		[SMBFieldDescription("Unit Weight")]
		public decimal prtwgt;

		/// <summary>
		/// Average Cost                    
		/// </summary>
		[SMBFieldName("avgcst")]
		[SMBFieldDescription("Average Cost")]
		public decimal avgcst;

		/// <summary>
		/// Default Cost                    
		/// </summary>
		[SMBFieldName("prtcst")]
		[SMBFieldDescription("Default Cost")]
		public decimal prtcst;

		/// <summary>
		/// Quantity                        
		/// </summary>
		[SMBFieldName("labunt")]
		[SMBFieldDescription("Quantity")]
		public decimal labunt;

		/// <summary>
		/// Billing Amount                  
		/// </summary>
		[SMBFieldName("prtbil")]
		[SMBFieldDescription("Billing Amount")]
		public decimal prtbil;

		/// <summary>
		/// Quantity on Hand                
		/// </summary>
		[SMBFieldName("qtyohn")]
		[SMBFieldDescription("Quantity on Hand")]
		public decimal qtyohn;

		/// <summary>
		/// Stock Item                      
		/// </summary>
		[SMBFieldName("stkitm")]
		[SMBFieldDescription("Stock Item")]
		public long stkitm;

		/// <summary>
		/// Serialized Item                 
		/// </summary>
		[SMBFieldName("serinv")]
		[SMBFieldDescription("Serialized Item")]
		public long serinv;

		/// <summary>
		/// Markup %                        
		/// </summary>
		[SMBFieldName("mrkupr")]
		[SMBFieldDescription("Markup %")]
		public decimal mrkupr;

		/// <summary>
		/// Labor Part#                     
		/// </summary>
		[SMBFieldName("labnum")]
		[SMBFieldDescription("Labor Part#")]
		public long labnum;

		/// <summary>
		/// Notes                           
		/// </summary>
		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

		/// <summary>
		/// Service Equipment Item          
		/// </summary>
		[SMBFieldName("srvprt")]
		[SMBFieldDescription("Service Equipment Item")]
		public long srvprt;

		/// <summary>
		/// OEM Warranty Duration           
		/// </summary>
		[SMBFieldName("oemdur")]
		[SMBFieldDescription("OEM Warranty Duration")]
		public long oemdur;

		/// <summary>
		/// Required from Inv.              
		/// </summary>
		[SMBFieldName("reqivt")]
		[SMBFieldDescription("Required from Inv.")]
		public long reqivt;

	}
}