namespace Lab05_21520406_21521581
{
    partial class Lab05_Bai1
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
            this.tbPath = new System.Windows.Forms.TextBox();
            this.btSelect = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btSend = new System.Windows.Forms.Button();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbFrom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rtbBody = new System.Windows.Forms.RichTextBox();
            this.tbSub = new System.Windows.Forms.TextBox();
            this.tbTo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbPath
            // 
            this.tbPath.Location = new System.Drawing.Point(97, 477);
            this.tbPath.Name = "tbPath";
            this.tbPath.Size = new System.Drawing.Size(499, 23);
            this.tbPath.TabIndex = 49;
            // 
            // btSelect
            // 
            this.btSelect.Location = new System.Drawing.Point(602, 477);
            this.btSelect.Name = "btSelect";
            this.btSelect.Size = new System.Drawing.Size(73, 23);
            this.btSelect.TabIndex = 48;
            this.btSelect.Text = "Select";
            this.btSelect.UseVisualStyleBackColor = true;
            this.btSelect.Click += new System.EventHandler(this.btSelect_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 481);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 15);
            this.label6.TabIndex = 47;
            this.label6.Text = "Attachment";
            // 
            // btSend
            // 
            this.btSend.Location = new System.Drawing.Point(521, 38);
            this.btSend.Name = "btSend";
            this.btSend.Size = new System.Drawing.Size(75, 62);
            this.btSend.TabIndex = 46;
            this.btSend.Text = "Send";
            this.btSend.UseVisualStyleBackColor = true;
            this.btSend.Click += new System.EventHandler(this.btSend_Click);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(97, 103);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(389, 23);
            this.tbName.TabIndex = 45;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 15);
            this.label5.TabIndex = 44;
            this.label5.Text = "Name:";
            // 
            // tbFrom
            // 
            this.tbFrom.Location = new System.Drawing.Point(97, 24);
            this.tbFrom.Name = "tbFrom";
            this.tbFrom.Size = new System.Drawing.Size(388, 23);
            this.tbFrom.TabIndex = 43;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 42;
            this.label1.Text = "From:";
            // 
            // rtbBody
            // 
            this.rtbBody.Location = new System.Drawing.Point(97, 194);
            this.rtbBody.Name = "rtbBody";
            this.rtbBody.Size = new System.Drawing.Size(500, 277);
            this.rtbBody.TabIndex = 41;
            this.rtbBody.Text = "";
            // 
            // tbSub
            // 
            this.tbSub.Location = new System.Drawing.Point(97, 144);
            this.tbSub.Name = "tbSub";
            this.tbSub.Size = new System.Drawing.Size(500, 23);
            this.tbSub.TabIndex = 40;
            // 
            // tbTo
            // 
            this.tbTo.Location = new System.Drawing.Point(97, 64);
            this.tbTo.Name = "tbTo";
            this.tbTo.Size = new System.Drawing.Size(389, 23);
            this.tbTo.TabIndex = 39;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 38;
            this.label4.Text = "Body:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 15);
            this.label3.TabIndex = 37;
            this.label3.Text = "Subject:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 15);
            this.label2.TabIndex = 36;
            this.label2.Text = "To:";
            // 
            // Lab05_Bai1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 514);
            this.Controls.Add(this.tbPath);
            this.Controls.Add(this.btSelect);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btSend);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbFrom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtbBody);
            this.Controls.Add(this.tbSub);
            this.Controls.Add(this.tbTo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Lab05_Bai1";
            this.Text = "Bài 1_ Gửi mail";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tbPath;
        private Button btSelect;
        private Label label6;
        private Button btSend;
        private TextBox tbName;
        private Label label5;
        private TextBox tbFrom;
        private Label label1;
        private RichTextBox rtbBody;
        private TextBox tbSub;
        private TextBox tbTo;
        private Label label4;
        private Label label3;
        private Label label2;
    }
}