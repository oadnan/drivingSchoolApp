using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace AutoSkola
{
	/// <summary>
	/// Summary description for izvjVozila.
	/// </summary>
	public class frmIzvjVozila : System.Windows.Forms.Form
	{
		private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
		private System.Data.SqlClient.SqlConnection connIzvVozila;
		private System.Data.SqlClient.SqlDataAdapter daIzvVozila;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
		private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
		private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
		private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
        private AutoSkola.DSetovi.dsIzvVozila dsIzvVozila1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public IVozila rpt = new IVozila();
		
		public frmIzvjVozila()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

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
			this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
			this.connIzvVozila = new System.Data.SqlClient.SqlConnection();
			this.daIzvVozila = new System.Data.SqlClient.SqlDataAdapter();
			this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
            this.dsIzvVozila1 = new AutoSkola.DSetovi.dsIzvVozila();
			((System.ComponentModel.ISupportInitialize)(this.dsIzvVozila1)).BeginInit();
			this.SuspendLayout();
			// 
			// crystalReportViewer1
			// 
			this.crystalReportViewer1.ActiveViewIndex = -1;
			this.crystalReportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.crystalReportViewer1.DisplayGroupTree = false;
			this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
			this.crystalReportViewer1.Name = "crystalReportViewer1";
			this.crystalReportViewer1.ReportSource = null;
			this.crystalReportViewer1.ShowGroupTreeButton = false;
			this.crystalReportViewer1.Size = new System.Drawing.Size(904, 536);
			this.crystalReportViewer1.TabIndex = 0;
			// 
			// connIzvVozila
			// 
			this.connIzvVozila.ConnectionString = "Data Source=(local);Initial Catalog=baza;integrated security=SSPI";
			// 
			// daIzvVozila
			// 
			this.daIzvVozila.DeleteCommand = this.sqlDeleteCommand1;
			this.daIzvVozila.InsertCommand = this.sqlInsertCommand1;
			this.daIzvVozila.SelectCommand = this.sqlSelectCommand1;
			this.daIzvVozila.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																								  new System.Data.Common.DataTableMapping("Table", "Vozila", new System.Data.Common.DataColumnMapping[] {
																																																			new System.Data.Common.DataColumnMapping("VoziloID", "VoziloID"),
																																																			new System.Data.Common.DataColumnMapping("Proizvodjac", "Proizvodjac"),
																																																			new System.Data.Common.DataColumnMapping("Model", "Model"),
																																																			new System.Data.Common.DataColumnMapping("Boja", "Boja"),
																																																			new System.Data.Common.DataColumnMapping("GodinaProizvodnje", "GodinaProizvodnje"),
																																																			new System.Data.Common.DataColumnMapping("RegistarskiBroj", "RegistarskiBroj"),
																																																			new System.Data.Common.DataColumnMapping("Motor", "Motor"),
																																																			new System.Data.Common.DataColumnMapping("OstaliDetalji", "OstaliDetalji")})});
			this.daIzvVozila.UpdateCommand = this.sqlUpdateCommand1;
			// 
			// sqlDeleteCommand1
			// 
			this.sqlDeleteCommand1.CommandText = @"DELETE FROM Vozila WHERE (VoziloID = @Original_VoziloID) AND (Boja = @Original_Boja OR @Original_Boja IS NULL AND Boja IS NULL) AND (GodinaProizvodnje = @Original_GodinaProizvodnje OR @Original_GodinaProizvodnje IS NULL AND GodinaProizvodnje IS NULL) AND (Model = @Original_Model OR @Original_Model IS NULL AND Model IS NULL) AND (Motor = @Original_Motor OR @Original_Motor IS NULL AND Motor IS NULL) AND (OstaliDetalji = @Original_OstaliDetalji OR @Original_OstaliDetalji IS NULL AND OstaliDetalji IS NULL) AND (Proizvodjac = @Original_Proizvodjac OR @Original_Proizvodjac IS NULL AND Proizvodjac IS NULL) AND (RegistarskiBroj = @Original_RegistarskiBroj OR @Original_RegistarskiBroj IS NULL AND RegistarskiBroj IS NULL)";
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_VoziloID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "VoziloID", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Boja", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Boja", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_GodinaProizvodnje", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "GodinaProizvodnje", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Model", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Model", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Motor", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Motor", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_OstaliDetalji", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "OstaliDetalji", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Proizvodjac", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Proizvodjac", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_RegistarskiBroj", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "RegistarskiBroj", System.Data.DataRowVersion.Original, null));
			// 
			// sqlInsertCommand1
			// 
			this.sqlInsertCommand1.CommandText = @"INSERT INTO Vozila(Proizvodjac, Model, Boja, GodinaProizvodnje, RegistarskiBroj, Motor, OstaliDetalji) VALUES (@Proizvodjac, @Model, @Boja, @GodinaProizvodnje, @RegistarskiBroj, @Motor, @OstaliDetalji); SELECT VoziloID, Proizvodjac, Model, Boja, GodinaProizvodnje, RegistarskiBroj, Motor, OstaliDetalji FROM Vozila WHERE (VoziloID = @@IDENTITY) ORDER BY VoziloID";
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Proizvodjac", System.Data.SqlDbType.VarChar, 50, "Proizvodjac"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Model", System.Data.SqlDbType.VarChar, 50, "Model"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Boja", System.Data.SqlDbType.VarChar, 50, "Boja"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@GodinaProizvodnje", System.Data.SqlDbType.VarChar, 50, "GodinaProizvodnje"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@RegistarskiBroj", System.Data.SqlDbType.VarChar, 50, "RegistarskiBroj"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Motor", System.Data.SqlDbType.VarChar, 50, "Motor"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@OstaliDetalji", System.Data.SqlDbType.VarChar, 50, "OstaliDetalji"));
			// 
			// sqlSelectCommand1
			// 
			this.sqlSelectCommand1.CommandText = "SELECT VoziloID, Proizvodjac, Model, Boja, GodinaProizvodnje, RegistarskiBroj, Mo" +
				"tor, OstaliDetalji FROM Vozila ORDER BY VoziloID";
			this.sqlSelectCommand1.Connection = this.connIzvVozila;
			// 
			// sqlUpdateCommand1
			// 
			this.sqlUpdateCommand1.CommandText = @"UPDATE Vozila SET Proizvodjac = @Proizvodjac, Model = @Model, Boja = @Boja, GodinaProizvodnje = @GodinaProizvodnje, RegistarskiBroj = @RegistarskiBroj, Motor = @Motor, OstaliDetalji = @OstaliDetalji WHERE (VoziloID = @Original_VoziloID) AND (Boja = @Original_Boja OR @Original_Boja IS NULL AND Boja IS NULL) AND (GodinaProizvodnje = @Original_GodinaProizvodnje OR @Original_GodinaProizvodnje IS NULL AND GodinaProizvodnje IS NULL) AND (Model = @Original_Model OR @Original_Model IS NULL AND Model IS NULL) AND (Motor = @Original_Motor OR @Original_Motor IS NULL AND Motor IS NULL) AND (OstaliDetalji = @Original_OstaliDetalji OR @Original_OstaliDetalji IS NULL AND OstaliDetalji IS NULL) AND (Proizvodjac = @Original_Proizvodjac OR @Original_Proizvodjac IS NULL AND Proizvodjac IS NULL) AND (RegistarskiBroj = @Original_RegistarskiBroj OR @Original_RegistarskiBroj IS NULL AND RegistarskiBroj IS NULL); SELECT VoziloID, Proizvodjac, Model, Boja, GodinaProizvodnje, RegistarskiBroj, Motor, OstaliDetalji FROM Vozila WHERE (VoziloID = @VoziloID) ORDER BY VoziloID";
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Proizvodjac", System.Data.SqlDbType.VarChar, 50, "Proizvodjac"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Model", System.Data.SqlDbType.VarChar, 50, "Model"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Boja", System.Data.SqlDbType.VarChar, 50, "Boja"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@GodinaProizvodnje", System.Data.SqlDbType.VarChar, 50, "GodinaProizvodnje"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@RegistarskiBroj", System.Data.SqlDbType.VarChar, 50, "RegistarskiBroj"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Motor", System.Data.SqlDbType.VarChar, 50, "Motor"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@OstaliDetalji", System.Data.SqlDbType.VarChar, 50, "OstaliDetalji"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_VoziloID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "VoziloID", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Boja", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Boja", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_GodinaProizvodnje", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "GodinaProizvodnje", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Model", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Model", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Motor", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Motor", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_OstaliDetalji", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "OstaliDetalji", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Proizvodjac", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Proizvodjac", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_RegistarskiBroj", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "RegistarskiBroj", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@VoziloID", System.Data.SqlDbType.Int, 4, "VoziloID"));
			// 
			// dsIzvVozila1
			// 
			this.dsIzvVozila1.DataSetName = "dsIzvVozila";
			this.dsIzvVozila1.Locale = new System.Globalization.CultureInfo("hr-HR");
			// 
			// frmIzvjVozila
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 15);
			this.ClientSize = new System.Drawing.Size(902, 534);
			this.Controls.Add(this.crystalReportViewer1);
			this.Name = "frmIzvjVozila";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Vozila";
			this.Load += new System.EventHandler(this.IzvjVozila_Load);
			((System.ComponentModel.ISupportInitialize)(this.dsIzvVozila1)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void IzvjVozila_Load(object sender, System.EventArgs e)
		{
			daIzvVozila.Fill(this.dsIzvVozila1, "Vozila");
			crystalReportViewer1.ReportSource = rpt;
			rpt.SetDataSource(this.dsIzvVozila1);
			
		}

		
	}
}
