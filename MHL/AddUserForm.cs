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
    public partial class AddUserForm : MetroFramework.Forms.MetroForm
    {
        //TODO: Make path relevent
        SqlConnection sqlcon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Repos\MHL\MHL\dbFile\PWDB.mdf;Integrated Security=True;Connect Timeout=30");
        public AddUserForm()
        {
            InitializeComponent();
        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel7_Click(object sender, EventArgs e)
        {

        }

        private void AddUserForm_Load(object sender, EventArgs e)
        {
            CheckIfTeacher();
            string TeacherdropSelectCommand = "select TeacherLastName from Teachers group by TeacherLastName";
            MLH.FillDropDownList(TeacherdropSelectCommand, ComboTeacherLN, sqlcon); // Group Teacher name
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            txtAddFName.Clear();
            txtAddLName.Clear();
            txtAddEmail.Clear();
            txtAddPW.Clear();
        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {
            txtAddFName.Clear();
        }

        private void metroTextBox2_Click(object sender, EventArgs e)
        {
            txtAddLName.Clear();
        }

        private void metroTextBox3_Click(object sender, EventArgs e)
        {
            txtAddEmail.Clear();
        }


        private void metroTextBox6_Click(object sender, EventArgs e)
        {
            txtAddPW.Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (RadioBtnIsTeacher.Checked)
            {               
                AddTeacher();
            }
            else
                AddStudent();

        }

        private void metroLabel4_Click(object sender, EventArgs e)
        {

        }

        private void metroRadioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                //this.pWDBTableAdapter.FillBy(this.pWDBDataSet.GetAllData);
            }
            catch (Exception ex)
            {
               MessageBox.Show(ex.Message);
            }

        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                //this.pWDBTableAdapter.FillBy1(this.pWDBDataSet.GetAllData);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void CheckIfTeacher()
        {
            if (RadioBtnIsStudent.Checked)
            {

                lblFirstName.Text = "Student First Name";
                txtAddFName.Text = "Enter Student First Name";
                lblLastName.Text = "Student Last Name";
                txtAddLName.Text = "Enter Student Last Name";
                lblEmail.Text = "Student EMail";
                txtAddEmail.Text = "Enter Student E-mail Address";
                lblTeacherLastName.Visible = true;
                chkBoxAdmin.Visible = false;
                ComboTeacherLN.Visible = true;
            }
            else
            {
                lblFirstName.Text = "Teacher First Name";
                txtAddFName.Text = "Enter Teacher First Name";
                lblLastName.Text = "Teacher Last Name";
                txtAddLName.Text = "Enter Teacher Last Name";
                lblEmail.Text = "Teacher EMail";
                txtAddEmail.Text = "Enter Teacher E-mail Address";
                lblTeacherLastName.Visible = false;
                chkBoxAdmin.Visible = true;
                ComboTeacherLN.Visible = false;
            }
        }

        private void AddTeacher()
        {
            if (string.IsNullOrWhiteSpace(txtAddFName.Text) || string.IsNullOrWhiteSpace(txtAddLName.Text) ||
                string.IsNullOrWhiteSpace(txtAddPW.Text) || string.IsNullOrWhiteSpace(txtAddEmail.Text) || txtAddFName.Text == "Enter First Name" || txtAddLName.Text == "Enter Last Name" || txtAddPW.Text == "Enter Password" || txtAddEmail.Text == "Enter Email / Login")
            {
                MessageBox.Show("Please Fill All Fields");
            }
            else  
            {
                try
                {
                    if (sqlcon.State == ConnectionState.Closed)
                    {
                        sqlcon.Open();
                        SqlCommand sqlCmd = new SqlCommand("AddTeacher", sqlcon);
                        sqlCmd.CommandType = CommandType.StoredProcedure;
                        sqlCmd.Parameters.AddWithValue("@TeacherID", 0);
                        sqlCmd.Parameters.AddWithValue("@Email", txtAddEmail.Text.Trim());
                        sqlCmd.Parameters.AddWithValue("@TeacherLastName", txtAddLName.Text.Trim());
                        sqlCmd.Parameters.AddWithValue("@TeacherFirstName", txtAddFName.Text.Trim());
                        sqlCmd.Parameters.AddWithValue("@Password", txtAddPW.Text.Trim());
                        sqlCmd.Parameters.AddWithValue("@Admin", chkBoxAdmin.Checked);
                        sqlCmd.ExecuteNonQuery();
                        MessageBox.Show("Teacher Record Added Successfully");
                    }

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message, "Error Message");
                }
                finally
                {
                    sqlcon.Close();
                }
                this.Close();
            }
        }

        private void AddStudent()
        {
            if (string.IsNullOrWhiteSpace(txtAddFName.Text) || string.IsNullOrWhiteSpace(txtAddLName.Text) ||
                string.IsNullOrWhiteSpace(txtAddPW.Text) || string.IsNullOrWhiteSpace(txtAddEmail.Text) || txtAddFName.Text == "Enter First Name" || txtAddLName.Text == "Enter Last Name" || txtAddPW.Text == "Enter Password" || txtAddEmail.Text == "Enter Email / Login")
            {
                MessageBox.Show("Please Fill All Fields");
            }
            else
            {
                try
                {
                    if (sqlcon.State == ConnectionState.Closed)
                    {
                        sqlcon.Open();
                        SqlCommand sqlCmd = new SqlCommand("AddStudent", sqlcon);
                        sqlCmd.CommandType = CommandType.StoredProcedure;
                        sqlCmd.Parameters.AddWithValue("@StudentID", 0);
                        sqlCmd.Parameters.AddWithValue("@FirstName", txtAddFName.Text.Trim());
                        sqlCmd.Parameters.AddWithValue("@LastNAME", txtAddLName.Text.Trim());
                        sqlCmd.Parameters.AddWithValue("@Email", txtAddEmail.Text.Trim());
                        sqlCmd.Parameters.AddWithValue("@TeacherID", GetTeacherID(ComboTeacherLN.Text.Trim()));
                        sqlCmd.Parameters.AddWithValue("@Password", txtAddPW.Text.Trim());
                        sqlCmd.ExecuteNonQuery();
                        MessageBox.Show("Student Record Added Successfully");
                    }

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message, "Error Message");
                }
                finally
                {
                    sqlcon.Close();
                }
                this.Close();
                //TODO: add refresh to main DataGrid
            }
        }

        private void RadioBtnIsAdmin_CheckedChanged(object sender, EventArgs e)
        {
            CheckIfTeacher();
        }
            private void metroRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            CheckIfTeacher();
        }

        private void chkBoxAdmin_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ComboTeacherLN_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private int GetTeacherID(string TeacherLastName)
        //This function assumes the data connection is open and does not close it once it done. 
        //When using this function the connection must be closed by the location it was called from.
        {
            int teacherid = 0;
            try
            {
                SqlCommand sqlCmd = new SqlCommand("Select Teachers.TeacherID from Teachers where TeacherLastName ='" + TeacherLastName + "'", sqlcon);
                sqlCmd.CommandType = CommandType.Text;
                SqlDataReader reader = sqlCmd.ExecuteReader();
                while (reader.Read())
                {
                    teacherid = reader.GetInt32(0);
                }
                reader.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message");
            }
            return teacherid;
        }
    }
}

