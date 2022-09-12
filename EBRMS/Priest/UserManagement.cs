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

            btn1.Name = "";
            btn1.Text = "Activate";
            btn1.UseColumnTextForButtonValue = true;

            dgvUsers.Columns.Add(btn);
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
            DisplayUser();
        }

        private void dgvUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvUsers[e.ColumnIndex, e.RowIndex] is DataGridViewButtonCell)
            {
                updateUser.Id = dgvUsers[1, e.RowIndex].Value.ToString();
                updateUser.ShowDialog();
            }
        }
    }
}
