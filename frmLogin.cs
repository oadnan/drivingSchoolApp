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
	/// Summary description for frmLogin.
	/// </summary>
	public class frmLogin : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label lbSifraP;
		private System.Windows.Forms.Button duOdustani;
		private System.Windows.Forms.Button duPrijavise;
		private System.Windows.Forms.Label lbSifra;
		private System.Windows.Forms.Label lbKorisIme;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tbSifra;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
		private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
		private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
		private System.Data.SqlClient.SqlConnection connLogin;
		private System.Data.SqlClient.SqlDataAdapter daLogin;
        private AutoSkola.DSetovi.dsLogin dsLogin1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;
		private System.Windows.Forms.TextBox tbKorisnickoIme;
        private SqlCommand sqlInsertCommand;
        private Label lbTipP;

		frmGlavna forma = new frmGlavna();

		public frmLogin()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

            this.sqlSelectCommand1.Connection = clsKonekcija.GetConnection();
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.lbSifraP = new System.Windows.Forms.Label();
            this.dsLogin1 = new AutoSkola.DSetovi.dsLogin();
            this.duOdustani = new System.Windows.Forms.Button();
            this.duPrijavise = new System.Windows.Forms.Button();
            this.lbSifra = new System.Windows.Forms.Label();
            this.lbKorisIme = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbSifra = new System.Windows.Forms.TextBox();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.connLogin = new System.Data.SqlClient.SqlConnection();
            this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
            this.daLogin = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlInsertCommand = new System.Data.SqlClient.SqlCommand();
            this.tbKorisnickoIme = new System.Windows.Forms.TextBox();
            this.lbTipP = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dsLogin1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbSifraP
            // 
            this.lbSifraP.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsLogin1, "Sifre.Sifra", true));
            this.lbSifraP.Location = new System.Drawing.Point(349, 94);
            this.lbSifraP.Name = "lbSifraP";
            this.lbSifraP.Size = new System.Drawing.Size(28, 23);
            this.lbSifraP.TabIndex = 15;
            // 
            // dsLogin1
            // 
            this.dsLogin1.DataSetName = "dsLogin";
            this.dsLogin1.Locale = new System.Globalization.CultureInfo("hr-HR");
            this.dsLogin1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // duOdustani
            // 
            this.duOdustani.BackColor = System.Drawing.Color.Beige;
            this.duOdustani.Cursor = System.Windows.Forms.Cursors.Hand;
            this.duOdustani.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.duOdustani.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.duOdustani.Image = ((System.Drawing.Image)(resources.GetObject("duOdustani.Image")));
            this.duOdustani.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.duOdustani.Location = new System.Drawing.Point(211, 128);
            this.duOdustani.Name = "duOdustani";
            this.duOdustani.Size = new System.Drawing.Size(96, 32);
            this.duOdustani.TabIndex = 3;
            this.duOdustani.Text = "Odustani";
            this.duOdustani.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.duOdustani.UseVisualStyleBackColor = false;
            this.duOdustani.Click += new System.EventHandler(this.duOdustani_Click);
            // 
            // duPrijavise
            // 
            this.duPrijavise.BackColor = System.Drawing.Color.Beige;
            this.duPrijavise.Cursor = System.Windows.Forms.Cursors.Hand;
            this.duPrijavise.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.duPrijavise.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.duPrijavise.Image = ((System.Drawing.Image)(resources.GetObject("duPrijavise.Image")));
            this.duPrijavise.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.duPrijavise.Location = new System.Drawing.Point(107, 128);
            this.duPrijavise.Name = "duPrijavise";
            this.duPrijavise.Size = new System.Drawing.Size(96, 32);
            this.duPrijavise.TabIndex = 2;
            this.duPrijavise.Text = "Prijavi se";
            this.duPrijavise.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.duPrijavise.UseVisualStyleBackColor = false;
            this.duPrijavise.Click += new System.EventHandler(this.duPrijavise_Click);
            // 
            // lbSifra
            // 
            this.lbSifra.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSifra.Location = new System.Drawing.Point(11, 91);
            this.lbSifra.Name = "lbSifra";
            this.lbSifra.Size = new System.Drawing.Size(100, 23);
            this.lbSifra.TabIndex = 14;
            this.lbSifra.Text = "Šifra:";
            this.lbSifra.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbKorisIme
            // 
            this.lbKorisIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKorisIme.Location = new System.Drawing.Point(11, 51);
            this.lbKorisIme.Name = "lbKorisIme";
            this.lbKorisIme.Size = new System.Drawing.Size(100, 23);
            this.lbKorisIme.TabIndex = 13;
            this.lbKorisIme.Text = "Korisnicko ime:";
            this.lbKorisIme.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(11, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(328, 32);
            this.label1.TabIndex = 10;
            this.label1.Text = "Unesite korisnicko ime i šifru da bi ste se prijavili.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbSifra
            // 
            this.tbSifra.Location = new System.Drawing.Point(126, 91);
            this.tbSifra.Name = "tbSifra";
            this.tbSifra.PasswordChar = '•';
            this.tbSifra.Size = new System.Drawing.Size(181, 22);
            this.tbSifra.TabIndex = 1;
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = "SELECT SifraID, KorisnickoIme, Sifra, Tip FROM  Sifre";
            // 
            // connLogin
            // 
            this.connLogin.ConnectionString = "Data Source=(local);Initial Catalog=baza;integrated security=SSPI";
            this.connLogin.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlUpdateCommand1
            // 
            this.sqlUpdateCommand1.CommandText = resources.GetString("sqlUpdateCommand1.CommandText");
            this.sqlUpdateCommand1.Connection = this.connLogin;
            this.sqlUpdateCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
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
            // sqlDeleteCommand1
            // 
            this.sqlDeleteCommand1.CommandText = resources.GetString("sqlDeleteCommand1.CommandText");
            this.sqlDeleteCommand1.Connection = this.connLogin;
            this.sqlDeleteCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_SifraID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "SifraID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_KorisnickoIme", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "KorisnickoIme", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_KorisnickoIme", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "KorisnickoIme", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Sifra", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Sifra", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Sifra", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Sifra", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Tip", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Tip", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Tip", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Tip", System.Data.DataRowVersion.Original, null)});
            // 
            // daLogin
            // 
            this.daLogin.DeleteCommand = this.sqlDeleteCommand1;
            this.daLogin.InsertCommand = this.sqlInsertCommand;
            this.daLogin.SelectCommand = this.sqlSelectCommand1;
            this.daLogin.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Sifre", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("SifraID", "SifraID"),
                        new System.Data.Common.DataColumnMapping("KorisnickoIme", "KorisnickoIme"),
                        new System.Data.Common.DataColumnMapping("Sifra", "Sifra"),
                        new System.Data.Common.DataColumnMapping("Tip", "Tip")})});
            this.daLogin.UpdateCommand = this.sqlUpdateCommand1;
            // 
            // sqlInsertCommand
            // 
            this.sqlInsertCommand.CommandText = "INSERT INTO [Sifre] ([KorisnickoIme], [Sifra], [Tip]) VALUES (@KorisnickoIme, @Si" +
                "fra, @Tip);\r\nSELECT SifraID, KorisnickoIme, Sifra, Tip FROM Sifre WHERE (SifraID" +
                " = SCOPE_IDENTITY()) ORDER BY SifraID";
            this.sqlInsertCommand.Connection = this.connLogin;
            this.sqlInsertCommand.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@KorisnickoIme", System.Data.SqlDbType.VarChar, 0, "KorisnickoIme"),
            new System.Data.SqlClient.SqlParameter("@Sifra", System.Data.SqlDbType.VarChar, 0, "Sifra"),
            new System.Data.SqlClient.SqlParameter("@Tip", System.Data.SqlDbType.VarChar, 0, "Tip")});
            // 
            // tbKorisnickoIme
            // 
            this.tbKorisnickoIme.Location = new System.Drawing.Point(126, 56);
            this.tbKorisnickoIme.Name = "tbKorisnickoIme";
            this.tbKorisnickoIme.Size = new System.Drawing.Size(181, 22);
            this.tbKorisnickoIme.TabIndex = 0;
            // 
            // lbTipP
            // 
            this.lbTipP.AutoSize = true;
            this.lbTipP.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsLogin1, "Sifre.Tip", true));
            this.lbTipP.Location = new System.Drawing.Point(349, 127);
            this.lbTipP.Name = "lbTipP";
            this.lbTipP.Size = new System.Drawing.Size(28, 17);
            this.lbTipP.TabIndex = 16;
            this.lbTipP.Text = "     ";
            // 
            // frmLogin
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 15);
            this.ClientSize = new System.Drawing.Size(350, 168);
            this.Controls.Add(this.lbTipP);
            this.Controls.Add(this.tbKorisnickoIme);
            this.Controls.Add(this.tbSifra);
            this.Controls.Add(this.lbSifraP);
            this.Controls.Add(this.duOdustani);
            this.Controls.Add(this.duPrijavise);
            this.Controls.Add(this.lbSifra);
            this.Controls.Add(this.lbKorisIme);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prijava";
            ((System.ComponentModel.ISupportInitialize)(this.dsLogin1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		private void duPrijavise_Click(object sender, System.EventArgs e)
		{
			//Ako u jedno ili obadva polja nismo unijeli podatke onda prikaži upozorenje
			if(this.tbKorisnickoIme.Text=="" || this.tbSifra.Text=="")
			{
				MessageBox.Show("U jedno od polja niste unijeli podatke !","Upozorenje !",MessageBoxButtons.OK,MessageBoxIcon.Information);
			}
			else
			{
				try
				{

					string query = "";
					query = "SELECT * FROM Sifre WHERE KorisnickoIme='"+tbKorisnickoIme.Text+"'";
					SqlDataAdapter cmdAdapter = new SqlDataAdapter();
					SqlCommand cmd = new SqlCommand(query, clsKonekcija.GetConnection());
					cmdAdapter.SelectCommand =cmd;
					cmdAdapter.SelectCommand.CommandType = CommandType.Text;
					//this.connLogin.Open();
					this.dsLogin1.Clear();
					cmdAdapter.Fill(this.dsLogin1,"Sifre");
					//this.connLogin.Close();
				}

				catch(Exception ex)
				{
					string izu=ex.Message.ToString();
					MessageBox.Show(izu,"Upozorenje!",MessageBoxButtons.OK,MessageBoxIcon.Question);
				}
				
				//Provjera ispravnosti šifre
				if(this.tbSifra.Text==this.lbSifraP.Text)
				{										
					this.forma.Get_Status(this.lbTipP.Text);
					this.forma.Show();
					this.Hide();
				}
				else
				{
					MessageBox.Show("Unijeli ste neispravne podatke !","Upozorenje !",MessageBoxButtons.OK,MessageBoxIcon.Information);
				
				}		
			}  
		}

		private void duOdustani_Click(object sender, System.EventArgs e)
		{
			Application.Exit();
		}
	}
}
