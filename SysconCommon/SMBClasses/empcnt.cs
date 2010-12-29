using System;

namespace SMB.Tables {
	public class empcnt : smbtable {
		/// <summary>
		/// Employee#                       
		/// </summary>
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Employee#")]
		public long recnum;

		/// <summary>
		/// Line#                           
		/// </summary>
		[SMBFieldName("linnum")]
		[SMBFieldDescription("Line#")]
		public long linnum;

		/// <summary>
		/// Contact Name                    
		/// </summary>
		[SMBFieldName("cntnme")]
		[SMBFieldDescription("Contact Name")]
		public string cntnme;

		/// <summary>
		/// Relationship                    
		/// </summary>
		[SMBFieldName("relate")]
		[SMBFieldDescription("Relationship")]
		public string relate;

		/// <summary>
		/// Phone#                          
		/// </summary>
		[SMBFieldName("phnnum")]
		[SMBFieldDescription("Phone#")]
		public string phnnum;

		/// <summary>
		/// Extension                       
		/// </summary>
		[SMBFieldName("phnext")]
		[SMBFieldDescription("Extension")]
		public string phnext;

		/// <summary>
		/// Email                           
		/// </summary>
		[SMBFieldName("e_mail")]
		[SMBFieldDescription("Email")]
		public string e_mail;

		/// <summary>
		/// Cell Phone#                     
		/// </summary>
		[SMBFieldName("cllphn")]
		[SMBFieldDescription("Cell Phone#")]
		public string cllphn;

		/// <summary>
		/// Fax#                            
		/// </summary>
		[SMBFieldName("faxnum")]
		[SMBFieldDescription("Fax#")]
		public string faxnum;

		/// <summary>
		/// Other#                          
		/// </summary>
		[SMBFieldName("othphn")]
		[SMBFieldDescription("Other#")]
		public string othphn;

		/// <summary>
		/// Other Description               
		/// </summary>
		[SMBFieldName("othdsc")]
		[SMBFieldDescription("Other Description")]
		public string othdsc;

		/// <summary>
		/// Notes                           
		/// </summary>
		[SMBFieldName("ntetxt")]
		[SMBFieldDescription("Notes")]
		public string ntetxt;

	}
}