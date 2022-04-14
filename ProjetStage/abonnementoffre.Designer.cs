
namespace ProjetStage
{
    partial class abonnementoffre
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label nomLabel;
            System.Windows.Forms.Label prenomLabel;
            System.Windows.Forms.Label villeLabel;
            System.Windows.Forms.Label ageLabel;
            this.gestion_des_personnelsDataSet = new ProjetStage.Gestion_des_personnelsDataSet();
            this.abonnementsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.abonnementsTableAdapter = new ProjetStage.Gestion_des_personnelsDataSetTableAdapters.AbonnementsTableAdapter();
            this.tableAdapterManager = new ProjetStage.Gestion_des_personnelsDataSetTableAdapters.TableAdapterManager();
            this.offresTableAdapter = new ProjetStage.Gestion_des_personnelsDataSetTableAdapters.OffresTableAdapter();
            this.salarieTableAdapter = new ProjetStage.Gestion_des_personnelsDataSetTableAdapters.SalarieTableAdapter();
            this.offresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.offresBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.ageTextBox = new System.Windows.Forms.TextBox();
            this.salarieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.villeTextBox = new System.Windows.Forms.TextBox();
            this.nomTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.offresComboBox = new System.Windows.Forms.ComboBox();
            this.prenomTextBox = new System.Windows.Forms.TextBox();
            this.salarieBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.abonnementsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.offresBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.salarieBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.salarieComboBox = new System.Windows.Forms.ComboBox();
            nomLabel = new System.Windows.Forms.Label();
            prenomLabel = new System.Windows.Forms.Label();
            villeLabel = new System.Windows.Forms.Label();
            ageLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gestion_des_personnelsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.abonnementsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.offresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.offresBindingSource1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salarieBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salarieBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.abonnementsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.offresBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salarieBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // nomLabel
            // 
            nomLabel.AutoSize = true;
            nomLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nomLabel.Location = new System.Drawing.Point(496, 33);
            nomLabel.Name = "nomLabel";
            nomLabel.Size = new System.Drawing.Size(41, 15);
            nomLabel.TabIndex = 4;
            nomLabel.Text = "Nom:";
            nomLabel.Click += new System.EventHandler(this.nomLabel_Click);
            // 
            // prenomLabel
            // 
            prenomLabel.AutoSize = true;
            prenomLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            prenomLabel.Location = new System.Drawing.Point(482, 68);
            prenomLabel.Name = "prenomLabel";
            prenomLabel.Size = new System.Drawing.Size(61, 15);
            prenomLabel.TabIndex = 6;
            prenomLabel.Text = "Prenom:";
            prenomLabel.Click += new System.EventHandler(this.prenomLabel_Click);
            // 
            // villeLabel
            // 
            villeLabel.AutoSize = true;
            villeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            villeLabel.Location = new System.Drawing.Point(496, 97);
            villeLabel.Name = "villeLabel";
            villeLabel.Size = new System.Drawing.Size(39, 15);
            villeLabel.TabIndex = 10;
            villeLabel.Text = "Ville:";
            // 
            // ageLabel
            // 
            ageLabel.AutoSize = true;
            ageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ageLabel.Location = new System.Drawing.Point(496, 127);
            ageLabel.Name = "ageLabel";
            ageLabel.Size = new System.Drawing.Size(35, 15);
            ageLabel.TabIndex = 12;
            ageLabel.Text = "Age:";
            // 
            // gestion_des_personnelsDataSet
            // 
            this.gestion_des_personnelsDataSet.DataSetName = "Gestion_des_personnelsDataSet";
            this.gestion_des_personnelsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // abonnementsBindingSource
            // 
            this.abonnementsBindingSource.DataMember = "Abonnements";
            this.abonnementsBindingSource.DataSource = this.gestion_des_personnelsDataSet;
            // 
            // abonnementsTableAdapter
            // 
            this.abonnementsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AbonnementsTableAdapter = this.abonnementsTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientTableAdapter = null;
            this.tableAdapterManager.ConnecterTableAdapter = null;
            this.tableAdapterManager.DepartementTableAdapter = null;
            this.tableAdapterManager.GradeTableAdapter = null;
            this.tableAdapterManager.OffresTableAdapter = this.offresTableAdapter;
            this.tableAdapterManager.SalarieTableAdapter = this.salarieTableAdapter;
            this.tableAdapterManager.Service1TableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ProjetStage.Gestion_des_personnelsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // offresTableAdapter
            // 
            this.offresTableAdapter.ClearBeforeFill = true;
            // 
            // salarieTableAdapter
            // 
            this.salarieTableAdapter.ClearBeforeFill = true;
            // 
            // offresBindingSource
            // 
            this.offresBindingSource.DataMember = "Offres";
            this.offresBindingSource.DataSource = this.gestion_des_personnelsDataSet;
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(810, 543);
            this.crystalReportViewer1.TabIndex = 0;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.crystalReportViewer1.Load += new System.EventHandler(this.crystalReportViewer1_Load);
            // 
            // offresBindingSource1
            // 
            this.offresBindingSource1.DataMember = "Offres";
            this.offresBindingSource1.DataSource = this.gestion_des_personnelsDataSet;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.salarieComboBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.ageTextBox);
            this.groupBox1.Controls.Add(this.villeTextBox);
            this.groupBox1.Controls.Add(villeLabel);
            this.groupBox1.Controls.Add(ageLabel);
            this.groupBox1.Controls.Add(this.nomTextBox);
            this.groupBox1.Controls.Add(nomLabel);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.offresComboBox);
            this.groupBox1.Controls.Add(this.prenomTextBox);
            this.groupBox1.Controls.Add(prenomLabel);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(810, 174);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " ";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(68, 112);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(310, 35);
            this.button1.TabIndex = 14;
            this.button1.Text = "Imprimer ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ageTextBox
            // 
            this.ageTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.salarieBindingSource, "Age", true));
            this.ageTextBox.Location = new System.Drawing.Point(559, 127);
            this.ageTextBox.Name = "ageTextBox";
            this.ageTextBox.Size = new System.Drawing.Size(100, 20);
            this.ageTextBox.TabIndex = 13;
            // 
            // salarieBindingSource
            // 
            this.salarieBindingSource.DataMember = "Salarie";
            this.salarieBindingSource.DataSource = this.gestion_des_personnelsDataSet;
            // 
            // villeTextBox
            // 
            this.villeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.salarieBindingSource, "Ville", true));
            this.villeTextBox.Location = new System.Drawing.Point(559, 97);
            this.villeTextBox.Name = "villeTextBox";
            this.villeTextBox.Size = new System.Drawing.Size(100, 20);
            this.villeTextBox.TabIndex = 11;
            // 
            // nomTextBox
            // 
            this.nomTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.salarieBindingSource, "Nom", true));
            this.nomTextBox.Location = new System.Drawing.Point(559, 33);
            this.nomTextBox.Multiline = true;
            this.nomTextBox.Name = "nomTextBox";
            this.nomTextBox.Size = new System.Drawing.Size(100, 20);
            this.nomTextBox.TabIndex = 5;
            this.nomTextBox.TextChanged += new System.EventHandler(this.nomTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Choisir Id d\'offre ";
            // 
            // offresComboBox
            // 
            this.offresComboBox.DataSource = this.offresBindingSource1;
            this.offresComboBox.DisplayMember = "Id";
            this.offresComboBox.FormattingEnabled = true;
            this.offresComboBox.Location = new System.Drawing.Point(32, 63);
            this.offresComboBox.Name = "offresComboBox";
            this.offresComboBox.Size = new System.Drawing.Size(185, 21);
            this.offresComboBox.TabIndex = 1;
            this.offresComboBox.ValueMember = "Id";
            this.offresComboBox.SelectedIndexChanged += new System.EventHandler(this.offresComboBox_SelectedIndexChanged);
            // 
            // prenomTextBox
            // 
            this.prenomTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.salarieBindingSource, "Prenom", true));
            this.prenomTextBox.Location = new System.Drawing.Point(559, 61);
            this.prenomTextBox.Name = "prenomTextBox";
            this.prenomTextBox.Size = new System.Drawing.Size(100, 20);
            this.prenomTextBox.TabIndex = 7;
            this.prenomTextBox.TextChanged += new System.EventHandler(this.prenomTextBox_TextChanged);
            // 
            // salarieBindingSource1
            // 
            this.salarieBindingSource1.DataMember = "Salarie";
            this.salarieBindingSource1.DataSource = this.gestion_des_personnelsDataSet;
            // 
            // abonnementsBindingSource1
            // 
            this.abonnementsBindingSource1.DataMember = "Abonnements";
            this.abonnementsBindingSource1.DataSource = this.gestion_des_personnelsDataSet;
            // 
            // offresBindingSource2
            // 
            this.offresBindingSource2.DataMember = "Offres";
            this.offresBindingSource2.DataSource = this.gestion_des_personnelsDataSet;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(284, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Choisir id de Salarié :";
            // 
            // salarieBindingSource2
            // 
            this.salarieBindingSource2.DataMember = "Salarie";
            this.salarieBindingSource2.DataSource = this.gestion_des_personnelsDataSet;
            // 
            // salarieComboBox
            // 
            this.salarieComboBox.DataSource = this.salarieBindingSource2;
            this.salarieComboBox.DisplayMember = "Matricule";
            this.salarieComboBox.FormattingEnabled = true;
            this.salarieComboBox.Location = new System.Drawing.Point(259, 68);
            this.salarieComboBox.Name = "salarieComboBox";
            this.salarieComboBox.Size = new System.Drawing.Size(182, 21);
            this.salarieComboBox.TabIndex = 15;
            this.salarieComboBox.ValueMember = "Matricule";
            // 
            // abonnementoffre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 543);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.crystalReportViewer1);
            this.Name = "abonnementoffre";
            this.Text = "abonnementoffre";
            this.Load += new System.EventHandler(this.abonnementoffre_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gestion_des_personnelsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.abonnementsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.offresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.offresBindingSource1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salarieBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salarieBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.abonnementsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.offresBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salarieBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Gestion_des_personnelsDataSet gestion_des_personnelsDataSet;
        private System.Windows.Forms.BindingSource abonnementsBindingSource;
        private Gestion_des_personnelsDataSetTableAdapters.AbonnementsTableAdapter abonnementsTableAdapter;
        private Gestion_des_personnelsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private Gestion_des_personnelsDataSetTableAdapters.OffresTableAdapter offresTableAdapter;
        private System.Windows.Forms.BindingSource offresBindingSource;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private Gestion_des_personnelsDataSetTableAdapters.SalarieTableAdapter salarieTableAdapter;
        private System.Windows.Forms.BindingSource offresBindingSource1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource salarieBindingSource;
        private System.Windows.Forms.TextBox nomTextBox;
        private System.Windows.Forms.TextBox prenomTextBox;
        private System.Windows.Forms.TextBox villeTextBox;
        private System.Windows.Forms.TextBox ageTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox offresComboBox;
        private System.Windows.Forms.BindingSource salarieBindingSource1;
        private System.Windows.Forms.BindingSource offresBindingSource2;
        private System.Windows.Forms.BindingSource abonnementsBindingSource1;
        private System.Windows.Forms.ComboBox salarieComboBox;
        private System.Windows.Forms.BindingSource salarieBindingSource2;
        private System.Windows.Forms.Label label2;
    }
}