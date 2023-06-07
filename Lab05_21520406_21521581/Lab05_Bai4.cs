using MailKit.Net.Imap;
using MailKit.Net.Pop3;
using MailKit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http.Headers;

namespace Lab05_21520406_21521581
{
    public partial class Lab05_Bai4 : Form
    {
        string gmail, pass;
        public Lab05_Bai4(string gmail, string pass)
        {
            InitializeComponent();
            this.gmail = gmail;
            this.pass = pass;
            tbOwn.Text = gmail;
            tbOwn.Enabled = false;
            btRef.Enabled = false;
        }

        private void lvBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvBox.SelectedItems.Count == 0) return;
            ListViewItem item = lvBox.SelectedItems[0];
            int num = Int32.Parse(item.SubItems[0].Text);
            if (cbType.Text.ToString() == "IMAP")
            {
                var client = new ImapClient();
                client.Connect("imap.gmail.com", 993, true);
                client.Authenticate(gmail, pass);

                var inbox = client.Inbox;
                inbox.Open(FolderAccess.ReadOnly);
                var message = inbox.GetMessage(inbox.Count - num);
                FormView formView = new FormView(message.From.ToString(), message.To.ToString(), message.Subject.ToString(), message.HtmlBody.ToString(), pass);
                formView.Show();
            }
            else
            {
                var client = new Pop3Client();
                client.Connect("pop.gmail.com", 995, true);
                client.Authenticate(gmail, pass);

                var message = client.GetMessage(client.Count - num);
                FormView formView = new FormView(message.From.ToString(), message.To.ToString(), message.Subject.ToString(), message.HtmlBody.ToString(), pass);
                formView.Show();
            }
        }

        private void cbType_SelectedValueChanged(object sender, EventArgs e)
        {
            lvBox.Items.Clear();
            string type = cbType.Text.ToString();
            if (type != null) btRef.Enabled = true;
            MessageBox.Show("Đang load mail, vui lòng chờ trong giây lát!");
            if (type == "IMAP")
            {
                var client = new ImapClient();
                client.Connect("imap.gmail.com", 993, true);
                client.Authenticate(gmail, pass);
                var inbox = client.Inbox;
                inbox.Open(FolderAccess.ReadOnly);
                int limit = 1;
                for (int i = inbox.Count - 1; i >= 0; i--)
                {
                    var message = inbox.GetMessage(i);
                    ListViewItem item = new ListViewItem(limit.ToString());
                    item.SubItems.Add(message.From.ToString());
                    item.SubItems.Add(message.Subject.ToString());
                    item.SubItems.Add(message.Date.ToString());
                    lvBox.Items.Add(item);
                    if (limit == 20)
                    {
                        break;
                    }
                    else
                    {
                        limit++;
                    }
                }
            }
            else
            {
                var client = new Pop3Client();
                client.Connect("pop.gmail.com", 995, true);
                client.Authenticate(gmail, pass);
                int limit = 1;
                for (int i = client.Count - 1; i >= 0; i--)
                {
                    var message = client.GetMessage(i);
                    ListViewItem item = new ListViewItem(limit.ToString());
                    item.SubItems.Add(message.From.ToString());
                    item.SubItems.Add(message.Subject.ToString());
                    item.SubItems.Add(message.Date.ToString());
                    lvBox.Items.Add(item);
                    if (limit == 20)
                    {
                        break;
                    }
                    else
                    {
                        limit++;
                    }
                }
            }
        }

        private void btSendM_Click(object sender, EventArgs e)
        {
            Lab05_Bai1 lab05_Bai1 = new Lab05_Bai1(gmail, pass);
            lab05_Bai1.Show();
        }

        private void btLogout_Click(object sender, EventArgs e)
        {
            DialogResult logout = MessageBox.Show("Bạn có chắc muốn log out?", "Log out", MessageBoxButtons.YesNo);
            if (logout == DialogResult.Yes)
            {
                this.Close();
            }
            else if (logout == DialogResult.No)
            {

            }
        }

        private void btRef_Click(object sender, EventArgs e)
        {
            cbType_SelectedValueChanged(sender, e);
        }
    }
}
