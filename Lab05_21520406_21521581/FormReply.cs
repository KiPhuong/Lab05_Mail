using MailKit.Net.Smtp;
using MimeKit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab05_21520406_21521581
{
    public partial class FormReply : Form
    {
        string gmail, to, pass, sub, path;
        public FormReply(string gmail, string to, string sub, string pass)
        {
            InitializeComponent();
            this.gmail = gmail;
            this.to = to;
            this.sub = sub;
            this.pass = pass;
            path = "";
        }

        private void FormReply_Load(object sender, EventArgs e)
        {
            tbFrom.Text = gmail;
            tbTo.Text = to;
            tbSub.Text = "Re: " + sub;
            tbFrom.Enabled = false;
            tbTo.Enabled = false;
        }

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

        //xử lý email address của người nhận
        //format address: "Name" <email> -> email
        string format(string to)
        {
            string newaddr = "";
            int i;
            for (i = 0; i < to.Length; i++)
            {
                if (to[i] == '<') break;
            }
            i++;
            while (to[i] != '>')
            {
                newaddr += to[i];
                i++;
            }
            return newaddr;
        }

        private void btSend_Click(object sender, EventArgs e)
        {
            // string newaddr = format(to);
            string newaddr = format(to);
            try
            {
                var client = new SmtpClient();
                client.Connect("smtp.gmail.com", 465, true); // smtp host, port, use ssl.
                client.Authenticate(gmail, pass); // gmail account, app password
                var reply = new MimeMessage();
                reply.From.Add(new MailboxAddress(tbName.Text, gmail));
                reply.To.Add(new MailboxAddress("", newaddr));
                reply.Subject = tbSub.Text;
                builder.TextBody = rtbBody.Text;
                reply.Body = builder.ToMessageBody();
                client.Send(reply);
                MessageBox.Show("Reply thành công!");
            }
            catch
            {
                MessageBox.Show("Lỗi! Không gửi được mail");
            }
        }

        


    }
}
