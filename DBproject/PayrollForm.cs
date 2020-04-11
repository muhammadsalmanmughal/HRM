using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBproject
{
    public partial class PayrollForm : Form
    {
        public PayrollForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ControlPanel cp = new ControlPanel();
            cp.Show();
            this.Hide();
        }

        private void btnretrive_Click(object sender, EventArgs e)
        {
            
        }

        private void PayrollForm_Load(object sender, EventArgs e)
        {
            lblday2.Text = DateTime.Now.DayOfWeek.ToString();
            payroll ret = new payroll();
            dgvPayroll.DataSource = ret.showrecord();
            txtId.MaxLength = 3;
            txthours.MaxLength = 2;
            txtrates.MaxLength = 4;
            txtName.Enabled = false;
            txtGROSSPAY.Enabled = false;
            txtmedallow.Enabled = false;
            txtTAXES.Enabled = false;
        }

        private void btnCALC_Click(object sender, EventArgs e)
        {
            //define variables
            double hours, rate;
            double grossPay, MedAll, Tax, netPay;

            //input
            hours = Convert.ToDouble(txtrates.Text);
            rate = Convert.ToDouble(txthours.Text);


            //calculation
            grossPay = hours * rate;
            MedAll = grossPay * 0.10;
            Tax = grossPay * 5 / 100;
            netPay = grossPay - (MedAll + Tax);

            //netPay = grossPay - fedTax + stateTax

            //output
            txtGROSSPAY.Text = grossPay.ToString("");
            txtmedallow.Text = MedAll.ToString("");
            txtTAXES.Text = Tax.ToString("");
            txtNETPAY.Text = netPay.ToString("");
        }

        private void btnGENER_Click(object sender, EventArgs e)
        {
            payroll pr = new payroll();

            try
            {
                if (txtrates.Text == "")
                {
                    MessageBox.Show("please insert  hours rates");

                    return;
                }
                else if (txthours.Text == "")
                {
                    MessageBox.Show("please insert Houres Worked");

                    return;
                }
                pr.EmployeeID = Convert.ToInt32(txtId.Text);
                pr.Empfullname = txtName.Text;
                pr.Empsalary = txtNETPAY.Text;
                pr.Day = lblday2.Text;

                pr.insert();
                MessageBox.Show("Report Generated");
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ControlPanel cp = new ControlPanel();
            cp.Show();
            this.Hide();
        }

        private void btnret_Click(object sender, EventArgs e)
        {
            payroll ret = new payroll();
            try
            {
                if (txtId.Text == "")
                {
                    MessageBox.Show("please insert the ID");

                    return;
                }
                else
                {
                    int aid = Convert.ToInt32(txtId.Text);
                    ret.Retrieve2(aid);

                    txtName.Text = ret.EmpFirstName;

                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
                return;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime datetimee = DateTime.Now;
            this.lbldatetime.Text = datetimee.ToString();
        }

        private void txtId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space)
            {
                e.Handled = false;
            }

            else
            {
                e.Handled = true;
                MessageBox.Show("only numbers are allowed");
            }
        }

        private void txtrates_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (char.IsNumber(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space)
            {
                e.Handled = false;
            }

            else
            {
                e.Handled = true;
                MessageBox.Show("only numbers are allowed");
            }
        }

        private void txthours_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (char.IsNumber(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space)
            {
                e.Handled = false;
            }

            else
            {
                e.Handled = true;
                MessageBox.Show("only numbers are allowed");
            }
        }

        private void txtrates_Validating(object sender, CancelEventArgs e)
        {
            decimal Input = Convert.ToDecimal(txtrates.Text);
            if (Input < 600 || Input > 2000)
            {
                MessageBox.Show("Age not valid only 23 to 60");
                e.Cancel = true;
                return;
            }
        }
    }
}
