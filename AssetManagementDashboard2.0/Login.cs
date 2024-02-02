using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace AssetManagementDashboard2._0
{
    public partial class Login : Form
    {
        //SqlCommand cmd;
        //SqlConnection conn;
        //SqlDataReader dr;


        public Login()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("Server =.\\SQLEXPRESS;Initial Catalog=Dashboard;Integrated Security=True;Encrypt=False;");

        private void Login_Load(object sender, EventArgs e)
        {
            //Server =.\\SQLEXPRESS;Initial Catalog=Dashboard;Integrated Security=True;Encrypt=False;"
           
        }

        private void Btn_Login_Click_Click(object sender, EventArgs e)
        {
            string username, password;

            username= txtusername.Text;
            password = txtpassword.Text;

            try
            {
                string.query = " select * from User_Login where Username = '" + txtusername.Text + "'and Password = '" + txtpassword.Text + "'";
                SqlDataAdapter da = new SqlDataAdapter();

                DataTable dt = new DataTable();
                da.Fill(dt);

                if(dt.Rows.Count > 0 )
                {
                    username = txtusername.Text;
                    password = txtpassword.Text;

                    //page
                    Home hm = new Home();
                    hm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invaild login details","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    txtusername.Clear();
                    txtpassword.Clear();


                    //focus
                    txtusername.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
            finally 
            { 
                conn.Close();
            }

        }
    }
}
