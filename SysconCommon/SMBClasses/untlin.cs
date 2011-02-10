using System;
using SysconCommon.Algebras.DataTables;

namespace SMB.Tables {
	public partial class untlin : smbtable {
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
		/// Bid Item                        
		/// </summary>
		[ColumnOrder(30)]
		[SMBFieldName("biditm")]
		[SMBFieldDescription("Bid Item")]
		public long biditm;

		/// <summary>
		/// Item Code                       
		/// </summary>
		[ColumnOrder(40)]
		[SMBFieldName("itmcde")]
		[SMBFieldDescription("Item Code")]
		public string itmcde;

		/// <summary>
		/// Description                     
		/// </summary>
		[ColumnOrder(50)]
		[SMBFieldName("itmnme")]
		[SMBFieldDescription("Description")]
		public string itmnme;

		/// <summary>
		/// Unit                            
		/// </summary>
		[ColumnOrder(60)]
		[SMBFieldName("untdsc")]
		[SMBFieldDescription("Unit")]
		public string untdsc;

		/// <summary>
		/// Unit Price                      
		/// </summary>
		[ColumnOrder(70)]
		[SMBFieldName("untcst")]
		[SMBFieldDescription("Unit Price")]
		public decimal untcst;

		/// <summary>
		/// Sched. Qty                      
		/// </summary>
		[ColumnOrder(80)]
		[SMBFieldName("schamt")]
		[SMBFieldDescription("Sched. Qty")]
		public decimal schamt;

		/// <summary>
		/// Sched. $                        
		/// </summary>
		[ColumnOrder(90)]
		[SMBFieldName("schval")]
		[SMBFieldDescription("Sched. $")]
		public decimal schval;

		/// <summary>
		/// Change Qty                      
		/// </summary>
		[ColumnOrder(100)]
		[SMBFieldName("chgamt")]
		[SMBFieldDescription("Change Qty")]
		public decimal chgamt;

		/// <summary>
		/// Change $                        
		/// </summary>
		[ColumnOrder(110)]
		[SMBFieldName("chgval")]
		[SMBFieldDescription("Change $")]
		public decimal chgval;

		/// <summary>
		/// Contract Qty                    
		/// </summary>
		[ColumnOrder(120)]
		[SMBFieldName("newcon")]
		[SMBFieldDescription("Contract Qty")]
		public decimal newcon;

		/// <summary>
		/// Contract $                      
		/// </summary>
		[ColumnOrder(130)]
		[SMBFieldName("cntval")]
		[SMBFieldDescription("Contract $")]
		public decimal cntval;

		/// <summary>
		/// Previous Qty                    
		/// </summary>
		[ColumnOrder(140)]
		[SMBFieldName("prvbll")]
		[SMBFieldDescription("Previous Qty")]
		public decimal prvbll;

		/// <summary>
		/// Previous $                      
		/// </summary>
		[ColumnOrder(150)]
		[SMBFieldName("prvval")]
		[SMBFieldDescription("Previous $")]
		public decimal prvval;

		/// <summary>
		/// Current Qty                     
		/// </summary>
		[ColumnOrder(160)]
		[SMBFieldName("curbll")]
		[SMBFieldDescription("Current Qty")]
		public decimal curbll;

		/// <summary>
		/// Current $                       
		/// </summary>
		[ColumnOrder(170)]
		[SMBFieldName("curval")]
		[SMBFieldDescription("Current $")]
		public decimal curval;

		/// <summary>
		/// Total Qty                       
		/// </summary>
		[ColumnOrder(180)]
		[SMBFieldName("ttlcmp")]
		[SMBFieldDescription("Total Qty")]
		public decimal ttlcmp;

		/// <summary>
		/// Total $                         
		/// </summary>
		[ColumnOrder(190)]
		[SMBFieldName("totval")]
		[SMBFieldDescription("Total $")]
		public decimal totval;

		/// <summary>
		/// Balance Qty                     
		/// </summary>
		[ColumnOrder(200)]
		[SMBFieldName("balfin")]
		[SMBFieldDescription("Balance Qty")]
		public decimal balfin;

		/// <summary>
		/// Balance $                       
		/// </summary>
		[ColumnOrder(210)]
		[SMBFieldName("remval")]
		[SMBFieldDescription("Balance $")]
		public decimal remval;

		/// <summary>
		/// Ret. Rate                       
		/// </summary>
		[ColumnOrder(220)]
		[SMBFieldName("retrte")]
		[SMBFieldDescription("Ret. Rate")]
		public decimal retrte;

		/// <summary>
		/// Retention                       
		/// </summary>
		[ColumnOrder(230)]
		[SMBFieldName("retamt")]
		[SMBFieldDescription("Retention")]
		public decimal retamt;

		/// <summary>
		/// User Defined                    
		/// </summary>
		[ColumnOrder(240)]
		[SMBFieldName("usrdf1")]
		[SMBFieldDescription("User Defined")]
		public string usrdf1;

		/// <summary>
		/// Notes                           
		/// </summary>
		[ColumnOrder(250)]
		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

	}
}