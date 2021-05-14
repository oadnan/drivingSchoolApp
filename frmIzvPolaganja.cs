using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace AutoSkola
{
	/// <summary>
	/// Summary description for frmIzvPolaganja.
	/// </summary>
	public class frmIzvPolaganja : System.Windows.Forms.Form
	{
		private CrystalDecisions.Windows.Forms.CrystalReportViewer crViewerPolaganja;
		private System.Data.SqlClient.SqlConnection connIzvPolaganja;
		private System.Data.SqlClient.SqlDataAdapter daIzvPolaganja;
        private AutoSkola.DSetovi.dsIzvPolaganja dsIzvPolaganja1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand1;

		public IzvPolaganja rpt = new IzvPolaganja();
		
		public frmIzvPolaganja()
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
			this.crViewerPolaganja = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
			this.connIzvPolaganja = new System.Data.SqlClient.SqlConnection();
			this.daIzvPolaganja = new System.Data.SqlClient.SqlDataAdapter();
            this.dsIzvPolaganja1 = new AutoSkola.DSetovi.dsIzvPolaganja();
			this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
			((System.ComponentModel.ISupportInitialize)(this.dsIzvPolaganja1)).BeginInit();
			this.SuspendLayout();
			// 
			// crViewerPolaganja
			// 
			this.crViewerPolaganja.ActiveViewIndex = -1;
			this.crViewerPolaganja.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.crViewerPolaganja.DisplayGroupTree = false;
			this.crViewerPolaganja.Location = new System.Drawing.Point(0, 0);
			this.crViewerPolaganja.Name = "crViewerPolaganja";
			this.crViewerPolaganja.ReportSource = null;
			this.crViewerPolaganja.ShowGroupTreeButton = false;
			this.crViewerPolaganja.Size = new System.Drawing.Size(904, 536);
			this.crViewerPolaganja.TabIndex = 0;
			// 
			// connIzvPolaganja
			// 
			this.connIzvPolaganja.ConnectionString = "Data Source=(local);Initial Catalog=baza;integrated security=SSPI";
			// 
			// daIzvPolaganja
			// 
			this.daIzvPolaganja.SelectCommand = this.sqlSelectCommand1;
			this.daIzvPolaganja.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																									 new System.Data.Common.DataTableMapping("Table", "Polaganja", new System.Data.Common.DataColumnMapping[] {
																																																				  new System.Data.Common.DataColumnMapping("PolaganjeID", "PolaganjeID"),
																																																				  new System.Data.Common.DataColumnMapping("KandidatID", "KandidatID"),
																																																				  new System.Data.Common.DataColumnMapping("Ime", "Ime"),
																																																				  new System.Data.Common.DataColumnMapping("Prezime", "Prezime"),
																																																				  new System.Data.Common.DataColumnMapping("DatumPolaganja", "DatumPolaganja"),
																																																				  new System.Data.Common.DataColumnMapping("Pokusaj", "Pokusaj"),
																																																				  new System.Data.Common.DataColumnMapping("Polozeno", "Polozeno"),
																																																				  new System.Data.Common.DataColumnMapping("KategorijaID", "KategorijaID"),
																																																				  new System.Data.Common.DataColumnMapping("Kategorija", "Kategorija"),
																																																				  new System.Data.Common.DataColumnMapping("InstruktorID", "InstruktorID"),
																																																				  new System.Data.Common.DataColumnMapping("ImeInst", "ImeInst"),
																																																				  new System.Data.Common.DataColumnMapping("PrezimeInst", "PrezimeInst")})});
			// 
			// dsIzvPolaganja1
			// 
			this.dsIzvPolaganja1.DataSetName = "dsIzvPolaganja";
			this.dsIzvPolaganja1.Locale = new System.Globalization.CultureInfo("hr-HR");
			// 
			// sqlSelectCommand1
			// 
			this.sqlSelectCommand1.CommandText = @"SELECT P.PolaganjeID, K.KandidatID, K.Ime, K.Prezime, P.DatumPolaganja, P.Pokusaj, P.Polozeno, Kategorije.KategorijaID, Kategorije.Kategorija, I.InstruktorID, I.Ime AS ImeInst, I.Prezime AS PrezimeInst FROM Polaganja P INNER JOIN Kandidati K ON P.KandidatID = K.KandidatID INNER JOIN Kategorije ON P.KategorijaID = Kategorije.KategorijaID INNER JOIN Instruktori I ON P.InstruktorID = I.InstruktorID ORDER BY P.PolaganjeID";
			
			// 
			// frmIzvPolaganja
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 15);
			this.ClientSize = new System.Drawing.Size(902, 534);
			this.Controls.Add(this.crViewerPolaganja);
			this.Name = "frmIzvPolaganja";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Polaganja";
			this.Load += new System.EventHandler(this.frmIzvPolaganja_Load);
			((System.ComponentModel.ISupportInitialize)(this.dsIzvPolaganja1)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void frmIzvPolaganja_Load(object sender, System.EventArgs e)
		{
			daIzvPolaganja.Fill(this.dsIzvPolaganja1, "Polaganja");
			crViewerPolaganja.ReportSource = rpt;
			rpt.SetDataSource(this.dsIzvPolaganja1);
		}
	}
}
