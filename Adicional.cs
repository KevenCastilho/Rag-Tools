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
    public partial class Adicional : Form
    {
        public Adicional()
        {
            InitializeComponent();
            btnNPCRules.MouseEnter += new EventHandler(button1_MouseEnter);
            btnNPCRules.MouseLeave += new EventHandler(button1_MouseLeave);
            btnGRFView.MouseEnter += new EventHandler(button2_MouseEnter);
            btnGRFView.MouseLeave += new EventHandler(button2_MouseLeave);
            btnItemDB.MouseEnter += new EventHandler(button3_MouseEnter);
            btnItemDB.MouseLeave += new EventHandler(button3_MouseLeave);
            btnMobDB.MouseEnter += new EventHandler(button4_MouseEnter);
            btnMobDB.MouseLeave += new EventHandler(button4_MouseLeave);
            btnNPCScript.MouseEnter += new EventHandler(button5_MouseEnter);
            btnNPCScript.MouseLeave += new EventHandler(button5_MouseLeave);
            btnVoltar.MouseEnter += new EventHandler(button6_MouseEnter);
            btnVoltar.MouseLeave += new EventHandler(button6_MouseLeave);
        }

        // Botão 1
        void button1_MouseLeave(object sender, EventArgs e)
        {
            this.btnNPCRules.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.BTN_1));
            Cursor cur = new Cursor(Properties.Resources.point.Handle);
            this.Cursor = cur;
        }


        void button1_MouseEnter(object sender, EventArgs e)
        {
            this.btnNPCRules.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.BTN_2));
            Cursor cur = new Cursor(Properties.Resources.link.Handle);
            this.Cursor = cur;
        }

        // Botão 2
        void button2_MouseLeave(object sender, EventArgs e)
        {
            this.btnGRFView.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.BTN_1));
            Cursor cur = new Cursor(Properties.Resources.point.Handle);
            this.Cursor = cur;
        }


        void button2_MouseEnter(object sender, EventArgs e)
        {
            this.btnGRFView.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.BTN_2));
            Cursor cur = new Cursor(Properties.Resources.link.Handle);
            this.Cursor = cur;
        }

        // Botão 3
        void button3_MouseLeave(object sender, EventArgs e)
        {
            this.btnItemDB.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.BTN_1));
            Cursor cur = new Cursor(Properties.Resources.point.Handle);
            this.Cursor = cur;
        }


        void button3_MouseEnter(object sender, EventArgs e)
        {
            this.btnItemDB.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.BTN_2));
            Cursor cur = new Cursor(Properties.Resources.link.Handle);
            this.Cursor = cur;
        }

        // Botão 4
        void button4_MouseLeave(object sender, EventArgs e)
        {
            this.btnMobDB.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.BTN_1));
            Cursor cur = new Cursor(Properties.Resources.point.Handle);
            this.Cursor = cur;
        }


        void button4_MouseEnter(object sender, EventArgs e)
        {
            this.btnMobDB.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.BTN_2));
            Cursor cur = new Cursor(Properties.Resources.link.Handle);
            this.Cursor = cur;
        }

        // Botão 5
        void button5_MouseLeave(object sender, EventArgs e)
        {
            this.btnNPCScript.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.BTN_1));
            Cursor cur = new Cursor(Properties.Resources.point.Handle);
            this.Cursor = cur;
        }


        void button5_MouseEnter(object sender, EventArgs e)
        {
            this.btnNPCScript.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.BTN_2));
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
            Navegador.CoreWebView2.Navigate("https://raw.githubusercontent.com/Cronus-Emulator/Cronus/master/doc/Comandos_de_Script_PT-BR.txt");
        }

        private void btnEquip_Click(object sender, EventArgs e)
        {
            Navegador.CoreWebView2.Navigate("http://grfview.xp3.biz/");
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
            Navegador.CoreWebView2.Navigate("https://haru.ws/hercules/itemdbconverter");
        }

        private void btnMobDB_Click(object sender, EventArgs e)
        {
            Navegador.CoreWebView2.Navigate("https://haru.ws/hercules/mobdbconverter");
        }

        private void btnNPCScript_Click(object sender, EventArgs e)
        {
            Navegador.CoreWebView2.Navigate("http://grfviewer.rf.gd/NPC/");
        }
    }
}
