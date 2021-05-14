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
	/// Summary description for DnevnikObuke.
	/// </summary>
	public class frmDnevnikObuke : System.Windows.Forms.Form
	{
		private System.Windows.Forms.PictureBox pictureBoxInst;
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
		private System.Windows.Forms.DataGrid dgDnevnikObuke;
		private System.Data.SqlClient.SqlConnection connDnevnikObuke;
		private System.Data.SqlClient.SqlDataAdapter daDnevnikObuke;
		private AutoSkola.DSetovi.dsDnevnikObuke dsDnevnikObuke1;
		private System.Windows.Forms.DataGridTableStyle dgTableStyleDnevnik;
		private System.Windows.Forms.DataGridTextBoxColumn CasID;
		private System.Windows.Forms.DataGridTextBoxColumn KandidatID;
		private System.Windows.Forms.DataGridTextBoxColumn Ime;
		private System.Windows.Forms.DataGridTextBoxColumn Prezime;
		private System.Windows.Forms.DataGridTextBoxColumn KatID;
		private System.Windows.Forms.DataGridTextBoxColumn Kategorija;
		private System.Windows.Forms.DataGridTextBoxColumn DatumObuke;
		private System.Windows.Forms.DataGridTextBoxColumn MetodskaJedinica;
		private System.Windows.Forms.DataGridTextBoxColumn MjestoObuke;
		private System.Windows.Forms.DataGridTextBoxColumn VrijemeOd;
		private System.Windows.Forms.DataGridTextBoxColumn VrijemeDo;
		private System.Windows.Forms.DataGridTextBoxColumn VoziloID;
		private System.Windows.Forms.DataGridTextBoxColumn Model;
		private System.Windows.Forms.DataGridTextBoxColumn InstruktorID;
		private System.Windows.Forms.DataGridTextBoxColumn ImeInst;
		private System.Windows.Forms.DataGridTextBoxColumn PrezimeInst;
		private System.Windows.Forms.Button duOdstampaj;
		private System.Windows.Forms.Button duPretraga;
		private System.Windows.Forms.ComboBox cbPolje1;
		private System.Windows.Forms.TextBox tbVrijednost1;
		private System.Windows.Forms.Label lbVrijednost1;
		private System.Windows.Forms.Label label2;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmDnevnikObuke()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
						
			this.sqlSelectCommand1.Connection = clsKonekcija.GetConnection();
			
			this.daDnevnikObuke.Fill(this.dsDnevnikObuke1);

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		private static frmDnevnikObuke dnevnik = null;
		public static frmDnevnikObuke Instance()
		{
			if (dnevnik == null) { dnevnik = new frmDnevnikObuke(); }

			return dnevnik;
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

			dnevnik = null;
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDnevnikObuke));
            this.pictureBoxInst = new System.Windows.Forms.PictureBox();
            this.dgDnevnikObuke = new System.Windows.Forms.DataGrid();
            this.dsDnevnikObuke1 = new AutoSkola.DSetovi.dsDnevnikObuke();
            this.dgTableStyleDnevnik = new System.Windows.Forms.DataGridTableStyle();
            this.CasID = new System.Windows.Forms.DataGridTextBoxColumn();
            this.KandidatID = new System.Windows.Forms.DataGridTextBoxColumn();
            this.Ime = new System.Windows.Forms.DataGridTextBoxColumn();
            this.Prezime = new System.Windows.Forms.DataGridTextBoxColumn();
            this.KatID = new System.Windows.Forms.DataGridTextBoxColumn();
            this.Kategorija = new System.Windows.Forms.DataGridTextBoxColumn();
            this.DatumObuke = new System.Windows.Forms.DataGridTextBoxColumn();
            this.MetodskaJedinica = new System.Windows.Forms.DataGridTextBoxColumn();
            this.MjestoObuke = new System.Windows.Forms.DataGridTextBoxColumn();
            this.VrijemeOd = new System.Windows.Forms.DataGridTextBoxColumn();
            this.VrijemeDo = new System.Windows.Forms.DataGridTextBoxColumn();
            this.VoziloID = new System.Windows.Forms.DataGridTextBoxColumn();
            this.Model = new System.Windows.Forms.DataGridTextBoxColumn();
            this.InstruktorID = new System.Windows.Forms.DataGridTextBoxColumn();
            this.ImeInst = new System.Windows.Forms.DataGridTextBoxColumn();
            this.PrezimeInst = new System.Windows.Forms.DataGridTextBoxColumn();
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
            this.connDnevnikObuke = new System.Data.SqlClient.SqlConnection();
            this.daDnevnikObuke = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInst)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgDnevnikObuke)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDnevnikObuke1)).BeginInit();
            this.gbPretraga.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbOpcije.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxInst
            // 
            this.pictureBoxInst.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxInst.Image")));
            this.pictureBoxInst.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxInst.Name = "pictureBoxInst";
            this.pictureBoxInst.Size = new System.Drawing.Size(784, 32);
            this.pictureBoxInst.TabIndex = 11;
            this.pictureBoxInst.TabStop = false;
            // 
            // dgDnevnikObuke
            // 
            this.dgDnevnikObuke.DataMember = "";
            this.dgDnevnikObuke.DataSource = this.dsDnevnikObuke1.DnevnikObuke;
            this.dgDnevnikObuke.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dgDnevnikObuke.Location = new System.Drawing.Point(8, 48);
            this.dgDnevnikObuke.Name = "dgDnevnikObuke";
            this.dgDnevnikObuke.PreferredColumnWidth = 80;
            this.dgDnevnikObuke.ReadOnly = true;
            this.dgDnevnikObuke.Size = new System.Drawing.Size(611, 304);
            this.dgDnevnikObuke.TabIndex = 10;
            this.dgDnevnikObuke.TableStyles.AddRange(new System.Windows.Forms.DataGridTableStyle[] {
            this.dgTableStyleDnevnik});
            this.dgDnevnikObuke.DoubleClick += new System.EventHandler(this.dgDnevnikObuke_DoubleClick);
            // 
            // dsDnevnikObuke1
            // 
            this.dsDnevnikObuke1.DataSetName = "dsDnevnikObuke";
            this.dsDnevnikObuke1.Locale = new System.Globalization.CultureInfo("hr-HR");
            this.dsDnevnikObuke1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dgTableStyleDnevnik
            // 
            this.dgTableStyleDnevnik.DataGrid = this.dgDnevnikObuke;
            this.dgTableStyleDnevnik.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {
            this.CasID,
            this.KandidatID,
            this.Ime,
            this.Prezime,
            this.KatID,
            this.Kategorija,
            this.DatumObuke,
            this.MetodskaJedinica,
            this.MjestoObuke,
            this.VrijemeOd,
            this.VrijemeDo,
            this.VoziloID,
            this.Model,
            this.InstruktorID,
            this.ImeInst,
            this.PrezimeInst});
            this.dgTableStyleDnevnik.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dgTableStyleDnevnik.MappingName = "DnevnikObuke";
            this.dgTableStyleDnevnik.PreferredRowHeight = 22;
            // 
            // CasID
            // 
            this.CasID.Format = "";
            this.CasID.FormatInfo = null;
            this.CasID.HeaderText = "ID";
            this.CasID.MappingName = "CasID";
            this.CasID.Width = 0;
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
            this.Kategorija.Width = 70;
            // 
            // DatumObuke
            // 
            this.DatumObuke.Format = "";
            this.DatumObuke.FormatInfo = null;
            this.DatumObuke.HeaderText = "Datum Obuke";
            this.DatumObuke.MappingName = "DatumObuke";
            this.DatumObuke.Width = 95;
            // 
            // MetodskaJedinica
            // 
            this.MetodskaJedinica.Format = "";
            this.MetodskaJedinica.FormatInfo = null;
            this.MetodskaJedinica.HeaderText = "Metodska Jedinica";
            this.MetodskaJedinica.MappingName = "MetodskaJedinica";
            this.MetodskaJedinica.Width = 130;
            // 
            // MjestoObuke
            // 
            this.MjestoObuke.Format = "";
            this.MjestoObuke.FormatInfo = null;
            this.MjestoObuke.HeaderText = "Mjesto Obuke";
            this.MjestoObuke.MappingName = "MjestoObuke";
            this.MjestoObuke.Width = 95;
            // 
            // VrijemeOd
            // 
            this.VrijemeOd.Format = "";
            this.VrijemeOd.FormatInfo = null;
            this.VrijemeOd.HeaderText = "Vrijeme Od";
            this.VrijemeOd.MappingName = "VrijemeOd";
            this.VrijemeOd.Width = 75;
            // 
            // VrijemeDo
            // 
            this.VrijemeDo.Format = "";
            this.VrijemeDo.FormatInfo = null;
            this.VrijemeDo.HeaderText = "Vrijeme Do";
            this.VrijemeDo.MappingName = "VrijemeDo";
            this.VrijemeDo.Width = 75;
            // 
            // VoziloID
            // 
            this.VoziloID.Format = "";
            this.VoziloID.FormatInfo = null;
            this.VoziloID.HeaderText = "VoziloID";
            this.VoziloID.MappingName = "VoziloID";
            this.VoziloID.Width = 0;
            // 
            // Model
            // 
            this.Model.Format = "";
            this.Model.FormatInfo = null;
            this.Model.HeaderText = "Vozilo";
            this.Model.MappingName = "Model";
            this.Model.Width = 75;
            // 
            // InstruktorID
            // 
            this.InstruktorID.Format = "";
            this.InstruktorID.FormatInfo = null;
            this.InstruktorID.HeaderText = "InstruktorID";
            this.InstruktorID.MappingName = "InstruktorID";
            this.InstruktorID.Width = 0;
            // 
            // ImeInst
            // 
            this.ImeInst.Format = "";
            this.ImeInst.FormatInfo = null;
            this.ImeInst.HeaderText = "Instruktor";
            this.ImeInst.MappingName = "ImeInst";
            this.ImeInst.Width = 75;
            // 
            // PrezimeInst
            // 
            this.PrezimeInst.Format = "";
            this.PrezimeInst.FormatInfo = null;
            this.PrezimeInst.MappingName = "PrezimeInst";
            this.PrezimeInst.Width = 75;
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
            this.gbPretraga.Location = new System.Drawing.Point(9, 363);
            this.gbPretraga.Name = "gbPretraga";
            this.gbPretraga.Size = new System.Drawing.Size(610, 109);
            this.gbPretraga.TabIndex = 9;
            this.gbPretraga.TabStop = false;
            this.gbPretraga.Text = "        Pretraga";
            // 
            // duPretraga
            // 
            this.duPretraga.BackColor = System.Drawing.Color.Beige;
            this.duPretraga.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.duPretraga.Image = ((System.Drawing.Image)(resources.GetObject("duPretraga.Image")));
            this.duPretraga.Location = new System.Drawing.Point(549, 32);
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
            "Kategorija",
            "MetodskaJedinica",
            "MjestoObuke",
            "VrijemeOd",
            "VrijemeDo",
            "I.Ime",
            "I.Prezime"});
            this.cbPolje1.Location = new System.Drawing.Point(128, 66);
            this.cbPolje1.Name = "cbPolje1";
            this.cbPolje1.Size = new System.Drawing.Size(128, 24);
            this.cbPolje1.TabIndex = 11;
            this.cbPolje1.Text = "K.Prezime";
            this.cbPolje1.SelectedValueChanged += new System.EventHandler(this.cbPolje1_SelectedValueChanged);
            // 
            // tbVrijednost1
            // 
            this.tbVrijednost1.Location = new System.Drawing.Point(405, 66);
            this.tbVrijednost1.Name = "tbVrijednost1";
            this.tbVrijednost1.Size = new System.Drawing.Size(128, 22);
            this.tbVrijednost1.TabIndex = 13;
            this.tbVrijednost1.TextChanged += new System.EventHandler(this.tbVrijednost1_TextChanged);
            // 
            // lbVrijednost1
            // 
            this.lbVrijednost1.Location = new System.Drawing.Point(267, 66);
            this.lbVrijednost1.Name = "lbVrijednost1";
            this.lbVrijednost1.Size = new System.Drawing.Size(131, 21);
            this.lbVrijednost1.TabIndex = 12;
            this.lbVrijednost1.Text = "Prezime Kandidata:";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(8, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 32);
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
            "Kategorija",
            "MetodskaJedinica",
            "MjestoObuke",
            "VrijemeOd",
            "VrijemeDo",
            "I.Ime",
            "I.Prezime"});
            this.cbPolje.Location = new System.Drawing.Point(128, 32);
            this.cbPolje.Name = "cbPolje";
            this.cbPolje.Size = new System.Drawing.Size(128, 24);
            this.cbPolje.TabIndex = 0;
            this.cbPolje.Text = "K.Ime";
            this.cbPolje.SelectedValueChanged += new System.EventHandler(this.cbPolje_SelectedValueChanged);
            // 
            // tbVrijednost
            // 
            this.tbVrijednost.Location = new System.Drawing.Point(405, 32);
            this.tbVrijednost.Name = "tbVrijednost";
            this.tbVrijednost.Size = new System.Drawing.Size(128, 22);
            this.tbVrijednost.TabIndex = 1;
            this.tbVrijednost.TextChanged += new System.EventHandler(this.tbVrijednost_TextChanged);
            // 
            // lbVrijednost
            // 
            this.lbVrijednost.Location = new System.Drawing.Point(267, 32);
            this.lbVrijednost.Name = "lbVrijednost";
            this.lbVrijednost.Size = new System.Drawing.Size(126, 21);
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
            this.gbOpcije.Location = new System.Drawing.Point(633, 42);
            this.gbOpcije.Name = "gbOpcije";
            this.gbOpcije.Size = new System.Drawing.Size(136, 280);
            this.gbOpcije.TabIndex = 8;
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
            this.duOdstampaj.Text = "       Odštampaj";
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
            // connDnevnikObuke
            // 
            this.connDnevnikObuke.ConnectionString = "workstation id=\"ADNAN-WUCFPZFI4\";packet size=4096;integrated security=SSPI;initia" +
                "l catalog=baza;persist security info=False";
            this.connDnevnikObuke.FireInfoMessageEventOnUserErrors = false;
            // 
            // daDnevnikObuke
            // 
            this.daDnevnikObuke.SelectCommand = this.sqlSelectCommand1;
            this.daDnevnikObuke.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "DnevnikObuke", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("CasID", "CasID"),
                        new System.Data.Common.DataColumnMapping("KandidatID", "KandidatID"),
                        new System.Data.Common.DataColumnMapping("Ime", "Ime"),
                        new System.Data.Common.DataColumnMapping("Prezime", "Prezime"),
                        new System.Data.Common.DataColumnMapping("KatID", "KatID"),
                        new System.Data.Common.DataColumnMapping("Kategorija", "Kategorija"),
                        new System.Data.Common.DataColumnMapping("DatumObuke", "DatumObuke"),
                        new System.Data.Common.DataColumnMapping("MetodskaJedinica", "MetodskaJedinica"),
                        new System.Data.Common.DataColumnMapping("MjestoObuke", "MjestoObuke"),
                        new System.Data.Common.DataColumnMapping("VrijemeOd", "VrijemeOd"),
                        new System.Data.Common.DataColumnMapping("VrijemeDo", "VrijemeDo"),
                        new System.Data.Common.DataColumnMapping("VoziloID", "VoziloID"),
                        new System.Data.Common.DataColumnMapping("Model", "Model"),
                        new System.Data.Common.DataColumnMapping("InstruktorID", "InstruktorID"),
                        new System.Data.Common.DataColumnMapping("ImeInst", "ImeInst"),
                        new System.Data.Common.DataColumnMapping("PrezimeInst", "PrezimeInst")})});
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = resources.GetString("sqlSelectCommand1.CommandText");
            // 
            // frmDnevnikObuke
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 15);
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(783, 480);
            this.Controls.Add(this.pictureBoxInst);
            this.Controls.Add(this.dgDnevnikObuke);
            this.Controls.Add(this.gbPretraga);
            this.Controls.Add(this.gbOpcije);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(791, 520);
            this.Name = "frmDnevnikObuke";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dnevnik obuke";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInst)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgDnevnikObuke)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDnevnikObuke1)).EndInit();
            this.gbPretraga.ResumeLayout(false);
            this.gbPretraga.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbOpcije.ResumeLayout(false);
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
			clsDnevnikObuke dnevnik = new clsDnevnikObuke();
			frmDnevnikUnos dodaj = new frmDnevnikUnos();
			dodaj.uzmiPodatke(dnevnik,1);
			//dodaj.ShowDialog();

            if (dodaj.ShowDialog() == DialogResult.OK)
            {
                duOsvjezi_Click(sender, e);
            }
		}

		private void duIzmjeni_Click(object sender, System.EventArgs e)
		{
			if(this.dsDnevnikObuke1.DnevnikObuke.Rows.Count>0)
			{
				//Odabir trenutno oznacene celije
				DataGridCell celija = this.dgDnevnikObuke.CurrentCell;
				//Odabir podataka iz trenutne celije na pozicijama kolona od 0 i 7 
				object I0=this.dgDnevnikObuke[celija.RowNumber, 0];
				object I1=this.dgDnevnikObuke[celija.RowNumber, 1];
				object I2=this.dgDnevnikObuke[celija.RowNumber, 2];
				object I3=this.dgDnevnikObuke[celija.RowNumber, 3];
				object I4=this.dgDnevnikObuke[celija.RowNumber, 4];
				object I5=this.dgDnevnikObuke[celija.RowNumber, 5];
				object I6=this.dgDnevnikObuke[celija.RowNumber, 6];
				object I7=this.dgDnevnikObuke[celija.RowNumber, 7];
				object I8=this.dgDnevnikObuke[celija.RowNumber, 8];
				object I9=this.dgDnevnikObuke[celija.RowNumber, 9];
				object I10=this.dgDnevnikObuke[celija.RowNumber, 10];
				object I11=this.dgDnevnikObuke[celija.RowNumber, 11];
				object I12=this.dgDnevnikObuke[celija.RowNumber, 12];
				object I13=this.dgDnevnikObuke[celija.RowNumber, 13];
				object I14=this.dgDnevnikObuke[celija.RowNumber, 14];
				object I15=this.dgDnevnikObuke[celija.RowNumber, 15];


				
				//Kreiranje novog objekta klase clsDnevnikObuke
				clsDnevnikObuke dnevnik = new clsDnevnikObuke();
				
				//Konvertovanje objekata I0 do I7 u stringove i 
				//proslijedivanje u varijable iz clsVarijable
				dnevnik.CasID = Convert.ToString(I0);
				dnevnik.KandidatID = Convert.ToString(I1);
				dnevnik.KandidatIme = Convert.ToString(I2);
				dnevnik.KandidatPrezime = Convert.ToString(I3);				
				dnevnik.KategorijaID = Convert.ToString(I4);
				dnevnik.Kategorija = Convert.ToString(I5);	
				dnevnik.DatumObuke = Convert.ToString(I6);
				dnevnik.MetodskaJedinica = Convert.ToString(I7);
				dnevnik.MjestoObuke = Convert.ToString(I8);
				dnevnik.VrijemeOd = Convert.ToString(I9);
				dnevnik.VrijemeDo = Convert.ToString(I10);
				dnevnik.VoziloID = Convert.ToString(I11);
				dnevnik.Model = Convert.ToString(I12);			
				dnevnik.InstruktorID = Convert.ToString(I13);
				dnevnik.InstruktorIme = Convert.ToString(I14);
				dnevnik.InstruktorPrezime = Convert.ToString(I15);
								
				//Kreiranje objekta izmjeni klase frmDnevnikUnos
				frmDnevnikUnos izmjeni = new frmDnevnikUnos();
				//Poziv funkcije uzmiPodatke za objekat izmjeni
				
				izmjeni.uzmiPodatke(dnevnik,2);
				//Otvaranje forme frmDnevnikUnos
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
			this.dsDnevnikObuke1.Clear();
			this.daDnevnikObuke.Fill(this.dsDnevnikObuke1);
					
		}

		private void duIzbrisi_Click(object sender, System.EventArgs e)
		{
			//Ako data set dsInstruktori nije prazan
			if(this.dsDnevnikObuke1.DnevnikObuke.Rows.Count>0)
			{
				//Odabir trenutno oznacene celije
				DataGridCell selectedCell = dgDnevnikObuke.CurrentCell;
				//Odabir podataka iz trenutne celije na poziciji kolona 1 i 2 
				object o1 = dgDnevnikObuke[selectedCell.RowNumber, 0];
				object o2 = dgDnevnikObuke[selectedCell.RowNumber, 2];
				object o3 = dgDnevnikObuke[selectedCell.RowNumber, 3];
				
				//Konvertovanje objekata o1 i o2 u stringove
				string CasID = Convert.ToString(o1);
				string Ime = Convert.ToString(o2);
				string Prezime = Convert.ToString(o3);
				
				//Prikaz dijalog boksa sa pitanjem, ako je rezultat opcija Yes
				//Onda izbriši odabrani zapis
				if(MessageBox.Show("Da li ste sigurni da želite izbrisati podatke \niz dnevnika obuke za kandidata: \nCas ID: "+CasID+" \nIme: "+Ime+" \nPrezime: "+Prezime+" ","Upozorenje !",MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes)
				{
					System.Windows.Forms.DataGridCell celija = this.dgDnevnikObuke.CurrentCell;
					object B0=this.dgDnevnikObuke[celija.RowNumber, 0];
					string DnevnikID=Convert.ToString(B0);

					try
					{

						//this.connDnevnikObuke.Open();
						SqlCommand kom = new SqlCommand("DELETE FROM DnevnikObuke WHERE CasID = "+DnevnikID+"", clsKonekcija.GetConnection());
						kom.ExecuteNonQuery();
						//this.connDnevnikObuke.Close();

						this.dsDnevnikObuke1.Clear();
						this.daDnevnikObuke.Fill(this.dsDnevnikObuke1);
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
			frmIzvDnevnikObuke i = new frmIzvDnevnikObuke();
			i.ShowDialog();
		}

		private void dgDnevnikObuke_DoubleClick(object sender, System.EventArgs e)
		{
            duIzmjeni_Click(sender, e);            
		}

		private void duPretraga_Click(object sender, System.EventArgs e)
		{
			if (this.tbVrijednost.Text=="" && this.tbVrijednost1.Text=="")
			{
				MessageBox.Show("Niste unijeli vrijednost za pretragu!","Upozorenje",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
				this.dsDnevnikObuke1.Clear();
				this.daDnevnikObuke.Fill(this.dsDnevnikObuke1);
			}
			else
			{
                string pretraga = "SELECT DO.CasID, K.KandidatID, K.Ime, K.Prezime, KAT.KategorijaID AS KatID, KAT.Kategorija, DO.DatumObuke, DO.MetodskaJedinica, DO.MjestoObuke, DO.VrijemeOd, DO.VrijemeDo, V.VoziloID, V.Model, I.InstruktorID, I.Ime AS ImeInst, I.Prezime AS PrezimeInst FROM DnevnikObuke DO INNER JOIN Kandidati K ON DO.KandidatID = K.KandidatID INNER JOIN Kategorije KAT ON DO.KategorijaID = KAT.KategorijaID INNER JOIN Vozila V ON DO.VoziloID = V.VoziloID INNER JOIN Instruktori I ON DO.InstruktorID = I.InstruktorID WHERE(" + cbPolje.SelectedItem + ")LIKE('" + tbVrijednost.Text + "%') AND (" + cbPolje1.SelectedItem + ")LIKE('" + tbVrijednost1.Text + "%') ORDER BY CasID";
				
				try
				{
					//OVAKO
					SqlDataAdapter cmdAdapter = new SqlDataAdapter();
					cmdAdapter.SelectCommand =new SqlCommand(pretraga, clsKonekcija.GetConnection());
					cmdAdapter.SelectCommand.CommandType = CommandType.Text;

					//this.connDnevnikObuke.Open();
					this.dsDnevnikObuke1.Clear();
					cmdAdapter.Fill(this.dsDnevnikObuke1,"DnevnikObuke");
					//this.connDnevnikObuke.Close();
					

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
