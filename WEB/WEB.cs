using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tia_Web
{
    public partial class UserControl1: UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

    
        private void btnIr_Click(object sender, EventArgs e)
        {
                webBrowser1.Navigate(txtURL.Text);
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void btnRecargar_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void btnAlto_Click(object sender, EventArgs e)
        {
            webBrowser1.Stop();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            webBrowser1.GoHome();
        }
    }
}
