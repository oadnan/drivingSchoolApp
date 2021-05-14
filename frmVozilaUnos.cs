using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace AutoSkola
{
	/// <summary>
	/// Summary description for frmVozilaUnos.
	/// </summary>
	public class frmVozilaUnos : System.Windows.Forms.Form
	{
		private System.Windows.Forms.GroupBox gbPodaci;
		private System.Windows.Forms.TextBox tbRegistarskiBroj;
		private System.Windows.Forms.Label lbRegistarskiBroj;
		private System.Windows.Forms.TextBox tbOstaliDetalji;
		private System.Windows.Forms.TextBox tbMotor;
		private System.Windows.Forms.TextBox tbGodProizvodnje;
		private System.Windows.Forms.TextBox tbModel;
		private System.Windows.Forms.TextBox tbProizvodjac;
		private System.Windows.Forms.TextBox tbVoziloID;
		private System.Windows.Forms.Label lbOstaliDetalji;
		private System.Windows.Forms.Label lbMotor;
		private System.Windows.Forms.Label lbGodinaProizvodnje;
		private System.Windows.Forms.Label lbModel;
        private System.Windows.Forms.Label lbProizvodjac;
		private System.Windows.Forms.GroupBox gbOpcije;
		private System.Windows.Forms.Button duZatvori;
        private System.Windows.Forms.Button duSpasi;
		private System.Windows.Forms.Label lbBoja;
		private System.Windows.Forms.TextBox tbBoja;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		int opcija=0;
		private System.Data.SqlClient.SqlConnection connVozilaUnos;
		clsVozila vozilo = new clsVozila();
		
		public frmVozilaUnos()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVozilaUnos));
            this.gbPodaci = new System.Windows.Forms.GroupBox();
            this.tbBoja = new System.Windows.Forms.TextBox();
            this.tbRegistarskiBroj = new System.Windows.Forms.TextBox();
            this.lbRegistarskiBroj = new System.Windows.Forms.Label();
            this.tbOstaliDetalji = new System.Windows.Forms.TextBox();
            this.tbMotor = new System.Windows.Forms.TextBox();
            this.tbGodProizvodnje = new System.Windows.Forms.TextBox();
            this.tbModel = new System.Windows.Forms.TextBox();
            this.tbProizvodjac = new System.Windows.Forms.TextBox();
            this.tbVoziloID = new System.Windows.Forms.TextBox();
            this.lbOstaliDetalji = new System.Windows.Forms.Label();
            this.lbMotor = new System.Windows.Forms.Label();
            this.lbGodinaProizvodnje = new System.Windows.Forms.Label();
            this.lbBoja = new System.Windows.Forms.Label();
            this.lbModel = new System.Windows.Forms.Label();
            this.lbProizvodjac = new System.Windows.Forms.Label();
            this.gbOpcije = new System.Windows.Forms.GroupBox();
            this.duZatvori = new System.Windows.Forms.Button();
            this.duSpasi = new System.Windows.Forms.Button();
            this.connVozilaUnos = new System.Data.SqlClient.SqlConnection();
            this.gbPodaci.SuspendLayout();
            this.gbOpcije.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbPodaci
            // 
            this.gbPodaci.BackColor = System.Drawing.SystemColors.Control;
            this.gbPodaci.Controls.Add(this.tbBoja);
            this.gbPodaci.Controls.Add(this.tbRegistarskiBroj);
            this.gbPodaci.Controls.Add(this.lbRegistarskiBroj);
            this.gbPodaci.Controls.Add(this.tbOstaliDetalji);
            this.gbPodaci.Controls.Add(this.tbMotor);
            this.gbPodaci.Controls.Add(this.tbGodProizvodnje);
            this.gbPodaci.Controls.Add(this.tbModel);
            this.gbPodaci.Controls.Add(this.tbProizvodjac);
            this.gbPodaci.Controls.Add(this.tbVoziloID);
            this.gbPodaci.Controls.Add(this.lbOstaliDetalji);
            this.gbPodaci.Controls.Add(this.lbMotor);
            this.gbPodaci.Controls.Add(this.lbGodinaProizvodnje);
            this.gbPodaci.Controls.Add(this.lbBoja);
            this.gbPodaci.Controls.Add(this.lbModel);
            this.gbPodaci.Controls.Add(this.lbProizvodjac);
            this.gbPodaci.Location = new System.Drawing.Point(11, 8);
            this.gbPodaci.Name = "gbPodaci";
            this.gbPodaci.Size = new System.Drawing.Size(317, 299);
            this.gbPodaci.TabIndex = 4;
            this.gbPodaci.TabStop = false;
            this.gbPodaci.Text = "Unos podataka";
            // 
            // tbBoja
            // 
            this.tbBoja.Location = new System.Drawing.Point(144, 100);
            this.tbBoja.Name = "tbBoja";
            this.tbBoja.Size = new System.Drawing.Size(152, 22);
            this.tbBoja.TabIndex = 2;
            // 
            // tbRegistarskiBroj
            // 
            this.tbRegistarskiBroj.Location = new System.Drawing.Point(144, 204);
            this.tbRegistarskiBroj.Name = "tbRegistarskiBroj";
            this.tbRegistarskiBroj.Size = new System.Drawing.Size(152, 22);
            this.tbRegistarskiBroj.TabIndex = 5;
            // 
            // lbRegistarskiBroj
            // 
            this.lbRegistarskiBroj.Location = new System.Drawing.Point(16, 172);
            this.lbRegistarskiBroj.Name = "lbRegistarskiBroj";
            this.lbRegistarskiBroj.Size = new System.Drawing.Size(120, 23);
            this.lbRegistarskiBroj.TabIndex = 17;
            this.lbRegistarskiBroj.Text = "Registarski broj:";
            this.lbRegistarskiBroj.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbOstaliDetalji
            // 
            this.tbOstaliDetalji.Location = new System.Drawing.Point(144, 236);
            this.tbOstaliDetalji.Multiline = true;
            this.tbOstaliDetalji.Name = "tbOstaliDetalji";
            this.tbOstaliDetalji.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbOstaliDetalji.Size = new System.Drawing.Size(152, 45);
            this.tbOstaliDetalji.TabIndex = 6;
            // 
            // tbMotor
            // 
            this.tbMotor.Location = new System.Drawing.Point(144, 172);
            this.tbMotor.Name = "tbMotor";
            this.tbMotor.Size = new System.Drawing.Size(152, 22);
            this.tbMotor.TabIndex = 4;
            // 
            // tbGodProizvodnje
            // 
            this.tbGodProizvodnje.Location = new System.Drawing.Point(144, 137);
            this.tbGodProizvodnje.Name = "tbGodProizvodnje";
            this.tbGodProizvodnje.Size = new System.Drawing.Size(152, 22);
            this.tbGodProizvodnje.TabIndex = 3;
            // 
            // tbModel
            // 
            this.tbModel.Location = new System.Drawing.Point(144, 67);
            this.tbModel.Name = "tbModel";
            this.tbModel.Size = new System.Drawing.Size(152, 22);
            this.tbModel.TabIndex = 1;
            // 
            // tbProizvodjac
            // 
            this.tbProizvodjac.Location = new System.Drawing.Point(144, 32);
            this.tbProizvodjac.Name = "tbProizvodjac";
            this.tbProizvodjac.Size = new System.Drawing.Size(152, 22);
            this.tbProizvodjac.TabIndex = 0;
            // 
            // tbVoziloID
            // 
            this.tbVoziloID.Location = new System.Drawing.Point(144, 32);
            this.tbVoziloID.Name = "tbVoziloID";
            this.tbVoziloID.ReadOnly = true;
            this.tbVoziloID.Size = new System.Drawing.Size(46, 22);
            this.tbVoziloID.TabIndex = 0;
            this.tbVoziloID.TabStop = false;
            this.tbVoziloID.Visible = false;
            // 
            // lbOstaliDetalji
            // 
            this.lbOstaliDetalji.Location = new System.Drawing.Point(16, 236);
            this.lbOstaliDetalji.Name = "lbOstaliDetalji";
            this.lbOstaliDetalji.Size = new System.Drawing.Size(120, 23);
            this.lbOstaliDetalji.TabIndex = 6;
            this.lbOstaliDetalji.Text = "Ostali Detalji:";
            this.lbOstaliDetalji.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbMotor
            // 
            this.lbMotor.Location = new System.Drawing.Point(16, 204);
            this.lbMotor.Name = "lbMotor";
            this.lbMotor.Size = new System.Drawing.Size(120, 23);
            this.lbMotor.TabIndex = 5;
            this.lbMotor.Text = "Motor:";
            this.lbMotor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbGodinaProizvodnje
            // 
            this.lbGodinaProizvodnje.Location = new System.Drawing.Point(16, 136);
            this.lbGodinaProizvodnje.Name = "lbGodinaProizvodnje";
            this.lbGodinaProizvodnje.Size = new System.Drawing.Size(128, 23);
            this.lbGodinaProizvodnje.TabIndex = 4;
            this.lbGodinaProizvodnje.Text = "Godina proizvodnje:";
            this.lbGodinaProizvodnje.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbBoja
            // 
            this.lbBoja.Location = new System.Drawing.Point(16, 101);
            this.lbBoja.Name = "lbBoja";
            this.lbBoja.Size = new System.Drawing.Size(120, 23);
            this.lbBoja.TabIndex = 3;
            this.lbBoja.Text = "Boja:";
            this.lbBoja.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbModel
            // 
            this.lbModel.Location = new System.Drawing.Point(16, 66);
            this.lbModel.Name = "lbModel";
            this.lbModel.Size = new System.Drawing.Size(120, 23);
            this.lbModel.TabIndex = 2;
            this.lbModel.Text = "Model:";
            this.lbModel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbProizvodjac
            // 
            this.lbProizvodjac.Location = new System.Drawing.Point(16, 31);
            this.lbProizvodjac.Name = "lbProizvodjac";
            this.lbProizvodjac.Size = new System.Drawing.Size(120, 23);
            this.lbProizvodjac.TabIndex = 1;
            this.lbProizvodjac.Text = "Proizvodac:";
            this.lbProizvodjac.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gbOpcije
            // 
            this.gbOpcije.BackColor = System.Drawing.SystemColors.Control;
            this.gbOpcije.Controls.Add(this.duZatvori);
            this.gbOpcije.Controls.Add(this.duSpasi);
            this.gbOpcije.Location = new System.Drawing.Point(11, 313);
            this.gbOpcije.Name = "gbOpcije";
            this.gbOpcije.Size = new System.Drawing.Size(317, 72);
            this.gbOpcije.TabIndex = 5;
            this.gbOpcije.TabStop = false;
            this.gbOpcije.Text = "Opcije";
            // 
            // duZatvori
            // 
            this.duZatvori.BackColor = System.Drawing.Color.Beige;
            this.duZatvori.Cursor = System.Windows.Forms.Cursors.Hand;
            this.duZatvori.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.duZatvori.Image = ((System.Drawing.Image)(resources.GetObject("duZatvori.Image")));
            this.duZatvori.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.duZatvori.Location = new System.Drawing.Point(176, 24);
            this.duZatvori.Name = "duZatvori";
            this.duZatvori.Size = new System.Drawing.Size(112, 32);
            this.duZatvori.TabIndex = 2;
            this.duZatvori.Text = "       Zatvori";
            this.duZatvori.UseVisualStyleBackColor = false;
            this.duZatvori.Click += new System.EventHandler(this.duZatvori_Click);
            // 
            // duSpasi
            // 
            this.duSpasi.BackColor = System.Drawing.Color.Beige;
            this.duSpasi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.duSpasi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.duSpasi.Image = ((System.Drawing.Image)(resources.GetObject("duSpasi.Image")));
            this.duSpasi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.duSpasi.Location = new System.Drawing.Point(32, 24);
            this.duSpasi.Name = "duSpasi";
            this.duSpasi.Size = new System.Drawing.Size(112, 32);
            this.duSpasi.TabIndex = 0;
            this.duSpasi.Text = "Spasi";
            this.duSpasi.UseVisualStyleBackColor = false;
            this.duSpasi.Click += new System.EventHandler(this.duSpasi_Click);
            // 
            // connVozilaUnos
            // 
            this.connVozilaUnos.ConnectionString = "Data Source=(local);Initial Catalog=baza;integrated security=SSPI";
            this.connVozilaUnos.FireInfoMessageEventOnUserErrors = false;
            // 
            // frmVozilaUnos
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 15);
            this.ClientSize = new System.Drawing.Size(338, 395);
            this.Controls.Add(this.gbOpcije);
            this.Controls.Add(this.gbPodaci);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmVozilaUnos";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Unos vozila";
            this.Load += new System.EventHandler(this.frmVozilaUnos_Load);
            this.gbPodaci.ResumeLayout(false);
            this.gbPodaci.PerformLayout();
            this.gbOpcije.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		#endregion

		public void uzmiPodatke(clsVozila a,int o)
		{
			this.vozilo = a;
			this.opcija = o;
		}

		private void duSpasi_Click(object sender, System.EventArgs e)
		{
            if (duSpasi.Text == "Spasi")
            {
                string query = "INSERT INTO Vozila(Proizvodjac, Model, Boja, GodinaProizvodnje,Motor,RegistarskiBroj,OstaliDetalji) VALUES('" + tbProizvodjac.Text + "','" + tbModel.Text + "','" + tbBoja.Text + "','" + tbGodProizvodnje.Text + "','" + tbMotor.Text + "','" + tbRegistarskiBroj.Text + "','" + tbOstaliDetalji.Text + "');";

                try
                {
                    SqlCommand cmd = new SqlCommand(query, clsKonekcija.GetConnection());
                    //this.connVozilaUnos.Open();
                    cmd.ExecuteNonQuery();
                    //this.connVozilaUnos.Close();

                    MessageBox.Show("Podaci su uspješno spašeni.", "Obavještenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (Exception ex)
                {
                    string iz = ex.Message.ToString();
                    MessageBox.Show("Nepravilno uneseni podaci !", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }

            else if(duSpasi.Text == "Izmjeni")
            {
                {
                    string query1 = "UPDATE Vozila SET Proizvodjac ='" + tbProizvodjac.Text + "' WHERE(VoziloID=" + tbVoziloID.Text + ")";
                    string query2 = "UPDATE Vozila SET Model ='" + tbModel.Text + "' WHERE(VoziloID=" + tbVoziloID.Text + ")";
                    string query3 = "UPDATE Vozila SET Boja ='" + tbBoja.Text + "' WHERE(VoziloID=" + tbVoziloID.Text + ")";
                    string query4 = "UPDATE Vozila SET GodinaProizvodnje ='" + tbGodProizvodnje.Text + "' WHERE(VoziloID=" + tbVoziloID.Text + ")";
                    string query5 = "UPDATE Vozila SET RegistarskiBroj ='" + tbMotor.Text + "' WHERE(VoziloID=" + tbVoziloID.Text + ")";
                    string query6 = "UPDATE Vozila SET Motor ='" + tbRegistarskiBroj.Text + "' WHERE(VoziloID=" + tbVoziloID.Text + ")";
                    string query7 = "UPDATE Vozila SET OstaliDetalji='" + tbOstaliDetalji.Text + "' WHERE(VoziloID=" + tbVoziloID.Text + ")";

                    try
                    {
                        SqlCommand cmd1 = new SqlCommand(query1, clsKonekcija.GetConnection());
                        SqlCommand cmd2 = new SqlCommand(query2, clsKonekcija.GetConnection());
                        SqlCommand cmd3 = new SqlCommand(query3, clsKonekcija.GetConnection());
                        SqlCommand cmd4 = new SqlCommand(query4, clsKonekcija.GetConnection());
                        SqlCommand cmd5 = new SqlCommand(query5, clsKonekcija.GetConnection());
                        SqlCommand cmd6 = new SqlCommand(query6, clsKonekcija.GetConnection());
                        SqlCommand cmd7 = new SqlCommand(query7, clsKonekcija.GetConnection());
                                                
                        cmd1.ExecuteNonQuery();
                        cmd2.ExecuteNonQuery();
                        cmd3.ExecuteNonQuery();
                        cmd4.ExecuteNonQuery();
                        cmd5.ExecuteNonQuery();
                        cmd6.ExecuteNonQuery();
                        cmd7.ExecuteNonQuery();
                        
                        MessageBox.Show("Podaci su uspješno izmjenjeni.", "Obavještenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    catch (SqlException ex)
                    {
                        string iz = ex.Message.ToString();
                        MessageBox.Show("Greška: " + iz + "", "Upozorenje", MessageBoxButtons.OK);
                    }
                }
            }
		}

		private void frmVozilaUnos_Load(object sender, System.EventArgs e)
		{
			if(this.opcija==1)
			{				
                this.duSpasi.Text = "Spasi";
            }
			if(this.opcija==2)
			{				
                this.duSpasi.Text = "Izmjeni";
			
				this.tbVoziloID.Text = this.vozilo.VoziloID;
				this.tbProizvodjac.Text = this.vozilo.Proizvodjac;
				this.tbModel.Text = this.vozilo.Model;
				this.tbBoja.Text = this.vozilo.Boja;
				this.tbGodProizvodnje.Text = this.vozilo.GodinaProizvodnje;
				this.tbMotor.Text = this.vozilo.Motor;
				this.tbRegistarskiBroj.Text = this.vozilo.RegistarskiBroj;
				this.tbOstaliDetalji.Text = this.vozilo.OstaliDetalji;		
			}
		}		

		private void duZatvori_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}
	}
}
