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
    public partial class Grade : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-ELPBKRT\\SQLEXPRESS;Initial Catalog=Gestion des personnels;Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader dr;
        public Grade()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Grade_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("Matricule", "Matricule");
            dataGridView1.Columns.Add("NOM", "NOM");
            dataGridView1.Columns.Add("PRENOM", "PRENOM");
            dataGridView1.Columns.Add("Ville", "Ville");
            dataGridView1.Columns.Add("Age", "Age");
            dataGridView1.Columns.Add("Etat-Civil", "Etat-Civil");
            dataGridView1.Columns.Add("Adresse", "Adresse");
            dataGridView1.Columns.Add("Telephone", "Telephone");
            dataGridView1.Columns.Add("fonctions", "fonctions");



            con.Open();
            cmd = new SqlCommand("Select Grade from Grade", con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr[0]);

            }
            con.Close();






            //dataGridView1.Columns.Add("Id_Grade", "Id_Grade");
            //dataGridView1.Columns.Add("Grade", "Grade");
            //dataGridView1.Columns.Add("Matricule", "Matricule");

            //con.Open();
            //cmd = new SqlCommand("Select Matricule from Grade", con);
            //dr = cmd.ExecuteReader(); 
            //while (dr.Read())
            //{
            //    comboBox1.Items.Add(dr[0]);

            //}
            //con.Close();


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand("Select * from Salarie  ", con);
            dr = cmd.ExecuteReader();
            dataGridView1.Rows.Clear();
            while (dr.Read())
            {
                dataGridView1.Rows.Add(dr["Matricule"], dr["Nom"], dr["Prenom"], dr["Ville"], dr["Age"], dr["EtatCivil"], dr["Adresse"], dr["Telephone"], dr["Fonctions"]);

            }
            dr.Close();
            con.Close();

            //con.Open();
            //cmd = new SqlCommand("Select * from Grade  ", con);
            //dr = cmd.ExecuteReader();
            //dataGridView1.Rows.Clear();
            //while (dr.Read())
            //{
            //    dataGridView1.Rows.Add(dr[0], dr[1], dr[2]);

            //}
            //dr.Close();
            //con.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //con.Open();
            //cmd = new SqlCommand("select * from Grade", con);
            //dr = cmd.ExecuteReader();
            //dataGridView1.Rows.Clear();
            //if (dr.Read())
            //{
            //    dataGridView1.Rows.Add(dr["Id_Grad"], dr["Grade"]);
            //}
            //dr.Close();
            //con.Close();

            //con.Open();
            //cmd = new SqlCommand("select * from Salarie", con);
            //dr = cmd.ExecuteReader();
            //dataGridView1.Rows.Clear();
            //if (dr.Read())
            //{
            //    dataGridView1.Rows.Add(dr["Matricule"], dr["Nom"],dr["Prenom"], dr["Ville"],dr["Age"], dr["EtatCivil"],dr["Adresse"], dr["Telephone"], dr["Fonctions"]);
            //}
            //dr.Close();
            //con.Close();
            con.Open();
            cmd = new SqlCommand("select * from Grade g inner join Salarie s on s.Matricule =g.Matricule where  g.Grade='" + comboBox1.Text + "'", con);
            dr = cmd.ExecuteReader();
            dataGridView1.Rows.Clear();
            if (dr.Read())
            {
                dataGridView1.Rows.Add(dr["Matricule"], dr["Nom"], dr["Prenom"], dr["Ville"], dr["Age"], dr["EtatCivil"], dr["Adresse"], dr["Telephone"], dr["Fonctions"]);
            }
            dr.Close();
            con.Close();





        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
