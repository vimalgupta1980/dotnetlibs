using System;

namespace SMB.Tables {
	public class sbcgln : smbtable {
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
		/// Description                     
		/// </summary>
		[SMBFieldName("dscrpt")]
		[SMBFieldDescription("Description")]
		public string dscrpt;

		/// <summary>
		/// Budget Hours                    
		/// </summary>
		[SMBFieldName("chghrs")]
		[SMBFieldDescription("Budget Hours")]
		public decimal chghrs;

		/// <summary>
		/// Budget Units                    
		/// </summary>
		[SMBFieldName("chgunt")]
		[SMBFieldDescription("Budget Units")]
		public decimal chgunt;

		/// <summary>
		/// Budget Amount                   
		/// </summary>
		[SMBFieldName("bdgprc")]
		[SMBFieldDescription("Budget Amount")]
		public decimal bdgprc;

		/// <summary>
		/// Vendor                          
		/// </summary>
		[SMBFieldName("vndnum")]
		[SMBFieldDescription("Vendor")]
		public long vndnum;

		/// <summary>
		/// Subcontract                     
		/// </summary>
		[SMBFieldName("vndctc")]
		[SMBFieldDescription("Subcontract")]
		public long vndctc;

		/// <summary>
		/// Subcontract Line                
		/// </summary>
		[SMBFieldName("ctclin")]
		[SMBFieldDescription("Subcontract Line")]
		public long ctclin;

		/// <summary>
		/// Change#                         
		/// </summary>
		[SMBFieldName("chgnum")]
		[SMBFieldDescription("Change#")]
		public string chgnum;

		/// <summary>
		/// Status                          
		/// </summary>
		[SMBFieldName("chgsts")]
		[SMBFieldDescription("Status")]
		public long chgsts;

		/// <summary>
		/// Date                            
		/// </summary>
		[SMBFieldName("chgdte")]
		[SMBFieldDescription("Date")]
		public DateTime chgdte;

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
		/// User Defined                    
		/// </summary>
		[SMBFieldName("usrdf1")]
		[SMBFieldDescription("User Defined")]
		public string usrdf1;

		/// <summary>
		/// Change Order Notes              
		/// </summary>
		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Change Order Notes")]
		public string ntetxt;

		/// <summary>
		/// Subcontract Line Reference #    
		/// </summary>
		[SMBFieldName("linref")]
		[SMBFieldDescription("Subcontract Line Reference #")]
		public string linref;

	}
}