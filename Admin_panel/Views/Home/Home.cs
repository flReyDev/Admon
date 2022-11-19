using Admin_panel.Helpers;
using Admin_panel.Helpers.Functions;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Admin_panel
{
    public partial class Home : Form
    {
        private IHelperF helper;
        private List<Control> menus = new List<Control>();
        public Home(IHelperF helperF)
        {
            InitializeComponent();
            this.helper = helperF;
        }

        private void Home_Load(object sender, EventArgs e)
        {
            this.menus.Add(  this.MenuInventary  );
            this.menus.Add(  this.MenuInvoice    );
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

        private void iconButton9_Click(object sender, EventArgs e)
        {

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
            this.helper.ShowAndHideControls( null, sender, this.menus );
        }
    }
}
