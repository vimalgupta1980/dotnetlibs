using System;

namespace SMB.Tables {
	public class srvlin : smbtable {
		/// <summary>
		/// Record#                         
		/// </summary>
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Record#")]
		public long recnum;

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
		[SMBFieldName("dscrpt")]
		[SMBFieldDescription("Description")]
		public string dscrpt;

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
		[SMBFieldName("prtqty")]
		[SMBFieldDescription("Quantity")]
		public decimal prtqty;

		/// <summary>
		/// Price                           
		/// </summary>
		[SMBFieldName("prtprc")]
		[SMBFieldDescription("Price")]
		public decimal prtprc;

		/// <summary>
		/// Ext Qty                         
		/// </summary>
		[SMBFieldName("extqty")]
		[SMBFieldDescription("Ext Qty")]
		public decimal extqty;

		/// <summary>
		/// Ext Price                       
		/// </summary>
		[SMBFieldName("extprc")]
		[SMBFieldDescription("Ext Price")]
		public decimal extprc;

		/// <summary>
		/// Ticket#                         
		/// </summary>
		[SMBFieldName("tktnum")]
		[SMBFieldDescription("Ticket#")]
		public string tktnum;

		/// <summary>
		/// Billed to Date                  
		/// </summary>
		[SMBFieldName("blldte")]
		[SMBFieldDescription("Billed to Date")]
		public decimal blldte;

		/// <summary>
		/// Current                         
		/// </summary>
		[SMBFieldName("curbll")]
		[SMBFieldDescription("Current")]
		public decimal curbll;

		/// <summary>
		/// Cost Type                       
		/// </summary>
		[SMBFieldName("csttyp")]
		[SMBFieldDescription("Cost Type")]
		public long csttyp;

		/// <summary>
		/// Account                         
		/// </summary>
		[SMBFieldName("actnum")]
		[SMBFieldDescription("Account")]
		public long actnum;

		/// <summary>
		/// Subaccount                      
		/// </summary>
		[SMBFieldName("subact")]
		[SMBFieldDescription("Subaccount")]
		public long subact;

		/// <summary>
		/// Inv. Location                   
		/// </summary>
		[SMBFieldName("invloc")]
		[SMBFieldDescription("Inv. Location")]
		public long invloc;

		/// <summary>
		/// Serial Number                   
		/// </summary>
		[SMBFieldName("sernum")]
		[SMBFieldDescription("Serial Number")]
		public string sernum;

		/// <summary>
		/// Site Location                   
		/// </summary>
		[SMBFieldName("sitloc")]
		[SMBFieldDescription("Site Location")]
		public string sitloc;

		/// <summary>
		/// Equipment                       
		/// </summary>
		[SMBFieldName("eqpnum")]
		[SMBFieldDescription("Equipment")]
		public long eqpnum;

		/// <summary>
		/// User Defined                    
		/// </summary>
		[SMBFieldName("usrdf1")]
		[SMBFieldDescription("User Defined")]
		public string usrdf1;

		/// <summary>
		/// Shop Notes                      
		/// </summary>
		[SMBFieldName("shpnte")]
		[SMBFieldDescription("Shop Notes")]
		public string shpnte;

		/// <summary>
		/// Owner Notes                     
		/// </summary>
		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Owner Notes")]
		public string ntetxt;

	}
}