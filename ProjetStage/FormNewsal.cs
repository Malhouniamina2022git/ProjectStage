using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetStage
{
    public partial class FormNewsal : Form
    {
        public FormNewsal()
        {
            InitializeComponent();
        }

        private void FormNewsal_Load(object sender, EventArgs e)
        {
            CrystalRepNewSal cr = new CrystalRepNewSal();
            crystalReportViewer1.ReportSource = cr;
            crystalReportViewer1.Refresh();
        }
    }
}
