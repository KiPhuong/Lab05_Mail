namespace Lab05_21520406_21521581
{
    partial class Lab05_Bai2_3
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbOwn = new System.Windows.Forms.TextBox();
            this.lvBox = new System.Windows.Forms.ListView();
            this.colNum = new System.Windows.Forms.ColumnHeader();
            this.colFrom = new System.Windows.Forms.ColumnHeader();
            this.colSub = new System.Windows.Forms.ColumnHeader();
            this.colDate = new System.Windows.Forms.ColumnHeader();
            this.btRef = new System.Windows.Forms.Button();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.btBack = new System.Windows.Forms.Button();
            this.btNext = new System.Windows.Forms.Button();
            this.tbPage = new System.Windows.Forms.TextBox();
            this.lbpage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Owner: ";
            // 
            // tbOwn
            // 
            this.tbOwn.Location = new System.Drawing.Point(67, 22);
            this.tbOwn.Name = "tbOwn";
            this.tbOwn.Size = new System.Drawing.Size(317, 23);
            this.tbOwn.TabIndex = 8;
            // 
            // lvBox
            // 
            this.lvBox.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colNum,
            this.colFrom,
            this.colSub,
            this.colDate});
            this.lvBox.FullRowSelect = true;
            this.lvBox.Location = new System.Drawing.Point(12, 71);
            this.lvBox.Name = "lvBox";
            this.lvBox.Size = new System.Drawing.Size(769, 367);
            this.lvBox.TabIndex = 10;
            this.lvBox.UseCompatibleStateImageBehavior = false;
            this.lvBox.View = System.Windows.Forms.View.Details;
            this.lvBox.SelectedIndexChanged += new System.EventHandler(this.lvBox_SelectedIndexChanged);
            // 
            // colNum
            // 
            this.colNum.Text = "#";
            this.colNum.Width = 25;
            // 
            // colFrom
            // 
            this.colFrom.Text = "From";
            this.colFrom.Width = 250;
            // 
            // colSub
            // 
            this.colSub.Text = "Subject";
            this.colSub.Width = 350;
            // 
            // colDate
            // 
            this.colDate.Text = "Date";
            this.colDate.Width = 140;
            // 
            // btRef
            // 
            this.btRef.Location = new System.Drawing.Point(706, 12);
            this.btRef.Name = "btRef";
            this.btRef.Size = new System.Drawing.Size(75, 40);
            this.btRef.TabIndex = 11;
            this.btRef.Text = "Refresh";
            this.btRef.UseVisualStyleBackColor = true;
            this.btRef.Click += new System.EventHandler(this.btRef_Click);
            // 
            // cbType
            // 
            this.cbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbType.FormattingEnabled = true;
            this.cbType.Items.AddRange(new object[] {
            "IMAP",
            "POP3"});
            this.cbType.Location = new System.Drawing.Point(478, 22);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(89, 23);
            this.cbType.TabIndex = 12;
            this.cbType.SelectedValueChanged += new System.EventHandler(this.cbType_SelectedValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(410, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "Chọn host";
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Location = new System.Drawing.Point(493, 454);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(38, 15);
            this.lbTotal.TabIndex = 14;
            this.lbTotal.Text = "Total: ";
            // 
            // btBack
            // 
            this.btBack.Location = new System.Drawing.Point(590, 451);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(50, 23);
            this.btBack.TabIndex = 15;
            this.btBack.Text = "Back";
            this.btBack.UseVisualStyleBackColor = true;
            this.btBack.Click += new System.EventHandler(this.btBack_Click);
            // 
            // btNext
            // 
            this.btNext.Location = new System.Drawing.Point(706, 451);
            this.btNext.Name = "btNext";
            this.btNext.Size = new System.Drawing.Size(50, 23);
            this.btNext.TabIndex = 16;
            this.btNext.Text = "Next";
            this.btNext.UseVisualStyleBackColor = true;
            this.btNext.Click += new System.EventHandler(this.btNext_Click);
            // 
            // tbPage
            // 
            this.tbPage.Enabled = false;
            this.tbPage.Location = new System.Drawing.Point(656, 451);
            this.tbPage.Name = "tbPage";
            this.tbPage.Size = new System.Drawing.Size(35, 23);
            this.tbPage.TabIndex = 17;
            this.tbPage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbpage
            // 
            this.lbpage.AutoSize = true;
            this.lbpage.Location = new System.Drawing.Point(655, 477);
            this.lbpage.Name = "lbpage";
            this.lbpage.Size = new System.Drawing.Size(10, 15);
            this.lbpage.TabIndex = 18;
            this.lbpage.Text = " ";
            // 
            // Lab05_Bai2_3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 499);
            this.Controls.Add(this.lbpage);
            this.Controls.Add(this.tbPage);
            this.Controls.Add(this.btNext);
            this.Controls.Add(this.btBack);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbType);
            this.Controls.Add(this.btRef);
            this.Controls.Add(this.lvBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbOwn);
            this.Name = "Lab05_Bai2_3";
            this.Text = "Lab05_Bai2_3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox tbOwn;
        private ListView lvBox;
        private ColumnHeader colNum;
        private ColumnHeader colFrom;
        private ColumnHeader colSub;
        private ColumnHeader colDate;
        private Button btRef;
        private ComboBox cbType;
        private Label label2;
        private Label lbTotal;
        private Button btBack;
        private Button btNext;
        private TextBox tbPage;
        private Label lbpage;
    }
}