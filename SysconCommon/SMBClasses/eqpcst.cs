using System;
using SysconCommon.Algebras.DataTables;

namespace SMB.Tables {
	public partial class eqpcst : smbtable {
		/// <summary>
		/// Record#                         
		/// </summary>
		[ColumnOrder(10)]
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Record#")]
		public long recnum;

		/// <summary>
		/// Equipment                       
		/// </summary>
		[ColumnOrder(20)]
		[SMBFieldName("eqpnum")]
		[SMBFieldDescription("Equipment")]
		public long eqpnum;

		/// <summary>
		/// Trans#                          
		/// </summary>
		[ColumnOrder(30)]
		[SMBFieldName("trnnum")]
		[SMBFieldDescription("Trans#")]
		public string trnnum;

		/// <summary>
		/// Description                     
		/// </summary>
		[ColumnOrder(40)]
		[SMBFieldName("dscrpt")]
		[SMBFieldDescription("Description")]
		public string dscrpt;

		/// <summary>
		/// Date                            
		/// </summary>
		[ColumnOrder(50)]
		[SMBFieldName("trndte")]
		[SMBFieldDescription("Date")]
		public DateTime trndte;

		/// <summary>
		/// Entry Date                      
		/// </summary>
		[ColumnOrder(60)]
		[SMBFieldName("entdte")]
		[SMBFieldDescription("Entry Date")]
		public DateTime entdte;

		/// <summary>
		/// Period                          
		/// </summary>
		[ColumnOrder(70)]
		[SMBFieldName("actprd")]
		[SMBFieldDescription("Period")]
		public long actprd;

		/// <summary>
		/// Source                          
		/// </summary>
		[ColumnOrder(80)]
		[SMBFieldName("srcnum")]
		[SMBFieldDescription("Source")]
		public long srcnum;

		/// <summary>
		/// Status                          
		/// </summary>
		[ColumnOrder(90)]
		[SMBFieldName("status")]
		[SMBFieldDescription("Status")]
		public long status;

		/// <summary>
		/// Cost Code                       
		/// </summary>
		[ColumnOrder(100)]
		[SMBFieldName("cstcde")]
		[SMBFieldDescription("Cost Code")]
		public decimal cstcde;

		/// <summary>
		/// Cost Type                       
		/// </summary>
		[ColumnOrder(110)]
		[SMBFieldName("csttyp")]
		[SMBFieldDescription("Cost Type")]
		public long csttyp;

		/// <summary>
		/// Vendor                          
		/// </summary>
		[ColumnOrder(120)]
		[SMBFieldName("vndnum")]
		[SMBFieldDescription("Vendor")]
		public long vndnum;

		/// <summary>
		/// Oper Equip                      
		/// </summary>
		[ColumnOrder(130)]
		[SMBFieldName("opreqp")]
		[SMBFieldDescription("Oper Equip")]
		public long opreqp;

		/// <summary>
		/// Employee                        
		/// </summary>
		[ColumnOrder(140)]
		[SMBFieldName("empnum")]
		[SMBFieldDescription("Employee")]
		public long empnum;

		/// <summary>
		/// Payroll Record                  
		/// </summary>
		[ColumnOrder(150)]
		[SMBFieldName("payrec")]
		[SMBFieldDescription("Payroll Record")]
		public long payrec;

		/// <summary>
		/// Pay Type                        
		/// </summary>
		[ColumnOrder(160)]
		[SMBFieldName("paytyp")]
		[SMBFieldDescription("Pay Type")]
		public long paytyp;

		/// <summary>
		/// Labor Hours                     
		/// </summary>
		[ColumnOrder(170)]
		[SMBFieldName("csthrs")]
		[SMBFieldDescription("Labor Hours")]
		public decimal csthrs;

		/// <summary>
		/// Type                            
		/// </summary>
		[ColumnOrder(180)]
		[SMBFieldName("eqptyp")]
		[SMBFieldDescription("Type")]
		public long eqptyp;

		/// <summary>
		/// Quantity                        
		/// </summary>
		[ColumnOrder(190)]
		[SMBFieldName("eqpqty")]
		[SMBFieldDescription("Quantity")]
		public decimal eqpqty;

		/// <summary>
		/// Cost                            
		/// </summary>
		[ColumnOrder(200)]
		[SMBFieldName("cstamt")]
		[SMBFieldDescription("Cost")]
		public decimal cstamt;

		/// <summary>
		/// Gross Wage                      
		/// </summary>
		[ColumnOrder(210)]
		[SMBFieldName("grswge")]
		[SMBFieldDescription("Gross Wage")]
		public decimal grswge;

		/// <summary>
		/// Unit                            
		/// </summary>
		[ColumnOrder(220)]
		[SMBFieldName("eqpunt")]
		[SMBFieldDescription("Unit")]
		public long eqpunt;

		/// <summary>
		/// Username                        
		/// </summary>
		[ColumnOrder(230)]
		[SMBFieldName("usrnme")]
		[SMBFieldDescription("Username")]
		public string usrnme;

		/// <summary>
		/// Ledger Ref#                     
		/// </summary>
		[ColumnOrder(240)]
		[SMBFieldName("lgrrec")]
		[SMBFieldDescription("Ledger Ref#")]
		public long lgrrec;

		/// <summary>
		/// Notes                           
		/// </summary>
		[ColumnOrder(250)]
		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

	}
}