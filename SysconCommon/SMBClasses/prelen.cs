using System;
using SysconCommon.Algebras.DataTables;

namespace SMB.Tables {
	public partial class prelen : smbtable {
		/// <summary>
		/// Job#                            
		/// </summary>
		[ColumnOrder(10)]
		[SMBFieldName("recnum")]
		[SMBFieldDescription("Job#")]
		public long recnum;

		/// <summary>
		/// Name                            
		/// </summary>
		[ColumnOrder(20)]
		[SMBFieldName("ownnme")]
		[SMBFieldDescription("Name")]
		public string ownnme;

		/// <summary>
		/// Address 1                       
		/// </summary>
		[ColumnOrder(30)]
		[SMBFieldName("ownad1")]
		[SMBFieldDescription("Address 1")]
		public string ownad1;

		/// <summary>
		/// Address 2                       
		/// </summary>
		[ColumnOrder(40)]
		[SMBFieldName("ownad2")]
		[SMBFieldDescription("Address 2")]
		public string ownad2;

		/// <summary>
		/// City                            
		/// </summary>
		[ColumnOrder(50)]
		[SMBFieldName("owncty")]
		[SMBFieldDescription("City")]
		public string owncty;

		/// <summary>
		/// State                           
		/// </summary>
		[ColumnOrder(60)]
		[SMBFieldName("ownste")]
		[SMBFieldDescription("State")]
		public string ownste;

		/// <summary>
		/// Zip                             
		/// </summary>
		[ColumnOrder(70)]
		[SMBFieldName("ownzip")]
		[SMBFieldDescription("Zip")]
		public string ownzip;

		/// <summary>
		/// Name                            
		/// </summary>
		[ColumnOrder(80)]
		[SMBFieldName("lndnme")]
		[SMBFieldDescription("Name")]
		public string lndnme;

		/// <summary>
		/// Address 1                       
		/// </summary>
		[ColumnOrder(90)]
		[SMBFieldName("lndad1")]
		[SMBFieldDescription("Address 1")]
		public string lndad1;

		/// <summary>
		/// Address 2                       
		/// </summary>
		[ColumnOrder(100)]
		[SMBFieldName("lndad2")]
		[SMBFieldDescription("Address 2")]
		public string lndad2;

		/// <summary>
		/// City                            
		/// </summary>
		[ColumnOrder(110)]
		[SMBFieldName("lndcty")]
		[SMBFieldDescription("City")]
		public string lndcty;

		/// <summary>
		/// State                           
		/// </summary>
		[ColumnOrder(120)]
		[SMBFieldName("lndste")]
		[SMBFieldDescription("State")]
		public string lndste;

		/// <summary>
		/// Zip                             
		/// </summary>
		[ColumnOrder(130)]
		[SMBFieldName("lndzip")]
		[SMBFieldDescription("Zip")]
		public string lndzip;

		/// <summary>
		/// Name                            
		/// </summary>
		[ColumnOrder(140)]
		[SMBFieldName("connme")]
		[SMBFieldDescription("Name")]
		public string connme;

		/// <summary>
		/// Address 1                       
		/// </summary>
		[ColumnOrder(150)]
		[SMBFieldName("conad1")]
		[SMBFieldDescription("Address 1")]
		public string conad1;

		/// <summary>
		/// Address 2                       
		/// </summary>
		[ColumnOrder(160)]
		[SMBFieldName("conad2")]
		[SMBFieldDescription("Address 2")]
		public string conad2;

		/// <summary>
		/// City                            
		/// </summary>
		[ColumnOrder(170)]
		[SMBFieldName("concty")]
		[SMBFieldDescription("City")]
		public string concty;

		/// <summary>
		/// State                           
		/// </summary>
		[ColumnOrder(180)]
		[SMBFieldName("conste")]
		[SMBFieldDescription("State")]
		public string conste;

		/// <summary>
		/// Zip                             
		/// </summary>
		[ColumnOrder(190)]
		[SMBFieldName("conzip")]
		[SMBFieldDescription("Zip")]
		public string conzip;

		/// <summary>
		/// Name                            
		/// </summary>
		[ColumnOrder(200)]
		[SMBFieldName("subnme")]
		[SMBFieldDescription("Name")]
		public string subnme;

		/// <summary>
		/// Address 1                       
		/// </summary>
		[ColumnOrder(210)]
		[SMBFieldName("subad1")]
		[SMBFieldDescription("Address 1")]
		public string subad1;

		/// <summary>
		/// Address 2                       
		/// </summary>
		[ColumnOrder(220)]
		[SMBFieldName("subad2")]
		[SMBFieldDescription("Address 2")]
		public string subad2;

		/// <summary>
		/// City                            
		/// </summary>
		[ColumnOrder(230)]
		[SMBFieldName("subcty")]
		[SMBFieldDescription("City")]
		public string subcty;

		/// <summary>
		/// State                           
		/// </summary>
		[ColumnOrder(240)]
		[SMBFieldName("subste")]
		[SMBFieldDescription("State")]
		public string subste;

		/// <summary>
		/// Zip                             
		/// </summary>
		[ColumnOrder(250)]
		[SMBFieldName("subzip")]
		[SMBFieldDescription("Zip")]
		public string subzip;

		/// <summary>
		/// Name                            
		/// </summary>
		[ColumnOrder(260)]
		[SMBFieldName("cntnme")]
		[SMBFieldDescription("Name")]
		public string cntnme;

		/// <summary>
		/// Address 1                       
		/// </summary>
		[ColumnOrder(270)]
		[SMBFieldName("cntad1")]
		[SMBFieldDescription("Address 1")]
		public string cntad1;

		/// <summary>
		/// Address 2                       
		/// </summary>
		[ColumnOrder(280)]
		[SMBFieldName("cntad2")]
		[SMBFieldDescription("Address 2")]
		public string cntad2;

		/// <summary>
		/// City                            
		/// </summary>
		[ColumnOrder(290)]
		[SMBFieldName("cntcty")]
		[SMBFieldDescription("City")]
		public string cntcty;

		/// <summary>
		/// State                           
		/// </summary>
		[ColumnOrder(300)]
		[SMBFieldName("cntste")]
		[SMBFieldDescription("State")]
		public string cntste;

		/// <summary>
		/// Zip                             
		/// </summary>
		[ColumnOrder(310)]
		[SMBFieldName("cntzip")]
		[SMBFieldDescription("Zip")]
		public string cntzip;

		/// <summary>
		/// Description                     
		/// </summary>
		[ColumnOrder(320)]
		[SMBFieldName("dscrpt")]
		[SMBFieldDescription("Description")]
		public string dscrpt;

	}
}