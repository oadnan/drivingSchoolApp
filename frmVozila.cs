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
	/// Summary description for frmVozila.
	/// </summary>
	public class frmVozila : System.Windows.Forms.Form
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
		private System.Data.SqlClient.SqlConnection connVozila;
		private System.Data.SqlClient.SqlDataAdapter daVozila;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
		private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
		private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
		private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
        private AutoSkola.DSetovi.dsVozila dsVozila1;
		private System.Windows.Forms.DataGrid dgVozila;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		//Objekat koji se koristi kod preklopljenog konstruktora
		frmDnevnikUnos d;
		private System.Windows.Forms.Button duOdstampaj;
		private System.Windows.Forms.Button duPretraga;
		private System.Windows.Forms.ComboBox cbPolje1;
		private System.Windows.Forms.TextBox tbVrijednost1;
		private System.Windows.Forms.Label lbVrijednost1;
		private System.Windows.Forms.Label label2;
        private DataGridTableStyle dgTableStyleVozila;
        private DataGridTextBoxColumn VoziloID;
        private DataGridTextBoxColumn Proizvodjac;
        private DataGridTextBoxColumn Model;
        private DataGridTextBoxColumn Boja;
        private DataGridTextBoxColumn GodinaProizvodnje;
        private DataGridTextBoxColumn RegistarskiBroj;
        private DataGridTextBoxColumn Motor;
        private DataGridTextBoxColumn OstaliDetalji;
		
		int broj = 0;
		
		public frmVozila()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
			
			this.sqlSelectCommand1.Connection = clsKonekcija.GetConnection();

            this.daVozila.Fill(this.dsVozila1);
			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}
		
		private static frmVozila vozilo = null;
		public static frmVozila Instance()
		{
			if (vozilo == null) { vozilo = new frmVozila(); }

			return vozilo;
		}

		//Preklopljeni konstruktor sa argumentom tipa frmKandidatiUnos
		public frmVozila(frmDnevnikUnos fr3)
		{
			InitializeComponent();
			d = new frmDnevnikUnos();
			d = fr3;
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

			vozilo = null;
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVozila));
            this.pictureBoxInst = new System.Windows.Forms.PictureBox();
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
            this.connVozila = new System.Data.SqlClient.SqlConnection();
            this.daVozila = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
            this.dsVozila1 = new AutoSkola.DSetovi.dsVozila();
            this.dgVozila = new System.Windows.Forms.DataGrid();
            this.dgTableStyleVozila = new System.Windows.Forms.DataGridTableStyle();
            this.VoziloID = new System.Windows.Forms.DataGridTextBoxColumn();
            this.Proizvodjac = new System.Windows.Forms.DataGridTextBoxColumn();
            this.Model = new System.Windows.Forms.DataGridTextBoxColumn();
            this.Boja = new System.Windows.Forms.DataGridTextBoxColumn();
            this.GodinaProizvodnje = new System.Windows.Forms.DataGridTextBoxColumn();
            this.RegistarskiBroj = new System.Windows.Forms.DataGridTextBoxColumn();
            this.Motor = new System.Windows.Forms.DataGridTextBoxColumn();
            this.OstaliDetalji = new System.Windows.Forms.DataGridTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInst)).BeginInit();
            this.gbPretraga.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbOpcije.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsVozila1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgVozila)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxInst
            // 
            this.pictureBoxInst.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxInst.Image")));
            this.pictureBoxInst.Location = new System.Drawing.Point(-1, 0);
            this.pictureBoxInst.Name = "pictureBoxInst";
            this.pictureBoxInst.Size = new System.Drawing.Size(786, 32);
            this.pictureBoxInst.TabIndex = 8;
            this.pictureBoxInst.TabStop = false;
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
            this.gbPretraga.Location = new System.Drawing.Point(10, 358);
            this.gbPretraga.Name = "gbPretraga";
            this.gbPretraga.Size = new System.Drawing.Size(604, 114);
            this.gbPretraga.TabIndex = 7;
            this.gbPretraga.TabStop = false;
            this.gbPretraga.Text = "        Pretraga";
            // 
            // duPretraga
            // 
            this.duPretraga.BackColor = System.Drawing.Color.Beige;
            this.duPretraga.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.duPretraga.Image = ((System.Drawing.Image)(resources.GetObject("duPretraga.Image")));
            this.duPretraga.Location = new System.Drawing.Point(544, 43);
            this.duPretraga.Name = "duPretraga";
            this.duPretraga.Size = new System.Drawing.Size(44, 44);
            this.duPretraga.TabIndex = 14;
            this.duPretraga.UseVisualStyleBackColor = false;
            this.duPretraga.Click += new System.EventHandler(this.duPretraga_Click);
            // 
            // cbPolje1
            // 
            this.cbPolje1.Items.AddRange(new object[] {
            "Proizvodjac",
            "Model",
            "Boja",
            "GodinaProizvodnje",
            "RegistarskiBroj",
            "Motor"});
            this.cbPolje1.Location = new System.Drawing.Point(120, 72);
            this.cbPolje1.Name = "cbPolje1";
            this.cbPolje1.Size = new System.Drawing.Size(136, 24);
            this.cbPolje1.TabIndex = 11;
            this.cbPolje1.Text = "Model";
            this.cbPolje1.SelectedValueChanged += new System.EventHandler(this.cbPolje1_SelectedValueChanged);
            // 
            // tbVrijednost1
            // 
            this.tbVrijednost1.Location = new System.Drawing.Point(404, 75);
            this.tbVrijednost1.Name = "tbVrijednost1";
            this.tbVrijednost1.Size = new System.Drawing.Size(128, 22);
            this.tbVrijednost1.TabIndex = 13;
            this.tbVrijednost1.TextChanged += new System.EventHandler(this.tbVrijednost1_TextChanged);
            // 
            // lbVrijednost1
            // 
            this.lbVrijednost1.Location = new System.Drawing.Point(270, 75);
            this.lbVrijednost1.Name = "lbVrijednost1";
            this.lbVrijednost1.Size = new System.Drawing.Size(132, 24);
            this.lbVrijednost1.TabIndex = 12;
            this.lbVrijednost1.Text = "Model vozila:";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(8, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 24);
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
            "Proizvodjac",
            "Model",
            "Boja",
            "GodinaProizvodnje",
            "RegistarskiBroj",
            "Motor"});
            this.cbPolje.Location = new System.Drawing.Point(120, 32);
            this.cbPolje.Name = "cbPolje";
            this.cbPolje.Size = new System.Drawing.Size(136, 24);
            this.cbPolje.TabIndex = 0;
            this.cbPolje.Text = "Proizvodjac";
            this.cbPolje.SelectedValueChanged += new System.EventHandler(this.cbPolje_SelectedValueChanged);
            // 
            // tbVrijednost
            // 
            this.tbVrijednost.Location = new System.Drawing.Point(404, 35);
            this.tbVrijednost.Name = "tbVrijednost";
            this.tbVrijednost.Size = new System.Drawing.Size(128, 22);
            this.tbVrijednost.TabIndex = 1;
            this.tbVrijednost.TextChanged += new System.EventHandler(this.tbVrijednost_TextChanged);
            // 
            // lbVrijednost
            // 
            this.lbVrijednost.Location = new System.Drawing.Point(270, 35);
            this.lbVrijednost.Name = "lbVrijednost";
            this.lbVrijednost.Size = new System.Drawing.Size(132, 24);
            this.lbVrijednost.TabIndex = 1;
            this.lbVrijednost.Text = "Proizvodjac:";
            // 
            // lbPolje
            // 
            this.lbPolje.Location = new System.Drawing.Point(8, 35);
            this.lbPolje.Name = "lbPolje";
            this.lbPolje.Size = new System.Drawing.Size(112, 24);
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
            this.gbOpcije.Location = new System.Drawing.Point(628, 36);
            this.gbOpcije.Name = "gbOpcije";
            this.gbOpcije.Size = new System.Drawing.Size(136, 280);
            this.gbOpcije.TabIndex = 6;
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
            this.duOdstampaj.Text = "     Odštampaj";
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
            // connVozila
            // 
            this.connVozila.ConnectionString = "Data Source=(local);Initial Catalog=baza;integrated security=SSPI";
            this.connVozila.FireInfoMessageEventOnUserErrors = false;
            // 
            // daVozila
            // 
            this.daVozila.DeleteCommand = this.sqlDeleteCommand1;
            this.daVozila.InsertCommand = this.sqlInsertCommand1;
            this.daVozila.SelectCommand = this.sqlSelectCommand1;
            this.daVozila.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Vozila", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("VoziloID", "VoziloID"),
                        new System.Data.Common.DataColumnMapping("Proizvodjac", "Proizvodjac"),
                        new System.Data.Common.DataColumnMapping("Model", "Model"),
                        new System.Data.Common.DataColumnMapping("Boja", "Boja"),
                        new System.Data.Common.DataColumnMapping("GodinaProizvodnje", "GodinaProizvodnje"),
                        new System.Data.Common.DataColumnMapping("RegistarskiBroj", "RegistarskiBroj"),
                        new System.Data.Common.DataColumnMapping("Motor", "Motor"),
                        new System.Data.Common.DataColumnMapping("OstaliDetalji", "OstaliDetalji")})});
            this.daVozila.UpdateCommand = this.sqlUpdateCommand1;
            // 
            // sqlDeleteCommand1
            // 
            this.sqlDeleteCommand1.CommandText = resources.GetString("sqlDeleteCommand1.CommandText");
            this.sqlDeleteCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_VoziloID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "VoziloID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Boja", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Boja", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_GodinaProizvodnje", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "GodinaProizvodnje", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Model", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Model", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Motor", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Motor", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_OstaliDetalji", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "OstaliDetalji", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Proizvodjac", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Proizvodjac", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_RegistarskiBroj", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "RegistarskiBroj", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlInsertCommand1
            // 
            this.sqlInsertCommand1.CommandText = resources.GetString("sqlInsertCommand1.CommandText");
            this.sqlInsertCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Proizvodjac", System.Data.SqlDbType.VarChar, 50, "Proizvodjac"),
            new System.Data.SqlClient.SqlParameter("@Model", System.Data.SqlDbType.VarChar, 50, "Model"),
            new System.Data.SqlClient.SqlParameter("@Boja", System.Data.SqlDbType.VarChar, 50, "Boja"),
            new System.Data.SqlClient.SqlParameter("@GodinaProizvodnje", System.Data.SqlDbType.VarChar, 50, "GodinaProizvodnje"),
            new System.Data.SqlClient.SqlParameter("@RegistarskiBroj", System.Data.SqlDbType.VarChar, 50, "RegistarskiBroj"),
            new System.Data.SqlClient.SqlParameter("@Motor", System.Data.SqlDbType.VarChar, 50, "Motor"),
            new System.Data.SqlClient.SqlParameter("@OstaliDetalji", System.Data.SqlDbType.VarChar, 50, "OstaliDetalji")});
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = "SELECT VoziloID, Proizvodjac, Model, Boja, GodinaProizvodnje, RegistarskiBroj, Mo" +
                "tor, OstaliDetalji FROM Vozila ORDER BY VoziloID";
            // 
            // sqlUpdateCommand1
            // 
            this.sqlUpdateCommand1.CommandText = resources.GetString("sqlUpdateCommand1.CommandText");
            this.sqlUpdateCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Proizvodjac", System.Data.SqlDbType.VarChar, 50, "Proizvodjac"),
            new System.Data.SqlClient.SqlParameter("@Model", System.Data.SqlDbType.VarChar, 50, "Model"),
            new System.Data.SqlClient.SqlParameter("@Boja", System.Data.SqlDbType.VarChar, 50, "Boja"),
            new System.Data.SqlClient.SqlParameter("@GodinaProizvodnje", System.Data.SqlDbType.VarChar, 50, "GodinaProizvodnje"),
            new System.Data.SqlClient.SqlParameter("@RegistarskiBroj", System.Data.SqlDbType.VarChar, 50, "RegistarskiBroj"),
            new System.Data.SqlClient.SqlParameter("@Motor", System.Data.SqlDbType.VarChar, 50, "Motor"),
            new System.Data.SqlClient.SqlParameter("@OstaliDetalji", System.Data.SqlDbType.VarChar, 50, "OstaliDetalji"),
            new System.Data.SqlClient.SqlParameter("@Original_VoziloID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "VoziloID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Boja", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Boja", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_GodinaProizvodnje", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "GodinaProizvodnje", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Model", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Model", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Motor", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Motor", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_OstaliDetalji", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "OstaliDetalji", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Proizvodjac", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Proizvodjac", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_RegistarskiBroj", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "RegistarskiBroj", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@VoziloID", System.Data.SqlDbType.Int, 4, "VoziloID")});
            // 
            // dsVozila1
            // 
            this.dsVozila1.DataSetName = "dsVozila";
            this.dsVozila1.Locale = new System.Globalization.CultureInfo("hr-HR");
            this.dsVozila1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dgVozila
            // 
            this.dgVozila.DataMember = "";
            this.dgVozila.DataSource = this.dsVozila1.Vozila;
            this.dgVozila.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dgVozila.Location = new System.Drawing.Point(10, 42);
            this.dgVozila.Name = "dgVozila";
            this.dgVozila.ReadOnly = true;
            this.dgVozila.Size = new System.Drawing.Size(604, 302);
            this.dgVozila.TabIndex = 9;
            this.dgVozila.TableStyles.AddRange(new System.Windows.Forms.DataGridTableStyle[] {
            this.dgTableStyleVozila});
            this.dgVozila.DoubleClick += new System.EventHandler(this.dgVozila_DoubleClick);
            // 
            // dgTableStyleVozila
            // 
            this.dgTableStyleVozila.DataGrid = this.dgVozila;
            this.dgTableStyleVozila.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {
            this.VoziloID,
            this.Proizvodjac,
            this.Model,
            this.Boja,
            this.GodinaProizvodnje,
            this.RegistarskiBroj,
            this.Motor,
            this.OstaliDetalji});
            this.dgTableStyleVozila.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dgTableStyleVozila.MappingName = "Vozila";
            // 
            // VoziloID
            // 
            this.VoziloID.Format = "";
            this.VoziloID.FormatInfo = null;
            this.VoziloID.HeaderText = "VoziloID";
            this.VoziloID.MappingName = "VoziloID";
            this.VoziloID.Width = 0;
            // 
            // Proizvodjac
            // 
            this.Proizvodjac.Format = "";
            this.Proizvodjac.FormatInfo = null;
            this.Proizvodjac.HeaderText = "Proizvodjac";
            this.Proizvodjac.MappingName = "Proizvodjac";
            this.Proizvodjac.Width = 80;
            // 
            // Model
            // 
            this.Model.Format = "";
            this.Model.FormatInfo = null;
            this.Model.HeaderText = "Model";
            this.Model.MappingName = "Model";
            this.Model.Width = 75;
            // 
            // Boja
            // 
            this.Boja.Format = "";
            this.Boja.FormatInfo = null;
            this.Boja.HeaderText = "Boja";
            this.Boja.MappingName = "Boja";
            this.Boja.Width = 70;
            // 
            // GodinaProizvodnje
            // 
            this.GodinaProizvodnje.Format = "";
            this.GodinaProizvodnje.FormatInfo = null;
            this.GodinaProizvodnje.HeaderText = "Godina Proizvodnje";
            this.GodinaProizvodnje.MappingName = "GodinaProizvodnje";
            this.GodinaProizvodnje.Width = 125;
            // 
            // RegistarskiBroj
            // 
            this.RegistarskiBroj.Format = "";
            this.RegistarskiBroj.FormatInfo = null;
            this.RegistarskiBroj.HeaderText = "Registarski Broj";
            this.RegistarskiBroj.MappingName = "RegistarskiBroj";
            this.RegistarskiBroj.Width = 105;
            // 
            // Motor
            // 
            this.Motor.Format = "";
            this.Motor.FormatInfo = null;
            this.Motor.HeaderText = "Motor";
            this.Motor.MappingName = "Motor";
            this.Motor.Width = 65;
            // 
            // OstaliDetalji
            // 
            this.OstaliDetalji.Format = "";
            this.OstaliDetalji.FormatInfo = null;
            this.OstaliDetalji.HeaderText = "Ostali Detalji";
            this.OstaliDetalji.MappingName = "OstaliDetalji";
            this.OstaliDetalji.Width = 95;
            // 
            // frmVozila
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 15);
            this.ClientSize = new System.Drawing.Size(777, 484);
            this.Controls.Add(this.dgVozila);
            this.Controls.Add(this.pictureBoxInst);
            this.Controls.Add(this.gbPretraga);
            this.Controls.Add(this.gbOpcije);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(785, 524);
            this.Name = "frmVozila";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vozila";
            this.Load += new System.EventHandler(this.frmVozila_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInst)).EndInit();
            this.gbPretraga.ResumeLayout(false);
            this.gbPretraga.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbOpcije.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dsVozila1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgVozila)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		public void uzmiBroj(int b)
		{
			broj = b;
		}

		private void tbVrijednost_TextChanged(object sender, System.EventArgs e)
		{
            if (this.tbVrijednost.Text == "" && this.tbVrijednost1.Text == "")
            {
                duOsvjezi_Click(sender, e);
            }			
		}

		private void duNovi_Click(object sender, System.EventArgs e)
		{
			clsVozila vozila = new clsVozila();
			frmVozilaUnos dodaj = new frmVozilaUnos();
			dodaj.uzmiPodatke(vozila,1);
			//dodaj.ShowDialog();

            if (dodaj.ShowDialog() == DialogResult.OK)
            {
                duOsvjezi_Click(sender, e);
            }
		}

		private void duIzmjeni_Click(object sender, System.EventArgs e)
		{
			if(this.dsVozila1.Vozila.Rows.Count>0)
			{
				DataGridCell celija = this.dgVozila.CurrentCell;
				object I0=this.dgVozila[celija.RowNumber, 0];
				object I1=this.dgVozila[celija.RowNumber, 1];
				object I2=this.dgVozila[celija.RowNumber, 2];
				object I3=this.dgVozila[celija.RowNumber, 3];
				object I4=this.dgVozila[celija.RowNumber, 4];
				object I5=this.dgVozila[celija.RowNumber, 5];
				object I6=this.dgVozila[celija.RowNumber, 6];
				object I7=this.dgVozila[celija.RowNumber, 7];
				
				clsVozila vozilo = new clsVozila();

				vozilo.VoziloID = Convert.ToString(I0);
				vozilo.Proizvodjac = Convert.ToString(I1);
				vozilo.Model = Convert.ToString(I2);
				vozilo.Boja = Convert.ToString(I3);
				vozilo.GodinaProizvodnje = Convert.ToString(I4);
				vozilo.Motor = Convert.ToString(I5);
				vozilo.RegistarskiBroj = Convert.ToString(I6);
				vozilo.OstaliDetalji = Convert.ToString(I7);
				
				frmVozilaUnos izmjeni = new frmVozilaUnos();
                izmjeni.uzmiPodatke(vozilo, 2);
				//izmjeni.ShowDialog();
                if (izmjeni.ShowDialog() == DialogResult.OK)
                {
                    duOsvjezi_Click(sender, e);
                }                

			}
			else
			{
				MessageBox.Show("Niste oznacili zapis za Ažuriranje:","Upozorenje !",MessageBoxButtons.OK,MessageBoxIcon.Question);
			}
		}

		private void duIzbrisi_Click(object sender, System.EventArgs e)
		{
			if(this.dsVozila1.Vozila.Rows.Count>0)
			{
				DataGridCell selectedCell = dgVozila.CurrentCell;
				object o1 = dgVozila[selectedCell.RowNumber, 1];
				object o2 = dgVozila[selectedCell.RowNumber, 2];
				string Proizvodjac = Convert.ToString(o1);
				string Model = Convert.ToString(o2);
				
				if(MessageBox.Show("Da li ste sigurni da želite izbrisati podatke o vozilu: \nProizvodjac: "+Proizvodjac+" \nModel: "+Model+"","Upozorenje !",MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes)
				{
					System.Windows.Forms.DataGridCell celija = this.dgVozila.CurrentCell;
					object B0=this.dgVozila[celija.RowNumber, 0];
					string VoziloID=Convert.ToString(B0);

					try
					{
						//this.connVozila.Open();
						SqlCommand kom = new SqlCommand("DELETE FROM Vozila WHERE VoziloID = "+VoziloID+"", clsKonekcija.GetConnection());
						kom.ExecuteNonQuery();
						//this.connVozila.Close();

						this.dsVozila1.Clear();
						this.daVozila.Fill(this.dsVozila1);
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

		private void duOsvjezi_Click(object sender, System.EventArgs e)
		{
			this.dsVozila1.Clear();
			this.daVozila.Fill(this.dsVozila1);
						
		}

		private void duZatvori_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void frmVozila_Load(object sender, System.EventArgs e)
		{
			if (this.broj == 1)
			{
				this.duOdaberi.Location = new System.Drawing.Point(12, 32);
				this.duZatvori.Location = new System.Drawing.Point(12, 72);
				this.duOsvjezi.Location = new System.Drawing.Point(12, 120);
				this.gbOpcije.Size = new Size(136, 120);								
			}

			this.dsVozila1.Clear();
			this.sqlSelectCommand1.Connection = clsKonekcija.GetConnection();
			this.daVozila.Fill(this.dsVozila1);
		}	

		private void duOdaberi_Click(object sender, System.EventArgs e)
		{
			DataGridCell celija = this.dgVozila.CurrentCell;
			
			object I0=this.dgVozila[celija.RowNumber, 0];
			object I1=this.dgVozila[celija.RowNumber, 2];
						
			string S0 = Convert.ToString(I0);
			string S1 = Convert.ToString(I1);
							
			d.UnesiVozilo(S0, S1);

			this.Close();
		}

		private void duOdstampaj_Click(object sender, System.EventArgs e)
		{
			frmIzvjVozila i = new frmIzvjVozila();
			i.ShowDialog();
		}

		private void dgVozila_DoubleClick(object sender, System.EventArgs e)
		{
            duIzmjeni_Click(sender, e);          
        }

		private void duPretraga_Click(object sender, System.EventArgs e)
		{
			if (this.tbVrijednost.Text=="" && this.tbVrijednost1.Text=="")
			{
				MessageBox.Show("Niste unijeli vrijednost za pretragu!","Upozorenje",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
				this.dsVozila1.Clear();
				this.daVozila.Fill(this.dsVozila1);
			}
			else
			{
				try
				{
					//OVAKO
					SqlDataAdapter cmdAdapter = new SqlDataAdapter();
					cmdAdapter.SelectCommand =new SqlCommand("SELECT * FROM Vozila WHERE("+cbPolje.SelectedItem+")LIKE('" + tbVrijednost.Text + "%') AND ("+cbPolje1.SelectedItem+")LIKE('" + tbVrijednost1.Text + "%') ORDER BY VoziloID;", clsKonekcija.GetConnection());
					cmdAdapter.SelectCommand.CommandType = CommandType.Text;

					//this.connVozila.Open();
					this.dsVozila1.Clear();
					cmdAdapter.Fill(this.dsVozila1,"Vozila");
					//this.connVozila.Close();
					

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
        }

        private void cbPolje1_SelectedValueChanged(object sender, EventArgs e)
        {
            this.lbVrijednost1.Text = this.cbPolje1.Text + ":";
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
