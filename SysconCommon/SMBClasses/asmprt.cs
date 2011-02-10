using System;
using SysconCommon.Algebras.DataTables;

namespace SMB.Tables {
	public partial class asmprt : smbtable {
		/// <summary>
		/// Assembly#                       
		/// </summary>
		[ColumnOrder(10)]
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Assembly#")]
		public long recnum;

		/// <summary>
		/// Line#                           
		/// </summary>
		[ColumnOrder(20)]
		[SMBFieldName("linnum")]
		[SMBFieldDescription("Line#")]
		public long linnum;

		/// <summary>
		///                                 
		/// </summary>
		[ColumnOrder(30)]
		[SMBFieldName("prtchk")]
		[SMBFieldDescription("")]
		public long prtchk;

		/// <summary>
		/// Part                            
		/// </summary>
		[ColumnOrder(40)]
		[SMBFieldName("prtnum")]
		[SMBFieldDescription("Part")]
		public long prtnum;

		/// <summary>
		/// Part Name                       
		/// </summary>
		[ColumnOrder(50)]
		[SMBFieldName("prtnme")]
		[SMBFieldDescription("Part Name")]
		public string prtnme;

		/// <summary>
		/// Alpha Part #                    
		/// </summary>
		[ColumnOrder(60)]
		[SMBFieldName("alpnum")]
		[SMBFieldDescription("Alpha Part #")]
		public string alpnum;

		/// <summary>
		/// Unit                            
		/// </summary>
		[ColumnOrder(70)]
		[SMBFieldName("prtunt")]
		[SMBFieldDescription("Unit")]
		public string prtunt;

		/// <summary>
		/// Quantity                        
		/// </summary>
		[ColumnOrder(80)]
		[SMBFieldName("prtqty")]
		[SMBFieldDescription("Quantity")]
		public decimal prtqty;

		/// <summary>
		/// Cost                            
		/// </summary>
		[ColumnOrder(90)]
		[SMBFieldName("prtbil")]
		[SMBFieldDescription("Cost")]
		public decimal prtbil;

		/// <summary>
		/// Total                           
		/// </summary>
		[ColumnOrder(100)]
		[SMBFieldName("extprc")]
		[SMBFieldDescription("Total")]
		public decimal extprc;

		/// <summary>
		/// Formula                         
		/// </summary>
		[ColumnOrder(110)]
		[SMBFieldName("prtfrm")]
		[SMBFieldDescription("Formula")]
		public string prtfrm;

		/// <summary>
		/// Cost Code                       
		/// </summary>
		[ColumnOrder(120)]
		[SMBFieldName("prtcde")]
		[SMBFieldDescription("Cost Code")]
		public decimal prtcde;

		/// <summary>
		/// Cost Type                       
		/// </summary>
		[ColumnOrder(130)]
		[SMBFieldName("prttyp")]
		[SMBFieldDescription("Cost Type")]
		public long prttyp;

		/// <summary>
		/// Task                            
		/// </summary>
		[ColumnOrder(140)]
		[SMBFieldName("prttsk")]
		[SMBFieldDescription("Task")]
		public decimal prttsk;

		/// <summary>
		/// User Defined                    
		/// </summary>
		[ColumnOrder(150)]
		[SMBFieldName("usrdf1")]
		[SMBFieldDescription("User Defined")]
		public string usrdf1;

		/// <summary>
		/// Notes                           
		/// </summary>
		[ColumnOrder(160)]
		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

	}
}