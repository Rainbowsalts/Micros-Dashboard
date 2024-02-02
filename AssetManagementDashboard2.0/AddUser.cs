using FontAwesome.Sharp;
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

namespace AssetManagementDashboard2._0
{

    public partial class AddUser : Form
    {
        //public string con = 

        SqlCommand cmd;
        SqlConnection con;
        SqlDataReader dr;

        
        public AddUser()
        {
            InitializeComponent();
        }

        private void AddUser_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Server =.\\SQLEXPRESS;Initial Catalog=Dashboard;Integrated Security=True;Encrypt=False;");
            con.Open();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login log = new Login();
            log.ShowDialog();
        }

        private void BtnAddUser_Click(object sender, EventArgs e)
        {
            if (txtConfiPassword.Text != string.Empty || txtPassword.Text != string.Empty || txtUsername.Text != string.Empty)
            {
                if (txtPassword.Text == txtConfiPassword.Text)
                {
                    SqlCommand cmd = new SqlCommand("select * from dbo.User_Login where username='" + txtUsername.Text + "'", con);
                    cmd.Connection = con;
                    SqlDataReader dr = cmd.ExecuteReader();
                   
            
                   //SqlDataAdapter da =  cmd.ExecuteNonQuery();

                    if (dr.Read())
                    {
                        dr.Close();
                        MessageBox.Show("Username already exisit, please try another", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        dr.Close();
                        cmd = new SqlCommand("insert into User_Login values(@username,@password)", con);
                        cmd.Parameters.AddWithValue("username", txtUsername.Text);
                        cmd.Parameters.AddWithValue("password", txtPassword.Text);
                        cmd.Parameters.AddWithValue("confirmpassword", txtConfiPassword.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("User is created. Go ahead an login.", "Done",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        con.Close();
                    }


                }
                else
                {
                    MessageBox.Show("Enter password","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Enter all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtConfiPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void label_Click(object sender, EventArgs e)
        {

        }
    }
}

