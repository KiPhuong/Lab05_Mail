namespace Lab05_21520406_21521581
{
    partial class Lab05_Bai4
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
            this.label2 = new System.Windows.Forms.Label();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.lvBox = new System.Windows.Forms.ListView();
            this.colNum = new System.Windows.Forms.ColumnHeader();
            this.colFrom = new System.Windows.Forms.ColumnHeader();
            this.colSub = new System.Windows.Forms.ColumnHeader();
            this.colDate = new System.Windows.Forms.ColumnHeader();
            this.label1 = new System.Windows.Forms.Label();
            this.tbOwn = new System.Windows.Forms.TextBox();
            this.btRef = new System.Windows.Forms.Button();
            this.btSendM = new System.Windows.Forms.Button();
            this.btLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(331, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 15);
            this.label2.TabIndex = 19;
            this.label2.Text = "Chọn host";
            // 
            // cbType
            // 
            this.cbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbType.FormattingEnabled = true;
            this.cbType.Items.AddRange(new object[] {
            "IMAP",
            "POP3"});
            this.cbType.Location = new System.Drawing.Point(399, 22);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(89, 23);
            this.cbType.TabIndex = 18;
            this.cbType.SelectedValueChanged += new System.EventHandler(this.cbType_SelectedValueChanged);
            // 
            // lvBox
            // 
            this.lvBox.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colNum,
            this.colFrom,
            this.colSub,
            this.colDate});
            this.lvBox.FullRowSelect = true;
            this.lvBox.Location = new System.Drawing.Point(16, 71);
            this.lvBox.Name = "lvBox";
            this.lvBox.Size = new System.Drawing.Size(769, 367);
            this.lvBox.TabIndex = 16;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 15);
            this.label1.TabIndex = 15;
            this.label1.Text = "Owner: ";
            // 
            // tbOwn
            // 
            this.tbOwn.Location = new System.Drawing.Point(71, 22);
            this.tbOwn.Name = "tbOwn";
            this.tbOwn.Size = new System.Drawing.Size(246, 23);
            this.tbOwn.TabIndex = 14;
            // 
            // btRef
            // 
            this.btRef.Location = new System.Drawing.Point(601, 12);
            this.btRef.Name = "btRef";
            this.btRef.Size = new System.Drawing.Size(75, 40);
            this.btRef.TabIndex = 22;
            this.btRef.Text = "Refresh";
            this.btRef.UseVisualStyleBackColor = true;
            this.btRef.Click += new System.EventHandler(this.btRef_Click);
            // 
            // btSendM
            // 
            this.btSendM.Location = new System.Drawing.Point(509, 12);
            this.btSendM.Name = "btSendM";
            this.btSendM.Size = new System.Drawing.Size(75, 40);
            this.btSendM.TabIndex = 21;
            this.btSendM.Text = "Send mail";
            this.btSendM.UseVisualStyleBackColor = true;
            this.btSendM.Click += new System.EventHandler(this.btSendM_Click);
            // 
            // btLogout
            // 
            this.btLogout.Location = new System.Drawing.Point(694, 12);
            this.btLogout.Name = "btLogout";
            this.btLogout.Size = new System.Drawing.Size(75, 40);
            this.btLogout.TabIndex = 20;
            this.btLogout.Text = "Log out";
            this.btLogout.UseVisualStyleBackColor = true;
            this.btLogout.Click += new System.EventHandler(this.btLogout_Click);
            // 
            // Lab05_Bai4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btRef);
            this.Controls.Add(this.btSendM);
            this.Controls.Add(this.btLogout);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbType);
            this.Controls.Add(this.lvBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbOwn);
            this.Name = "Lab05_Bai4";
            this.Text = "Lab05_Bai4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label2;
        private ComboBox cbType;
        private ListView lvBox;
        private ColumnHeader colNum;
        private ColumnHeader colFrom;
        private ColumnHeader colSub;
        private ColumnHeader colDate;
        private Label label1;
        private TextBox tbOwn;
        private Button btRef;
        private Button btSendM;
        private Button btLogout;
    }
}