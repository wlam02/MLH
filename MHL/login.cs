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

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            MLH frm = new MLH();
            {
                frm.ShowDialog();                
            }
            this.Close();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            SqlConnection _sqlCon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|dbFile\PWDB.mdf;Integrated Security=True;Connect Timeout=30");
            SqlDataAdapter sda = new SqlDataAdapter();
            DataTable dt = new DataTable();
            string Loginquery = ("Select TeacherLastName from PWDB where Email='" + txtUserName.Text.Trim() + "' and Password='" + txtPassword.Text.Trim() + "'");
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
                        SqlCommand sqlCmd = new SqlCommand(Loginquery, _sqlCon);   
                        sqlCmd.CommandType = CommandType.Text;
                        sqlCmd.ExecuteNonQuery();

                        sda.Fill(dt);
                        //if(dt.Rows[0][0].ToString()=="Admin")
                        if (dt.Rows.Count == 1)
                        {
                            MessageBox.Show("login Sucsessful");
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
                this.Close();
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
