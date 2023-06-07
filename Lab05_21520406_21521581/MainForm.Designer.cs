namespace Lab05_21520406_21521581
{
    partial class MainForm
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
            this.btBai1 = new System.Windows.Forms.Button();
            this.btBai2_3 = new System.Windows.Forms.Button();
            this.btBai4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btBai1
            // 
            this.btBai1.Location = new System.Drawing.Point(62, 76);
            this.btBai1.Name = "btBai1";
            this.btBai1.Size = new System.Drawing.Size(75, 40);
            this.btBai1.TabIndex = 0;
            this.btBai1.Text = "Bài 1";
            this.btBai1.UseVisualStyleBackColor = true;
            this.btBai1.Click += new System.EventHandler(this.btBai1_Click);
            // 
            // btBai2_3
            // 
            this.btBai2_3.Location = new System.Drawing.Point(184, 76);
            this.btBai2_3.Name = "btBai2_3";
            this.btBai2_3.Size = new System.Drawing.Size(75, 40);
            this.btBai2_3.TabIndex = 1;
            this.btBai2_3.Text = "Bài 2 + 3";
            this.btBai2_3.UseVisualStyleBackColor = true;
            this.btBai2_3.Click += new System.EventHandler(this.btBai2_3_Click);
            // 
            // btBai4
            // 
            this.btBai4.Location = new System.Drawing.Point(305, 76);
            this.btBai4.Name = "btBai4";
            this.btBai4.Size = new System.Drawing.Size(75, 40);
            this.btBai4.TabIndex = 3;
            this.btBai4.Text = "Bài 4";
            this.btBai4.UseVisualStyleBackColor = true;
            this.btBai4.Click += new System.EventHandler(this.btBai4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(166, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Form điều hướng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Bài 1: Gửi mail";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(245, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Bài 2 + 3: Đọc mail bằng IMAP (POP3)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 265);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Bài 4: Ứng dụng Email Client";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 293);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btBai4);
            this.Controls.Add(this.btBai2_3);
            this.Controls.Add(this.btBai1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btBai1;
        private Button btBai2_3;
        private Button btBai4;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}