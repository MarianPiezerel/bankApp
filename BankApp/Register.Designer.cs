
namespace BankApp
{
    partial class Register
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
            this.button2 = new System.Windows.Forms.Button();
            this.lastName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.firstName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.personalNumericCode = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.radioButtonDa = new System.Windows.Forms.RadioButton();
            this.radioButtonDan = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.generateIban = new System.Windows.Forms.Button();
            this.ibanTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.emailAddressTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(138, 218);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Register";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lastName
            // 
            this.lastName.Location = new System.Drawing.Point(113, 109);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(100, 20);
            this.lastName.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Register";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Last Name";
            // 
            // firstName
            // 
            this.firstName.Location = new System.Drawing.Point(113, 83);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(100, 20);
            this.firstName.TabIndex = 7;
            this.firstName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "First Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "CNP";
            // 
            // personalNumericCode
            // 
            this.personalNumericCode.Location = new System.Drawing.Point(113, 135);
            this.personalNumericCode.Name = "personalNumericCode";
            this.personalNumericCode.Size = new System.Drawing.Size(100, 20);
            this.personalNumericCode.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Sex";
            // 
            // radioButtonDa
            // 
            this.radioButtonDa.AutoSize = true;
            this.radioButtonDa.Location = new System.Drawing.Point(113, 195);
            this.radioButtonDa.Name = "radioButtonDa";
            this.radioButtonDa.Size = new System.Drawing.Size(39, 17);
            this.radioButtonDa.TabIndex = 13;
            this.radioButtonDa.TabStop = true;
            this.radioButtonDa.Text = "Da";
            this.radioButtonDa.UseVisualStyleBackColor = true;
            this.radioButtonDa.CheckedChanged += new System.EventHandler(this.radioButtonDa_CheckedChanged);
            // 
            // radioButtonDan
            // 
            this.radioButtonDan.AutoSize = true;
            this.radioButtonDan.Location = new System.Drawing.Point(168, 195);
            this.radioButtonDan.Name = "radioButtonDan";
            this.radioButtonDan.Size = new System.Drawing.Size(45, 17);
            this.radioButtonDan.TabIndex = 14;
            this.radioButtonDan.TabStop = true;
            this.radioButtonDan.Text = "Dan";
            this.radioButtonDan.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(115, 256);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Back to login";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // generateIban
            // 
            this.generateIban.Location = new System.Drawing.Point(218, 56);
            this.generateIban.Name = "generateIban";
            this.generateIban.Size = new System.Drawing.Size(84, 23);
            this.generateIban.TabIndex = 16;
            this.generateIban.Text = "Generate Iban";
            this.generateIban.UseVisualStyleBackColor = true;
            this.generateIban.Click += new System.EventHandler(this.generateIban_Click);
            // 
            // ibanTextBox
            // 
            this.ibanTextBox.Location = new System.Drawing.Point(55, 57);
            this.ibanTextBox.Name = "ibanTextBox";
            this.ibanTextBox.Size = new System.Drawing.Size(157, 20);
            this.ibanTextBox.TabIndex = 17;
            this.ibanTextBox.TextChanged += new System.EventHandler(this.ibanTextBox_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(52, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Email";
            // 
            // emailAddressTextBox
            // 
            this.emailAddressTextBox.Location = new System.Drawing.Point(112, 166);
            this.emailAddressTextBox.Name = "emailAddressTextBox";
            this.emailAddressTextBox.Size = new System.Drawing.Size(100, 20);
            this.emailAddressTextBox.TabIndex = 10;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 328);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ibanTextBox);
            this.Controls.Add(this.generateIban);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.radioButtonDan);
            this.Controls.Add(this.radioButtonDa);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.emailAddressTextBox);
            this.Controls.Add(this.personalNumericCode);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.firstName);
            this.Controls.Add(this.label1);
            this.Name = "Register";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Register_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox lastName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox firstName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox personalNumericCode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton radioButtonDa;
        private System.Windows.Forms.RadioButton radioButtonDan;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button generateIban;
        private System.Windows.Forms.TextBox ibanTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox emailAddressTextBox;
    }
}