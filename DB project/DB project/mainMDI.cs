using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_project
{
    public partial class mainMDI : Form
    {
        public mainMDI()
        {
            InitializeComponent();
        }

        private void btncandi_Click(object sender, EventArgs e)
        {
            CandidateInfo cin = new CandidateInfo();
            cin.Show();
            this.Close();
        }
    }
}
