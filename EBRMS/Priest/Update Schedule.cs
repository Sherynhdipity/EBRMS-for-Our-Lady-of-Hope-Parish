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
    public partial class frmUpdateSchedule : Form
    {
        public frmUpdateSchedule()
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
            cmbTime.SelectedIndex = 0;
        }

        //UpdateSched
        public void UpdateSchedule()
        {
            con.Close();
            result = MessageBox.Show("Do you want to update this Schedule?", "Update Schedule", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                try
                {
                    con.Close();
                    con.Open();
                    
                    QueryUpdate = "UPDATE tblSchedule SET s_Date = @sDate, s_Time = @sTime WHERE schedule_id = '" + id + "'";

                    cmd = new SqlCommand(QueryUpdate, con);

                    cmd.Parameters.AddWithValue("@sDate", dtpAvailableSched.Value.Date);
                    cmd.Parameters.AddWithValue("@sTime", cmbTime.SelectedItem.ToString());
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Schedule Updated Successfully!", "Update Schedule", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            else
            {
                MessageBox.Show("Please Provide Details!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //Display Sched
        public void DisplaySchedule()
        {

            try
            {
                con.Open();
                QuerySelect = "SELECT * from tblSchedule WHERE schedule_id = '" + id + "'";


                cmd = new SqlCommand(QuerySelect, con);
                adapter = new SqlDataAdapter(cmd);
                dt = new DataTable();
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {

                    dtpAvailableSched.Value = Convert.ToDateTime(dt.Rows[0]["s_Date"].ToString());

                    if (dt.Rows[0]["s_Time"].ToString() == "6:00 AM - 8:00 AM")
                    {
                        cmbTime.SelectedIndex = 0;
                    }
                    else if (dt.Rows[0]["s_Time"].ToString() == "8:00 AM - 10:00 AM")
                    {
                        cmbTime.SelectedIndex = 1;
                    }
                    else if (dt.Rows[0]["s_Time"].ToString() == "10:00 AM - 12:00 NN")
                    {
                        cmbTime.SelectedIndex = 2;
                    }
                    else if (dt.Rows[0]["s_Time"].ToString() == "12:00 PM - 2:00 PM")
                    {
                        cmbTime.SelectedIndex = 3;
                    }
                    else if (dt.Rows[0]["s_Time"].ToString() == "2:00 PM - 4:00 PM")
                    {
                        cmbTime.SelectedIndex = 4;
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
            UpdateSchedule();
        }

        private void frmUpdateUser_Load(object sender, EventArgs e)
        {
            DisplaySchedule();
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
