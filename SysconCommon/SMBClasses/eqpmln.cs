using System;
using SysconCommon.Algebras.DataTables;

namespace SMB.Tables {
	public partial class eqpmln : smbtable {
		/// <summary>
		/// Equipment#                      
		/// </summary>
		[ColumnOrder(10)]
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Equipment#")]
		public long recnum;

		/// <summary>
		/// Line#                           
		/// </summary>
		[ColumnOrder(20)]
		[SMBFieldName("linnum")]
		[SMBFieldDescription("Line#")]
		public long linnum;

		/// <summary>
		/// Description                     
		/// </summary>
		[ColumnOrder(30)]
		[SMBFieldName("dscrpt")]
		[SMBFieldDescription("Description")]
		public string dscrpt;

		/// <summary>
		/// Cost Code                       
		/// </summary>
		[ColumnOrder(40)]
		[SMBFieldName("cstcde")]
		[SMBFieldDescription("Cost Code")]
		public decimal cstcde;

		/// <summary>
		/// Comp Date                       
		/// </summary>
		[ColumnOrder(50)]
		[SMBFieldName("cmpday")]
		[SMBFieldDescription("Comp Date")]
		public DateTime cmpday;

		/// <summary>
		/// Cycle Days                      
		/// </summary>
		[ColumnOrder(60)]
		[SMBFieldName("cycday")]
		[SMBFieldDescription("Cycle Days")]
		public long cycday;

		/// <summary>
		/// Sched Date                      
		/// </summary>
		[ColumnOrder(70)]
		[SMBFieldName("schdte")]
		[SMBFieldDescription("Sched Date")]
		public DateTime schdte;

		/// <summary>
		/// Comp Units                      
		/// </summary>
		[ColumnOrder(80)]
		[SMBFieldName("cmphrs")]
		[SMBFieldDescription("Comp Units")]
		public long cmphrs;

		/// <summary>
		/// Cycle Units                     
		/// </summary>
		[ColumnOrder(90)]
		[SMBFieldName("cychrs")]
		[SMBFieldDescription("Cycle Units")]
		public long cychrs;

		/// <summary>
		/// Sched Units                     
		/// </summary>
		[ColumnOrder(100)]
		[SMBFieldName("schhrs")]
		[SMBFieldDescription("Sched Units")]
		public long schhrs;

		/// <summary>
		/// Employee                        
		/// </summary>
		[ColumnOrder(110)]
		[SMBFieldName("empnum")]
		[SMBFieldDescription("Employee")]
		public long empnum;

		/// <summary>
		/// User Defined                    
		/// </summary>
		[ColumnOrder(120)]
		[SMBFieldName("usrdf1")]
		[SMBFieldDescription("User Defined")]
		public string usrdf1;

		/// <summary>
		/// Notes                           
		/// </summary>
		[ColumnOrder(130)]
		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

	}
}