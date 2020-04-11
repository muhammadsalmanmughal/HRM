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
    public partial class OrganizationChartform : Form
    {
        public OrganizationChartform()
        {
            InitializeComponent();
        }

        private void OrganizationChartform_Load(object sender, EventArgs e)
        {
            ClsOC ret = new ClsOC();
            dgvorganization.DataSource = ret.showrecord();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            ControlPanel cp = new ControlPanel();
            cp.Show();
            this.Hide();
        }
    }
}
