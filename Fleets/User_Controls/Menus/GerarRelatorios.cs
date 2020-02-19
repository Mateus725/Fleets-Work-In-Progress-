using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fleets.Controls.Menus
{
    public partial class GerarRelatorios : UserControl
    {
        public GerarRelatorios()
        {
            InitializeComponent();
            
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}
