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
    public partial class Main : Form
    {
        string path = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "\\Data";

        public List<string> oMsg = new List<string>();
       
        public Main()
        {
            InitializeComponent();
            ClearForm();
            this.cboEventType.DataSource = Enum.GetValues(typeof(Customer.EventType));
            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);
            lbloMsgs.Text = oMsgToString(oMsg);


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
                txtEventsLocation.Text, dtEventsDate.Value, Convert.ToDouble(txtTotalCost.Text), Convert.ToDouble(txtPaid.Text), txtComments.Text,
                 cboEventType.SelectedItem.ToString(), txtEmail.Text);

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
            cboEventType.SelectedIndex = -1;
            txtEventsLocation.Text = string.Empty;
            dtEventsDate.Text = string.Empty;
            txtTotalCost.Text = string.Empty;
            txtPaid.Text  = string.Empty;
            txtComments.Text = string.Empty;
            txtEmail.Text = string.Empty;
            lbloMsgs.Text = oMsgToString(oMsg);
        }

        private bool ValidateData()
        {
            bool allok=false;

            if (String.IsNullOrWhiteSpace(txtName.Text))
            {
                oMsg.Add("Name Is required");
                txtName.Focus();
               // txtName.ForeColor = Color.Red;
            }


            if (String.IsNullOrWhiteSpace(txtLastName.Text))
            {
                oMsg.Add("Last Name Is required");
                txtLastName.Focus();
                //txtLastName.ForeColor = Color.Red;
            }

            if (String.IsNullOrWhiteSpace(txtMobilePhone.Text))
            {
                oMsg.Add("Mobile Phone is required Is Required");
                txtMobilePhone.Focus();
                //txtMobilePhone.ForeColor = Color.Red;
            }

            double value;
            if (!double.TryParse(txtTotalCost.Text, out value))
            {
                oMsg.Add("In Total Cost field you should enter a number");
                txtTotalCost.Focus();
               // txtTotalCost.ForeColor = Color.Red;
            }
            if (!double.TryParse(txtPaid.Text, out value))
            {
                oMsg.Add("In Paid field you should enter a number");
                txtPaid.Focus();
                //txtPaid.ForeColor = Color.Red;
            }

            if (!IsValid(txtEmail.Text))
            {
                oMsg.Add("Use a valid email address");
                txtEmail.Focus();
                //txtEmail.ForeColor = Color.Red;
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

        private void btSubmit_Click(object sender, EventArgs e)
        {
            if (ValidateData())
            {
                WriteToFile wf = new WriteToFile();
                ReadFromFile rd = new ReadFromFile();
                DataSet ds = loadDataToDataset();
                if (wf.WriteToTxtFile(ds, path))
                {
                    oMsg.Add("Record Saved");
                  
                    ClearForm();
                    DataTable dt;
                    dt = rd.ReadTxtToDataTable(path + "\\data.txt", 13);
                    DataTable finalDT = rd.ConvertDataSet(dt);
                    DataView view = new DataView(finalDT);
                    dataGridView1.DataSource = view;
                }
                else
                {
                    oMsg.Add("Submition Failed");
                    
                }
            }
            else
                oMsg.Add("Unable to make the submition");

            lbloMsgs.Text = oMsgToString(oMsg);
            oMsg.Clear();
        }
      

        public string oMsgToString(List<string> oMsg)
        {
            string result = string.Empty; ;
            if (oMsg.Count != 0)
            {
                foreach (string s in oMsg)
                {
                    result += s + "\n";
                }
            }
            return result;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            Utils ut = new Utils();
            ReadFromFile rd = new ReadFromFile();
            DataTable dt = rd.ReadTxtToDataTable(path + "\\data.txt", 13);
            DataTable finalDT = rd.ConvertDataSet(dt);
            if (finalDT.Rows.Count == 0 || finalDT == null)
            {
                DataTable emptyDT = ut.CustomTable();
                DataView view = new DataView(emptyDT);
                dataGridView1.DataSource = view;
            }
            else
            {
                DataView view = new DataView(finalDT);
                dataGridView1.DataSource = view;
            }

            

        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            double number;
            CustomerDetails cd = new CustomerDetails();
            cd.txtName.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            cd.txtLastName.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            cd.txtMobilePhone.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            cd.txtHomePhone.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            cd.txtSpouseName.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
            cd.txtKidsName.Text = this.dataGridView1.CurrentRow.Cells[5].Value.ToString();
            cd.txtEventType.Text = this.dataGridView1.CurrentRow.Cells[11].Value.ToString();
            cd.txtEventsLocation.Text = this.dataGridView1.CurrentRow.Cells[6].Value.ToString();//this.dataGridView1.CurrentRow.Cells[8].Value.ToString();
            cd.txtEventsDate.Text = this.dataGridView1.CurrentRow.Cells[7].Value.ToString();
            cd.txtTotalCost.Text = this.dataGridView1.CurrentRow.Cells[8].Value.ToString();         // this.dataGridView1.CurrentRow.Cells[9].Value.ToString();
            cd.txtPaid.Text = this.dataGridView1.CurrentRow.Cells[9].Value.ToString();
            cd.txtComments.Text =           this.dataGridView1.CurrentRow.Cells[10].Value.ToString();
            cd.txtEmail.Text =              this.dataGridView1.CurrentRow.Cells[12].Value.ToString();
            cd.ShowDialog();
        }
    }
}
