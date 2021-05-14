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
	/// Summary description for frmDnevnikUnos.
	/// </summary>
	public class frmDnevnikUnos : System.Windows.Forms.Form
	{
        private System.Windows.Forms.GroupBox gbPodaci;
		private System.Windows.Forms.TextBox tbVoziloID;
        private System.Windows.Forms.Label lbModel;
        public System.Windows.Forms.TextBox tbInstruktorID;
        private System.Windows.Forms.TextBox tbKandidatID;
        private System.Windows.Forms.TextBox tbCasID;
		private System.Windows.Forms.GroupBox gbOpcije;
		private System.Windows.Forms.Button duZatvori;
        private System.Windows.Forms.Button duSpasi;
		private System.Windows.Forms.Label lbVrijemeOd;
		private System.Windows.Forms.TextBox tbMjestoObuke;
		private System.Windows.Forms.Label lbMjestoObuke;
		private System.Windows.Forms.TextBox tbMetodskaJedinica;
		private System.Windows.Forms.Label lbDatumObuke;
		private System.Windows.Forms.Label lbMetodskaJedinica;
        private System.Windows.Forms.Label lbVrijemeDo;
		private System.Windows.Forms.TextBox tbKategorijaID;
		private System.Windows.Forms.Label lbKategorija;
		private System.Data.SqlClient.SqlConnection connDnevnikUnos;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		//Varijabla koja služi za odredivanje da li se radi o opciji 
		//Novi ili Izmjeni(ažuriranje)
		int opcija=0;

		//Kreiranje novog objekta klase clsPolaganja
		clsDnevnikObuke dnevnik = new clsDnevnikObuke();
		private System.Windows.Forms.DateTimePicker DTPvrijemeOd;
		private System.Windows.Forms.DateTimePicker DTPvrijemeDo;
        private System.Windows.Forms.DateTimePicker DTPdatumObuke;
		private System.Windows.Forms.Label lblInstruktorID;
        private System.Windows.Forms.Label lblKandidatID;
        private AutoSkola.DSetovi.dsInstruktori dsInstruktori1;
        private ComboBox cbInstruktor;
        private AutoSkola.DSetovi.dsKandidati dsKandidati1;
        private ComboBox cbKandidat;
        private AutoSkola.DSetovi.dsKategorije dsKategorije1;
        private ComboBox cbKategorija;
        private AutoSkola.DSetovi.dsVozila dsVozila1;
        private ComboBox cbVozilo;

		int broj = 0;
		
		public frmDnevnikUnos()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDnevnikUnos));
            this.gbPodaci = new System.Windows.Forms.GroupBox();
            this.cbVozilo = new System.Windows.Forms.ComboBox();
            this.dsVozila1 = new AutoSkola.DSetovi.dsVozila();
            this.cbKategorija = new System.Windows.Forms.ComboBox();
            this.dsKategorije1 = new AutoSkola.DSetovi.dsKategorije();
            this.cbKandidat = new System.Windows.Forms.ComboBox();
            this.dsKandidati1 = new AutoSkola.DSetovi.dsKandidati();
            this.cbInstruktor = new System.Windows.Forms.ComboBox();
            this.dsInstruktori1 = new AutoSkola.DSetovi.dsInstruktori();
            this.lblKandidatID = new System.Windows.Forms.Label();
            this.lblInstruktorID = new System.Windows.Forms.Label();
            this.DTPdatumObuke = new System.Windows.Forms.DateTimePicker();
            this.DTPvrijemeDo = new System.Windows.Forms.DateTimePicker();
            this.DTPvrijemeOd = new System.Windows.Forms.DateTimePicker();
            this.tbKategorijaID = new System.Windows.Forms.TextBox();
            this.lbKategorija = new System.Windows.Forms.Label();
            this.lbVrijemeDo = new System.Windows.Forms.Label();
            this.tbVoziloID = new System.Windows.Forms.TextBox();
            this.lbModel = new System.Windows.Forms.Label();
            this.tbInstruktorID = new System.Windows.Forms.TextBox();
            this.lbVrijemeOd = new System.Windows.Forms.Label();
            this.tbMjestoObuke = new System.Windows.Forms.TextBox();
            this.lbMjestoObuke = new System.Windows.Forms.Label();
            this.tbKandidatID = new System.Windows.Forms.TextBox();
            this.tbMetodskaJedinica = new System.Windows.Forms.TextBox();
            this.tbCasID = new System.Windows.Forms.TextBox();
            this.lbDatumObuke = new System.Windows.Forms.Label();
            this.lbMetodskaJedinica = new System.Windows.Forms.Label();
            this.gbOpcije = new System.Windows.Forms.GroupBox();
            this.duZatvori = new System.Windows.Forms.Button();
            this.duSpasi = new System.Windows.Forms.Button();
            this.connDnevnikUnos = new System.Data.SqlClient.SqlConnection();
            this.gbPodaci.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsVozila1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsKategorije1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsKandidati1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsInstruktori1)).BeginInit();
            this.gbOpcije.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbPodaci
            // 
            this.gbPodaci.BackColor = System.Drawing.SystemColors.Control;
            this.gbPodaci.Controls.Add(this.cbVozilo);
            this.gbPodaci.Controls.Add(this.cbKategorija);
            this.gbPodaci.Controls.Add(this.cbKandidat);
            this.gbPodaci.Controls.Add(this.cbInstruktor);
            this.gbPodaci.Controls.Add(this.lblKandidatID);
            this.gbPodaci.Controls.Add(this.lblInstruktorID);
            this.gbPodaci.Controls.Add(this.DTPdatumObuke);
            this.gbPodaci.Controls.Add(this.DTPvrijemeDo);
            this.gbPodaci.Controls.Add(this.DTPvrijemeOd);
            this.gbPodaci.Controls.Add(this.tbKategorijaID);
            this.gbPodaci.Controls.Add(this.lbKategorija);
            this.gbPodaci.Controls.Add(this.lbVrijemeDo);
            this.gbPodaci.Controls.Add(this.tbVoziloID);
            this.gbPodaci.Controls.Add(this.lbModel);
            this.gbPodaci.Controls.Add(this.tbInstruktorID);
            this.gbPodaci.Controls.Add(this.lbVrijemeOd);
            this.gbPodaci.Controls.Add(this.tbMjestoObuke);
            this.gbPodaci.Controls.Add(this.lbMjestoObuke);
            this.gbPodaci.Controls.Add(this.tbKandidatID);
            this.gbPodaci.Controls.Add(this.tbMetodskaJedinica);
            this.gbPodaci.Controls.Add(this.tbCasID);
            this.gbPodaci.Controls.Add(this.lbDatumObuke);
            this.gbPodaci.Controls.Add(this.lbMetodskaJedinica);
            this.gbPodaci.Location = new System.Drawing.Point(15, 13);
            this.gbPodaci.Name = "gbPodaci";
            this.gbPodaci.Size = new System.Drawing.Size(319, 379);
            this.gbPodaci.TabIndex = 0;
            this.gbPodaci.TabStop = false;
            this.gbPodaci.Text = "Unos podataka";
            // 
            // cbVozilo
            // 
            this.cbVozilo.DataSource = this.dsVozila1;
            this.cbVozilo.DisplayMember = "Vozila.Model";
            this.cbVozilo.FormattingEnabled = true;
            this.cbVozilo.Location = new System.Drawing.Point(138, 303);
            this.cbVozilo.Name = "cbVozilo";
            this.cbVozilo.Size = new System.Drawing.Size(159, 24);
            this.cbVozilo.TabIndex = 7;
            // 
            // dsVozila1
            // 
            this.dsVozila1.DataSetName = "dsVozila";
            this.dsVozila1.Locale = new System.Globalization.CultureInfo("hr-HR");
            this.dsVozila1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbKategorija
            // 
            this.cbKategorija.DataSource = this.dsKategorije1;
            this.cbKategorija.DisplayMember = "Kategorije.Kategorija";
            this.cbKategorija.FormattingEnabled = true;
            this.cbKategorija.Location = new System.Drawing.Point(139, 265);
            this.cbKategorija.Name = "cbKategorija";
            this.cbKategorija.Size = new System.Drawing.Size(158, 24);
            this.cbKategorija.TabIndex = 6;
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
            this.cbKandidat.Location = new System.Drawing.Point(138, 227);
            this.cbKandidat.Name = "cbKandidat";
            this.cbKandidat.Size = new System.Drawing.Size(159, 24);
            this.cbKandidat.TabIndex = 5;
            // 
            // dsKandidati1
            // 
            this.dsKandidati1.DataSetName = "dsKandidati";
            this.dsKandidati1.Locale = new System.Globalization.CultureInfo("hr-HR");
            this.dsKandidati1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbInstruktor
            // 
            this.cbInstruktor.DataSource = this.dsInstruktori1;
            this.cbInstruktor.DisplayMember = "Instruktori.Ime";
            this.cbInstruktor.FormattingEnabled = true;
            this.cbInstruktor.Location = new System.Drawing.Point(139, 341);
            this.cbInstruktor.Name = "cbInstruktor";
            this.cbInstruktor.Size = new System.Drawing.Size(158, 24);
            this.cbInstruktor.TabIndex = 8;
            // 
            // dsInstruktori1
            // 
            this.dsInstruktori1.DataSetName = "dsInstruktori";
            this.dsInstruktori1.Locale = new System.Globalization.CultureInfo("hr-HR");
            this.dsInstruktori1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblKandidatID
            // 
            this.lblKandidatID.Location = new System.Drawing.Point(18, 227);
            this.lblKandidatID.Name = "lblKandidatID";
            this.lblKandidatID.Size = new System.Drawing.Size(73, 23);
            this.lblKandidatID.TabIndex = 62;
            this.lblKandidatID.Text = "Kandidat:";
            this.lblKandidatID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblInstruktorID
            // 
            this.lblInstruktorID.Location = new System.Drawing.Point(17, 342);
            this.lblInstruktorID.Name = "lblInstruktorID";
            this.lblInstruktorID.Size = new System.Drawing.Size(76, 23);
            this.lblInstruktorID.TabIndex = 61;
            this.lblInstruktorID.Text = "Instruktor:";
            this.lblInstruktorID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DTPdatumObuke
            // 
            this.DTPdatumObuke.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPdatumObuke.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.DTPdatumObuke.Location = new System.Drawing.Point(138, 32);
            this.DTPdatumObuke.Name = "DTPdatumObuke";
            this.DTPdatumObuke.Size = new System.Drawing.Size(159, 22);
            this.DTPdatumObuke.TabIndex = 0;
            this.DTPdatumObuke.Value = new System.DateTime(2007, 4, 11, 0, 0, 0, 0);
            // 
            // DTPvrijemeDo
            // 
            this.DTPvrijemeDo.CustomFormat = "H\':\'mm";
            this.DTPvrijemeDo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTPvrijemeDo.Location = new System.Drawing.Point(138, 191);
            this.DTPvrijemeDo.Name = "DTPvrijemeDo";
            this.DTPvrijemeDo.Size = new System.Drawing.Size(159, 22);
            this.DTPvrijemeDo.TabIndex = 4;
            // 
            // DTPvrijemeOd
            // 
            this.DTPvrijemeOd.CustomFormat = "H\':\'mm";
            this.DTPvrijemeOd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTPvrijemeOd.Location = new System.Drawing.Point(138, 155);
            this.DTPvrijemeOd.Name = "DTPvrijemeOd";
            this.DTPvrijemeOd.Size = new System.Drawing.Size(159, 22);
            this.DTPvrijemeOd.TabIndex = 3;
            this.DTPvrijemeOd.Value = new System.DateTime(2007, 10, 31, 18, 56, 0, 0);
            // 
            // tbKategorijaID
            // 
            this.tbKategorijaID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsKategorije1, "Kategorije.KategorijaID", true));
            this.tbKategorijaID.Location = new System.Drawing.Point(139, 266);
            this.tbKategorijaID.Name = "tbKategorijaID";
            this.tbKategorijaID.ReadOnly = true;
            this.tbKategorijaID.Size = new System.Drawing.Size(24, 22);
            this.tbKategorijaID.TabIndex = 50;
            this.tbKategorijaID.TabStop = false;
            // 
            // lbKategorija
            // 
            this.lbKategorija.Location = new System.Drawing.Point(18, 264);
            this.lbKategorija.Name = "lbKategorija";
            this.lbKategorija.Size = new System.Drawing.Size(88, 23);
            this.lbKategorija.TabIndex = 53;
            this.lbKategorija.Text = "Kategorija:";
            this.lbKategorija.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbVrijemeDo
            // 
            this.lbVrijemeDo.Location = new System.Drawing.Point(18, 190);
            this.lbVrijemeDo.Name = "lbVrijemeDo";
            this.lbVrijemeDo.Size = new System.Drawing.Size(88, 23);
            this.lbVrijemeDo.TabIndex = 48;
            this.lbVrijemeDo.Text = "Vrijeme Do:";
            this.lbVrijemeDo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbVoziloID
            // 
            this.tbVoziloID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsVozila1, "Vozila.VoziloID", true));
            this.tbVoziloID.Location = new System.Drawing.Point(139, 303);
            this.tbVoziloID.Name = "tbVoziloID";
            this.tbVoziloID.ReadOnly = true;
            this.tbVoziloID.Size = new System.Drawing.Size(24, 22);
            this.tbVoziloID.TabIndex = 15;
            this.tbVoziloID.TabStop = false;
            // 
            // lbModel
            // 
            this.lbModel.Location = new System.Drawing.Point(18, 301);
            this.lbModel.Name = "lbModel";
            this.lbModel.Size = new System.Drawing.Size(101, 23);
            this.lbModel.TabIndex = 46;
            this.lbModel.Text = "Model vozila:";
            this.lbModel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbInstruktorID
            // 
            this.tbInstruktorID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsInstruktori1, "Instruktori.ID", true));
            this.tbInstruktorID.Location = new System.Drawing.Point(140, 342);
            this.tbInstruktorID.Name = "tbInstruktorID";
            this.tbInstruktorID.ReadOnly = true;
            this.tbInstruktorID.Size = new System.Drawing.Size(24, 22);
            this.tbInstruktorID.TabIndex = 7;
            this.tbInstruktorID.TabStop = false;
            // 
            // lbVrijemeOd
            // 
            this.lbVrijemeOd.Location = new System.Drawing.Point(18, 155);
            this.lbVrijemeOd.Name = "lbVrijemeOd";
            this.lbVrijemeOd.Size = new System.Drawing.Size(88, 23);
            this.lbVrijemeOd.TabIndex = 36;
            this.lbVrijemeOd.Text = "Vrijeme Od:";
            this.lbVrijemeOd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbMjestoObuke
            // 
            this.tbMjestoObuke.Location = new System.Drawing.Point(139, 120);
            this.tbMjestoObuke.Name = "tbMjestoObuke";
            this.tbMjestoObuke.Size = new System.Drawing.Size(159, 22);
            this.tbMjestoObuke.TabIndex = 2;
            // 
            // lbMjestoObuke
            // 
            this.lbMjestoObuke.Location = new System.Drawing.Point(18, 120);
            this.lbMjestoObuke.Name = "lbMjestoObuke";
            this.lbMjestoObuke.Size = new System.Drawing.Size(104, 23);
            this.lbMjestoObuke.TabIndex = 34;
            this.lbMjestoObuke.Text = "Mjesto Obuke:";
            this.lbMjestoObuke.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbKandidatID
            // 
            this.tbKandidatID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsKandidati1, "Kandidati.KandidatID", true));
            this.tbKandidatID.Location = new System.Drawing.Point(138, 227);
            this.tbKandidatID.Name = "tbKandidatID";
            this.tbKandidatID.ReadOnly = true;
            this.tbKandidatID.Size = new System.Drawing.Size(24, 22);
            this.tbKandidatID.TabIndex = 11;
            this.tbKandidatID.TabStop = false;
            // 
            // tbMetodskaJedinica
            // 
            this.tbMetodskaJedinica.Location = new System.Drawing.Point(139, 67);
            this.tbMetodskaJedinica.Multiline = true;
            this.tbMetodskaJedinica.Name = "tbMetodskaJedinica";
            this.tbMetodskaJedinica.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbMetodskaJedinica.Size = new System.Drawing.Size(159, 40);
            this.tbMetodskaJedinica.TabIndex = 1;
            // 
            // tbCasID
            // 
            this.tbCasID.Location = new System.Drawing.Point(138, 32);
            this.tbCasID.Name = "tbCasID";
            this.tbCasID.ReadOnly = true;
            this.tbCasID.Size = new System.Drawing.Size(24, 22);
            this.tbCasID.TabIndex = 0;
            this.tbCasID.TabStop = false;
            // 
            // lbDatumObuke
            // 
            this.lbDatumObuke.Location = new System.Drawing.Point(18, 32);
            this.lbDatumObuke.Name = "lbDatumObuke";
            this.lbDatumObuke.Size = new System.Drawing.Size(88, 23);
            this.lbDatumObuke.TabIndex = 3;
            this.lbDatumObuke.Text = "Datum obuke:";
            this.lbDatumObuke.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbMetodskaJedinica
            // 
            this.lbMetodskaJedinica.Location = new System.Drawing.Point(18, 75);
            this.lbMetodskaJedinica.Name = "lbMetodskaJedinica";
            this.lbMetodskaJedinica.Size = new System.Drawing.Size(88, 32);
            this.lbMetodskaJedinica.TabIndex = 2;
            this.lbMetodskaJedinica.Text = "Metodska Jedinica:";
            this.lbMetodskaJedinica.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gbOpcije
            // 
            this.gbOpcije.BackColor = System.Drawing.SystemColors.Control;
            this.gbOpcije.Controls.Add(this.duZatvori);
            this.gbOpcije.Controls.Add(this.duSpasi);
            this.gbOpcije.Location = new System.Drawing.Point(15, 398);
            this.gbOpcije.Name = "gbOpcije";
            this.gbOpcije.Size = new System.Drawing.Size(319, 72);
            this.gbOpcije.TabIndex = 8;
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
            this.duZatvori.Location = new System.Drawing.Point(185, 24);
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
            this.duSpasi.Location = new System.Drawing.Point(30, 24);
            this.duSpasi.Name = "duSpasi";
            this.duSpasi.Size = new System.Drawing.Size(112, 32);
            this.duSpasi.TabIndex = 0;
            this.duSpasi.Text = "       Spasi";
            this.duSpasi.UseVisualStyleBackColor = false;
            this.duSpasi.Click += new System.EventHandler(this.duSpasi_Click);
            // 
            // connDnevnikUnos
            // 
            this.connDnevnikUnos.ConnectionString = "Data Source=(local);Initial Catalog=baza;integrated security=SSPI";
            this.connDnevnikUnos.FireInfoMessageEventOnUserErrors = false;
            // 
            // frmDnevnikUnos
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 15);
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(350, 480);
            this.Controls.Add(this.gbOpcije);
            this.Controls.Add(this.gbPodaci);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmDnevnikUnos";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Unos u dnevnik Obuke";
            this.Load += new System.EventHandler(this.frmDnevnikUnos_Load);
            this.gbPodaci.ResumeLayout(false);
            this.gbPodaci.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsVozila1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsKategorije1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsKandidati1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsInstruktori1)).EndInit();
            this.gbOpcije.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		#endregion

		public void uzmiPodatke(clsDnevnikObuke a,int o)
		{
			this.dnevnik=a;
			this.opcija=o;
		}

		public void uzmiBroj(int b)
		{
			broj = b;
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
        //Novo
        public void ucitajVozila()
        {
            string query = "SELECT VoziloID, Model FROM Vozila ";

            try
            {
                SqlCommand cmd = new SqlCommand(query, clsKonekcija.GetConnection());
                SqlDataAdapter cmdAdapter = new SqlDataAdapter(cmd);

                dsVozila1.Clear();
                cmdAdapter.Fill(dsVozila1.Vozila);
            }
            catch (Exception ex)
            {
                string iz = ex.Message.ToString();
                MessageBox.Show("Došlo je do greške!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        //
        
        private void frmDnevnikUnos_Load(object sender, System.EventArgs e)
		{
            ucitajKandidate();
            ucitajKategorije();
            ucitajInstruktore();
            ucitajVozila();

            if(this.opcija==1)
			{
                this.duSpasi.Text = "Spasi";                
			}
			if(this.opcija==2)
			{
                this.duSpasi.Text = "Izmjeni";                		
				
				//Ako je odabrana opcija za izmjenu podataka onda proslijedi 
				//odabrani zapis iz data grida u formu za izmjenu podataka koristeci varijable iz clsVarijable
				this.tbCasID.Text=this.dnevnik.CasID;
				this.tbKandidatID.Text=this.dnevnik.KandidatID;
                this.cbKandidat.Text = this.dnevnik.KandidatIme +" "+ this.dnevnik.KandidatPrezime;                
                				
                this.tbKategorijaID.Text=this.dnevnik.KategorijaID;
                this.cbKategorija.Text = this.dnevnik.Kategorija;
                				
				this.DTPdatumObuke.Text=this.dnevnik.DatumObuke;
				this.tbMetodskaJedinica.Text=this.dnevnik.MetodskaJedinica;
				this.tbMjestoObuke.Text=this.dnevnik.MjestoObuke;
				this.DTPvrijemeOd.Text=this.dnevnik.VrijemeOd;
				this.DTPvrijemeDo.Text=this.dnevnik.VrijemeDo;
				
                this.tbVoziloID.Text=this.dnevnik.VoziloID;
                this.cbVozilo.Text = this.dnevnik.Model;
                
				this.tbInstruktorID.Text=this.dnevnik.InstruktorID;
                this.cbInstruktor.Text = this.dnevnik.InstruktorIme +" "+ this.dnevnik.InstruktorPrezime;                
			}
		}

		private void duSpasi_Click(object sender, System.EventArgs e)
		{
            if (this.duSpasi.Text == "Spasi")
            {
                string query = "INSERT INTO DnevnikObuke(KandidatID, KategorijaID, DatumObuke, MetodskaJedinica, MjestoObuke, VrijemeOd, VrijemeDo, VoziloID, InstruktorID) VALUES('" + tbKandidatID.Text + "','" + tbKategorijaID.Text + "',@DatumObuke,'" + tbMetodskaJedinica.Text + "','" + tbMjestoObuke.Text + "',@VrijemeOd, @VrijemeDo, '" + tbVoziloID.Text + "', '" + tbInstruktorID.Text + "');";

                try
                {
                    SqlCommand cmd = new SqlCommand(query, clsKonekcija.GetConnection());

                    cmd.Parameters.Add("@DatumObuke", SqlDbType.DateTime);
                    cmd.Parameters["@DatumObuke"].Value = DTPdatumObuke.Text.ToString();

                    cmd.Parameters.Add("@VrijemeOd", SqlDbType.VarChar);
                    cmd.Parameters["@VrijemeOd"].Value = DTPvrijemeOd.Text.ToString();

                    cmd.Parameters.Add("@VrijemeDo", SqlDbType.VarChar);
                    cmd.Parameters["@VrijemeDo"].Value = DTPvrijemeDo.Text.ToString();

                    //this.connDnevnikUnos.Open();
                    cmd.ExecuteNonQuery();
                    //this.connDnevnikUnos.Close();

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
                if (this.tbCasID.Text != "")
                {
                    string query1 = "UPDATE DnevnikObuke SET KandidatID='" + tbKandidatID.Text + "' WHERE(CasID=" + tbCasID.Text + ")";
                    string query2 = "UPDATE DnevnikObuke SET KategorijaID='" + tbKategorijaID.Text + "' WHERE(CasID=" + tbCasID.Text + ")";
                    string query3 = "UPDATE DnevnikObuke SET DatumObuke=@DatumObuke WHERE(CasID=" + tbCasID.Text + ")";
                    string query4 = "UPDATE DnevnikObuke SET MetodskaJedinica='" + tbMetodskaJedinica.Text + "' WHERE(CasID=" + tbCasID.Text + ")";
                    string query5 = "UPDATE DnevnikObuke SET MjestoObuke='" + tbMjestoObuke.Text + "' WHERE(CasID=" + tbCasID.Text + ")";
                    string query6 = "UPDATE DnevnikObuke SET VrijemeOd= @VrijemeOd WHERE(CasID=" + tbCasID.Text + ")";
                    string query7 = "UPDATE DnevnikObuke SET VrijemeDo= @VrijemeDo WHERE(CasID=" + tbCasID.Text + ")";
                    string query8 = "UPDATE DnevnikObuke SET VoziloID='" + tbVoziloID.Text + "' WHERE(CasID=" + tbCasID.Text + ")";
                    string query9 = "UPDATE DnevnikObuke SET InstruktorID='" + tbInstruktorID.Text + "' WHERE(CasID=" + tbCasID.Text + ")";

                    try
                    {
                        SqlCommand cmd1 = new SqlCommand(query1, clsKonekcija.GetConnection());
                        SqlCommand cmd2 = new SqlCommand(query2, clsKonekcija.GetConnection());
                        SqlCommand cmd3 = new SqlCommand(query3, clsKonekcija.GetConnection());
                        SqlCommand cmd4 = new SqlCommand(query4, clsKonekcija.GetConnection());
                        SqlCommand cmd5 = new SqlCommand(query5, clsKonekcija.GetConnection());
                        SqlCommand cmd6 = new SqlCommand(query6, clsKonekcija.GetConnection());
                        SqlCommand cmd7 = new SqlCommand(query7, clsKonekcija.GetConnection());
                        SqlCommand cmd8 = new SqlCommand(query8, clsKonekcija.GetConnection());
                        SqlCommand cmd9 = new SqlCommand(query9, clsKonekcija.GetConnection());

                        cmd3.Parameters.Add("@DatumObuke", SqlDbType.DateTime);
                        cmd3.Parameters["@DatumObuke"].Value = DTPdatumObuke.Text.ToString();

                        cmd6.Parameters.Add("@VrijemeOd", SqlDbType.VarChar);
                        cmd6.Parameters["@VrijemeOd"].Value = DTPvrijemeOd.Text.ToString();

                        cmd7.Parameters.Add("@VrijemeDo", SqlDbType.VarChar);
                        cmd7.Parameters["@VrijemeDo"].Value = DTPvrijemeDo.Text.ToString();

                        //this.connDnevnikUnos.Open();
                        cmd1.ExecuteNonQuery();
                        cmd2.ExecuteNonQuery();
                        cmd3.ExecuteNonQuery();
                        cmd4.ExecuteNonQuery();
                        cmd5.ExecuteNonQuery();
                        cmd6.ExecuteNonQuery();
                        cmd7.ExecuteNonQuery();
                        cmd8.ExecuteNonQuery();
                        cmd9.ExecuteNonQuery();
                        //this.connDnevnikUnos.Close();

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
        		
		public void UnesiKategoriju(string sKategorijaID, string sKategorija)
		{
			//tbKategorijaID.Text=sKategorijaID;
			//tbKategorija.Text=sKategorija;
            /*
            duKategorijaUnos_Click
            frmKategorije f = new frmKategorije(this);
            f.uzmiBroj(4); 
            f.ShowDialog();
            */
        }
		
		private void duKategorijaUnos_Click(object sender, System.EventArgs e)
		{
			
		}

		public void UnesiKandidata(string sKandidatID, string sKandidatIme, string sKandidatPrezime)
		{
			//tbKandidatID.Text = sKandidatID;
			//tbKandidatIme.Text = sKandidatIme;
			//tbKandidatPrezime.Text = sKandidatPrezime;
            /*
            duKandidatUnos_Click
            frmKandidati k = new frmKandidati(this);
            k.uzmiBroj(2); 
            k.ShowDialog();
            */
        }
		
		private void duKandidatUnos_Click(object sender, System.EventArgs e)
		{
			
		}

		public void UnesiInstruktora(string sInstruktorID, string sInstruktorIme, string sInstruktorPrezime)
		{
			//tbInstruktorID.Text = sInstruktorID;
			//tbInstruktorIme.Text = sInstruktorIme;
			//tbInstruktorPrezime.Text = sInstruktorPrezime;
            /*
            duInstruktorUnos_Click
            frmInstruktori i = new frmInstruktori(this);
            i.uzmiBroj(2); 
            i.ShowDialog();
            */
        }
		
		private void duInstruktorUnos_Click(object sender, System.EventArgs e)
		{
			
		}

		public void UnesiVozilo(string sVoziloID, string sModel)
		{
			//tbVoziloID.Text = sVoziloID;
			//tbModel.Text = sModel;
            /*
            duVoziloUnos_Click
            frmVozila v = new frmVozila(this);
            v.uzmiBroj(1); 
            v.ShowDialog();
            */
        }
		
		private void duVoziloUnos_Click(object sender, System.EventArgs e)
		{
			
		}

		
	}
}
