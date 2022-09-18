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
    public partial class frmUpdateUser : Form
    {
        public frmUpdateUser()
        {
            InitializeComponent();
        }

        public static SqlConnection con = new SqlConnection(DBConnection.con);
        public static SqlCommand cmd = new SqlCommand();
        public static SqlDataReader reader;
        public static SqlDataAdapter adapter;
        public static DataTable dt = new DataTable();
        public static DialogResult result;
        public static string QueryUpdate;
        public static string QuerySelect;

        private string id;
        public string Id
        {
            get { return id; }
            set { id = value; }
        }

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

            }
            else if (String.IsNullOrEmpty(txtLastName.Text))
            {
                MessageBox.Show("Enter Last Name!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (String.IsNullOrWhiteSpace(txtLastName.Text))
            {
                MessageBox.Show("Whitespace is not allowed!");

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
                MessageBox.Show("Password must be 8 characters");

            }
            else if (!Regex.IsMatch(txtPassword.Text, @"^(?=.*[A-Z])"))
            {
                MessageBox.Show("Password must be have atleast 1 Uppercase letter");
            }
            else if (!Regex.IsMatch(txtPassword.Text, @"^(?=.*[@$!%*#?&_])"))
            {
                MessageBox.Show("Password must have atleast 1 special characters");
            }
            else if (!Regex.IsMatch(txtFirstName.Text, @"^([a-zA-Z-.]+?)([-\s'][a-zA-Z]+)*?$"))
            {
                MessageBox.Show("First Name must be a letter only");
            }

            else if (!Regex.IsMatch(txtLastName.Text, @"^([a-zA-Z-.]+?)([-\s'][a-zA-Z]+)*?$"))
            {
                MessageBox.Show("Last name must be letter only");

            }
            else if (!Regex.IsMatch(txtUsername.Text, @"^[A-Za-z0-9_!@#$%^&*()+={}[]*$"))
            {
                MessageBox.Show("Invalid Username");
            }

            else if (txtFirstName.Text != "" && txtLastName.Text != "" && txtUsername.Text != "" && txtPassword.Text != "" && txtConfirmPassword.Text != "")
            {
                if (txtPassword.Text == txtConfirmPassword.Text)
                {
                    result = MessageBox.Show("Do you want to update this User?", "Update User", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            con.Close();
                            con.Open();

                            QueryUpdate = "UPDATE tblUsers SET firstName = @fName, lastName = @lName, username = @userName, password = @password,userType = @userType WHERE userID = '" + id + "'";

                            cmd = new SqlCommand(QueryUpdate, con);

                            cmd.Parameters.AddWithValue("@fName", txtFirstName.Text);
                            cmd.Parameters.AddWithValue("@lName", txtLastName.Text);                           
                            cmd.Parameters.AddWithValue("@userName", txtUsername.Text);
                            cmd.Parameters.AddWithValue("@password", txtPassword.Text);
                            cmd.Parameters.AddWithValue("@userType", cmbRole.SelectedItem.ToString());
                            cmd.ExecuteNonQuery();

                            MessageBox.Show("User Updated Successfully!", "Update User", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();

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
                    }
                }

                else
                {
                    MessageBox.Show("Password Don't Match!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtConfirmPassword.Focus();
                }

            }
            else
            {
                MessageBox.Show("Please Provide Details!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //Display User
        public void DisplayUser()
        {

            try
            {
                con.Open();
                QuerySelect = "SELECT * from tblUsers WHERE userID = '" + id + "'";


                cmd = new SqlCommand(QuerySelect, con);
                adapter = new SqlDataAdapter(cmd);
                dt = new DataTable();
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    txtFirstName.Text = dt.Rows[0]["firstName"].ToString(); 
                    txtLastName.Text = dt.Rows[0]["lastName"].ToString();
                    txtUsername.Text = dt.Rows[0]["username"].ToString();
                    txtPassword.Text = dt.Rows[0]["password"].ToString();
                    txtConfirmPassword.Text = dt.Rows[0]["password"].ToString();
                    if (dt.Rows[0]["userType"].ToString() == "Priest")
                    {
                        cmbRole.SelectedIndex = 0;
                    }
                    else if (dt.Rows[0]["userType"].ToString() == "Secretary")
                    {
                        cmbRole.SelectedIndex = 1;
                    }
                    else if (dt.Rows[0]["user_type"].ToString() == "Treasurer")
                    {
                        cmbRole.SelectedIndex = 2;
                    }

                }

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


        private void btnSave_Click(object sender, EventArgs e)
        {
            UpdateUser();
        }

        private void frmUpdateUser_Load(object sender, EventArgs e)
        {
            DisplayUser();
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
