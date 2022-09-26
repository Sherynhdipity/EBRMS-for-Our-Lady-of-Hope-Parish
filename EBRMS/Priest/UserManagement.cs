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
using System.Text.RegularExpressions;

namespace EBRMS.Priest
{
    public partial class ucUserManagement : UserControl
    {
        public ucUserManagement()
        {
            InitializeComponent();

            addNew.FormClosed += new FormClosedEventHandler(Form_Closed);
            updateUser.FormClosed += new FormClosedEventHandler(Form_Closed1);
            DisplayUser();
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            DataGridViewButtonColumn btn1 = new DataGridViewButtonColumn();

            btn.Name = "";
            btn.Text = "Update";
            btn.UseColumnTextForButtonValue = true;

            dgvUsers.Columns.Add(btn);
        }

        //clear controls
        public void ClearControls()
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            txtUsername.Clear();
            txtPassword.Clear();
            txtConfirmPass.Clear();
            cmbRole.SelectedIndex = 0;
        }

        void Form_Closed(object sender, FormClosedEventArgs e)
        {
            frmAddUser frm = (frmAddUser)sender;
            DisplayUser();
        }

        void Form_Closed1(object sender, FormClosedEventArgs e)
        {
            frmUpdateUser frm = (frmUpdateUser)sender;
            DisplayUser();
        }


        private static ucUserManagement users;

        public static ucUserManagement usersInstance
        {
            get
            {
                if (users == null)
                    users = new ucUserManagement();
                return users;
            }

        }

        frmAddUser addNew = new frmAddUser();
        frmUpdateUser updateUser = new frmUpdateUser();

        public static SqlConnection con = new SqlConnection(DBConnection.con);
        public static SqlCommand cmd = new SqlCommand();
        public static SqlDataReader reader;
        public static SqlDataAdapter adapter;
        public static DataTable dt = new DataTable();
        public static DialogResult result;
        public static string QueryInsert;
        public static string QuerySelect;
        public static string QueryUpdate;


        //DISPLAY USER DATA IN DATAGRID
        public void DisplayUser()
        {
            try
            {
                con.Open();

                if (txtViewUsers.Text == "" || txtViewUsers.Text == null)
                {
                    QuerySelect = "SELECT * FROM vwUsers";
                }
                else
                {
                    QuerySelect = "SELECT * FROM  vwUsers WHERE ([First Name] LIKE '%' + @fName + '%') OR ([Last Name] LIKE '%' + @lName + '%') OR (Username LIKE '%' + @userName + '%') OR ([Role] LIKE '%' + @userType + '%')";
                }

                cmd = new SqlCommand(QuerySelect, con);
                cmd.Parameters.AddWithValue("@fName", txtViewUsers.Text);
                cmd.Parameters.AddWithValue("@lName", txtViewUsers.Text);
                cmd.Parameters.AddWithValue("@userName", txtViewUsers.Text);
                cmd.Parameters.AddWithValue("@userType", txtViewUsers.Text);

                adapter = new SqlDataAdapter(cmd);
                dt = new DataTable();
                adapter.Fill(dt);
                dgvUsers.DataSource = dt;

                dgvUsers.Refresh();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        //UpdateUser
        public void UpdateUser()
        {
            con.Close();

            if (String.IsNullOrEmpty(txtFirstName.Text))
            {
                MessageBox.Show("Enter First Name!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFirstName.Focus();
            }
            else if (String.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                MessageBox.Show("Whitespace is not allowed!");
                txtFirstName.Clear();
            }
            else if (String.IsNullOrEmpty(txtLastName.Text))
            {
                MessageBox.Show("Enter Last Name!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLastName.Focus();
            }
            else if (String.IsNullOrWhiteSpace(txtLastName.Text))
            {
                MessageBox.Show("Whitespace is not allowed!");
                txtLastName.Clear();
            }
            else if (String.IsNullOrEmpty(txtUsername.Text))
            {
                MessageBox.Show("Enter Username!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsername.Focus();
            }
            else if (String.IsNullOrWhiteSpace(txtUsername.Text))
            {
                MessageBox.Show("Whitespace is not allowed!");
                txtUsername.Clear();
            }
            else if (String.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Enter Password!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
            }
            else if (String.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Whitespace is not allowed!");
                txtPassword.Clear();
            }
            else if (String.IsNullOrEmpty(txtConfirmPassword.Text))
            {
                MessageBox.Show("Enter Confirm Password!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtConfirmPassword.Focus();
            }
            else if (String.IsNullOrWhiteSpace(txtConfirmPassword.Text))
            {
                MessageBox.Show("Whitespace is not allowed!");
                txtConfirmPassword.Clear();
            }
            else if (!Regex.IsMatch(txtPassword.Text, @"^(?=.*[a-z]).{8,15}$"))
            {
                MessageBox.Show("Password is minimum of 8 characters");
                txtPassword.Clear();
            }
            else if (!Regex.IsMatch(txtPassword.Text, @"^(?=.*[A-Z])"))
            {
                MessageBox.Show("Password must have atleast 1 Uppercase letter");
            }
            else if (!Regex.IsMatch(txtPassword.Text, @"^(?=.*[@$!%*#?&_])"))
            {
                MessageBox.Show("Password must have atleast 1 special characters");
            }
            else if (!Regex.IsMatch(txtFirstName.Text, @"^([a-zA-Z-.]+?)([-\s'][a-zA-Z]+)*?$"))
            {
                MessageBox.Show("First Name must be in letters only");
            }
            else if (txtFirstName.Text != "" && txtLastName.Text != "" && txtContactNo.Text != "")
            {
                result = MessageBox.Show("Do you want to update this User?", "Update User", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        con.Close();
                        con.Open();

                        QueryUpdate = "UPDATE tblClient SET c_FN = @fName, c_MN = @mName, c_LN = @lName, c_ContactNo = @cNo, Province = @cProv, Municipality = @cMun, Barangay = @cBrgy WHERE clientID = (SELECT clientID FROM tblClient WHERE c_FN = @fName  AND c_MN = @mName AND c_LN = @lName)";

                        cmd = new SqlCommand(QueryUpdate, con);

                        cmd.Parameters.AddWithValue("@fName", txtFirstName.Text);
                        cmd.Parameters.AddWithValue("@mName", txtMiddleName.Text);
                        cmd.Parameters.AddWithValue("@lName", txtLastName.Text);
                        cmd.Parameters.AddWithValue("@cNo", txtContactNo.Text);
                        cmd.Parameters.AddWithValue("@cProv", cmbProvince.Text);
                        cmd.Parameters.AddWithValue("@cMun", cmbMunicipality.Text);
                        cmd.Parameters.AddWithValue("@cBrgy", cmbBarangay.Text);

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Client Updated Successfully!", "Update Client", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearControls();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        con.Close();
                    }
                    finally
                    {
                        con.Close();
                    }

                    DisplayClients();
                    ClearControls();
                    pnlClientInfo.Visible = false;
                }
            }
            else
            {
                MessageBox.Show("Please Provide Details!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void txtViewUsers_TextChange(object sender, EventArgs e)
        {
            DisplayUser();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            frmAddUser addUser = new frmAddUser();
            addUser.Show();
        }

        private void ucUserManagement_Load(object sender, EventArgs e)
        {
            timer1 = new System.Windows.Forms.Timer();
            timer1.Interval = 5000;
            timer1.Tick += new System.EventHandler(timer1_Tick);
            timer1.Start();
        }

        private void dgvUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvUsers[e.ColumnIndex, e.RowIndex] is DataGridViewButtonCell)
            {
                updateUser.Id = dgvUsers[1, e.RowIndex].Value.ToString();
                updateUser.ShowDialog();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DisplayUser();
        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            ClearControls();
            pnlUserInfo.Visible = true;
            dgvUsers.Enabled = true;
            btnSave.Visible = false;
            btnUpdate.Visible = true;
        }
    }
}
