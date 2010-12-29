using System;

namespace SMB.Tables {
	public class payrec : smbtable {
		/// <summary>
		/// Record#                         
		/// </summary>
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Record#")]
		public long recnum;

		/// <summary>
		/// Employee                        
		/// </summary>
		[SMBFieldName("empnum")]
		[SMBFieldDescription("Employee")]
		public long empnum;

		/// <summary>
		/// Period Start                    
		/// </summary>
		[SMBFieldName("strprd")]
		[SMBFieldDescription("Period Start")]
		public DateTime strprd;

		/// <summary>
		/// Period End                      
		/// </summary>
		[SMBFieldName("payprd")]
		[SMBFieldDescription("Period End")]
		public DateTime payprd;

		/// <summary>
		/// Check#                          
		/// </summary>
		[SMBFieldName("chknum")]
		[SMBFieldDescription("Check#")]
		public string chknum;

		/// <summary>
		/// Check Date                      
		/// </summary>
		[SMBFieldName("chkdte")]
		[SMBFieldDescription("Check Date")]
		public DateTime chkdte;

		/// <summary>
		/// State                           
		/// </summary>
		[SMBFieldName("taxste")]
		[SMBFieldDescription("State")]
		public string taxste;

		/// <summary>
		/// Salary                          
		/// </summary>
		[SMBFieldName("salary")]
		[SMBFieldDescription("Salary")]
		public decimal salary;

		/// <summary>
		/// Standard Regular Rate           
		/// </summary>
		[SMBFieldName("payrt1")]
		[SMBFieldDescription("Standard Regular Rate")]
		public decimal payrt1;

		/// <summary>
		/// Standard Overtime Rate          
		/// </summary>
		[SMBFieldName("payrt2")]
		[SMBFieldDescription("Standard Overtime Rate")]
		public decimal payrt2;

		/// <summary>
		/// Standard Premium Rate           
		/// </summary>
		[SMBFieldName("payrt3")]
		[SMBFieldDescription("Standard Premium Rate")]
		public decimal payrt3;

		/// <summary>
		/// Advance                         
		/// </summary>
		[SMBFieldName("advnce")]
		[SMBFieldDescription("Advance")]
		public decimal advnce;

		/// <summary>
		/// Payroll Type                    
		/// </summary>
		[SMBFieldName("paytyp")]
		[SMBFieldDescription("Payroll Type")]
		public long paytyp;

		/// <summary>
		/// Status                          
		/// </summary>
		[SMBFieldName("status")]
		[SMBFieldDescription("Status")]
		public long status;

		/// <summary>
		/// Quarter                         
		/// </summary>
		[SMBFieldName("qtrnum")]
		[SMBFieldDescription("Quarter")]
		public long qtrnum;

		/// <summary>
		/// Regular Hrs                     
		/// </summary>
		[SMBFieldName("reghrs")]
		[SMBFieldDescription("Regular Hrs")]
		public decimal reghrs;

		/// <summary>
		/// Overtime Hrs                    
		/// </summary>
		[SMBFieldName("ovthrs")]
		[SMBFieldDescription("Overtime Hrs")]
		public decimal ovthrs;

		/// <summary>
		/// Premium Hrs                     
		/// </summary>
		[SMBFieldName("prmhrs")]
		[SMBFieldDescription("Premium Hrs")]
		public decimal prmhrs;

		/// <summary>
		/// Sick Hrs                        
		/// </summary>
		[SMBFieldName("sckhrs")]
		[SMBFieldDescription("Sick Hrs")]
		public decimal sckhrs;

		/// <summary>
		/// Vacation Hrs                    
		/// </summary>
		[SMBFieldName("vachrs")]
		[SMBFieldDescription("Vacation Hrs")]
		public decimal vachrs;

		/// <summary>
		/// Holiday Hrs                     
		/// </summary>
		[SMBFieldName("holhrs")]
		[SMBFieldDescription("Holiday Hrs")]
		public decimal holhrs;

		/// <summary>
		/// Pieces                          
		/// </summary>
		[SMBFieldName("pieces")]
		[SMBFieldDescription("Pieces")]
		public decimal pieces;

		/// <summary>
		/// Total Hrs                       
		/// </summary>
		[SMBFieldName("ttlhrs")]
		[SMBFieldDescription("Total Hrs")]
		public decimal ttlhrs;

		/// <summary>
		/// Reg Pay                         
		/// </summary>
		[SMBFieldName("regpay")]
		[SMBFieldDescription("Reg Pay")]
		public decimal regpay;

		/// <summary>
		/// Ovt Pay                         
		/// </summary>
		[SMBFieldName("ovtpay")]
		[SMBFieldDescription("Ovt Pay")]
		public decimal ovtpay;

		/// <summary>
		/// Prem Pay                        
		/// </summary>
		[SMBFieldName("prmpay")]
		[SMBFieldDescription("Prem Pay")]
		public decimal prmpay;

		/// <summary>
		/// Sick Pay                        
		/// </summary>
		[SMBFieldName("sckpay")]
		[SMBFieldDescription("Sick Pay")]
		public decimal sckpay;

		/// <summary>
		/// Vac Pay                         
		/// </summary>
		[SMBFieldName("vacpay")]
		[SMBFieldDescription("Vac Pay")]
		public decimal vacpay;

		/// <summary>
		/// Hol Pay                         
		/// </summary>
		[SMBFieldName("holpay")]
		[SMBFieldDescription("Hol Pay")]
		public decimal holpay;

		/// <summary>
		/// Piece Pay                       
		/// </summary>
		[SMBFieldName("pcerte")]
		[SMBFieldDescription("Piece Pay")]
		public decimal pcerte;

		/// <summary>
		/// Per Diem                        
		/// </summary>
		[SMBFieldName("perdim")]
		[SMBFieldDescription("Per Diem")]
		public decimal perdim;

		/// <summary>
		/// Msc Pay                         
		/// </summary>
		[SMBFieldName("mscpay")]
		[SMBFieldDescription("Msc Pay")]
		public decimal mscpay;

		/// <summary>
		/// Gross Pay                       
		/// </summary>
		[SMBFieldName("grspay")]
		[SMBFieldDescription("Gross Pay")]
		public decimal grspay;

		/// <summary>
		/// Deduct Total                    
		/// </summary>
		[SMBFieldName("dedttl")]
		[SMBFieldDescription("Deduct Total")]
		public decimal dedttl;

		/// <summary>
		/// Add Total                       
		/// </summary>
		[SMBFieldName("addttl")]
		[SMBFieldDescription("Add Total")]
		public decimal addttl;

		/// <summary>
		/// Net Pay                         
		/// </summary>
		[SMBFieldName("netpay")]
		[SMBFieldDescription("Net Pay")]
		public decimal netpay;

		/// <summary>
		/// Entry Date                      
		/// </summary>
		[SMBFieldName("entdte")]
		[SMBFieldDescription("Entry Date")]
		public DateTime entdte;

		/// <summary>
		/// Hourly Rate for Pieces          
		/// </summary>
		[SMBFieldName("pcpyrt")]
		[SMBFieldDescription("Hourly Rate for Pieces")]
		public decimal pcpyrt;

		/// <summary>
		/// Use Direct Deposit              
		/// </summary>
		[SMBFieldName("dirdep")]
		[SMBFieldDescription("Use Direct Deposit")]
		public long dirdep;

		/// <summary>
		/// Ledger Ref#                     
		/// </summary>
		[SMBFieldName("lgrrec")]
		[SMBFieldDescription("Ledger Ref#")]
		public long lgrrec;

		/// <summary>
		/// User Name                       
		/// </summary>
		[SMBFieldName("usrnme")]
		[SMBFieldDescription("User Name")]
		public string usrnme;

		/// <summary>
		/// Notes                           
		/// </summary>
		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

		/// <summary>
		/// Direct Dep. Batch#              
		/// </summary>
		[SMBFieldName("ddpbch")]
		[SMBFieldDescription("Direct Dep. Batch#")]
		public long ddpbch;

	}
}