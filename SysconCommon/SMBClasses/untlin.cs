using System;

namespace SMB.Tables {
	public class untlin : smbtable {
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
		/// Bid Item                        
		/// </summary>
		[SMBFieldName("biditm")]
		[SMBFieldDescription("Bid Item")]
		public long biditm;

		/// <summary>
		/// Item Code                       
		/// </summary>
		[SMBFieldName("itmcde")]
		[SMBFieldDescription("Item Code")]
		public string itmcde;

		/// <summary>
		/// Description                     
		/// </summary>
		[SMBFieldName("itmnme")]
		[SMBFieldDescription("Description")]
		public string itmnme;

		/// <summary>
		/// Unit                            
		/// </summary>
		[SMBFieldName("untdsc")]
		[SMBFieldDescription("Unit")]
		public string untdsc;

		/// <summary>
		/// Unit Price                      
		/// </summary>
		[SMBFieldName("untcst")]
		[SMBFieldDescription("Unit Price")]
		public decimal untcst;

		/// <summary>
		/// Sched. Qty                      
		/// </summary>
		[SMBFieldName("schamt")]
		[SMBFieldDescription("Sched. Qty")]
		public decimal schamt;

		/// <summary>
		/// Sched. $                        
		/// </summary>
		[SMBFieldName("schval")]
		[SMBFieldDescription("Sched. $")]
		public decimal schval;

		/// <summary>
		/// Change Qty                      
		/// </summary>
		[SMBFieldName("chgamt")]
		[SMBFieldDescription("Change Qty")]
		public decimal chgamt;

		/// <summary>
		/// Change $                        
		/// </summary>
		[SMBFieldName("chgval")]
		[SMBFieldDescription("Change $")]
		public decimal chgval;

		/// <summary>
		/// Contract Qty                    
		/// </summary>
		[SMBFieldName("newcon")]
		[SMBFieldDescription("Contract Qty")]
		public decimal newcon;

		/// <summary>
		/// Contract $                      
		/// </summary>
		[SMBFieldName("cntval")]
		[SMBFieldDescription("Contract $")]
		public decimal cntval;

		/// <summary>
		/// Previous Qty                    
		/// </summary>
		[SMBFieldName("prvbll")]
		[SMBFieldDescription("Previous Qty")]
		public decimal prvbll;

		/// <summary>
		/// Previous $                      
		/// </summary>
		[SMBFieldName("prvval")]
		[SMBFieldDescription("Previous $")]
		public decimal prvval;

		/// <summary>
		/// Current Qty                     
		/// </summary>
		[SMBFieldName("curbll")]
		[SMBFieldDescription("Current Qty")]
		public decimal curbll;

		/// <summary>
		/// Current $                       
		/// </summary>
		[SMBFieldName("curval")]
		[SMBFieldDescription("Current $")]
		public decimal curval;

		/// <summary>
		/// Total Qty                       
		/// </summary>
		[SMBFieldName("ttlcmp")]
		[SMBFieldDescription("Total Qty")]
		public decimal ttlcmp;

		/// <summary>
		/// Total $                         
		/// </summary>
		[SMBFieldName("totval")]
		[SMBFieldDescription("Total $")]
		public decimal totval;

		/// <summary>
		/// Balance Qty                     
		/// </summary>
		[SMBFieldName("balfin")]
		[SMBFieldDescription("Balance Qty")]
		public decimal balfin;

		/// <summary>
		/// Balance $                       
		/// </summary>
		[SMBFieldName("remval")]
		[SMBFieldDescription("Balance $")]
		public decimal remval;

		/// <summary>
		/// Ret. Rate                       
		/// </summary>
		[SMBFieldName("retrte")]
		[SMBFieldDescription("Ret. Rate")]
		public decimal retrte;

		/// <summary>
		/// Retention                       
		/// </summary>
		[SMBFieldName("retamt")]
		[SMBFieldDescription("Retention")]
		public decimal retamt;

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

	}
}