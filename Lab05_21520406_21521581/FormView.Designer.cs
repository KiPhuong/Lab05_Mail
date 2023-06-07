namespace Lab05_21520406_21521581
{
    partial class FormView
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
            this.tbSub = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbTo = new System.Windows.Forms.TextBox();
            this.tbFrom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.btReply = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).BeginInit();
            this.SuspendLayout();
            // 
            // tbSub
            // 
            this.tbSub.Location = new System.Drawing.Point(73, 76);
            this.tbSub.Name = "tbSub";
            this.tbSub.Size = new System.Drawing.Size(472, 23);
            this.tbSub.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 14;
            this.label3.Text = "Subject: ";
            // 
            // tbTo
            // 
            this.tbTo.Location = new System.Drawing.Point(73, 44);
            this.tbTo.Name = "tbTo";
            this.tbTo.Size = new System.Drawing.Size(472, 23);
            this.tbTo.TabIndex = 12;
            // 
            // tbFrom
            // 
            this.tbFrom.Location = new System.Drawing.Point(73, 12);
            this.tbFrom.Name = "tbFrom";
            this.tbFrom.Size = new System.Drawing.Size(472, 23);
            this.tbFrom.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "To: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "From: ";
            // 
            // webView21
            // 
            this.webView21.AllowExternalDrop = true;
            this.webView21.CreationProperties = null;
            this.webView21.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView21.Location = new System.Drawing.Point(12, 120);
            this.webView21.Name = "webView21";
            this.webView21.Size = new System.Drawing.Size(639, 391);
            this.webView21.TabIndex = 16;
            this.webView21.ZoomFactor = 1D;
            // 
            // btReply
            // 
            this.btReply.Location = new System.Drawing.Point(564, 29);
            this.btReply.Name = "btReply";
            this.btReply.Size = new System.Drawing.Size(75, 50);
            this.btReply.TabIndex = 17;
            this.btReply.Text = "Reply";
            this.btReply.UseVisualStyleBackColor = true;
            this.btReply.Click += new System.EventHandler(this.btReply_Click);
            // 
            // FormView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 523);
            this.Controls.Add(this.btReply);
            this.Controls.Add(this.webView21);
            this.Controls.Add(this.tbSub);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbTo);
            this.Controls.Add(this.tbFrom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormView";
            this.Text = "FormView";
            this.Load += new System.EventHandler(this.FormView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tbSub;
        private Label label3;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
        private Button btReply;
        private TextBox tbTo;
        private TextBox tbFrom;
        private Label label2;
        private Label label1;
    }
}