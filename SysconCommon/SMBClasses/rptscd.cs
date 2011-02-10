using System;
using SysconCommon.Algebras.DataTables;

namespace SMB.Tables {
	public partial class rptscd : smbtable {
		/// <summary>
		/// Schedule ID                     
		/// </summary>
		[ColumnOrder(10)]
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Schedule ID")]
		public long recnum;

		/// <summary>
		/// Report Title                    
		/// </summary>
		[ColumnOrder(20)]
		[SMBFieldName("rptttl")]
		[SMBFieldDescription("Report Title")]
		public string rptttl;

		/// <summary>
		/// Report RPF File                 
		/// </summary>
		[ColumnOrder(30)]
		[SMBFieldName("rptkey")]
		[SMBFieldDescription("Report RPF File")]
		public string rptkey;

		/// <summary>
		/// User Name                       
		/// </summary>
		[ColumnOrder(40)]
		[SMBFieldName("userid")]
		[SMBFieldDescription("User Name")]
		public string userid;

		/// <summary>
		/// Date Created                    
		/// </summary>
		[ColumnOrder(50)]
		[SMBFieldName("creatd")]
		[SMBFieldDescription("Date Created")]
		public DateTime creatd;

		/// <summary>
		/// Scheduled                       
		/// </summary>
		[ColumnOrder(60)]
		[SMBFieldName("scedul")]
		[SMBFieldDescription("Scheduled")]
		public string scedul;

		/// <summary>
		/// Printer                         
		/// </summary>
		[ColumnOrder(70)]
		[SMBFieldName("output")]
		[SMBFieldDescription("Printer")]
		public string output;

		/// <summary>
		/// Report Drive                    
		/// </summary>
		[ColumnOrder(80)]
		[SMBFieldName("rptdrv")]
		[SMBFieldDescription("Report Drive")]
		public string rptdrv;

		/// <summary>
		/// Report Form Design              
		/// </summary>
		[ColumnOrder(90)]
		[SMBFieldName("rptfrm")]
		[SMBFieldDescription("Report Form Design")]
		public string rptfrm;

		/// <summary>
		/// Report Criteria                 
		/// </summary>
		[ColumnOrder(100)]
		[SMBFieldName("dtafld")]
		[SMBFieldDescription("Report Criteria")]
		public string dtafld;

		/// <summary>
		/// Reporting Defaults              
		/// </summary>
		[ColumnOrder(110)]
		[SMBFieldName("rptdft")]
		[SMBFieldDescription("Reporting Defaults")]
		public string rptdft;

		/// <summary>
		/// Email Message                   
		/// </summary>
		[ColumnOrder(120)]
		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Email Message")]
		public string ntetxt;

		/// <summary>
		/// Subject Line                    
		/// </summary>
		[ColumnOrder(130)]
		[SMBFieldName("subjct")]
		[SMBFieldDescription("Subject Line")]
		public string subjct;

		/// <summary>
		/// Task GUID                       
		/// </summary>
		[ColumnOrder(140)]
		[SMBFieldName("tskgid")]
		[SMBFieldDescription("Task GUID")]
		public string tskgid;

		/// <summary>
		/// Machine Name                    
		/// </summary>
		[ColumnOrder(150)]
		[SMBFieldName("mchnam")]
		[SMBFieldDescription("Machine Name")]
		public string mchnam;

		/// <summary>
		/// Send Copy                       
		/// </summary>
		[ColumnOrder(160)]
		[SMBFieldName("sndcpy")]
		[SMBFieldDescription("Send Copy")]
		public string sndcpy;

		/// <summary>
		/// Read Receipt                    
		/// </summary>
		[ColumnOrder(170)]
		[SMBFieldName("rceipt")]
		[SMBFieldDescription("Read Receipt")]
		public string rceipt;

		/// <summary>
		/// Importance Level                
		/// </summary>
		[ColumnOrder(180)]
		[SMBFieldName("implvl")]
		[SMBFieldDescription("Importance Level")]
		public long implvl;

	}
}