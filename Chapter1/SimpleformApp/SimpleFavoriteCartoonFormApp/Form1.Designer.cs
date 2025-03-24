namespace SimpleFavoriteCartoonFormApp
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
            comboBox = new ComboBox();
            pictureBox = new PictureBox();
            viewBtn = new Button();
            clrBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.PaleGreen;
            label1.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 23);
            label1.Name = "label1";
            label1.Size = new Size(475, 26);
            label1.TabIndex = 0;
            label1.Text = "SIMPLE FAVORITE CARTOON CHARACTER PICKER";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.PaleGreen;
            label2.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(73, 87);
            label2.Name = "label2";
            label2.Size = new Size(126, 18);
            label2.TabIndex = 1;
            label2.Text = "SELECT AN ITEM:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.PaleGreen;
            label3.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(515, 87);
            label3.Name = "label3";
            label3.Size = new Size(59, 18);
            label3.TabIndex = 2;
            label3.Text = "IMAGE:";
            // 
            // comboBox
            // 
            comboBox.BackColor = SystemColors.Window;
            comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBox.FormattingEnabled = true;
            comboBox.Location = new Point(37, 125);
            comboBox.Name = "comboBox";
            comboBox.Size = new Size(197, 28);
            comboBox.TabIndex = 3;
            comboBox.SelectedIndexChanged += comboBox_SelectedIndexChanged;
            // 
            // pictureBox
            // 
            pictureBox.BackColor = Color.Transparent;
            pictureBox.BorderStyle = BorderStyle.Fixed3D;
            pictureBox.Location = new Point(373, 125);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(326, 282);
            pictureBox.TabIndex = 4;
            pictureBox.TabStop = false;
            pictureBox.Click += pictureBox_Click;
            // 
            // viewBtn
            // 
            viewBtn.BackColor = Color.PaleGreen;
            viewBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            viewBtn.Location = new Point(48, 179);
            viewBtn.Name = "viewBtn";
            viewBtn.Size = new Size(168, 40);
            viewBtn.TabIndex = 5;
            viewBtn.Text = "VIEW";
            viewBtn.UseVisualStyleBackColor = false;
            viewBtn.Click += viewBtn_Click;
            // 
            // clrBtn
            // 
            clrBtn.BackColor = Color.PaleGreen;
            clrBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            clrBtn.Location = new Point(48, 234);
            clrBtn.Name = "clrBtn";
            clrBtn.Size = new Size(168, 40);
            clrBtn.TabIndex = 6;
            clrBtn.Text = "CLEAR";
            clrBtn.UseVisualStyleBackColor = false;
            clrBtn.Click += clrBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Blue;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(clrBtn);
            Controls.Add(viewBtn);
            Controls.Add(pictureBox);
            Controls.Add(comboBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "FAVORITE CARTOON FORM APP";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox comboBox;
        private PictureBox pictureBox;
        private Button viewBtn;
        private Button clrBtn;
    }
}
