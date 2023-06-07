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
    public partial class MainForm : Form
    {
        string gmail, pass;
        public MainForm(string gmail, string pass)
        {
            InitializeComponent();
            this.gmail = gmail;
            this.pass = pass;
        }
        
        private void btBai1_Click(object sender, EventArgs e)
        {
            Lab05_Bai1 lab05_Bai1 = new Lab05_Bai1(gmail, pass);
            lab05_Bai1.Show();
        }

        private void btBai2_3_Click(object sender, EventArgs e)
        {
            Lab05_Bai2_3 lab05_Bai2_3 = new Lab05_Bai2_3(gmail, pass);
            lab05_Bai2_3.Show();
        }

        private void btBai4_Click(object sender, EventArgs e)
        {
            Lab05_Bai4 lab05_Bai4 = new Lab05_Bai4(gmail, pass);
            lab05_Bai4.Show();
        }
    }
}
