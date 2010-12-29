using System;

namespace SMB.Tables {
	public class asmprt : smbtable {
		/// <summary>
		/// Assembly#                       
		/// </summary>
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Assembly#")]
		public long recnum;

		/// <summary>
		/// Line#                           
		/// </summary>
		[SMBFieldName("linnum")]
		[SMBFieldDescription("Line#")]
		public long linnum;

		/// <summary>
		///                                 
		/// </summary>
		[SMBFieldName("prtchk")]
		[SMBFieldDescription("")]
		public long prtchk;

		/// <summary>
		/// Part                            
		/// </summary>
		[SMBFieldName("prtnum")]
		[SMBFieldDescription("Part")]
		public long prtnum;

		/// <summary>
		/// Part Name                       
		/// </summary>
		[SMBFieldName("prtnme")]
		[SMBFieldDescription("Part Name")]
		public string prtnme;

		/// <summary>
		/// Alpha Part #                    
		/// </summary>
		[SMBFieldName("alpnum")]
		[SMBFieldDescription("Alpha Part #")]
		public string alpnum;

		/// <summary>
		/// Unit                            
		/// </summary>
		[SMBFieldName("prtunt")]
		[SMBFieldDescription("Unit")]
		public string prtunt;

		/// <summary>
		/// Quantity                        
		/// </summary>
		[SMBFieldName("prtqty")]
		[SMBFieldDescription("Quantity")]
		public decimal prtqty;

		/// <summary>
		/// Cost                            
		/// </summary>
		[SMBFieldName("prtbil")]
		[SMBFieldDescription("Cost")]
		public decimal prtbil;

		/// <summary>
		/// Total                           
		/// </summary>
		[SMBFieldName("extprc")]
		[SMBFieldDescription("Total")]
		public decimal extprc;

		/// <summary>
		/// Formula                         
		/// </summary>
		[SMBFieldName("prtfrm")]
		[SMBFieldDescription("Formula")]
		public string prtfrm;

		/// <summary>
		/// Cost Code                       
		/// </summary>
		[SMBFieldName("prtcde")]
		[SMBFieldDescription("Cost Code")]
		public decimal prtcde;

		/// <summary>
		/// Cost Type                       
		/// </summary>
		[SMBFieldName("prttyp")]
		[SMBFieldDescription("Cost Type")]
		public long prttyp;

		/// <summary>
		/// Task                            
		/// </summary>
		[SMBFieldName("prttsk")]
		[SMBFieldDescription("Task")]
		public decimal prttsk;

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