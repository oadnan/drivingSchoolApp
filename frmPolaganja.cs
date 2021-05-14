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
	/// Summary description for frmPolaganja.
	/// </summary>
	public class frmPolaganja : System.Windows.Forms.Form
	{
		private System.Data.SqlClient.SqlConnection connPolaganja;
		private System.Data.SqlClient.SqlDataAdapter daPolaganja;
        private AutoSkola.DSetovi.dsPolaganja dsPolaganja1;
		private System.Windows.Forms.GroupBox gbPretraga;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.ComboBox cbPolje;
		private System.Windows.Forms.TextBox tbVrijednost;
		private System.Windows.Forms.Label lbVrijednost;
		private System.Windows.Forms.Label lbPolje;
		private System.Windows.Forms.GroupBox gbOpcije;
		private System.Windows.Forms.Button duOdaberi;
		private System.Windows.Forms.Button duZatvori;
		private System.Windows.Forms.Button duIzbrisi;
		private System.Windows.Forms.Button duOsvjezi;
		private System.Windows.Forms.Button duIzmjeni;
		private System.Windows.Forms.Button duNovi;
		private System.Windows.Forms.DataGrid dgPolaganja;
		private System.Windows.Forms.PictureBox pictureBoxInst;
		private System.Windows.Forms.DataGridTableStyle dgTableStylePolaganja;
		private System.Windows.Forms.DataGridTextBoxColumn PolaganjeID;
		private System.Windows.Forms.DataGridTextBoxColumn KandidatID;
		private System.Windows.Forms.DataGridTextBoxColumn Ime;
		private System.Windows.Forms.DataGridTextBoxColumn Prezime;
		private System.Windows.Forms.DataGridTextBoxColumn DatumPolaganja;
		private System.Windows.Forms.DataGridTextBoxColumn Pokusaj;
		private System.Windows.Forms.DataGridTextBoxColumn KatID;
		private System.Windows.Forms.DataGridTextBoxColumn Kategorija;
		private System.Windows.Forms.DataGridTextBoxColumn InstrID;
		private System.Windows.Forms.DataGridTextBoxColumn ImeInst;
		private System.Windows.Forms.DataGridTextBoxColumn PrezimeInst;
		private System.Windows.Forms.Button duOdstampaj;
		private System.Windows.Forms.Button duPretraga;
		private System.Windows.Forms.ComboBox cbPolje1;
		private System.Windows.Forms.TextBox tbVrijednost1;
		private System.Windows.Forms.Label lbVrijednost1;
		private System.Windows.Forms.Label label2;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
		private System.Windows.Forms.DataGridBoolColumn Polozeno;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmPolaganja()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			this.sqlSelectCommand1.Connection = clsKonekcija.GetConnection();

			this.daPolaganja.Fill(this.dsPolaganja1);
			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		private static frmPolaganja polaganje = null;
		public static frmPolaganja Instance()
		{
			if (polaganje == null) { polaganje = new frmPolaganja(); }

			return polaganje;
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

			polaganje = null;
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPolaganja));
            this.dsPolaganja1 = new AutoSkola.DSetovi.dsPolaganja();
            this.connPolaganja = new System.Data.SqlClient.SqlConnection();
            this.daPolaganja = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.gbPretraga = new System.Windows.Forms.GroupBox();
            this.duPretraga = new System.Windows.Forms.Button();
            this.cbPolje1 = new System.Windows.Forms.ComboBox();
            this.tbVrijednost1 = new System.Windows.Forms.TextBox();
            this.lbVrijednost1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbPolje = new System.Windows.Forms.ComboBox();
            this.tbVrijednost = new System.Windows.Forms.TextBox();
            this.lbVrijednost = new System.Windows.Forms.Label();
            this.lbPolje = new System.Windows.Forms.Label();
            this.gbOpcije = new System.Windows.Forms.GroupBox();
            this.duOdstampaj = new System.Windows.Forms.Button();
            this.duOdaberi = new System.Windows.Forms.Button();
            this.duZatvori = new System.Windows.Forms.Button();
            this.duIzbrisi = new System.Windows.Forms.Button();
            this.duOsvjezi = new System.Windows.Forms.Button();
            this.duIzmjeni = new System.Windows.Forms.Button();
            this.duNovi = new System.Windows.Forms.Button();
            this.dgPolaganja = new System.Windows.Forms.DataGrid();
            this.dgTableStylePolaganja = new System.Windows.Forms.DataGridTableStyle();
            this.PolaganjeID = new System.Windows.Forms.DataGridTextBoxColumn();
            this.KandidatID = new System.Windows.Forms.DataGridTextBoxColumn();
            this.Ime = new System.Windows.Forms.DataGridTextBoxColumn();
            this.Prezime = new System.Windows.Forms.DataGridTextBoxColumn();
            this.DatumPolaganja = new System.Windows.Forms.DataGridTextBoxColumn();
            this.Pokusaj = new System.Windows.Forms.DataGridTextBoxColumn();
            this.Polozeno = new System.Windows.Forms.DataGridBoolColumn();
            this.KatID = new System.Windows.Forms.DataGridTextBoxColumn();
            this.Kategorija = new System.Windows.Forms.DataGridTextBoxColumn();
            this.InstrID = new System.Windows.Forms.DataGridTextBoxColumn();
            this.ImeInst = new System.Windows.Forms.DataGridTextBoxColumn();
            this.PrezimeInst = new System.Windows.Forms.DataGridTextBoxColumn();
            this.pictureBoxInst = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dsPolaganja1)).BeginInit();
            this.gbPretraga.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbOpcije.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPolaganja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInst)).BeginInit();
            this.SuspendLayout();
            // 
            // dsPolaganja1
            // 
            this.dsPolaganja1.DataSetName = "dsPolaganja";
            this.dsPolaganja1.Locale = new System.Globalization.CultureInfo("hr-HR");
            this.dsPolaganja1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // connPolaganja
            // 
            this.connPolaganja.ConnectionString = "Data Source=(local);Initial Catalog=baza;integrated security=SSPI";
            this.connPolaganja.FireInfoMessageEventOnUserErrors = false;
            // 
            // daPolaganja
            // 
            this.daPolaganja.SelectCommand = this.sqlSelectCommand1;
            this.daPolaganja.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Polaganja", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("PolaganjeID", "PolaganjeID"),
                        new System.Data.Common.DataColumnMapping("KandidatID", "KandidatID"),
                        new System.Data.Common.DataColumnMapping("Ime", "Ime"),
                        new System.Data.Common.DataColumnMapping("Prezime", "Prezime"),
                        new System.Data.Common.DataColumnMapping("DatumPolaganja", "DatumPolaganja"),
                        new System.Data.Common.DataColumnMapping("Pokusaj", "Pokusaj"),
                        new System.Data.Common.DataColumnMapping("Polozeno", "Polozeno"),
                        new System.Data.Common.DataColumnMapping("KatID", "KatID"),
                        new System.Data.Common.DataColumnMapping("Kategorija", "Kategorija"),
                        new System.Data.Common.DataColumnMapping("InstrID", "InstrID"),
                        new System.Data.Common.DataColumnMapping("ImeInst", "ImeInst"),
                        new System.Data.Common.DataColumnMapping("PrezimeInst", "PrezimeInst")})});
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = resources.GetString("sqlSelectCommand1.CommandText");
            // 
            // gbPretraga
            // 
            this.gbPretraga.Controls.Add(this.duPretraga);
            this.gbPretraga.Controls.Add(this.cbPolje1);
            this.gbPretraga.Controls.Add(this.tbVrijednost1);
            this.gbPretraga.Controls.Add(this.lbVrijednost1);
            this.gbPretraga.Controls.Add(this.label2);
            this.gbPretraga.Controls.Add(this.pictureBox1);
            this.gbPretraga.Controls.Add(this.cbPolje);
            this.gbPretraga.Controls.Add(this.tbVrijednost);
            this.gbPretraga.Controls.Add(this.lbVrijednost);
            this.gbPretraga.Controls.Add(this.lbPolje);
            this.gbPretraga.Location = new System.Drawing.Point(9, 357);
            this.gbPretraga.Name = "gbPretraga";
            this.gbPretraga.Size = new System.Drawing.Size(622, 107);
            this.gbPretraga.TabIndex = 5;
            this.gbPretraga.TabStop = false;
            this.gbPretraga.Text = "        Pretraga";
            // 
            // duPretraga
            // 
            this.duPretraga.BackColor = System.Drawing.Color.Beige;
            this.duPretraga.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.duPretraga.Image = ((System.Drawing.Image)(resources.GetObject("duPretraga.Image")));
            this.duPretraga.Location = new System.Drawing.Point(563, 40);
            this.duPretraga.Name = "duPretraga";
            this.duPretraga.Size = new System.Drawing.Size(44, 44);
            this.duPretraga.TabIndex = 14;
            this.duPretraga.UseVisualStyleBackColor = false;
            this.duPretraga.Click += new System.EventHandler(this.duPretraga_Click);
            // 
            // cbPolje1
            // 
            this.cbPolje1.Items.AddRange(new object[] {
            "K.Ime",
            "K.Prezime",
            "DatumPolaganja",
            "Pokusaj",
            "Polozeno",
            "Kategorija",
            "I.Ime",
            "I.Prezime"});
            this.cbPolje1.Location = new System.Drawing.Point(128, 65);
            this.cbPolje1.Name = "cbPolje1";
            this.cbPolje1.Size = new System.Drawing.Size(136, 24);
            this.cbPolje1.TabIndex = 11;
            this.cbPolje1.Text = "K.Prezime";
            this.cbPolje1.SelectedValueChanged += new System.EventHandler(this.cbPolje1_SelectedValueChanged);
            // 
            // tbVrijednost1
            // 
            this.tbVrijednost1.Location = new System.Drawing.Point(421, 65);
            this.tbVrijednost1.Name = "tbVrijednost1";
            this.tbVrijednost1.Size = new System.Drawing.Size(128, 22);
            this.tbVrijednost1.TabIndex = 13;
            this.tbVrijednost1.TextChanged += new System.EventHandler(this.tbVrijednost1_TextChanged);
            // 
            // lbVrijednost1
            // 
            this.lbVrijednost1.Location = new System.Drawing.Point(280, 67);
            this.lbVrijednost1.Name = "lbVrijednost1";
            this.lbVrijednost1.Size = new System.Drawing.Size(135, 22);
            this.lbVrijednost1.TabIndex = 12;
            this.lbVrijednost1.Text = "Prezime Kandidata:";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(8, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 23);
            this.label2.TabIndex = 10;
            this.label2.Text = "Odaberite polje 2:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(8, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 22);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // cbPolje
            // 
            this.cbPolje.Items.AddRange(new object[] {
            "K.Ime",
            "K.Prezime",
            "DatumPolaganja",
            "Pokusaj",
            "Polozeno",
            "Kategorija",
            "I.Ime",
            "I.Prezime"});
            this.cbPolje.Location = new System.Drawing.Point(128, 32);
            this.cbPolje.Name = "cbPolje";
            this.cbPolje.Size = new System.Drawing.Size(136, 24);
            this.cbPolje.TabIndex = 0;
            this.cbPolje.Text = "K.Ime";
            this.cbPolje.SelectedValueChanged += new System.EventHandler(this.cbPolje_SelectedValueChanged);
            // 
            // tbVrijednost
            // 
            this.tbVrijednost.Location = new System.Drawing.Point(421, 32);
            this.tbVrijednost.Name = "tbVrijednost";
            this.tbVrijednost.Size = new System.Drawing.Size(128, 22);
            this.tbVrijednost.TabIndex = 1;
            this.tbVrijednost.TextChanged += new System.EventHandler(this.tbVrijednost_TextChanged);
            // 
            // lbVrijednost
            // 
            this.lbVrijednost.Location = new System.Drawing.Point(280, 34);
            this.lbVrijednost.Name = "lbVrijednost";
            this.lbVrijednost.Size = new System.Drawing.Size(135, 22);
            this.lbVrijednost.TabIndex = 1;
            this.lbVrijednost.Text = "Ime Kandidata:";
            // 
            // lbPolje
            // 
            this.lbPolje.Location = new System.Drawing.Point(8, 32);
            this.lbPolje.Name = "lbPolje";
            this.lbPolje.Size = new System.Drawing.Size(112, 32);
            this.lbPolje.TabIndex = 0;
            this.lbPolje.Text = "Odaberite polje 1:";
            // 
            // gbOpcije
            // 
            this.gbOpcije.Controls.Add(this.duOdstampaj);
            this.gbOpcije.Controls.Add(this.duOdaberi);
            this.gbOpcije.Controls.Add(this.duZatvori);
            this.gbOpcije.Controls.Add(this.duIzbrisi);
            this.gbOpcije.Controls.Add(this.duOsvjezi);
            this.gbOpcije.Controls.Add(this.duIzmjeni);
            this.gbOpcije.Controls.Add(this.duNovi);
            this.gbOpcije.Location = new System.Drawing.Point(642, 40);
            this.gbOpcije.Name = "gbOpcije";
            this.gbOpcije.Size = new System.Drawing.Size(136, 280);
            this.gbOpcije.TabIndex = 4;
            this.gbOpcije.TabStop = false;
            this.gbOpcije.Text = "Opcije";
            // 
            // duOdstampaj
            // 
            this.duOdstampaj.BackColor = System.Drawing.Color.Beige;
            this.duOdstampaj.Cursor = System.Windows.Forms.Cursors.Hand;
            this.duOdstampaj.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.duOdstampaj.Image = ((System.Drawing.Image)(resources.GetObject("duOdstampaj.Image")));
            this.duOdstampaj.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.duOdstampaj.Location = new System.Drawing.Point(12, 192);
            this.duOdstampaj.Name = "duOdstampaj";
            this.duOdstampaj.Size = new System.Drawing.Size(112, 32);
            this.duOdstampaj.TabIndex = 6;
            this.duOdstampaj.Text = "      Odštampaj";
            this.duOdstampaj.UseVisualStyleBackColor = false;
            this.duOdstampaj.Click += new System.EventHandler(this.duOdstampaj_Click);
            // 
            // duOdaberi
            // 
            this.duOdaberi.BackColor = System.Drawing.Color.Beige;
            this.duOdaberi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.duOdaberi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.duOdaberi.Image = ((System.Drawing.Image)(resources.GetObject("duOdaberi.Image")));
            this.duOdaberi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.duOdaberi.Location = new System.Drawing.Point(12, 192);
            this.duOdaberi.Name = "duOdaberi";
            this.duOdaberi.Size = new System.Drawing.Size(112, 32);
            this.duOdaberi.TabIndex = 4;
            this.duOdaberi.Text = "   Odaberi";
            this.duOdaberi.UseVisualStyleBackColor = false;
            // 
            // duZatvori
            // 
            this.duZatvori.BackColor = System.Drawing.Color.Beige;
            this.duZatvori.Cursor = System.Windows.Forms.Cursors.Hand;
            this.duZatvori.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.duZatvori.Image = ((System.Drawing.Image)(resources.GetObject("duZatvori.Image")));
            this.duZatvori.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.duZatvori.Location = new System.Drawing.Point(12, 232);
            this.duZatvori.Name = "duZatvori";
            this.duZatvori.Size = new System.Drawing.Size(112, 32);
            this.duZatvori.TabIndex = 5;
            this.duZatvori.Text = " Zatvori";
            this.duZatvori.UseVisualStyleBackColor = false;
            this.duZatvori.Click += new System.EventHandler(this.duZatvori_Click);
            // 
            // duIzbrisi
            // 
            this.duIzbrisi.BackColor = System.Drawing.Color.Beige;
            this.duIzbrisi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.duIzbrisi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.duIzbrisi.Image = ((System.Drawing.Image)(resources.GetObject("duIzbrisi.Image")));
            this.duIzbrisi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.duIzbrisi.Location = new System.Drawing.Point(12, 152);
            this.duIzbrisi.Name = "duIzbrisi";
            this.duIzbrisi.Size = new System.Drawing.Size(112, 32);
            this.duIzbrisi.TabIndex = 3;
            this.duIzbrisi.Text = "Izbriši";
            this.duIzbrisi.UseVisualStyleBackColor = false;
            this.duIzbrisi.Click += new System.EventHandler(this.duIzbrisi_Click);
            // 
            // duOsvjezi
            // 
            this.duOsvjezi.BackColor = System.Drawing.Color.Beige;
            this.duOsvjezi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.duOsvjezi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.duOsvjezi.Image = ((System.Drawing.Image)(resources.GetObject("duOsvjezi.Image")));
            this.duOsvjezi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.duOsvjezi.Location = new System.Drawing.Point(12, 112);
            this.duOsvjezi.Name = "duOsvjezi";
            this.duOsvjezi.Size = new System.Drawing.Size(112, 32);
            this.duOsvjezi.TabIndex = 2;
            this.duOsvjezi.Text = " Osvježi";
            this.duOsvjezi.UseVisualStyleBackColor = false;
            this.duOsvjezi.Click += new System.EventHandler(this.duOsvjezi_Click);
            // 
            // duIzmjeni
            // 
            this.duIzmjeni.BackColor = System.Drawing.Color.Beige;
            this.duIzmjeni.Cursor = System.Windows.Forms.Cursors.Hand;
            this.duIzmjeni.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.duIzmjeni.Image = ((System.Drawing.Image)(resources.GetObject("duIzmjeni.Image")));
            this.duIzmjeni.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.duIzmjeni.Location = new System.Drawing.Point(12, 72);
            this.duIzmjeni.Name = "duIzmjeni";
            this.duIzmjeni.Size = new System.Drawing.Size(112, 32);
            this.duIzmjeni.TabIndex = 1;
            this.duIzmjeni.Text = " Izmjeni";
            this.duIzmjeni.UseVisualStyleBackColor = false;
            this.duIzmjeni.Click += new System.EventHandler(this.duIzmjeni_Click);
            // 
            // duNovi
            // 
            this.duNovi.BackColor = System.Drawing.Color.Beige;
            this.duNovi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.duNovi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.duNovi.Image = ((System.Drawing.Image)(resources.GetObject("duNovi.Image")));
            this.duNovi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.duNovi.Location = new System.Drawing.Point(12, 32);
            this.duNovi.Name = "duNovi";
            this.duNovi.Size = new System.Drawing.Size(112, 32);
            this.duNovi.TabIndex = 0;
            this.duNovi.Text = "       Dodaj novi";
            this.duNovi.UseVisualStyleBackColor = false;
            this.duNovi.Click += new System.EventHandler(this.duNovi_Click);
            // 
            // dgPolaganja
            // 
            this.dgPolaganja.DataMember = "";
            this.dgPolaganja.DataSource = this.dsPolaganja1.Polaganja;
            this.dgPolaganja.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dgPolaganja.Location = new System.Drawing.Point(8, 46);
            this.dgPolaganja.Name = "dgPolaganja";
            this.dgPolaganja.PreferredColumnWidth = 80;
            this.dgPolaganja.ReadOnly = true;
            this.dgPolaganja.Size = new System.Drawing.Size(623, 304);
            this.dgPolaganja.TabIndex = 6;
            this.dgPolaganja.TableStyles.AddRange(new System.Windows.Forms.DataGridTableStyle[] {
            this.dgTableStylePolaganja});
            this.dgPolaganja.DoubleClick += new System.EventHandler(this.dgPolaganja_DoubleClick);
            // 
            // dgTableStylePolaganja
            // 
            this.dgTableStylePolaganja.DataGrid = this.dgPolaganja;
            this.dgTableStylePolaganja.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {
            this.PolaganjeID,
            this.KandidatID,
            this.Ime,
            this.Prezime,
            this.DatumPolaganja,
            this.Pokusaj,
            this.Polozeno,
            this.KatID,
            this.Kategorija,
            this.InstrID,
            this.ImeInst,
            this.PrezimeInst});
            this.dgTableStylePolaganja.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dgTableStylePolaganja.MappingName = "Polaganja";
            this.dgTableStylePolaganja.PreferredRowHeight = 22;
            // 
            // PolaganjeID
            // 
            this.PolaganjeID.Format = "";
            this.PolaganjeID.FormatInfo = null;
            this.PolaganjeID.HeaderText = "ID";
            this.PolaganjeID.MappingName = "PolaganjeID";
            this.PolaganjeID.Width = 0;
            // 
            // KandidatID
            // 
            this.KandidatID.Format = "";
            this.KandidatID.FormatInfo = null;
            this.KandidatID.HeaderText = "KandidatID";
            this.KandidatID.MappingName = "KandidatID";
            this.KandidatID.Width = 0;
            // 
            // Ime
            // 
            this.Ime.Format = "";
            this.Ime.FormatInfo = null;
            this.Ime.HeaderText = "Kandidat";
            this.Ime.MappingName = "Ime";
            this.Ime.Width = 75;
            // 
            // Prezime
            // 
            this.Prezime.Format = "";
            this.Prezime.FormatInfo = null;
            this.Prezime.MappingName = "Prezime";
            this.Prezime.Width = 75;
            // 
            // DatumPolaganja
            // 
            this.DatumPolaganja.Format = "";
            this.DatumPolaganja.FormatInfo = null;
            this.DatumPolaganja.HeaderText = "DatumPolaganja";
            this.DatumPolaganja.MappingName = "DatumPolaganja";
            this.DatumPolaganja.Width = 108;
            // 
            // Pokusaj
            // 
            this.Pokusaj.Format = "";
            this.Pokusaj.FormatInfo = null;
            this.Pokusaj.HeaderText = "Pokušaj";
            this.Pokusaj.MappingName = "Pokusaj";
            this.Pokusaj.Width = 75;
            // 
            // Polozeno
            // 
            this.Polozeno.HeaderText = "Položeno";
            this.Polozeno.MappingName = "Polozeno";
            this.Polozeno.Width = 70;
            // 
            // KatID
            // 
            this.KatID.Format = "";
            this.KatID.FormatInfo = null;
            this.KatID.HeaderText = "KatID";
            this.KatID.MappingName = "KatID";
            this.KatID.Width = 0;
            // 
            // Kategorija
            // 
            this.Kategorija.Format = "";
            this.Kategorija.FormatInfo = null;
            this.Kategorija.HeaderText = "Kategorija";
            this.Kategorija.MappingName = "Kategorija";
            this.Kategorija.Width = 75;
            // 
            // InstrID
            // 
            this.InstrID.Format = "";
            this.InstrID.FormatInfo = null;
            this.InstrID.HeaderText = "InstrID";
            this.InstrID.MappingName = "InstrID";
            this.InstrID.Width = 0;
            // 
            // ImeInst
            // 
            this.ImeInst.Format = "";
            this.ImeInst.FormatInfo = null;
            this.ImeInst.HeaderText = "Instruktor";
            this.ImeInst.MappingName = "ImeInst";
            this.ImeInst.NullText = "";
            this.ImeInst.Width = 75;
            // 
            // PrezimeInst
            // 
            this.PrezimeInst.Format = "";
            this.PrezimeInst.FormatInfo = null;
            this.PrezimeInst.MappingName = "PrezimeInst";
            this.PrezimeInst.Width = 75;
            // 
            // pictureBoxInst
            // 
            this.pictureBoxInst.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxInst.Image")));
            this.pictureBoxInst.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxInst.Name = "pictureBoxInst";
            this.pictureBoxInst.Size = new System.Drawing.Size(790, 32);
            this.pictureBoxInst.TabIndex = 7;
            this.pictureBoxInst.TabStop = false;
            // 
            // frmPolaganja
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 15);
            this.ClientSize = new System.Drawing.Size(789, 475);
            this.Controls.Add(this.pictureBoxInst);
            this.Controls.Add(this.dgPolaganja);
            this.Controls.Add(this.gbPretraga);
            this.Controls.Add(this.gbOpcije);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(797, 515);
            this.Name = "frmPolaganja";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Polaganja";
            ((System.ComponentModel.ISupportInitialize)(this.dsPolaganja1)).EndInit();
            this.gbPretraga.ResumeLayout(false);
            this.gbPretraga.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbOpcije.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgPolaganja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInst)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		private void tbVrijednost_TextChanged(object sender, System.EventArgs e)
		{
			if (this.tbVrijednost.Text=="" && this.tbVrijednost1.Text=="")
			{
                duOsvjezi_Click(sender, e);                
			}			
		}

		private void duNovi_Click(object sender, System.EventArgs e)
		{
			clsPolaganja polaganje = new clsPolaganja();
			frmPolaganjaUnos dodaj = new frmPolaganjaUnos();
			dodaj.uzmiPodatke(polaganje,1);
			//dodaj.ShowDialog(); 

            if (dodaj.ShowDialog() == DialogResult.OK)
            {
                duOsvjezi_Click(sender, e);
            }
		}

		private void duIzmjeni_Click(object sender, System.EventArgs e)
		{
			if(this.dsPolaganja1.Polaganja.Rows.Count>0)
			{
				//Odabir trenutno oznacene celije
				DataGridCell celija = this.dgPolaganja.CurrentCell;
				//Odabir podataka iz trenutne celije na pozicijama kolona od 0 i 7 
				object I0=this.dgPolaganja[celija.RowNumber, 0];
				object I1=this.dgPolaganja[celija.RowNumber, 1];
				object I2=this.dgPolaganja[celija.RowNumber, 2];
				object I3=this.dgPolaganja[celija.RowNumber, 3];
				object I4=this.dgPolaganja[celija.RowNumber, 4];
				object I5=this.dgPolaganja[celija.RowNumber, 5];
				object I6=this.dgPolaganja[celija.RowNumber, 6];
				object I7=this.dgPolaganja[celija.RowNumber, 7];
				object I8=this.dgPolaganja[celija.RowNumber, 8];
				object I9=this.dgPolaganja[celija.RowNumber, 9];
				object I10=this.dgPolaganja[celija.RowNumber, 10];
				object I11=this.dgPolaganja[celija.RowNumber, 11];
				
				//Kreiranje novog objekta klase clsInstruktori
				clsPolaganja polaganje = new clsPolaganja();
				
				//Konvertovanje objekata I0 do I7 u stringove i 
				//proslijedivanje u varijable iz clsVarijable
				polaganje.PolaganjeID = Convert.ToString(I0);
				polaganje.KandidatID = Convert.ToString(I1);
				polaganje.KandidatIme = Convert.ToString(I2);
				polaganje.KandidatPrezime = Convert.ToString(I3);				
				polaganje.DatumPolaganja = Convert.ToString(I4);
				polaganje.Pokusaj = Convert.ToString(I5);
				polaganje.Polozeno = Convert.ToBoolean(I6);
				polaganje.KategorijaID = Convert.ToString(I7);
				polaganje.Kategorija = Convert.ToString(I8);				
				polaganje.InstruktorID = Convert.ToString(I9);
				polaganje.InstruktorIme = Convert.ToString(I10);
				polaganje.InstruktorPrezime = Convert.ToString(I11);
				
				//Kreiranje objekta izmjeni klase frmPolaganjaUnos
				frmPolaganjaUnos izmjeni = new frmPolaganjaUnos();
				//Poziv funkcije uzmiPodatke za objekat izmjeni
				izmjeni.uzmiPodatke(polaganje,2);
				//Otvaranje forme frmPolaganjaUnos
				//izmjeni.ShowDialog();
                
                if (izmjeni.ShowDialog() == DialogResult.OK)
                {
                    duOsvjezi_Click(sender, e);
                }
			}
			else
			{
				MessageBox.Show("Niste oznaèili zapis za Ažuriranje:","Upozorenje !",MessageBoxButtons.OK,MessageBoxIcon.Question);
			}
		}

		private void duOsvjezi_Click(object sender, System.EventArgs e)
		{
			this.dsPolaganja1.Clear();
			this.daPolaganja.Fill(this.dsPolaganja1);
						
		}

		private void duIzbrisi_Click(object sender, System.EventArgs e)
		{
			//Ako data set dsInstruktori nije prazan
			if(this.dsPolaganja1.Polaganja.Rows.Count>0)
			{
				//Odabir trenutno oznacene celije
				DataGridCell selectedCell = dgPolaganja.CurrentCell;
				//Odabir podataka iz trenutne celije na poziciji kolona 1 i 2 
				object o1 = dgPolaganja[selectedCell.RowNumber, 2];
				object o2 = dgPolaganja[selectedCell.RowNumber, 3];
				object o3 = dgPolaganja[selectedCell.RowNumber, 5];
				
				//Konvertovanje objekata o1 i o2 u stringove
				string Ime = Convert.ToString(o1);
				string Prezime = Convert.ToString(o2);
				string Pokusaj = Convert.ToString(o3);
				
				//Prikaz dijalog boksa sa pitanjem, ako je rezultat opcija Yes
				//Onda izbriši odabrani zapis
				if(MessageBox.Show("Da li ste sigurni da želite izbrisati podatke o polaganju za kandidata: \nIme: "+Ime+" \nPrezime: "+Prezime+" \nPokusaj: "+Pokusaj+"","Upozorenje !",MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes)
				{
					System.Windows.Forms.DataGridCell celija = this.dgPolaganja.CurrentCell;
					object B0=this.dgPolaganja[celija.RowNumber, 0];
					string PolaganjeID=Convert.ToString(B0);

					try
					{

						//this.connPolaganja.Open();
						SqlCommand kom = new SqlCommand("DELETE FROM Polaganja WHERE PolaganjeID = "+PolaganjeID+"", clsKonekcija.GetConnection());
						kom.ExecuteNonQuery();
						//this.connPolaganja.Close();

						this.dsPolaganja1.Clear();
						this.daPolaganja.Fill(this.dsPolaganja1);
					}
					catch(SqlException ex)
					{
						string iz = ex.Message.ToString();
						MessageBox.Show("Došlo je do greške!","Upozorenje",MessageBoxButtons.OK,MessageBoxIcon.Question);
					}
			
				}
			}
			else
			{
				MessageBox.Show("Oznacili ste prazno polje.","Upozorenje !",MessageBoxButtons.OK,MessageBoxIcon.Question);
			}
		}

		private void duZatvori_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void duOdstampaj_Click(object sender, System.EventArgs e)
		{
			frmIzvPolaganja i = new frmIzvPolaganja();
			i.ShowDialog();
		}

		private void dgPolaganja_DoubleClick(object sender, System.EventArgs e)
		{
			duIzmjeni_Click(sender, e);            
		}

		private void duPretraga_Click(object sender, System.EventArgs e)
		{
			if (this.tbVrijednost.Text=="" && this.tbVrijednost1.Text=="")
			{
				MessageBox.Show("Niste unijeli vrijednost za pretragu!","Upozorenje",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
				this.dsPolaganja1.Clear();
				this.daPolaganja.Fill(this.dsPolaganja1);
			}
			else
			{
				string pretraga= "SELECT P.PolaganjeID, K.KandidatID, K.Ime, K.Prezime, P.DatumPolaganja, P.Pokusaj, P.Polozeno, KAT.KategorijaID AS KatID, KAT.Kategorija, I.InstruktorID AS InstrID, I.Ime AS ImeInst, I.Prezime AS PrezimeInst FROM Polaganja P INNER JOIN Kandidati K ON P.KandidatID = K.KandidatID INNER JOIN Kategorije KAT ON P.KategorijaID = KAT.KategorijaID INNER JOIN Instruktori I ON P.InstruktorID = I.InstruktorID WHERE("+cbPolje.SelectedItem+")LIKE('" + tbVrijednost.Text + "%') AND ("+cbPolje1.SelectedItem+")LIKE('" + tbVrijednost1.Text + "%') ORDER BY PolaganjeID";
				
				try
				{
					//OVAKO SELECT * FROM Polaganja WHERE("+cbPolje.SelectedItem+")LIKE('" + tbVrijednost.Text + "%') ORDER BY PolaganjeID;
					SqlDataAdapter cmdAdapter = new SqlDataAdapter();
					cmdAdapter.SelectCommand =new SqlCommand(pretraga, clsKonekcija.GetConnection());
					cmdAdapter.SelectCommand.CommandType = CommandType.Text;

					//this.connPolaganja.Open();
					this.dsPolaganja1.Clear();
					cmdAdapter.Fill(this.dsPolaganja1,"Polaganja");
					//this.connPolaganja.Close();
					

				}
				catch(Exception ex)
				{
					string iz=ex.Message.ToString();
					MessageBox.Show("Pogreška: "+iz+"","Upozorenje !",MessageBoxButtons.OK,MessageBoxIcon.Information);
				}

			}
		}

        private void cbPolje_SelectedValueChanged(object sender, EventArgs e)
        {
            this.lbVrijednost.Text = this.cbPolje.Text + ":";
            
            if (cbPolje.Text == "K.Ime")
                lbVrijednost.Text = "Ime Kandidata:";
            else if (cbPolje.Text == "K.Prezime")
                lbVrijednost.Text = "Prezime Kandidata:";
            else if (cbPolje.Text == "I.Ime")
                lbVrijednost.Text = "Ime Instruktora:";
            else if (cbPolje.Text == "I.Prezime")
                lbVrijednost.Text = "Prezime Instruktora:";
        }

        private void cbPolje1_SelectedValueChanged(object sender, EventArgs e)
        {
            this.lbVrijednost1.Text = this.cbPolje1.Text + ":";

            if (cbPolje1.Text == "K.Ime")
                lbVrijednost1.Text = "Ime Kandidata:";
            else if (cbPolje1.Text == "K.Prezime")
                lbVrijednost1.Text = "Prezime Kandidata:";
            else if (cbPolje1.Text == "I.Ime")
                lbVrijednost1.Text = "Ime Instruktora:";
            else if (cbPolje1.Text == "I.Prezime")
                lbVrijednost1.Text = "Prezime Instruktora:";
        }

        private void tbVrijednost1_TextChanged(object sender, EventArgs e)
        {
            if (this.tbVrijednost.Text == "" && this.tbVrijednost1.Text == "")
            {
                duOsvjezi_Click(sender, e);                
            }
        }
	}
}
