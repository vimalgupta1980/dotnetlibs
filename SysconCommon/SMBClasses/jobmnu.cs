using System;

namespace SMB.Tables {
	public class jobmnu : smbtable {
		/// <summary>
		/// User Name                       
		/// </summary>
		[SMBFieldName("userid")]
		[SMBFieldDescription("User Name")]
		public string userid;

		/// <summary>
		/// First Level Menu Number         
		/// </summary>
		[SMBFieldName("menu1")]
		[SMBFieldDescription("First Level Menu Number")]
		public long menu1 ;

		/// <summary>
		/// Second Level Menu Number        
		/// </summary>
		[SMBFieldName("menu2")]
		[SMBFieldDescription("Second Level Menu Number")]
		public long menu2 ;

		/// <summary>
		/// Third Level Menu Number         
		/// </summary>
		[SMBFieldName("menu3")]
		[SMBFieldDescription("Third Level Menu Number")]
		public long menu3 ;

		/// <summary>
		/// Menu Description                
		/// </summary>
		[SMBFieldName("mnudsc")]
		[SMBFieldDescription("Menu Description")]
		public string mnudsc;

	}
}