using System;
using SysconCommon.Algebras.DataTables;

namespace SMB.Tables {
	public partial class schlin : smbtable {
		/// <summary>
		/// Job#                            
		/// </summary>
		[ColumnOrder(10)]
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Job#")]
		public long recnum;

		/// <summary>
		/// Phase#                          
		/// </summary>
		[ColumnOrder(20)]
		[SMBFieldName("phsnum")]
		[SMBFieldDescription("Phase#")]
		public long phsnum;

		/// <summary>
		/// Line#                           
		/// </summary>
		[ColumnOrder(30)]
		[SMBFieldName("linnum")]
		[SMBFieldDescription("Line#")]
		public long linnum;

		/// <summary>
		/// Task#                           
		/// </summary>
		[ColumnOrder(40)]
		[SMBFieldName("tsknum")]
		[SMBFieldDescription("Task#")]
		public decimal tsknum;

		/// <summary>
		/// Description                     
		/// </summary>
		[ColumnOrder(50)]
		[SMBFieldName("tsknme")]
		[SMBFieldDescription("Description")]
		public string tsknme;

		/// <summary>
		/// Duration                        
		/// </summary>
		[ColumnOrder(60)]
		[SMBFieldName("tskdur")]
		[SMBFieldDescription("Duration")]
		public long tskdur;

		/// <summary>
		/// Task Type                       
		/// </summary>
		[ColumnOrder(70)]
		[SMBFieldName("tsktyp")]
		[SMBFieldDescription("Task Type")]
		public long tsktyp;

		/// <summary>
		/// Fixed Date                      
		/// </summary>
		[ColumnOrder(80)]
		[SMBFieldName("fxddte")]
		[SMBFieldDescription("Fixed Date")]
		public DateTime fxddte;

		/// <summary>
		/// Not Before                      
		/// </summary>
		[ColumnOrder(90)]
		[SMBFieldName("notbfr")]
		[SMBFieldDescription("Not Before")]
		public DateTime notbfr;

		/// <summary>
		/// Not After                       
		/// </summary>
		[ColumnOrder(100)]
		[SMBFieldName("notaft")]
		[SMBFieldDescription("Not After")]
		public DateTime notaft;

		/// <summary>
		/// Start Date                      
		/// </summary>
		[ColumnOrder(110)]
		[SMBFieldName("strdte")]
		[SMBFieldDescription("Start Date")]
		public DateTime strdte;

		/// <summary>
		/// Finish Date                     
		/// </summary>
		[ColumnOrder(120)]
		[SMBFieldName("findte")]
		[SMBFieldDescription("Finish Date")]
		public DateTime findte;

		/// <summary>
		/// Late Start                      
		/// </summary>
		[ColumnOrder(130)]
		[SMBFieldName("ltestr")]
		[SMBFieldDescription("Late Start")]
		public DateTime ltestr;

		/// <summary>
		/// Late Finish                     
		/// </summary>
		[ColumnOrder(140)]
		[SMBFieldName("ltefin")]
		[SMBFieldDescription("Late Finish")]
		public DateTime ltefin;

		/// <summary>
		/// Float                           
		/// </summary>
		[ColumnOrder(150)]
		[SMBFieldName("tskflt")]
		[SMBFieldDescription("Float")]
		public long tskflt;

		/// <summary>
		/// Original Duration               
		/// </summary>
		[ColumnOrder(160)]
		[SMBFieldName("orgdur")]
		[SMBFieldDescription("Original Duration")]
		public long orgdur;

		/// <summary>
		/// Original Start                  
		/// </summary>
		[ColumnOrder(170)]
		[SMBFieldName("orgstr")]
		[SMBFieldDescription("Original Start")]
		public DateTime orgstr;

		/// <summary>
		/// Original Finish                 
		/// </summary>
		[ColumnOrder(180)]
		[SMBFieldName("orgfin")]
		[SMBFieldDescription("Original Finish")]
		public DateTime orgfin;

		/// <summary>
		/// Original Float                  
		/// </summary>
		[ColumnOrder(190)]
		[SMBFieldName("orgflt")]
		[SMBFieldDescription("Original Float")]
		public long orgflt;

		/// <summary>
		/// User Defined                    
		/// </summary>
		[ColumnOrder(200)]
		[SMBFieldName("usrdf1")]
		[SMBFieldDescription("User Defined")]
		public string usrdf1;

		/// <summary>
		/// Notes                           
		/// </summary>
		[ColumnOrder(210)]
		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

	}
}