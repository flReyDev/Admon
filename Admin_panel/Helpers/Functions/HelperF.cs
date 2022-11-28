using Admin_panel.Helpers.Functions;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace Admin_panel.Helpers
{
    internal class HelperF : IHelperF
    {
        private Form formulario = null;
        public HelperF() { }

        /**
         * Metodo que permite establecer el posicionamiento del menu desplegable
         * en base al Control que lo acciona permitiendo establecerce bajo su posición
         * **/
        public void GetLocationRelative(Control referent, Control children)
        {
            children.Location = new Point()
            {
                X = referent.Location.X,
                Y = referent.Location.Y + (referent.Height * 2)
            };
        }

        /**
         * Metodo que permite validar si un menu esta visible, de estarlo lo oculta
         * de lo contrario lo muestra
         * **/
        public void ShowAndHideControls(Control control, object sender, List<Control> menus = null) {
            if (control != null)
            {
                ((Button)sender).Parent.SendToBack();
                control.BringToFront();
                if (control.Visible)
                {
                    control.Visible = false;
                    return;
                }
                control.Show();
            }
            IvalidateMenus(control, menus);
        }

        /**
         * Permite validar si un boton no tiene menu y estan abiertos menus de otros
         * botones lo cierra.
         * **/
        public void IvalidateMenus(Control control, List<Control> menus = null)
        {
            if (control == null && menus.Count() > 0)
            {
                foreach (var cont in menus)
                {
                    cont.Visible = false;
                }
            }
            if (menus.Count() > 0 && control != null)
            {
                foreach (Control child in menus)
                {
                    if (child.Name != control.Name)
                    {
                        child.Visible = false;
                    }
                }
            }
        }

        /**
         * Agregar formulario al panel principal
         * **/
        public void OpenForm(Control control, Form form, string titulo)
        {
            //control.Parent.Controls.Find("lblTituloPag", true)[0].Text = titulo;
            control.Parent.Text = titulo;
            if (this.formulario != null)
            {
                this.formulario.Close();
            }
            this.formulario = form;
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            control.Controls.Add(form);
            control.Tag = form;
            form.BringToFront();
            form.Show();
        }
    
    }
}
