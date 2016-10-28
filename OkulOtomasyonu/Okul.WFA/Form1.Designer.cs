namespace Okul.WFA
{
    partial class Form1
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
            this.formlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öğrenciFormuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öğretmenFormuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personelFormuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formlarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(623, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // formlarToolStripMenuItem
            // 
            this.formlarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.öğrenciFormuToolStripMenuItem,
            this.öğretmenFormuToolStripMenuItem,
            this.personelFormuToolStripMenuItem});
            this.formlarToolStripMenuItem.Name = "formlarToolStripMenuItem";
            this.formlarToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.formlarToolStripMenuItem.Text = "Formlar";
            // 
            // öğrenciFormuToolStripMenuItem
            // 
            this.öğrenciFormuToolStripMenuItem.Name = "öğrenciFormuToolStripMenuItem";
            this.öğrenciFormuToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.öğrenciFormuToolStripMenuItem.Text = "Öğrenci Formu";
            this.öğrenciFormuToolStripMenuItem.Click += new System.EventHandler(this.öğrenciFormuToolStripMenuItem_Click);
            // 
            // öğretmenFormuToolStripMenuItem
            // 
            this.öğretmenFormuToolStripMenuItem.Name = "öğretmenFormuToolStripMenuItem";
            this.öğretmenFormuToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.öğretmenFormuToolStripMenuItem.Text = "Öğretmen Formu";
            this.öğretmenFormuToolStripMenuItem.Click += new System.EventHandler(this.öğretmenFormuToolStripMenuItem_Click);
            // 
            // personelFormuToolStripMenuItem
            // 
            this.personelFormuToolStripMenuItem.Name = "personelFormuToolStripMenuItem";
            this.personelFormuToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.personelFormuToolStripMenuItem.Text = "Personel Formu";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 308);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem formlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem öğrenciFormuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem öğretmenFormuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personelFormuToolStripMenuItem;
    }
}

