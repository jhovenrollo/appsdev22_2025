namespace WinFormsApp2
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
            moviecheckedList = new CheckedListBox();
            movieBoxList = new ListBox();
            addBtn = new Button();
            rmvBtn = new Button();
            clrBtn = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // moviecheckedList
            // 
            moviecheckedList.BackColor = SystemColors.ActiveBorder;
            moviecheckedList.BorderStyle = BorderStyle.FixedSingle;
            moviecheckedList.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            moviecheckedList.FormattingEnabled = true;
            moviecheckedList.Location = new Point(20, 119);
            moviecheckedList.Name = "moviecheckedList";
            moviecheckedList.Size = new Size(206, 227);
            moviecheckedList.TabIndex = 0;
            // 
            // movieBoxList
            // 
            movieBoxList.BackColor = SystemColors.ActiveBorder;
            movieBoxList.BorderStyle = BorderStyle.FixedSingle;
            movieBoxList.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            movieBoxList.FormattingEnabled = true;
            movieBoxList.ItemHeight = 25;
            movieBoxList.Location = new Point(273, 119);
            movieBoxList.Name = "movieBoxList";
            movieBoxList.Size = new Size(322, 227);
            movieBoxList.TabIndex = 1;
            // 
            // addBtn
            // 
            addBtn.BackColor = SystemColors.ActiveBorder;
            addBtn.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addBtn.ForeColor = SystemColors.ActiveCaptionText;
            addBtn.Location = new Point(20, 360);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(194, 46);
            addBtn.TabIndex = 2;
            addBtn.Text = "ADD";
            addBtn.UseVisualStyleBackColor = false;
            addBtn.Click += addBtn_Click;
            // 
            // rmvBtn
            // 
            rmvBtn.BackColor = SystemColors.ActiveBorder;
            rmvBtn.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rmvBtn.Location = new Point(611, 119);
            rmvBtn.Name = "rmvBtn";
            rmvBtn.Size = new Size(194, 46);
            rmvBtn.TabIndex = 3;
            rmvBtn.Text = "REMOVE";
            rmvBtn.UseVisualStyleBackColor = false;
            rmvBtn.Click += rmvBtn_Click;
            // 
            // clrBtn
            // 
            clrBtn.BackColor = SystemColors.ActiveBorder;
            clrBtn.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            clrBtn.Location = new Point(611, 183);
            clrBtn.Name = "clrBtn";
            clrBtn.Size = new Size(194, 46);
            clrBtn.TabIndex = 4;
            clrBtn.Text = "CLEAR ALL";
            clrBtn.UseVisualStyleBackColor = false;
            clrBtn.Click += clrBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlDark;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(20, 24);
            label1.Name = "label1";
            label1.Size = new Size(368, 28);
            label1.TabIndex = 5;
            label1.Text = "SIMPLE FAVORITE MOVIE PICKER APP\r\n";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveBorder;
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Font = new Font("Showcard Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(61, 82);
            label2.Name = "label2";
            label2.Size = new Size(111, 23);
            label2.TabIndex = 6;
            label2.Text = "Movies List";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ActiveBorder;
            label3.BorderStyle = BorderStyle.Fixed3D;
            label3.Font = new Font("Showcard Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(347, 82);
            label3.Name = "label3";
            label3.Size = new Size(186, 23);
            label3.TabIndex = 7;
            label3.Text = "MY FAVORITE MOVIES";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(823, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(clrBtn);
            Controls.Add(rmvBtn);
            Controls.Add(addBtn);
            Controls.Add(movieBoxList);
            Controls.Add(moviecheckedList);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MOVIE FORM APP";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckedListBox moviecheckedList;
        private ListBox movieBoxList;
        private Button addBtn;
        private Button rmvBtn;
        private Button clrBtn;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
