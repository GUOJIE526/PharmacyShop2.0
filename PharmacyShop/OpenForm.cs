using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyShop
{
    public class OpenForm
    {
        private Form activeform = null;

        public void openForm(Form childform, Panel panel)
        {
            if (activeform != null)
            {
                activeform.Close();
                activeform.Dispose();
            }
            activeform = childform;
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            panel.Controls.Add(childform);
            panel.Tag = childform;
            childform.BringToFront();
            childform.Show();
        }
    }
}
