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
    public partial class Contracts : Form
    {
        public Contracts()
        {
            InitializeComponent();
        }

        private void Contracts_Load(object sender, EventArgs e)
        {

        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            ContPopUp popup = new ContPopUp();
            popup.Show();
        }
    }
}
