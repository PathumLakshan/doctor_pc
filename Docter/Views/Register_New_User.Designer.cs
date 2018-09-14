namespace Docter.Views
{
    partial class Register_New_User
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
            this.Button2 = new System.Windows.Forms.Button();
            this.Button1 = new System.Windows.Forms.Button();
            this.Label4 = new System.Windows.Forms.Label();
            this.txtlname = new System.Windows.Forms.TextBox();
            this.txtpword = new System.Windows.Forms.TextBox();
            this.txtuid = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Button2
            // 
            this.Button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button2.Location = new System.Drawing.Point(206, 330);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(136, 35);
            this.Button2.TabIndex = 31;
            this.Button2.Text = "Clear";
            this.Button2.UseVisualStyleBackColor = true;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Button1
            // 
            this.Button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button1.Location = new System.Drawing.Point(10, 330);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(136, 35);
            this.Button1.TabIndex = 30;
            this.Button1.Text = "Save";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(61, 9);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(238, 31);
            this.Label4.TabIndex = 28;
            this.Label4.Text = "Create New User";
            // 
            // txtlname
            // 
            this.txtlname.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtlname.Location = new System.Drawing.Point(189, 154);
            this.txtlname.Name = "txtlname";
            this.txtlname.Size = new System.Drawing.Size(131, 29);
            this.txtlname.TabIndex = 27;
            this.txtlname.TextChanged += new System.EventHandler(this.txtlname_TextChanged);
            // 
            // txtpword
            // 
            this.txtpword.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtpword.Location = new System.Drawing.Point(189, 213);
            this.txtpword.Name = "txtpword";
            this.txtpword.PasswordChar = '*';
            this.txtpword.Size = new System.Drawing.Size(131, 29);
            this.txtpword.TabIndex = 29;
            this.txtpword.TextChanged += new System.EventHandler(this.txtpword_TextChanged);
            // 
            // txtuid
            // 
            this.txtuid.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtuid.Location = new System.Drawing.Point(189, 93);
            this.txtuid.Name = "txtuid";
            this.txtuid.Size = new System.Drawing.Size(100, 29);
            this.txtuid.TabIndex = 23;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(23, 213);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(98, 25);
            this.Label3.TabIndex = 26;
            this.Label3.Text = "Password";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(23, 93);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(77, 25);
            this.Label5.TabIndex = 21;
            this.Label5.Text = "User ID";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(23, 154);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(117, 25);
            this.Label2.TabIndex = 24;
            this.Label2.Text = "Login Name";
            // 
            // Register_New_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 381);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.txtlname);
            this.Controls.Add(this.txtpword);
            this.Controls.Add(this.txtuid);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label2);
            this.Name = "Register_New_User";
            this.Text = "Register_New_User";
            this.Load += new System.EventHandler(this.Register_New_User_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button Button2;
        internal System.Windows.Forms.Button Button1;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.TextBox txtlname;
        internal System.Windows.Forms.TextBox txtpword;
        internal System.Windows.Forms.TextBox txtuid;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label2;
    }
}