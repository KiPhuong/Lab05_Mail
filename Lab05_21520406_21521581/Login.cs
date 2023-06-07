using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
//using System.Net.Mail;
using MailKit;
using MailKit.Net.Smtp;

namespace Lab05_21520406_21521581
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            try
            {
                var client = new SmtpClient();
                client.Connect("smtp.gmail.com", 465, true); // smtp host, port, use ssl.
                client.Authenticate(tbGmail.Text, tbPass.Text); // gmail account, app password
                MainForm mainForm = new MainForm(tbGmail.Text, tbPass.Text);
                mainForm.ShowDialog();
            }
            catch
            {
                MessageBox.Show("Tài khoản sai! Vui lòng nhập lại");
            }
            
        }
    }
}