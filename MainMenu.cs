using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RagTools
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
            btnOnline.MouseEnter += new EventHandler(button1_MouseEnter);
            btnOnline.MouseLeave += new EventHandler(button1_MouseLeave);
            btnOffline.MouseEnter += new EventHandler(button2_MouseEnter);
            btnOffline.MouseLeave += new EventHandler(button2_MouseLeave);
            btnInstall.MouseEnter += new EventHandler(button3_MouseEnter);
            btnInstall.MouseLeave += new EventHandler(button3_MouseLeave);
            btnCredito.MouseEnter += new EventHandler(button4_MouseEnter);
            btnCredito.MouseLeave += new EventHandler(button4_MouseLeave);
            btnAbout.MouseEnter += new EventHandler(button5_MouseEnter);
            btnAbout.MouseLeave += new EventHandler(button5_MouseLeave);
            btnSair.MouseEnter += new EventHandler(button6_MouseEnter);
            btnSair.MouseLeave += new EventHandler(button6_MouseLeave);
            txtCreditos.MouseEnter += new EventHandler(txtCreditos_MouseEnter);
            txtCreditos.MouseLeave += new EventHandler(txtCreditos_MouseLeave);
        }

        // Botão 1
        void button1_MouseLeave(object sender, EventArgs e)
        {
            this.btnOnline.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.BTN_1));
            Cursor cur = new Cursor(Properties.Resources.point.Handle);
            this.Cursor = cur;
        }


        void button1_MouseEnter(object sender, EventArgs e)
        {
            this.btnOnline.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.BTN_2));
            Cursor cur = new Cursor(Properties.Resources.link.Handle);
            this.Cursor = cur;
        }

        // Botão 2
        void button2_MouseLeave(object sender, EventArgs e)
        {
            this.btnOffline.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.BTN_1));
            Cursor cur = new Cursor(Properties.Resources.point.Handle);
            this.Cursor = cur;
        }


        void button2_MouseEnter(object sender, EventArgs e)
        {
            this.btnOffline.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.BTN_2));
            Cursor cur = new Cursor(Properties.Resources.link.Handle);
            this.Cursor = cur;
        }

        // Botão 3
        void button3_MouseLeave(object sender, EventArgs e)
        {
            this.btnInstall.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.BTN_1));
            Cursor cur = new Cursor(Properties.Resources.point.Handle);
            this.Cursor = cur;
        }


        void button3_MouseEnter(object sender, EventArgs e)
        {
            this.btnInstall.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.BTN_2));
            Cursor cur = new Cursor(Properties.Resources.link.Handle);
            this.Cursor = cur;
        }

        // Botão 4
        void button4_MouseLeave(object sender, EventArgs e)
        {
            this.btnCredito.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.BTN_1));
            Cursor cur = new Cursor(Properties.Resources.point.Handle);
            this.Cursor = cur;
        }


        void button4_MouseEnter(object sender, EventArgs e)
        {
            this.btnCredito.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.BTN_2));
            Cursor cur = new Cursor(Properties.Resources.link.Handle);
            this.Cursor = cur;
        }

        // Botão 5

        void button5_MouseLeave(object sender, EventArgs e)
        {
            this.btnAbout.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.BTN_1));
            Cursor cur = new Cursor(Properties.Resources.point.Handle);
            this.Cursor = cur;
        }


        void button5_MouseEnter(object sender, EventArgs e)
        {
            this.btnAbout.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.BTN_2));
            Cursor cur = new Cursor(Properties.Resources.link.Handle);
            this.Cursor = cur;
        }

        // Botão 6

        void button6_MouseLeave(object sender, EventArgs e)
        {
            this.btnSair.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.BTN_1));
            Cursor cur = new Cursor(Properties.Resources.point.Handle);
            this.Cursor = cur;
        }


        void button6_MouseEnter(object sender, EventArgs e)
        {
            this.btnSair.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.BTN_2));
            Cursor cur = new Cursor(Properties.Resources.link.Handle);
            this.Cursor = cur;
        }

        // Txt Créditos
        void txtCreditos_MouseLeave(object sender, EventArgs e)
        {
            
            Cursor cur = new Cursor(Properties.Resources.point.Handle);
            this.Cursor = cur;
        }


        void txtCreditos_MouseEnter(object sender, EventArgs e)
        {
            Cursor cur = new Cursor(Properties.Resources.link.Handle);
            this.Cursor = cur;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Cursor cur = new Cursor(Properties.Resources.point.Handle);
            this.Cursor = cur;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://linktr.ee/keven.castilho");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ToolsOnline Online = new ToolsOnline();
            Online.Show();
            this.Visible = false;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
            Application.Exit();
        }

        private void btnCredito_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Todos os créditos de seus respectivos criadores encontram-se onde os mesmos colocaram e nenhum crédito foi removido.\nCaso Queira seus crédito diretamente adicionado favor entrar em contato.", "RagTools - Créditos", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("RagTools é uma ferramenta que desenvolvi no inicio do meu aprendizado em C# durante a faculdade no intuito de práticar o que aprendi em C# criando uma ferramenta que reune varias outras ferramentas no auxilio de criação manutenção e gerenciamento de servidores private de Ragnarok Online.\nRagTools é de autoria de Keven Castilho.\nRagnarok Online é uma marca registrada pela Gravity Games e tem seus direitos reservados.", "RagTools - Sobre", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnOffline_Click(object sender, EventArgs e)
        {
            FerramentasOffline ToolsOffline = new FerramentasOffline();
            ToolsOffline.Show();
            this.Visible = false;

        }
    }
}
