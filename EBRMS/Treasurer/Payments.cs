using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EBRMS.Treasurer
{
    public partial class ucPayments : UserControl
    {
        public ucPayments()
        {
            InitializeComponent();
        }

        private static ucPayments payments;

        public static ucPayments paymentsInstance
        {
            get
            {
                if (payments == null)
                    payments = new ucPayments();
                return payments;
            }

        }

        public static SqlConnection con = new SqlConnection(DBConnection.con);
        public static SqlCommand cmd = new SqlCommand();
        public static SqlDataReader reader;
        public static SqlDataAdapter adapter;
        public static DataTable dt = new DataTable();
        public static DialogResult result;
        public static string QueryInsert;
        public static string QueryUpdate;
        public static string QuerySelect;
        public static string GetClientID;


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
            cmbPaymentMode.SelectedIndex = 0;
            cmbPaymentType.SelectedIndex = 0;
        }

        /* ------------------------ CLIENT SUBMODULE------------------------------------*/

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

        //Set Combobox Value Update
        public void setProvince()
        {
            con.Close();
            con.Open();
            QuerySelect = "SELECT province_desc FROM tblProvinces WHERE province_desc = (SELECT Province FROM tblClient WHERE clientID = (SELECT clientID FROM tblClient WHERE c_FN = @fName  AND c_MN = @mName AND c_LN = @lName))";
            cmd = new SqlCommand(QuerySelect, con);
            cmd.Parameters.AddWithValue("@fName", txtFirstName.Text);
            cmd.Parameters.AddWithValue("@mName", txtMiddleName.Text);
            cmd.Parameters.AddWithValue("@lName", txtLastName.Text);
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
            QuerySelect = "SELECT municipality_desc from tblMunicipality WHERE municipality_desc = (SELECT Municipality FROM tblClient WHERE clientID = (SELECT clientID FROM tblClient WHERE c_FN = @fName  AND c_MN = @mName AND c_LN = @lName))";
            cmd = new SqlCommand(QuerySelect, con);
            cmd.Parameters.AddWithValue("@fName", txtFirstName.Text);
            cmd.Parameters.AddWithValue("@mName", txtMiddleName.Text);
            cmd.Parameters.AddWithValue("@lName", txtLastName.Text);
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
            QuerySelect = "SELECT brgy_desc from tblBarangay WHERE brgy_desc = (SELECT Barangay FROM tblClient WHERE clientID = (SELECT clientID FROM tblClient WHERE c_FN = @fName  AND c_MN = @mName AND c_LN = @lName))";
            cmd = new SqlCommand(QuerySelect, con);
            cmd.Parameters.AddWithValue("@fName", txtFirstName.Text);
            cmd.Parameters.AddWithValue("@mName", txtMiddleName.Text);
            cmd.Parameters.AddWithValue("@lName", txtLastName.Text);
            adapter = new SqlDataAdapter(cmd);
            dt = new DataTable();
            adapter.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                cmbBarangay.SelectedIndex = cmbBarangay.FindString(dt.Rows[0]["brgy_desc"].ToString());
            }
        }

        public void loadBarangays()
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


        //Display Client Datagrid in Client Submodule
        public void DisplayClients()
        {
            try
            {
                con.Open();
                if (txtClientSearch.Text == "" || txtClientSearch.Text == null)
                {
                    QuerySelect = "SELECT * FROM vwClients";
                }
                else
                {
                    QuerySelect = "SELECT * FROM  vwClients WHERE ([First Name] LIKE '%' + @fName + '%') OR ([Middle Name] LIKE '%' + @mName + '%') OR ([Last Name] LIKE '%' + @lName + '%') OR ([Contact Number] LIKE '%' + @cNo + '%')";
                }

                cmd = new SqlCommand(QuerySelect, con);
                cmd.Parameters.AddWithValue("@fName", txtClientSearch.Text);
                cmd.Parameters.AddWithValue("@mName", txtClientSearch.Text);
                cmd.Parameters.AddWithValue("@lName", txtClientSearch.Text);
                cmd.Parameters.AddWithValue("@cNo", txtClientSearch.Text);

                adapter = new SqlDataAdapter(cmd);
                dt = new DataTable();
                adapter.Fill(dt);
                dgvClients.DataSource = dt;

                dgvClients.Refresh();
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

        //btnSaveClient details
        void SaveClientDeets()
        {
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
            else if (String.IsNullOrWhiteSpace(txtMiddleName.Text))
            {
                MessageBox.Show("Whitespace is not allowed!");
                txtMiddleName.Clear();
            }
            else if (!Regex.IsMatch(txtFirstName.Text, @"^([a-zA-Z-.]+?)([-\s'][a-zA-Z]+)*?$"))
            {
                MessageBox.Show("First Name must be in letters only");
            }

            else if (!Regex.IsMatch(txtLastName.Text, @"^([a-zA-Z-.]+?)([-\s'][a-zA-Z]+)*?$"))
            {
                MessageBox.Show("Last name must be in letters only");

            }
            else if (!Regex.IsMatch(txtMiddleName.Text, @"^([a-zA-Z-.]+?)([-\s'][a-zA-Z]+)*?$"))
            {
                MessageBox.Show("Middle Name must be in letters only");

            }
            else if (!Regex.IsMatch(txtContactNo.Text, @"^(09)\d{9}$"))
            {
                MessageBox.Show("Phone number must be 11 digit only");
            }
            else if (txtFirstName.Text != "" && txtLastName.Text != "" && txtMiddleName.Text != "" && txtContactNo.Text != "")
            {
                result = MessageBox.Show("Do you want to save Client Details?", "Add Client", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        con.Close();
                        con.Open();
                        QuerySelect = "SELECT * FROM tblClient WHERE c_FN = @cFN AND c_MN = @cMN AND c_LN = @cLN";

                        cmd = new SqlCommand(QuerySelect, con);
                        cmd.Parameters.AddWithValue("@cFN", txtFirstName.Text);
                        cmd.Parameters.AddWithValue("@cMN", txtMiddleName.Text);
                        cmd.Parameters.AddWithValue("@cLN", txtLastName.Text);

                        reader = cmd.ExecuteReader();

                        if (reader.HasRows)
                        {
                            MessageBox.Show("This client already exists!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtORNo.Clear();
                        }
                        else
                        {
                            //INSERT tblClients
                            try
                            {
                                if (con.State == ConnectionState.Open)
                                {
                                    con.Close();
                                }

                                con.Open();
                                QueryInsert = "INSERT INTO tblClient(c_FN, c_MN, c_LN, c_ContactNo, Province, Municipality, Barangay)" + "VALUES(@cFN, @cMN, @cLN, @cNo, @cProv, @cMun, @cBrgy)";
                                cmd = new SqlCommand(QueryInsert, con);

                                cmd.Parameters.AddWithValue("@cFN", txtFirstName.Text);
                                cmd.Parameters.AddWithValue("@cMN", txtMiddleName.Text);
                                cmd.Parameters.AddWithValue("@cLN", txtLastName.Text);
                                cmd.Parameters.AddWithValue("@cNo", txtContactNo.Text);
                                cmd.Parameters.AddWithValue("@cProv", cmbProvince.Text);
                                cmd.Parameters.AddWithValue("@cMun", cmbMunicipality.Text);
                                cmd.Parameters.AddWithValue("@cBrgy", cmbBarangay.Text);
                                
                                cmd.ExecuteNonQuery();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message + "\n" + ex.StackTrace);
                            }
                            finally
                            {
                                MessageBox.Show("Client Details Saved!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                con.Close();
                            }                          
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message + "\n" + ex.StackTrace);
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
            else if (!Regex.IsMatch(txtFirstName.Text, @"^([a-zA-Z-.]+?)([-\s'][a-zA-Z]+)*?$"))
            {
                MessageBox.Show("First Name must be in letters only");
            }
            else if (!Regex.IsMatch(txtLastName.Text, @"^([a-zA-Z-.]+?)([-\s'][a-zA-Z]+)*?$"))
            {
                MessageBox.Show("Last Name must be in letters only");
            }
            else if (!Regex.IsMatch(txtMiddleName.Text, @"^([a-zA-Z-.]+?)([-\s'][a-zA-Z]+)*?$"))
            {
                MessageBox.Show("Middle Name must be in letters only");
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




        /* ------------------------ PAYMENT SUBMODULE------------------------------------*/

        // for CRP Resibo
        void GenerateReceipt()
        {
            frmReceipt resibo = new frmReceipt();
            OReceipt receiptRPT = new OReceipt();

            /*------- Official Receipt Details ------*/

            // RH - RECEIPT HEADER

            TextObject tDate = (TextObject)receiptRPT.ReportDefinition.Sections["Section1"].ReportObjects["transdate"];
            tDate.Text = lblTransDate.Text;                


            //PH - CLIENT DETAILS

            TextObject clientName = (TextObject)receiptRPT.ReportDefinition.Sections["Section3"].ReportObjects["clientName"];
            clientName.Text = lblCFName.Text + " " + lblCMName.Text + " " + lblCLName.Text;

            TextObject clientAdd = (TextObject)receiptRPT.ReportDefinition.Sections["Section3"].ReportObjects["clientAddress"];
            clientAdd.Text = lblBarangay.Text + " " + lblCity.Text + " " + lblProvince.Text;


            //PH - PAYMENT DETAILS

            TextObject sumDigit = (TextObject)receiptRPT.ReportDefinition.Sections["Section3"].ReportObjects["amtDigit"];
            sumDigit.Text = txtAmountDigit.Text;

            TextObject paymentType = (TextObject)receiptRPT.ReportDefinition.Sections["Section3"].ReportObjects["paymentType"];
            paymentType.Text = cmbPaymentType.Text;

            TextObject paymentMode = (TextObject)receiptRPT.ReportDefinition.Sections["Section3"].ReportObjects["paymentMode"];
            paymentMode.Text = cmbPaymentMode.Text;


            //RF - OR NO DEETS AND SIGNATURE

            TextObject ORNum = (TextObject)receiptRPT.ReportDefinition.Sections["Section4"].ReportObjects["ORNo"];
            ORNum.Text = txtORNo.Text;

            resibo.crystalReportViewer1.ReportSource = receiptRPT;
            resibo.Show();

        }

        //Autocomplete Name in Client
        public void autoCompleteClientName()
        {
            con.Close();
            QuerySelect = "SELECT c_FN, c_MN, C_LN FROM tblClient WHERE c_FN LIKE '" + txtSearch.Text + "%'";
            cmd = new SqlCommand(QuerySelect, con);
            con.Open();
            reader = cmd.ExecuteReader();
            AutoCompleteStringCollection MyCollection = new AutoCompleteStringCollection();
            while (reader.Read())
            {
                MyCollection.Add(reader.GetString(0));
                MyCollection.Add(reader.GetString(1));
                MyCollection.Add(reader.GetString(2));
            }
            txtSearch.AutoCompleteCustomSource = MyCollection;
            con.Close();
        }


        //btnPay
        void TransactPayment()
        {
            result = MessageBox.Show("Confirm Payment?", "Settle Payment", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                try
                {
                    con.Close();
                    con.Open();
                    QuerySelect = "SELECT * FROM tblPayment WHERE p_ORNo = @OR";

                    cmd = new SqlCommand(QuerySelect, con);
                    cmd.Parameters.AddWithValue("@OR", txtORNo.Text);

                    reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        MessageBox.Show("This OR number already exists!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtORNo.Clear();
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
                            QueryInsert = "INSERT INTO tblPayment(clientID, userID, p_amount, p_date, p_ORNo)" + "VALUES((SELECT clientID FROM tblClient WHERE c_FN = '" + lblCFName.Text + "' AND c_MN = '" + lblCMName.Text + "' AND c_LN = '" + lblCLName.Text + "'), @uID, @pAmount, @pDate, @OR)";
                            cmd = new SqlCommand(QueryInsert, con);

                            cmd.Parameters.AddWithValue("@uID", frmLogin.GetUserID.ToString());
                            cmd.Parameters.AddWithValue("@pAmount", txtAmountDigit.Text.Replace(",", ""));
                            cmd.Parameters.AddWithValue("@pDate", DateTime.Now.Date.ToString("yyyy-MM-dd"));
                            cmd.Parameters.AddWithValue("@OR", txtORNo.Text);

                            cmd.ExecuteNonQuery();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message + "\n" + ex.StackTrace);
                        }

                        finally
                        {
                            con.Close();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + "\n" + ex.StackTrace);
                }
                finally
                {
                    con.Close();
                }
                MessageBox.Show("Transaction Finished!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GenerateReceipt();
            }
        }                  

        private void ucPayments_Load(object sender, EventArgs e)
        {
            lblTransDate.Text = DateTime.Now.ToString("MMMM, dd, yyyy");
            setProvince();
            setMunicipality();
            setBarangay();
            loadProvinces();
            DisplayClients();
            autoCompleteClientName();
        }

        private void cmbProvince_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadMunicipalities();
        }

        private void cmbMunicipality_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadBarangays();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            TransactPayment();
        }

        private void txtSearch_TextChange(object sender, EventArgs e)
        {
            try
            {
                if(txtSearch.Text != "")
                {
                    con.Close();
                    con.Open();
                    QuerySelect = "SELECT * FROM tblClient WHERE c_FN = @fName OR c_MN = @mName OR c_lN = @lName";

                    cmd = new SqlCommand(QuerySelect, con);
                    cmd.Parameters.AddWithValue("@fName", txtSearch.Text);
                    cmd.Parameters.AddWithValue("@mName", txtSearch.Text);
                    cmd.Parameters.AddWithValue("@lName", txtSearch.Text);

                    reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        pnlClient.Visible = true;
                        lblCFName.Text = reader[1].ToString();
                        lblCMName.Text = reader[2].ToString();
                        lblCLName.Text = reader[3].ToString();
                        lblCCNo.Text = reader[4].ToString();
                        lblProvince.Text = reader[5].ToString();
                        lblCity.Text = reader[6].ToString();
                        lblBarangay.Text = reader[7].ToString();
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

        private void btnSaveClient_Click(object sender, EventArgs e)
        {
            SaveClientDeets();
        }

        private void txtClientSearch_TextChange(object sender, EventArgs e)
        {
            DisplayClients();
        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            ClearControls();
            pnlClientInfo.Visible = true;
            dgvClients.Enabled = false;
            btnSaveClient.Visible = true;
            btnUpdate.Visible = false;
        }

        private void btnUpdateClient_Click(object sender, EventArgs e)
        {
            ClearControls();
            pnlClientInfo.Visible = true;
            dgvClients.Enabled = true;
            btnSaveClient.Visible = false;
            btnUpdate.Visible = true;
        }

        private void dgvClients_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvClients.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {

                    lblcID.Text = dgvClients.Rows[e.RowIndex].Cells[0].Value.ToString();
                    txtFirstName.Text = dgvClients.Rows[e.RowIndex].Cells[1].Value.ToString();
                    txtMiddleName.Text = dgvClients.Rows[e.RowIndex].Cells[2].Value.ToString();
                    txtLastName.Text = dgvClients.Rows[e.RowIndex].Cells[3].Value.ToString();
                    txtContactNo.Text = dgvClients.Rows[e.RowIndex].Cells[4].Value.ToString();
                    cmbProvince.Text = dgvClients.Rows[e.RowIndex].Cells[5].Value.ToString();
                    cmbMunicipality.Text = dgvClients.Rows[e.RowIndex].Cells[6].Value.ToString();
                    cmbBarangay.Text = dgvClients.Rows[e.RowIndex].Cells[7].Value.ToString();                                    
                }
            }
            catch
            {

            }           
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateClient();
        }
    }
}
