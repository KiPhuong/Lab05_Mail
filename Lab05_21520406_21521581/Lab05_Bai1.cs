using MailKit.Net.Smtp;
using MimeKit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Lab05_21520406_21521581
{
    public partial class Lab05_Bai1 : Form
    {
        string gmail, pass;
        public Lab05_Bai1(string gmail, string pass)
        {
            InitializeComponent();
            this.gmail = gmail;
            this.pass = pass;
            tbFrom.Text = gmail;
            tbFrom.Enabled = false;
        }

        string path = "";
        BodyBuilder builder = new BodyBuilder();
        private void btSelect_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            path = ofd.FileName;
            string temp = Path.GetFileName(path);
            tbPath.Text += temp + "  ";
            builder.Attachments.Add(path);
        }

        private void btSend_Click(object sender, EventArgs e)
        {
            try
            {
                var client = new SmtpClient();
                client.Connect("smtp.gmail.com", 465, true); // smtp host, port, use ssl.
                client.Authenticate(tbFrom.Text, pass); // gmail account, app password
                var message = new MimeMessage();
                message.From.Add(new MailboxAddress(tbName.Text, tbFrom.Text));
                message.To.Add(new MailboxAddress("", tbTo.Text));
                message.Subject = tbSub.Text;
                builder.TextBody = rtbBody.Text;
                message.Body = builder.ToMessageBody();
                client.Send(message);
                MessageBox.Show("Thành công! Đã gửi mail");
                this.Close();
            }
            catch
            {
                MessageBox.Show("Lỗi! Không gửi được mail");
            }
        }

       
    }
}
