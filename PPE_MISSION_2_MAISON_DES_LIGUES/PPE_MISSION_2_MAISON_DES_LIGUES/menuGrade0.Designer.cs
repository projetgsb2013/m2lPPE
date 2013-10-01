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
            this.buttDemanderService = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttDemanderService
            // 
            this.buttDemanderService.Location = new System.Drawing.Point(66, 44);
            this.buttDemanderService.Name = "buttDemanderService";
            this.buttDemanderService.Size = new System.Drawing.Size(131, 23);
            this.buttDemanderService.TabIndex = 0;
            this.buttDemanderService.Text = "Demande un Service";
            this.buttDemanderService.UseVisualStyleBackColor = true;
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
            // menuGrade0
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 229);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttDemanderService);
            this.Name = "menuGrade0";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Adhérent";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttDemanderService;
        private System.Windows.Forms.Label label1;
    }
}