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
using EBRMS.Priest;
using EBRMS.Secretary;
using EBRMS.Treasurer;



namespace EBRMS
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        public static SqlConnection con = new SqlConnection(DBConnection.con);
        public static SqlCommand cmd;
        public static SqlDataReader reader;
        public static string QuerySelect;
        public static string GetUserID;
        public static string GetUserName;
        public static string GetUserUsername;
        public static string GetUserRole;
        public static string GetUserStatus;

        private void ClearControls()
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtUsername.Focus();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                MessageBox.Show("Enter your Username first", "Login", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtUsername.Focus();
            }
            else if (txtPassword.Text == "")
            {
                MessageBox.Show("Enter your Password first", "Login", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtPassword.Focus();
            }
            else
            {

                try
                {

                    if (con.State == ConnectionState.Open)
                    {
                        con.Close();
                    }

                    con.Open();

                    QuerySelect = "Select UserID, Username, FirstName, LastName, Password, UserType from tblUsers WHERE Username= @uName AND Password= @pass";
                    cmd = new SqlCommand(QuerySelect, con);
                    cmd.Parameters.AddWithValue("@uName", txtUsername.Text);
                    cmd.Parameters.AddWithValue("@pass", txtPassword.Text);
                    reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        reader.Read();
                        string fName = reader["FirstName"].ToString();
                        string lName = reader["LastName"].ToString();

                        GetUserID = reader["UserID"].ToString();
                        GetUserName = fName + " " + lName;
                        GetUserUsername = reader["Username"].ToString();
                        GetUserRole = reader["UserType"].ToString();

                        switch (reader[5].ToString())
                        {
                            case "Priest":
                                {
                                    MessageBox.Show("Welcome user " + GetUserName + "\n" + GetUserRole);
                                    frmMainPriest frmPriest = new frmMainPriest();
                                    frmPriest.Show();
                                    this.Hide();
                                    break;
                                }
                            case "Secretary":
                                {
                                    MessageBox.Show("Welcome user " + GetUserName + "\n" + GetUserRole);
                                    frmMainSecretary frmSecretary = new frmMainSecretary();
                                    frmSecretary.Show();
                                    this.Hide();
                                    break;
                                }
                            case "Treasurer":
                                {
                                    MessageBox.Show("Welcome user " + GetUserName + "\n" + GetUserRole);
                                    frmMainTreasurer frmTreasurer = new frmMainTreasurer();
                                    frmTreasurer.Show();
                                    this.Hide();
                                    break;
                                }
                            default:
                                {
                                    MessageBox.Show("Enter Correct Username and Password");
                                    break;
                                }
                        }
                        //}
                        con.Close();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Account! Try Again", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        ClearControls();
                    }
                    con.Close();

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message + ex.StackTrace);

                }
                finally
                {

                    con.Close();

                }

            }
            con.Close();

        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}

