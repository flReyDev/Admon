using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Admin_panel.Helpers.Functions
{
    public interface IHelperF
    {
        void GetLocationRelative(Control referent, Control children);

        void ShowAndHideControls(Control control, object sender, List<Control> controls = null);

        void OpenForm( Control panelParent, Form form, string titulo );
    }
}
