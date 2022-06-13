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
    public partial class FerramentasOffline : Form
    {
        public FerramentasOffline()
        {
            InitializeComponent();
            btnAbrir.MouseEnter += new EventHandler(button1_MouseEnter);
            btnAbrir.MouseLeave += new EventHandler(button1_MouseLeave);
            btnVoltar.MouseEnter += new EventHandler(button6_MouseEnter);
            btnVoltar.MouseLeave += new EventHandler(button6_MouseLeave);
            txtCreditos.MouseEnter += new EventHandler(txtCreditos_MouseEnter);
            txtCreditos.MouseLeave += new EventHandler(txtCreditos_MouseLeave);
        }

        // Botão 1
        void button1_MouseLeave(object sender, EventArgs e)
        {
            this.btnAbrir.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.BTN_MINI_1));
            Cursor cur = new Cursor(Properties.Resources.point.Handle);
            this.Cursor = cur;
        }


        void button1_MouseEnter(object sender, EventArgs e)
        {
            this.btnAbrir.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.BTN_MINI_2));
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

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            int SelectProgram;
            cboProgramas.SelectedItem = "Chicken Stats";
                if (cboProgramas.SelectedItem.Equals("Chicken Stats"))
                {
                    SelectProgram = 1;
                }
                else if (cboProgramas.SelectedItem.Equals("Czao Item Creator"))
                {
                    SelectProgram = 2;
                }
                else if (cboProgramas.SelectedItem.Equals("Grf Builder"))
                {
                    SelectProgram = 3;
                }
                else if (cboProgramas.SelectedItem.Equals("Mob DB Editor"))
                {
                    SelectProgram = 4;
                }
                else if (cboProgramas.SelectedItem.Equals("NPC Creator"))
                {
                    SelectProgram = 5;
                }
                else if (cboProgramas.SelectedItem.Equals("Outro Mob DB Editor"))
                {
                    SelectProgram = 6;
                }
                else if (cboProgramas.SelectedItem.Equals("ROConverter"))
                {
                    SelectProgram = 7;
                }
                else if (cboProgramas.SelectedItem.Equals("Shoper"))
                {
                    SelectProgram = 8;
                }
                else if (cboProgramas.SelectedItem.Equals("SPR Conview"))
                {
                    SelectProgram = 9;
                }
                else

                {
                    SelectProgram = 0;
                }

            switch (SelectProgram)
            {
                case 1:
                    System.Diagnostics.Process.Start("C:/Executaveis/Chicken_Stats.exe");
                    break;

                case 2:
                    System.Diagnostics.Process.Start("C:/Executaveis/Czao_Item_Creator/Czao Item Creator.exe");
                    break;

                case 3:
                    System.Diagnostics.Process.Start("C:/Executaveis/grfbuilder/grfbuilder.exe");
                    break;

                case 4:
                    System.Diagnostics.Process.Start("C:/Executaveis/MobDBEditor/MobDBEditor_PT-Br.exe");
                    break;

                case 5:
                    System.Diagnostics.Process.Start("C:/Executaveis/npccreator/NPCCreator.exe");
                    break;

                case 6:
                    System.Diagnostics.Process.Start("C:/Executaveis/MobDB_Edittor.exe");
                    break;

                case 7:
                    System.Diagnostics.Process.Start("C:/Executaveis/ROconverter1.2.exe");
                    break;

                case 8:
                    System.Diagnostics.Process.Start("C:/Executaveis/shoper/Shoper.exe");
                    break;

                case 9:
                    System.Diagnostics.Process.Start("C:/Executaveis/SPR_Conview_v0.11.exe");
                    break;

                case 0:
                    MessageBox.Show("Selecione um programa antes de clicar em abrir!", "RagTools - Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;
            }
        }

        private void cboProgramas_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }
    }
}
