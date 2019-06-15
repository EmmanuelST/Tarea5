namespace Tarea5_Detalle
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.registroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoDeAnalisisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroDeAnalisisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(884, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // registroToolStripMenuItem
            // 
            this.registroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarUsuarioToolStripMenuItem,
            this.tipoDeAnalisisToolStripMenuItem,
            this.registroDeAnalisisToolStripMenuItem});
            this.registroToolStripMenuItem.Name = "registroToolStripMenuItem";
            this.registroToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.registroToolStripMenuItem.Text = "&Registro";
            // 
            // registrarUsuarioToolStripMenuItem
            // 
            this.registrarUsuarioToolStripMenuItem.Name = "registrarUsuarioToolStripMenuItem";
            this.registrarUsuarioToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.registrarUsuarioToolStripMenuItem.Text = "Registrar &Usuario";
            this.registrarUsuarioToolStripMenuItem.Click += new System.EventHandler(this.RegistrarUsuarioToolStripMenuItem_Click);
            // 
            // tipoDeAnalisisToolStripMenuItem
            // 
            this.tipoDeAnalisisToolStripMenuItem.Name = "tipoDeAnalisisToolStripMenuItem";
            this.tipoDeAnalisisToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tipoDeAnalisisToolStripMenuItem.Text = "Tipo de &Analisis";
            this.tipoDeAnalisisToolStripMenuItem.Click += new System.EventHandler(this.TipoDeAnalisisToolStripMenuItem_Click);
            // 
            // registroDeAnalisisToolStripMenuItem
            // 
            this.registroDeAnalisisToolStripMenuItem.Name = "registroDeAnalisisToolStripMenuItem";
            this.registroDeAnalisisToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.registroDeAnalisisToolStripMenuItem.Text = "&Registro de Analisis";
            this.registroDeAnalisisToolStripMenuItem.Click += new System.EventHandler(this.RegistroDeAnalisisToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 484);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Tarea5";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem registroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipoDeAnalisisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroDeAnalisisToolStripMenuItem;
    }
}

