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
    public partial class Offre : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-ELPBKRT\\SQLEXPRESS;Initial Catalog=Gestion des personnels;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        public Offre()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Mobile m = new Mobile();
            m.Show();
        }

        private void Offre_Load(object sender, EventArgs e)
        {

            
            dataGridView1.Columns.Add("Offre", "Offre");
            dataGridView1.Columns.Add("Prix", "prix");
            dataGridView1.Columns.Add("détail_offre", "détail_offre");
            dataGridView1.Columns.Add("Type_Offre", "Type_Offre");
            

            con.Open();
            cmd = new SqlCommand("Select typeoffre from Offres ", con);
            dr = cmd.ExecuteReader();
            comboBox1.Items.Clear();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr[0]);
            }
            dr.Close();
            con.Close();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand("Select * from Offres ", con);
            dr = cmd.ExecuteReader();
            dataGridView1.Rows.Clear();
            while (dr.Read())
            {
                dataGridView1.Rows.Add( dr[1], dr[2], dr[3], dr[4]);

            }
            dr.Close();
            con.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            con.Open();
            cmd = new SqlCommand("insert into Offres values ('" + textBoxoffre.Text + "','" + textBoxpx.Text + "','" + richTextBox1.Text + "','" + comboBox1.Text + "')", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("insertion est réussit");
            textBoxoffre.Clear();
            textBoxpx.Clear();
            comboBox1.Items.Clear();
            richTextBox1.Clear();
            con.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand("Update Offres set  prix='" + textBoxpx.Text + "',DétailOffre ='" + richTextBox1.Text + "',typeoffre ='" + comboBox1.Text + "'where Offre ='" + textBoxoffre.Text + "'", con);
            cmd.ExecuteNonQuery();
            comboBox1.Items.Clear();
            MessageBox.Show("bien modifier");
            textBoxoffre.Clear();
            textBoxpx.Clear();
            comboBox1.Items.Clear();
            richTextBox1.Clear();
            con.Close();

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand("delete from Offres where Offre='" + textBoxoffre.Text + "'", con);
            cmd.ExecuteNonQuery();
            comboBox1.Items.Clear();
            MessageBox.Show("bien supprimer");
            textBoxoffre.Clear();
            textBoxpx.Clear();
            comboBox1.Items.Clear();
            richTextBox1.Clear();
            con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxoffre.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBoxoffre.Enabled = false; 
            textBoxpx.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            richTextBox1.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            comboBox1.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();



        }

        private void button2_Click(object sender, EventArgs e)
        {
            Fixe f = new Fixe();
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            internet i = new internet();
            i.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
                con.Open();
                cmd = new SqlCommand("Select * from Offres where typeoffre='"+comboBox1.Text+"'", con);
                dr = cmd.ExecuteReader();
            comboBox1.Items.Clear();
            if (dr.Read())
            
                comboBox1.Text = dr[0].ToString();
                textBoxoffre.Text = dr[1].ToString();
                textBoxpx.Text = dr[2].ToString();
                richTextBox1.Text = dr[3].ToString();
                con.Close();
           
                
           
        }

        private void textBoxoffre_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
