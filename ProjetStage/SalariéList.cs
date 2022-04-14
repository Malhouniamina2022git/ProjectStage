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
    public partial class SalariéList : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-ELPBKRT\\SQLEXPRESS;Initial Catalog=Gestion des personnels;Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader dr;
        public SalariéList()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand("Select * from Salarie  ", con);
            dr = cmd.ExecuteReader();
            dataGridView1.Rows.Clear();
            while (dr.Read())
            {
                dataGridView1.Rows.Add(dr[0] , dr[1] , dr[2] , dr[3] , dr[4] , dr[5] , dr[6] , dr[7] , dr[8] , dr[9] , dr[10] , dr[11]);
                
            }
            dr.Close();
            con.Close();
        }

        private void SalariéList_Load(object sender, EventArgs e)
        {
          
            dataGridView1.Columns.Add("Id_Salarié", "Id_Salarié");
            dataGridView1.Columns.Add("Nom", "Nom");
            dataGridView1.Columns.Add("Prenom", "Prenom");
            dataGridView1.Columns.Add("Num_Dept", "Num_Dept");
            dataGridView1.Columns.Add("Ville", "Ville");
            dataGridView1.Columns.Add("Age", "Age");
            dataGridView1.Columns.Add("EtatCivil", "EtatCivil");
            dataGridView1.Columns.Add("Adresse", "Adresse");
            dataGridView1.Columns.Add("Telephone", "Telephone");
            dataGridView1.Columns.Add("Fonctions", "Fonctions");
            dataGridView1.Columns.Add("Password1", "Password1");

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Sal sl = new Sal();
            sl.Show();
           
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormNewsal cr = new FormNewsal();
            cr.Show();
        }
    }
}
