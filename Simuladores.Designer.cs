
namespace RagTools
{
    partial class Simuladores
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
            this.btnStats = new System.Windows.Forms.Button();
            this.btnSkills = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.Navegador = new Microsoft.Web.WebView2.WinForms.WebView2();
            ((System.ComponentModel.ISupportInitialize)(this.Navegador)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStats
            // 
            this.btnStats.BackColor = System.Drawing.Color.Transparent;
            this.btnStats.BackgroundImage = global::RagTools.Properties.Resources.BTN_1;
            this.btnStats.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStats.FlatAppearance.BorderSize = 0;
            this.btnStats.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStats.Font = new System.Drawing.Font("Helvetica", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStats.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(99)))), ((int)(((byte)(132)))));
            this.btnStats.Location = new System.Drawing.Point(12, 12);
            this.btnStats.Name = "btnStats";
            this.btnStats.Size = new System.Drawing.Size(221, 20);
            this.btnStats.TabIndex = 6;
            this.btnStats.Text = "Calculadora de Atributos";
            this.btnStats.UseVisualStyleBackColor = false;
            this.btnStats.Click += new System.EventHandler(this.btnSprites_Click);
            // 
            // btnSkills
            // 
            this.btnSkills.BackColor = System.Drawing.Color.Transparent;
            this.btnSkills.BackgroundImage = global::RagTools.Properties.Resources.BTN_1;
            this.btnSkills.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSkills.FlatAppearance.BorderSize = 0;
            this.btnSkills.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSkills.Font = new System.Drawing.Font("Helvetica", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSkills.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(99)))), ((int)(((byte)(132)))));
            this.btnSkills.Location = new System.Drawing.Point(239, 12);
            this.btnSkills.Name = "btnSkills";
            this.btnSkills.Size = new System.Drawing.Size(221, 20);
            this.btnSkills.TabIndex = 7;
            this.btnSkills.Text = "Calculadora de Habilidades";
            this.btnSkills.UseVisualStyleBackColor = false;
            this.btnSkills.Click += new System.EventHandler(this.btnEquip_Click);
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
            // Simuladores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 593);
            this.Controls.Add(this.Navegador);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnSkills);
            this.Controls.Add(this.btnStats);
            this.MaximumSize = new System.Drawing.Size(1101, 632);
            this.MinimumSize = new System.Drawing.Size(1101, 632);
            this.Name = "Simuladores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RagTools - Simuladores";
            this.Load += new System.EventHandler(this.Sprites_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Navegador)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnStats;
        private System.Windows.Forms.Button btnSkills;
        private System.Windows.Forms.Button btnVoltar;
        private Microsoft.Web.WebView2.WinForms.WebView2 Navegador;
    }
}