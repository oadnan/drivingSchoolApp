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
	/// Summary description for frmKandidatiUnos.
	/// </summary>
	public class frmKandidatiUnos : System.Windows.Forms.Form
	{
		private System.Windows.Forms.GroupBox gbPodaci;
		private System.Windows.Forms.DateTimePicker DTPdatRodjenja;
		private System.Windows.Forms.Label lbDatPrijavljivanja;
		private System.Windows.Forms.DateTimePicker DTPdatPrijav;
		private System.Windows.Forms.TextBox tbEmail;
		private System.Windows.Forms.TextBox tbTelefon;
		private System.Windows.Forms.TextBox tbAdresa;
		private System.Windows.Forms.TextBox tbPrezime;
		private System.Windows.Forms.TextBox tbIme;
		private System.Windows.Forms.TextBox tbKandidatID;
		private System.Windows.Forms.Label lbEmail;
		private System.Windows.Forms.Label lbTelefon;
		private System.Windows.Forms.Label lbAdresa;
		private System.Windows.Forms.Label lbDatumRodjenja;
		private System.Windows.Forms.Label lbPrezime;
        private System.Windows.Forms.Label lbIme;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		//Varijabla koja služi za odredivanje da li se radi o opciji 
		//Novi ili Izmjeni(ažuriranje)
		int opcija=0;
		
		//Kreiranje novog objekta klase klasaInstruktori
		clsKandidati kandidat = new clsKandidati();
		
		private System.Data.SqlClient.SqlConnection connKandidatiUnos;
		private System.Windows.Forms.GroupBox gbOpcije;
		private System.Windows.Forms.Button duZatvori;
        private System.Windows.Forms.Button duSpasi;
        private GroupBox groupBox1;
        private Label Password2;
        private TextBox txtPassword2;
        private TextBox txtPassword1;
        private Label label2;

		int broj = 0;
		
		public frmKandidatiUnos()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKandidatiUnos));
            this.gbPodaci = new System.Windows.Forms.GroupBox();
            this.DTPdatRodjenja = new System.Windows.Forms.DateTimePicker();
            this.lbDatPrijavljivanja = new System.Windows.Forms.Label();
            this.DTPdatPrijav = new System.Windows.Forms.DateTimePicker();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbTelefon = new System.Windows.Forms.TextBox();
            this.tbAdresa = new System.Windows.Forms.TextBox();
            this.tbPrezime = new System.Windows.Forms.TextBox();
            this.tbIme = new System.Windows.Forms.TextBox();
            this.tbKandidatID = new System.Windows.Forms.TextBox();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbTelefon = new System.Windows.Forms.Label();
            this.lbAdresa = new System.Windows.Forms.Label();
            this.lbDatumRodjenja = new System.Windows.Forms.Label();
            this.lbPrezime = new System.Windows.Forms.Label();
            this.lbIme = new System.Windows.Forms.Label();
            this.connKandidatiUnos = new System.Data.SqlClient.SqlConnection();
            this.gbOpcije = new System.Windows.Forms.GroupBox();
            this.duZatvori = new System.Windows.Forms.Button();
            this.duSpasi = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Password2 = new System.Windows.Forms.Label();
            this.txtPassword2 = new System.Windows.Forms.TextBox();
            this.txtPassword1 = new System.Windows.Forms.TextBox();
            this.gbPodaci.SuspendLayout();
            this.gbOpcije.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbPodaci
            // 
            this.gbPodaci.Controls.Add(this.DTPdatRodjenja);
            this.gbPodaci.Controls.Add(this.lbDatPrijavljivanja);
            this.gbPodaci.Controls.Add(this.DTPdatPrijav);
            this.gbPodaci.Controls.Add(this.tbEmail);
            this.gbPodaci.Controls.Add(this.tbTelefon);
            this.gbPodaci.Controls.Add(this.tbAdresa);
            this.gbPodaci.Controls.Add(this.tbPrezime);
            this.gbPodaci.Controls.Add(this.tbIme);
            this.gbPodaci.Controls.Add(this.tbKandidatID);
            this.gbPodaci.Controls.Add(this.lbEmail);
            this.gbPodaci.Controls.Add(this.lbTelefon);
            this.gbPodaci.Controls.Add(this.lbAdresa);
            this.gbPodaci.Controls.Add(this.lbDatumRodjenja);
            this.gbPodaci.Controls.Add(this.lbPrezime);
            this.gbPodaci.Controls.Add(this.lbIme);
            this.gbPodaci.Location = new System.Drawing.Point(14, 12);
            this.gbPodaci.Name = "gbPodaci";
            this.gbPodaci.Size = new System.Drawing.Size(312, 260);
            this.gbPodaci.TabIndex = 1;
            this.gbPodaci.TabStop = false;
            this.gbPodaci.Text = "Unos Podataka";
            // 
            // DTPdatRodjenja
            // 
            this.DTPdatRodjenja.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPdatRodjenja.Location = new System.Drawing.Point(152, 95);
            this.DTPdatRodjenja.Name = "DTPdatRodjenja";
            this.DTPdatRodjenja.Size = new System.Drawing.Size(144, 22);
            this.DTPdatRodjenja.TabIndex = 2;
            this.DTPdatRodjenja.Value = new System.DateTime(2007, 10, 25, 0, 0, 0, 0);
            // 
            // lbDatPrijavljivanja
            // 
            this.lbDatPrijavljivanja.Location = new System.Drawing.Point(24, 127);
            this.lbDatPrijavljivanja.Name = "lbDatPrijavljivanja";
            this.lbDatPrijavljivanja.Size = new System.Drawing.Size(128, 23);
            this.lbDatPrijavljivanja.TabIndex = 16;
            this.lbDatPrijavljivanja.Text = "Datum prijavljivanja:";
            this.lbDatPrijavljivanja.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DTPdatPrijav
            // 
            this.DTPdatPrijav.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPdatPrijav.Location = new System.Drawing.Point(152, 127);
            this.DTPdatPrijav.Name = "DTPdatPrijav";
            this.DTPdatPrijav.Size = new System.Drawing.Size(144, 22);
            this.DTPdatPrijav.TabIndex = 3;
            this.DTPdatPrijav.Value = new System.DateTime(2007, 10, 25, 0, 0, 0, 0);
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(152, 222);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(144, 22);
            this.tbEmail.TabIndex = 6;
            // 
            // tbTelefon
            // 
            this.tbTelefon.Location = new System.Drawing.Point(152, 191);
            this.tbTelefon.Name = "tbTelefon";
            this.tbTelefon.Size = new System.Drawing.Size(144, 22);
            this.tbTelefon.TabIndex = 5;
            // 
            // tbAdresa
            // 
            this.tbAdresa.Location = new System.Drawing.Point(152, 159);
            this.tbAdresa.Name = "tbAdresa";
            this.tbAdresa.Size = new System.Drawing.Size(144, 22);
            this.tbAdresa.TabIndex = 4;
            // 
            // tbPrezime
            // 
            this.tbPrezime.Location = new System.Drawing.Point(152, 63);
            this.tbPrezime.Name = "tbPrezime";
            this.tbPrezime.Size = new System.Drawing.Size(144, 22);
            this.tbPrezime.TabIndex = 1;
            // 
            // tbIme
            // 
            this.tbIme.Location = new System.Drawing.Point(152, 30);
            this.tbIme.Name = "tbIme";
            this.tbIme.Size = new System.Drawing.Size(144, 22);
            this.tbIme.TabIndex = 0;
            // 
            // tbKandidatID
            // 
            this.tbKandidatID.Location = new System.Drawing.Point(152, 30);
            this.tbKandidatID.Name = "tbKandidatID";
            this.tbKandidatID.ReadOnly = true;
            this.tbKandidatID.Size = new System.Drawing.Size(44, 22);
            this.tbKandidatID.TabIndex = 0;
            this.tbKandidatID.TabStop = false;
            this.tbKandidatID.Visible = false;
            // 
            // lbEmail
            // 
            this.lbEmail.Location = new System.Drawing.Point(24, 222);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(120, 23);
            this.lbEmail.TabIndex = 6;
            this.lbEmail.Text = "E-mail:";
            this.lbEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbTelefon
            // 
            this.lbTelefon.Location = new System.Drawing.Point(24, 191);
            this.lbTelefon.Name = "lbTelefon";
            this.lbTelefon.Size = new System.Drawing.Size(120, 23);
            this.lbTelefon.TabIndex = 5;
            this.lbTelefon.Text = "Telefon:";
            this.lbTelefon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbAdresa
            // 
            this.lbAdresa.Location = new System.Drawing.Point(24, 159);
            this.lbAdresa.Name = "lbAdresa";
            this.lbAdresa.Size = new System.Drawing.Size(120, 23);
            this.lbAdresa.TabIndex = 4;
            this.lbAdresa.Text = "Adresa:";
            this.lbAdresa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbDatumRodjenja
            // 
            this.lbDatumRodjenja.Location = new System.Drawing.Point(24, 95);
            this.lbDatumRodjenja.Name = "lbDatumRodjenja";
            this.lbDatumRodjenja.Size = new System.Drawing.Size(120, 23);
            this.lbDatumRodjenja.TabIndex = 3;
            this.lbDatumRodjenja.Text = "Datum rodjenja:";
            this.lbDatumRodjenja.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbPrezime
            // 
            this.lbPrezime.Location = new System.Drawing.Point(24, 63);
            this.lbPrezime.Name = "lbPrezime";
            this.lbPrezime.Size = new System.Drawing.Size(120, 23);
            this.lbPrezime.TabIndex = 2;
            this.lbPrezime.Text = "Prezime:";
            this.lbPrezime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbIme
            // 
            this.lbIme.Location = new System.Drawing.Point(24, 30);
            this.lbIme.Name = "lbIme";
            this.lbIme.Size = new System.Drawing.Size(120, 24);
            this.lbIme.TabIndex = 1;
            this.lbIme.Text = "Ime:";
            this.lbIme.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // connKandidatiUnos
            // 
            this.connKandidatiUnos.ConnectionString = "Data Source=(local);Initial Catalog=baza;integrated security=SSPI";
            this.connKandidatiUnos.FireInfoMessageEventOnUserErrors = false;
            // 
            // gbOpcije
            // 
            this.gbOpcije.BackColor = System.Drawing.SystemColors.Control;
            this.gbOpcije.Controls.Add(this.duZatvori);
            this.gbOpcije.Controls.Add(this.duSpasi);
            this.gbOpcije.Location = new System.Drawing.Point(14, 375);
            this.gbOpcije.Name = "gbOpcije";
            this.gbOpcije.Size = new System.Drawing.Size(312, 71);
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
            this.duZatvori.Size = new System.Drawing.Size(112, 33);
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
            this.duSpasi.Location = new System.Drawing.Point(28, 24);
            this.duSpasi.Name = "duSpasi";
            this.duSpasi.Size = new System.Drawing.Size(112, 33);
            this.duSpasi.TabIndex = 0;
            this.duSpasi.Text = "       Spasi";
            this.duSpasi.UseVisualStyleBackColor = false;
            this.duSpasi.Click += new System.EventHandler(this.duSpasi_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Password2);
            this.groupBox1.Controls.Add(this.txtPassword2);
            this.groupBox1.Controls.Add(this.txtPassword1);
            this.groupBox1.Location = new System.Drawing.Point(14, 278);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(312, 91);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Login Info";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Potvrdite šifru:";
            // 
            // Password2
            // 
            this.Password2.AutoSize = true;
            this.Password2.Location = new System.Drawing.Point(24, 27);
            this.Password2.Name = "Password2";
            this.Password2.Size = new System.Drawing.Size(41, 17);
            this.Password2.TabIndex = 2;
            this.Password2.Text = "Šifra:";
            // 
            // txtPassword2
            // 
            this.txtPassword2.Location = new System.Drawing.Point(138, 57);
            this.txtPassword2.Name = "txtPassword2";
            this.txtPassword2.PasswordChar = '•';
            this.txtPassword2.Size = new System.Drawing.Size(150, 22);
            this.txtPassword2.TabIndex = 1;
            // 
            // txtPassword1
            // 
            this.txtPassword1.Location = new System.Drawing.Point(138, 23);
            this.txtPassword1.Name = "txtPassword1";
            this.txtPassword1.PasswordChar = '•';
            this.txtPassword1.Size = new System.Drawing.Size(150, 22);
            this.txtPassword1.TabIndex = 0;
            // 
            // frmKandidatiUnos
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 15);
            this.ClientSize = new System.Drawing.Size(340, 457);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbOpcije);
            this.Controls.Add(this.gbPodaci);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmKandidatiUnos";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Unos kandidata";
            this.Load += new System.EventHandler(this.frmKandidatiUnos_Load);
            this.gbPodaci.ResumeLayout(false);
            this.gbPodaci.PerformLayout();
            this.gbOpcije.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

		}
		#endregion

		public void uzmiPodatke(clsKandidati a,int o)
		{
			this.kandidat=a;
			this.opcija=o;
		}

		public void uzmiBroj(int b)
		{
			broj = b;
		}

		private void frmKandidatiUnos_Load(object sender, System.EventArgs e)
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
				this.tbKandidatID.Text=this.kandidat.KandidatID;
				this.tbIme.Text=this.kandidat.Ime;
				this.tbPrezime.Text=this.kandidat.Prezime;
				this.DTPdatRodjenja.Text=this.kandidat.DatumRodjenja;
				this.DTPdatPrijav.Text=this.kandidat.DatumPrijavljivanja;
				this.tbAdresa.Text=this.kandidat.Adresa;
				this.tbTelefon.Text=this.kandidat.Telefon;
				this.tbEmail.Text=this.kandidat.Email;

                this.groupBox1.Enabled = false;
                //this.gbOpcije.Location = new System.Drawing.Point(14, 313);
                
			}
		}

        void dodajSifru()
        {   
            //moj remo izjeba me ovaj query
            string query = "Insert INTO Sifre VALUES(@KorisnickoIme, @Sifra, @Tip); " +
                "DECLARE @SifraId INT " +
                "SELECT @SifraId = MAX(SifraID) FROM Sifre " +
                "DECLARE @KandidatId INT " +
                "SELECT @KandidatId = MAX(KandidatID) FROM Kandidati " +
                "INSERT INTO tbl_kandidati_sifre VALUES(@SifraId, @KandidatId)";

            SqlCommand comm = new SqlCommand(query, clsKonekcija.GetConnection());

            comm.Parameters.Add("@KorisnickoIme", SqlDbType.VarChar).Value = 
                        tbIme.Text + " " + tbPrezime.Text;
            comm.Parameters.Add("@Sifra", SqlDbType.VarChar).Value = txtPassword1.Text;
            comm.Parameters.Add("@Tip", SqlDbType.VarChar).Value = "Kandidat";
            comm.ExecuteNonQuery();
        }

		private void duSpasi_Click(object sender, System.EventArgs e)
		{
            if (this.duSpasi.Text == "Spasi")
            {
                //jel sifra ista.. ono confirm
                if (!txtPassword1.Text.Trim().Equals(txtPassword2.Text.Trim()) ||
                    txtPassword1.Text.Trim() == "")
                {
                    MessageBox.Show("Šifre koje ste unijeli nisu jednake.");
                    return;
                }
                //SQL query za ubacivanje podataka u bazu '"+DTPdatRodjenja.Text+"' '"+DTPdatZap.Text+"'
                string query = "INSERT INTO Kandidati(Ime,Prezime,DatumRodjenja,DatumPrijavljivanja,Adresa,Telefon,Email) VALUES('" + tbIme.Text + "','" + tbPrezime.Text + "',@DatumRodjenja,@DatumPrijavljivanja,'" + tbAdresa.Text + "','" + tbTelefon.Text + "','" + tbEmail.Text + "');";

                /*try
                {*/
                SqlCommand cmd = new SqlCommand(query, clsKonekcija.GetConnection());

                cmd.Parameters.Add("@DatumRodjenja", SqlDbType.DateTime);
                cmd.Parameters["@DatumRodjenja"].Value = DTPdatRodjenja.Text.ToString();

                cmd.Parameters.Add("@DatumPrijavljivanja", SqlDbType.DateTime);
                cmd.Parameters["@DatumPrijavljivanja"].Value = DTPdatPrijav.Text.ToString();

                //cmd.Parameters.Add("@DatumPlacanja",SqlDbType.DateTime);
                //cmd.Parameters["@DatumPlacanja"].Value = DTPdatPlacanja.Text.ToString();

                //this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Proizvodjac", System.Data.SqlDbType.VarChar, 50, "Proizvodjac"));
                //this.connKandidatiUnos.Open();
                cmd.ExecuteNonQuery(); ;

                //this.connKandidatiUnos.Close();

                //

                dodajSifru();
                /////////////////////////////////////////


                MessageBox.Show("Podaci su uspješno spašeni.", "Obavještenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
                /* }

                 catch (Exception ex)
                 {
                     string iz = ex.Message.ToString();
                     MessageBox.Show("Nepravilno uneseni podaci !", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                 }*/
            }
            else if (this.duSpasi.Text == "Izmjeni")
            {
                if (this.tbKandidatID.Text != "")
                {
                    string query1 = "UPDATE Kandidati SET Ime='" + tbIme.Text + "' WHERE(KandidatID=" + tbKandidatID.Text + ")";
                    string query2 = "UPDATE Kandidati SET Prezime='" + tbPrezime.Text + "' WHERE(KandidatID=" + tbKandidatID.Text + ")";
                    string query3 = "UPDATE Kandidati SET DatumRodjenja=@DatumRodjenja WHERE(KandidatID=" + tbKandidatID.Text + ")";
                    string query4 = "UPDATE Kandidati SET DatumPrijavljivanja=@DatumPrijavljivanja WHERE(KandidatID=" + tbKandidatID.Text + ")";
                    string query5 = "UPDATE Kandidati SET Adresa='" + tbAdresa.Text + "' WHERE(KandidatID=" + tbKandidatID.Text + ")";
                    string query6 = "UPDATE Kandidati SET Telefon='" + tbTelefon.Text + "' WHERE(KandidatID=" + tbKandidatID.Text + ")";
                    string query7 = "UPDATE Kandidati SET Email='" + tbEmail.Text + "' WHERE(KandidatID=" + tbKandidatID.Text + ")";

                    try
                    {
                        SqlCommand cmd1 = new SqlCommand(query1, clsKonekcija.GetConnection());
                        SqlCommand cmd2 = new SqlCommand(query2, clsKonekcija.GetConnection());
                        SqlCommand cmd3 = new SqlCommand(query3, clsKonekcija.GetConnection());
                        SqlCommand cmd4 = new SqlCommand(query4, clsKonekcija.GetConnection());
                        SqlCommand cmd5 = new SqlCommand(query5, clsKonekcija.GetConnection());
                        SqlCommand cmd6 = new SqlCommand(query6, clsKonekcija.GetConnection());
                        SqlCommand cmd7 = new SqlCommand(query7, clsKonekcija.GetConnection());

                        cmd3.Parameters.Add("@DatumRodjenja", SqlDbType.DateTime);
                        cmd3.Parameters["@DatumRodjenja"].Value = DTPdatRodjenja.Text.ToString();

                        cmd4.Parameters.Add("@DatumPrijavljivanja", SqlDbType.DateTime);
                        cmd4.Parameters["@DatumPrijavljivanja"].Value = DTPdatPrijav.Text.ToString();

                        //cmd10.Parameters.Add("@DatumPlacanja",SqlDbType.DateTime);
                        //cmd10.Parameters["@DatumPlacanja"].Value = DTPdatPlacanja.Text.ToString();

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

		private void duZatvori_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		/*public void UnesiKategoriju(string sKategorijaID, string sKategorija)
		{
			tbKategorijaID.Text=sKategorijaID;
			tbKategorija.Text=sKategorija;
		}*/

		private void duKategorijaUnos_Click(object sender, System.EventArgs e)
		{
			frmKategorije k = new frmKategorije(this);
			k.uzmiBroj(2); 
			k.ShowDialog();			
		}
	}
}
