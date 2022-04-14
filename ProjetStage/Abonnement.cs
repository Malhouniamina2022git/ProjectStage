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
    public partial class Abonnement : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-ELPBKRT\\SQLEXPRESS;Initial Catalog=Gestion des personnels;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        public Abonnement()
        {
            InitializeComponent();
        }

        private void Abonnement_Load(object sender, EventArgs e)
        {

            con.Open();
            cmd = new SqlCommand("select Matricule  from Salarie", con);
            dr = cmd.ExecuteReader();
            comboBoxid.Items.Clear();
            while (dr.Read())
            {
                comboBoxid.Items.Add(dr[0]);
            }
            dr.Close();
            con.Close();

            con.Open();
            cmd = new SqlCommand("select typeoffre from Offres ", con);
            dr = cmd.ExecuteReader();
            comboBoxTYP.Items.Clear();
            while (dr.Read())
            {
                comboBoxTYP.Items.Add(dr[0]);
            }
            dr.Close();
            con.Close();


            //con.Open();
            //cmd = new SqlCommand("select a.Matricule, a.Id , a.DateDebut , a.datefin from Abonnements a inner join Offres o on o.Id=a.Id", con);
            //dr = cmd.ExecuteReader();
            //dr.Read();
            //comboBoxid.Text = dr["Matricule"].ToString();
            //comboBoxTYP.Text = dr["typeoffre"].ToString();
            //textBoxoffr.Text = dr["Offre"].ToString();
            //label10.Text = dr["Prix"].ToString();
            //label8.Text = dr["DétailOffre"].ToString();
            //dateTimePicker1.Text = dr["DateDebut"].ToString();
            //dateTimePicker2.Text = dr["datefin"].ToString();
            //dr.Close();
            //con.Close();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {


            con.Open();
            cmd = new SqlCommand("select * from Abonnements a inner join Offres o on o.Id=a.Id where  a.Matricule='"+comboBoxid.Text+"'", con);
            dr = cmd.ExecuteReader();
            dr.Read();
            comboBoxid.Text.Equals(dr["Matricule"]);
            dateTimePicker1.Text = dr["DateDebut"].ToString();
            dateTimePicker2.Text = dr["datefin"].ToString();
            textBoxoffr.Text = dr["Offre"].ToString();
            labelpx.Text = dr["Prix"].ToString();
            labeldetl.Text = dr["DétailOffre"].ToString();
            comboBoxTYP.Text = dr["typeoffre"].ToString();
            dr.Close();
            con.Close();




            //con.Open();
            //cmd = new SqlCommand("select * from Abonnement where Matricule ='" + textBoxsal.Text + "'", con);
            //SqlDataReader dr = cmd.ExecuteReader();
            //dr.Read();
            //textBoxsal.Text.Equals(dr["Matricule"]);
            //textBoxID.Text = dr["IdOffre"].ToString();
            //textBoxDEP.Text = dr["Num_Dept"].ToString();
            //textBoxPRX.Text = dr["Prix"].ToString();
            //dateTimePicker1.Text = dr["DateDebut"].ToString();
            //dateTimePicker2.Text = dr["DateFin"].ToString();
            //textBoxsal.Focus();
            //dr.Close();
            //con.Close();

            //con.Open();
            //cmd = new SqlCommand("SELECT * FROM Offre o INNER JOIN Abonnement ab ON o.Id =ab.IdOffre where IdOffre ='"+textBoxID.Text+"'", con);
            //dr = cmd.ExecuteReader();
            //dr.Read();
            //textBoxID.Text.Equals(dr["Id"]);
            //textBoxoffr.Text = dr["Offre"].ToString();
            //comboBoxTYP.Text = dr["TypeOffre"].ToString();
            //textBoxID.Focus();
            //dr.Close();
            //con.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //this.Hide();
            //CRYSTAL2 cr2 = new CRYSTAL2();
            //cr2.Refresh();
        }

        private void pictureBoxaouter_Click(object sender, EventArgs e)
        {
            
            con.Open();
            //SqlDataAdapter adapter = new SqlDataAdapter("SELECT * from Offres", con);
            //DataSet data = new DataSet();
            //adapter.Fill(data, "offres");
            //comboBoxid.DataSource = data;
            //comboBoxid.ValueMember = "Id"; 
            //comboBoxid.DisplayMember = "typeoffre";
            //cmd = new SqlCommand("insert into Abonnements (Matricule,Id,DateDebut,datefin) values (" + comboBoxid.Text + ",'" + comboBoxTYP.Text + "','" + dateTimePicker1.Value + "','" + dateTimePicker2.Value + "'", con);
            cmd = new SqlCommand("insert into Abonnements values ('" + comboBoxid.Text + "','" + comboBoxTYP.Text + "','" + DateTime.Parse(dateTimePicker1.Text) + "','" + DateTime.Parse(dateTimePicker2.Text) + "'", con);

            cmd.ExecuteNonQuery();
            MessageBox.Show("BIEN AJOUTEE");
            con.Close();

            //"','" + labelpx.Text + "','" + labeldetl.Text +

        }

        private void pictureBoxmod_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand("Update Abonnements set  typeoffre='" + comboBoxTYP.Text + "',offre ='" + textBoxoffr.Text + "',DateDebut ='" + dateTimePicker1.Text + "',datefin ='" + dateTimePicker2.Text + "'where Matricule ='" + comboBoxid.Text + "'", con); ;
            cmd.ExecuteNonQuery();
            MessageBox.Show("bien modifier");
            con.Close();

        }

        private void pictureBoxsupp_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand("Delete from Abonnements  where Matricule='" + comboBoxid.Text + "'", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("bien supprimer");
            con.Close();
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            abonnementoffre ab = new abonnementoffre();
            ab.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
