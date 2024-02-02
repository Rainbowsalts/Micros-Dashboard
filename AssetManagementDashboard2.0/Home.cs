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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dashboardDataSet.Server_HardwareEquipment' table. You can move, or remove it, as needed.
            //this.server_HardwareEquipmentTableAdapter.Fill(this.dashboardDataSet.Server_HardwareEquipment);
            BtnSearch.MouseHover += BtnSearch_MouseHover;


        }

        private void BtnSearch_MouseHover(object sender, EventArgs e)
        {
            toolTip.Show("Search for something", BtnSearch);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnContracts_Click(object sender, EventArgs e)
        {
            Contracts cont = new Contracts();
            cont.Show();
        }

        private void btnLicenses_Click(object sender, EventArgs e)
        {
            Licenses li = new Licenses();
            li.Show();
        }

        private void btnServers_Click(object sender, EventArgs e)
        {
            Servers ser = new Servers();
            ser.Show();
        }

        private void btnDevices_Click(object sender, EventArgs e)
        {
            Devices dev = new Devices();
            dev.Show();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            Settings set = new Settings();
            set.Show();
        }
    }
}
