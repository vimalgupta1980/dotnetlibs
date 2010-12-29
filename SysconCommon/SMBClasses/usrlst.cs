using System;

namespace SMB.Tables {
	public class usrlst : smbtable {
		/// <summary>
		/// User Name                       
		/// </summary>
		[SMBFieldName("usrnme")]
		[SMBFieldDescription("User Name")]
		public string usrnme;

		/// <summary>
		/// Password                        
		/// </summary>
		[SMBFieldName("usrpsw")]
		[SMBFieldDescription("Password")]
		public string usrpsw;

		/// <summary>
		/// License Group                   
		/// </summary>
		[SMBFieldName("licgrp")]
		[SMBFieldDescription("License Group")]
		public string licgrp;

		/// <summary>
		/// Group 1                         
		/// </summary>
		[SMBFieldName("group1")]
		[SMBFieldDescription("Group 1")]
		public long group1;

		/// <summary>
		/// Group 2                         
		/// </summary>
		[SMBFieldName("group2")]
		[SMBFieldDescription("Group 2")]
		public long group2;

		/// <summary>
		/// Group 3                         
		/// </summary>
		[SMBFieldName("group3")]
		[SMBFieldDescription("Group 3")]
		public long group3;

		/// <summary>
		/// Group 4                         
		/// </summary>
		[SMBFieldName("group4")]
		[SMBFieldDescription("Group 4")]
		public long group4;

		/// <summary>
		/// Group 5                         
		/// </summary>
		[SMBFieldName("group5")]
		[SMBFieldDescription("Group 5")]
		public long group5;

	}
}