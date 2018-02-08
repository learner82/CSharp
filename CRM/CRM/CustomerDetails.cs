using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRM
{
    public partial class CustomerDetails : Form
    {
        string path = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "\\Data";
        public List<string> oMsg = new List<string>();
        Main m = new Main();

        public CustomerDetails()
        {
            InitializeComponent();
            
            btnDelete.Visible = false;
            btnUpdate.Visible = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (ValidateData())
            {
                WriteToFile wf = new WriteToFile();
                ReadFromFile rd = new ReadFromFile();
                DataSet ds = loadDataToDataset();
                if (wf.WriteToTxtFile(ds, path))
                {
                    oMsg.Add("Record Saved");
                    MessageBox.Show(m.oMsgToString(oMsg));

                    ClearForm();
                    DataTable dt = rd.ReadTxtToDataTable(path + "\\data.txt", 13);
                    DataTable finalDT = rd.ConvertDataSet(dt);
                    
                    
                }
                else
                {
                    oMsg.Add("Submition Failed");
                    MessageBox.Show(m.oMsgToString(oMsg));
                }
            }
            else
                oMsg.Add("Unable to make the submition");
                MessageBox.Show(m.oMsgToString(oMsg));


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        public DataSet loadDataToDataset()
        {
            Utils ut = new Utils();
            DataSet ds = new DataSet();
            DataTable dt = ut.CustomTable();
            ds.Tables.Add(dt);
            Customer cus = new Customer();
            dt.Rows.Add(txtName.Text, txtLastName.Text, txtMobilePhone.Text,
                txtHomePhone.Text, txtSpouseName.Text, txtKidsName.Text,
                txtEventsLocation.Text, txtEventsDate.Text, 0, 0, txtComments.Text, 0, txtEmail.Text);



            return ds;
        }

        private void ClearForm()
        {

            txtName.Text = string.Empty;
            txtLastName.Text = string.Empty;
            txtMobilePhone.Text = string.Empty;
            txtHomePhone.Text = string.Empty;
            txtSpouseName.Text = string.Empty;
            txtKidsName.Text = string.Empty;
            
            txtEventsLocation.Text = string.Empty;
            txtEventsDate.Text = string.Empty;
            txtTotalCost.Text = string.Empty;
            txtPaid.Text = string.Empty;
            txtComments.Text = string.Empty;
            txtEmail.Text = string.Empty;
           
        }

        private bool ValidateData()
        {
            bool allok = false;

            if (String.IsNullOrWhiteSpace(txtName.Text))
            {
                oMsg.Add("Name Is required");
                txtName.Focus();
                txtName.ForeColor = Color.Red;
            }


            if (String.IsNullOrWhiteSpace(txtLastName.Text))
            {
                oMsg.Add("Last Name Is required");
                txtLastName.Focus();
                txtLastName.ForeColor = Color.Red;
            }

            if (String.IsNullOrWhiteSpace(txtMobilePhone.Text))
            {
                oMsg.Add("Mobile Phone is required Is Required");
                txtMobilePhone.Focus();
                txtMobilePhone.ForeColor = Color.Red;
            }

            double value;
            if (!double.TryParse(txtTotalCost.Text, out value))
            {
                oMsg.Add("In Total Cost field you should enter a number");
                txtTotalCost.Focus();
                txtTotalCost.ForeColor = Color.Red;
            }
            if (!double.TryParse(txtPaid.Text, out value))
            {
                oMsg.Add("In Paid field you should enter a number");
                txtPaid.Focus();
                txtPaid.ForeColor = Color.Red;
            }

            if (!IsValid(txtEmail.Text))
            {
                oMsg.Add("Use a valid email address");
                txtEmail.Focus();
                txtEmail.ForeColor = Color.Red;
            }
            if (oMsg.Count == 0)
            {
                allok = true;
            }

            return allok;

        }

        public bool IsValid(string ts)
        {
            if (String.IsNullOrWhiteSpace(ts))
            {
                return false;
            }
            else
            {
                try
                {
                    MailAddress m = new MailAddress(ts);

                    return true;
                }
                catch (Exception ex)
                {
                    oMsg.Add(ex.Message);
                    return false;
                }
            }

        }
    }
}
