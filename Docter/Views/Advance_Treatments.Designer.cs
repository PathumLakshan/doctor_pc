namespace Docter.Views
{
    partial class Advance_Treatments
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
            this.Button2 = new System.Windows.Forms.Button();
            this.txtpid = new System.Windows.Forms.TextBox();
            this.comboxPname = new System.Windows.Forms.ComboBox();
            this.patientDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtrs = new System.Windows.Forms.TextBox();
            this.btnclear = new System.Windows.Forms.Button();
            this.Button1 = new System.Windows.Forms.Button();
            this.txttid = new System.Windows.Forms.TextBox();
            this.txtprescription = new System.Windows.Forms.TextBox();
            this.dateTreatment = new System.Windows.Forms.DateTimePicker();
            this.Label8 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtdisease = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.patientDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Button2
            // 
            this.Button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button2.Location = new System.Drawing.Point(535, 127);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(216, 44);
            this.Button2.TabIndex = 66;
            this.Button2.Text = "Patient History Search";
            this.Button2.UseVisualStyleBackColor = true;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // txtpid
            // 
            this.txtpid.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtpid.Location = new System.Drawing.Point(149, 131);
            this.txtpid.Name = "txtpid";
            this.txtpid.Size = new System.Drawing.Size(100, 29);
            this.txtpid.TabIndex = 64;
            this.txtpid.TextChanged += new System.EventHandler(this.txtpid_TextChanged);
            // 
            // comboxPname
            // 
            this.comboxPname.AllowDrop = true;
            this.comboxPname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboxPname.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboxPname.DataSource = this.patientDetailsBindingSource;
            this.comboxPname.DisplayMember = "Patient_Name";
            this.comboxPname.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.comboxPname.FormattingEnabled = true;
            this.comboxPname.Location = new System.Drawing.Point(148, 180);
            this.comboxPname.Name = "comboxPname";
            this.comboxPname.Size = new System.Drawing.Size(299, 30);
            this.comboxPname.TabIndex = 49;
            this.comboxPname.SelectedIndexChanged += new System.EventHandler(this.comboxPname_SelectedIndexChanged);
            // 
            // patientDetailsBindingSource
            // 
            this.patientDetailsBindingSource.DataMember = "Patient_Details";
            // 
            
            // txtrs
            // 
            this.txtrs.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtrs.Location = new System.Drawing.Point(148, 463);
            this.txtrs.Name = "txtrs";
            this.txtrs.Size = new System.Drawing.Size(121, 29);
            this.txtrs.TabIndex = 61;
            this.txtrs.TextChanged += new System.EventHandler(this.txtrs_TextChanged);
            // 
            // btnclear
            // 
            this.btnclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Location = new System.Drawing.Point(275, 515);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(211, 35);
            this.btnclear.TabIndex = 63;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // Button1
            // 
            this.Button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button1.Location = new System.Drawing.Point(22, 515);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(211, 35);
            this.Button1.TabIndex = 62;
            this.Button1.Text = "Save";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // txttid
            // 
            this.txttid.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.txttid.Location = new System.Drawing.Point(150, 81);
            this.txttid.Name = "txttid";
            this.txttid.Size = new System.Drawing.Size(100, 29);
            this.txttid.TabIndex = 48;
            // 
            // txtprescription
            // 
            this.txtprescription.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtprescription.Location = new System.Drawing.Point(148, 274);
            this.txtprescription.Multiline = true;
            this.txtprescription.Name = "txtprescription";
            this.txtprescription.Size = new System.Drawing.Size(370, 108);
            this.txtprescription.TabIndex = 58;
            this.txtprescription.TextChanged += new System.EventHandler(this.txtprescription_TextChanged);
            // 
            // dateTreatment
            // 
            this.dateTreatment.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.dateTreatment.Location = new System.Drawing.Point(148, 402);
            this.dateTreatment.Name = "dateTreatment";
            this.dateTreatment.Size = new System.Drawing.Size(299, 29);
            this.dateTreatment.TabIndex = 60;
            this.dateTreatment.ValueChanged += new System.EventHandler(this.DateTimePicker1_ValueChanged);
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label8.Location = new System.Drawing.Point(11, 467);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(57, 25);
            this.Label8.TabIndex = 57;
            this.Label8.Text = "RS\\=";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.Location = new System.Drawing.Point(11, 406);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(53, 25);
            this.Label6.TabIndex = 59;
            this.Label6.Text = "Date";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(7, 274);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(124, 25);
            this.Label5.TabIndex = 56;
            this.Label5.Text = "Prescriptions";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(7, 228);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(83, 25);
            this.Label4.TabIndex = 55;
            this.Label4.Text = "Disease";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(7, 127);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(96, 25);
            this.Label3.TabIndex = 52;
            this.Label3.Text = "Patient ID";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(7, 177);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(129, 25);
            this.Label2.TabIndex = 51;
            this.Label2.Text = "Patient Name";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.Location = new System.Drawing.Point(7, 84);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(135, 25);
            this.Label7.TabIndex = 50;
            this.Label7.Text = "Treatments ID";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(518, 13);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(162, 31);
            this.Label1.TabIndex = 53;
            this.Label1.Text = "Treatments";
            // 
            // txtdisease
            // 
            this.txtdisease.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtdisease.Location = new System.Drawing.Point(148, 228);
            this.txtdisease.Name = "txtdisease";
            this.txtdisease.Size = new System.Drawing.Size(191, 29);
            this.txtdisease.TabIndex = 54;
            this.txtdisease.TextChanged += new System.EventHandler(this.txtdisease_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(538, 192);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(717, 356);
            this.dataGridView1.TabIndex = 67;
            // 
            // Advance_Treatments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1267, 560);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.txtpid);
            this.Controls.Add(this.comboxPname);
            this.Controls.Add(this.txtrs);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.txttid);
            this.Controls.Add(this.txtprescription);
            this.Controls.Add(this.dateTreatment);
            this.Controls.Add(this.Label8);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.txtdisease);
            this.Name = "Advance_Treatments";
            this.Text = "Advance_Treatments";
            this.Load += new System.EventHandler(this.Advance_Treatments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.patientDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button Button2;
        internal System.Windows.Forms.TextBox txtpid;
        internal System.Windows.Forms.ComboBox comboxPname;
        internal System.Windows.Forms.TextBox txtrs;
        internal System.Windows.Forms.Button btnclear;
        internal System.Windows.Forms.Button Button1;
        internal System.Windows.Forms.TextBox txttid;
        internal System.Windows.Forms.TextBox txtprescription;
        internal System.Windows.Forms.DateTimePicker dateTreatment;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox txtdisease;
        private System.Windows.Forms.BindingSource patientDetailsBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}