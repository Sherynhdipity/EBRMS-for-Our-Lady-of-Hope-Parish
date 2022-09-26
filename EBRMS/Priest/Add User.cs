using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace EBRMS.Priest
{
    public partial class frmAddUser : Form
    {
        public frmAddUser()
        {
            InitializeComponent();
        }

        public static SqlConnection con = new SqlConnection(DBConnection.con);
        public static SqlCommand cmd = new SqlCommand();
        public static SqlDataReader reader;
        public static SqlDataAdapter adapter;
        public static DataTable dt = new DataTable();
        public static DialogResult result;
        public static string QueryInsert;
        public static string QuerySelect;

        //clear controls
        public void ClearControls()
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            txtUsername.Clear();
            txtPassword.Clear();
            txtConfirmPassword.Clear();
            cmbRole.SelectedIndex = 0;
        }

        //AddUser
        public void AddUser()
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

            else if (!Regex.IsMatch(txtLastName.Text, @"^([a-zA-Z-.]+?)([-\s'][a-zA-Z]+)*?$"))
            {
                MessageBox.Show("Last name must be in letters only");

            }
            else if (txtFirstName.Text != "" && txtLastName.Text != "" && txtUsername.Text != "" && txtPassword.Text != "" && txtConfirmPassword.Text != "")
            {
                if (txtPassword.Text == txtConfirmPassword.Text)
                {
                    result = MessageBox.Show("Do you want to Add this User?", "Add User", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        con.Close();
                        con.Open();
                        QuerySelect = "SELECT * FROM tblUsers WHERE Username = @uName";

                        cmd = new SqlCommand(QuerySelect, con);
                        cmd.Parameters.AddWithValue("@uName", txtUsername.Text);

                        reader = cmd.ExecuteReader();

                        if (reader.HasRows)
                        {
                            MessageBox.Show("This user already exists!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtUsername.Clear();
                        }
                        else
                        {
                            try
                            {
                                con.Close();
                                con.Open();
                                QueryInsert = "INSERT INTO tblUsers (username,firstName, lastName, password,userType)" +
                                "VALUES (@username, @fName, @lName,@password, @userType)";

                                cmd = new SqlCommand(QueryInsert, con);

                                cmd.Parameters.AddWithValue("@fName", txtFirstName.Text);
                                cmd.Parameters.AddWithValue("@lName", txtLastName.Text);
                                cmd.Parameters.AddWithValue("@userName", txtUsername.Text);
                                cmd.Parameters.AddWithValue("@password", txtPassword.Text);
                                cmd.Parameters.AddWithValue("@userType", cmbRole.SelectedItem.ToString());

                                cmd.ExecuteNonQuery();

                                MessageBox.Show("User Added Successfully!", "Add User", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                                ClearControls();

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

                    }

                }
                else
                {
                    MessageBox.Show("Passwords Don't Match!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtConfirmPassword.Focus();
                }
            }
            else
            {
                MessageBox.Show("Please Provide Details!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            AddUser();
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAddUser_Load(object sender, EventArgs e)
        {

        }
    }
}
