using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;

namespace MHL
{
    public partial class MLH : MetroFramework.Forms.MetroForm

    {
        SqlConnection _sqlCon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|dbFile\PWDB.mdf;Integrated Security=True;Connect Timeout=30");
        int UserID = 0;
        string TeacherdropSelectCommand = "select TeacherLastName from Teachers group by TeacherLastName";
        public MLH()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitilizeForm();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            //TODO: Need to remove this temp function and add print procedure. 
            hideTab(true);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (_sqlCon.State == ConnectionState.Closed) //check if the connection is closed
                    _sqlCon.Open();
                SqlCommand sqlReadPWcmd = new SqlCommand("SELECT Student.Password, Student.Email FROM Student WHERE Student.LastNAME LIKE" + "'" + ComboName.Text.Trim() + "'", _sqlCon);
                SqlDataReader reader;
                sqlReadPWcmd.CommandType = CommandType.Text;
                sqlReadPWcmd.Connection = _sqlCon;
                reader = sqlReadPWcmd.ExecuteReader();
                String barcode = "";
                String login = "";
                while (reader.Read())
                {
                    barcode += reader[0].ToString();
                    login += reader[1].ToString();
                }

                Bitmap PWbitmap = new Bitmap(barcode.Length * 80, 40);
                Bitmap Loginbitmap = new Bitmap(barcode.Length * 80, 40);
                using (Graphics graphics = Graphics.FromImage(PWbitmap))
                {
                    Font OFont = new Font("IDAutomationHC39M", 16);
                    PointF point = new PointF(2f, 2f);
                    SolidBrush black = new SolidBrush(Color.Black);
                    SolidBrush White = new SolidBrush(Color.White);
                    graphics.FillRectangle(White, 0, 0, PWbitmap.Width, PWbitmap.Height);
                    graphics.DrawString(barcode, OFont, black, point);

                }
                using (MemoryStream ms = new MemoryStream())
                {
                    PWbitmap.Save(ms, ImageFormat.Png);
                    picPW.Image = PWbitmap;
                    picPW.Height = PWbitmap.Height;
                    picPW.Width = PWbitmap.Width;
                }

                using (Graphics graphics = Graphics.FromImage(Loginbitmap))
                {
                    Font OFont = new Font("IDAutomationHC39M", 16);
                    PointF point = new PointF(2f, 2f);
                    SolidBrush black = new SolidBrush(Color.Black);
                    SolidBrush White = new SolidBrush(Color.White);
                    graphics.FillRectangle(White, 0, 0, Loginbitmap.Width, Loginbitmap.Height);
                    graphics.DrawString(login, OFont, black, point);

                }
                using (MemoryStream ms = new MemoryStream())
                {
                    PWbitmap.Save(ms, ImageFormat.Png);
                    picLogin.Image = Loginbitmap;
                    picLogin.Height = Loginbitmap.Height;
                    picLogin.Width = Loginbitmap.Width;
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

        private void metroTile1_Click(object sender, EventArgs e)
        {
            using (AddUserForm frm = new AddUserForm())
            {
                frm.ShowDialog();
            }
            //try
            //{
            //    if (_sqlCon.State == ConnectionState.Closed)
            //    {

            //        //TODO: Add data validation to make sure the into is new.
            //        _sqlCon.Open();
            //        SqlCommand sqlCmd = new SqlCommand("PWDBAddorEdit", _sqlCon);
            //        sqlCmd.CommandType = CommandType.StoredProcedure;
            //        sqlCmd.Parameters.AddWithValue("@mode", "Add");
            //        sqlCmd.Parameters.AddWithValue("@UserID", 0);
            //        sqlCmd.Parameters.AddWithValue("@FirstName", txteditFirstName.Text.Trim());
            //        sqlCmd.Parameters.AddWithValue("@LastNAME", txteditLastName.Text.Trim());
            //        sqlCmd.Parameters.AddWithValue("@Email", txteditemail.Text.Trim());
            //        sqlCmd.Parameters.AddWithValue("@TeacherFirstName", txtEditTeachFName.Text.Trim());
            //        sqlCmd.Parameters.AddWithValue("@TeacherLastName", txtEditTeachLName.Text.Trim());
            //        sqlCmd.Parameters.AddWithValue("@Password", txtEditPW.Text.Trim());
            //        sqlCmd.ExecuteNonQuery();
            //        MessageBox.Show("Added Successfully");
            //    }

            //}
            //catch (Exception ex)
            //{

            //    MessageBox.Show(ex.Message, "Error Message");
            //}
            //finally
            //{
            //    _sqlCon.Close();
            //}

        }

        private void Logo_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void metroTile6_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            try
            {
                FillDataGridView(txtSearch.Text.Trim());
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error Message");
            }

        }

        private void picPW_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }


        void FillDataGridView(string lastName)
        {
            if (_sqlCon.State == ConnectionState.Closed) //check if the connection is closed
                _sqlCon.Open();
            SqlDataAdapter sqlDa = new SqlDataAdapter("StudentViewOrSearch", _sqlCon);
            sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
            sqlDa.SelectCommand.Parameters.AddWithValue("@LastNAME", lastName);
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);
            metroGrid1.DataSource = dtbl;
            metroGrid1.Columns[0].Visible = false; //Hides Student ID columns
            _sqlCon.Close();

        }
        void FillDataGrid(string UserType)
        {
            if (_sqlCon.State == ConnectionState.Closed) //check if the connection is closed
                _sqlCon.Open();
            SqlDataAdapter sqlDa = new SqlDataAdapter(UserType, _sqlCon);
            sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;            
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);
            metroGrid1.DataSource = dtbl;
            metroGrid1.Columns[0].Visible = false; //Hides Student ID columns
            _sqlCon.Close();
        }


        private void metroTextBox1_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox2_Click(object sender, EventArgs e)
        {
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
        }

        private void dataGridView1_DoubleClick_1(object sender, EventArgs e)
        {

        }

        private void btnFrmClear_Click(object sender, EventArgs e)
        {
            metroGrid1.DataSource = null;
            metroGrid1.Refresh();
            txteditFirstName.Clear();
            txteditLastName.Clear();
            txteditemail.Clear();
            txtEditPW.Clear();
            txtSearch.Clear();
            chkIsAdmin.Checked = false;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            metroGrid1.DataSource = null;
            try
            {
                FillDataGridView(txtSearch.Text.Trim());
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error Message");
            }
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {

        }

        private void picReload_Click(object sender, EventArgs e)
        {

        }

        private void picSave_Click(object sender, EventArgs e)
        {

        }

        private void metroTile4_Click(object sender, EventArgs e)
        {

        }

        private void picEdit_Click(object sender, EventArgs e)
        {

        }


        public static void FillDropDownList(string Query, ComboBox comboTeacherName, SqlConnection cn)
        {
            DataTable dt = new DataTable();
            var cmd = new SqlCommand(Query, cn);
            try
            {
                if (cn.State == ConnectionState.Closed)
                {
                    cn.Open();
                }
                dt.Load(cmd.ExecuteReader());
                comboTeacherName.DataSource = dt;
                comboTeacherName.ValueMember = "TeacherLastName";
                comboTeacherName.DisplayMember = "Teacher's Name";
            }
            catch (SqlException e)
            {
                MessageBox.Show("There was an error accessing your data. DETAIL: " + e.Message);
            }
            finally
            {
                cn.Close();
            }
        }

        public static void FillNameDropDownList(string Query, ComboBox ComboName, SqlConnection cn)
        {

            DataTable dt = new DataTable();
            var cmd = new SqlCommand(Query, cn);
            try
            {
                if (cn.State == ConnectionState.Closed)
                {
                    cn.Open();
                }

                dt.Load(cmd.ExecuteReader());
                ComboName.DataSource = dt;
                ComboName.ValueMember = "LastName";
                ComboName.DisplayMember = "Student Last Name";
            }
            catch (SqlException e)
            {
                MessageBox.Show("There was an error accessing your data. DETAIL: " + e.Message);
            }
            finally
            {
                cn.Close();
            }
        }

        private void comboTeacherName_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillNameDropDownList(("Select Student.LastName from Student Inner join Teachers on Student.TeacherID=Teachers.TeacherID Where Teachers.TeacherLastName = " + "'" + comboTeacherName.Text + "'"), ComboName, _sqlCon);
        }

        private void tabMain_Selected(object sender, TabControlEventArgs e)
        {
           
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabAddEdit_Click(object sender, EventArgs e)
        {

        }

        public void hideTab(Boolean showTab)
        {
            if (showTab)
            {
                tabMain.TabPages.Remove(tabAddEdit);
            }
            else
            {
                tabMain.TabPages.Add(tabAddEdit);
            }
        }

        private void tabPWGenerator_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            login AdminFRM = new login();
            AdminFRM.ShowDialog();
        }

        private void metroButton1_Click_1(object sender, EventArgs e)
        {
            InitilizeForm();
        }

        private void metroButton2_Click_1(object sender, EventArgs e)
        {
            using (AddUserForm frm = new AddUserForm())
            {
                frm.ShowDialog();
            }
        }

        private void metroButton2_Click_2(object sender, EventArgs e)
        {
            using (AddUserForm frm = new AddUserForm())
            {
                frm.ShowDialog();
            }
        }

        private void picDel_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView_DoubleClick(object sender, EventArgs e)
        {
            if (metroGrid1.CurrentRow.Index != -1) //Check if the current DataGrid is selected 
            {
                UserID = Convert.ToInt32(metroGrid1.CurrentRow.Cells[0].Value.ToString());
                txteditFirstName.Text = metroGrid1.CurrentRow.Cells[1].Value.ToString();
                txteditLastName.Text = metroGrid1.CurrentRow.Cells[2].Value.ToString();
                txteditemail.Text = metroGrid1.CurrentRow.Cells[3].Value.ToString();
                comboTeacherLastName.Text = metroGrid1.CurrentRow.Cells[5].Value.ToString();
                txtEditPW.Text = metroGrid1.CurrentRow.Cells[6].Value.ToString();
                picSave.Enabled = true;
                picDel.Enabled = true;
            }
        }

        private void picSave_Click_1(object sender, EventArgs e)
        {
            DialogResult save = MessageBox.Show("Save Changes to Database?", "Please Confirm", MessageBoxButtons.YesNo);
            if (save == DialogResult.No)
            {
                return;
            }
            else
            {
                try
                {
                    if (_sqlCon.State == ConnectionState.Closed)
                    {
                        _sqlCon.Open();                       
                        SqlCommand sqlCmd = new SqlCommand("EditUser", _sqlCon);
                        sqlCmd.CommandType = CommandType.StoredProcedure;                   
                        sqlCmd.Parameters.AddWithValue("@UserID", UserID);
                        sqlCmd.Parameters.AddWithValue("@FirstNAME", txteditFirstName.Text.Trim());
                        sqlCmd.Parameters.AddWithValue("@LastNAME", txteditLastName.Text.Trim());
                        sqlCmd.Parameters.AddWithValue("@Email", txteditemail.Text.Trim());
                        sqlCmd.Parameters.AddWithValue("@TeacherLastName", comboTeacherLastName.Text.Trim());
                        sqlCmd.Parameters.AddWithValue("@Password", txtEditPW.Text.Trim());
                        sqlCmd.Parameters.AddWithValue("@Admin", chkIsAdmin.Checked);
                        sqlCmd.ExecuteNonQuery();
                        MessageBox.Show("Record Updated Successfully");
                        FillDataGridView(""); //refresh the DataGrid
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

        private void rdoStudentInfo_CheckedChanged(object sender, EventArgs e)
        {            
            FillDataGrid("StudentData");
            FormatDataGridHeader("Student");
            lblEditTeachLName.Visible = true;
            comboTeacherLastName.Visible = true;
            chkIsAdmin.Visible = false;
        }

        private void FormatDataGridHeader(string UserType)
        {
            metroGrid1.Columns[0].Visible = false; //Hides Student ID columns 
            metroGrid1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            if (UserType == "Teacher")
            {
                metroGrid1.Columns[1].HeaderCell.Value = "First Name";
                metroGrid1.Columns[2].HeaderCell.Value = "Last Name";
                metroGrid1.Columns[3].HeaderCell.Value = "Email / Login";
                metroGrid1.Columns[4].HeaderCell.Value = "Password";
                metroGrid1.Columns[5].HeaderCell.Value = "Admin";
            }            
            else 
            {
                metroGrid1.Columns[1].HeaderCell.Value = "First Name";
                metroGrid1.Columns[2].HeaderCell.Value = "Last Name";
                metroGrid1.Columns[3].HeaderCell.Value = "Email / Login";
                metroGrid1.Columns[4].HeaderCell.Value = "Teacher";
                metroGrid1.Columns[5].HeaderCell.Value = "Password";
            }
        }

        private void rdoTeacherInfo_CheckedChanged(object sender, EventArgs e)
        {
            FillDataGrid("TeacherData");
            FormatDataGridHeader("Teacher");
            lblEditTeachLName.Visible = false;
            comboTeacherLastName.Visible = false;
            chkIsAdmin.Visible = true;
        }

        private void ComboName_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        public void InitilizeForm()
        {
            {// Fill DataGrid with Default Student information
                FillDataGrid("StudentData");
                FormatDataGridHeader("Student");
            }
            {//Populate Drop down menus for Main and Admin Tabs
                FillDropDownList(TeacherdropSelectCommand, comboTeacherLastName, _sqlCon); // Group Teacher name
                FillDropDownList(TeacherdropSelectCommand, comboTeacherName, _sqlCon); //Group Teacher by Name for Add Form
                FillNameDropDownList(("Select Student.LastName from Student Inner join Teachers on Student.TeacherID=Teachers.TeacherID Where Teachers.TeacherLastName = " + "'" + comboTeacherName.Text + "'"), ComboName, _sqlCon);
            }
            { //Hide Teacher specific controllers to set default mode to Student
                rdoStudentInfo.Checked = true;
                lblEditTeachLName.Visible = true;
                comboTeacherLastName.Visible = true;
                chkIsAdmin.Visible = false;
            }
        }
    }      
}