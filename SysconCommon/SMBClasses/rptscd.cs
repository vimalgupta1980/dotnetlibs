using System;

namespace SMB.Tables {
	public class rptscd : smbtable {
		/// <summary>
		/// Schedule ID                     
		/// </summary>
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Schedule ID")]
		public long recnum;

		/// <summary>
		/// Report Title                    
		/// </summary>
		[SMBFieldName("rptttl")]
		[SMBFieldDescription("Report Title")]
		public string rptttl;

		/// <summary>
		/// Report RPF File                 
		/// </summary>
		[SMBFieldName("rptkey")]
		[SMBFieldDescription("Report RPF File")]
		public string rptkey;

		/// <summary>
		/// User Name                       
		/// </summary>
		[SMBFieldName("userid")]
		[SMBFieldDescription("User Name")]
		public string userid;

		/// <summary>
		/// Date Created                    
		/// </summary>
		[SMBFieldName("creatd")]
		[SMBFieldDescription("Date Created")]
		public DateTime creatd;

		/// <summary>
		/// Scheduled                       
		/// </summary>
		[SMBFieldName("scedul")]
		[SMBFieldDescription("Scheduled")]
		public string scedul;

		/// <summary>
		/// Printer                         
		/// </summary>
		[SMBFieldName("output")]
		[SMBFieldDescription("Printer")]
		public string output;

		/// <summary>
		/// Report Drive                    
		/// </summary>
		[SMBFieldName("rptdrv")]
		[SMBFieldDescription("Report Drive")]
		public string rptdrv;

		/// <summary>
		/// Report Form Design              
		/// </summary>
		[SMBFieldName("rptfrm")]
		[SMBFieldDescription("Report Form Design")]
		public string rptfrm;

		/// <summary>
		/// Report Criteria                 
		/// </summary>
		[SMBFieldName("dtafld")]
		[SMBFieldDescription("Report Criteria")]
		public string dtafld;

		/// <summary>
		/// Reporting Defaults              
		/// </summary>
		[SMBFieldName("rptdft")]
		[SMBFieldDescription("Reporting Defaults")]
		public string rptdft;

		/// <summary>
		/// Email Message                   
		/// </summary>
		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Email Message")]
		public string ntetxt;

		/// <summary>
		/// Subject Line                    
		/// </summary>
		[SMBFieldName("subjct")]
		[SMBFieldDescription("Subject Line")]
		public string subjct;

		/// <summary>
		/// Task GUID                       
		/// </summary>
		[SMBFieldName("tskgid")]
		[SMBFieldDescription("Task GUID")]
		public string tskgid;

		/// <summary>
		/// Machine Name                    
		/// </summary>
		[SMBFieldName("mchnam")]
		[SMBFieldDescription("Machine Name")]
		public string mchnam;

		/// <summary>
		/// Send Copy                       
		/// </summary>
		[SMBFieldName("sndcpy")]
		[SMBFieldDescription("Send Copy")]
		public string sndcpy;

		/// <summary>
		/// Read Receipt                    
		/// </summary>
		[SMBFieldName("rceipt")]
		[SMBFieldDescription("Read Receipt")]
		public string rceipt;

		/// <summary>
		/// Importance Level                
		/// </summary>
		[SMBFieldName("implvl")]
		[SMBFieldDescription("Importance Level")]
		public long implvl;

	}
}