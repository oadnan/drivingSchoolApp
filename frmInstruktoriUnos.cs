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
	/// Summary description for frmInstruktoriUnos.
	/// </summary>
	public class frmInstruktoriUnos : System.Windows.Forms.Form
	{
		private System.Windows.Forms.GroupBox gbOpcije;
		private System.Windows.Forms.Button duZatvori;
        private System.Windows.Forms.Button duSpasi;
		private System.Windows.Forms.GroupBox gbPodaci;
		private System.Windows.Forms.DateTimePicker DTPdatRodjenja;
		private System.Windows.Forms.DateTimePicker DTPdatZap;
		private System.Windows.Forms.TextBox tbEmail;
		private System.Windows.Forms.TextBox tbTelefon;
		private System.Windows.Forms.TextBox tbAdresa;
		private System.Windows.Forms.TextBox tbPrezime;
		private System.Windows.Forms.TextBox tbIme;
		private System.Windows.Forms.TextBox tbInstruktorID;
		private System.Windows.Forms.Label lbDatumZapos;
		private System.Windows.Forms.Label lbEmail;
		private System.Windows.Forms.Label lbTelefon;
		private System.Windows.Forms.Label lbAdresa;
		private System.Windows.Forms.Label lbDatumRodjenja;
		private System.Windows.Forms.Label lbPrezime;
        private System.Windows.Forms.Label lbIme;
        private IContainer components;

		//Varijabla koja služi za odredivanje da li se radi o opciji 
		//Novi ili Izmjeni(ažuriranje)
		int opcija=0;
		
		//Kreiranje novog objekta klase clsInstruktori
		clsInstruktori instruktor = new clsInstruktori();
		private System.Data.SqlClient.SqlConnection connInstruktoriUnos;
        private AutoSkola.DSetovi.dsKategorije dsKategorije1;
		private System.Windows.Forms.DataGridTextBoxColumn KatInstID;
		private System.Windows.Forms.GroupBox gbKategorije;
		private System.Windows.Forms.Button duSpasiKategoriju;
		private System.Windows.Forms.Button duIzbrisi;
        private System.Windows.Forms.DataGrid dgKategorijeInst;
		private System.Windows.Forms.DataGridTableStyle dgTableStyleKatIns;
		private System.Windows.Forms.DataGridTextBoxColumn KatInstID1;
		private System.Windows.Forms.DataGridTextBoxColumn KategorijaID;
        private System.Windows.Forms.DataGridTextBoxColumn Kategorija;
        private AutoSkola.DSetovi.dsKandidati dsKandidati;
        private TextBox tbKatID;

		int broj = 0;
        private ComboBox cbKategorija;
        private Label label1;
        private Label label2;
        private AutoSkola.DSetovi.dsKategorije dsKategorije2;
                        		
		public frmInstruktoriUnos()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInstruktoriUnos));
            this.gbOpcije = new System.Windows.Forms.GroupBox();
            this.duZatvori = new System.Windows.Forms.Button();
            this.duSpasi = new System.Windows.Forms.Button();
            this.gbPodaci = new System.Windows.Forms.GroupBox();
            this.gbKategorije = new System.Windows.Forms.GroupBox();
            this.cbKategorija = new System.Windows.Forms.ComboBox();
            this.dsKategorije2 = new AutoSkola.DSetovi.dsKategorije();
            this.tbKatID = new System.Windows.Forms.TextBox();
            this.duSpasiKategoriju = new System.Windows.Forms.Button();
            this.duIzbrisi = new System.Windows.Forms.Button();
            this.dgKategorijeInst = new System.Windows.Forms.DataGrid();
            this.dsKategorije1 = new AutoSkola.DSetovi.dsKategorije();
            this.dgTableStyleKatIns = new System.Windows.Forms.DataGridTableStyle();
            this.KatInstID1 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.KategorijaID = new System.Windows.Forms.DataGridTextBoxColumn();
            this.Kategorija = new System.Windows.Forms.DataGridTextBoxColumn();
            this.DTPdatRodjenja = new System.Windows.Forms.DateTimePicker();
            this.DTPdatZap = new System.Windows.Forms.DateTimePicker();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbTelefon = new System.Windows.Forms.TextBox();
            this.tbAdresa = new System.Windows.Forms.TextBox();
            this.tbPrezime = new System.Windows.Forms.TextBox();
            this.tbIme = new System.Windows.Forms.TextBox();
            this.tbInstruktorID = new System.Windows.Forms.TextBox();
            this.lbDatumZapos = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbTelefon = new System.Windows.Forms.Label();
            this.lbAdresa = new System.Windows.Forms.Label();
            this.lbDatumRodjenja = new System.Windows.Forms.Label();
            this.lbPrezime = new System.Windows.Forms.Label();
            this.lbIme = new System.Windows.Forms.Label();
            this.connInstruktoriUnos = new System.Data.SqlClient.SqlConnection();
            this.KatInstID = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dsKandidati = new AutoSkola.DSetovi.dsKandidati();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gbOpcije.SuspendLayout();
            this.gbPodaci.SuspendLayout();
            this.gbKategorije.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsKategorije2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgKategorijeInst)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsKategorije1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsKandidati)).BeginInit();
            this.SuspendLayout();
            // 
            // gbOpcije
            // 
            this.gbOpcije.BackColor = System.Drawing.SystemColors.Control;
            this.gbOpcije.Controls.Add(this.duZatvori);
            this.gbOpcije.Controls.Add(this.duSpasi);
            this.gbOpcije.Location = new System.Drawing.Point(16, 287);
            this.gbOpcije.Name = "gbOpcije";
            this.gbOpcije.Size = new System.Drawing.Size(280, 72);
            this.gbOpcije.TabIndex = 4;
            this.gbOpcije.TabStop = false;
            // 
            // duZatvori
            // 
            this.duZatvori.BackColor = System.Drawing.Color.Beige;
            this.duZatvori.Cursor = System.Windows.Forms.Cursors.Hand;
            this.duZatvori.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.duZatvori.Image = ((System.Drawing.Image)(resources.GetObject("duZatvori.Image")));
            this.duZatvori.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.duZatvori.Location = new System.Drawing.Point(152, 24);
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
            this.duSpasi.TabIndex = 0;
            this.duSpasi.Text = "       Spasi";
            this.duSpasi.UseVisualStyleBackColor = false;
            this.duSpasi.Click += new System.EventHandler(this.duSpasi_Click);
            // 
            // gbPodaci
            // 
            this.gbPodaci.BackColor = System.Drawing.SystemColors.Control;
            this.gbPodaci.Controls.Add(this.gbKategorije);
            this.gbPodaci.Controls.Add(this.DTPdatRodjenja);
            this.gbPodaci.Controls.Add(this.DTPdatZap);
            this.gbPodaci.Controls.Add(this.tbEmail);
            this.gbPodaci.Controls.Add(this.tbTelefon);
            this.gbPodaci.Controls.Add(this.tbAdresa);
            this.gbPodaci.Controls.Add(this.tbPrezime);
            this.gbPodaci.Controls.Add(this.tbIme);
            this.gbPodaci.Controls.Add(this.tbInstruktorID);
            this.gbPodaci.Controls.Add(this.lbDatumZapos);
            this.gbPodaci.Controls.Add(this.lbEmail);
            this.gbPodaci.Controls.Add(this.lbTelefon);
            this.gbPodaci.Controls.Add(this.lbAdresa);
            this.gbPodaci.Controls.Add(this.lbDatumRodjenja);
            this.gbPodaci.Controls.Add(this.lbPrezime);
            this.gbPodaci.Controls.Add(this.lbIme);
            this.gbPodaci.Controls.Add(this.gbOpcije);
            this.gbPodaci.Location = new System.Drawing.Point(15, 8);
            this.gbPodaci.Name = "gbPodaci";
            this.gbPodaci.Size = new System.Drawing.Size(312, 556);
            this.gbPodaci.TabIndex = 3;
            this.gbPodaci.TabStop = false;
            this.gbPodaci.Text = "Unos Podataka";
            // 
            // gbKategorije
            // 
            this.gbKategorije.Controls.Add(this.label2);
            this.gbKategorije.Controls.Add(this.label1);
            this.gbKategorije.Controls.Add(this.cbKategorija);
            this.gbKategorije.Controls.Add(this.tbKatID);
            this.gbKategorije.Controls.Add(this.duSpasiKategoriju);
            this.gbKategorije.Controls.Add(this.duIzbrisi);
            this.gbKategorije.Controls.Add(this.dgKategorijeInst);
            this.gbKategorije.Location = new System.Drawing.Point(16, 367);
            this.gbKategorije.Name = "gbKategorije";
            this.gbKategorije.Size = new System.Drawing.Size(280, 180);
            this.gbKategorije.TabIndex = 12;
            this.gbKategorije.TabStop = false;
            this.gbKategorije.Text = "Unos kategorija instruktoru";
            // 
            // cbKategorija
            // 
            this.cbKategorija.DataSource = this.dsKategorije2;
            this.cbKategorija.DisplayMember = "Kategorije.Kategorija";
            this.cbKategorija.FormattingEnabled = true;
            this.cbKategorija.Location = new System.Drawing.Point(158, 58);
            this.cbKategorija.Name = "cbKategorija";
            this.cbKategorija.Size = new System.Drawing.Size(112, 24);
            this.cbKategorija.TabIndex = 6;
            // 
            // dsKategorije2
            // 
            this.dsKategorije2.DataSetName = "dsKategorije";
            this.dsKategorije2.Locale = new System.Globalization.CultureInfo("hr-HR");
            this.dsKategorije2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbKatID
            // 
            this.tbKatID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsKategorije2, "Kategorije.KategorijaID", true));
            this.tbKatID.Location = new System.Drawing.Point(158, 58);
            this.tbKatID.Name = "tbKatID";
            this.tbKatID.PasswordChar = '*';
            this.tbKatID.ReadOnly = true;
            this.tbKatID.Size = new System.Drawing.Size(29, 22);
            this.tbKatID.TabIndex = 5;
            // 
            // duSpasiKategoriju
            // 
            this.duSpasiKategoriju.BackColor = System.Drawing.Color.Beige;
            this.duSpasiKategoriju.Cursor = System.Windows.Forms.Cursors.Hand;
            this.duSpasiKategoriju.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.duSpasiKategoriju.Image = ((System.Drawing.Image)(resources.GetObject("duSpasiKategoriju.Image")));
            this.duSpasiKategoriju.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.duSpasiKategoriju.Location = new System.Drawing.Point(158, 91);
            this.duSpasiKategoriju.Name = "duSpasiKategoriju";
            this.duSpasiKategoriju.Size = new System.Drawing.Size(112, 32);
            this.duSpasiKategoriju.TabIndex = 2;
            this.duSpasiKategoriju.Text = "       Spasi";
            this.duSpasiKategoriju.UseVisualStyleBackColor = false;
            this.duSpasiKategoriju.Click += new System.EventHandler(this.duSpasiKategoriju_Click);
            // 
            // duIzbrisi
            // 
            this.duIzbrisi.BackColor = System.Drawing.Color.Beige;
            this.duIzbrisi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.duIzbrisi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.duIzbrisi.Image = ((System.Drawing.Image)(resources.GetObject("duIzbrisi.Image")));
            this.duIzbrisi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.duIzbrisi.Location = new System.Drawing.Point(158, 131);
            this.duIzbrisi.Name = "duIzbrisi";
            this.duIzbrisi.Size = new System.Drawing.Size(112, 32);
            this.duIzbrisi.TabIndex = 3;
            this.duIzbrisi.Text = "Izbriši";
            this.duIzbrisi.UseVisualStyleBackColor = false;
            this.duIzbrisi.Click += new System.EventHandler(this.duIzbrisi_Click);
            // 
            // dgKategorijeInst
            // 
            this.dgKategorijeInst.DataMember = "";
            this.dgKategorijeInst.DataSource = this.dsKategorije1.Kategorije;
            this.dgKategorijeInst.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dgKategorijeInst.Location = new System.Drawing.Point(15, 23);
            this.dgKategorijeInst.Name = "dgKategorijeInst";
            this.dgKategorijeInst.ReadOnly = true;
            this.dgKategorijeInst.Size = new System.Drawing.Size(136, 140);
            this.dgKategorijeInst.TabIndex = 0;
            this.dgKategorijeInst.TableStyles.AddRange(new System.Windows.Forms.DataGridTableStyle[] {
            this.dgTableStyleKatIns});
            // 
            // dsKategorije1
            // 
            this.dsKategorije1.DataSetName = "dsKategorije";
            this.dsKategorije1.Locale = new System.Globalization.CultureInfo("");
            this.dsKategorije1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dgTableStyleKatIns
            // 
            this.dgTableStyleKatIns.DataGrid = this.dgKategorijeInst;
            this.dgTableStyleKatIns.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {
            this.KatInstID1,
            this.KategorijaID,
            this.Kategorija});
            this.dgTableStyleKatIns.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dgTableStyleKatIns.MappingName = "Kategorije";
            // 
            // KatInstID1
            // 
            this.KatInstID1.Format = "";
            this.KatInstID1.FormatInfo = null;
            this.KatInstID1.HeaderText = "KatInstID";
            this.KatInstID1.MappingName = "KatInstID";
            this.KatInstID1.Width = 0;
            // 
            // KategorijaID
            // 
            this.KategorijaID.Format = "";
            this.KategorijaID.FormatInfo = null;
            this.KategorijaID.HeaderText = "KategorijaID";
            this.KategorijaID.MappingName = "KategorijaID";
            this.KategorijaID.Width = 0;
            // 
            // Kategorija
            // 
            this.Kategorija.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.Kategorija.Format = "";
            this.Kategorija.FormatInfo = null;
            this.Kategorija.HeaderText = "Kategorija";
            this.Kategorija.MappingName = "Kategorija";
            this.Kategorija.Width = 75;
            // 
            // DTPdatRodjenja
            // 
            this.DTPdatRodjenja.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPdatRodjenja.Location = new System.Drawing.Point(144, 109);
            this.DTPdatRodjenja.Name = "DTPdatRodjenja";
            this.DTPdatRodjenja.Size = new System.Drawing.Size(152, 22);
            this.DTPdatRodjenja.TabIndex = 2;
            this.DTPdatRodjenja.Value = new System.DateTime(2007, 10, 24, 0, 0, 0, 0);
            // 
            // DTPdatZap
            // 
            this.DTPdatZap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPdatZap.Location = new System.Drawing.Point(144, 253);
            this.DTPdatZap.Name = "DTPdatZap";
            this.DTPdatZap.Size = new System.Drawing.Size(152, 22);
            this.DTPdatZap.TabIndex = 6;
            this.DTPdatZap.Value = new System.DateTime(2007, 10, 24, 0, 0, 0, 0);
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(144, 213);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(152, 22);
            this.tbEmail.TabIndex = 5;
            // 
            // tbTelefon
            // 
            this.tbTelefon.Location = new System.Drawing.Point(144, 181);
            this.tbTelefon.Name = "tbTelefon";
            this.tbTelefon.Size = new System.Drawing.Size(152, 22);
            this.tbTelefon.TabIndex = 4;
            // 
            // tbAdresa
            // 
            this.tbAdresa.Location = new System.Drawing.Point(144, 149);
            this.tbAdresa.Name = "tbAdresa";
            this.tbAdresa.Size = new System.Drawing.Size(152, 22);
            this.tbAdresa.TabIndex = 3;
            // 
            // tbPrezime
            // 
            this.tbPrezime.Location = new System.Drawing.Point(144, 69);
            this.tbPrezime.Name = "tbPrezime";
            this.tbPrezime.Size = new System.Drawing.Size(152, 22);
            this.tbPrezime.TabIndex = 1;
            // 
            // tbIme
            // 
            this.tbIme.Location = new System.Drawing.Point(144, 29);
            this.tbIme.Name = "tbIme";
            this.tbIme.Size = new System.Drawing.Size(152, 22);
            this.tbIme.TabIndex = 0;
            // 
            // tbInstruktorID
            // 
            this.tbInstruktorID.Location = new System.Drawing.Point(144, 29);
            this.tbInstruktorID.Name = "tbInstruktorID";
            this.tbInstruktorID.ReadOnly = true;
            this.tbInstruktorID.Size = new System.Drawing.Size(37, 22);
            this.tbInstruktorID.TabIndex = 0;
            this.tbInstruktorID.TabStop = false;
            this.tbInstruktorID.Visible = false;
            // 
            // lbDatumZapos
            // 
            this.lbDatumZapos.Location = new System.Drawing.Point(16, 253);
            this.lbDatumZapos.Name = "lbDatumZapos";
            this.lbDatumZapos.Size = new System.Drawing.Size(120, 23);
            this.lbDatumZapos.TabIndex = 7;
            this.lbDatumZapos.Text = "Datum zaposlenja:";
            this.lbDatumZapos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbEmail
            // 
            this.lbEmail.Location = new System.Drawing.Point(16, 213);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(120, 23);
            this.lbEmail.TabIndex = 6;
            this.lbEmail.Text = "E-mail:";
            this.lbEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbTelefon
            // 
            this.lbTelefon.Location = new System.Drawing.Point(16, 181);
            this.lbTelefon.Name = "lbTelefon";
            this.lbTelefon.Size = new System.Drawing.Size(120, 23);
            this.lbTelefon.TabIndex = 5;
            this.lbTelefon.Text = "Telefon:";
            this.lbTelefon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbAdresa
            // 
            this.lbAdresa.Location = new System.Drawing.Point(16, 148);
            this.lbAdresa.Name = "lbAdresa";
            this.lbAdresa.Size = new System.Drawing.Size(120, 23);
            this.lbAdresa.TabIndex = 4;
            this.lbAdresa.Text = "Adresa:";
            this.lbAdresa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbDatumRodjenja
            // 
            this.lbDatumRodjenja.Location = new System.Drawing.Point(16, 109);
            this.lbDatumRodjenja.Name = "lbDatumRodjenja";
            this.lbDatumRodjenja.Size = new System.Drawing.Size(120, 23);
            this.lbDatumRodjenja.TabIndex = 3;
            this.lbDatumRodjenja.Text = "Datum rodjenja:";
            this.lbDatumRodjenja.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbPrezime
            // 
            this.lbPrezime.Location = new System.Drawing.Point(16, 69);
            this.lbPrezime.Name = "lbPrezime";
            this.lbPrezime.Size = new System.Drawing.Size(120, 23);
            this.lbPrezime.TabIndex = 2;
            this.lbPrezime.Text = "Prezime:";
            this.lbPrezime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbIme
            // 
            this.lbIme.Location = new System.Drawing.Point(16, 29);
            this.lbIme.Name = "lbIme";
            this.lbIme.Size = new System.Drawing.Size(120, 23);
            this.lbIme.TabIndex = 1;
            this.lbIme.Text = "Ime:";
            this.lbIme.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // connInstruktoriUnos
            // 
            this.connInstruktoriUnos.ConnectionString = "Data Source=(local);Initial Catalog=baza;integrated security=SSPI";
            this.connInstruktoriUnos.FireInfoMessageEventOnUserErrors = false;
            // 
            // KatInstID
            // 
            this.KatInstID.Format = "";
            this.KatInstID.FormatInfo = null;
            this.KatInstID.HeaderText = "KatInstID";
            this.KatInstID.MappingName = "KatInstID";
            this.KatInstID.Width = 75;
            // 
            // dsKandidati
            // 
            this.dsKandidati.DataSetName = "dsKandidati";
            this.dsKandidati.Locale = new System.Globalization.CultureInfo("hr-HR");
            this.dsKandidati.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(157, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Unos nove";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(157, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "kategorije:";
            // 
            // frmInstruktoriUnos
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 15);
            this.ClientSize = new System.Drawing.Size(338, 573);
            this.Controls.Add(this.gbPodaci);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmInstruktoriUnos";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Unos instruktora";
            this.Load += new System.EventHandler(this.frmInstruktoriUnos_Load);
            this.gbOpcije.ResumeLayout(false);
            this.gbPodaci.ResumeLayout(false);
            this.gbPodaci.PerformLayout();
            this.gbKategorije.ResumeLayout(false);
            this.gbKategorije.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsKategorije2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgKategorijeInst)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsKategorije1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsKandidati)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion
	
		public void uzmiPodatke(clsInstruktori a,int o)
		{
			this.instruktor=a;
			this.opcija=o;
		}

		public void uzmiBroj(int b)
		{
			broj = b;
		}

		public void ucitajKategorije()
		{			
			string query = "SELECT KI.KatInstID, K.KategorijaID, K.Kategorija FROM Kategorije K INNER JOIN KategorijeInstruktori KI ON K.KategorijaID = KI.KategorijaID INNER JOIN Instruktori I ON KI.InstruktorID = I.InstruktorID WHERE I.InstruktorID = @InstruktorID ORDER BY K.KategorijaID";
			//string query = "SELECT KI.KatInstID, K.KategorijaID, K.Kategorija FROM KategorijeInstruktori KI INNER JOIN Kategorije K ON KI.KategorijaID = K.KategorijaID INNER JOIN Instruktori I ON KI.InstruktorID = I.InstruktorID WHERE I.InstruktorID = @InstruktorID ORDER BY K.KategorijaID";				
			try
			{
				SqlCommand cmd = new SqlCommand(query, clsKonekcija.GetConnection());				
												
				SqlDataAdapter cmdAdapter = new SqlDataAdapter(cmd);				

				cmd.Parameters.Add("@InstruktorID",SqlDbType.Int);
				cmd.Parameters["@InstruktorID"].Value = tbInstruktorID.Text;
				// ,"Kategorije"			
				dsKategorije1.Clear();
				cmdAdapter.Fill(dsKategorije1.Kategorije);
                                
            }
			catch(Exception ex)
			{
				string iz=ex.Message.ToString();
				MessageBox.Show("Više puta ste unijeli istu kategoriju!","Upozorenje",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
			}
		}

        //Novo
        public void ucitajKategDodaj()
		{
            string query = "SELECT KategorijaID, Kategorija FROM Kategorije ";
            
            try
            {
                SqlCommand cmd = new SqlCommand(query, clsKonekcija.GetConnection());
                SqlDataAdapter cmdAdapter = new SqlDataAdapter(cmd);
                                			
                dsKategorije2.Clear();
                cmdAdapter.Fill(dsKategorije2.Kategorije);                                
            }
            catch (Exception ex)
            {
                string iz = ex.Message.ToString();
                MessageBox.Show("Došlo je do greške!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        //

		private void frmInstruktoriUnos_Load(object sender, System.EventArgs e)
		{
			if(this.opcija==1)
			{
                this.duSpasi.Text = "Spasi";
                this.gbKategorije.Enabled = false; 
                ucitajKategDodaj();
			}
			if(this.opcija==2)
			{
                this.duSpasi.Text = "Izmjeni";
							
				//Ako je odabrana opcija za izmjenu podataka onda proslijedi 
				//odabrani zapis iz data grida u formu za izmjenu podataka koristeci varijable iz clsVarijable
				this.tbInstruktorID.Text=this.instruktor.InstruktorID;
                                
                this.tbIme.Text=this.instruktor.Ime;
				this.tbPrezime.Text=this.instruktor.Prezime;				
				this.DTPdatRodjenja.Text=this.instruktor.DatumRodjenja;
				this.tbAdresa.Text=this.instruktor.Adresa;
				this.tbTelefon.Text=this.instruktor.Telefon;
				this.tbEmail.Text=this.instruktor.Email;
				this.DTPdatZap.Text=this.instruktor.DatumZaposlenja;
			
				ucitajKategorije();
                ucitajKategDodaj();
			}
						
		}

		private void duSpasi_Click(object sender, System.EventArgs e)
		{
            if (this.duSpasi.Text == "Spasi")
            {
                string query = "INSERT INTO Instruktori(Ime,Prezime,DatumRodjenja,Adresa,Telefon,Email,DatumZaposlenja) VALUES('" + tbIme.Text + "','" + tbPrezime.Text + "',@DatumRodjenja,'" + tbAdresa.Text + "','" + tbTelefon.Text + "','" + tbEmail.Text + "',@DatumZaposlenja);";

                try
                {
                    SqlCommand cmd = new SqlCommand(query, clsKonekcija.GetConnection());

                    cmd.Parameters.Add("@DatumRodjenja", SqlDbType.DateTime);
                    cmd.Parameters["@DatumRodjenja"].Value = DTPdatRodjenja.Text.ToString();

                    cmd.Parameters.Add("@DatumZaposlenja", SqlDbType.DateTime);
                    cmd.Parameters["@DatumZaposlenja"].Value = DTPdatZap.Text.ToString();

                    //this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Proizvodjac", System.Data.SqlDbType.VarChar, 50, "Proizvodjac"));

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Podaci su uspješno spašeni.", "Obavještenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //this.Close();	


                    string queryIDinst = "SELECT MAX(InstruktorID) AS IDinst FROM Instruktori ";
                    SqlCommand cmdIDinst = new SqlCommand(queryIDinst, clsKonekcija.GetConnection());
                    SqlDataReader drIDinst = cmdIDinst.ExecuteReader();
                    if (drIDinst.Read())
                    {
                        tbInstruktorID.Text = drIDinst["IDinst"].ToString();
                    }
                    drIDinst.Close();

                    this.gbKategorije.Enabled = true;

                    //Novo
                    //

                }
                catch (Exception ex)
                {
                    string iz = ex.Message.ToString();
                    MessageBox.Show("Nepravilno uneseni podaci !", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else if (this.duSpasi.Text == "Izmjeni")
            {
                if (this.tbInstruktorID.Text != "")
                {
                    string query1 = "UPDATE Instruktori SET Ime ='" + tbIme.Text + "' WHERE(InstruktorID=" + this.tbInstruktorID.Text + ")";
                    string query2 = "UPDATE Instruktori SET Prezime ='" + tbPrezime.Text + "' WHERE(InstruktorID=" + this.tbInstruktorID.Text + ")";
                    string query3 = "UPDATE Instruktori SET DatumRodjenja =@DatumRodjenja WHERE(InstruktorID=" + this.tbInstruktorID.Text + ")";
                    string query4 = "UPDATE Instruktori SET Adresa ='" + tbAdresa.Text + "' WHERE(InstruktorID=" + this.tbInstruktorID.Text + ")";
                    string query5 = "UPDATE Instruktori SET Telefon ='" + tbTelefon.Text + "' WHERE(InstruktorID=" + this.tbInstruktorID.Text + ")";
                    string query6 = "UPDATE Instruktori SET Email ='" + tbEmail.Text + "' WHERE(InstruktorID=" + this.tbInstruktorID.Text + ")";
                    string query7 = "UPDATE Instruktori SET DatumZaposlenja = @DatumZaposlenja WHERE(InstruktorID=" + this.tbInstruktorID.Text + ")";

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

                        cmd7.Parameters.Add("@DatumZaposlenja", SqlDbType.DateTime);
                        cmd7.Parameters["@DatumZaposlenja"].Value = DTPdatZap.Text.ToString();

                        //this.connInstruktoriUnos.Open();
                        cmd1.ExecuteNonQuery();
                        cmd2.ExecuteNonQuery();
                        cmd3.ExecuteNonQuery();
                        cmd4.ExecuteNonQuery();
                        cmd5.ExecuteNonQuery();
                        cmd6.ExecuteNonQuery();
                        cmd7.ExecuteNonQuery();
                        //this.connInstruktoriUnos.Close();

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
            //
            this.DialogResult = DialogResult.OK;
            //
		}        	

		public void UnesiKategoriju(string sKategorijaID, string sKategorija)
		{
			//tbKategorijaID.Text=sKategorijaID;
			//tbKategorija.Text=sKategorija;
		}
		
		private void duInstruktorUnos_Click(object sender, System.EventArgs e)
		{
			frmKategorije f = new frmKategorije(this);
			f.uzmiBroj(1); 
			f.ShowDialog();			
		}

		private void duSpasiKategoriju_Click(object sender, System.EventArgs e)
		{
			string query = "INSERT INTO KategorijeInstruktori(InstruktorID,KategorijaID) VALUES('"+tbInstruktorID.Text+"','"+tbKatID.Text+"');";
									
			try
			{
				SqlCommand cmd = new SqlCommand(query, clsKonekcija.GetConnection());
								
				cmd.ExecuteNonQuery();
												
				MessageBox.Show("Kategorija je dodata instruktoru.", "Obavještenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
				//this.tbKategorijaID.Clear();
				//this.tbKategorija.Clear();
				ucitajKategorije();			
			}
			catch(Exception ex)
			{
				string iz=ex.Message.ToString();
				MessageBox.Show("Došlo je do greške!","Upozorenje",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
			}
		}

		private void duOsvjezi_Click(object sender, System.EventArgs e)
		{		
			ucitajKategorije();
		}

		private void duIzbrisi_Click(object sender, System.EventArgs e)
		{
			//Ako data set dsKategorije1 nije prazan
			if(this.dsKategorije1.Kategorije.Rows.Count>0)
			{
				//Odabir trenutno oznacene celije
				DataGridCell selectedCell = dgKategorijeInst.CurrentCell;
				//Odabir podataka iz trenutne celije na poziciji kolone 2  
				object o1 = dgKategorijeInst[selectedCell.RowNumber, 2];
								
				//Konvertovanje objekta o1 
				string Kategorija = Convert.ToString(o1);
				string Ime = this.tbIme.Text.ToString();
 				string Prezime = this.tbPrezime.Text.ToString();

				//Prikaz dijalog boksa sa pitanjem, ako je rezultat opcija Yes
				//Onda izbriši odabrani zapis
				if(MessageBox.Show("Da li ste sigurni da želite izbrisati kategoriju: "+Kategorija+" \nZa instruktora: "+Ime+" "+Prezime+"","Upozorenje !",MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes)
				{
					System.Windows.Forms.DataGridCell celija = this.dgKategorijeInst.CurrentCell;
					object B0=this.dgKategorijeInst[celija.RowNumber, 0];
					string KatInstID =Convert.ToString(B0);

					try
					{						
						SqlCommand kom = new SqlCommand("DELETE FROM KategorijeInstruktori WHERE KatInstID = "+KatInstID+"", clsKonekcija.GetConnection());
						kom.ExecuteNonQuery();
												
						ucitajKategorije();						
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
				MessageBox.Show("Polje kategorija je prazno!","Upozorenje",MessageBoxButtons.OK,MessageBoxIcon.Question);
			}
		}

		
	}
}