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
	/// Summary description for frmPolaganjaUnos.
	/// </summary>
	public class frmPolaganjaUnos : System.Windows.Forms.Form
	{
		private System.Windows.Forms.GroupBox gbOpcije;
		private System.Windows.Forms.Button duZatvori;
        private System.Windows.Forms.Button duSpasi;
        private System.Windows.Forms.GroupBox gbPodaci;
        private System.Windows.Forms.TextBox tbPolaganjeID;
		private System.Windows.Forms.DateTimePicker DTPdatPolaganja;
		private System.Windows.Forms.Label lbDatumPolaganja;
		private System.Windows.Forms.Label lbPolozeno;
        private System.Windows.Forms.Label lbPokusaj;
		private System.Data.SqlClient.SqlConnection connPolaganjaUnos;
		private System.Windows.Forms.ComboBox cbPokusaj;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		//Varijabla koja služi za odredivanje da li se radi o opciji 
		//Novi ili Izmjeni(ažuriranje)
		int opcija=0;

		//Kreiranje novog objekta klase clsPolaganja
        clsPolaganja polaganje = new clsPolaganja();
		private System.Windows.Forms.CheckBox chBoxPolozeno;
		private System.Windows.Forms.Label lblInstruktorID;
		private System.Windows.Forms.Label lblKategorijaID;
		private System.Windows.Forms.Label lblKandidatID;
        private ComboBox cbKandidat;
        private TextBox tbKandidatID;
        private AutoSkola.DSetovi.dsKandidati dsKandidati1;
        private TextBox tbKategorijaID;
        private ComboBox cbKategorija;
        private AutoSkola.DSetovi.dsKategorije dsKategorije1;
        private ComboBox cbInstruktor;
        private TextBox tbInstruktorID;
        private AutoSkola.DSetovi.dsInstruktori dsInstruktori1;

		int broj = 0;
		
		public frmPolaganjaUnos()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPolaganjaUnos));
            this.gbOpcije = new System.Windows.Forms.GroupBox();
            this.duZatvori = new System.Windows.Forms.Button();
            this.duSpasi = new System.Windows.Forms.Button();
            this.gbPodaci = new System.Windows.Forms.GroupBox();
            this.cbInstruktor = new System.Windows.Forms.ComboBox();
            this.dsInstruktori1 = new AutoSkola.DSetovi.dsInstruktori();
            this.cbKategorija = new System.Windows.Forms.ComboBox();
            this.dsKategorije1 = new AutoSkola.DSetovi.dsKategorije();
            this.cbKandidat = new System.Windows.Forms.ComboBox();
            this.dsKandidati1 = new AutoSkola.DSetovi.dsKandidati();
            this.tbKandidatID = new System.Windows.Forms.TextBox();
            this.lblKandidatID = new System.Windows.Forms.Label();
            this.lblKategorijaID = new System.Windows.Forms.Label();
            this.lblInstruktorID = new System.Windows.Forms.Label();
            this.chBoxPolozeno = new System.Windows.Forms.CheckBox();
            this.cbPokusaj = new System.Windows.Forms.ComboBox();
            this.DTPdatPolaganja = new System.Windows.Forms.DateTimePicker();
            this.tbPolaganjeID = new System.Windows.Forms.TextBox();
            this.lbPolozeno = new System.Windows.Forms.Label();
            this.lbPokusaj = new System.Windows.Forms.Label();
            this.lbDatumPolaganja = new System.Windows.Forms.Label();
            this.tbInstruktorID = new System.Windows.Forms.TextBox();
            this.tbKategorijaID = new System.Windows.Forms.TextBox();
            this.connPolaganjaUnos = new System.Data.SqlClient.SqlConnection();
            this.gbOpcije.SuspendLayout();
            this.gbPodaci.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsInstruktori1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsKategorije1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsKandidati1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbOpcije
            // 
            this.gbOpcije.BackColor = System.Drawing.SystemColors.Control;
            this.gbOpcije.Controls.Add(this.duZatvori);
            this.gbOpcije.Controls.Add(this.duSpasi);
            this.gbOpcije.Location = new System.Drawing.Point(16, 280);
            this.gbOpcije.Name = "gbOpcije";
            this.gbOpcije.Size = new System.Drawing.Size(312, 72);
            this.gbOpcije.TabIndex = 1;
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
            this.duSpasi.Location = new System.Drawing.Point(26, 24);
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
            this.gbPodaci.Controls.Add(this.cbInstruktor);
            this.gbPodaci.Controls.Add(this.cbKategorija);
            this.gbPodaci.Controls.Add(this.cbKandidat);
            this.gbPodaci.Controls.Add(this.tbKandidatID);
            this.gbPodaci.Controls.Add(this.lblKandidatID);
            this.gbPodaci.Controls.Add(this.lblKategorijaID);
            this.gbPodaci.Controls.Add(this.lblInstruktorID);
            this.gbPodaci.Controls.Add(this.chBoxPolozeno);
            this.gbPodaci.Controls.Add(this.cbPokusaj);
            this.gbPodaci.Controls.Add(this.DTPdatPolaganja);
            this.gbPodaci.Controls.Add(this.tbPolaganjeID);
            this.gbPodaci.Controls.Add(this.lbPolozeno);
            this.gbPodaci.Controls.Add(this.lbPokusaj);
            this.gbPodaci.Controls.Add(this.lbDatumPolaganja);
            this.gbPodaci.Controls.Add(this.tbInstruktorID);
            this.gbPodaci.Controls.Add(this.tbKategorijaID);
            this.gbPodaci.Location = new System.Drawing.Point(16, 11);
            this.gbPodaci.Name = "gbPodaci";
            this.gbPodaci.Size = new System.Drawing.Size(312, 263);
            this.gbPodaci.TabIndex = 0;
            this.gbPodaci.TabStop = false;
            this.gbPodaci.Text = "Unos Podataka";
            // 
            // cbInstruktor
            // 
            this.cbInstruktor.DataSource = this.dsInstruktori1;
            this.cbInstruktor.DisplayMember = "Instruktori.Ime";
            this.cbInstruktor.FormattingEnabled = true;
            this.cbInstruktor.Location = new System.Drawing.Point(144, 223);
            this.cbInstruktor.Name = "cbInstruktor";
            this.cbInstruktor.Size = new System.Drawing.Size(152, 24);
            this.cbInstruktor.TabIndex = 5;
            this.cbInstruktor.SelectedValueChanged += new System.EventHandler(this.cbInstruktor_SelectedValueChanged);
            // 
            // dsInstruktori1
            // 
            this.dsInstruktori1.DataSetName = "dsInstruktori";
            this.dsInstruktori1.Locale = new System.Globalization.CultureInfo("hr-HR");
            this.dsInstruktori1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbKategorija
            // 
            this.cbKategorija.DataSource = this.dsKategorije1;
            this.cbKategorija.DisplayMember = "Kategorije.Kategorija";
            this.cbKategorija.FormattingEnabled = true;
            this.cbKategorija.Location = new System.Drawing.Point(144, 75);
            this.cbKategorija.Name = "cbKategorija";
            this.cbKategorija.Size = new System.Drawing.Size(121, 24);
            this.cbKategorija.TabIndex = 1;
            this.cbKategorija.Tag = "Kategorije.KategorijaID";
            // 
            // dsKategorije1
            // 
            this.dsKategorije1.DataSetName = "dsKategorije";
            this.dsKategorije1.Locale = new System.Globalization.CultureInfo("hr-HR");
            this.dsKategorije1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbKandidat
            // 
            this.cbKandidat.DataSource = this.dsKandidati1;
            this.cbKandidat.DisplayMember = "Kandidati.Ime";
            this.cbKandidat.FormattingEnabled = true;
            this.cbKandidat.Location = new System.Drawing.Point(144, 32);
            this.cbKandidat.Name = "cbKandidat";
            this.cbKandidat.Size = new System.Drawing.Size(152, 24);
            this.cbKandidat.TabIndex = 0;
            // 
            // dsKandidati1
            // 
            this.dsKandidati1.DataSetName = "dsKandidati";
            this.dsKandidati1.Locale = new System.Globalization.CultureInfo("hr-HR");
            this.dsKandidati1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbKandidatID
            // 
            this.tbKandidatID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsKandidati1, "Kandidati.KandidatID", true));
            this.tbKandidatID.Location = new System.Drawing.Point(145, 33);
            this.tbKandidatID.Name = "tbKandidatID";
            this.tbKandidatID.ReadOnly = true;
            this.tbKandidatID.Size = new System.Drawing.Size(27, 22);
            this.tbKandidatID.TabIndex = 26;
            // 
            // lblKandidatID
            // 
            this.lblKandidatID.Location = new System.Drawing.Point(16, 32);
            this.lblKandidatID.Name = "lblKandidatID";
            this.lblKandidatID.Size = new System.Drawing.Size(87, 23);
            this.lblKandidatID.TabIndex = 25;
            this.lblKandidatID.Text = "Kandidat:";
            this.lblKandidatID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblKategorijaID
            // 
            this.lblKategorijaID.Location = new System.Drawing.Point(15, 75);
            this.lblKategorijaID.Name = "lblKategorijaID";
            this.lblKategorijaID.Size = new System.Drawing.Size(88, 23);
            this.lblKategorijaID.TabIndex = 24;
            this.lblKategorijaID.Text = "Kategorija:";
            this.lblKategorijaID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblInstruktorID
            // 
            this.lblInstruktorID.Location = new System.Drawing.Point(15, 223);
            this.lblInstruktorID.Name = "lblInstruktorID";
            this.lblInstruktorID.Size = new System.Drawing.Size(76, 23);
            this.lblInstruktorID.TabIndex = 23;
            this.lblInstruktorID.Text = "Instruktor:";
            this.lblInstruktorID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chBoxPolozeno
            // 
            this.chBoxPolozeno.Location = new System.Drawing.Point(144, 192);
            this.chBoxPolozeno.Name = "chBoxPolozeno";
            this.chBoxPolozeno.Size = new System.Drawing.Size(40, 16);
            this.chBoxPolozeno.TabIndex = 4;
            // 
            // cbPokusaj
            // 
            this.cbPokusaj.Items.AddRange(new object[] {
            "Prvi",
            "Drugi ",
            "Treci",
            "Cetvrti",
            "Peti",
            "Šesti",
            "Sedmi",
            "Osmi",
            "Deveti",
            "Deseti"});
            this.cbPokusaj.Location = new System.Drawing.Point(144, 152);
            this.cbPokusaj.Name = "cbPokusaj";
            this.cbPokusaj.Size = new System.Drawing.Size(152, 24);
            this.cbPokusaj.TabIndex = 3;
            // 
            // DTPdatPolaganja
            // 
            this.DTPdatPolaganja.CustomFormat = "";
            this.DTPdatPolaganja.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPdatPolaganja.Location = new System.Drawing.Point(144, 115);
            this.DTPdatPolaganja.Name = "DTPdatPolaganja";
            this.DTPdatPolaganja.Size = new System.Drawing.Size(152, 22);
            this.DTPdatPolaganja.TabIndex = 2;
            this.DTPdatPolaganja.Value = new System.DateTime(2007, 10, 24, 0, 0, 0, 0);
            // 
            // tbPolaganjeID
            // 
            this.tbPolaganjeID.Location = new System.Drawing.Point(176, 33);
            this.tbPolaganjeID.Name = "tbPolaganjeID";
            this.tbPolaganjeID.ReadOnly = true;
            this.tbPolaganjeID.Size = new System.Drawing.Size(27, 22);
            this.tbPolaganjeID.TabIndex = 0;
            this.tbPolaganjeID.TabStop = false;
            // 
            // lbPolozeno
            // 
            this.lbPolozeno.Location = new System.Drawing.Point(16, 188);
            this.lbPolozeno.Name = "lbPolozeno";
            this.lbPolozeno.Size = new System.Drawing.Size(120, 23);
            this.lbPolozeno.TabIndex = 5;
            this.lbPolozeno.Text = "Položeno:";
            this.lbPolozeno.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbPokusaj
            // 
            this.lbPokusaj.Location = new System.Drawing.Point(16, 152);
            this.lbPokusaj.Name = "lbPokusaj";
            this.lbPokusaj.Size = new System.Drawing.Size(120, 23);
            this.lbPokusaj.TabIndex = 4;
            this.lbPokusaj.Text = "Pokušaj:";
            this.lbPokusaj.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbDatumPolaganja
            // 
            this.lbDatumPolaganja.Location = new System.Drawing.Point(15, 115);
            this.lbDatumPolaganja.Name = "lbDatumPolaganja";
            this.lbDatumPolaganja.Size = new System.Drawing.Size(120, 23);
            this.lbDatumPolaganja.TabIndex = 3;
            this.lbDatumPolaganja.Text = "Datum polaganja:";
            this.lbDatumPolaganja.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbInstruktorID
            // 
            this.tbInstruktorID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsInstruktori1, "Instruktori.ID", true));
            this.tbInstruktorID.Location = new System.Drawing.Point(144, 224);
            this.tbInstruktorID.Name = "tbInstruktorID";
            this.tbInstruktorID.ReadOnly = true;
            this.tbInstruktorID.Size = new System.Drawing.Size(27, 22);
            this.tbInstruktorID.TabIndex = 31;
            // 
            // tbKategorijaID
            // 
            this.tbKategorijaID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsKategorije1, "Kategorije.KategorijaID", true));
            this.tbKategorijaID.Location = new System.Drawing.Point(145, 76);
            this.tbKategorijaID.Name = "tbKategorijaID";
            this.tbKategorijaID.ReadOnly = true;
            this.tbKategorijaID.Size = new System.Drawing.Size(27, 22);
            this.tbKategorijaID.TabIndex = 29;
            // 
            // connPolaganjaUnos
            // 
            this.connPolaganjaUnos.ConnectionString = "Data Source=(local);Initial Catalog=baza;integrated security=SSPI";
            this.connPolaganjaUnos.FireInfoMessageEventOnUserErrors = false;
            // 
            // frmPolaganjaUnos
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 15);
            this.ClientSize = new System.Drawing.Size(344, 367);
            this.Controls.Add(this.gbOpcije);
            this.Controls.Add(this.gbPodaci);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmPolaganjaUnos";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Unos polaganja";
            this.Load += new System.EventHandler(this.frmPolaganjaUnos_Load);
            this.gbOpcije.ResumeLayout(false);
            this.gbPodaci.ResumeLayout(false);
            this.gbPodaci.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsInstruktori1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsKategorije1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsKandidati1)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		public void uzmiPodatke(clsPolaganja a,int o)
		{
			this.polaganje=a;
			this.opcija=o;
		}

		public void uzmiBroj(int b)
		{
			broj = b;
		}

		private void duSpasi_Click(object sender, System.EventArgs e)
		{
            if (this.duSpasi.Text == "Spasi")
            {
                string query = "INSERT INTO Polaganja(KandidatID,KategorijaID,DatumPolaganja,Pokusaj,Polozeno,InstruktorID) VALUES('" + tbKandidatID.Text + "','" + tbKategorijaID.Text + "',@DatumPolaganja,'" + cbPokusaj.Text + "',@Polozeno,'" + tbInstruktorID.Text + "');";

                try
                {
                    SqlCommand cmd = new SqlCommand(query, clsKonekcija.GetConnection());

                    cmd.Parameters.Add("@DatumPolaganja", SqlDbType.VarChar);
                    cmd.Parameters["@DatumPolaganja"].Value = DTPdatPolaganja.Text.ToString();

                    cmd.Parameters.Add("@Polozeno", SqlDbType.Bit);
                    cmd.Parameters["@Polozeno"].Value = chBoxPolozeno.Checked;

                    cmd.ExecuteNonQuery();

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
                if (this.tbPolaganjeID.Text != "")
                {
                    string query1 = "UPDATE Polaganja SET KandidatID = '" + tbKandidatID.Text + "' WHERE(PolaganjeID=" + tbPolaganjeID.Text + ")";
                    string query2 = "UPDATE Polaganja SET KategorijaID = '" + tbKategorijaID.Text + "' WHERE(PolaganjeID=" + tbPolaganjeID.Text + ")";
                    string query3 = "UPDATE Polaganja SET DatumPolaganja = @DatumPolaganja WHERE(PolaganjeID=" + tbPolaganjeID.Text + ")";
                    string query4 = "UPDATE Polaganja SET Pokusaj = '" + cbPokusaj.Text + "' WHERE(PolaganjeID=" + tbPolaganjeID.Text + ")";
                    string query5 = "UPDATE Polaganja SET Polozeno = @Polozeno WHERE(PolaganjeID=" + tbPolaganjeID.Text + ")";
                    string query6 = "UPDATE Polaganja SET InstruktorID = '" + tbInstruktorID.Text + "' WHERE(PolaganjeID=" + tbPolaganjeID.Text + ")";

                    try
                    {
                        SqlCommand cmd1 = new SqlCommand(query1, clsKonekcija.GetConnection());
                        SqlCommand cmd2 = new SqlCommand(query2, clsKonekcija.GetConnection());
                        SqlCommand cmd3 = new SqlCommand(query3, clsKonekcija.GetConnection());
                        SqlCommand cmd4 = new SqlCommand(query4, clsKonekcija.GetConnection());
                        SqlCommand cmd5 = new SqlCommand(query5, clsKonekcija.GetConnection());
                        SqlCommand cmd6 = new SqlCommand(query6, clsKonekcija.GetConnection());

                        cmd3.Parameters.Add("@DatumPolaganja", SqlDbType.VarChar);
                        cmd3.Parameters["@DatumPolaganja"].Value = DTPdatPolaganja.Text.ToString();

                        cmd5.Parameters.Add("@Polozeno", SqlDbType.Bit);
                        cmd5.Parameters["@Polozeno"].Value = chBoxPolozeno.Checked;

                        cmd1.ExecuteNonQuery();
                        cmd2.ExecuteNonQuery();
                        cmd3.ExecuteNonQuery();
                        cmd4.ExecuteNonQuery();
                        cmd5.ExecuteNonQuery();
                        cmd6.ExecuteNonQuery();

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

        //Novo
        public void ucitajKandidate()
        {
            string query = "SELECT KandidatID, [Ime]+' '+[Prezime] AS Ime FROM Kandidati ";
            
            try
            {
                SqlCommand cmd = new SqlCommand(query, clsKonekcija.GetConnection());
                SqlDataAdapter cmdAdapter = new SqlDataAdapter(cmd);

                dsKandidati1.Clear();
                cmdAdapter.Fill(dsKandidati1.Kandidati);
            }
            catch (Exception ex)
            {
                string iz = ex.Message.ToString();
                MessageBox.Show("Došlo je do greške!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        //
        //Novo
        public void ucitajKategorije()
        {
            string query = "SELECT KategorijaID, Kategorija FROM Kategorije ";

            try
            {
                SqlCommand cmd = new SqlCommand(query, clsKonekcija.GetConnection());
                SqlDataAdapter cmdAdapter = new SqlDataAdapter(cmd);

                dsKategorije1.Clear();
                cmdAdapter.Fill(dsKategorije1.Kategorije);
            }
            catch (Exception ex)
            {
                string iz = ex.Message.ToString();
                MessageBox.Show("Došlo je do greške!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        //
        //Novo
        public void ucitajInstruktore()
        {
            string query = "SELECT InstruktorID AS ID, [Ime]+' '+[Prezime] AS Ime FROM Instruktori ORDER BY InstruktorID";
            //SELECT InstruktorID AS ID, Ime, Prezime, DatumRodjenja, Adresa, Telefon, Email, DatumZaposlenja FROM Instruktori ORDER BY InstruktorID
            try
            {
                SqlCommand cmd = new SqlCommand(query, clsKonekcija.GetConnection());
                SqlDataAdapter cmdAdapter = new SqlDataAdapter(cmd);

                dsInstruktori1.Clear();
                cmdAdapter.Fill(dsInstruktori1.Instruktori);
            }
            catch (Exception ex)
            {
                string iz = ex.Message.ToString();
                MessageBox.Show("Došlo je do greške!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        //

		private void frmPolaganjaUnos_Load(object sender, System.EventArgs e)
		{
            ucitajKandidate();
            ucitajKategorije();
            ucitajInstruktore();
            
            if(this.opcija==1)
			{
                this.duSpasi.Text = "Spasi";                                
            }
			if(this.opcija==2)
			{
                this.duSpasi.Text = "Izmjeni";				
				
				//Ako je odabrana opcija za izmjenu podataka onda proslijedi 
				//odabrani zapis iz data grida u formu za izmjenu podataka koristeci varijable iz clsVarijable
				this.tbPolaganjeID.Text=this.polaganje.PolaganjeID;								
				this.DTPdatPolaganja.Text=this.polaganje.DatumPolaganja;
				this.cbPokusaj.Text=this.polaganje.Pokusaj;				
				this.chBoxPolozeno.Checked = this.polaganje.Polozeno;

                this.tbKandidatID.Text = this.polaganje.KandidatID;
                this.cbKandidat.Text = this.polaganje.KandidatIme + " " + this.polaganje.KandidatPrezime;

                this.tbKategorijaID.Text = this.polaganje.KategorijaID;
                this.cbKategorija.Text = this.polaganje.Kategorija;
                
                this.tbInstruktorID.Text = this.polaganje.InstruktorID;
                this.cbInstruktor.Text = this.polaganje.InstruktorIme + " " + this.polaganje.InstruktorPrezime;                
            }            
		}

		public void UnesiKategoriju(string sKategorijaID, string sKategorija)
		{
			//tbKategorijaID.Text=sKategorijaID;
			//tbKategorija.Text=sKategorija;
            /*
            duKategorijeUnos_Click
            frmKategorije f = new frmKategorije(this);
            f.uzmiBroj(3); 
            f.ShowDialog();
            */
        }
		
		private void duKategorijeUnos_Click(object sender, System.EventArgs e)
		{
			
		}

		public void UnesiInstruktora(string sInstruktorID, string sIme, string sPrezime)
		{
			//tbInstruktorID.Text=sInstruktorID;
			//tbInstruktorIme.Text=sIme;
			//tbInstruktorPrezime.Text=sPrezime;
            /*
            duInstruktoriUnos_Click
            frmInstruktori i = new frmInstruktori(this);
            i.uzmiBroj(1); 
            i.ShowDialog();
            */
        }
		
		private void duInstruktoriUnos_Click(object sender, System.EventArgs e)
		{
			
		}

		public void UnesiKandidata(string sKandidatID, string sIme, string sPrezime)
		{
			//tbKandidatID.Text = sKandidatID;
			//tbKandidatIme.Text = sIme;
			//tbKandidatPrezime.Text = sPrezime;
            /*
            duKandidatiUnos_Click
            frmKandidati k = new frmKandidati(this);
            k.uzmiBroj(1); 
            k.ShowDialog();
            */
        }
		
		private void duKandidatiUnos_Click(object sender, System.EventArgs e)
		{
			
		}

        private void cbInstruktor_SelectedValueChanged(object sender, EventArgs e)
        {
            //ucitajInstruktore();
        }
	}
}
