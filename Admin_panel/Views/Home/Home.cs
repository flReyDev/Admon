using Admin_panel.Helpers.Functions;
using Admin_panel.Helpers.Web;
using Admin_panel.Views;
using Admin_panel.Views.Config;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Admin_panel
{
    public partial class Home : Form
    {
        private IHelperF helper;
        private IHttpHelper httpHelper;
        private List<Control> menus = new List<Control>();
        public Home(IHelperF helperF, IHttpHelper httpHelper)
        {
            InitializeComponent();
            this.helper = helperF;
            this.httpHelper = httpHelper;
        }

        private void Home_Load(object sender, EventArgs e)
        {
            this.menus.Add(this.MenuInventary);
            this.menus.Add(this.MenuInvoice);

            this.helper.OpenForm(this.PanelPrincipal, new Dashboard(), "Dashboard");

            //string tokenEmpresa = "539f7188dcd0548a987471227005b4a0ba8d1e25";
            //string tokenPassword = "4f74279b901affaff844b73c09dde5e59bb3e267";
        }

        private void btnClosed_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
                WindowState = FormWindowState.Maximized;
            }
            else if (WindowState == FormWindowState.Maximized)
            {
                this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
                WindowState = FormWindowState.Normal;
            }

        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Minimized;
            else if (WindowState == FormWindowState.Maximized)
                WindowState = FormWindowState.Minimized;
        }

        private void TxtSearch_Enter(object sender, EventArgs e)
        {
            TxtSearch.Text = "";
        }

        private void ShowMenuInventary(object sender, EventArgs e)
        {
            this.helper.GetLocationRelative(this.BtnMenuInventary,this.MenuInventary);
            this.helper.ShowAndHideControls(this.MenuInventary, sender, this.menus);
        }

        private void ShowMenuInvoice(object sender, EventArgs e)
        {
            this.helper.GetLocationRelative(this.BtnMenuInvoice, this.MenuInvoice);
            this.helper.ShowAndHideControls(this.MenuInvoice, sender, this.menus);
        }

        private void Menu_enterprise(object sender, EventArgs e)
        {
            this.helper.ShowAndHideControls(null, sender, this.menus);
        }

        private void ShowConfig(object sender, EventArgs e)
        {

            //MessageBox.Show("Configuración");
            this.helper.OpenForm(this.PanelPrincipal, new Configuracion(), "Configuración");
        }
    }


}
