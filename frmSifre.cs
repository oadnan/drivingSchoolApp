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
	/// Summary description for frmSifre.
	/// </summary>
	public class frmSifre : System.Windows.Forms.Form
	{
		private System.Windows.Forms.GroupBox gbOpcije;
		private System.Windows.Forms.Button duOdaberiKand;
		private System.Windows.Forms.Button duOdaberi;
		private System.Windows.Forms.Button duZatvori;
		private System.Windows.Forms.Button duIzbrisi;
		private System.Windows.Forms.Button duOsvjezi;
		private System.Windows.Forms.Button duIzmjeni;
		private System.Windows.Forms.Button duNovi;
		private System.Windows.Forms.DataGrid dgSifre;
		private System.Data.SqlClient.SqlConnection connSifre;
		private System.Data.SqlClient.SqlDataAdapter daSifre;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
		private System.Windows.Forms.Button duOdaberiPolaga;
		private System.Windows.Forms.DataGridTableStyle dgTableStyleSifre;
		private System.Windows.Forms.DataGridTextBoxColumn SifraID;
		private System.Windows.Forms.DataGridTextBoxColumn KorisnickoIme;
		private System.Windows.Forms.DataGridTextBoxColumn Sifra1;
        private SqlCommand sqlDeleteCommand;
        private SqlCommand sqlInsertCommand;
        private SqlCommand sqlUpdateCommand;
        private DataGridTextBoxColumn Tip;
        private AutoSkola.DSetovi.dsSifre dsSifre1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmSifre()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			this.sqlSelectCommand1.Connection = clsKonekcija.GetConnection();
            
			this.daSifre.Fill(this.dsSifre1);
			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		private static frmSifre sifra = null;
		public static frmSifre Instance()
		{
			if (sifra == null) { sifra = new frmSifre(); }

			return sifra;
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

			sifra = null;
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSifre));
            this.gbOpcije = new System.Windows.Forms.GroupBox();
            this.duOdaberiPolaga = new System.Windows.Forms.Button();
            this.duOdaberiKand = new System.Windows.Forms.Button();
            this.duOdaberi = new System.Windows.Forms.Button();
            this.duZatvori = new System.Windows.Forms.Button();
            this.duIzbrisi = new System.Windows.Forms.Button();
            this.duOsvjezi = new System.Windows.Forms.Button();
            this.duIzmjeni = new System.Windows.Forms.Button();
            this.duNovi = new System.Windows.Forms.Button();
            this.connSifre = new System.Data.SqlClient.SqlConnection();
            this.daSifre = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlDeleteCommand = new System.Data.SqlClient.SqlCommand();
            this.sqlInsertCommand = new System.Data.SqlClient.SqlCommand();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand = new System.Data.SqlClient.SqlCommand();
            this.dgSifre = new System.Windows.Forms.DataGrid();
            this.dsSifre1 = new AutoSkola.DSetovi.dsSifre();
            this.dgTableStyleSifre = new System.Windows.Forms.DataGridTableStyle();
            this.SifraID = new System.Windows.Forms.DataGridTextBoxColumn();
            this.KorisnickoIme = new System.Windows.Forms.DataGridTextBoxColumn();
            this.Sifra1 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.Tip = new System.Windows.Forms.DataGridTextBoxColumn();
            this.gbOpcije.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSifre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSifre1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbOpcije
            // 
            this.gbOpcije.Controls.Add(this.duOdaberiPolaga);
            this.gbOpcije.Controls.Add(this.duOdaberiKand);
            this.gbOpcije.Controls.Add(this.duOdaberi);
            this.gbOpcije.Controls.Add(this.duZatvori);
            this.gbOpcije.Controls.Add(this.duIzbrisi);
            this.gbOpcije.Controls.Add(this.duOsvjezi);
            this.gbOpcije.Controls.Add(this.duIzmjeni);
            this.gbOpcije.Controls.Add(this.duNovi);
            this.gbOpcije.Location = new System.Drawing.Point(344, 8);
            this.gbOpcije.Name = "gbOpcije";
            this.gbOpcije.Size = new System.Drawing.Size(136, 232);
            this.gbOpcije.TabIndex = 4;
            this.gbOpcije.TabStop = false;
            // 
            // duOdaberiPolaga
            // 
            this.duOdaberiPolaga.BackColor = System.Drawing.Color.Beige;
            this.duOdaberiPolaga.Cursor = System.Windows.Forms.Cursors.Hand;
            this.duOdaberiPolaga.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.duOdaberiPolaga.Image = ((System.Drawing.Image)(resources.GetObject("duOdaberiPolaga.Image")));
            this.duOdaberiPolaga.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.duOdaberiPolaga.Location = new System.Drawing.Point(12, 232);
            this.duOdaberiPolaga.Name = "duOdaberiPolaga";
            this.duOdaberiPolaga.Size = new System.Drawing.Size(112, 32);
            this.duOdaberiPolaga.TabIndex = 7;
            this.duOdaberiPolaga.Text = "   Odaberi";
            this.duOdaberiPolaga.UseVisualStyleBackColor = false;
            // 
            // duOdaberiKand
            // 
            this.duOdaberiKand.BackColor = System.Drawing.Color.Beige;
            this.duOdaberiKand.Cursor = System.Windows.Forms.Cursors.Hand;
            this.duOdaberiKand.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.duOdaberiKand.Image = ((System.Drawing.Image)(resources.GetObject("duOdaberiKand.Image")));
            this.duOdaberiKand.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.duOdaberiKand.Location = new System.Drawing.Point(12, 232);
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
            this.duOdaberi.Location = new System.Drawing.Point(12, 232);
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
            // connSifre
            // 
            this.connSifre.ConnectionString = "Data Source=(local);Initial Catalog=baza;integrated security=SSPI";
            this.connSifre.FireInfoMessageEventOnUserErrors = false;
            // 
            // daSifre
            // 
            this.daSifre.DeleteCommand = this.sqlDeleteCommand;
            this.daSifre.InsertCommand = this.sqlInsertCommand;
            this.daSifre.SelectCommand = this.sqlSelectCommand1;
            this.daSifre.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Sifre", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("SifraID", "SifraID"),
                        new System.Data.Common.DataColumnMapping("KorisnickoIme", "KorisnickoIme"),
                        new System.Data.Common.DataColumnMapping("Sifra", "Sifra"),
                        new System.Data.Common.DataColumnMapping("Tip", "Tip")})});
            this.daSifre.UpdateCommand = this.sqlUpdateCommand;
            // 
            // sqlDeleteCommand
            // 
            this.sqlDeleteCommand.CommandText = resources.GetString("sqlDeleteCommand.CommandText");
            this.sqlDeleteCommand.Connection = this.connSifre;
            this.sqlDeleteCommand.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_SifraID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "SifraID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_KorisnickoIme", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "KorisnickoIme", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_KorisnickoIme", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "KorisnickoIme", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Sifra", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Sifra", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Sifra", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Sifra", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Tip", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Tip", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Tip", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Tip", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlInsertCommand
            // 
            this.sqlInsertCommand.CommandText = "INSERT INTO [Sifre] ([KorisnickoIme], [Sifra], [Tip]) VALUES (@KorisnickoIme, @Si" +
                "fra, @Tip);\r\nSELECT SifraID, KorisnickoIme, Sifra, Tip FROM Sifre WHERE (SifraID" +
                " = SCOPE_IDENTITY()) ORDER BY SifraID";
            this.sqlInsertCommand.Connection = this.connSifre;
            this.sqlInsertCommand.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@KorisnickoIme", System.Data.SqlDbType.VarChar, 0, "KorisnickoIme"),
            new System.Data.SqlClient.SqlParameter("@Sifra", System.Data.SqlDbType.VarChar, 0, "Sifra"),
            new System.Data.SqlClient.SqlParameter("@Tip", System.Data.SqlDbType.VarChar, 0, "Tip")});
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = "SELECT SifraID, KorisnickoIme, Sifra, Tip FROM  Sifre ORDER BY SifraID";
            // 
            // sqlUpdateCommand
            // 
            this.sqlUpdateCommand.CommandText = resources.GetString("sqlUpdateCommand.CommandText");
            this.sqlUpdateCommand.Connection = this.connSifre;
            this.sqlUpdateCommand.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@KorisnickoIme", System.Data.SqlDbType.VarChar, 0, "KorisnickoIme"),
            new System.Data.SqlClient.SqlParameter("@Sifra", System.Data.SqlDbType.VarChar, 0, "Sifra"),
            new System.Data.SqlClient.SqlParameter("@Tip", System.Data.SqlDbType.VarChar, 0, "Tip"),
            new System.Data.SqlClient.SqlParameter("@Original_SifraID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "SifraID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_KorisnickoIme", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "KorisnickoIme", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_KorisnickoIme", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "KorisnickoIme", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Sifra", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Sifra", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Sifra", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Sifra", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Tip", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Tip", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Tip", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Tip", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@SifraID", System.Data.SqlDbType.Int, 4, "SifraID")});
            // 
            // dgSifre
            // 
            this.dgSifre.DataMember = "";
            this.dgSifre.DataSource = this.dsSifre1.Sifre;
            this.dgSifre.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dgSifre.Location = new System.Drawing.Point(12, 14);
            this.dgSifre.Name = "dgSifre";
            this.dgSifre.PreferredColumnWidth = 80;
            this.dgSifre.ReadOnly = true;
            this.dgSifre.Size = new System.Drawing.Size(320, 226);
            this.dgSifre.TabIndex = 5;
            this.dgSifre.TableStyles.AddRange(new System.Windows.Forms.DataGridTableStyle[] {
            this.dgTableStyleSifre});
            // 
            // dsSifre1
            // 
            this.dsSifre1.DataSetName = "dsSifre";
            this.dsSifre1.Locale = new System.Globalization.CultureInfo("hr-HR");
            this.dsSifre1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dgTableStyleSifre
            // 
            this.dgTableStyleSifre.DataGrid = this.dgSifre;
            this.dgTableStyleSifre.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {
            this.SifraID,
            this.KorisnickoIme,
            this.Sifra1,
            this.Tip});
            this.dgTableStyleSifre.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dgTableStyleSifre.MappingName = "Sifre";
            // 
            // SifraID
            // 
            this.SifraID.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.SifraID.Format = "";
            this.SifraID.FormatInfo = null;
            this.SifraID.HeaderText = "ID";
            this.SifraID.MappingName = "SifraID";
            this.SifraID.Width = 0;
            // 
            // KorisnickoIme
            // 
            this.KorisnickoIme.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.KorisnickoIme.Format = "";
            this.KorisnickoIme.FormatInfo = null;
            this.KorisnickoIme.HeaderText = "Korisnicko Ime";
            this.KorisnickoIme.MappingName = "KorisnickoIme";
            this.KorisnickoIme.Width = 95;
            // 
            // Sifra1
            // 
            this.Sifra1.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.Sifra1.Format = "";
            this.Sifra1.FormatInfo = null;
            this.Sifra1.HeaderText = "Šifra";
            this.Sifra1.MappingName = "Sifra";
            this.Sifra1.Width = 80;
            // 
            // Tip
            // 
            this.Tip.Format = "";
            this.Tip.FormatInfo = null;
            this.Tip.HeaderText = "Tip korisnika";
            this.Tip.MappingName = "Tip";
            this.Tip.Width = 85;
            // 
            // frmSifre
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 15);
            this.ClientSize = new System.Drawing.Size(489, 251);
            this.Controls.Add(this.dgSifre);
            this.Controls.Add(this.gbOpcije);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(497, 291);
            this.Name = "frmSifre";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pristupni podaci";
            this.gbOpcije.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgSifre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSifre1)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		private void duNovi_Click(object sender, System.EventArgs e)
		{
			clsSifre sifra = new clsSifre();
			frmSifreUnos dodaj = new frmSifreUnos();
			dodaj.uzmiPodatke(sifra,1);
			//dodaj.ShowDialog();

            if (dodaj.ShowDialog() == DialogResult.OK)
            {
                duOsvjezi_Click(sender, e);
            }
		}

		private void duIzmjeni_Click(object sender, System.EventArgs e)
		{
			if(this.dsSifre1.Sifre.Rows.Count>0)
			{
				//Odabir trenutno oznacene celije
				DataGridCell celija = this.dgSifre.CurrentCell;
				//Odabir podataka iz trenutne celije na pozicijama kolona od 0 i 7 
				object I0 = this.dgSifre[celija.RowNumber, 0];
				object I1 = this.dgSifre[celija.RowNumber, 1];
				object I2 = this.dgSifre[celija.RowNumber, 2];
                object I3 = this.dgSifre[celija.RowNumber, 3];
				
				//Kreiranje novog objekta klase clsSifre
				clsSifre sifra = new clsSifre();
				
				//Konvertovanje objekata I0 do I3 u stringove i 
				//proslijedivanje u varijable iz clsVarijable
				sifra.SifraID = Convert.ToString(I0);
				sifra.KorisnickoIme = Convert.ToString(I1);
				sifra.Sifra = Convert.ToString(I2);
                sifra.Tip = Convert.ToString(I3);
				
				//Kreiranje objekta izmjeni klase frmSifreUnos
				frmSifreUnos izmjeni = new frmSifreUnos();

				//Poziv funkcije uzmiPodatke za objekat izmjeni				
                izmjeni.uzmiPodatke(sifra, 2);
				
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

		private void duOsvjezi_Click(object sender, System.EventArgs e)
		{
			this.dsSifre1.Clear();
			this.daSifre.Fill(this.dsSifre1);
			//this.connSifre.Close();
		}

		private void duIzbrisi_Click(object sender, System.EventArgs e)
		{
			//Ako data set dsInstruktori nije prazan
			if(this.dsSifre1.Sifre.Rows.Count>0)
			{
				//Odabir trenutno oznacene celije
				DataGridCell selectedCell = dgSifre.CurrentCell;
				//Odabir podataka iz trenutne celije na poziciji kolona 1 i 2 
				object o1 = dgSifre[selectedCell.RowNumber, 1];
				object o2 = dgSifre[selectedCell.RowNumber, 2];
				
				//Konvertovanje objekata o1 i o2 u stringove
				string KorisnickoIme = Convert.ToString(o1);
				string Sifra = Convert.ToString(o2);
				
				//Prikaz dijalog boksa sa pitanjem, ako je rezultat opcija Yes
				//Onda izbriši odabrani zapis
				if(MessageBox.Show("Da li ste sigurni da želite izbrisati pristupne podatke: \nKorisnicko Ime: "+KorisnickoIme+" \nŠifra: "+Sifra+"","Upozorenje !",MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes)
				{
					System.Windows.Forms.DataGridCell celija = this.dgSifre.CurrentCell;
					object B0=this.dgSifre[celija.RowNumber, 0];
					string SifrID=Convert.ToString(B0);

					try
					{

						//this.connSifre.Open();
						SqlCommand kom = new SqlCommand("DELETE FROM Sifre WHERE SifraID = "+SifrID+"", clsKonekcija.GetConnection());
						kom.ExecuteNonQuery();
						//this.connSifre.Close();

						this.dsSifre1.Clear();
						this.daSifre.Fill(this.dsSifre1);
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
		
	}
}


