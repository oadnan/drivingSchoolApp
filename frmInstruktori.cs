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
	/// Summary description for frmInstruktori.
	/// </summary>
	public class frmInstruktori : System.Windows.Forms.Form
	{
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.ComboBox cbPolje;
		private System.Windows.Forms.TextBox tbVrijednost;
		private System.Windows.Forms.Label lbVrijednost1;
		private System.Windows.Forms.Label lbPolje;
		private System.Windows.Forms.Button duOdaberi;
		private System.Windows.Forms.Button duZatvori;
		private System.Windows.Forms.Button duIzbrisi;
		private System.Windows.Forms.Button duOsvjezi;
		private System.Windows.Forms.Button duIzmjeni;
		private System.Windows.Forms.Button duNovi;
		private System.Data.SqlClient.SqlDataAdapter daInstruktori;
		private AutoSkola.DSetovi.dsInstruktori dsInstruktori1;
		private System.Windows.Forms.PictureBox pictureBoxInst;
		private System.Windows.Forms.GroupBox gbOpcije;
		private System.Data.SqlClient.SqlConnection connInstruktori;
		private System.Windows.Forms.GroupBox gbPretraga;
		private System.Windows.Forms.DataGrid dgInstruktori;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		//Objekat koji se koristi kod preklopljenog konstruktora
		frmPolaganjaUnos p;

		//Objekat koji se koristi kod preklopljenog konstruktora
		frmDnevnikUnos d;
		private System.Windows.Forms.Button duOdaberiDnevnik;
		private System.Windows.Forms.Button duOdstampaj;
		private System.Windows.Forms.ComboBox cbPolje1;
		private System.Windows.Forms.Label lbVrijednost2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox tbVrijednost1;
		private System.Windows.Forms.DataGridTableStyle dgTableStyleInstruktori;
		private System.Windows.Forms.DataGridTextBoxColumn ID;
		private System.Windows.Forms.DataGridTextBoxColumn Ime;
		private System.Windows.Forms.DataGridTextBoxColumn Prezime;
		private System.Windows.Forms.DataGridTextBoxColumn DatumRodjenja;
		private System.Windows.Forms.DataGridTextBoxColumn Adresa;
		private System.Windows.Forms.DataGridTextBoxColumn Telefon;
		private System.Windows.Forms.DataGridTextBoxColumn Email;
		private System.Windows.Forms.DataGridTextBoxColumn DatumZaposlenja;
		private System.Windows.Forms.Button duPretraga;
		private System.Windows.Forms.DataGridBoolColumn Testovi;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand1;

		int broj = 0;
		
		public frmInstruktori()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
						
			this.sqlSelectCommand1.Connection = clsKonekcija.GetConnection();
			
			this.daInstruktori.Fill(this.dsInstruktori1);
			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		private static frmInstruktori instruktor = null;
		public static frmInstruktori Instance()
		{
			if (instruktor == null) { instruktor = new frmInstruktori(); }

			return instruktor;
		}  

		//Preklopljeni konstruktor sa argumentom tipa frmKandidatiUnos
		public frmInstruktori(frmPolaganjaUnos fr3)
		{
			InitializeComponent();
			p = new frmPolaganjaUnos();
			p = fr3;
		}

		//Preklopljeni konstruktor sa argumentom tipa frmKandidatiUnos
		public frmInstruktori(frmDnevnikUnos fr2)
		{
			InitializeComponent();
			d = new frmDnevnikUnos();
			d = fr2;
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

			instruktor = null;
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInstruktori));
            this.gbPretraga = new System.Windows.Forms.GroupBox();
            this.duPretraga = new System.Windows.Forms.Button();
            this.cbPolje1 = new System.Windows.Forms.ComboBox();
            this.tbVrijednost1 = new System.Windows.Forms.TextBox();
            this.lbVrijednost2 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbPolje = new System.Windows.Forms.ComboBox();
            this.tbVrijednost = new System.Windows.Forms.TextBox();
            this.lbVrijednost1 = new System.Windows.Forms.Label();
            this.lbPolje = new System.Windows.Forms.Label();
            this.gbOpcije = new System.Windows.Forms.GroupBox();
            this.duOdstampaj = new System.Windows.Forms.Button();
            this.duOdaberiDnevnik = new System.Windows.Forms.Button();
            this.duOdaberi = new System.Windows.Forms.Button();
            this.duZatvori = new System.Windows.Forms.Button();
            this.duIzbrisi = new System.Windows.Forms.Button();
            this.duOsvjezi = new System.Windows.Forms.Button();
            this.duIzmjeni = new System.Windows.Forms.Button();
            this.duNovi = new System.Windows.Forms.Button();
            this.daInstruktori = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.connInstruktori = new System.Data.SqlClient.SqlConnection();
            this.dsInstruktori1 = new AutoSkola.DSetovi.dsInstruktori();
            this.dgInstruktori = new System.Windows.Forms.DataGrid();
            this.dgTableStyleInstruktori = new System.Windows.Forms.DataGridTableStyle();
            this.ID = new System.Windows.Forms.DataGridTextBoxColumn();
            this.Ime = new System.Windows.Forms.DataGridTextBoxColumn();
            this.Prezime = new System.Windows.Forms.DataGridTextBoxColumn();
            this.DatumRodjenja = new System.Windows.Forms.DataGridTextBoxColumn();
            this.Adresa = new System.Windows.Forms.DataGridTextBoxColumn();
            this.Telefon = new System.Windows.Forms.DataGridTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridTextBoxColumn();
            this.DatumZaposlenja = new System.Windows.Forms.DataGridTextBoxColumn();
            this.Testovi = new System.Windows.Forms.DataGridBoolColumn();
            this.pictureBoxInst = new System.Windows.Forms.PictureBox();
            this.gbPretraga.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbOpcije.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsInstruktori1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgInstruktori)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInst)).BeginInit();
            this.SuspendLayout();
            // 
            // gbPretraga
            // 
            this.gbPretraga.Controls.Add(this.duPretraga);
            this.gbPretraga.Controls.Add(this.cbPolje1);
            this.gbPretraga.Controls.Add(this.tbVrijednost1);
            this.gbPretraga.Controls.Add(this.lbVrijednost2);
            this.gbPretraga.Controls.Add(this.label2);
            this.gbPretraga.Controls.Add(this.pictureBox1);
            this.gbPretraga.Controls.Add(this.cbPolje);
            this.gbPretraga.Controls.Add(this.tbVrijednost);
            this.gbPretraga.Controls.Add(this.lbVrijednost1);
            this.gbPretraga.Controls.Add(this.lbPolje);
            this.gbPretraga.Location = new System.Drawing.Point(8, 360);
            this.gbPretraga.Name = "gbPretraga";
            this.gbPretraga.Size = new System.Drawing.Size(599, 112);
            this.gbPretraga.TabIndex = 3;
            this.gbPretraga.TabStop = false;
            this.gbPretraga.Text = "        Pretraga";
            // 
            // duPretraga
            // 
            this.duPretraga.BackColor = System.Drawing.Color.Beige;
            this.duPretraga.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.duPretraga.Image = ((System.Drawing.Image)(resources.GetObject("duPretraga.Image")));
            this.duPretraga.Location = new System.Drawing.Point(540, 40);
            this.duPretraga.Name = "duPretraga";
            this.duPretraga.Size = new System.Drawing.Size(44, 44);
            this.duPretraga.TabIndex = 9;
            this.duPretraga.UseVisualStyleBackColor = false;
            this.duPretraga.Click += new System.EventHandler(this.duPretraga_Click);
            // 
            // cbPolje1
            // 
            this.cbPolje1.Items.AddRange(new object[] {
            "Ime",
            "Prezime",
            "Adresa",
            "Telefon",
            "Email"});
            this.cbPolje1.Location = new System.Drawing.Point(124, 72);
            this.cbPolje1.Name = "cbPolje1";
            this.cbPolje1.Size = new System.Drawing.Size(136, 24);
            this.cbPolje1.TabIndex = 6;
            this.cbPolje1.Text = "Prezime";
            this.cbPolje1.SelectedValueChanged += new System.EventHandler(this.cbPolje1_SelectedValueChanged);
            // 
            // tbVrijednost1
            // 
            this.tbVrijednost1.Location = new System.Drawing.Point(399, 72);
            this.tbVrijednost1.Name = "tbVrijednost1";
            this.tbVrijednost1.Size = new System.Drawing.Size(128, 22);
            this.tbVrijednost1.TabIndex = 8;
            this.tbVrijednost1.TextChanged += new System.EventHandler(this.tbVrijednost1_TextChanged);
            // 
            // lbVrijednost2
            // 
            this.lbVrijednost2.Location = new System.Drawing.Point(275, 75);
            this.lbVrijednost2.Name = "lbVrijednost2";
            this.lbVrijednost2.Size = new System.Drawing.Size(114, 24);
            this.lbVrijednost2.TabIndex = 7;
            this.lbVrijednost2.Text = "Prezime:";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(8, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 32);
            this.label2.TabIndex = 5;
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
            "Ime",
            "Prezime",
            "Adresa",
            "Telefon",
            "Email"});
            this.cbPolje.Location = new System.Drawing.Point(124, 32);
            this.cbPolje.Name = "cbPolje";
            this.cbPolje.Size = new System.Drawing.Size(136, 24);
            this.cbPolje.TabIndex = 0;
            this.cbPolje.Text = "Ime";
            this.cbPolje.SelectedValueChanged += new System.EventHandler(this.cbPolje_SelectedValueChanged);
            // 
            // tbVrijednost
            // 
            this.tbVrijednost.Location = new System.Drawing.Point(399, 32);
            this.tbVrijednost.Name = "tbVrijednost";
            this.tbVrijednost.Size = new System.Drawing.Size(128, 22);
            this.tbVrijednost.TabIndex = 1;
            this.tbVrijednost.TextChanged += new System.EventHandler(this.tbVrijednost_TextChanged);
            // 
            // lbVrijednost1
            // 
            this.lbVrijednost1.Location = new System.Drawing.Point(275, 33);
            this.lbVrijednost1.Name = "lbVrijednost1";
            this.lbVrijednost1.Size = new System.Drawing.Size(114, 24);
            this.lbVrijednost1.TabIndex = 1;
            this.lbVrijednost1.Text = "Ime:";
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
            this.gbOpcije.Controls.Add(this.duOdaberiDnevnik);
            this.gbOpcije.Controls.Add(this.duOdaberi);
            this.gbOpcije.Controls.Add(this.duZatvori);
            this.gbOpcije.Controls.Add(this.duIzbrisi);
            this.gbOpcije.Controls.Add(this.duOsvjezi);
            this.gbOpcije.Controls.Add(this.duIzmjeni);
            this.gbOpcije.Controls.Add(this.duNovi);
            this.gbOpcije.Location = new System.Drawing.Point(615, 40);
            this.gbOpcije.Name = "gbOpcije";
            this.gbOpcije.Size = new System.Drawing.Size(136, 280);
            this.gbOpcije.TabIndex = 2;
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
            this.duOdstampaj.TabIndex = 7;
            this.duOdstampaj.Text = "         Odštampaj";
            this.duOdstampaj.UseVisualStyleBackColor = false;
            this.duOdstampaj.Click += new System.EventHandler(this.duOdstampaj_Click);
            // 
            // duOdaberiDnevnik
            // 
            this.duOdaberiDnevnik.BackColor = System.Drawing.Color.Beige;
            this.duOdaberiDnevnik.Cursor = System.Windows.Forms.Cursors.Hand;
            this.duOdaberiDnevnik.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.duOdaberiDnevnik.Image = ((System.Drawing.Image)(resources.GetObject("duOdaberiDnevnik.Image")));
            this.duOdaberiDnevnik.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.duOdaberiDnevnik.Location = new System.Drawing.Point(12, 192);
            this.duOdaberiDnevnik.Name = "duOdaberiDnevnik";
            this.duOdaberiDnevnik.Size = new System.Drawing.Size(112, 32);
            this.duOdaberiDnevnik.TabIndex = 6;
            this.duOdaberiDnevnik.Text = "   Odaberi";
            this.duOdaberiDnevnik.UseVisualStyleBackColor = false;
            this.duOdaberiDnevnik.Click += new System.EventHandler(this.duOdaberiDnevnik_Click);
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
            this.duOdaberi.Click += new System.EventHandler(this.duOdaberi_Click);
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
            // daInstruktori
            // 
            this.daInstruktori.SelectCommand = this.sqlSelectCommand1;
            this.daInstruktori.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Instruktori", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("ID", "ID"),
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
            this.sqlSelectCommand1.CommandText = "SELECT InstruktorID AS ID, Ime, Prezime, DatumRodjenja, Adresa, Telefon, Email, D" +
                "atumZaposlenja FROM Instruktori ORDER BY InstruktorID";
            // 
            // connInstruktori
            // 
            this.connInstruktori.ConnectionString = "Data Source=(local);Initial Catalog=baza;integrated security=SSPI";
            this.connInstruktori.FireInfoMessageEventOnUserErrors = false;
            // 
            // dsInstruktori1
            // 
            this.dsInstruktori1.DataSetName = "dsInstruktori";
            this.dsInstruktori1.Locale = new System.Globalization.CultureInfo("hr-HR");
            this.dsInstruktori1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dgInstruktori
            // 
            this.dgInstruktori.DataMember = "";
            this.dgInstruktori.DataSource = this.dsInstruktori1.Instruktori;
            this.dgInstruktori.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dgInstruktori.Location = new System.Drawing.Point(8, 48);
            this.dgInstruktori.Name = "dgInstruktori";
            this.dgInstruktori.ReadOnly = true;
            this.dgInstruktori.Size = new System.Drawing.Size(599, 304);
            this.dgInstruktori.TabIndex = 4;
            this.dgInstruktori.TableStyles.AddRange(new System.Windows.Forms.DataGridTableStyle[] {
            this.dgTableStyleInstruktori});
            this.dgInstruktori.DoubleClick += new System.EventHandler(this.dgInstruktori_DoubleClick);
            // 
            // dgTableStyleInstruktori
            // 
            this.dgTableStyleInstruktori.DataGrid = this.dgInstruktori;
            this.dgTableStyleInstruktori.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {
            this.ID,
            this.Ime,
            this.Prezime,
            this.DatumRodjenja,
            this.Adresa,
            this.Telefon,
            this.Email,
            this.DatumZaposlenja,
            this.Testovi});
            this.dgTableStyleInstruktori.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dgTableStyleInstruktori.MappingName = "Instruktori";
            this.dgTableStyleInstruktori.PreferredRowHeight = 22;
            // 
            // ID
            // 
            this.ID.Format = "";
            this.ID.FormatInfo = null;
            this.ID.HeaderText = "ID";
            this.ID.MappingName = "ID";
            this.ID.Width = 0;
            // 
            // Ime
            // 
            this.Ime.Format = "";
            this.Ime.FormatInfo = null;
            this.Ime.HeaderText = "Ime";
            this.Ime.MappingName = "Ime";
            this.Ime.Width = 75;
            // 
            // Prezime
            // 
            this.Prezime.Format = "";
            this.Prezime.FormatInfo = null;
            this.Prezime.HeaderText = "Prezime";
            this.Prezime.MappingName = "Prezime";
            this.Prezime.Width = 75;
            // 
            // DatumRodjenja
            // 
            this.DatumRodjenja.Format = "";
            this.DatumRodjenja.FormatInfo = null;
            this.DatumRodjenja.HeaderText = "Datum Rodjenja";
            this.DatumRodjenja.MappingName = "DatumRodjenja";
            this.DatumRodjenja.Width = 105;
            // 
            // Adresa
            // 
            this.Adresa.Format = "";
            this.Adresa.FormatInfo = null;
            this.Adresa.HeaderText = "Adresa";
            this.Adresa.MappingName = "Adresa";
            this.Adresa.Width = 95;
            // 
            // Telefon
            // 
            this.Telefon.Format = "";
            this.Telefon.FormatInfo = null;
            this.Telefon.HeaderText = "Telefon";
            this.Telefon.MappingName = "Telefon";
            this.Telefon.Width = 85;
            // 
            // Email
            // 
            this.Email.Format = "";
            this.Email.FormatInfo = null;
            this.Email.HeaderText = "Email";
            this.Email.MappingName = "Email";
            this.Email.Width = 105;
            // 
            // DatumZaposlenja
            // 
            this.DatumZaposlenja.Format = "";
            this.DatumZaposlenja.FormatInfo = null;
            this.DatumZaposlenja.HeaderText = "Datum Zaposlenja";
            this.DatumZaposlenja.MappingName = "DatumZaposlenja";
            this.DatumZaposlenja.Width = 115;
            // 
            // Testovi
            // 
            this.Testovi.HeaderText = "Testovi";
            this.Testovi.MappingName = "Testovi";
            this.Testovi.Width = 75;
            // 
            // pictureBoxInst
            // 
            this.pictureBoxInst.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxInst.Image")));
            this.pictureBoxInst.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxInst.Name = "pictureBoxInst";
            this.pictureBoxInst.Size = new System.Drawing.Size(774, 32);
            this.pictureBoxInst.TabIndex = 5;
            this.pictureBoxInst.TabStop = false;
            // 
            // frmInstruktori
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 15);
            this.ClientSize = new System.Drawing.Size(763, 480);
            this.Controls.Add(this.pictureBoxInst);
            this.Controls.Add(this.dgInstruktori);
            this.Controls.Add(this.gbPretraga);
            this.Controls.Add(this.gbOpcije);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(771, 520);
            this.Name = "frmInstruktori";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Instruktori";
            this.Load += new System.EventHandler(this.frmInstruktori_Load);
            this.gbPretraga.ResumeLayout(false);
            this.gbPretraga.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbOpcije.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dsInstruktori1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgInstruktori)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInst)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		public void uzmiBroj(int b)
		{
			broj = b;
		}
		
		private void duNovi_Click(object sender, System.EventArgs e)
		{
			clsInstruktori instruktor = new clsInstruktori();
			frmInstruktoriUnos dodaj = new frmInstruktoriUnos();
			dodaj.uzmiPodatke(instruktor,1);
			//dodaj.ShowDialog();
            if (dodaj.ShowDialog() == DialogResult.OK)
            {
                duOsvjezi_Click(sender, e);
            }
		}

		private void tbVrijednost_TextChanged(object sender, System.EventArgs e)
		{
			if (this.tbVrijednost.Text=="" && this.tbVrijednost1.Text=="")
			{
                duOsvjezi_Click(sender, e);                
			}			
		}

		private void duIzmjeni_Click(object sender, System.EventArgs e)
		{
			if(this.dsInstruktori1.Instruktori.Rows.Count>0)
			{
				//Odabir trenutno oznacene celije
				DataGridCell celija = this.dgInstruktori.CurrentCell;
				//Odabir podataka iz trenutne celije na pozicijama kolona od 0 i 7 
				object I0=this.dgInstruktori[celija.RowNumber, 0];
				object I1=this.dgInstruktori[celija.RowNumber, 1];
				object I2=this.dgInstruktori[celija.RowNumber, 2];
				object I3=this.dgInstruktori[celija.RowNumber, 3];
				object I4=this.dgInstruktori[celija.RowNumber, 4];
				object I5=this.dgInstruktori[celija.RowNumber, 5];
				object I6=this.dgInstruktori[celija.RowNumber, 6];
				object I7=this.dgInstruktori[celija.RowNumber, 7];
								
				//Kreiranje novog objekta klase clsInstruktori
				clsInstruktori instruktor = new clsInstruktori();
				
				//Konvertovanje objekata I0 do I7 u stringove i 
				//proslijedivanje u varijable iz clsVarijable
				instruktor.InstruktorID = Convert.ToString(I0);
				instruktor.Ime = Convert.ToString(I1);
				instruktor.Prezime = Convert.ToString(I2);
				instruktor.DatumRodjenja = Convert.ToString(I3);
				instruktor.Adresa = Convert.ToString(I4);
				instruktor.Telefon = Convert.ToString(I5);
				instruktor.Email = Convert.ToString(I6);
				instruktor.DatumZaposlenja = Convert.ToString(I7);
				
				//Kreiranje objekta izmjeni klase frmInstruktoriUnos
				frmInstruktoriUnos izmjeni = new frmInstruktoriUnos();
				//Poziv funkcije uzmiPodatke za objekat izmjeni
				izmjeni.uzmiPodatke(instruktor,2);
				//Otvaranje forme forInstruktoriDodaj
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

		private void duIzbrisi_Click(object sender, System.EventArgs e)
		{
			
			//Ako data set dsInstruktori nije prazan
			if(this.dsInstruktori1.Instruktori.Rows.Count>0)
			{
				//Odabir trenutno oznacene celije
				DataGridCell selectedCell = dgInstruktori.CurrentCell;
				//Odabir podataka iz trenutne celije na poziciji kolona 1 i 2 
				object o1 = dgInstruktori[selectedCell.RowNumber, 1];
				object o2 = dgInstruktori[selectedCell.RowNumber, 2];
				
				//Konvertovanje objekata o1 i o2 u stringove
				string Ime = Convert.ToString(o1);
				string Prezime = Convert.ToString(o2);
				
				//Prikaz dijalog boksa sa pitanjem, ako je rezultat opcija Yes
				//Onda izbriši odabrani zapis
				if(MessageBox.Show("Da li ste sigurni da želite izbrisati podatke o instruktoru: \nIme: "+Ime+" \nPrezime: "+Prezime+"","Upozorenje !",MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes)
				{
					System.Windows.Forms.DataGridCell celija = this.dgInstruktori.CurrentCell;
					object B0=this.dgInstruktori[celija.RowNumber, 0];
					string InstruktorID1 = Convert.ToString(B0);

					try
					{

						//this.connInstruktori.Open();
						SqlCommand kom = new SqlCommand("DELETE FROM Instruktori WHERE InstruktorID = "+InstruktorID1+"", clsKonekcija.GetConnection());
						kom.ExecuteNonQuery();
						//this.connInstruktori.Close();

						this.dsInstruktori1.Clear();
						this.daInstruktori.Fill(this.dsInstruktori1);
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

		private void duOdaberi_Click(object sender, System.EventArgs e)
		{
			DataGridCell celija = this.dgInstruktori.CurrentCell;
			
			object I0=this.dgInstruktori[celija.RowNumber, 0];
			object I1=this.dgInstruktori[celija.RowNumber, 1];
			object I2=this.dgInstruktori[celija.RowNumber, 2];
			
			string S0 = Convert.ToString(I0);
			string S1 = Convert.ToString(I1);
			string S2 = Convert.ToString(I2);
				
			p.UnesiInstruktora(S0, S1, S2);

			this.Close();
		}

		private void duZatvori_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void duOsvjezi_Click(object sender, System.EventArgs e)
		{
			this.dsInstruktori1.Clear();
			this.daInstruktori.Fill(this.dsInstruktori1);
			
		}

		private void frmInstruktori_Load(object sender, System.EventArgs e)
		{
			if (this.broj == 1)
			{
				this.duOdaberi.Location = new System.Drawing.Point(12, 32);
				this.duZatvori.Location = new System.Drawing.Point(12, 72);
				this.duOsvjezi.Location = new System.Drawing.Point(12, 120);
				this.gbOpcije.Size = new Size(136, 120);								
			}

			if (this.broj == 2)
			{
				this.duOdaberiDnevnik.Location = new System.Drawing.Point(12, 32);
				this.duZatvori.Location = new System.Drawing.Point(12, 72);
				this.duOsvjezi.Location = new System.Drawing.Point(12, 120);
				this.gbOpcije.Size = new Size(136, 120);								
			}

			this.dsInstruktori1.Clear();
			this.sqlSelectCommand1.Connection = clsKonekcija.GetConnection();
			this.daInstruktori.Fill(this.dsInstruktori1);
									
		}

		private void duOdaberiDnevnik_Click(object sender, System.EventArgs e)
		{
			DataGridCell celija = this.dgInstruktori.CurrentCell;
			
			object I0=this.dgInstruktori[celija.RowNumber, 0];
			object I1=this.dgInstruktori[celija.RowNumber, 1];
			object I2=this.dgInstruktori[celija.RowNumber, 2];
			
			string S0 = Convert.ToString(I0);
			string S1 = Convert.ToString(I1);
			string S2 = Convert.ToString(I2);
				
			d.UnesiInstruktora(S0, S1, S2);

			this.Close();
		}

		private void duOdstampaj_Click(object sender, System.EventArgs e)
		{
			frmIzvInstruktori i = new frmIzvInstruktori();
			i.ShowDialog();
		}

		private void duPretraga_Click(object sender, System.EventArgs e)
		{
			if (this.tbVrijednost.Text=="" && this.tbVrijednost1.Text=="")
			{
				MessageBox.Show("Niste unijeli vrijednost za pretragu!","Upozorenje",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
				this.dsInstruktori1.Clear();
				this.daInstruktori.Fill(this.dsInstruktori1);
			}
			else
			{
				string pretraga= "SELECT InstruktorID AS ID, Ime, Prezime, DatumRodjenja, Adresa, Telefon, Email, DatumZaposlenja FROM Instruktori WHERE("+cbPolje.SelectedItem+")LIKE('" + tbVrijednost.Text + "%') AND ("+cbPolje1.SelectedItem+")LIKE('" + tbVrijednost1.Text + "%') ORDER BY InstruktorID";

				try
				{
					//OVAKO "SELECT * FROM Instruktori WHERE("+cbPolje.SelectedItem+")LIKE('" + tbVrijednost.Text + "%') ORDER BY InstruktorID;" INNER JOIN 
					SqlDataAdapter cmdAdapter = new SqlDataAdapter();
					cmdAdapter.SelectCommand =new SqlCommand(pretraga, clsKonekcija.GetConnection());
					cmdAdapter.SelectCommand.CommandType = CommandType.Text;

					//this.connInstruktori.Open();
					this.dsInstruktori1.Clear();
					cmdAdapter.Fill(this.dsInstruktori1,"Instruktori");
					//this.connInstruktori.Close();
					

				}
				catch(Exception ex)
				{
					string iz=ex.Message.ToString();
					MessageBox.Show("Pogreška: "+iz+"","Upozorenje !",MessageBoxButtons.OK,MessageBoxIcon.Information);
				}

			}
		}

		private void dgInstruktori_DoubleClick(object sender, System.EventArgs e)
		{
            duIzmjeni_Click(sender, e);            
		}

        private void cbPolje_SelectedValueChanged(object sender, EventArgs e)
        {
            this.lbVrijednost1.Text = this.cbPolje.Text + ":";
        }

        private void cbPolje1_SelectedValueChanged(object sender, EventArgs e)
        {
            this.lbVrijednost2.Text = this.cbPolje1.Text + ":";
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
