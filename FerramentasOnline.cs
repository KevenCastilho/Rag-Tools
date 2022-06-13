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
    public partial class ToolsOnline : Form
    {
        public ToolsOnline()
        {
            InitializeComponent();
            btnSprites.MouseEnter += new EventHandler(button1_MouseEnter);
            btnSprites.MouseLeave += new EventHandler(button1_MouseLeave);
            btnSimuladores.MouseEnter += new EventHandler(button2_MouseEnter);
            btnSimuladores.MouseLeave += new EventHandler(button2_MouseLeave);
            btnDBOld.MouseEnter += new EventHandler(button3_MouseEnter);
            btnDBOld.MouseLeave += new EventHandler(button3_MouseLeave);
            btnDBRe.MouseEnter += new EventHandler(button4_MouseEnter);
            btnDBRe.MouseLeave += new EventHandler(button4_MouseLeave);
            btnExtras.MouseEnter += new EventHandler(button5_MouseEnter);
            btnExtras.MouseLeave += new EventHandler(button5_MouseLeave);
            btnVoltar.MouseEnter += new EventHandler(button6_MouseEnter);
            btnVoltar.MouseLeave += new EventHandler(button6_MouseLeave);
            txtCreditos.MouseEnter += new EventHandler(txtCreditos_MouseEnter);
            txtCreditos.MouseLeave += new EventHandler(txtCreditos_MouseLeave);
        }

        // Botão 1
        void button1_MouseLeave(object sender, EventArgs e)
        {
            this.btnSprites.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.BTN_1));
            Cursor cur = new Cursor(Properties.Resources.point.Handle);
            this.Cursor = cur;
        }


        void button1_MouseEnter(object sender, EventArgs e)
        {
            this.btnSprites.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.BTN_2));
            Cursor cur = new Cursor(Properties.Resources.link.Handle);
            this.Cursor = cur;
        }

        // Botão 2
        void button2_MouseLeave(object sender, EventArgs e)
        {
            this.btnSimuladores.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.BTN_1));
            Cursor cur = new Cursor(Properties.Resources.point.Handle);
            this.Cursor = cur;
        }


        void button2_MouseEnter(object sender, EventArgs e)
        {
            this.btnSimuladores.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.BTN_2));
            Cursor cur = new Cursor(Properties.Resources.link.Handle);
            this.Cursor = cur;
        }

        // Botão 3
        void button3_MouseLeave(object sender, EventArgs e)
        {
            this.btnDBOld.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.BTN_1));
            Cursor cur = new Cursor(Properties.Resources.point.Handle);
            this.Cursor = cur;
        }


        void button3_MouseEnter(object sender, EventArgs e)
        {
            this.btnDBOld.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.BTN_2));
            Cursor cur = new Cursor(Properties.Resources.link.Handle);
            this.Cursor = cur;
        }

        // Botão 4
        void button4_MouseLeave(object sender, EventArgs e)
        {
            this.btnDBRe.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.BTN_1));
            Cursor cur = new Cursor(Properties.Resources.point.Handle);
            this.Cursor = cur;
        }


        void button4_MouseEnter(object sender, EventArgs e)
        {
            this.btnDBRe.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.BTN_2));
            Cursor cur = new Cursor(Properties.Resources.link.Handle);
            this.Cursor = cur;
        }

        // Botão 5

        void button5_MouseLeave(object sender, EventArgs e)
        {
            this.btnExtras.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.BTN_1));
            Cursor cur = new Cursor(Properties.Resources.point.Handle);
            this.Cursor = cur;
        }


        void button5_MouseEnter(object sender, EventArgs e)
        {
            this.btnExtras.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.BTN_2));
            Cursor cur = new Cursor(Properties.Resources.link.Handle);
            this.Cursor = cur;
        }

        // Botão 6

        void button6_MouseLeave(object sender, EventArgs e)
        {
            this.btnVoltar.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.BTN_1));
            Cursor cur = new Cursor(Properties.Resources.point.Handle);
            this.Cursor = cur;
        }


        void button6_MouseEnter(object sender, EventArgs e)
        {
            this.btnVoltar.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.BTN_2));
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

        private void button5_Click(object sender, EventArgs e)
        {
            MainMenu Menu = new MainMenu();
            Menu.Show();
            this.Visible = false;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnSprites_Click(object sender, EventArgs e)
        {
            Sprites SpriteList = new Sprites();
            SpriteList.Show();
            this.Visible = false;
        }

        private void btnSimuladores_Click(object sender, EventArgs e)
        {
            Simuladores SimuladoresList = new Simuladores();
            SimuladoresList.Show();
            this.Visible = false;
        }

        private void btnDBOld_Click(object sender, EventArgs e)
        {
            DB_Old NavegaDBOld = new DB_Old();
            NavegaDBOld.Show();
            this.Visible = false;
        }

        private void txtCreditos_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://linktr.ee/keven.castilho");
        }

        private void btnDBRe_Click(object sender, EventArgs e)
        {
            DB_RE NavegaDB_RE = new DB_RE();
            NavegaDB_RE.Show();
            this.Visible = false;
        }

        private void btnExtras_Click(object sender, EventArgs e)
        {
            Adicional NavegaAdicional = new Adicional();
            NavegaAdicional.Show();
            this.Visible = false;
        }
    }
}
