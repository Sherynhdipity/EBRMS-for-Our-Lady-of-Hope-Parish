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
    public partial class frmAddSchedule : Form
    {
        public frmAddSchedule()
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
            cmbTime.SelectedIndex = 0;
        }

        //AddSchedule
        public void AddSchedule()
        {
            con.Close();

            if (cmbTime.SelectedIndex == -1)
            {
                MessageBox.Show("There is no Time Selected!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                result = MessageBox.Show("Do you want to Add this Schedule?", "Add Schedule", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    con.Close();
                    con.Open();
                    QuerySelect = "SELECT * FROM tblSchedule WHERE s_Date = @sDate AND s_Time = @sTime";

                    cmd = new SqlCommand(QuerySelect, con);
                    cmd.Parameters.AddWithValue("@sDate", dtpAvailableSched.Value.Date);
                    cmd.Parameters.AddWithValue("@sTime", cmbTime.SelectedItem.ToString());

                    reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        MessageBox.Show("There an existing Schedule Already!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        try
                        {
                            con.Close();
                            con.Open();
                            QueryInsert = "INSERT INTO tblSchedule (s_Date,s_Time)" +
                            "VALUES (@sDate, @sTime)";

                            cmd = new SqlCommand(QueryInsert, con);
                            cmd.Parameters.AddWithValue("@sDate", dtpAvailableSched.Value.Date);
                            cmd.Parameters.AddWithValue("@sTime", cmbTime.SelectedItem.ToString());

                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Schedule Added Successfully!", "Add Schedule", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                else
                {
                    MessageBox.Show("Please Provide Details!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            AddSchedule();
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtpAvailableSched_ValueChanged(object sender, EventArgs e)
        {
            if (DateTime.Today > dtpAvailableSched.Value)
            {
                MessageBox.Show("The selected date is Invalid!");
                dtpAvailableSched.Value = DateTime.Today;
            }
        }
    }
}

