namespace ProvaTPLI
{
    partial class MENU
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
            this.aRQUIVOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fECHARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cADASTROSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uSUARIOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eXIBIRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aJUDAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mANUALToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fUNCIONARIOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aRQUIVOToolStripMenuItem,
            this.cADASTROSToolStripMenuItem,
            this.eXIBIRToolStripMenuItem,
            this.aJUDAToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aRQUIVOToolStripMenuItem
            // 
            this.aRQUIVOToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fECHARToolStripMenuItem});
            this.aRQUIVOToolStripMenuItem.Name = "aRQUIVOToolStripMenuItem";
            this.aRQUIVOToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.aRQUIVOToolStripMenuItem.Text = "ARQUIVO";
            // 
            // fECHARToolStripMenuItem
            // 
            this.fECHARToolStripMenuItem.Name = "fECHARToolStripMenuItem";
            this.fECHARToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.fECHARToolStripMenuItem.Text = "FECHAR";
            this.fECHARToolStripMenuItem.Click += new System.EventHandler(this.fECHARToolStripMenuItem_Click);
            // 
            // cADASTROSToolStripMenuItem
            // 
            this.cADASTROSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uSUARIOSToolStripMenuItem});
            this.cADASTROSToolStripMenuItem.Name = "cADASTROSToolStripMenuItem";
            this.cADASTROSToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.cADASTROSToolStripMenuItem.Text = "CADASTROS";
            // 
            // uSUARIOSToolStripMenuItem
            // 
            this.uSUARIOSToolStripMenuItem.Name = "uSUARIOSToolStripMenuItem";
            this.uSUARIOSToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.uSUARIOSToolStripMenuItem.Text = "USUARIOS";
            this.uSUARIOSToolStripMenuItem.Click += new System.EventHandler(this.uSUARIOSToolStripMenuItem_Click);
            // 
            // eXIBIRToolStripMenuItem
            // 
            this.eXIBIRToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fUNCIONARIOToolStripMenuItem});
            this.eXIBIRToolStripMenuItem.Name = "eXIBIRToolStripMenuItem";
            this.eXIBIRToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.eXIBIRToolStripMenuItem.Text = "EXIBIR";
            // 
            // aJUDAToolStripMenuItem
            // 
            this.aJUDAToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mANUALToolStripMenuItem});
            this.aJUDAToolStripMenuItem.Name = "aJUDAToolStripMenuItem";
            this.aJUDAToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.aJUDAToolStripMenuItem.Text = "AJUDA";
            // 
            // mANUALToolStripMenuItem
            // 
            this.mANUALToolStripMenuItem.Name = "mANUALToolStripMenuItem";
            this.mANUALToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.mANUALToolStripMenuItem.Text = "MANUAL";
            // 
            // fUNCIONARIOToolStripMenuItem
            // 
            this.fUNCIONARIOToolStripMenuItem.Name = "fUNCIONARIOToolStripMenuItem";
            this.fUNCIONARIOToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.fUNCIONARIOToolStripMenuItem.Text = "FUNCIONARIO";
            this.fUNCIONARIOToolStripMenuItem.Click += new System.EventHandler(this.fUNCIONARIOToolStripMenuItem_Click);
            // 
            // MENU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MENU";
            this.Text = "Menu Empresa";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aRQUIVOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fECHARToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cADASTROSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uSUARIOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eXIBIRToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aJUDAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mANUALToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fUNCIONARIOToolStripMenuItem;
    }
}