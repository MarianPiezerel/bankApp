
namespace BankApp
{
    partial class HomePage
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
            this.SendMoneyButton = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.receiverIbanTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.balanceLabel = new System.Windows.Forms.Label();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SendMoneyButton
            // 
            this.SendMoneyButton.Location = new System.Drawing.Point(61, 302);
            this.SendMoneyButton.Name = "SendMoneyButton";
            this.SendMoneyButton.Size = new System.Drawing.Size(75, 23);
            this.SendMoneyButton.TabIndex = 1;
            this.SendMoneyButton.Text = "Send Money";
            this.SendMoneyButton.UseVisualStyleBackColor = true;
            this.SendMoneyButton.Click += new System.EventHandler(this.SendMoneyButton_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "test",
            "test1",
            "test2"});
            this.listBox1.Location = new System.Drawing.Point(491, 34);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 2;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // amountTextBox
            // 
            this.amountTextBox.Location = new System.Drawing.Point(61, 250);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(100, 20);
            this.amountTextBox.TabIndex = 3;
            this.amountTextBox.TextChanged += new System.EventHandler(this.amountTextBox_TextChanged);
            // 
            // receiverIbanTextBox
            // 
            this.receiverIbanTextBox.Location = new System.Drawing.Point(61, 276);
            this.receiverIbanTextBox.Name = "receiverIbanTextBox";
            this.receiverIbanTextBox.Size = new System.Drawing.Size(100, 20);
            this.receiverIbanTextBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 253);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Amount";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 279);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Iban";
            // 
            // balanceLabel
            // 
            this.balanceLabel.AutoSize = true;
            this.balanceLabel.Location = new System.Drawing.Point(20, 34);
            this.balanceLabel.Name = "balanceLabel";
            this.balanceLabel.Size = new System.Drawing.Size(35, 13);
            this.balanceLabel.TabIndex = 6;
            this.balanceLabel.Text = "label3";
            this.balanceLabel.Click += new System.EventHandler(this.balanceLabel_Click);
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Location = new System.Drawing.Point(20, 9);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(52, 13);
            this.welcomeLabel.TabIndex = 5;
            this.welcomeLabel.Text = "Welcome";
            this.welcomeLabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.balanceLabel);
            this.Controls.Add(this.welcomeLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.receiverIbanTextBox);
            this.Controls.Add(this.amountTextBox);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.SendMoneyButton);
            this.Name = "HomePage";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button SendMoneyButton;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox amountTextBox;
        private System.Windows.Forms.TextBox receiverIbanTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label balanceLabel;
        private System.Windows.Forms.Label welcomeLabel;
    }
}