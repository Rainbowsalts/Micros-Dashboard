using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssetManagementDashboard2._0
{
    public partial class Servers : Form
    {
        public Servers()
        {
            InitializeComponent();
        }

        private void Servers_Load(object sender, EventArgs e)
        {
            searchbox.MouseHover += Searchbox_MouseHover;
            searchbox.MouseLeave += Searchbox_MouseLeave;
        }

        private void Searchbox_MouseLeave(object sender, EventArgs e)
        {
            toolTip1.Show("Search for something..", searchbox);

            searchbox.Visible = true;
            searchbox.Location = new Point(search1.Location.X + search1.Width + 5, search1.Location.Y);
        }

        private void Searchbox_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Hide(search1);

            searchbox.Visible = false;
        }
    }
}
