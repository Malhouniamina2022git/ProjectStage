using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetStage
{
    public partial class Connecter : Form
    {
        public Connecter()
        {
            InitializeComponent();
        }
        ADO d = new ADO();
        private void button1_Click(object sender, EventArgs e)
        {
            bool tr = false;
            d.cmd.CommandText = "select Login1,motPasse from Connecter";
            d.cmd.Connection = d.con;
            d.dr = d.cmd.ExecuteReader();
            while (d.dr.Read())
            {
                if (textBox1.Text.Equals(d.dr[0].ToString()) && textBox2.Text.Equals(d.dr[1].ToString()))
                {
                    tr = true;
                    break;
                }
            }
            // une fois click sur le button afficher un interface 
            if (tr == true)
            {
                this.Hide();
                Menu1 m1 = new Menu1();
                m1.Show();
            }
            //if (tr == true)
            //{
            //    MessageBox.Show("mot de passe incorecct ");
            //}

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            d.connecter();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
