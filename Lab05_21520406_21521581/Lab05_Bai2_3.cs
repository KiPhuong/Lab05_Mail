using MailKit.Net.Imap;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using MailKit.Net.Pop3;

namespace Lab05_21520406_21521581
{
    public partial class Lab05_Bai2_3 : Form
    {
        string gmail, pass, type = "";
        int page = 0, tolpage;

        public Lab05_Bai2_3(string gmail, string pass)
        {
            InitializeComponent();
            this.gmail = gmail;
            this.pass = pass;
            tbOwn.Text = gmail;
            tbOwn.Enabled = false; 
            btRef.Enabled = false;
        }

        private void cbType_SelectedValueChanged(object sender, EventArgs e)
        {
            type = cbType.Text.ToString();
            if (type != null) btRef.Enabled = true;
            LoadF(page);
            tbPage.Text = (page + 1).ToString();
            lbpage.Text = "1 - 20";
        }
        void LoadF(int page)
        {
            lvBox.Items.Clear();
            MessageBox.Show("Đang load mail, vui lòng chờ trong giây lát!");
            if (type == "IMAP")
            {
                var client = new ImapClient();
                client.Connect("imap.gmail.com", 993, true);
                client.Authenticate(gmail, pass);
                var inbox = client.Inbox;
                inbox.Open(FolderAccess.ReadOnly);

                lbTotal.Text = "Total: " + inbox.Count.ToString();

                if (inbox.Count % 20 > 0) tolpage = inbox.Count / 20 + 1;
                else tolpage = inbox.Count % 20;

                int limit = 1 +  20 * page;
                for (int i = inbox.Count - 1 - (page * 20); i >= 0; i--)
                {
                    var message = inbox.GetMessage(i);
                    ListViewItem item = new ListViewItem(limit.ToString());
                    item.SubItems.Add(message.From.ToString());
                    item.SubItems.Add(message.Subject.ToString());
                    item.SubItems.Add(message.Date.ToString());
                    lvBox.Items.Add(item);
                    if (limit % 20 == 0)
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
                int limit = 1 + 20 * page;
                lbTotal.Text = "Total: " + client.Count.ToString(); 

                if (client.Count % 20 > 0) tolpage = client.Count / 20 + 1;
                else tolpage = client.Count % 20;

                for (int i = client.Count - 1 - (page * 20); i >= 0; i--)
                {
                    var message = client.GetMessage(i);
                    ListViewItem item = new ListViewItem(limit.ToString());
                    item.SubItems.Add(message.From.ToString());
                    item.SubItems.Add(message.Subject.ToString());
                    item.SubItems.Add(message.Date.ToString());
                    lvBox.Items.Add(item);
                    if (limit % 20 == 0)
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
        

        private void btBack_Click(object sender, EventArgs e)
        {
            if (page > 0)
            {
                page--;
                lbpage.Text = (page * 20 + 1).ToString() + " - " + (page * 20 + 20).ToString();
                tbPage.Text = (page + 1).ToString();
                LoadF(page);
            }
            else
            {
                MessageBox.Show("Không thể back!");
            }
        }

        private void btNext_Click(object sender, EventArgs e)
        {
            if (page < tolpage)
            {
                page++;
                lbpage.Text = (page * 20 + 1).ToString() + " - " + (page * 20 + 20).ToString();
                tbPage.Text = (page + 1).ToString();
                LoadF(page);
            }
            else
            {
                MessageBox.Show("Không thể next!");
            }
        }

        private void btRef_Click(object sender, EventArgs e)
        {
            LoadF(page);
        }
    }
}
