namespace PPE_MISSION_2_MAISON_DES_LIGUES
{
    partial class FormulaireModif
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
            this.etatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.m2l_Marco_SalimDataSet4 = new PPE_MISSION_2_MAISON_DES_LIGUES.m2l_Marco_SalimDataSet4();
            this.labelChangement = new System.Windows.Forms.Label();
            this.etatTableAdapter = new PPE_MISSION_2_MAISON_DES_LIGUES.m2l_Marco_SalimDataSet4TableAdapters.etatTableAdapter();
            this.buttValiderChangement = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.etatBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m2l_Marco_SalimDataSet4)).BeginInit();
            this.SuspendLayout();
            // 
            // etatBindingSource
            // 
            this.etatBindingSource.DataMember = "etat";
            this.etatBindingSource.DataSource = this.m2l_Marco_SalimDataSet4;
            this.etatBindingSource.CurrentChanged += new System.EventHandler(this.etatBindingSource_CurrentChanged);
            // 
            // m2l_Marco_SalimDataSet4
            // 
            this.m2l_Marco_SalimDataSet4.DataSetName = "m2l_Marco_SalimDataSet4";
            this.m2l_Marco_SalimDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // labelChangement
            // 
            this.labelChangement.AutoSize = true;
            this.labelChangement.Location = new System.Drawing.Point(15, 22);
            this.labelChangement.Name = "labelChangement";
            this.labelChangement.Size = new System.Drawing.Size(205, 13);
            this.labelChangement.TabIndex = 1;
            this.labelChangement.Text = "Cliquez sur valider pour passer a l\'état de :";
            this.labelChangement.Click += new System.EventHandler(this.labelChangement_Click);
            // 
            // etatTableAdapter
            // 
            this.etatTableAdapter.ClearBeforeFill = true;
            // 
            // buttValiderChangement
            // 
            this.buttValiderChangement.Location = new System.Drawing.Point(64, 100);
            this.buttValiderChangement.Name = "buttValiderChangement";
            this.buttValiderChangement.Size = new System.Drawing.Size(167, 23);
            this.buttValiderChangement.TabIndex = 2;
            this.buttValiderChangement.Text = "Valider les changements";
            this.buttValiderChangement.UseVisualStyleBackColor = true;
            this.buttValiderChangement.Click += new System.EventHandler(this.buttValiderChangement_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(99, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // FormulaireModif
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 145);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttValiderChangement);
            this.Controls.Add(this.labelChangement);
            this.Name = "FormulaireModif";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormulaireModif";
            this.Load += new System.EventHandler(this.FormulaireModif_Load);
            ((System.ComponentModel.ISupportInitialize)(this.etatBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m2l_Marco_SalimDataSet4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelChangement;
        private m2l_Marco_SalimDataSet4 m2l_Marco_SalimDataSet4;
        private System.Windows.Forms.BindingSource etatBindingSource;
        private m2l_Marco_SalimDataSet4TableAdapters.etatTableAdapter etatTableAdapter;
        private System.Windows.Forms.Button buttValiderChangement;
        private System.Windows.Forms.Label label1;
    }
}