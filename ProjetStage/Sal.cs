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
    public partial class Sal : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-ELPBKRT\\SQLEXPRESS;Initial Catalog=Gestion des personnels;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        int i;
        public Sal()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void Sal_Load(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand("select * from Salarie ", con);
            dr = cmd.ExecuteReader();
            comboBoxdept.Items.Clear();
            comboBoxfonct.Items.Clear();
            combonumServic.Items.Clear();
            while (dr.Read())
            {
                comboBoxdept.Items.Add(dr[3]);
                comboBoxfonct.Items.Add(dr[9]);
                combonumServic.Items.Add(dr[11]);
            }
            con.Close();

            con.Open();
            cmd = new SqlCommand("select * from Service1", con);
            dr = cmd.ExecuteReader();
            combonumser.Items.Clear();
            comboBoxNomserv.Items.Clear();
            comboBchef.Items.Clear();
            while (dr.Read())
            {
                combonumser.Items.Add(dr[0]);
                comboBoxNomserv.Items.Add(dr[1]);
                comboBchef.Items.Add(dr[2]);
            }
            con.Close();


        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            con.Open();
            textMatricul.Clear();
            textNOM.Clear();
            textprenom.Clear();
            comboBoxdept.Items.Clear();
            textBoxvill.Clear();
            textBoxage.Clear();
            textBoxeta.Clear();
            textBoxadress.Clear();
            textBoxtel.Clear();
            comboBoxfonct.Items.Clear();
            textBoxpass.Clear();
            combonumServic.Items.Clear();
            combonumser.Items.Clear();
            comboBoxNomserv.Items.Clear();
            comboBchef.Items.Clear();
            con.Close();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand("insert into Salarie values ('" + textMatricul.Text + "','" + textNOM.Text + "','" + textprenom.Text + "','" + comboBoxdept.Text + "','" + textBoxvill.Text + "','" + textBoxage.Text + "','"
                + textBoxeta.Text + "','" + textBoxadress.Text + "','" + textBoxtel.Text + "','" + comboBoxfonct.Text + "','" + textBoxpass.Text + "','" + combonumServic.Text + "')", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("bien Ajouter");
            textMatricul.Focus();
            con.Close();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBoxmod_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand("update Salarie set Nom='" + textNOM.Text + "',Prenom ='" + textprenom.Text + "',Num_Dept='" + comboBoxdept.Text +
                "',Ville='" + textBoxvill.Text + "',Age='" + textBoxage.Text + "',EtatCivil='" + textBoxeta.Text + "',Adresse='" + textBoxadress.Text + "',Telephone='" + textBoxtel.Text +
                "',Fonctions='" + comboBoxfonct.Text + "',Password1='" + textBoxpass.Text + "',NumService='" + combonumServic.Text + "'where Matricule='"+textMatricul.Text+ "'", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("bien Modifier");
            con.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            i = 0;
            con.Open();
            cmd = new SqlCommand("select * from Salarie", con);
            dr = cmd.ExecuteReader();
            dr.Read();
            textMatricul.Text = dr[0].ToString();
            textNOM.Text = dr[1].ToString();
            textprenom.Text = dr[2].ToString();
            comboBoxdept.Text = dr[3].ToString();
            textBoxvill.Text = dr[4].ToString();
            textBoxage.Text = dr[5].ToString();
            textBoxeta.Text = dr[6].ToString();
            textBoxadress.Text = dr[7].ToString();
            textBoxtel.Text = dr[8].ToString();
            comboBoxfonct.Text = dr[9].ToString();
            textBoxpass.Text = dr[10].ToString();
            combonumServic.Text = dr[11].ToString();
            con.Close();

            con.Open();
            cmd = new SqlCommand("Select * from Service1", con);
            dr = cmd.ExecuteReader();
            dr.Read();
            combonumser.Text = dr[0].ToString();
            comboBoxNomserv.Text = dr[1].ToString();
            comboBchef.Text = dr[2].ToString();
            con.Close();
        }

        private void pictureBoxsupp_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand("Delete from Salarie where Matricule='" + textMatricul.Text + "'", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("bien supprimer");
            textMatricul.Focus();
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            try
            {
                cmd = new SqlCommand("Select * from Salarie where Matricule < "+textMatricul.Text+ "order by Matricule Desc", con);
                dr = cmd.ExecuteReader();
                dr.Read();
                textMatricul.Text = dr[0].ToString();
                textNOM.Text = dr[1].ToString();
                textprenom.Text = dr[2].ToString();
                comboBoxdept.Text = dr[3].ToString();
                textBoxvill.Text = dr[4].ToString();
                textBoxage.Text = dr[5].ToString();
                textBoxeta.Text = dr[6].ToString();
                textBoxadress.Text = dr[7].ToString();
                textBoxtel.Text = dr[8].ToString();
                comboBoxfonct.Text = dr[9].ToString();
                textBoxpass.Text = dr[10].ToString();
                combonumServic.Text = dr[11].ToString();
            }
            catch { MessageBox.Show("Fin"); }
            con.Close();

            con.Open();
            cmd = new SqlCommand("Select * from Service1 where NumService <" + combonumser.Text+ "order by NumService Desc", con) ;
            dr = cmd.ExecuteReader();
            dr.Read();
            combonumser.Text = dr[0].ToString();
            comboBoxNomserv.Text = dr[1].ToString();
            comboBchef.Text = dr[2].ToString();
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            try
            {
                cmd = new SqlCommand("Select * from Salarie where Matricule > " + textMatricul.Text + "order by Matricule Asc", con);
                dr = cmd.ExecuteReader();
                dr.Read();
                textMatricul.Text = dr[0].ToString();
                textNOM.Text = dr[1].ToString();
                textprenom.Text = dr[2].ToString();
                comboBoxdept.Text = dr[3].ToString();
                textBoxvill.Text = dr[4].ToString();
                textBoxage.Text = dr[5].ToString();
                textBoxeta.Text = dr[6].ToString();
                textBoxadress.Text = dr[7].ToString();
                textBoxtel.Text = dr[8].ToString();
                comboBoxfonct.Text = dr[9].ToString();
                textBoxpass.Text = dr[10].ToString();
                combonumServic.Text = dr[11].ToString();
            }
            catch { MessageBox.Show("Fin"); }
            con.Close();

            con.Open();
            try
            {
                cmd = new SqlCommand("Select * from Service1 where NumService >" + combonumser.Text + "order by NumService Asc", con);
                dr = cmd.ExecuteReader();
                dr.Read();
                combonumser.Text = dr[0].ToString();
                comboBoxNomserv.Text = dr[1].ToString();
                comboBchef.Text = dr[2].ToString();
            }
            catch { MessageBox.Show("Fin"); }
            con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand("Select * from Salarie", con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                textMatricul.Text = dr[0].ToString();
                textNOM.Text = dr[1].ToString();
                textprenom.Text = dr[2].ToString();
                comboBoxdept.Text = dr[3].ToString();
                textBoxvill.Text = dr[4].ToString();
                textBoxage.Text = dr[5].ToString();
                textBoxeta.Text = dr[6].ToString();
                textBoxadress.Text = dr[7].ToString();
                textBoxtel.Text = dr[8].ToString();
                comboBoxfonct.Text = dr[9].ToString();
                textBoxpass.Text = dr[10].ToString();
                combonumServic.Text = dr[11].ToString();
            }
            i++;
            con.Close();
            con.Open();
            cmd = new SqlCommand("Select * from Service1", con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                combonumser.Text = dr[0].ToString();
                comboBoxNomserv.Text = dr[1].ToString();
                comboBchef.Text = dr[2].ToString();
               
            }
            i++;
            con.Close();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
