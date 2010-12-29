using System;

namespace SMB.Tables {
	public class eqpmln : smbtable {
		/// <summary>
		/// Equipment#                      
		/// </summary>
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Equipment#")]
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
		/// Cost Code                       
		/// </summary>
		[SMBFieldName("cstcde")]
		[SMBFieldDescription("Cost Code")]
		public decimal cstcde;

		/// <summary>
		/// Comp Date                       
		/// </summary>
		[SMBFieldName("cmpday")]
		[SMBFieldDescription("Comp Date")]
		public DateTime cmpday;

		/// <summary>
		/// Cycle Days                      
		/// </summary>
		[SMBFieldName("cycday")]
		[SMBFieldDescription("Cycle Days")]
		public long cycday;

		/// <summary>
		/// Sched Date                      
		/// </summary>
		[SMBFieldName("schdte")]
		[SMBFieldDescription("Sched Date")]
		public DateTime schdte;

		/// <summary>
		/// Comp Units                      
		/// </summary>
		[SMBFieldName("cmphrs")]
		[SMBFieldDescription("Comp Units")]
		public long cmphrs;

		/// <summary>
		/// Cycle Units                     
		/// </summary>
		[SMBFieldName("cychrs")]
		[SMBFieldDescription("Cycle Units")]
		public long cychrs;

		/// <summary>
		/// Sched Units                     
		/// </summary>
		[SMBFieldName("schhrs")]
		[SMBFieldDescription("Sched Units")]
		public long schhrs;

		/// <summary>
		/// Employee                        
		/// </summary>
		[SMBFieldName("empnum")]
		[SMBFieldDescription("Employee")]
		public long empnum;

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