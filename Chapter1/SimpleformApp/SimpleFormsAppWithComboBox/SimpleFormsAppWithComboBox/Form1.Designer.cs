namespace SimpleFormsAppWithComboBox
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
            comboBox = new ComboBox();
            foodCheckedBox = new CheckedListBox();
            foodListBox = new ListBox();
            addBtn = new Button();
            removeBtn = new Button();
            clrBtn = new Button();
            label3 = new Label();
            label4 = new Label();
            selBtn = new Button();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Beige;
            label1.Font = new Font("Showcard Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(355, 33);
            label1.Name = "label1";
            label1.Size = new Size(448, 35);
            label1.TabIndex = 0;
            label1.Text = "MY FAVORITE FOOD PICKER APP";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Beige;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(79, 112);
            label2.Name = "label2";
            label2.Size = new Size(82, 25);
            label2.TabIndex = 1;
            label2.Text = "CUISINE";
            // 
            // comboBox
            // 
            comboBox.BackColor = Color.Beige;
            comboBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBox.FormattingEnabled = true;
            comboBox.Location = new Point(28, 150);
            comboBox.Name = "comboBox";
            comboBox.Size = new Size(183, 28);
            comboBox.TabIndex = 2;
            comboBox.SelectedIndexChanged += comboBox_SelectedIndexChanged;
            // 
            // foodCheckedBox
            // 
            foodCheckedBox.BackColor = Color.Beige;
            foodCheckedBox.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            foodCheckedBox.FormattingEnabled = true;
            foodCheckedBox.Location = new Point(261, 150);
            foodCheckedBox.Name = "foodCheckedBox";
            foodCheckedBox.Size = new Size(297, 212);
            foodCheckedBox.TabIndex = 3;
            // 
            // foodListBox
            // 
            foodListBox.BackColor = Color.Beige;
            foodListBox.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            foodListBox.FormattingEnabled = true;
            foodListBox.ItemHeight = 25;
            foodListBox.Location = new Point(612, 150);
            foodListBox.Name = "foodListBox";
            foodListBox.Size = new Size(284, 279);
            foodListBox.TabIndex = 4;
            // 
            // addBtn
            // 
            addBtn.BackColor = Color.Beige;
            addBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addBtn.Location = new Point(309, 380);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(196, 58);
            addBtn.TabIndex = 5;
            addBtn.Text = "ADD";
            addBtn.UseVisualStyleBackColor = false;
            addBtn.Click += addBtn_Click_1;
            // 
            // removeBtn
            // 
            removeBtn.BackColor = Color.Beige;
            removeBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            removeBtn.Location = new Point(919, 150);
            removeBtn.Name = "removeBtn";
            removeBtn.Size = new Size(160, 52);
            removeBtn.TabIndex = 6;
            removeBtn.Text = "REMOVE";
            removeBtn.UseVisualStyleBackColor = false;
            removeBtn.Click += removeBtn_Click;
            // 
            // clrBtn
            // 
            clrBtn.BackColor = Color.Beige;
            clrBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            clrBtn.Location = new Point(919, 220);
            clrBtn.Name = "clrBtn";
            clrBtn.Size = new Size(160, 52);
            clrBtn.TabIndex = 7;
            clrBtn.Text = "CLEAR ALL";
            clrBtn.UseVisualStyleBackColor = false;
            clrBtn.Click += clrBtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Beige;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(355, 109);
            label3.Name = "label3";
            label3.Size = new Size(112, 28);
            label3.TabIndex = 8;
            label3.Text = "FOOD LIST";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Beige;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(637, 109);
            label4.Name = "label4";
            label4.Size = new Size(247, 28);
            label4.TabIndex = 9;
            label4.Text = "MY FAVORITE FOOD LIST";
            // 
            // selBtn
            // 
            selBtn.BackColor = Color.Beige;
            selBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            selBtn.Location = new Point(46, 197);
            selBtn.Name = "selBtn";
            selBtn.Size = new Size(151, 64);
            selBtn.TabIndex = 10;
            selBtn.Text = "SELECT";
            selBtn.UseVisualStyleBackColor = false;
            selBtn.Click += selBtn_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Beige;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(961, 9);
            label5.Name = "label5";
            label5.Size = new Size(140, 25);
            label5.TabIndex = 11;
            label5.Text = "CC-APPSDEV22";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1111, 450);
            Controls.Add(label5);
            Controls.Add(selBtn);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(clrBtn);
            Controls.Add(removeBtn);
            Controls.Add(addBtn);
            Controls.Add(foodListBox);
            Controls.Add(foodCheckedBox);
            Controls.Add(comboBox);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FOOD FORM APP";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox comboBox;
        private CheckedListBox foodCheckedBox;
        private ListBox foodListBox;
        private Button addBtn;
        private Button removeBtn;
        private Button clrBtn;
        private Label label3;
        private Label label4;
        private Button selBtn;
        private Label label5;
    }
}
