using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace AutoSkola
{
	/// <summary>
	/// Summary description for frmIzvKandidati.
	/// </summary>
	public class frmIzvKandidati : System.Windows.Forms.Form
	{
		private CrystalDecisions.Windows.Forms.CrystalReportViewer crViewerKandidati;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;
		private System.Data.SqlClient.SqlConnection connIzvKandidati;
		private System.Data.SqlClient.SqlDataAdapter daIzvKandidati;
		private AutoSkola.DSetovi.dsIzvKandidati dsIzvKandidati1;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand1;

		public IzvKandidati rpt = new IzvKandidati();

		public frmIzvKandidati()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
			
			this.sqlSelectCommand1.Connection = clsKonekcija.GetConnection();
			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.crViewerKandidati = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
			this.connIzvKandidati = new System.Data.SqlClient.SqlConnection();
			this.daIzvKandidati = new System.Data.SqlClient.SqlDataAdapter();
			this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.dsIzvKandidati1 = new AutoSkola.DSetovi.dsIzvKandidati();
			((System.ComponentModel.ISupportInitialize)(this.dsIzvKandidati1)).BeginInit();
			this.SuspendLayout();
			// 
			// crViewerKandidati
			// 
			this.crViewerKandidati.ActiveViewIndex = -1;
			this.crViewerKandidati.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.crViewerKandidati.DisplayGroupTree = false;
			this.crViewerKandidati.Location = new System.Drawing.Point(0, 0);
			this.crViewerKandidati.Name = "crViewerKandidati";
			this.crViewerKandidati.ReportSource = null;
			this.crViewerKandidati.ShowGroupTreeButton = false;
			this.crViewerKandidati.Size = new System.Drawing.Size(904, 536);
			this.crViewerKandidati.TabIndex = 0;
			// 
			// connIzvKandidati
			// 
			this.connIzvKandidati.ConnectionString = "Data Source=(local);Initial Catalog=baza;integrated security=SSPI";
			// 
			// daIzvKandidati
			// 
			this.daIzvKandidati.SelectCommand = this.sqlSelectCommand1;
			this.daIzvKandidati.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																									 new System.Data.Common.DataTableMapping("Table", "Kandidati", new System.Data.Common.DataColumnMapping[] {
																																																				  new System.Data.Common.DataColumnMapping("KandidatID", "KandidatID"),
																																																				  new System.Data.Common.DataColumnMapping("Ime", "Ime"),
																																																				  new System.Data.Common.DataColumnMapping("Prezime", "Prezime"),
																																																				  new System.Data.Common.DataColumnMapping("DatumRodjenja", "DatumRodjenja"),
																																																				  new System.Data.Common.DataColumnMapping("DatumPrijavljivanja", "DatumPrijavljivanja"),
																																																				  new System.Data.Common.DataColumnMapping("Adresa", "Adresa"),
																																																				  new System.Data.Common.DataColumnMapping("Telefon", "Telefon"),
																																																				  new System.Data.Common.DataColumnMapping("Email", "Email")})});
			// 
			// sqlSelectCommand1
			// 
			this.sqlSelectCommand1.CommandText = "SELECT KandidatID, Ime, Prezime, DatumRodjenja, DatumPrijavljivanja, Adresa, Tele" +
				"fon, Email FROM Kandidati ORDER BY KandidatID";
			// 
			// dsIzvKandidati1
			// 
			this.dsIzvKandidati1.DataSetName = "dsIzvKandidati";
			this.dsIzvKandidati1.Locale = new System.Globalization.CultureInfo("hr-HR");
			// 
			// frmIzvKandidati
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 15);
			this.ClientSize = new System.Drawing.Size(902, 534);
			this.Controls.Add(this.crViewerKandidati);
			this.Name = "frmIzvKandidati";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Kandidati";
			this.Load += new System.EventHandler(this.frmIzvKandidati_Load);
			((System.ComponentModel.ISupportInitialize)(this.dsIzvKandidati1)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void frmIzvKandidati_Load(object sender, System.EventArgs e)
		{
			daIzvKandidati.Fill(this.dsIzvKandidati1, "Kandidati");
			crViewerKandidati.ReportSource = rpt;
			rpt.SetDataSource(this.dsIzvKandidati1);
		}
	}
}
