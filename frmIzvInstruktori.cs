using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace AutoSkola
{
	/// <summary>
	/// Summary description for frmIzvInstruktori.
	/// </summary>
	public class frmIzvInstruktori : System.Windows.Forms.Form
	{
		private CrystalDecisions.Windows.Forms.CrystalReportViewer crInstruktori;
		private System.Data.SqlClient.SqlConnection connIzvInstruktori;
		private System.Data.SqlClient.SqlDataAdapter daIzvInstruktori;
        private AutoSkola.DSetovi.dsIzvInstruktori dsIzvInstruktori1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand1;

		public IzvInstruktori rpt = new IzvInstruktori();
		
		public frmIzvInstruktori()
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
			this.crInstruktori = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
			this.connIzvInstruktori = new System.Data.SqlClient.SqlConnection();
			this.daIzvInstruktori = new System.Data.SqlClient.SqlDataAdapter();
			this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.dsIzvInstruktori1 = new AutoSkola.DSetovi.dsIzvInstruktori();
			((System.ComponentModel.ISupportInitialize)(this.dsIzvInstruktori1)).BeginInit();
			this.SuspendLayout();
			// 
			// crInstruktori
			// 
			this.crInstruktori.ActiveViewIndex = -1;
			this.crInstruktori.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.crInstruktori.DisplayGroupTree = false;
			this.crInstruktori.Location = new System.Drawing.Point(0, 0);
			this.crInstruktori.Name = "crInstruktori";
			this.crInstruktori.ReportSource = null;
			this.crInstruktori.ShowGroupTreeButton = false;
			this.crInstruktori.Size = new System.Drawing.Size(904, 536);
			this.crInstruktori.TabIndex = 0;
			// 
			// connIzvInstruktori
			// 
			this.connIzvInstruktori.ConnectionString = "workstation id=\"ADNAN-WUCFPZFI4\";packet size=4096;integrated security=SSPI;initia" +
				"l catalog=baza;persist security info=False";
			// 
			// daIzvInstruktori
			// 
			this.daIzvInstruktori.SelectCommand = this.sqlSelectCommand1;
			this.daIzvInstruktori.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																									   new System.Data.Common.DataTableMapping("Table", "Instruktori", new System.Data.Common.DataColumnMapping[] {
																																																					  new System.Data.Common.DataColumnMapping("InstruktorID", "InstruktorID"),
																																																					  new System.Data.Common.DataColumnMapping("Ime", "Ime"),
																																																					  new System.Data.Common.DataColumnMapping("Prezime", "Prezime"),
																																																					  new System.Data.Common.DataColumnMapping("DatumRodjenja", "DatumRodjenja"),
																																																					  new System.Data.Common.DataColumnMapping("Adresa", "Adresa"),
																																																					  new System.Data.Common.DataColumnMapping("Telefon", "Telefon"),
																																																					  new System.Data.Common.DataColumnMapping("Email", "Email"),
																																																					  new System.Data.Common.DataColumnMapping("DatumZaposlenja", "DatumZaposlenja")})});
			// 
			// sqlSelectCommand1
			// 
			this.sqlSelectCommand1.CommandText = "SELECT InstruktorID, Ime, Prezime, DatumRodjenja, Adresa, Telefon, Email, DatumZa" +
				"poslenja FROM Instruktori ORDER BY I.InstruktorID";
			
			// 
			// dsIzvInstruktori1
			// 
			this.dsIzvInstruktori1.DataSetName = "dsIzvInstruktori";
			this.dsIzvInstruktori1.Locale = new System.Globalization.CultureInfo("hr-HR");
			// 
			// frmIzvInstruktori
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 15);
			this.ClientSize = new System.Drawing.Size(902, 534);
			this.Controls.Add(this.crInstruktori);
			this.Name = "frmIzvInstruktori";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Instruktori";
			this.Load += new System.EventHandler(this.frmIzvInstruktori_Load);
			((System.ComponentModel.ISupportInitialize)(this.dsIzvInstruktori1)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void frmIzvInstruktori_Load(object sender, System.EventArgs e)
		{
			daIzvInstruktori.Fill(this.dsIzvInstruktori1, "Instruktori");
			crInstruktori.ReportSource = rpt;
			rpt.SetDataSource(this.dsIzvInstruktori1);
		}
	}
}
