namespace CVParserApp
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnSaveManual = new System.Windows.Forms.Button();
            this.lblManualResult = new System.Windows.Forms.Label();
            this.btnValidate = new System.Windows.Forms.Button();
            this.txtPostalCode = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnSaveCV = new System.Windows.Forms.Button();
            this.lblCVResult = new System.Windows.Forms.Label();
            this.btnParse = new System.Windows.Forms.Button();
            this.txtCVContent = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(584, 461);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnSaveManual);
            this.tabPage1.Controls.Add(this.lblManualResult);
            this.tabPage1.Controls.Add(this.btnValidate);
            this.tabPage1.Controls.Add(this.txtPostalCode);
            this.tabPage1.Controls.Add(this.txtAddress);
            this.tabPage1.Controls.Add(this.txtPassword);
            this.tabPage1.Controls.Add(this.txtPhone);
            this.tabPage1.Controls.Add(this.txtEmail);
            this.tabPage1.Controls.Add(this.txtName);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(576, 435);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Manual Form Entry";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnSaveManual
            // 
            this.btnSaveManual.Enabled = false;
            this.btnSaveManual.Location = new System.Drawing.Point(395, 400);
            this.btnSaveManual.Name = "btnSaveManual";
            this.btnSaveManual.Size = new System.Drawing.Size(175, 23);
            this.btnSaveManual.TabIndex = 14;
            this.btnSaveManual.Text = "Save Validated Data";
            this.btnSaveManual.UseVisualStyleBackColor = true;
            this.btnSaveManual.Click += new System.EventHandler(this.btnSaveManual_Click);
            // 
            // lblManualResult
            // 
            this.lblManualResult.AutoSize = true;
            this.lblManualResult.Location = new System.Drawing.Point(8, 280);
            this.lblManualResult.MaximumSize = new System.Drawing.Size(560, 0);
            this.lblManualResult.Name = "lblManualResult";
            this.lblManualResult.Size = new System.Drawing.Size(0, 13);
            this.lblManualResult.TabIndex = 13;
            // 
            // btnValidate
            // 
            this.btnValidate.Location = new System.Drawing.Point(395, 240);
            this.btnValidate.Name = "btnValidate";
            this.btnValidate.Size = new System.Drawing.Size(175, 23);
            this.btnValidate.TabIndex = 12;
            this.btnValidate.Text = "Validate";
            this.btnValidate.UseVisualStyleBackColor = true;
            this.btnValidate.Click += new System.EventHandler(this.btnValidate_Click);
            // 
            // txtPostalCode
            // 
            this.txtPostalCode.Location = new System.Drawing.Point(120, 240);
            this.txtPostalCode.Name = "txtPostalCode";
            this.txtPostalCode.Size = new System.Drawing.Size(250, 20);
            this.txtPostalCode.TabIndex = 11;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(120, 200);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(250, 20);
            this.txtAddress.TabIndex = 10;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(120, 160);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(250, 20);
            this.txtPassword.TabIndex = 9;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(120, 120);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(250, 20);
            this.txtPhone.TabIndex = 8;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(120, 80);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(250, 20);
            this.txtEmail.TabIndex = 7;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(120, 40);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(250, 20);
            this.txtName.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 243);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Postal Code:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Address:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Phone:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Email:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnSaveCV);
            this.tabPage2.Controls.Add(this.lblCVResult);
            this.tabPage2.Controls.Add(this.btnParse);
            this.tabPage2.Controls.Add(this.txtCVContent);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(576, 435);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "CV Text Parsing";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnSaveCV
            // 
            this.btnSaveCV.Enabled = false;
            this.btnSaveCV.Location = new System.Drawing.Point(395, 400);
            this.btnSaveCV.Name = "btnSaveCV";
            this.btnSaveCV.Size = new System.Drawing.Size(175, 23);
            this.btnSaveCV.TabIndex = 4;
            this.btnSaveCV.Text = "Save Parsed Data";
            this.btnSaveCV.UseVisualStyleBackColor = true;
            this.btnSaveCV.Click += new System.EventHandler(this.btnSaveCV_Click);
            // 
            // lblCVResult
            // 
            this.lblCVResult.AutoSize = true;
            this.lblCVResult.Location = new System.Drawing.Point(8, 200);
            this.lblCVResult.MaximumSize = new System.Drawing.Size(560, 0);
            this.lblCVResult.Name = "lblCVResult";
            this.lblCVResult.Size = new System.Drawing.Size(0, 13);
            this.lblCVResult.TabIndex = 3;
            // 
            // btnParse
            // 
            this.btnParse.Location = new System.Drawing.Point(395, 160);
            this.btnParse.Name = "btnParse";
            this.btnParse.Size = new System.Drawing.Size(175, 23);
            this.btnParse.TabIndex = 2;
            this.btnParse.Text = "Parse CV";
            this.btnParse.UseVisualStyleBackColor = true;
            this.btnParse.Click += new System.EventHandler(this.btnParse_Click);
            // 
            // txtCVContent
            // 
            this.txtCVContent.Location = new System.Drawing.Point(8, 40);
            this.txtCVContent.Multiline = true;
            this.txtCVContent.Name = "txtCVContent";
            this.txtCVContent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCVContent.Size = new System.Drawing.Size(560, 100);
            this.txtCVContent.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(149, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Paste or type your CV content:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "CV Parser and Form Validator";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPostalCode;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnValidate;
        private System.Windows.Forms.Label lblManualResult;
        private System.Windows.Forms.TextBox txtCVContent;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnParse;
        private System.Windows.Forms.Label lblCVResult;
        private System.Windows.Forms.Button btnSaveManual;
        private System.Windows.Forms.Button btnSaveCV;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}