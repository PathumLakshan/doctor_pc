namespace Docter.Views
{
    partial class Update_Patient
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
            this.txtgender = new System.Windows.Forms.TextBox();
            this.Button2 = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtpaddress = new System.Windows.Forms.TextBox();
            this.txtnic = new System.Windows.Forms.TextBox();
            this.txtnumber = new System.Windows.Forms.TextBox();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label9 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtpid = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.patientDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            
            ((System.ComponentModel.ISupportInitialize)(this.patientDetailsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtgender
            // 
            this.txtgender.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtgender.Location = new System.Drawing.Point(222, 284);
            this.txtgender.Name = "txtgender";
            this.txtgender.Size = new System.Drawing.Size(100, 29);
            this.txtgender.TabIndex = 39;
            this.txtgender.TextChanged += new System.EventHandler(this.txtgender_TextChanged);
            // 
            // Button2
            // 
            this.Button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button2.Location = new System.Drawing.Point(318, 453);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(211, 35);
            this.Button2.TabIndex = 43;
            this.Button2.Text = "Clear";
            this.Button2.UseVisualStyleBackColor = true;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(15, 453);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(211, 35);
            this.btnSave.TabIndex = 42;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtpaddress
            // 
            this.txtpaddress.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtpaddress.Location = new System.Drawing.Point(222, 390);
            this.txtpaddress.Name = "txtpaddress";
            this.txtpaddress.Size = new System.Drawing.Size(307, 29);
            this.txtpaddress.TabIndex = 41;
            this.txtpaddress.TextChanged += new System.EventHandler(this.txtpaddress_TextChanged);
            // 
            // txtnic
            // 
            this.txtnic.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtnic.Location = new System.Drawing.Point(222, 333);
            this.txtnic.Name = "txtnic";
            this.txtnic.Size = new System.Drawing.Size(180, 29);
            this.txtnic.TabIndex = 40;
            this.txtnic.TextChanged += new System.EventHandler(this.txtnic_TextChanged);
            // 
            // txtnumber
            // 
            this.txtnumber.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtnumber.Location = new System.Drawing.Point(222, 234);
            this.txtnumber.Name = "txtnumber";
            this.txtnumber.Size = new System.Drawing.Size(156, 29);
            this.txtnumber.TabIndex = 38;
            this.txtnumber.TextChanged += new System.EventHandler(this.txtnumber_TextChanged);
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.Location = new System.Drawing.Point(10, 394);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(150, 25);
            this.Label7.TabIndex = 50;
            this.Label7.Text = "Patient Address";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.Location = new System.Drawing.Point(10, 337);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(185, 25);
            this.Label6.TabIndex = 51;
            this.Label6.Text = "Patient NIC Number";
            // 
            // txtAge
            // 
            this.txtAge.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtAge.Location = new System.Drawing.Point(222, 183);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(100, 29);
            this.txtAge.TabIndex = 37;
            this.txtAge.TextChanged += new System.EventHandler(this.txtAge_TextChanged);
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(7, 238);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(209, 25);
            this.Label3.TabIndex = 48;
            this.Label3.Text = "Patient Mobile Number";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(7, 288);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(142, 25);
            this.Label4.TabIndex = 47;
            this.Label4.Text = "Patient Gender";
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label8.Location = new System.Drawing.Point(148, 9);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(273, 29);
            this.Label8.TabIndex = 46;
            this.Label8.Text = "Update Patient Details";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(7, 187);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(113, 25);
            this.Label2.TabIndex = 45;
            this.Label2.Text = "Patient Age";
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label9.Location = new System.Drawing.Point(7, 78);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(96, 25);
            this.Label9.TabIndex = 49;
            this.Label9.Text = "Patient ID";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(7, 135);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(134, 25);
            this.Label1.TabIndex = 44;
            this.Label1.Text = "Patient Name ";
            // 
            // txtpid
            // 
            this.txtpid.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtpid.Location = new System.Drawing.Point(222, 74);
            this.txtpid.Name = "txtpid";
            this.txtpid.Size = new System.Drawing.Size(100, 29);
            this.txtpid.TabIndex = 52;
            this.txtpid.TextChanged += new System.EventHandler(this.txtpid_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.patientDetailsBindingSource;
            this.comboBox1.DisplayMember = "Patient_Name";
            this.comboBox1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(222, 130);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(307, 30);
            this.comboBox1.TabIndex = 53;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // patientDetailsBindingSource
            // 
            this.patientDetailsBindingSource.DataMember = "Patient_Details";
           // 
            
            // Update_Patient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 505);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txtgender);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtpaddress);
            this.Controls.Add(this.txtnic);
            this.Controls.Add(this.txtnumber);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.txtpid);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label8);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label9);
            this.Controls.Add(this.Label1);
            this.Name = "Update_Patient";
            this.Text = "Update_Patient";
            this.Load += new System.EventHandler(this.Update_Patient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.patientDetailsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox txtgender;
        internal System.Windows.Forms.Button Button2;
        internal System.Windows.Forms.Button btnSave;
        internal System.Windows.Forms.TextBox txtpaddress;
        internal System.Windows.Forms.TextBox txtnic;
        internal System.Windows.Forms.TextBox txtnumber;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.TextBox txtAge;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox txtpid;
        private System.Windows.Forms.ComboBox comboBox1;
       
        private System.Windows.Forms.BindingSource patientDetailsBindingSource;
       
    }
}