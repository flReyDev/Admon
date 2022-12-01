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
    /// <summary>
    /// Clase de utilidades, para entorno grafico, Menus, cambio de titulos etc...
    /// </summary>
    internal class HelperF : IHelperF
    {
        private Form formulario = null;
        public HelperF() { }

        /// <summary>
        /// Metodo que permite establecer el posicionamiento del menu desplegable 
        /// en base al Control que lo acciona permitiendo establecerce bajo su posición
        /// </summary>
        /// <param name="referent"></param>
        /// <param name="children"></param>
        public void GetLocationRelative(Control referent, Control children)
        {
            children.Location = new Point()
            {
                X = referent.Location.X,
                Y = referent.Location.Y + (referent.Height * 2)
            };
        }

       /// <summary>
       /// Metodo que permite validar si un menu el visible
       /// de estar visible lo oculta
       /// </summary>
       /// <param name="control"></param>
       /// <param name="sender"></param>
       /// <param name="menus"></param>
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

        /// <summary>
        /// Metodo que permite validar si un boton tiene abierto su menu
        /// de ser asi lo cierra
        /// </summary>
        /// <param name="control"></param>
        /// <param name="menus"></param>
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

        /// <summary>
        /// Metodo que agrega un formulario al panel principal
        /// </summary>
        /// <param name="control"></param>
        /// <param name="form"></param>
        /// <param name="titulo"></param>
        public void OpenForm(Control control, Form form, string titulo)
        {
            control.Parent.Controls.Find("lblTituloPag", true)[0].Text = titulo;

            this.formulario?.Close();
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
