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

namespace EBRMS.Secretary
{
    public partial class ucBookingManagement : UserControl
    {
        public ucBookingManagement()
        {
            InitializeComponent();
        }

        private static ucBookingManagement booking;

        public static ucBookingManagement bookingInstance
        {
            get
            {
                if (booking == null)
                    booking = new ucBookingManagement();
                return booking;
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


        ////AddBooking - Baptism
        //public void BaptismBooking()
        //{
        //    con.Close();

        //    if (String.IsNullOrEmpty(txtBFatherName.Text))
        //    {
        //        MessageBox.Show("Enter Father's Name!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        txtBFatherName.Focus();
        //    }
        //    else if (String.IsNullOrWhiteSpace(txtBFatherName.Text))
        //    {
        //        MessageBox.Show("Whitespace is not allowed!");
        //        txtBFatherName.Clear();
        //    }
        //    else if (String.IsNullOrEmpty(txtBMotherName.Text))
        //    {
        //        MessageBox.Show("Enter Mother's Name!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        txtBMotherName.Focus();
        //    }
        //    else if (String.IsNullOrWhiteSpace(txtBMotherName.Text))
        //    {
        //        MessageBox.Show("Whitespace is not allowed!");
        //        txtBMotherName.Clear();
        //    }
        //    else if (String.IsNullOrEmpty(txtBCLastName.Text))
        //    {
        //        MessageBox.Show("Enter Last Name!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        txtBCLastName.Focus();
        //    }
        //    else if (String.IsNullOrWhiteSpace(txtBCLastName.Text))
        //    {
        //        MessageBox.Show("Whitespace is not allowed!");
        //        txtBCLastName.Clear();
        //    }
        //    else if (String.IsNullOrEmpty(txtBCFirstName.Text))
        //    {
        //        MessageBox.Show("Enter First Name!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        txtBCFirstName.Focus();
        //    }
        //    else if (String.IsNullOrWhiteSpace(txtBCFirstName.Text))
        //    {
        //        MessageBox.Show("Whitespace is not allowed!");
        //        txtBCFirstName.Clear();
        //    }
        //    else if (String.IsNullOrEmpty(txtBCMiddleName.Text))
        //    {
        //        MessageBox.Show("Enter Confirm Password!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        txtBCMiddleName.Focus();
        //    }
        //    else if (String.IsNullOrWhiteSpace(txtBCMiddleName.Text))
        //    {
        //        MessageBox.Show("Whitespace is not allowed!");
        //        txtBCMiddleName.Clear();
        //    }
        //    else if (!Regex.IsMatch(txtBCLastName.Text, @"^([a-zA-Z-.]+?)([-\s'][a-zA-Z]+)*?$"))
        //    {
        //        MessageBox.Show("First Name must be in letters only");
        //    }
        //    else if (!Regex.IsMatch(txtBCFirstName.Text, @"^([a-zA-Z-.]+?)([-\s'][a-zA-Z]+)*?$"))
        //    {
        //        MessageBox.Show("Last name must be in letters only");
        //    }
        //    else if (!Regex.IsMatch(txtBCMiddleName.Text, @"^([a-zA-Z-.]+?)([-\s'][a-zA-Z]+)*?$"))
        //    {
        //        MessageBox.Show("Middle Name must be in letters only");
        //    }
        //    else if (txtBFatherName.Text != "" && txtBMotherName.Text != "" && txtBCLastName.Text != "" && txtBCFirstName.Text != "" && txtBCMiddleName.Text != "")
        //    {
        //        result = MessageBox.Show("Do you want to Add this Event Booking?", "Add Booking", MessageBoxButtons.YesNo);
        //        if (result == DialogResult.Yes)
        //        {
        //            con.Close();
        //            con.Open();
        //            QuerySelect = "SELECT * FROM tblBooking INNER JOIN tblPayment ON tblBooking.paymentID = tblPayment.paymentID WHERE tblPayment.p_ORNo = @orNO";

        //            cmd = new SqlCommand(QuerySelect, con);
        //            cmd.Parameters.AddWithValue("@uName", txtSearch.Text);

        //            reader = cmd.ExecuteReader();
        //            if (reader.HasRows)
        //            {
        //                MessageBox.Show("This Event Booking already exists!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //                txtSearch.Clear();
        //            }
        //            else
        //            {
        //                try
        //                {
        //                    con.Close();
        //                    con.Open();
        //                    QueryInsert = "INSERT INTO tblUsers (username,firstName, lastName, password,userType)" +
        //                        "VALUES (@username, @fName, @lName,@password, @userType)";

        //                    cmd = new SqlCommand(QueryInsert, con);

        //                    cmd.Parameters.AddWithValue("@fName", txtFirstName.Text);
        //                    cmd.Parameters.AddWithValue("@lName", txtLastName.Text);
        //                    cmd.Parameters.AddWithValue("@userName", txtUsername.Text);
        //                    cmd.Parameters.AddWithValue("@password", txtPassword.Text);
        //                    cmd.Parameters.AddWithValue("@userType", cmbRole.SelectedItem.ToString());

        //                    cmd.ExecuteNonQuery();

        //                    MessageBox.Show("User Added Successfully!", "Add User", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //                    this.Close();
        //                    ClearControls();
        //                }
        //                catch (Exception ex)
        //                {
        //                    MessageBox.Show(ex.Message);
        //                }
        //                finally
        //                {
        //                    con.Close();
        //                }
        //            }
        //        }
        //    }
        //    else
        //    {
        //        MessageBox.Show("Please Provide Details!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //    }
        //}

        private void cmbEventType_SelectedValueChanged(object sender, EventArgs e)
        {
            lblEventName.Text = cmbEventType.Text;
        }

        private void cmbEventType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbEventType.SelectedIndex == 0)
            {
                pnlBaptism.Visible = true;
                pnlConfirmation.Visible = false;
                pnlWedding.Visible = false;
                pnlFuneral.Visible = false;
            }
            else if (cmbEventType.SelectedIndex == 1)
            {
                pnlBaptism.Visible = false;
                pnlConfirmation.Visible = true;
                pnlWedding.Visible = false;
                pnlFuneral.Visible = false;
            }
            else if (cmbEventType.SelectedIndex == 2)
            {
                pnlBaptism.Visible = false;
                pnlConfirmation.Visible = false;
                pnlWedding.Visible = true;
                pnlFuneral.Visible = false;
            }
            else if (cmbEventType.SelectedIndex == 3)
            {
                pnlBaptism.Visible = false;
                pnlConfirmation.Visible = false;
                pnlWedding.Visible = false;
                pnlFuneral.Visible = true;
            }
            else
            {
                pnlBaptism.Visible = false;
                pnlConfirmation.Visible = false;
                pnlWedding.Visible = false;
                pnlFuneral.Visible = false;
            }
        }

        private void btnBookEvent_Click(object sender, EventArgs e)
        {
            if (cmbEventType.SelectedIndex == 0)
            {

            }
            else if (cmbEventType.SelectedIndex == 1)
            {
                pnlBaptism.Visible = false;
                pnlConfirmation.Visible = true;
                pnlWedding.Visible = false;
                pnlFuneral.Visible = false;
            }
            else if (cmbEventType.SelectedIndex == 2)
            {
                pnlBaptism.Visible = false;
                pnlConfirmation.Visible = false;
                pnlWedding.Visible = true;
                pnlFuneral.Visible = false;
            }
            else if (cmbEventType.SelectedIndex == 3)
            {
                pnlBaptism.Visible = false;
                pnlConfirmation.Visible = false;
                pnlWedding.Visible = false;
                pnlFuneral.Visible = true;
            }
        }
    }
}
