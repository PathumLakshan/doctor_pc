namespace Docter.Views
{
    partial class Main_Window
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.patientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewPatientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updatePatientDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.treatmentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newTreatmentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.advancedTreatmentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.patientToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.patientDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.treatmentDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.patientTreatmentDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblUser = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.patientToolStripMenuItem,
            this.treatmentsToolStripMenuItem,
            this.reportsToolStripMenuItem,
            this.optionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(750, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // patientToolStripMenuItem
            // 
            this.patientToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewPatientToolStripMenuItem,
            this.updatePatientDetailsToolStripMenuItem});
            this.patientToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientToolStripMenuItem.Name = "patientToolStripMenuItem";
            this.patientToolStripMenuItem.Size = new System.Drawing.Size(100, 29);
            this.patientToolStripMenuItem.Text = "Patient";
            // 
            // addNewPatientToolStripMenuItem
            // 
            this.addNewPatientToolStripMenuItem.Name = "addNewPatientToolStripMenuItem";
            this.addNewPatientToolStripMenuItem.Size = new System.Drawing.Size(321, 30);
            this.addNewPatientToolStripMenuItem.Text = "Add New Patient";
            this.addNewPatientToolStripMenuItem.Click += new System.EventHandler(this.addNewPatientToolStripMenuItem_Click);
            // 
            // updatePatientDetailsToolStripMenuItem
            // 
            this.updatePatientDetailsToolStripMenuItem.Name = "updatePatientDetailsToolStripMenuItem";
            this.updatePatientDetailsToolStripMenuItem.Size = new System.Drawing.Size(321, 30);
            this.updatePatientDetailsToolStripMenuItem.Text = "Update Patient Details";
            this.updatePatientDetailsToolStripMenuItem.Click += new System.EventHandler(this.updatePatientDetailsToolStripMenuItem_Click);
            // 
            // treatmentsToolStripMenuItem
            // 
            this.treatmentsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newTreatmentsToolStripMenuItem,
            this.advancedTreatmentsToolStripMenuItem});
            this.treatmentsToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treatmentsToolStripMenuItem.Name = "treatmentsToolStripMenuItem";
            this.treatmentsToolStripMenuItem.Size = new System.Drawing.Size(145, 29);
            this.treatmentsToolStripMenuItem.Text = "Treatments";
            // 
            // newTreatmentsToolStripMenuItem
            // 
            this.newTreatmentsToolStripMenuItem.Name = "newTreatmentsToolStripMenuItem";
            this.newTreatmentsToolStripMenuItem.Size = new System.Drawing.Size(312, 30);
            this.newTreatmentsToolStripMenuItem.Text = "New Treatments";
            this.newTreatmentsToolStripMenuItem.Click += new System.EventHandler(this.newTreatmentsToolStripMenuItem_Click);
            // 
            // advancedTreatmentsToolStripMenuItem
            // 
            this.advancedTreatmentsToolStripMenuItem.Name = "advancedTreatmentsToolStripMenuItem";
            this.advancedTreatmentsToolStripMenuItem.Size = new System.Drawing.Size(312, 30);
            this.advancedTreatmentsToolStripMenuItem.Text = "Advanced Treatments";
            this.advancedTreatmentsToolStripMenuItem.Click += new System.EventHandler(this.advancedTreatmentsToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.patientToolStripMenuItem1,
            this.treatmentDetailsToolStripMenuItem});
            this.reportsToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(106, 29);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // patientToolStripMenuItem1
            // 
            this.patientToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.patientDetailsToolStripMenuItem});
            this.patientToolStripMenuItem1.Name = "patientToolStripMenuItem1";
            this.patientToolStripMenuItem1.Size = new System.Drawing.Size(273, 30);
            this.patientToolStripMenuItem1.Text = "Patient";
            // 
            // patientDetailsToolStripMenuItem
            // 
            this.patientDetailsToolStripMenuItem.Name = "patientDetailsToolStripMenuItem";
            this.patientDetailsToolStripMenuItem.Size = new System.Drawing.Size(239, 30);
            this.patientDetailsToolStripMenuItem.Text = "Patient Details";
            this.patientDetailsToolStripMenuItem.Click += new System.EventHandler(this.patientDetailsToolStripMenuItem_Click);
            // 
            // treatmentDetailsToolStripMenuItem
            // 
            this.treatmentDetailsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.patientTreatmentDetailsToolStripMenuItem});
            this.treatmentDetailsToolStripMenuItem.Name = "treatmentDetailsToolStripMenuItem";
            this.treatmentDetailsToolStripMenuItem.Size = new System.Drawing.Size(273, 30);
            this.treatmentDetailsToolStripMenuItem.Text = "Treatment Details";
            // 
            // patientTreatmentDetailsToolStripMenuItem
            // 
            this.patientTreatmentDetailsToolStripMenuItem.Name = "patientTreatmentDetailsToolStripMenuItem";
            this.patientTreatmentDetailsToolStripMenuItem.Size = new System.Drawing.Size(355, 30);
            this.patientTreatmentDetailsToolStripMenuItem.Text = "Patient Treatment Details";
            this.patientTreatmentDetailsToolStripMenuItem.Click += new System.EventHandler(this.patientTreatmentDetailsToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewUserToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.optionsToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(105, 29);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // addNewUserToolStripMenuItem
            // 
            this.addNewUserToolStripMenuItem.Name = "addNewUserToolStripMenuItem";
            this.addNewUserToolStripMenuItem.Size = new System.Drawing.Size(231, 30);
            this.addNewUserToolStripMenuItem.Text = "Add New User";
            this.addNewUserToolStripMenuItem.Click += new System.EventHandler(this.addNewUserToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(231, 30);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(631, 9);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(0, 20);
            this.lblUser.TabIndex = 1;
            // 
            // Main_Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 424);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main_Window";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main_Window";
            this.Load += new System.EventHandler(this.Main_Window_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem patientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewPatientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updatePatientDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem treatmentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newTreatmentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem advancedTreatmentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem patientToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem patientDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem treatmentDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem patientTreatmentDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label lblUser;
    }
}