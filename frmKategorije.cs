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
	/// Summary description for frmKategorije.
	/// </summary>
	public class frmKategorije : System.Windows.Forms.Form
	{
		private System.Data.SqlClient.SqlConnection connKategorije;
		private System.Data.SqlClient.SqlDataAdapter daKategorije;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
		private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
		private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
		private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
        private AutoSkola.DSetovi.dsKategorije dsKategorije1;
		private System.Windows.Forms.GroupBox gbOpcije;
		private System.Windows.Forms.Button duOdaberi;
		private System.Windows.Forms.Button duZatvori;
		private System.Windows.Forms.Button duIzbrisi;
		private System.Windows.Forms.Button duOsvjezi;
		private System.Windows.Forms.Button duIzmjeni;
		private System.Windows.Forms.Button duNovi;
		private System.Windows.Forms.DataGrid dgKategorije;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		//Objekat koji se koristi kod preklopljenog konstruktora
		frmInstruktoriUnos f;
		
		//Objekat koji se koristi kod preklopljenog konstruktora
		frmKandidatiUnos k;

		//Objekat koji se koristi kod preklopljenog konstruktora
		frmPolaganjaUnos p;

		//Objekat koji se koristi kod preklopljenog konstruktora
		frmDnevnikUnos d;
		
		private System.Windows.Forms.Button duOdaberiKand;
		private System.Windows.Forms.Button duOdaberiPolaga;
		private System.Windows.Forms.Button duOdaberiDnevnik;
		private System.Windows.Forms.DataGridTableStyle dgTableStyleKategorije;
		private System.Windows.Forms.DataGridTextBoxColumn KategorijaID;
		private System.Windows.Forms.DataGridTextBoxColumn Kategorija1;
				
		int broj = 0;
		
		public frmKategorije()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			this.daKategorije.Fill(this.dsKategorije1);

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		private static frmKategorije kategorija = null;
		public static frmKategorije Instance()
		{
			if (kategorija == null) { kategorija = new frmKategorije(); }

			return kategorija;
		}

		//Preklopljeni konstruktor sa argumentom tipa frmInstruktoriUnos
		public frmKategorije(frmInstruktoriUnos fr1)
		{
			InitializeComponent();
			f = new frmInstruktoriUnos();
			f = fr1;
		}

		//Preklopljeni konstruktor sa argumentom tipa frmKandidatiUnos
		public frmKategorije(frmKandidatiUnos fr2)
		{
			InitializeComponent();
			k = new frmKandidatiUnos();
			k = fr2;
		}

		//Preklopljeni konstruktor sa argumentom tipa frmKandidatiUnos
		public frmKategorije(frmPolaganjaUnos fr3)
		{
			InitializeComponent();
			p = new frmPolaganjaUnos();
			p = fr3;
		}

		//Preklopljeni konstruktor sa argumentom tipa frmDnevnikUnos
		public frmKategorije(frmDnevnikUnos fr4)
		{
			InitializeComponent();
			d = new frmDnevnikUnos();
			d = fr4;
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

			kategorija = null;
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKategorije));
            this.connKategorije = new System.Data.SqlClient.SqlConnection();
            this.daKategorije = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
            this.dsKategorije1 = new AutoSkola.DSetovi.dsKategorije();
            this.gbOpcije = new System.Windows.Forms.GroupBox();
            this.duOdaberiDnevnik = new System.Windows.Forms.Button();
            this.duOdaberiPolaga = new System.Windows.Forms.Button();
            this.duOdaberiKand = new System.Windows.Forms.Button();
            this.duOdaberi = new System.Windows.Forms.Button();
            this.duZatvori = new System.Windows.Forms.Button();
            this.duIzbrisi = new System.Windows.Forms.Button();
            this.duOsvjezi = new System.Windows.Forms.Button();
            this.duIzmjeni = new System.Windows.Forms.Button();
            this.duNovi = new System.Windows.Forms.Button();
            this.dgKategorije = new System.Windows.Forms.DataGrid();
            this.dgTableStyleKategorije = new System.Windows.Forms.DataGridTableStyle();
            this.KategorijaID = new System.Windows.Forms.DataGridTextBoxColumn();
            this.Kategorija1 = new System.Windows.Forms.DataGridTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dsKategorije1)).BeginInit();
            this.gbOpcije.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgKategorije)).BeginInit();
            this.SuspendLayout();
            // 
            // connKategorije
            // 
            this.connKategorije.ConnectionString = "Data Source=(local);Initial Catalog=baza;integrated security=SSPI";
            this.connKategorije.FireInfoMessageEventOnUserErrors = false;
            // 
            // daKategorije
            // 
            this.daKategorije.DeleteCommand = this.sqlDeleteCommand1;
            this.daKategorije.InsertCommand = this.sqlInsertCommand1;
            this.daKategorije.SelectCommand = this.sqlSelectCommand1;
            this.daKategorije.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Kategorije", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("KategorijaID", "KategorijaID"),
                        new System.Data.Common.DataColumnMapping("Kategorija", "Kategorija")})});
            this.daKategorije.UpdateCommand = this.sqlUpdateCommand1;
            // 
            // sqlDeleteCommand1
            // 
            this.sqlDeleteCommand1.CommandText = "DELETE FROM Kategorije WHERE (KategorijaID = @Original_KategorijaID) AND (Kategor" +
                "ija = @Original_Kategorija OR @Original_Kategorija IS NULL AND Kategorija IS NUL" +
                "L)";
            this.sqlDeleteCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_KategorijaID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "KategorijaID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Kategorija", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Kategorija", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlInsertCommand1
            // 
            this.sqlInsertCommand1.CommandText = "INSERT INTO Kategorije(Kategorija) VALUES (@Kategorija); SELECT KategorijaID, Kat" +
                "egorija FROM Kategorije WHERE (KategorijaID = @@IDENTITY) ORDER BY KategorijaID";
            this.sqlInsertCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Kategorija", System.Data.SqlDbType.VarChar, 20, "Kategorija")});
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = "SELECT KategorijaID, Kategorija FROM Kategorije ORDER BY KategorijaID";
            this.sqlSelectCommand1.Connection = this.connKategorije;
            // 
            // sqlUpdateCommand1
            // 
            this.sqlUpdateCommand1.CommandText = resources.GetString("sqlUpdateCommand1.CommandText");
            this.sqlUpdateCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Kategorija", System.Data.SqlDbType.VarChar, 20, "Kategorija"),
            new System.Data.SqlClient.SqlParameter("@Original_KategorijaID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "KategorijaID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Kategorija", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Kategorija", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@KategorijaID", System.Data.SqlDbType.Int, 4, "KategorijaID")});
            // 
            // dsKategorije1
            // 
            this.dsKategorije1.DataSetName = "dsKategorije";
            this.dsKategorije1.Locale = new System.Globalization.CultureInfo("hr-HR");
            this.dsKategorije1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gbOpcije
            // 
            this.gbOpcije.Controls.Add(this.duZatvori);
            this.gbOpcije.Controls.Add(this.duOdaberiDnevnik);
            this.gbOpcije.Controls.Add(this.duOdaberiPolaga);
            this.gbOpcije.Controls.Add(this.duOdaberiKand);
            this.gbOpcije.Controls.Add(this.duOdaberi);
            this.gbOpcije.Controls.Add(this.duIzbrisi);
            this.gbOpcije.Controls.Add(this.duOsvjezi);
            this.gbOpcije.Controls.Add(this.duIzmjeni);
            this.gbOpcije.Controls.Add(this.duNovi);
            this.gbOpcije.Location = new System.Drawing.Point(157, 9);
            this.gbOpcije.Name = "gbOpcije";
            this.gbOpcije.Size = new System.Drawing.Size(136, 231);
            this.gbOpcije.TabIndex = 3;
            this.gbOpcije.TabStop = false;
            // 
            // duOdaberiDnevnik
            // 
            this.duOdaberiDnevnik.BackColor = System.Drawing.Color.Beige;
            this.duOdaberiDnevnik.Cursor = System.Windows.Forms.Cursors.Hand;
            this.duOdaberiDnevnik.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.duOdaberiDnevnik.Image = ((System.Drawing.Image)(resources.GetObject("duOdaberiDnevnik.Image")));
            this.duOdaberiDnevnik.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.duOdaberiDnevnik.Location = new System.Drawing.Point(12, 184);
            this.duOdaberiDnevnik.Name = "duOdaberiDnevnik";
            this.duOdaberiDnevnik.Size = new System.Drawing.Size(112, 32);
            this.duOdaberiDnevnik.TabIndex = 8;
            this.duOdaberiDnevnik.Text = "   Odaberi";
            this.duOdaberiDnevnik.UseVisualStyleBackColor = false;
            this.duOdaberiDnevnik.Click += new System.EventHandler(this.duOdaberiDnevnik_Click);
            // 
            // duOdaberiPolaga
            // 
            this.duOdaberiPolaga.BackColor = System.Drawing.Color.Beige;
            this.duOdaberiPolaga.Cursor = System.Windows.Forms.Cursors.Hand;
            this.duOdaberiPolaga.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.duOdaberiPolaga.Image = ((System.Drawing.Image)(resources.GetObject("duOdaberiPolaga.Image")));
            this.duOdaberiPolaga.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.duOdaberiPolaga.Location = new System.Drawing.Point(12, 184);
            this.duOdaberiPolaga.Name = "duOdaberiPolaga";
            this.duOdaberiPolaga.Size = new System.Drawing.Size(112, 32);
            this.duOdaberiPolaga.TabIndex = 7;
            this.duOdaberiPolaga.Text = "   Odaberi";
            this.duOdaberiPolaga.UseVisualStyleBackColor = false;
            this.duOdaberiPolaga.Click += new System.EventHandler(this.duOdaberiPolaga_Click);
            // 
            // duOdaberiKand
            // 
            this.duOdaberiKand.BackColor = System.Drawing.Color.Beige;
            this.duOdaberiKand.Cursor = System.Windows.Forms.Cursors.Hand;
            this.duOdaberiKand.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.duOdaberiKand.Image = ((System.Drawing.Image)(resources.GetObject("duOdaberiKand.Image")));
            this.duOdaberiKand.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.duOdaberiKand.Location = new System.Drawing.Point(12, 184);
            this.duOdaberiKand.Name = "duOdaberiKand";
            this.duOdaberiKand.Size = new System.Drawing.Size(112, 32);
            this.duOdaberiKand.TabIndex = 6;
            this.duOdaberiKand.Text = "   Odaberi";
            this.duOdaberiKand.UseVisualStyleBackColor = false;
            // 
            // duOdaberi
            // 
            this.duOdaberi.BackColor = System.Drawing.Color.Beige;
            this.duOdaberi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.duOdaberi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.duOdaberi.Image = ((System.Drawing.Image)(resources.GetObject("duOdaberi.Image")));
            this.duOdaberi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.duOdaberi.Location = new System.Drawing.Point(12, 184);
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
            this.duZatvori.Location = new System.Drawing.Point(12, 184);
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
            this.duIzbrisi.Location = new System.Drawing.Point(12, 144);
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
            this.duOsvjezi.Location = new System.Drawing.Point(12, 104);
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
            this.duIzmjeni.Location = new System.Drawing.Point(12, 64);
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
            this.duNovi.Location = new System.Drawing.Point(12, 24);
            this.duNovi.Name = "duNovi";
            this.duNovi.Size = new System.Drawing.Size(112, 32);
            this.duNovi.TabIndex = 0;
            this.duNovi.Text = "       Dodaj novi";
            this.duNovi.UseVisualStyleBackColor = false;
            this.duNovi.Click += new System.EventHandler(this.duNovi_Click);
            // 
            // dgKategorije
            // 
            this.dgKategorije.DataMember = "";
            this.dgKategorije.DataSource = this.dsKategorije1.Kategorije;
            this.dgKategorije.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dgKategorije.Location = new System.Drawing.Point(12, 15);
            this.dgKategorije.Name = "dgKategorije";
            this.dgKategorije.PreferredColumnWidth = 80;
            this.dgKategorije.ReadOnly = true;
            this.dgKategorije.Size = new System.Drawing.Size(135, 225);
            this.dgKategorije.TabIndex = 4;
            this.dgKategorije.TableStyles.AddRange(new System.Windows.Forms.DataGridTableStyle[] {
            this.dgTableStyleKategorije});
            // 
            // dgTableStyleKategorije
            // 
            this.dgTableStyleKategorije.DataGrid = this.dgKategorije;
            this.dgTableStyleKategorije.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {
            this.KategorijaID,
            this.Kategorija1});
            this.dgTableStyleKategorije.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dgTableStyleKategorije.MappingName = "Kategorije";
            // 
            // KategorijaID
            // 
            this.KategorijaID.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.KategorijaID.Format = "";
            this.KategorijaID.FormatInfo = null;
            this.KategorijaID.HeaderText = "ID";
            this.KategorijaID.MappingName = "KategorijaID";
            this.KategorijaID.Width = 0;
            // 
            // Kategorija1
            // 
            this.Kategorija1.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.Kategorija1.Format = "";
            this.Kategorija1.FormatInfo = null;
            this.Kategorija1.HeaderText = "Kategorija";
            this.Kategorija1.MappingName = "Kategorija";
            this.Kategorija1.Width = 75;
            // 
            // frmKategorije
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 15);
            this.ClientSize = new System.Drawing.Size(303, 248);
            this.Controls.Add(this.dgKategorije);
            this.Controls.Add(this.gbOpcije);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(311, 288);
            this.Name = "frmKategorije";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kategorije";
            this.Load += new System.EventHandler(this.frmKategorije_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsKategorije1)).EndInit();
            this.gbOpcije.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgKategorije)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		public void uzmiBroj(int b)
		{
			broj = b;
		}
		
		/*
		public void unosKategorije(int b)
		{
			unosKat = b;
		}
		*/

		private void duOdaberi_Click(object sender, System.EventArgs e)
		{							
			//Unos podataka o kategoriji: ID, Kategorija u formu Instruktori
			DataGridCell celija = this.dgKategorije.CurrentCell;
			
			object I0=this.dgKategorije[celija.RowNumber, 0];
			object I1=this.dgKategorije[celija.RowNumber, 1];
			
			string S0 = Convert.ToString(I0);
			string S1 = Convert.ToString(I1);

			f.UnesiKategoriju(S0, S1);
						
			this.Close();
		}

		private void frmKategorije_Load(object sender, System.EventArgs e)
		{
			this.duOdaberiPolaga.Location = new System.Drawing.Point(12, 235);
			this.duOdaberiKand.Location = new System.Drawing.Point(12, 235);
			this.duOdaberi.Location = new System.Drawing.Point(12, 235);
			this.duOdaberiDnevnik.Location = new System.Drawing.Point(12, 235);
			this.duZatvori.Location = new System.Drawing.Point(12, 184);
			this.gbOpcije.Size = new Size(136, 231);
			
			if (this.broj == 1)
			{
				this.duOdaberi.Location = new System.Drawing.Point(12, 24);
				this.duZatvori.Location = new System.Drawing.Point(12, 64);
				this.duOsvjezi.Location = new System.Drawing.Point(12, 120);
				this.gbOpcije.Size = new Size(136, 111);
				
				/*this.duOdaberiKand.Hide();
				this.duOdaberiPolaga.Visible = false;*/
			}

			else if (this.broj == 2)
			{
				this.duOdaberiKand.Location = new System.Drawing.Point(12, 24);
				this.duZatvori.Location = new System.Drawing.Point(12, 64);
				this.duOsvjezi.Location = new System.Drawing.Point(12, 120);
				this.gbOpcije.Size = new Size(136, 111);
				
				/*this.duOdaberi.Location = new System.Drawing.Point(136, 184);
				this.duOdaberiPolaga.Location= new System.Drawing.Point(136, 184);*/
			}

			else if (this.broj == 3)
			{
				this.duOdaberiPolaga.Location = new System.Drawing.Point(12, 24);
				this.duZatvori.Location = new System.Drawing.Point(12, 64);
				this.duOsvjezi.Location = new System.Drawing.Point(12, 120);
				this.gbOpcije.Size = new Size(136, 111);
				
				/*this.duOdaberi.Visible = false;
				this.duOdaberiKand.Location= new System.Drawing.Point(136, 184);*/
			}

			else if (this.broj == 4)
			{
				this.duOdaberiDnevnik.Location = new System.Drawing.Point(12, 24);
				this.duZatvori.Location = new System.Drawing.Point(12, 64);
				this.duOsvjezi.Location = new System.Drawing.Point(12, 120);
				this.gbOpcije.Size = new Size(136, 111);

				/*this.duOdaberi.Location = new System.Drawing.Point(136, 184);
				this.duOdaberiPolaga.Location= new System.Drawing.Point(136, 184);
				this.duOdaberiKand.Location= new System.Drawing.Point(136, 184); */
			}			
			
			this.dsKategorije1.Clear();
			this.daKategorije.Fill(this.dsKategorije1);
		}

		/*private void duOdaberiKand_Click(object sender, System.EventArgs e)
		{
			DataGridCell celija = this.dgKategorije.CurrentCell;
			
			object I0=this.dgKategorije[celija.RowNumber, 0];
			object I1=this.dgKategorije[celija.RowNumber, 1];
			
			string S0 = Convert.ToString(I0);
			string S1 = Convert.ToString(I1);
				
			k.UnesiKategoriju(S0, S1);

			this.Close();
		}*/

		private void duOdaberiPolaga_Click(object sender, System.EventArgs e)
		{
			DataGridCell celija = this.dgKategorije.CurrentCell;
			
			object I0=this.dgKategorije[celija.RowNumber, 0];
			object I1=this.dgKategorije[celija.RowNumber, 1];
			
			string S0 = Convert.ToString(I0);
			string S1 = Convert.ToString(I1);
				
			p.UnesiKategoriju(S0, S1);

			this.Close();
		}

		private void duZatvori_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void duNovi_Click(object sender, System.EventArgs e)
		{
			clsKategorije kategorija = new clsKategorije();
			frmKategorijeUnos dodaj = new frmKategorijeUnos();
			dodaj.uzmiPodatke(kategorija,1);
			//dodaj.ShowDialog();

            if (dodaj.ShowDialog() == DialogResult.OK)
            {
                duOsvjezi_Click(sender, e);
            }
		}

		private void duIzmjeni_Click(object sender, System.EventArgs e)
		{
			if(this.dsKategorije1.Kategorije.Rows.Count>0)
			{
				//Odabir trenutno oznacene celije
				DataGridCell celija = this.dgKategorije.CurrentCell;
				//Odabir podataka iz trenutne celije na pozicijama kolona od 0 i 7 
				object I0=this.dgKategorije[celija.RowNumber, 0];
				object I1=this.dgKategorije[celija.RowNumber, 1];
								
				//Kreiranje novog objekta klase clsKategorije
				clsKategorije kategorija = new clsKategorije();
				
				//Konvertovanje objekata I0 do I7 u stringove i 
				//proslijedivanje u varijable iz clsVarijable
				kategorija.KategorijaID = Convert.ToString(I0);
				kategorija.Kategorija = Convert.ToString(I1);
								
				//Kreiranje objekta izmjeni klase frmKategorijeUnos
				frmKategorijeUnos izmjeni = new frmKategorijeUnos();
				//Poziv funkcije uzmiPodatke za objekat izmjeni
				izmjeni.uzmiPodatke(kategorija,2);
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

		private void duOsvjezi_Click(object sender, System.EventArgs e)
		{
			this.dsKategorije1.Clear();
			this.daKategorije.Fill(this.dsKategorije1);

			this.connKategorije.Close();
		}

		private void duIzbrisi_Click(object sender, System.EventArgs e)
		{
			//Ako data set dsInstruktori nije prazan
			if(this.dsKategorije1.Kategorije.Rows.Count>0)
			{
				//Odabir trenutno oznacene celije
				DataGridCell selectedCell = dgKategorije.CurrentCell;
				//Odabir podataka iz trenutne celije na poziciji kolona 1 i 2 
				object o1 = dgKategorije[selectedCell.RowNumber, 0];
				object o2 = dgKategorije[selectedCell.RowNumber, 1];
				
				//Konvertovanje objekata o1 i o2 u stringove
				string KategorijaID = Convert.ToString(o1);
				string Kategorija = Convert.ToString(o2);
				
				//Prikaz dijalog boksa sa pitanjem, ako je rezultat opcija Yes
				//Onda izbriši odabrani zapis
				if(MessageBox.Show("Da li ste sigurni da želite izbrisati podatke o kategoriji: \nKategorija ID: "+KategorijaID+" \nKategorija: "+Kategorija+"","Upozorenje !",MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes)
				{
					System.Windows.Forms.DataGridCell celija = this.dgKategorije.CurrentCell;
					object B0=this.dgKategorije[celija.RowNumber, 0];
					string KatID=Convert.ToString(B0);

					try
					{

						this.connKategorije.Open();
						SqlCommand kom = new SqlCommand("DELETE FROM Kategorije WHERE KategorijaID = "+KatID+"",this.connKategorije);
						kom.ExecuteNonQuery();
						this.connKategorije.Close();

						this.dsKategorije1.Clear();
						this.daKategorije.Fill(this.dsKategorije1);
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

		private void duOdaberiDnevnik_Click(object sender, System.EventArgs e)
		{
			DataGridCell celija = this.dgKategorije.CurrentCell;
			
			object I0=this.dgKategorije[celija.RowNumber, 0];
			object I1=this.dgKategorije[celija.RowNumber, 1];
			
			string S0 = Convert.ToString(I0);
			string S1 = Convert.ToString(I1);
				
			d.UnesiKategoriju(S0, S1);

			this.Close();
		}
	}
}
