using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;


namespace AutoSkola
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class frmGlavna : System.Windows.Forms.Form
	{
		private System.Windows.Forms.MainMenu mainMenu1;
		private System.Windows.Forms.MenuItem menuItem12;
		private System.Windows.Forms.ToolBar toolBar1;
		private System.Windows.Forms.ToolBarButton Instruktori;
		private System.Windows.Forms.ImageList imageList1;
		private System.Windows.Forms.ToolBarButton Sep;
		private System.Windows.Forms.ToolBarButton Kandidati;
		private System.Windows.Forms.ToolBarButton Sep1;
		private System.Windows.Forms.ToolBarButton Sep2;
		private System.Windows.Forms.ToolBarButton Vozila;
		private System.Windows.Forms.ToolBarButton Sep3;
		private System.Windows.Forms.ToolBarButton Polaganja;
		private System.Windows.Forms.ToolBarButton Sep4;
        private System.Windows.Forms.ToolBarButton Kategorije;
		private System.ComponentModel.IContainer components;
		private System.Windows.Forms.MenuItem menuItemInstr;
		private System.Windows.Forms.MenuItem menuItemVozila;
		private System.Windows.Forms.MenuItem menuItemKandidati;
		private System.Windows.Forms.MenuItem menuItemPodaci;
		private System.Windows.Forms.MenuItem menuItemPolaganja;
		private System.Windows.Forms.MenuItem menuItemKategorije;
		private System.Windows.Forms.MenuItem menuItemPristup;
        private System.Windows.Forms.MenuItem menuItemIzvjestaji;
		private System.Windows.Forms.MenuItem menuItemProzori;
		private System.Windows.Forms.MenuItem menuItemKaskadno;
		private System.Windows.Forms.MenuItem menuItemVertikalno;
		private System.Windows.Forms.MenuItem menuItemOdjava;
		private System.Windows.Forms.MenuItem menuItemDnevnik;
		private System.Windows.Forms.ToolBarButton dnevnikObuke;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem menuItem2;
		private System.Windows.Forms.MenuItem menuItem3;
		private System.Windows.Forms.MenuItem menuItem4;
        private System.Windows.Forms.MenuItem menuItem5;
        private MenuItem menuItem7;

		string status="";
		
		public frmGlavna()
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
			Application.Exit();
						
			if( disposing )
			{
				if (components != null) 
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGlavna));
            this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.menuItemPodaci = new System.Windows.Forms.MenuItem();
            this.menuItemInstr = new System.Windows.Forms.MenuItem();
            this.menuItemKandidati = new System.Windows.Forms.MenuItem();
            this.menuItemDnevnik = new System.Windows.Forms.MenuItem();
            this.menuItemVozila = new System.Windows.Forms.MenuItem();
            this.menuItemPolaganja = new System.Windows.Forms.MenuItem();
            this.menuItemKategorije = new System.Windows.Forms.MenuItem();
            this.menuItem12 = new System.Windows.Forms.MenuItem();
            this.menuItemPristup = new System.Windows.Forms.MenuItem();
            this.menuItemIzvjestaji = new System.Windows.Forms.MenuItem();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.menuItem5 = new System.Windows.Forms.MenuItem();
            this.menuItemProzori = new System.Windows.Forms.MenuItem();
            this.menuItemKaskadno = new System.Windows.Forms.MenuItem();
            this.menuItemVertikalno = new System.Windows.Forms.MenuItem();
            this.menuItemOdjava = new System.Windows.Forms.MenuItem();
            this.menuItem7 = new System.Windows.Forms.MenuItem();
            this.toolBar1 = new System.Windows.Forms.ToolBar();
            this.Instruktori = new System.Windows.Forms.ToolBarButton();
            this.Sep = new System.Windows.Forms.ToolBarButton();
            this.Kandidati = new System.Windows.Forms.ToolBarButton();
            this.Sep1 = new System.Windows.Forms.ToolBarButton();
            this.dnevnikObuke = new System.Windows.Forms.ToolBarButton();
            this.Sep2 = new System.Windows.Forms.ToolBarButton();
            this.Vozila = new System.Windows.Forms.ToolBarButton();
            this.Sep3 = new System.Windows.Forms.ToolBarButton();
            this.Polaganja = new System.Windows.Forms.ToolBarButton();
            this.Sep4 = new System.Windows.Forms.ToolBarButton();
            this.Kategorije = new System.Windows.Forms.ToolBarButton();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItemPodaci,
            this.menuItemIzvjestaji,
            this.menuItemProzori,
            this.menuItemOdjava});
            // 
            // menuItemPodaci
            // 
            this.menuItemPodaci.Index = 0;
            this.menuItemPodaci.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItemInstr,
            this.menuItemKandidati,
            this.menuItemDnevnik,
            this.menuItemVozila,
            this.menuItemPolaganja,
            this.menuItemKategorije,
            this.menuItem12,
            this.menuItemPristup});
            resources.ApplyResources(this.menuItemPodaci, "menuItemPodaci");
            // 
            // menuItemInstr
            // 
            this.menuItemInstr.Index = 0;
            resources.ApplyResources(this.menuItemInstr, "menuItemInstr");
            this.menuItemInstr.Click += new System.EventHandler(this.menuItemInstr_Click);
            // 
            // menuItemKandidati
            // 
            this.menuItemKandidati.Index = 1;
            resources.ApplyResources(this.menuItemKandidati, "menuItemKandidati");
            this.menuItemKandidati.Click += new System.EventHandler(this.menuItemKandidati_Click);
            // 
            // menuItemDnevnik
            // 
            this.menuItemDnevnik.Index = 2;
            resources.ApplyResources(this.menuItemDnevnik, "menuItemDnevnik");
            this.menuItemDnevnik.Click += new System.EventHandler(this.menuItemDnevnik_Click);
            // 
            // menuItemVozila
            // 
            this.menuItemVozila.Index = 3;
            resources.ApplyResources(this.menuItemVozila, "menuItemVozila");
            this.menuItemVozila.Click += new System.EventHandler(this.menuItemVozila_Click);
            // 
            // menuItemPolaganja
            // 
            this.menuItemPolaganja.Index = 4;
            resources.ApplyResources(this.menuItemPolaganja, "menuItemPolaganja");
            this.menuItemPolaganja.Click += new System.EventHandler(this.menuItemPolaganja_Click);
            // 
            // menuItemKategorije
            // 
            this.menuItemKategorije.Index = 5;
            resources.ApplyResources(this.menuItemKategorije, "menuItemKategorije");
            this.menuItemKategorije.Click += new System.EventHandler(this.menuItemKategorije_Click);
            // 
            // menuItem12
            // 
            this.menuItem12.Index = 6;
            resources.ApplyResources(this.menuItem12, "menuItem12");
            // 
            // menuItemPristup
            // 
            this.menuItemPristup.Index = 7;
            resources.ApplyResources(this.menuItemPristup, "menuItemPristup");
            this.menuItemPristup.Click += new System.EventHandler(this.menuItemPristup_Click);
            // 
            // menuItemIzvjestaji
            // 
            this.menuItemIzvjestaji.Index = 1;
            this.menuItemIzvjestaji.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem1,
            this.menuItem2,
            this.menuItem3,
            this.menuItem4,
            this.menuItem5});
            resources.ApplyResources(this.menuItemIzvjestaji, "menuItemIzvjestaji");
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 0;
            resources.ApplyResources(this.menuItem1, "menuItem1");
            this.menuItem1.Click += new System.EventHandler(this.menuItem1_Click);
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 1;
            resources.ApplyResources(this.menuItem2, "menuItem2");
            this.menuItem2.Click += new System.EventHandler(this.menuItem2_Click);
            // 
            // menuItem3
            // 
            this.menuItem3.Index = 2;
            resources.ApplyResources(this.menuItem3, "menuItem3");
            this.menuItem3.Click += new System.EventHandler(this.menuItem3_Click);
            // 
            // menuItem4
            // 
            this.menuItem4.Index = 3;
            resources.ApplyResources(this.menuItem4, "menuItem4");
            this.menuItem4.Click += new System.EventHandler(this.menuItem4_Click);
            // 
            // menuItem5
            // 
            this.menuItem5.Index = 4;
            resources.ApplyResources(this.menuItem5, "menuItem5");
            this.menuItem5.Click += new System.EventHandler(this.menuItem5_Click);
            // 
            // menuItemProzori
            // 
            this.menuItemProzori.Index = 2;
            this.menuItemProzori.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItemKaskadno,
            this.menuItemVertikalno});
            resources.ApplyResources(this.menuItemProzori, "menuItemProzori");
            // 
            // menuItemKaskadno
            // 
            this.menuItemKaskadno.Index = 0;
            resources.ApplyResources(this.menuItemKaskadno, "menuItemKaskadno");
            this.menuItemKaskadno.Click += new System.EventHandler(this.menuItem14_Click);
            // 
            // menuItemVertikalno
            // 
            this.menuItemVertikalno.Index = 1;
            resources.ApplyResources(this.menuItemVertikalno, "menuItemVertikalno");
            this.menuItemVertikalno.Click += new System.EventHandler(this.menuItem15_Click);
            // 
            // menuItemOdjava
            // 
            this.menuItemOdjava.Index = 3;
            this.menuItemOdjava.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem7});
            resources.ApplyResources(this.menuItemOdjava, "menuItemOdjava");
            // 
            // menuItem7
            // 
            this.menuItem7.Index = 0;
            resources.ApplyResources(this.menuItem7, "menuItem7");
            this.menuItem7.Click += new System.EventHandler(this.menuItem7_Click);
            // 
            // toolBar1
            // 
            resources.ApplyResources(this.toolBar1, "toolBar1");
            this.toolBar1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.toolBar1.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
            this.Instruktori,
            this.Sep,
            this.Kandidati,
            this.Sep1,
            this.dnevnikObuke,
            this.Sep2,
            this.Vozila,
            this.Sep3,
            this.Polaganja,
            this.Sep4,
            this.Kategorije});
            this.toolBar1.ImageList = this.imageList1;
            this.toolBar1.Name = "toolBar1";
            this.toolBar1.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.toolBar1_ButtonClick);
            // 
            // Instruktori
            // 
            resources.ApplyResources(this.Instruktori, "Instruktori");
            this.Instruktori.Name = "Instruktori";
            // 
            // Sep
            // 
            this.Sep.Name = "Sep";
            this.Sep.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // Kandidati
            // 
            resources.ApplyResources(this.Kandidati, "Kandidati");
            this.Kandidati.Name = "Kandidati";
            // 
            // Sep1
            // 
            this.Sep1.Name = "Sep1";
            this.Sep1.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // dnevnikObuke
            // 
            resources.ApplyResources(this.dnevnikObuke, "dnevnikObuke");
            this.dnevnikObuke.Name = "dnevnikObuke";
            // 
            // Sep2
            // 
            this.Sep2.Name = "Sep2";
            this.Sep2.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // Vozila
            // 
            resources.ApplyResources(this.Vozila, "Vozila");
            this.Vozila.Name = "Vozila";
            // 
            // Sep3
            // 
            this.Sep3.Name = "Sep3";
            this.Sep3.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // Polaganja
            // 
            resources.ApplyResources(this.Polaganja, "Polaganja");
            this.Polaganja.Name = "Polaganja";
            // 
            // Sep4
            // 
            this.Sep4.Name = "Sep4";
            this.Sep4.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // Kategorije
            // 
            resources.ApplyResources(this.Kategorije, "Kategorije");
            this.Kategorije.Name = "Kategorije";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "");
            this.imageList1.Images.SetKeyName(1, "");
            this.imageList1.Images.SetKeyName(2, "");
            this.imageList1.Images.SetKeyName(3, "");
            this.imageList1.Images.SetKeyName(4, "Testovi1.ico");
            this.imageList1.Images.SetKeyName(5, "");
            this.imageList1.Images.SetKeyName(6, "");
            // 
            // frmGlavna
            // 
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.toolBar1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IsMdiContainer = true;
            this.Menu = this.mainMenu1;
            this.Name = "frmGlavna";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmGlavna_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		

		public void Get_Status(string a)
		{
			this.status=a;
		}
		
		private void toolBar1_ButtonClick(object sender, System.Windows.Forms.ToolBarButtonClickEventArgs e)
		{
			if(e.Button == Instruktori){menuItemInstr.PerformClick();}
			else if(e.Button == Vozila){menuItemVozila.PerformClick();}
			else if(e.Button == Kandidati){menuItemKandidati.PerformClick();}
			else if(e.Button == Kategorije){menuItemKategorije.PerformClick();}
			else if(e.Button == Polaganja){menuItemPolaganja.PerformClick();}
			else if(e.Button == dnevnikObuke){menuItemDnevnik.PerformClick();}
            //else if (e.Button == Testovi) { menuItemTestovi.PerformClick(); }
									   
		}

		private void frmGlavna_Load(object sender, System.EventArgs e)
		{

            if (this.status == "Instruktor" || this.status == "Administrator")
            {
                this.menuItemPristup.Enabled = true;                
            }

            /*
			else if(this.status == "Administrator")
			{
				this.menuItemPristup.Enabled = true;
			}
			*/
            else if (this.status == "Kandidat")
            {
                this.menuItemPodaci.Enabled = false;
                this.menuItemIzvjestaji.Enabled = false;
                this.menuItemProzori.Enabled = false;
                this.toolBar1.Enabled = false;
            }
            else if (this.status == "Ostali")
            {
                this.menuItemPodaci.Enabled = false;
                this.menuItemIzvjestaji.Enabled = false;
                this.menuItemProzori.Enabled = false;
                this.toolBar1.Enabled = false;
            }
            else
            {
                /*
                this.menuItemPodaci.Enabled = false;
                this.menuItemIzvjestaji.Enabled = false;
                this.menuItemProzori.Enabled = false;
                this.toolBar1.Enabled = false;
                */ 
            }

            //frmSplashScreen splash = new frmSplashScreen();
            //splash.ShowDialog();			
		}

		private void menuItem14_Click(object sender, System.EventArgs e)
		{
			this.LayoutMdi(MdiLayout.Cascade);
		}

		private void menuItem15_Click(object sender, System.EventArgs e)
		{
			this.LayoutMdi(MdiLayout.TileVertical);
		}

		

		private void menuItemVozila_Click(object sender, System.EventArgs e)
		{
			Form vozilo = frmVozila.Instance();
			vozilo.MdiParent = this;
			vozilo.Show();
			//vozilo.Activate();
		}

		private void menuItemInstr_Click(object sender, System.EventArgs e)
		{
			Form instruktor = frmInstruktori.Instance();
			instruktor.MdiParent = this;
			instruktor.Show();
			//instruktor.Activate();
		}

		private void menuItemKandidati_Click(object sender, System.EventArgs e)
		{
			Form kandidat = frmKandidati.Instance();
			kandidat.MdiParent = this;
			kandidat.Show();
			//kandidat.Activate();
		}

		private void menuItemKategorije_Click(object sender, System.EventArgs e)
		{
			Form kategorija = frmKategorije.Instance();
			kategorija.MdiParent = this;
			kategorija.Show();
			//kategorija.Activate();
			
		}

		private void menuItemPolaganja_Click(object sender, System.EventArgs e)
		{
			Form polaganje = frmPolaganja.Instance();
			polaganje.MdiParent = this;
			polaganje.Show();
			//polaganje.Activate();
		}

		private void menuItemPristup_Click(object sender, System.EventArgs e)
		{
			Form sifra = frmSifre.Instance();
			sifra.MdiParent = this;
			sifra.Show();
			//sifra.Activate();
		}

		private void menuItemDnevnik_Click(object sender, System.EventArgs e)
		{
			Form dnevnik = frmDnevnikObuke.Instance();
			dnevnik.MdiParent = this;
			dnevnik.Show();
			//dnevnik.Activate();
		}

		private void menuItem1_Click(object sender, System.EventArgs e)
		{
			frmIzvInstruktori i = new frmIzvInstruktori();
			i.ShowDialog();
		}

		private void menuItem4_Click(object sender, System.EventArgs e)
		{
			frmIzvjVozila i = new frmIzvjVozila();
			i.ShowDialog();
		}

		private void menuItem2_Click(object sender, System.EventArgs e)
		{
			frmIzvKandidati i = new frmIzvKandidati();
			i.ShowDialog();
		}

		private void menuItem3_Click(object sender, System.EventArgs e)
		{
			frmIzvDnevnikObuke i = new frmIzvDnevnikObuke();
			i.ShowDialog();
		}

		private void menuItem5_Click(object sender, System.EventArgs e)
		{
			frmIzvPolaganja i = new frmIzvPolaganja();
			i.ShowDialog();
		}

        private void menuItemTestovi_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process p = new System.Diagnostics.Process();
            //Ovo ti je putanja do fajla testovi.exe. Ovo ces vjerovatno morat promijenit
            //Zavisi gdje se intaliraju testovi
            //Ako budu u istom folderu mozda se moze stavit samo "Testovi.exe"
            p.StartInfo.FileName = 
                System.Configuration.ConfigurationSettings.AppSettings["testoviStartPath"];
            p.Start();

           
        }

        /*
            System.Diagnostics.Process p = new System.Diagnostics.Process();
            //Ovo ti je putanja do fajla testovi.exe. Ovo ces vjerovatno morat promijenit
            //Zavisi gdje se instaliraju testovi
            //Ako budu u istom folderu mozda se moze stavit samo "Testovi.exe"
            p.StartInfo.FileName =
                System.Configuration.ConfigurationSettings.AppSettings["testoviStartPath"];
            p.Start();
        */
        private void menuItemPokreni_Click(object sender, EventArgs e)
        {           
            /*
            System.Diagnostics.Process p = new System.Diagnostics.Process();
            //Ovo ti je putanja do fajla testovi.exe. Ovo ces vjerovatno morat promijenit
            //Zavisi gdje se instaliraju testovi
            //Ako budu u istom folderu mozda se moze stavit samo "Testovi.exe"
            p.StartInfo.FileName =
                System.Configuration.ConfigurationSettings.AppSettings["testoviStartPath"];
            p.Start();
            */
        }

        /*
            frmLogin login = new frmLogin();
            this.Hide();
            login.ShowDialog();
        */
        
        private void menuItem7_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose(true);
        }        		
	}
}
