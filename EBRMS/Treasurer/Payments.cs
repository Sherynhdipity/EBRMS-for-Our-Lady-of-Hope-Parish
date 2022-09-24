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
        public static string QuerySelect;

        //clear controls
        public void ClearControls()
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            txtMiddleName.Clear();
            cmbProvince.SelectedIndex = 0;
            cmbMunicipality.SelectedIndex = 0;
            cmbBarangay.SelectedIndex = 0;
            cmbPaymentMode.SelectedIndex = 0;
            cmbPaymentType.SelectedIndex = 0;
        }

        public void DisplayClients()
        {
            try
            {
                con.Open();
                QuerySelect = "SELECT * FROM vwClients)";

                cmd = new SqlCommand(QuerySelect, con);
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
            clientName.Text = txtFirstName.Text + " " + txtMiddleName.Text + " " + txtLastName.Text;

            TextObject clientAdd = (TextObject)receiptRPT.ReportDefinition.Sections["Section3"].ReportObjects["clientAddress"];
            clientAdd.Text = cmbBarangay.Text + " " + cmbMunicipality.Text + " " + cmbProvince.Text;


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

        void TransactPayment()
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
            else if (txtFirstName.Text != "" && txtLastName.Text != "" && txtMiddleName.Text != "" && txtAmountDigit.Text != "" && txtORNo.Text != "" && txtContactNo.Text != "")
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
                            //INSERT tblPayments
                            try
                            {
                                if (con.State == ConnectionState.Open)
                                {
                                    con.Close();
                                }

                                con.Open();
                                QueryInsert = "INSERT INTO tblPayment(p_amount, p_date, p_ORNo)" + "VALUES(@pAmount, @pDate, @OR)";
                                cmd = new SqlCommand(QueryInsert, con);

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

                            //INSERT tblClient
                            try
                            {
                                if (con.State == ConnectionState.Open)
                                {
                                    con.Close();
                                }
                                con.Open();
                                QueryInsert = "INSERT INTO tblClient(c_FN, c_MN, c_LN, c_ContactNo)" + "VALUES(@cFN, @cMN, @cLN, @cNo)";
                                cmd = new SqlCommand(QueryInsert, con);

                                cmd.Parameters.AddWithValue("@cFN", txtFirstName.Text);
                                cmd.Parameters.AddWithValue("@cMN", txtMiddleName.Text);
                                cmd.Parameters.AddWithValue("@cLN", txtLastName.Text);
                                cmd.Parameters.AddWithValue("@cNo", txtContactNo.Text);

                                cmd.ExecuteNonQuery();
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

        private void ucPayments_Load(object sender, EventArgs e)
        {
            lblTransDate.Text = DateTime.Now.ToString("MMMM, dd, yyyy");
            loadProvinces();
            DisplayClients();
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
    }
}
