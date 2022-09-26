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

namespace EBRMS.Treasurer
{
    public partial class frmUpdateClient : Form
    {
        public frmUpdateClient()
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
            txtMiddleName.Clear();
            txtContactNo.Clear();
            cmbProvince.SelectedIndex = 0;
            cmbMunicipality.SelectedIndex = 0;
            cmbBarangay.SelectedIndex = 0;
        }

        //UpdateClient
        public void UpdateClient()
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
            else if (!Regex.IsMatch(txtFirstName.Text, @"^([a-zA-Z-.]+?)([-\s'][a-zA-Z]+)*?$"))
            {
                MessageBox.Show("First Name must be a letter only");
            }
            else if (!Regex.IsMatch(txtLastName.Text, @"^([a-zA-Z-.]+?)([-\s'][a-zA-Z]+)*?$"))
            {
                MessageBox.Show("Last name must be letter only");

            }
            else if (!Regex.IsMatch(txtMiddleName.Text, @"^([a-zA-Z-.]+?)([-\s'][a-zA-Z]+)*?$"))
            {
                MessageBox.Show("Middle Name must be a letter only");
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

                        QueryUpdate = "UPDATE tblClient SET c_FN = @fName, c_MN = @mName, c_LN = @lName, c_ContactNo = @cNo, Province = @cProv, Municipality = @cMun, Barangay = @cBrgy WHERE clientID = '" + id + "'";

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
                MessageBox.Show("Please Provide Details!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void loadProvinces()
        {
            con.Close();
            con.Open();
            QuerySelect = "Select * From tblProvinces WHERE psg_code = '126500000'";
            cmd = new SqlCommand(QuerySelect, con);
            adapter = new SqlDataAdapter(cmd);
            dt = new DataTable();
            adapter.Fill(dt);
            cmd.ExecuteNonQuery();
            con.Close();

            cmbProvince.DisplayMember = "province_desc";
            cmbProvince.ValueMember = "province_code";
            cmbProvince.DataSource = dt;

        }

        public void loadMunicipalities()
        {
            if (cmbProvince.SelectedIndex == 0)
            {
                con.Close();
                con.Open();
                QuerySelect = "Select * From tblMunicipality Where province_code = '" + cmbProvince.SelectedValue + "' Order by municipality_desc ASC";
                cmd = new SqlCommand(QuerySelect, con);
                adapter = new SqlDataAdapter(cmd);
                dt = new DataTable();
                adapter.Fill(dt);
                cmd.ExecuteNonQuery();
                con.Close();

                cmbMunicipality.DisplayMember = "municipality_desc";
                cmbMunicipality.ValueMember = "municipality_code";
                cmbMunicipality.DataSource = dt;
            }
            else
            {

                try
                {

                    con.Close();
                    con.Open();
                    QuerySelect = "Select * From tblMunicipality Where province_code = '" + cmbProvince.SelectedValue + "' Order by municipality_desc ASC";
                    cmd = new SqlCommand(QuerySelect, con);
                    adapter = new SqlDataAdapter(cmd);
                    dt = new DataTable();
                    adapter.Fill(dt);
                    cmd.ExecuteNonQuery();
                    con.Close();

                    cmbMunicipality.DisplayMember = "municipality_desc";
                    cmbMunicipality.ValueMember = "municipality_code";
                    cmbMunicipality.DataSource = dt;



                    con.Open();
                    QuerySelect = "SELECT Municipality from tblClient WHERE clientID = '" + id + "'";


                    cmd = new SqlCommand(QuerySelect, con);
                    adapter = new SqlDataAdapter(cmd);
                    dt = new DataTable();
                    adapter.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        cmbMunicipality.SelectedValue = dt.Rows[0][0].ToString();
                    }
                    else
                    {
                        cmbMunicipality.SelectedIndex = 0;
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

        }

        public void loadBarangays()
        {
            if (cmbMunicipality.SelectedIndex == 0)
            {
                con.Close();
                con.Open();
                QuerySelect = "Select * From tblBarangay Where municipality_code = '" + cmbMunicipality.SelectedValue + "' Order by brgy_desc ASC";
                cmd = new SqlCommand(QuerySelect, con);
                adapter = new SqlDataAdapter(cmd);
                dt = new DataTable();
                adapter.Fill(dt);
                cmd.ExecuteNonQuery();
                con.Close();

                cmbBarangay.DisplayMember = "brgy_desc";
                cmbBarangay.ValueMember = "brgy_code";
                cmbBarangay.DataSource = dt;
            }
            else
            {

                try
                {

                    con.Close();
                    con.Open();
                    QuerySelect = "Select * From tblBarangay Where municipality_code = '" + cmbMunicipality.SelectedValue + "' Order by brgy_desc ASC";
                    cmd = new SqlCommand(QuerySelect, con);
                    adapter = new SqlDataAdapter(cmd);
                    dt = new DataTable();
                    adapter.Fill(dt);
                    cmd.ExecuteNonQuery();
                    con.Close();

                    cmbBarangay.DisplayMember = "brgy_desc";
                    cmbBarangay.ValueMember = "brgy_code";
                    cmbBarangay.DataSource = dt;



                    con.Open();
                    QuerySelect = "SELECT Barangay from tblClient WHERE clientID = '" + id + "'";


                    cmd = new SqlCommand(QuerySelect, con);
                    adapter = new SqlDataAdapter(cmd);
                    dt = new DataTable();
                    adapter.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        cmbBarangay.SelectedValue = dt.Rows[0][0].ToString();
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

        }

        //Display Client
        public void DisplayClient()
        {
            loadProvinces();

            try
            {
                con.Open();
                QuerySelect = "SELECT * from tblClient WHERE clientID = '" + id + "'";


                cmd = new SqlCommand(QuerySelect, con);
                adapter = new SqlDataAdapter(cmd);
                dt = new DataTable();
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    txtFirstName.Text = dt.Rows[0]["c_FN"].ToString();
                    txtMiddleName.Text = dt.Rows[0]["c_MN"].ToString();
                    txtLastName.Text = dt.Rows[0]["c_LN"].ToString();
                    txtContactNo.Text = dt.Rows[0]["c_ContactNo"].ToString();
                    cmbProvince.SelectedValue = dt.Rows[0]["Province"].ToString();                    
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

        public void setProvince()
        {
            con.Close();
            con.Open();
            QuerySelect = "SELECT province_desc FROM tblProvinces WHERE province_desc = (SELECT Province FROM tblClient WHERE clientID = '" + id + "')";
            cmd = new SqlCommand(QuerySelect, con);
            adapter = new SqlDataAdapter(cmd);
            dt = new DataTable();
            adapter.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                cmbMunicipality.SelectedIndex = cmbMunicipality.FindString(dt.Rows[0]["province_desc"].ToString());
            }
        }

        public void setMunicipality()
        {
            con.Close();
            con.Open();
            QuerySelect = "SELECT municipality_desc from tblMunicipality WHERE municipality_desc = (SELECT Municipality FROM tblClient WHERE clientID = '" + id + "')";
            cmd = new SqlCommand(QuerySelect, con);
            adapter = new SqlDataAdapter(cmd);
            dt = new DataTable();
            adapter.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                cmbMunicipality.SelectedIndex = cmbMunicipality.FindString(dt.Rows[0]["municipality_desc"].ToString());
            }
        }

        public void setBarangay()
        {
            con.Close();
            con.Open();
            QuerySelect = "SELECT brgy_desc from tblBarangay WHERE brgy_desc = (SELECT Barangay FROM tblClient WHERE clientID = '" + id + "')";
            cmd = new SqlCommand(QuerySelect, con);
            adapter = new SqlDataAdapter(cmd);
            dt = new DataTable();
            adapter.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                cmbBarangay.SelectedIndex = cmbBarangay.FindString(dt.Rows[0]["brgy_desc"].ToString());
            }
        }


        private void pbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            UpdateClient();
        }

        private void frmUpdateClient_Load(object sender, EventArgs e)
        {
            DisplayClient();
            setProvince();
            setMunicipality();
            setBarangay();
        }

        private void cmbProvince_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadMunicipalities();
        }

        private void cmbMunicipality_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadBarangays();
        }
    }
}
