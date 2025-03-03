namespace SimpleformApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            firstName = new TextBox();
            lastName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            submitBtn = new Button();
            SuspendLayout();
            // 
            // firstName
            // 
            firstName.Location = new Point(161, 96);
            firstName.Name = "firstName";
            firstName.Size = new Size(100, 23);
            firstName.TabIndex = 0;
            firstName.TextChanged += textBox1_TextChanged;
            // 
            // lastName
            // 
            lastName.Location = new Point(161, 209);
            lastName.Name = "lastName";
            lastName.Size = new Size(100, 23);
            lastName.TabIndex = 1;
            lastName.TextChanged += textBox2_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(182, 78);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 2;
            label1.Text = "First Name";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(182, 191);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 3;
            label2.Text = "Last Name";
            label2.Click += label2_Click;
            // 
            // submitBtn
            // 
            submitBtn.Location = new Point(171, 299);
            submitBtn.Name = "submitBtn";
            submitBtn.Size = new Size(75, 23);
            submitBtn.TabIndex = 4;
            submitBtn.Text = "Submit";
            submitBtn.UseVisualStyleBackColor = true;
            submitBtn.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(417, 446);
            Controls.Add(submitBtn);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lastName);
            Controls.Add(firstName);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox firstName;
        private TextBox lastName;
        private Label label1;
        private Label label2;
        private Button submitBtn;
    }
}
