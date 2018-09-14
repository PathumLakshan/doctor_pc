namespace Docter.Views
{
    partial class Treatments
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
            this.txtpid = new System.Windows.Forms.TextBox();
            this.comboxPname = new System.Windows.Forms.ComboBox();
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
            this.patientDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.patientDetailsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtpid
            // 
            this.txtpid.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtpid.Location = new System.Drawing.Point(153, 129);
            this.txtpid.Name = "txtpid";
            this.txtpid.Size = new System.Drawing.Size(100, 29);
            this.txtpid.TabIndex = 43;
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
            this.comboxPname.Location = new System.Drawing.Point(152, 178);
            this.comboxPname.Name = "comboxPname";
            this.comboxPname.Size = new System.Drawing.Size(299, 30);
            this.comboxPname.TabIndex = 28;
            this.comboxPname.SelectedIndexChanged += new System.EventHandler(this.comboxPname_SelectedIndexChanged);
            // 
            // txtrs
            // 
            this.txtrs.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtrs.Location = new System.Drawing.Point(152, 461);
            this.txtrs.Name = "txtrs";
            this.txtrs.Size = new System.Drawing.Size(121, 29);
            this.txtrs.TabIndex = 40;
            this.txtrs.TextChanged += new System.EventHandler(this.txtrs_TextChanged);
            // 
            // btnclear
            // 
            this.btnclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Location = new System.Drawing.Point(279, 513);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(211, 35);
            this.btnclear.TabIndex = 42;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // Button1
            // 
            this.Button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button1.Location = new System.Drawing.Point(26, 513);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(211, 35);
            this.Button1.TabIndex = 41;
            this.Button1.Text = "Save";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // txttid
            // 
            this.txttid.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.txttid.Location = new System.Drawing.Point(154, 79);
            this.txttid.Name = "txttid";
            this.txttid.Size = new System.Drawing.Size(100, 29);
            this.txttid.TabIndex = 27;
            // 
            // txtprescription
            // 
            this.txtprescription.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtprescription.Location = new System.Drawing.Point(152, 272);
            this.txtprescription.Multiline = true;
            this.txtprescription.Name = "txtprescription";
            this.txtprescription.Size = new System.Drawing.Size(370, 108);
            this.txtprescription.TabIndex = 37;
            this.txtprescription.TextChanged += new System.EventHandler(this.txtprescription_TextChanged);
            // 
            // dateTreatment
            // 
            this.dateTreatment.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.dateTreatment.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTreatment.Location = new System.Drawing.Point(152, 400);
            this.dateTreatment.Name = "dateTreatment";
            this.dateTreatment.Size = new System.Drawing.Size(299, 29);
            this.dateTreatment.TabIndex = 39;
            this.dateTreatment.ValueChanged += new System.EventHandler(this.dateTreatment_ValueChanged);
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label8.Location = new System.Drawing.Point(11, 457);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(57, 25);
            this.Label8.TabIndex = 36;
            this.Label8.Text = "RS\\=";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.Location = new System.Drawing.Point(11, 395);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(53, 25);
            this.Label6.TabIndex = 38;
            this.Label6.Text = "Date";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(11, 268);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(124, 25);
            this.Label5.TabIndex = 35;
            this.Label5.Text = "Prescriptions";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(11, 221);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(83, 25);
            this.Label4.TabIndex = 34;
            this.Label4.Text = "Disease";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(11, 125);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(96, 25);
            this.Label3.TabIndex = 31;
            this.Label3.Text = "Patient ID";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(11, 175);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(129, 25);
            this.Label2.TabIndex = 30;
            this.Label2.Text = "Patient Name";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.Location = new System.Drawing.Point(11, 82);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(135, 25);
            this.Label7.TabIndex = 29;
            this.Label7.Text = "Treatments ID";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(181, 9);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(162, 31);
            this.Label1.TabIndex = 32;
            this.Label1.Text = "Treatments";
            // 
            // txtdisease
            // 
            this.txtdisease.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtdisease.Location = new System.Drawing.Point(152, 226);
            this.txtdisease.Name = "txtdisease";
            this.txtdisease.Size = new System.Drawing.Size(191, 29);
            this.txtdisease.TabIndex = 33;
            this.txtdisease.TextChanged += new System.EventHandler(this.txtdisease_TextChanged);
            // 

            // patientDetailsBindingSource
            // 
            this.patientDetailsBindingSource.DataMember = "Patient_Details";

            // Treatments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 559);
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
            this.Name = "Treatments";
            this.Text = "Treatments";
            this.Load += new System.EventHandler(this.Treatments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.patientDetailsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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

    }
}