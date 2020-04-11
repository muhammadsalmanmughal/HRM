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
    public partial class ControlPanel : Form
    {
        public ControlPanel()
        {
            InitializeComponent();
        }

        private void btncandi_Click(object sender, EventArgs e)
        {
            CandidateForm cf = new CandidateForm();
            cf.Show();
            this.Hide();
        }

        private void btnhir_Click(object sender, EventArgs e)
        {
            EmployeeForm ef = new EmployeeForm();
            ef.Show();
            this.Hide();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OrganizationChartform ocf = new OrganizationChartform();
            ocf.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Attendanceform af = new Attendanceform();
            af.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PayrollForm pf = new PayrollForm();
            pf.Show();
            this.Hide();

        }
    }
}
