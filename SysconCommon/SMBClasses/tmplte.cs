using System;

namespace SMB.Tables {
	public class tmplte : smbtable {
		/// <summary>
		/// Template Name                   
		/// </summary>
		[SMBFieldName("dtanme")]
		[SMBFieldDescription("Template Name")]
		public string dtanme;

		/// <summary>
		/// Line Data                       
		/// </summary>
		[SMBFieldName("dtalin")]
		[SMBFieldDescription("Line Data")]
		public string dtalin;

	}
}