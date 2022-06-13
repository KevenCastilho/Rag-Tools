
namespace RagTools
{
    partial class Adicional
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnNPCRules = new System.Windows.Forms.Button();
            this.btnGRFView = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.Navegador = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.btnItemDB = new System.Windows.Forms.Button();
            this.btnMobDB = new System.Windows.Forms.Button();
            this.btnNPCScript = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Navegador)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNPCRules
            // 
            this.btnNPCRules.BackColor = System.Drawing.Color.Transparent;
            this.btnNPCRules.BackgroundImage = global::RagTools.Properties.Resources.BTN_1;
            this.btnNPCRules.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNPCRules.FlatAppearance.BorderSize = 0;
            this.btnNPCRules.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNPCRules.Font = new System.Drawing.Font("Helvetica", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNPCRules.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(99)))), ((int)(((byte)(132)))));
            this.btnNPCRules.Location = new System.Drawing.Point(1, 12);
            this.btnNPCRules.Name = "btnNPCRules";
            this.btnNPCRules.Size = new System.Drawing.Size(200, 20);
            this.btnNPCRules.TabIndex = 6;
            this.btnNPCRules.Text = "Regras NPC";
            this.btnNPCRules.UseVisualStyleBackColor = false;
            this.btnNPCRules.Click += new System.EventHandler(this.btnSprites_Click);
            // 
            // btnGRFView
            // 
            this.btnGRFView.BackColor = System.Drawing.Color.Transparent;
            this.btnGRFView.BackgroundImage = global::RagTools.Properties.Resources.BTN_1;
            this.btnGRFView.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGRFView.FlatAppearance.BorderSize = 0;
            this.btnGRFView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGRFView.Font = new System.Drawing.Font("Helvetica", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGRFView.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(99)))), ((int)(((byte)(132)))));
            this.btnGRFView.Location = new System.Drawing.Point(207, 12);
            this.btnGRFView.Name = "btnGRFView";
            this.btnGRFView.Size = new System.Drawing.Size(200, 20);
            this.btnGRFView.TabIndex = 7;
            this.btnGRFView.Text = "Visualizar GRF";
            this.btnGRFView.UseVisualStyleBackColor = false;
            this.btnGRFView.Click += new System.EventHandler(this.btnEquip_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.Transparent;
            this.btnVoltar.BackgroundImage = global::RagTools.Properties.Resources.BTN_MINI_1;
            this.btnVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVoltar.FlatAppearance.BorderSize = 0;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Font = new System.Drawing.Font("Helvetica", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(99)))), ((int)(((byte)(132)))));
            this.btnVoltar.Location = new System.Drawing.Point(1031, 12);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(42, 20);
            this.btnVoltar.TabIndex = 9;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // Navegador
            // 
            this.Navegador.CreationProperties = null;
            this.Navegador.DefaultBackgroundColor = System.Drawing.Color.White;
            this.Navegador.Location = new System.Drawing.Point(1, 43);
            this.Navegador.Name = "Navegador";
            this.Navegador.Size = new System.Drawing.Size(1082, 550);
            this.Navegador.Source = new System.Uri("about:blank", System.UriKind.Absolute);
            this.Navegador.TabIndex = 10;
            this.Navegador.ZoomFactor = 1D;
            this.Navegador.Click += new System.EventHandler(this.Navegador_Click);
            // 
            // btnItemDB
            // 
            this.btnItemDB.BackColor = System.Drawing.Color.Transparent;
            this.btnItemDB.BackgroundImage = global::RagTools.Properties.Resources.BTN_1;
            this.btnItemDB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnItemDB.FlatAppearance.BorderSize = 0;
            this.btnItemDB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnItemDB.Font = new System.Drawing.Font("Helvetica", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnItemDB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(99)))), ((int)(((byte)(132)))));
            this.btnItemDB.Location = new System.Drawing.Point(413, 12);
            this.btnItemDB.Name = "btnItemDB";
            this.btnItemDB.Size = new System.Drawing.Size(200, 20);
            this.btnItemDB.TabIndex = 12;
            this.btnItemDB.Text = "Item DB Convert";
            this.btnItemDB.UseVisualStyleBackColor = false;
            this.btnItemDB.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnMobDB
            // 
            this.btnMobDB.BackColor = System.Drawing.Color.Transparent;
            this.btnMobDB.BackgroundImage = global::RagTools.Properties.Resources.BTN_1;
            this.btnMobDB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMobDB.FlatAppearance.BorderSize = 0;
            this.btnMobDB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMobDB.Font = new System.Drawing.Font("Helvetica", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMobDB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(99)))), ((int)(((byte)(132)))));
            this.btnMobDB.Location = new System.Drawing.Point(619, 12);
            this.btnMobDB.Name = "btnMobDB";
            this.btnMobDB.Size = new System.Drawing.Size(200, 20);
            this.btnMobDB.TabIndex = 13;
            this.btnMobDB.Text = "Mob DB Convert";
            this.btnMobDB.UseVisualStyleBackColor = false;
            this.btnMobDB.Click += new System.EventHandler(this.btnMobDB_Click);
            // 
            // btnNPCScript
            // 
            this.btnNPCScript.BackColor = System.Drawing.Color.Transparent;
            this.btnNPCScript.BackgroundImage = global::RagTools.Properties.Resources.BTN_1;
            this.btnNPCScript.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNPCScript.FlatAppearance.BorderSize = 0;
            this.btnNPCScript.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNPCScript.Font = new System.Drawing.Font("Helvetica", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNPCScript.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(99)))), ((int)(((byte)(132)))));
            this.btnNPCScript.Location = new System.Drawing.Point(825, 12);
            this.btnNPCScript.Name = "btnNPCScript";
            this.btnNPCScript.Size = new System.Drawing.Size(200, 20);
            this.btnNPCScript.TabIndex = 14;
            this.btnNPCScript.Text = "NPC Scripts";
            this.btnNPCScript.UseVisualStyleBackColor = false;
            this.btnNPCScript.Click += new System.EventHandler(this.btnNPCScript_Click);
            // 
            // Adicional
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 593);
            this.Controls.Add(this.btnNPCScript);
            this.Controls.Add(this.btnMobDB);
            this.Controls.Add(this.btnItemDB);
            this.Controls.Add(this.Navegador);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnGRFView);
            this.Controls.Add(this.btnNPCRules);
            this.MaximumSize = new System.Drawing.Size(1101, 632);
            this.MinimumSize = new System.Drawing.Size(1101, 632);
            this.Name = "Adicional";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RagTools - Conteudo Adicional";
            this.Load += new System.EventHandler(this.Sprites_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Navegador)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnNPCRules;
        private System.Windows.Forms.Button btnGRFView;
        private System.Windows.Forms.Button btnVoltar;
        private Microsoft.Web.WebView2.WinForms.WebView2 Navegador;
        private System.Windows.Forms.Button btnItemDB;
        private System.Windows.Forms.Button btnMobDB;
        private System.Windows.Forms.Button btnNPCScript;
    }
}