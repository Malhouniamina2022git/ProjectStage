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
    public partial class Menu1 : Form
    {
        public Menu1()
        {
            InitializeComponent();
        }

        private void salariéToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SalariéList sl = new SalariéList();
            sl.Show();
        
        }

        private void adminToolStripMenuItem1_Click(object sender, EventArgs e)
        { 
        }

        private void Menu1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void départementToolStripMenuItem1_Click(object sender, EventArgs e)
        {
             
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void clientToolStripMenuItem1_Click(object sender, EventArgs e)
        {
             
        }

        private void gradeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Grade g = new Grade();
            g.Show();
        }

        private void lesOffresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Offre O = new Offre();
            O.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void abonnementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Abonnement A = new Abonnement();
            A.Show();
        }

        private void seDéconnecterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Connecter conc = new Connecter();
            conc.Show();
        }
    }
}
