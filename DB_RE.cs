using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Web.WebView2.Core;

namespace RagTools
{
    public partial class DB_RE : Form
    {
        public DB_RE()
        {
            InitializeComponent();
            btnDivinePride.MouseEnter += new EventHandler(button1_MouseEnter);
            btnDivinePride.MouseLeave += new EventHandler(button1_MouseLeave);
            btnRagnaPlace.MouseEnter += new EventHandler(button2_MouseEnter);
            btnRagnaPlace.MouseLeave += new EventHandler(button2_MouseLeave);
            btnRateMyServer.MouseEnter += new EventHandler(button3_MouseEnter);
            btnRateMyServer.MouseLeave += new EventHandler(button3_MouseLeave);
            btnVoltar.MouseEnter += new EventHandler(button6_MouseEnter);
            btnVoltar.MouseLeave += new EventHandler(button6_MouseLeave);
        }

        // Botão 1
        void button1_MouseLeave(object sender, EventArgs e)
        {
            this.btnDivinePride.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.BTN_1));
            Cursor cur = new Cursor(Properties.Resources.point.Handle);
            this.Cursor = cur;
        }


        void button1_MouseEnter(object sender, EventArgs e)
        {
            this.btnDivinePride.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.BTN_2));
            Cursor cur = new Cursor(Properties.Resources.link.Handle);
            this.Cursor = cur;
        }

        // Botão 2
        void button2_MouseLeave(object sender, EventArgs e)
        {
            this.btnRagnaPlace.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.BTN_1));
            Cursor cur = new Cursor(Properties.Resources.point.Handle);
            this.Cursor = cur;
        }


        void button2_MouseEnter(object sender, EventArgs e)
        {
            this.btnRagnaPlace.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.BTN_2));
            Cursor cur = new Cursor(Properties.Resources.link.Handle);
            this.Cursor = cur;
        }

        // Botão 3
        void button3_MouseLeave(object sender, EventArgs e)
        {
            this.btnRateMyServer.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.BTN_1));
            Cursor cur = new Cursor(Properties.Resources.point.Handle);
            this.Cursor = cur;
        }


        void button3_MouseEnter(object sender, EventArgs e)
        {
            this.btnRateMyServer.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.BTN_2));
            Cursor cur = new Cursor(Properties.Resources.link.Handle);
            this.Cursor = cur;
        }

        // Botão 6

        void button6_MouseLeave(object sender, EventArgs e)
        {
            this.btnVoltar.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.BTN_MINI_1));
            Cursor cur = new Cursor(Properties.Resources.point.Handle);
            this.Cursor = cur;
        }


        void button6_MouseEnter(object sender, EventArgs e)
        {
            this.btnVoltar.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.BTN_MINI_2));
            Cursor cur = new Cursor(Properties.Resources.link.Handle);
            this.Cursor = cur;
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
           
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            ToolsOnline Online = new ToolsOnline();
            Online.Show();
            this.Visible = false;
        }

        private void btnSprites_Click(object sender, EventArgs e)
        {
            Navegador.CoreWebView2.Navigate("https://www.divine-pride.net/");
        }

        private void btnEquip_Click(object sender, EventArgs e)
        {
            Navegador.CoreWebView2.Navigate("https://ragnaplace.com/");
        }

        private void btnMonstros_Click(object sender, EventArgs e)
        {
            Navegador.CoreWebView2.Navigate("http://nn.ai4rei.net/dev/npclist/?q=type%3Amonster");
        }

        private void Sprites_Load(object sender, EventArgs e)
        {

        }

        private void btnJobs_Click(object sender, EventArgs e)
        {
            Navegador.CoreWebView2.Navigate("http://nn.ai4rei.net/dev/npclist/?q=type%3Ajob");
        }

        private void btnHomun_Click(object sender, EventArgs e)
        {
            Navegador.CoreWebView2.Navigate("http://nn.ai4rei.net/dev/npclist/?q=type%3Amercenary");
        }

        private void btnIlustra_Click(object sender, EventArgs e)
        {
            Navegador.CoreWebView2.Navigate("http://nn.ai4rei.net/dev/npclist/?q=illust%3Atrue");
        }

        private void Navegador_Click(object sender, EventArgs e)
        {

        }

        private void btnRagData_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Navegador.CoreWebView2.Navigate("https://ratemyserver.net/");
        }
    }
}
