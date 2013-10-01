namespace PPE_MISSION_2_MAISON_DES_LIGUES
{
    partial class menuGrade0
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
            this.buttDemanderService = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.labelService = new System.Windows.Forms.Label();
            this.m2l_Marco_SalimDataSet = new PPE_MISSION_2_MAISON_DES_LIGUES.m2l_Marco_SalimDataSet();
            this.typeServiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.typeServiceTableAdapter = new PPE_MISSION_2_MAISON_DES_LIGUES.m2l_Marco_SalimDataSetTableAdapters.typeServiceTableAdapter();
            this.m2l_Marco_SalimDataSet1 = new PPE_MISSION_2_MAISON_DES_LIGUES.m2l_Marco_SalimDataSet1();
            this.typeServiceBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.typeServiceTableAdapter1 = new PPE_MISSION_2_MAISON_DES_LIGUES.m2l_Marco_SalimDataSet1TableAdapters.typeServiceTableAdapter();
            this.m2l_Marco_SalimDataSet2 = new PPE_MISSION_2_MAISON_DES_LIGUES.m2l_Marco_SalimDataSet2();
            this.typeServiceBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.typeServiceTableAdapter2 = new PPE_MISSION_2_MAISON_DES_LIGUES.m2l_Marco_SalimDataSet2TableAdapters.typeServiceTableAdapter();
            this.calendrierService = new System.Windows.Forms.DateTimePicker();
            this.labelDate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.m2l_Marco_SalimDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeServiceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m2l_Marco_SalimDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeServiceBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m2l_Marco_SalimDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeServiceBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // buttDemanderService
            // 
            this.buttDemanderService.Location = new System.Drawing.Point(80, 44);
            this.buttDemanderService.Name = "buttDemanderService";
            this.buttDemanderService.Size = new System.Drawing.Size(131, 23);
            this.buttDemanderService.TabIndex = 0;
            this.buttDemanderService.Text = "Demander un Service";
            this.buttDemanderService.UseVisualStyleBackColor = true;
            this.buttDemanderService.Click += new System.EventHandler(this.buttDemanderService_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Menu";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.typeServiceBindingSource2;
            this.comboBox1.DisplayMember = "libelleService";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(80, 195);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.ValueMember = "id";
            // 
            // labelService
            // 
            this.labelService.AutoSize = true;
            this.labelService.Location = new System.Drawing.Point(12, 198);
            this.labelService.Name = "labelService";
            this.labelService.Size = new System.Drawing.Size(43, 13);
            this.labelService.TabIndex = 3;
            this.labelService.Text = "Service";
            // 
            // m2l_Marco_SalimDataSet
            // 
            this.m2l_Marco_SalimDataSet.DataSetName = "m2l_Marco_SalimDataSet";
            this.m2l_Marco_SalimDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // typeServiceBindingSource
            // 
            this.typeServiceBindingSource.DataMember = "typeService";
            this.typeServiceBindingSource.DataSource = this.m2l_Marco_SalimDataSet;
            // 
            // typeServiceTableAdapter
            // 
            this.typeServiceTableAdapter.ClearBeforeFill = true;
            // 
            // m2l_Marco_SalimDataSet1
            // 
            this.m2l_Marco_SalimDataSet1.DataSetName = "m2l_Marco_SalimDataSet1";
            this.m2l_Marco_SalimDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // typeServiceBindingSource1
            // 
            this.typeServiceBindingSource1.DataMember = "typeService";
            this.typeServiceBindingSource1.DataSource = this.m2l_Marco_SalimDataSet1;
            // 
            // typeServiceTableAdapter1
            // 
            this.typeServiceTableAdapter1.ClearBeforeFill = true;
            // 
            // m2l_Marco_SalimDataSet2
            // 
            this.m2l_Marco_SalimDataSet2.DataSetName = "m2l_Marco_SalimDataSet2";
            this.m2l_Marco_SalimDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // typeServiceBindingSource2
            // 
            this.typeServiceBindingSource2.DataMember = "typeService";
            this.typeServiceBindingSource2.DataSource = this.m2l_Marco_SalimDataSet2;
            // 
            // typeServiceTableAdapter2
            // 
            this.typeServiceTableAdapter2.ClearBeforeFill = true;
            // 
            // calendrierService
            // 
            this.calendrierService.Location = new System.Drawing.Point(80, 138);
            this.calendrierService.Name = "calendrierService";
            this.calendrierService.Size = new System.Drawing.Size(200, 20);
            this.calendrierService.TabIndex = 4;
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(13, 144);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(30, 13);
            this.labelDate.TabIndex = 5;
            this.labelDate.Text = "Date";
            // 
            // menuGrade0
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 497);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.calendrierService);
            this.Controls.Add(this.labelService);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttDemanderService);
            this.Name = "menuGrade0";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Adhérent";
            this.Load += new System.EventHandler(this.menuGrade0_Load);
            ((System.ComponentModel.ISupportInitialize)(this.m2l_Marco_SalimDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeServiceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m2l_Marco_SalimDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeServiceBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m2l_Marco_SalimDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeServiceBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttDemanderService;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label labelService;
        private m2l_Marco_SalimDataSet m2l_Marco_SalimDataSet;
        private System.Windows.Forms.BindingSource typeServiceBindingSource;
        private m2l_Marco_SalimDataSetTableAdapters.typeServiceTableAdapter typeServiceTableAdapter;
        private m2l_Marco_SalimDataSet1 m2l_Marco_SalimDataSet1;
        private System.Windows.Forms.BindingSource typeServiceBindingSource1;
        private m2l_Marco_SalimDataSet1TableAdapters.typeServiceTableAdapter typeServiceTableAdapter1;
        private m2l_Marco_SalimDataSet2 m2l_Marco_SalimDataSet2;
        private System.Windows.Forms.BindingSource typeServiceBindingSource2;
        private m2l_Marco_SalimDataSet2TableAdapters.typeServiceTableAdapter typeServiceTableAdapter2;
        private System.Windows.Forms.DateTimePicker calendrierService;
        private System.Windows.Forms.Label labelDate;
    }
}