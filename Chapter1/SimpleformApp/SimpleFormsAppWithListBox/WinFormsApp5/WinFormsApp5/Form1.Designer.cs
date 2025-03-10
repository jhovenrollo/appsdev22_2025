namespace WinFormsApp5
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
            listBox = new ListBox();
            textBox = new TextBox();
            addBtn = new Button();
            delBtn = new Button();
            clrBtn = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // listBox
            // 
            listBox.BackColor = SystemColors.WindowText;
            listBox.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            listBox.ForeColor = SystemColors.Window;
            listBox.FormattingEnabled = true;
            listBox.ItemHeight = 21;
            listBox.Location = new Point(48, 120);
            listBox.Name = "listBox";
            listBox.Size = new Size(188, 256);
            listBox.TabIndex = 0;
            // 
            // textBox
            // 
            textBox.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox.Location = new Point(253, 123);
            textBox.Name = "textBox";
            textBox.Size = new Size(151, 35);
            textBox.TabIndex = 1;
            // 
            // addBtn
            // 
            addBtn.Location = new Point(253, 217);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(151, 45);
            addBtn.TabIndex = 2;
            addBtn.Text = "Add";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += addBtn_Click;
            // 
            // delBtn
            // 
            delBtn.Location = new Point(253, 278);
            delBtn.Name = "delBtn";
            delBtn.Size = new Size(151, 42);
            delBtn.TabIndex = 3;
            delBtn.Text = "Delete";
            delBtn.UseVisualStyleBackColor = true;
            delBtn.Click += delBtn_Click;
            // 
            // clrBtn
            // 
            clrBtn.Location = new Point(253, 336);
            clrBtn.Name = "clrBtn";
            clrBtn.Size = new Size(151, 43);
            clrBtn.TabIndex = 4;
            clrBtn.Text = "Clear";
            clrBtn.UseVisualStyleBackColor = true;
            clrBtn.Click += clrBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(255, 255, 128);
            label1.Location = new Point(108, 29);
            label1.Name = "label1";
            label1.Size = new Size(240, 30);
            label1.TabIndex = 5;
            label1.Text = "SIMPLE NAME VIEWER";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(255, 255, 128);
            label2.Location = new Point(151, 416);
            label2.Name = "label2";
            label2.Size = new Size(163, 30);
            label2.TabIndex = 6;
            label2.Text = "CC-APPSDEV22";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkBlue;
            ClientSize = new Size(458, 507);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(clrBtn);
            Controls.Add(delBtn);
            Controls.Add(addBtn);
            Controls.Add(textBox);
            Controls.Add(listBox);
            ForeColor = SystemColors.ControlText;
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox;
        private TextBox textBox;
        private Button addBtn;
        private Button delBtn;
        private Button clrBtn;
        private Label label1;
        private Label label2;
    }
}
