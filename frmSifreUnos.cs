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
	/// Summary description for frmSifreUnos.
	/// </summary>
	public class frmSifreUnos : System.Windows.Forms.Form
	{
		private System.Windows.Forms.GroupBox gbOpcije;
		private System.Windows.Forms.Button duZatvori;
        private System.Windows.Forms.Button duSpasi;
		private System.Windows.Forms.GroupBox gbPodaci;
        private System.Windows.Forms.TextBox tbKorisnickoIme;
        private System.Windows.Forms.Label lbKorisnickoIme;
		private System.Windows.Forms.TextBox tbSifra;
		private System.Windows.Forms.Label lbSifra;
		private System.Data.SqlClient.SqlConnection connSifreUnos;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		//Varijabla koja služi za odredivanje da li se radi o opciji 
		//Novi ili Izmjeni(ažuriranje)
		int opcija=0;
        private Label lbTipKorisnika;
        private ComboBox cbTip;

        string sifraID;

		//Kreiranje novog objekta klase clsKategorije
		clsSifre sifra = new clsSifre();
		
		public frmSifreUnos()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSifreUnos));
            this.gbOpcije = new System.Windows.Forms.GroupBox();
            this.duZatvori = new System.Windows.Forms.Button();
            this.duSpasi = new System.Windows.Forms.Button();
            this.gbPodaci = new System.Windows.Forms.GroupBox();
            this.lbTipKorisnika = new System.Windows.Forms.Label();
            this.cbTip = new System.Windows.Forms.ComboBox();
            this.tbSifra = new System.Windows.Forms.TextBox();
            this.lbSifra = new System.Windows.Forms.Label();
            this.tbKorisnickoIme = new System.Windows.Forms.TextBox();
            this.lbKorisnickoIme = new System.Windows.Forms.Label();
            this.connSifreUnos = new System.Data.SqlClient.SqlConnection();
            this.gbOpcije.SuspendLayout();
            this.gbPodaci.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbOpcije
            // 
            this.gbOpcije.BackColor = System.Drawing.SystemColors.Control;
            this.gbOpcije.Controls.Add(this.duZatvori);
            this.gbOpcije.Controls.Add(this.duSpasi);
            this.gbOpcije.Location = new System.Drawing.Point(14, 143);
            this.gbOpcije.Name = "gbOpcije";
            this.gbOpcije.Size = new System.Drawing.Size(275, 72);
            this.gbOpcije.TabIndex = 9;
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
            this.duZatvori.TabIndex = 1;
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
            this.duSpasi.Location = new System.Drawing.Point(17, 24);
            this.duSpasi.Name = "duSpasi";
            this.duSpasi.Size = new System.Drawing.Size(112, 32);
            this.duSpasi.TabIndex = 0;
            this.duSpasi.Text = "       Spasi";
            this.duSpasi.UseVisualStyleBackColor = false;
            this.duSpasi.Click += new System.EventHandler(this.duSpasi_Click);
            // 
            // gbPodaci
            // 
            this.gbPodaci.BackColor = System.Drawing.SystemColors.Control;
            this.gbPodaci.Controls.Add(this.lbTipKorisnika);
            this.gbPodaci.Controls.Add(this.cbTip);
            this.gbPodaci.Controls.Add(this.tbSifra);
            this.gbPodaci.Controls.Add(this.lbSifra);
            this.gbPodaci.Controls.Add(this.tbKorisnickoIme);
            this.gbPodaci.Controls.Add(this.lbKorisnickoIme);
            this.gbPodaci.Location = new System.Drawing.Point(14, 10);
            this.gbPodaci.Name = "gbPodaci";
            this.gbPodaci.Size = new System.Drawing.Size(275, 127);
            this.gbPodaci.TabIndex = 0;
            this.gbPodaci.TabStop = false;
            // 
            // lbTipKorisnika
            // 
            this.lbTipKorisnika.Location = new System.Drawing.Point(13, 88);
            this.lbTipKorisnika.Name = "lbTipKorisnika";
            this.lbTipKorisnika.Size = new System.Drawing.Size(96, 23);
            this.lbTipKorisnika.TabIndex = 6;
            this.lbTipKorisnika.Text = "Tip korisnika:";
            this.lbTipKorisnika.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbTip
            // 
            this.cbTip.DisplayMember = "Instruktor";
            this.cbTip.FormattingEnabled = true;
            this.cbTip.Items.AddRange(new object[] {
            "Instruktor",
            "Kandidat",
            "Administrator"});
            this.cbTip.Location = new System.Drawing.Point(121, 88);
            this.cbTip.Name = "cbTip";
            this.cbTip.Size = new System.Drawing.Size(136, 24);
            this.cbTip.TabIndex = 2;
            // 
            // tbSifra
            // 
            this.tbSifra.Location = new System.Drawing.Point(121, 53);
            this.tbSifra.Name = "tbSifra";
            this.tbSifra.PasswordChar = '•';
            this.tbSifra.Size = new System.Drawing.Size(136, 22);
            this.tbSifra.TabIndex = 1;
            // 
            // lbSifra
            // 
            this.lbSifra.Location = new System.Drawing.Point(12, 53);
            this.lbSifra.Name = "lbSifra";
            this.lbSifra.Size = new System.Drawing.Size(96, 23);
            this.lbSifra.TabIndex = 4;
            this.lbSifra.Text = "Šifra:";
            this.lbSifra.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbKorisnickoIme
            // 
            this.tbKorisnickoIme.Location = new System.Drawing.Point(121, 21);
            this.tbKorisnickoIme.Name = "tbKorisnickoIme";
            this.tbKorisnickoIme.Size = new System.Drawing.Size(136, 22);
            this.tbKorisnickoIme.TabIndex = 0;
            // 
            // lbKorisnickoIme
            // 
            this.lbKorisnickoIme.Location = new System.Drawing.Point(13, 21);
            this.lbKorisnickoIme.Name = "lbKorisnickoIme";
            this.lbKorisnickoIme.Size = new System.Drawing.Size(96, 23);
            this.lbKorisnickoIme.TabIndex = 1;
            this.lbKorisnickoIme.Text = "Korisnicko Ime:";
            this.lbKorisnickoIme.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // connSifreUnos
            // 
            this.connSifreUnos.ConnectionString = "Data Source=(local);Initial Catalog=baza;integrated security=SSPI";
            this.connSifreUnos.FireInfoMessageEventOnUserErrors = false;
            // 
            // frmSifreUnos
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 15);
            this.ClientSize = new System.Drawing.Size(304, 228);
            this.Controls.Add(this.gbOpcije);
            this.Controls.Add(this.gbPodaci);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(310, 266);
            this.Name = "frmSifreUnos";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Unos Korisnika";
            this.Load += new System.EventHandler(this.frmSifreUnos_Load);
            this.gbOpcije.ResumeLayout(false);
            this.gbPodaci.ResumeLayout(false);
            this.gbPodaci.PerformLayout();
            this.ResumeLayout(false);

		}
		#endregion

		public void uzmiPodatke(clsSifre a,int o)
		{
			this.sifra = a;
			this.opcija = o;
		}

		private void duSpasi_Click(object sender, System.EventArgs e)
		{
            if (this.duSpasi.Text == "Spasi")
            {
                //Ako u jedno od polja nismo unijeli podatke onda prikaži upozorenje
                if (this.tbKorisnickoIme.Text == "" || this.tbSifra.Text == "" || this.cbTip.Text == "")
                {
                    MessageBox.Show("U jedno od polja niste unijeli podatke !", "Upozorenje !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else
                {

                    //SQL query za ubacivanje podataka u bazu
                    string query = "INSERT INTO Sifre(KorisnickoIme, Sifra, Tip) VALUES('" + tbKorisnickoIme.Text + "', '" + tbSifra.Text + "', '" + cbTip.Text + "');";

                    try
                    {
                        SqlCommand cmd = new SqlCommand(query, clsKonekcija.GetConnection());

                        //this.connSifreUnos.Open();
                        cmd.ExecuteNonQuery();
                        //this.connSifreUnos.Close();

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
            }
            else if (this.duSpasi.Text == "Izmjeni")
            {
                if (this.sifraID != "")
                {
                    string query1 = "UPDATE Sifre SET KorisnickoIme='" + tbKorisnickoIme.Text + "' WHERE(SifraID=" + this.sifraID + ")";
                    string query2 = "UPDATE Sifre SET Sifra='" + tbSifra.Text + "' WHERE(SifraID=" + this.sifraID + ")";
                    string query3 = "UPDATE Sifre SET Tip='" + cbTip.Text + "' WHERE(SifraID=" + this.sifraID + ")";

                    try
                    {
                        SqlCommand cmd1 = new SqlCommand(query1, clsKonekcija.GetConnection());
                        SqlCommand cmd2 = new SqlCommand(query2, clsKonekcija.GetConnection());
                        SqlCommand cmd3 = new SqlCommand(query3, clsKonekcija.GetConnection());

                        //this.connSifreUnos.Open();
                        cmd1.ExecuteNonQuery();
                        cmd2.ExecuteNonQuery();
                        cmd3.ExecuteNonQuery();
                        //this.connSifreUnos.Close();

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

		private void frmSifreUnos_Load(object sender, System.EventArgs e)
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
				
                //this.tbSifraID.Text = this.sifra.SifraID;
                this.sifraID = this.sifra.SifraID;
                
                this.tbKorisnickoIme.Text = this.sifra.KorisnickoIme;
				this.tbSifra.Text = this.sifra.Sifra;
                this.cbTip.Text = this.sifra.Tip;				
			}
		}
	}
}
