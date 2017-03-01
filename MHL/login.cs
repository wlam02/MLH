using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MHL
{
    public partial class login : MetroFramework.Forms.MetroForm
    {
        public login()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {
            txtUserName.Focus();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            string Loginquery = ("Select TeacherLastName, Admin from PWDB where Email='" + txtUserName.Text.Trim() + "' and Password='" + txtPassword.Text.Trim() + "'");
            SqlConnection _sqlCon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|dbFile\PWDB.mdf;Integrated Security=True;Connect Timeout=30");            
            DataTable dt = new DataTable();            
            SqlDataAdapter sda = new SqlDataAdapter(Loginquery, _sqlCon);
            if (string.IsNullOrWhiteSpace(txtUserName.Text) || string.IsNullOrWhiteSpace(txtPassword.Text) ||
             txtUserName.Text == "Please Enter User Name" || txtPassword.Text == "Please Enter Password")
            {
                MessageBox.Show("Please Enter user Name and Password");
            }
            else
            {
                try
                {
                    if (_sqlCon.State == ConnectionState.Closed)
                    {
                        _sqlCon.Open();           
                        sda.Fill(dt);                                                 
                        if (dt.Rows.Count == 1)
                        {
                            MessageBox.Show("   Welcome " + dt.Rows[0][0].ToString(), "Murphy Login Helper");
                            this.Hide();                            
                            MLH frm = new MLH();
                            if (dt.Rows[0][1].ToString() == "True")
                            {
                                frm.ShowDialog();
                            }
                            else
                            {
                                frm.hideTab(true);
                                frm.ShowDialog();
                            }                                           
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Please check your credentials and try again!", "Failed to Login",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            txtPassword.Clear();
                            txtPassword.Focus();
                        }
                    }

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message, "Error Message");
                }
                finally
                {
                    _sqlCon.Close();
                }              
            }
        }

        private void txtUserName_Click(object sender, EventArgs e)
        {
            txtUserName.Clear();
        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            txtPassword.Clear();
        }
    }
}
