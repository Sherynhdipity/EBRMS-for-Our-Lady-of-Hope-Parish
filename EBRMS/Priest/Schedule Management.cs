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
    public partial class ucScheduleManagement : UserControl
    {
        public ucScheduleManagement()
        {
            InitializeComponent();

            addNewSched.FormClosed += new FormClosedEventHandler(Form_Closed);
            updateSched.FormClosed += new FormClosedEventHandler(Form_Closed1);
            DisplaySchedule();
            DataGridViewButtonColumn btnupdate = new DataGridViewButtonColumn();
            DataGridViewButtonColumn btndelete = new DataGridViewButtonColumn();

            btnupdate.Name = "";
            btnupdate.Text = "Update";
            btnupdate.UseColumnTextForButtonValue = true;

            btndelete.Name = "";
            btndelete.Text = "Delete";
            btndelete.UseColumnTextForButtonValue = true;

            dgvAvailSchedule.Columns.Add(btnupdate);

        }

        void Form_Closed(object sender, FormClosedEventArgs e)
        {
            frmAddSchedule frm = (frmAddSchedule)sender;
            DisplaySchedule();
        }

        void Form_Closed1(object sender, FormClosedEventArgs e)
        {
            frmUpdateSchedule frm = (frmUpdateSchedule)sender;
            DisplaySchedule();
        }


        private static ucScheduleManagement schedule;
        public static ucScheduleManagement scheduleInstance
        {
            get
            {
                if (schedule == null)
                    schedule = new ucScheduleManagement();
                return schedule;
            }

        }

        frmAddSchedule addNewSched = new frmAddSchedule();
        frmUpdateSchedule updateSched = new frmUpdateSchedule();

        public static SqlConnection con = new SqlConnection(DBConnection.con);
        public static SqlCommand cmd = new SqlCommand();
        public static SqlDataReader reader;
        public static SqlDataAdapter adapter;
        public static DataTable dt = new DataTable();
        public static DialogResult result;
        public static string QueryInsert;
        public static string QuerySelect;
        public static string QueryUpdate;

        public void DisplaySchedule()
        {
            try
            {
                QuerySelect = "SELECT * FROM vwAvailableSched";

                cmd = new SqlCommand(QuerySelect, con);
                adapter = new SqlDataAdapter(cmd);
                dt = new DataTable();
                adapter.Fill(dt);
                dgvAvailSchedule.DataSource = dt;
                dgvAvailSchedule.Refresh();
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

        private void btnAddDateTime_Click(object sender, EventArgs e)
        {
            frmAddSchedule addSchedule = new frmAddSchedule();
            addSchedule.Show();
        }

        private void dgvAvailSchedule_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvAvailSchedule[e.ColumnIndex, e.RowIndex] is DataGridViewButtonCell)
            {
                updateSched.Id = dgvAvailSchedule[1, e.RowIndex].Value.ToString();
                updateSched.ShowDialog();
            }
        }
    }
}
