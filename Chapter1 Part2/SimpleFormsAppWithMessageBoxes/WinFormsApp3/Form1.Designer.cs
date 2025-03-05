namespace WinFormsApp3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            firstName = new TextBox();
            middleName = new TextBox();
            lastName = new TextBox();
            suffix = new TextBox();
            submitBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(112, 28);
            label1.Name = "label1";
            label1.Size = new Size(161, 17);
            label1.TabIndex = 0;
            label1.Text = "Simple Form Application";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(47, 73);
            label2.Name = "label2";
            label2.Size = new Size(74, 17);
            label2.TabIndex = 1;
            label2.Text = "First Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(47, 143);
            label3.Name = "label3";
            label3.Size = new Size(89, 17);
            label3.TabIndex = 2;
            label3.Text = "Middle Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(47, 214);
            label4.Name = "label4";
            label4.Size = new Size(72, 17);
            label4.TabIndex = 3;
            label4.Text = "Last Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(47, 290);
            label5.Name = "label5";
            label5.Size = new Size(41, 17);
            label5.TabIndex = 4;
            label5.Text = "Suffix";
            // 
            // firstName
            // 
            firstName.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            firstName.Location = new Point(47, 102);
            firstName.Name = "firstName";
            firstName.Size = new Size(258, 25);
            firstName.TabIndex = 5;
            // 
            // middleName
            // 
            middleName.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            middleName.Location = new Point(47, 171);
            middleName.Name = "middleName";
            middleName.Size = new Size(258, 25);
            middleName.TabIndex = 6;
            // 
            // lastName
            // 
            lastName.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lastName.Location = new Point(47, 243);
            lastName.Name = "lastName";
            lastName.Size = new Size(258, 25);
            lastName.TabIndex = 7;
            // 
            // suffix
            // 
            suffix.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            suffix.Location = new Point(47, 318);
            suffix.Name = "suffix";
            suffix.Size = new Size(258, 25);
            suffix.TabIndex = 8;
            // 
            // submitBtn
            // 
            submitBtn.BackColor = Color.Transparent;
            submitBtn.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            submitBtn.Location = new Point(82, 377);
            submitBtn.Name = "submitBtn";
            submitBtn.Size = new Size(201, 38);
            submitBtn.TabIndex = 9;
            submitBtn.Text = "Submit";
            submitBtn.UseVisualStyleBackColor = false;
            submitBtn.Click += submitBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Purple;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(364, 483);
            Controls.Add(submitBtn);
            Controls.Add(suffix);
            Controls.Add(lastName);
            Controls.Add(middleName);
            Controls.Add(firstName);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            ShowInTaskbar = false;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox firstName;
        private TextBox middleName;
        private TextBox lastName;
        private TextBox suffix;
        private Button submitBtn;
    }
}
