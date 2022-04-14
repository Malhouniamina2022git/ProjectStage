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
    public partial class abonnementoffre : Form
    { 
        public abonnementoffre()
        {
            InitializeComponent();
        }

        

        private void abonnementoffre_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'gestion_des_personnelsDataSet.Salarie'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.salarieTableAdapter.Fill(this.gestion_des_personnelsDataSet.Salarie);
            // TODO: cette ligne de code charge les données dans la table 'gestion_des_personnelsDataSet.Offres'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.offresTableAdapter.Fill(this.gestion_des_personnelsDataSet.Offres);
            // TODO: cette ligne de code charge les données dans la table 'gestion_des_personnelsDataSet.Abonnements'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.abonnementsTableAdapter.Fill(this.gestion_des_personnelsDataSet.Abonnements);


            

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void nomTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void prenomLabel_Click(object sender, EventArgs e)
        {

        }

        private void prenomTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void nomLabel_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CrystalAbonnemeNew crn = new CrystalAbonnemeNew();
            crn.SetDataSource(gestion_des_personnelsDataSet);
            crystalReportViewer1.ReportSource = crn;
            crystalReportViewer1.SelectionFormula = "{Offres.Id} =" + offresComboBox.SelectedValue;
            crystalReportViewer1.SelectionFormula = "{Salarie.Matricule} =" + salarieComboBox.SelectedValue;


        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void offresComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.salarieTableAdapter.FillBy(this.gestion_des_personnelsDataSet.Salarie);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
