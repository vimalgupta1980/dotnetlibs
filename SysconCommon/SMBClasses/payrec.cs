using System;
using SysconCommon.Algebras.DataTables;

namespace SMB.Tables {
	public partial class payrec : smbtable {
		/// <summary>
		/// Record#                         
		/// </summary>
		[ColumnOrder(10)]
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Record#")]
		public long recnum;

		/// <summary>
		/// Employee                        
		/// </summary>
		[ColumnOrder(20)]
		[SMBFieldName("empnum")]
		[SMBFieldDescription("Employee")]
		public long empnum;

		/// <summary>
		/// Period Start                    
		/// </summary>
		[ColumnOrder(30)]
		[SMBFieldName("strprd")]
		[SMBFieldDescription("Period Start")]
		public DateTime strprd;

		/// <summary>
		/// Period End                      
		/// </summary>
		[ColumnOrder(40)]
		[SMBFieldName("payprd")]
		[SMBFieldDescription("Period End")]
		public DateTime payprd;

		/// <summary>
		/// Check#                          
		/// </summary>
		[ColumnOrder(50)]
		[SMBFieldName("chknum")]
		[SMBFieldDescription("Check#")]
		public string chknum;

		/// <summary>
		/// Check Date                      
		/// </summary>
		[ColumnOrder(60)]
		[SMBFieldName("chkdte")]
		[SMBFieldDescription("Check Date")]
		public DateTime chkdte;

		/// <summary>
		/// State                           
		/// </summary>
		[ColumnOrder(70)]
		[SMBFieldName("taxste")]
		[SMBFieldDescription("State")]
		public string taxste;

		/// <summary>
		/// Salary                          
		/// </summary>
		[ColumnOrder(80)]
		[SMBFieldName("salary")]
		[SMBFieldDescription("Salary")]
		public decimal salary;

		/// <summary>
		/// Standard Regular Rate           
		/// </summary>
		[ColumnOrder(90)]
		[SMBFieldName("payrt1")]
		[SMBFieldDescription("Standard Regular Rate")]
		public decimal payrt1;

		/// <summary>
		/// Standard Overtime Rate          
		/// </summary>
		[ColumnOrder(100)]
		[SMBFieldName("payrt2")]
		[SMBFieldDescription("Standard Overtime Rate")]
		public decimal payrt2;

		/// <summary>
		/// Standard Premium Rate           
		/// </summary>
		[ColumnOrder(110)]
		[SMBFieldName("payrt3")]
		[SMBFieldDescription("Standard Premium Rate")]
		public decimal payrt3;

		/// <summary>
		/// Advance                         
		/// </summary>
		[ColumnOrder(120)]
		[SMBFieldName("advnce")]
		[SMBFieldDescription("Advance")]
		public decimal advnce;

		/// <summary>
		/// Payroll Type                    
		/// </summary>
		[ColumnOrder(130)]
		[SMBFieldName("paytyp")]
		[SMBFieldDescription("Payroll Type")]
		public long paytyp;

		/// <summary>
		/// Status                          
		/// </summary>
		[ColumnOrder(140)]
		[SMBFieldName("status")]
		[SMBFieldDescription("Status")]
		public long status;

		/// <summary>
		/// Quarter                         
		/// </summary>
		[ColumnOrder(150)]
		[SMBFieldName("qtrnum")]
		[SMBFieldDescription("Quarter")]
		public long qtrnum;

		/// <summary>
		/// Regular Hrs                     
		/// </summary>
		[ColumnOrder(160)]
		[SMBFieldName("reghrs")]
		[SMBFieldDescription("Regular Hrs")]
		public decimal reghrs;

		/// <summary>
		/// Overtime Hrs                    
		/// </summary>
		[ColumnOrder(170)]
		[SMBFieldName("ovthrs")]
		[SMBFieldDescription("Overtime Hrs")]
		public decimal ovthrs;

		/// <summary>
		/// Premium Hrs                     
		/// </summary>
		[ColumnOrder(180)]
		[SMBFieldName("prmhrs")]
		[SMBFieldDescription("Premium Hrs")]
		public decimal prmhrs;

		/// <summary>
		/// Sick Hrs                        
		/// </summary>
		[ColumnOrder(190)]
		[SMBFieldName("sckhrs")]
		[SMBFieldDescription("Sick Hrs")]
		public decimal sckhrs;

		/// <summary>
		/// Vacation Hrs                    
		/// </summary>
		[ColumnOrder(200)]
		[SMBFieldName("vachrs")]
		[SMBFieldDescription("Vacation Hrs")]
		public decimal vachrs;

		/// <summary>
		/// Holiday Hrs                     
		/// </summary>
		[ColumnOrder(210)]
		[SMBFieldName("holhrs")]
		[SMBFieldDescription("Holiday Hrs")]
		public decimal holhrs;

		/// <summary>
		/// Pieces                          
		/// </summary>
		[ColumnOrder(220)]
		[SMBFieldName("pieces")]
		[SMBFieldDescription("Pieces")]
		public decimal pieces;

		/// <summary>
		/// Total Hrs                       
		/// </summary>
		[ColumnOrder(230)]
		[SMBFieldName("ttlhrs")]
		[SMBFieldDescription("Total Hrs")]
		public decimal ttlhrs;

		/// <summary>
		/// Reg Pay                         
		/// </summary>
		[ColumnOrder(240)]
		[SMBFieldName("regpay")]
		[SMBFieldDescription("Reg Pay")]
		public decimal regpay;

		/// <summary>
		/// Ovt Pay                         
		/// </summary>
		[ColumnOrder(250)]
		[SMBFieldName("ovtpay")]
		[SMBFieldDescription("Ovt Pay")]
		public decimal ovtpay;

		/// <summary>
		/// Prem Pay                        
		/// </summary>
		[ColumnOrder(260)]
		[SMBFieldName("prmpay")]
		[SMBFieldDescription("Prem Pay")]
		public decimal prmpay;

		/// <summary>
		/// Sick Pay                        
		/// </summary>
		[ColumnOrder(270)]
		[SMBFieldName("sckpay")]
		[SMBFieldDescription("Sick Pay")]
		public decimal sckpay;

		/// <summary>
		/// Vac Pay                         
		/// </summary>
		[ColumnOrder(280)]
		[SMBFieldName("vacpay")]
		[SMBFieldDescription("Vac Pay")]
		public decimal vacpay;

		/// <summary>
		/// Hol Pay                         
		/// </summary>
		[ColumnOrder(290)]
		[SMBFieldName("holpay")]
		[SMBFieldDescription("Hol Pay")]
		public decimal holpay;

		/// <summary>
		/// Piece Pay                       
		/// </summary>
		[ColumnOrder(300)]
		[SMBFieldName("pcerte")]
		[SMBFieldDescription("Piece Pay")]
		public decimal pcerte;

		/// <summary>
		/// Per Diem                        
		/// </summary>
		[ColumnOrder(310)]
		[SMBFieldName("perdim")]
		[SMBFieldDescription("Per Diem")]
		public decimal perdim;

		/// <summary>
		/// Msc Pay                         
		/// </summary>
		[ColumnOrder(320)]
		[SMBFieldName("mscpay")]
		[SMBFieldDescription("Msc Pay")]
		public decimal mscpay;

		/// <summary>
		/// Gross Pay                       
		/// </summary>
		[ColumnOrder(330)]
		[SMBFieldName("grspay")]
		[SMBFieldDescription("Gross Pay")]
		public decimal grspay;

		/// <summary>
		/// Deduct Total                    
		/// </summary>
		[ColumnOrder(340)]
		[SMBFieldName("dedttl")]
		[SMBFieldDescription("Deduct Total")]
		public decimal dedttl;

		/// <summary>
		/// Add Total                       
		/// </summary>
		[ColumnOrder(350)]
		[SMBFieldName("addttl")]
		[SMBFieldDescription("Add Total")]
		public decimal addttl;

		/// <summary>
		/// Net Pay                         
		/// </summary>
		[ColumnOrder(360)]
		[SMBFieldName("netpay")]
		[SMBFieldDescription("Net Pay")]
		public decimal netpay;

		/// <summary>
		/// Entry Date                      
		/// </summary>
		[ColumnOrder(370)]
		[SMBFieldName("entdte")]
		[SMBFieldDescription("Entry Date")]
		public DateTime entdte;

		/// <summary>
		/// Hourly Rate for Pieces          
		/// </summary>
		[ColumnOrder(380)]
		[SMBFieldName("pcpyrt")]
		[SMBFieldDescription("Hourly Rate for Pieces")]
		public decimal pcpyrt;

		/// <summary>
		/// Use Direct Deposit              
		/// </summary>
		[ColumnOrder(390)]
		[SMBFieldName("dirdep")]
		[SMBFieldDescription("Use Direct Deposit")]
		public long dirdep;

		/// <summary>
		/// Ledger Ref#                     
		/// </summary>
		[ColumnOrder(400)]
		[SMBFieldName("lgrrec")]
		[SMBFieldDescription("Ledger Ref#")]
		public long lgrrec;

		/// <summary>
		/// User Name                       
		/// </summary>
		[ColumnOrder(410)]
		[SMBFieldName("usrnme")]
		[SMBFieldDescription("User Name")]
		public string usrnme;

		/// <summary>
		/// Notes                           
		/// </summary>
		[ColumnOrder(420)]
		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

		/// <summary>
		/// Direct Dep. Batch#              
		/// </summary>
		[ColumnOrder(430)]
		[SMBFieldName("ddpbch")]
		[SMBFieldDescription("Direct Dep. Batch#")]
		public long ddpbch;

	}
}