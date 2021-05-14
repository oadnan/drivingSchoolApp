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
	/// Summary description for frmKategorijeUnos.
	/// </summary>
	public class frmKategorijeUnos : System.Windows.Forms.Form
	{
        private System.Windows.Forms.GroupBox gbPodaci;
        private System.Windows.Forms.Label lbKategorija;
		private System.Windows.Forms.GroupBox gbOpcije;
		private System.Windows.Forms.Button duZatvori;
        private System.Windows.Forms.Button duSpasi;
		private System.Data.SqlClient.SqlConnection connKategorijeUnos;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		//Varijabla koja služi za odredivanje da li se radi o opciji 
		//Novi ili Izmjeni(ažuriranje)
		int opcija=0;

        string kategorijaId;

		private System.Windows.Forms.TextBox tbKategorija;
		
		//Kreiranje novog objekta klase clsKategorije
		clsKategorije kategorija = new clsKategorije();
		
		public frmKategorijeUnos()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKategorijeUnos));
            this.gbPodaci = new System.Windows.Forms.GroupBox();
            this.tbKategorija = new System.Windows.Forms.TextBox();
            this.lbKategorija = new System.Windows.Forms.Label();
            this.gbOpcije = new System.Windows.Forms.GroupBox();
            this.duZatvori = new System.Windows.Forms.Button();
            this.duSpasi = new System.Windows.Forms.Button();
            this.connKategorijeUnos = new System.Data.SqlClient.SqlConnection();
            this.gbPodaci.SuspendLayout();
            this.gbOpcije.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbPodaci
            // 
            this.gbPodaci.BackColor = System.Drawing.SystemColors.Control;
            this.gbPodaci.Controls.Add(this.tbKategorija);
            this.gbPodaci.Controls.Add(this.lbKategorija);
            this.gbPodaci.Location = new System.Drawing.Point(13, 13);
            this.gbPodaci.Name = "gbPodaci";
            this.gbPodaci.Size = new System.Drawing.Size(275, 59);
            this.gbPodaci.TabIndex = 6;
            this.gbPodaci.TabStop = false;
            // 
            // tbKategorija
            // 
            this.tbKategorija.Location = new System.Drawing.Point(121, 21);
            this.tbKategorija.Name = "tbKategorija";
            this.tbKategorija.Size = new System.Drawing.Size(136, 22);
            this.tbKategorija.TabIndex = 0;
            // 
            // lbKategorija
            // 
            this.lbKategorija.Location = new System.Drawing.Point(13, 21);
            this.lbKategorija.Name = "lbKategorija";
            this.lbKategorija.Size = new System.Drawing.Size(96, 23);
            this.lbKategorija.TabIndex = 1;
            this.lbKategorija.Text = "Kategorija:";
            this.lbKategorija.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gbOpcije
            // 
            this.gbOpcije.BackColor = System.Drawing.SystemColors.Control;
            this.gbOpcije.Controls.Add(this.duZatvori);
            this.gbOpcije.Controls.Add(this.duSpasi);
            this.gbOpcije.Location = new System.Drawing.Point(13, 78);
            this.gbOpcije.Name = "gbOpcije";
            this.gbOpcije.Size = new System.Drawing.Size(275, 72);
            this.gbOpcije.TabIndex = 7;
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
            this.duZatvori.Location = new System.Drawing.Point(145, 24);
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
            this.duSpasi.Location = new System.Drawing.Point(16, 24);
            this.duSpasi.Name = "duSpasi";
            this.duSpasi.Size = new System.Drawing.Size(112, 32);
            this.duSpasi.TabIndex = 1;
            this.duSpasi.Text = "       Spasi";
            this.duSpasi.UseVisualStyleBackColor = false;
            this.duSpasi.Click += new System.EventHandler(this.duSpasi_Click);
            // 
            // connKategorijeUnos
            // 
            this.connKategorijeUnos.ConnectionString = "Data Source=(local);Initial Catalog=baza;integrated security=SSPI";
            this.connKategorijeUnos.FireInfoMessageEventOnUserErrors = false;
            // 
            // frmKategorijeUnos
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 15);
            this.ClientSize = new System.Drawing.Size(304, 164);
            this.Controls.Add(this.gbOpcije);
            this.Controls.Add(this.gbPodaci);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmKategorijeUnos";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Unos kategorija";
            this.Load += new System.EventHandler(this.frmKategorijeUnos_Load);
            this.gbPodaci.ResumeLayout(false);
            this.gbPodaci.PerformLayout();
            this.gbOpcije.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		#endregion

		public void uzmiPodatke(clsKategorije a,int o)
		{
			this.kategorija=a;
			this.opcija=o;
		}

		private void duSpasi_Click(object sender, System.EventArgs e)
		{
            if (this.duSpasi.Text == "Spasi")
            {
                //SQL query za ubacivanje podataka u bazu
                string query = "INSERT INTO Kategorije(Kategorija) VALUES('" + tbKategorija.Text + "');";

                try
                {
                    SqlCommand cmd = new SqlCommand(query, clsKonekcija.GetConnection());

                    //this.connKategorijeUnos.Open();
                    cmd.ExecuteNonQuery();
                    //this.connKategorijeUnos.Close();

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
            else if (this.duSpasi.Text == "Izmjeni")
            {
                if (this.kategorijaId != "")
                {
                    string query1 = "UPDATE Kategorije SET Kategorija='" + tbKategorija.Text + "' WHERE(KategorijaID=" + this.kategorijaId + ")";

                    try
                    {
                        SqlCommand cmd1 = new SqlCommand(query1, clsKonekcija.GetConnection());

                        //this.connKategorijeUnos.Open();
                        cmd1.ExecuteNonQuery();
                        //this.connKategorijeUnos.Close();

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

		private void duZatvori_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void frmKategorijeUnos_Load(object sender, System.EventArgs e)
		{			            
            if(this.opcija==1)
			{
                this.duSpasi.Text = "Spasi";                
			}
			if(this.opcija==2)
			{
                this.duSpasi.Text = "Izmjeni";
							
				//Ako je odabrana opcija za izmjenu podataka onda proslijedi 
				//odabrani zapis iz data grida u formu za izmjenu podataka koristeci varijable iz clsVarijable
				//this.tbKategorijaID.Text=this.kategorija.KategorijaID;

                this.kategorijaId = this.kategorija.KategorijaID;
                this.tbKategorija.Text=this.kategorija.Kategorija;
								
			}
		}
	}
}
