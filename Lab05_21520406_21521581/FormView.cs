﻿using Microsoft.Web.WebView2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HtmlAgilityPack;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Microsoft.VisualBasic.ApplicationServices;

namespace Lab05_21520406_21521581
{
    public partial class FormView : Form
    {
        string gmail, to, sub, html, pass;

        public FormView(string gmail, string to, string sub, string html, string pass)
        {
            InitializeComponent();
            this.gmail = gmail;
            this.to = to;
            this.sub = sub;
            this.html = html;
            this.pass = pass;
        }

        private async void FormView_Load(object sender, EventArgs e)
        {
            tbFrom.Text = gmail;
            tbTo.Text = to;
            tbSub.Text = sub;
            tbFrom.Enabled = false;
            tbTo.Enabled = false;
            tbSub.Enabled = false;

            await webView21.EnsureCoreWebView2Async();
            webView21.NavigateToString(html);
        }

        private void btReply_Click(object sender, EventArgs e)
        {
            FormReply formReply = new FormReply(to, gmail, sub, pass);
            formReply.Show();
        }

    }
}
