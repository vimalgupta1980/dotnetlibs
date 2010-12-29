using System;

namespace SMB.Tables {
	public class prelen : smbtable {
		/// <summary>
		/// Job#                            
		/// </summary>
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Job#")]
		public long recnum;

		/// <summary>
		/// Name                            
		/// </summary>
		[SMBFieldName("ownnme")]
		[SMBFieldDescription("Name")]
		public string ownnme;

		/// <summary>
		/// Address 1                       
		/// </summary>
		[SMBFieldName("ownad1")]
		[SMBFieldDescription("Address 1")]
		public string ownad1;

		/// <summary>
		/// Address 2                       
		/// </summary>
		[SMBFieldName("ownad2")]
		[SMBFieldDescription("Address 2")]
		public string ownad2;

		/// <summary>
		/// City                            
		/// </summary>
		[SMBFieldName("owncty")]
		[SMBFieldDescription("City")]
		public string owncty;

		/// <summary>
		/// State                           
		/// </summary>
		[SMBFieldName("ownste")]
		[SMBFieldDescription("State")]
		public string ownste;

		/// <summary>
		/// Zip                             
		/// </summary>
		[SMBFieldName("ownzip")]
		[SMBFieldDescription("Zip")]
		public string ownzip;

		/// <summary>
		/// Name                            
		/// </summary>
		[SMBFieldName("lndnme")]
		[SMBFieldDescription("Name")]
		public string lndnme;

		/// <summary>
		/// Address 1                       
		/// </summary>
		[SMBFieldName("lndad1")]
		[SMBFieldDescription("Address 1")]
		public string lndad1;

		/// <summary>
		/// Address 2                       
		/// </summary>
		[SMBFieldName("lndad2")]
		[SMBFieldDescription("Address 2")]
		public string lndad2;

		/// <summary>
		/// City                            
		/// </summary>
		[SMBFieldName("lndcty")]
		[SMBFieldDescription("City")]
		public string lndcty;

		/// <summary>
		/// State                           
		/// </summary>
		[SMBFieldName("lndste")]
		[SMBFieldDescription("State")]
		public string lndste;

		/// <summary>
		/// Zip                             
		/// </summary>
		[SMBFieldName("lndzip")]
		[SMBFieldDescription("Zip")]
		public string lndzip;

		/// <summary>
		/// Name                            
		/// </summary>
		[SMBFieldName("connme")]
		[SMBFieldDescription("Name")]
		public string connme;

		/// <summary>
		/// Address 1                       
		/// </summary>
		[SMBFieldName("conad1")]
		[SMBFieldDescription("Address 1")]
		public string conad1;

		/// <summary>
		/// Address 2                       
		/// </summary>
		[SMBFieldName("conad2")]
		[SMBFieldDescription("Address 2")]
		public string conad2;

		/// <summary>
		/// City                            
		/// </summary>
		[SMBFieldName("concty")]
		[SMBFieldDescription("City")]
		public string concty;

		/// <summary>
		/// State                           
		/// </summary>
		[SMBFieldName("conste")]
		[SMBFieldDescription("State")]
		public string conste;

		/// <summary>
		/// Zip                             
		/// </summary>
		[SMBFieldName("conzip")]
		[SMBFieldDescription("Zip")]
		public string conzip;

		/// <summary>
		/// Name                            
		/// </summary>
		[SMBFieldName("subnme")]
		[SMBFieldDescription("Name")]
		public string subnme;

		/// <summary>
		/// Address 1                       
		/// </summary>
		[SMBFieldName("subad1")]
		[SMBFieldDescription("Address 1")]
		public string subad1;

		/// <summary>
		/// Address 2                       
		/// </summary>
		[SMBFieldName("subad2")]
		[SMBFieldDescription("Address 2")]
		public string subad2;

		/// <summary>
		/// City                            
		/// </summary>
		[SMBFieldName("subcty")]
		[SMBFieldDescription("City")]
		public string subcty;

		/// <summary>
		/// State                           
		/// </summary>
		[SMBFieldName("subste")]
		[SMBFieldDescription("State")]
		public string subste;

		/// <summary>
		/// Zip                             
		/// </summary>
		[SMBFieldName("subzip")]
		[SMBFieldDescription("Zip")]
		public string subzip;

		/// <summary>
		/// Name                            
		/// </summary>
		[SMBFieldName("cntnme")]
		[SMBFieldDescription("Name")]
		public string cntnme;

		/// <summary>
		/// Address 1                       
		/// </summary>
		[SMBFieldName("cntad1")]
		[SMBFieldDescription("Address 1")]
		public string cntad1;

		/// <summary>
		/// Address 2                       
		/// </summary>
		[SMBFieldName("cntad2")]
		[SMBFieldDescription("Address 2")]
		public string cntad2;

		/// <summary>
		/// City                            
		/// </summary>
		[SMBFieldName("cntcty")]
		[SMBFieldDescription("City")]
		public string cntcty;

		/// <summary>
		/// State                           
		/// </summary>
		[SMBFieldName("cntste")]
		[SMBFieldDescription("State")]
		public string cntste;

		/// <summary>
		/// Zip                             
		/// </summary>
		[SMBFieldName("cntzip")]
		[SMBFieldDescription("Zip")]
		public string cntzip;

		/// <summary>
		/// Description                     
		/// </summary>
		[SMBFieldName("dscrpt")]
		[SMBFieldDescription("Description")]
		public string dscrpt;

	}
}