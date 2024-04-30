
namespace praktika
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TaskBtn = new System.Windows.Forms.Button();
            this.RemindBtn = new System.Windows.Forms.Button();
            this.NoteBtn = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.NotePage = new System.Windows.Forms.TabPage();
            this.NoteTable = new System.Windows.Forms.FlowLayoutPanel();
            this.NotesMenuStrip = new System.Windows.Forms.MenuStrip();
            this.RemindPage = new System.Windows.Forms.TabPage();
            this.ReminedTable = new System.Windows.Forms.FlowLayoutPanel();
            this.RemindeMenuStrip = new System.Windows.Forms.MenuStrip();
            this.TaskPage = new System.Windows.Forms.TabPage();
            this.TasksFlowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.TaskMenuStreap = new System.Windows.Forms.MenuStrip();
            this.создатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MenuPanel.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.NotePage.SuspendLayout();
            this.NotesMenuStrip.SuspendLayout();
            this.RemindPage.SuspendLayout();
            this.RemindeMenuStrip.SuspendLayout();
            this.TaskPage.SuspendLayout();
            this.TaskMenuStreap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuPanel
            // 
            this.MenuPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.MenuPanel.Controls.Add(this.UserNameLabel);
            this.MenuPanel.Controls.Add(this.pictureBox1);
            this.MenuPanel.Controls.Add(this.label1);
            this.MenuPanel.Controls.Add(this.TaskBtn);
            this.MenuPanel.Controls.Add(this.RemindBtn);
            this.MenuPanel.Controls.Add(this.NoteBtn);
            this.MenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuPanel.Location = new System.Drawing.Point(0, 0);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(169, 450);
            this.MenuPanel.TabIndex = 0;
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.Font = new System.Drawing.Font("Elephant", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNameLabel.Location = new System.Drawing.Point(60, 125);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(70, 25);
            this.UserNameLabel.TabIndex = 5;
            this.UserNameLabel.Text = "label4";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "DigitalBook";
            // 
            // TaskBtn
            // 
            this.TaskBtn.Location = new System.Drawing.Point(36, 317);
            this.TaskBtn.Name = "TaskBtn";
            this.TaskBtn.Size = new System.Drawing.Size(94, 35);
            this.TaskBtn.TabIndex = 2;
            this.TaskBtn.Text = "Задачи";
            this.TaskBtn.UseVisualStyleBackColor = true;
            this.TaskBtn.Click += new System.EventHandler(this.TaskBtn_Click);
            // 
            // RemindBtn
            // 
            this.RemindBtn.Location = new System.Drawing.Point(36, 258);
            this.RemindBtn.Name = "RemindBtn";
            this.RemindBtn.Size = new System.Drawing.Size(94, 35);
            this.RemindBtn.TabIndex = 1;
            this.RemindBtn.Text = "Напоминания";
            this.RemindBtn.UseVisualStyleBackColor = true;
            this.RemindBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // NoteBtn
            // 
            this.NoteBtn.Location = new System.Drawing.Point(36, 201);
            this.NoteBtn.Name = "NoteBtn";
            this.NoteBtn.Size = new System.Drawing.Size(94, 35);
            this.NoteBtn.TabIndex = 0;
            this.NoteBtn.Text = "Заметки";
            this.NoteBtn.UseVisualStyleBackColor = true;
            this.NoteBtn.Click += new System.EventHandler(this.NoteBtn_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.NotePage);
            this.tabControl1.Controls.Add(this.RemindPage);
            this.tabControl1.Controls.Add(this.TaskPage);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tabControl1.ItemSize = new System.Drawing.Size(23, 23);
            this.tabControl1.Location = new System.Drawing.Point(169, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(631, 450);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.TabStop = false;
            // 
            // NotePage
            // 
            this.NotePage.Controls.Add(this.NoteTable);
            this.NotePage.Controls.Add(this.NotesMenuStrip);
            this.NotePage.Location = new System.Drawing.Point(4, 27);
            this.NotePage.Name = "NotePage";
            this.NotePage.Padding = new System.Windows.Forms.Padding(3);
            this.NotePage.Size = new System.Drawing.Size(623, 419);
            this.NotePage.TabIndex = 0;
            this.NotePage.Text = "tabPage1";
            this.NotePage.UseVisualStyleBackColor = true;
            // 
            // NoteTable
            // 
            this.NoteTable.AutoScroll = true;
            this.NoteTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NoteTable.Location = new System.Drawing.Point(3, 27);
            this.NoteTable.Name = "NoteTable";
            this.NoteTable.Size = new System.Drawing.Size(617, 389);
            this.NoteTable.TabIndex = 2;
            // 
            // NotesMenuStrip
            // 
            this.NotesMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьToolStripMenuItem});
            this.NotesMenuStrip.Location = new System.Drawing.Point(3, 3);
            this.NotesMenuStrip.Name = "NotesMenuStrip";
            this.NotesMenuStrip.Size = new System.Drawing.Size(617, 24);
            this.NotesMenuStrip.TabIndex = 1;
            this.NotesMenuStrip.Text = "menuStrip1";
            // 
            // RemindPage
            // 
            this.RemindPage.Controls.Add(this.ReminedTable);
            this.RemindPage.Controls.Add(this.RemindeMenuStrip);
            this.RemindPage.Location = new System.Drawing.Point(4, 27);
            this.RemindPage.Name = "RemindPage";
            this.RemindPage.Padding = new System.Windows.Forms.Padding(3);
            this.RemindPage.Size = new System.Drawing.Size(623, 419);
            this.RemindPage.TabIndex = 1;
            this.RemindPage.Text = "tabPage2";
            this.RemindPage.UseVisualStyleBackColor = true;
            // 
            // ReminedTable
            // 
            this.ReminedTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ReminedTable.Location = new System.Drawing.Point(3, 27);
            this.ReminedTable.Name = "ReminedTable";
            this.ReminedTable.Size = new System.Drawing.Size(617, 389);
            this.ReminedTable.TabIndex = 2;
            // 
            // RemindeMenuStrip
            // 
            this.RemindeMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьToolStripMenuItem1});
            this.RemindeMenuStrip.Location = new System.Drawing.Point(3, 3);
            this.RemindeMenuStrip.Name = "RemindeMenuStrip";
            this.RemindeMenuStrip.Size = new System.Drawing.Size(617, 24);
            this.RemindeMenuStrip.TabIndex = 1;
            this.RemindeMenuStrip.Text = "menuStrip1";
            // 
            // TaskPage
            // 
            this.TaskPage.Controls.Add(this.TasksFlowLayout);
            this.TaskPage.Controls.Add(this.TaskMenuStreap);
            this.TaskPage.Location = new System.Drawing.Point(4, 27);
            this.TaskPage.Name = "TaskPage";
            this.TaskPage.Padding = new System.Windows.Forms.Padding(3);
            this.TaskPage.Size = new System.Drawing.Size(623, 419);
            this.TaskPage.TabIndex = 2;
            this.TaskPage.Text = "tabPage1";
            this.TaskPage.UseVisualStyleBackColor = true;
            // 
            // TasksFlowLayout
            // 
            this.TasksFlowLayout.AutoScroll = true;
            this.TasksFlowLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TasksFlowLayout.Location = new System.Drawing.Point(3, 27);
            this.TasksFlowLayout.Name = "TasksFlowLayout";
            this.TasksFlowLayout.Size = new System.Drawing.Size(617, 389);
            this.TasksFlowLayout.TabIndex = 3;
            // 
            // TaskMenuStreap
            // 
            this.TaskMenuStreap.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.TaskMenuStreap.Location = new System.Drawing.Point(3, 3);
            this.TaskMenuStreap.Name = "TaskMenuStreap";
            this.TaskMenuStreap.Size = new System.Drawing.Size(617, 24);
            this.TaskMenuStreap.TabIndex = 2;
            this.TaskMenuStreap.Text = "menuStrip1";
            // 
            // создатьToolStripMenuItem
            // 
            this.создатьToolStripMenuItem.Image = global::praktika.Properties.Resources._1491254405_plusaddmoredetail_82972;
            this.создатьToolStripMenuItem.Name = "создатьToolStripMenuItem";
            this.создатьToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.создатьToolStripMenuItem.Text = "Создать";
            this.создатьToolStripMenuItem.Click += new System.EventHandler(this.создатьToolStripMenuItem_Click);
            // 
            // создатьToolStripMenuItem1
            // 
            this.создатьToolStripMenuItem1.Image = global::praktika.Properties.Resources._1491254405_plusaddmoredetail_82972;
            this.создатьToolStripMenuItem1.Name = "создатьToolStripMenuItem1";
            this.создатьToolStripMenuItem1.Size = new System.Drawing.Size(78, 20);
            this.создатьToolStripMenuItem1.Text = "Создать";
            this.создатьToolStripMenuItem1.Click += new System.EventHandler(this.создатьToolStripMenuItem1_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Image = global::praktika.Properties.Resources._1491254405_plusaddmoredetail_82972;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(78, 20);
            this.toolStripMenuItem1.Text = "Создать";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::praktika.Properties.Resources.avatardefault_92824__1_;
            this.pictureBox1.Location = new System.Drawing.Point(55, 74);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.MenuPanel);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.NotesMenuStrip;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MenuPanel.ResumeLayout(false);
            this.MenuPanel.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.NotePage.ResumeLayout(false);
            this.NotePage.PerformLayout();
            this.NotesMenuStrip.ResumeLayout(false);
            this.NotesMenuStrip.PerformLayout();
            this.RemindPage.ResumeLayout(false);
            this.RemindPage.PerformLayout();
            this.RemindeMenuStrip.ResumeLayout(false);
            this.RemindeMenuStrip.PerformLayout();
            this.TaskPage.ResumeLayout(false);
            this.TaskPage.PerformLayout();
            this.TaskMenuStreap.ResumeLayout(false);
            this.TaskMenuStreap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.Button NoteBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button TaskBtn;
        private System.Windows.Forms.Button RemindBtn;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage NotePage;
        private System.Windows.Forms.TabPage RemindPage;
        private System.Windows.Forms.TabPage TaskPage;
        private System.Windows.Forms.MenuStrip NotesMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem создатьToolStripMenuItem;
        public System.Windows.Forms.FlowLayoutPanel NoteTable;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label UserNameLabel;
        private System.Windows.Forms.MenuStrip RemindeMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem создатьToolStripMenuItem1;
        public System.Windows.Forms.FlowLayoutPanel ReminedTable;
        private System.Windows.Forms.MenuStrip TaskMenuStreap;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        public System.Windows.Forms.FlowLayoutPanel TasksFlowLayout;
    }
}

