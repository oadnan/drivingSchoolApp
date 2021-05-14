using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace AutoSkola
{
	/// <summary>
	/// Summary description for frmIzvDnevnikObuke.
	/// </summary>
	public class frmIzvDnevnikObuke : System.Windows.Forms.Form
	{
		private CrystalDecisions.Windows.Forms.CrystalReportViewer crViewerDnevnik;
		private System.Data.SqlClient.SqlDataAdapter daIzvDnevnikObuke;
		private System.Data.SqlClient.SqlConnection connIzvDnevnikObuke;
        private AutoSkola.DSetovi.dsIzvDnevnik dsIzvDnevnik1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand1;

		public IzvDnevnikObuke rpt = new IzvDnevnikObuke();
		
		public frmIzvDnevnikObuke()
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
			this.crViewerDnevnik = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
			this.connIzvDnevnikObuke = new System.Data.SqlClient.SqlConnection();
			this.daIzvDnevnikObuke = new System.Data.SqlClient.SqlDataAdapter();
            this.dsIzvDnevnik1 = new AutoSkola.DSetovi.dsIzvDnevnik();
			this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
			((System.ComponentModel.ISupportInitialize)(this.dsIzvDnevnik1)).BeginInit();
			this.SuspendLayout();
			// 
			// crViewerDnevnik
			// 
			this.crViewerDnevnik.ActiveViewIndex = -1;
			this.crViewerDnevnik.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.crViewerDnevnik.DisplayGroupTree = false;
			this.crViewerDnevnik.Location = new System.Drawing.Point(0, 0);
			this.crViewerDnevnik.Name = "crViewerDnevnik";
			this.crViewerDnevnik.ReportSource = null;
			this.crViewerDnevnik.ShowGroupTreeButton = false;
			this.crViewerDnevnik.Size = new System.Drawing.Size(904, 536);
			this.crViewerDnevnik.TabIndex = 0;
			// 
			// connIzvDnevnikObuke
			// 
			this.connIzvDnevnikObuke.ConnectionString = "Data Source=(local);Initial Catalog=baza;integrated security=SSPI";
			// 
			// daIzvDnevnikObuke
			// 
			this.daIzvDnevnikObuke.SelectCommand = this.sqlSelectCommand1;
			this.daIzvDnevnikObuke.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																										new System.Data.Common.DataTableMapping("Table", "DnevnikObuke", new System.Data.Common.DataColumnMapping[] {
																																																						new System.Data.Common.DataColumnMapping("CasID", "CasID"),
																																																						new System.Data.Common.DataColumnMapping("KandidatID", "KandidatID"),
																																																						new System.Data.Common.DataColumnMapping("Ime", "Ime"),
																																																						new System.Data.Common.DataColumnMapping("Prezime", "Prezime"),
																																																						new System.Data.Common.DataColumnMapping("KatID", "KatID"),
																																																						new System.Data.Common.DataColumnMapping("Kategorija", "Kategorija"),
																																																						new System.Data.Common.DataColumnMapping("DatumObuke", "DatumObuke"),
																																																						new System.Data.Common.DataColumnMapping("MetodskaJedinica", "MetodskaJedinica"),
																																																						new System.Data.Common.DataColumnMapping("MjestoObuke", "MjestoObuke"),
																																																						new System.Data.Common.DataColumnMapping("VrijemeOd", "VrijemeOd"),
																																																						new System.Data.Common.DataColumnMapping("VrijemeDo", "VrijemeDo"),
																																																						new System.Data.Common.DataColumnMapping("VoziloID", "VoziloID"),
																																																						new System.Data.Common.DataColumnMapping("Model", "Model"),
																																																						new System.Data.Common.DataColumnMapping("InstruktorID", "InstruktorID"),
																																																						new System.Data.Common.DataColumnMapping("ImeInst", "ImeInst"),
																																																						new System.Data.Common.DataColumnMapping("PrezimeInst", "PrezimeInst")})});
			// 
			// dsIzvDnevnik1
			// 
			this.dsIzvDnevnik1.DataSetName = "dsIzvDnevnik";
			this.dsIzvDnevnik1.Locale = new System.Globalization.CultureInfo("hr-HR");
			// 
			// sqlSelectCommand1
			// 
			this.sqlSelectCommand1.CommandText = @"SELECT DO.CasID, K.KandidatID, K.Ime, K.Prezime, KAT.KategorijaID AS KatID, KAT.Kategorija, DO.DatumObuke, DO.MetodskaJedinica, DO.MjestoObuke, DO.VrijemeOd, DO.VrijemeDo, V.VoziloID, V.Model, I.InstruktorID, I.Ime AS ImeInst, I.Prezime AS PrezimeInst FROM DnevnikObuke DO INNER JOIN Kandidati K ON DO.KandidatID = K.KandidatID INNER JOIN Kategorije KAT ON DO.KategorijaID = KAT.KategorijaID INNER JOIN Vozila V ON DO.VoziloID = V.VoziloID INNER JOIN Instruktori I ON DO.InstruktorID = I.InstruktorID ORDER BY DO.CasID";
			
			// 
			// frmIzvDnevnikObuke
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 15);
			this.ClientSize = new System.Drawing.Size(902, 534);
			this.Controls.Add(this.crViewerDnevnik);
			this.Name = "frmIzvDnevnikObuke";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Dnevnik obuke";
			this.Load += new System.EventHandler(this.frmIzvDnevnikObuke_Load);
			((System.ComponentModel.ISupportInitialize)(this.dsIzvDnevnik1)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void frmIzvDnevnikObuke_Load(object sender, System.EventArgs e)
		{
			daIzvDnevnikObuke.Fill(this.dsIzvDnevnik1, "DnevnikObuke");
			crViewerDnevnik.ReportSource = rpt;
			rpt.SetDataSource(this.dsIzvDnevnik1);
		}
	}
}
