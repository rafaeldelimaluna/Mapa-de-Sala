
namespace Mapa_de_Sala
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alunoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.professorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.matériaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.coordenadorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatórioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alunoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.professorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.matériaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.coordenadorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.salaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.BodyTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LoginEntrarBtn = new System.Windows.Forms.Button();
            this.LoginPasswordEntryBox = new System.Windows.Forms.TextBox();
            this.LoginEmailEntryBox = new System.Windows.Forms.TextBox();
            this.LoginPanel = new System.Windows.Forms.Panel();
            this.LoginHeaderLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.LoginPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem,
            this.relatórioToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1069, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alunoToolStripMenuItem,
            this.professorToolStripMenuItem,
            this.matériaToolStripMenuItem,
            this.coordenadorToolStripMenuItem,
            this.salaToolStripMenuItem});
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // alunoToolStripMenuItem
            // 
            this.alunoToolStripMenuItem.Name = "alunoToolStripMenuItem";
            this.alunoToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.alunoToolStripMenuItem.Text = "Aluno";
            // 
            // professorToolStripMenuItem
            // 
            this.professorToolStripMenuItem.Name = "professorToolStripMenuItem";
            this.professorToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.professorToolStripMenuItem.Text = "Professor";
            // 
            // matériaToolStripMenuItem
            // 
            this.matériaToolStripMenuItem.Name = "matériaToolStripMenuItem";
            this.matériaToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.matériaToolStripMenuItem.Text = "Matéria";
            // 
            // coordenadorToolStripMenuItem
            // 
            this.coordenadorToolStripMenuItem.Name = "coordenadorToolStripMenuItem";
            this.coordenadorToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.coordenadorToolStripMenuItem.Text = "Coordenador";
            // 
            // salaToolStripMenuItem
            // 
            this.salaToolStripMenuItem.Name = "salaToolStripMenuItem";
            this.salaToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.salaToolStripMenuItem.Text = "Sala";
            // 
            // relatórioToolStripMenuItem
            // 
            this.relatórioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alunoToolStripMenuItem1,
            this.professorToolStripMenuItem1,
            this.matériaToolStripMenuItem1,
            this.coordenadorToolStripMenuItem1,
            this.salaToolStripMenuItem1});
            this.relatórioToolStripMenuItem.Name = "relatórioToolStripMenuItem";
            this.relatórioToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.relatórioToolStripMenuItem.Text = "Relatório";
            // 
            // alunoToolStripMenuItem1
            // 
            this.alunoToolStripMenuItem1.Name = "alunoToolStripMenuItem1";
            this.alunoToolStripMenuItem1.Size = new System.Drawing.Size(144, 22);
            this.alunoToolStripMenuItem1.Text = "Aluno";
            // 
            // professorToolStripMenuItem1
            // 
            this.professorToolStripMenuItem1.Name = "professorToolStripMenuItem1";
            this.professorToolStripMenuItem1.Size = new System.Drawing.Size(144, 22);
            this.professorToolStripMenuItem1.Text = "Professor";
            // 
            // matériaToolStripMenuItem1
            // 
            this.matériaToolStripMenuItem1.Name = "matériaToolStripMenuItem1";
            this.matériaToolStripMenuItem1.Size = new System.Drawing.Size(144, 22);
            this.matériaToolStripMenuItem1.Text = "Matéria";
            // 
            // coordenadorToolStripMenuItem1
            // 
            this.coordenadorToolStripMenuItem1.Name = "coordenadorToolStripMenuItem1";
            this.coordenadorToolStripMenuItem1.Size = new System.Drawing.Size(144, 22);
            this.coordenadorToolStripMenuItem1.Text = "Coordenador";
            // 
            // salaToolStripMenuItem1
            // 
            this.salaToolStripMenuItem1.Name = "salaToolStripMenuItem1";
            this.salaToolStripMenuItem1.Size = new System.Drawing.Size(144, 22);
            this.salaToolStripMenuItem1.Text = "Sala";
            // 
            // BodyTitle
            // 
            this.BodyTitle.AccessibleRole = System.Windows.Forms.AccessibleRole.Document;
            this.BodyTitle.AutoSize = true;
            this.BodyTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BodyTitle.Font = new System.Drawing.Font("Segoe UI Emoji", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BodyTitle.Location = new System.Drawing.Point(414, 23);
            this.BodyTitle.Margin = new System.Windows.Forms.Padding(0);
            this.BodyTitle.MaximumSize = new System.Drawing.Size(16000, 16000);
            this.BodyTitle.Name = "BodyTitle";
            this.BodyTitle.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BodyTitle.Size = new System.Drawing.Size(273, 64);
            this.BodyTitle.TabIndex = 2;
            this.BodyTitle.Text = "Bem Vindo!";
            this.BodyTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BodyTitle.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BodyTitle);
            this.panel1.Location = new System.Drawing.Point(0, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1069, 118);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // LoginEntrarBtn
            // 
            this.LoginEntrarBtn.Location = new System.Drawing.Point(243, 247);
            this.LoginEntrarBtn.Name = "LoginEntrarBtn";
            this.LoginEntrarBtn.Size = new System.Drawing.Size(100, 23);
            this.LoginEntrarBtn.TabIndex = 5;
            this.LoginEntrarBtn.Text = "Entrar";
            this.LoginEntrarBtn.UseVisualStyleBackColor = true;
            this.LoginEntrarBtn.Click += new System.EventHandler(this.LoginEntrarBtn_Click);
            // 
            // LoginPasswordEntryBox
            // 
            this.LoginPasswordEntryBox.Location = new System.Drawing.Point(200, 205);
            this.LoginPasswordEntryBox.Name = "LoginPasswordEntryBox";
            this.LoginPasswordEntryBox.Size = new System.Drawing.Size(185, 23);
            this.LoginPasswordEntryBox.TabIndex = 6;
            this.LoginPasswordEntryBox.Click += new System.EventHandler(this.LoginPasswordEntryBox_Click);
            this.LoginPasswordEntryBox.TextChanged += new System.EventHandler(this.LoginPasswordEntryBox_TextChanged);
            // 
            // LoginEmailEntryBox
            // 
            this.LoginEmailEntryBox.Location = new System.Drawing.Point(200, 163);
            this.LoginEmailEntryBox.Name = "LoginEmailEntryBox";
            this.LoginEmailEntryBox.Size = new System.Drawing.Size(185, 23);
            this.LoginEmailEntryBox.TabIndex = 7;
            this.LoginEmailEntryBox.TextChanged += new System.EventHandler(this.LoginEmailEntryBox_TextChanged);
            // 
            // LoginPanel
            // 
            this.LoginPanel.Controls.Add(this.LoginHeaderLabel);
            this.LoginPanel.Controls.Add(this.LoginEmailEntryBox);
            this.LoginPanel.Controls.Add(this.LoginPasswordEntryBox);
            this.LoginPanel.Controls.Add(this.LoginEntrarBtn);
            this.LoginPanel.Location = new System.Drawing.Point(272, 151);
            this.LoginPanel.Name = "LoginPanel";
            this.LoginPanel.Size = new System.Drawing.Size(590, 421);
            this.LoginPanel.TabIndex = 8;
            // 
            // LoginHeaderLabel
            // 
            this.LoginHeaderLabel.AutoSize = true;
            this.LoginHeaderLabel.Font = new System.Drawing.Font("Segoe UI Symbol", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LoginHeaderLabel.Location = new System.Drawing.Point(255, 112);
            this.LoginHeaderLabel.Name = "LoginHeaderLabel";
            this.LoginHeaderLabel.Size = new System.Drawing.Size(64, 30);
            this.LoginHeaderLabel.TabIndex = 8;
            this.LoginHeaderLabel.Text = "Login";
            this.LoginHeaderLabel.TextChanged += new System.EventHandler(this.LoginHeaderLabel_TextChanged);
            this.LoginHeaderLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 617);
            this.Controls.Add(this.LoginPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.LoginPanel.ResumeLayout(false);
            this.LoginPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alunoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem professorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem matériaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem coordenadorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatórioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alunoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem professorToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem matériaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem coordenadorToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem salaToolStripMenuItem1;
        private System.Windows.Forms.Label BodyTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button LoginEntrarBtn;
        private System.Windows.Forms.TextBox LoginPasswordEntryBox;
        private System.Windows.Forms.TextBox LoginEmailEntryBox;
        private System.Windows.Forms.Panel LoginPanel;
        private System.Windows.Forms.Label LoginHeaderLabel;
    }
}

