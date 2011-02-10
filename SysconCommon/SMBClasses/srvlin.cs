using System;
using SysconCommon.Algebras.DataTables;

namespace SMB.Tables {
	public partial class srvlin : smbtable {
		/// <summary>
		/// Record#                         
		/// </summary>
		[ColumnOrder(10)]
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Record#")]
		public long recnum;

		/// <summary>
		/// Line#                           
		/// </summary>
		[ColumnOrder(20)]
		[SMBFieldName("linnum")]
		[SMBFieldDescription("Line#")]
		public long linnum;

		/// <summary>
		/// Assembly#                       
		/// </summary>
		[ColumnOrder(30)]
		[SMBFieldName("asmnum")]
		[SMBFieldDescription("Assembly#")]
		public long asmnum;

		/// <summary>
		///                                 
		/// </summary>
		[ColumnOrder(40)]
		[SMBFieldName("asmchk")]
		[SMBFieldDescription("")]
		public long asmchk;

		/// <summary>
		/// Part#                           
		/// </summary>
		[ColumnOrder(50)]
		[SMBFieldName("prtnum")]
		[SMBFieldDescription("Part#")]
		public long prtnum;

		/// <summary>
		/// Description                     
		/// </summary>
		[ColumnOrder(60)]
		[SMBFieldName("dscrpt")]
		[SMBFieldDescription("Description")]
		public string dscrpt;

		/// <summary>
		/// Alpha Part#                     
		/// </summary>
		[ColumnOrder(70)]
		[SMBFieldName("alpnum")]
		[SMBFieldDescription("Alpha Part#")]
		public string alpnum;

		/// <summary>
		/// Unit                            
		/// </summary>
		[ColumnOrder(80)]
		[SMBFieldName("untdsc")]
		[SMBFieldDescription("Unit")]
		public string untdsc;

		/// <summary>
		/// Quantity                        
		/// </summary>
		[ColumnOrder(90)]
		[SMBFieldName("prtqty")]
		[SMBFieldDescription("Quantity")]
		public decimal prtqty;

		/// <summary>
		/// Price                           
		/// </summary>
		[ColumnOrder(100)]
		[SMBFieldName("prtprc")]
		[SMBFieldDescription("Price")]
		public decimal prtprc;

		/// <summary>
		/// Ext Qty                         
		/// </summary>
		[ColumnOrder(110)]
		[SMBFieldName("extqty")]
		[SMBFieldDescription("Ext Qty")]
		public decimal extqty;

		/// <summary>
		/// Ext Price                       
		/// </summary>
		[ColumnOrder(120)]
		[SMBFieldName("extprc")]
		[SMBFieldDescription("Ext Price")]
		public decimal extprc;

		/// <summary>
		/// Ticket#                         
		/// </summary>
		[ColumnOrder(130)]
		[SMBFieldName("tktnum")]
		[SMBFieldDescription("Ticket#")]
		public string tktnum;

		/// <summary>
		/// Billed to Date                  
		/// </summary>
		[ColumnOrder(140)]
		[SMBFieldName("blldte")]
		[SMBFieldDescription("Billed to Date")]
		public decimal blldte;

		/// <summary>
		/// Current                         
		/// </summary>
		[ColumnOrder(150)]
		[SMBFieldName("curbll")]
		[SMBFieldDescription("Current")]
		public decimal curbll;

		/// <summary>
		/// Cost Type                       
		/// </summary>
		[ColumnOrder(160)]
		[SMBFieldName("csttyp")]
		[SMBFieldDescription("Cost Type")]
		public long csttyp;

		/// <summary>
		/// Account                         
		/// </summary>
		[ColumnOrder(170)]
		[SMBFieldName("actnum")]
		[SMBFieldDescription("Account")]
		public long actnum;

		/// <summary>
		/// Subaccount                      
		/// </summary>
		[ColumnOrder(180)]
		[SMBFieldName("subact")]
		[SMBFieldDescription("Subaccount")]
		public long subact;

		/// <summary>
		/// Inv. Location                   
		/// </summary>
		[ColumnOrder(190)]
		[SMBFieldName("invloc")]
		[SMBFieldDescription("Inv. Location")]
		public long invloc;

		/// <summary>
		/// Serial Number                   
		/// </summary>
		[ColumnOrder(200)]
		[SMBFieldName("sernum")]
		[SMBFieldDescription("Serial Number")]
		public string sernum;

		/// <summary>
		/// Site Location                   
		/// </summary>
		[ColumnOrder(210)]
		[SMBFieldName("sitloc")]
		[SMBFieldDescription("Site Location")]
		public string sitloc;

		/// <summary>
		/// Equipment                       
		/// </summary>
		[ColumnOrder(220)]
		[SMBFieldName("eqpnum")]
		[SMBFieldDescription("Equipment")]
		public long eqpnum;

		/// <summary>
		/// User Defined                    
		/// </summary>
		[ColumnOrder(230)]
		[SMBFieldName("usrdf1")]
		[SMBFieldDescription("User Defined")]
		public string usrdf1;

		/// <summary>
		/// Shop Notes                      
		/// </summary>
		[ColumnOrder(240)]
		[SMBFieldName("shpnte")]
		[SMBFieldDescription("Shop Notes")]
		public string shpnte;

		/// <summary>
		/// Owner Notes                     
		/// </summary>
		[ColumnOrder(250)]
		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Owner Notes")]
		public string ntetxt;

	}
}