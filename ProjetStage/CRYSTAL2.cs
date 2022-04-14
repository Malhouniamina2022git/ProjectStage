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
    public partial class CRYSTAL2 : Form
    {
        public CRYSTAL2()
        {
            InitializeComponent();
        }

        private void CRYSTAL2_Load(object sender, EventArgs e)
        {
            CrystalRepNewSal C2 = new CrystalRepNewSal();
            crystalReportViewe2.ReportSource = C2;
            C2.Refresh();
        }

        private void crystalReportViewe2_Load(object sender, EventArgs e)
        {

        }
    }
}
