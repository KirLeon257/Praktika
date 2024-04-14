
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
            this.label1 = new System.Windows.Forms.Label();
            this.TaskBtn = new System.Windows.Forms.Button();
            this.RemindBtn = new System.Windows.Forms.Button();
            this.NoteBtn = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.NotePage = new System.Windows.Forms.TabPage();
            this.NoteTable = new System.Windows.Forms.FlowLayoutPanel();
            this.NotesMenuStrip1 = new System.Windows.Forms.MenuStrip();
            this.создатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RemindPage = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.TaskPage = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.MenuPanel.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.NotePage.SuspendLayout();
            this.NotesMenuStrip1.SuspendLayout();
            this.RemindPage.SuspendLayout();
            this.TaskPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuPanel
            // 
            this.MenuPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
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
            this.TaskBtn.Location = new System.Drawing.Point(37, 252);
            this.TaskBtn.Name = "TaskBtn";
            this.TaskBtn.Size = new System.Drawing.Size(94, 35);
            this.TaskBtn.TabIndex = 2;
            this.TaskBtn.Text = "Задачи";
            this.TaskBtn.UseVisualStyleBackColor = true;
            this.TaskBtn.Click += new System.EventHandler(this.TaskBtn_Click);
            // 
            // RemindBtn
            // 
            this.RemindBtn.Location = new System.Drawing.Point(37, 193);
            this.RemindBtn.Name = "RemindBtn";
            this.RemindBtn.Size = new System.Drawing.Size(94, 35);
            this.RemindBtn.TabIndex = 1;
            this.RemindBtn.Text = "Напоминания";
            this.RemindBtn.UseVisualStyleBackColor = true;
            this.RemindBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // NoteBtn
            // 
            this.NoteBtn.Location = new System.Drawing.Point(37, 136);
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
            this.NotePage.Controls.Add(this.NotesMenuStrip1);
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
            // NotesMenuStrip1
            // 
            this.NotesMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьToolStripMenuItem});
            this.NotesMenuStrip1.Location = new System.Drawing.Point(3, 3);
            this.NotesMenuStrip1.Name = "NotesMenuStrip1";
            this.NotesMenuStrip1.Size = new System.Drawing.Size(617, 24);
            this.NotesMenuStrip1.TabIndex = 1;
            this.NotesMenuStrip1.Text = "menuStrip1";
            // 
            // создатьToolStripMenuItem
            // 
            this.создатьToolStripMenuItem.Image = global::praktika.Properties.Resources._1491254405_plusaddmoredetail_82972;
            this.создатьToolStripMenuItem.Name = "создатьToolStripMenuItem";
            this.создатьToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.создатьToolStripMenuItem.Text = "Создать";
            this.создатьToolStripMenuItem.Click += new System.EventHandler(this.создатьToolStripMenuItem_Click);
            // 
            // RemindPage
            // 
            this.RemindPage.Controls.Add(this.label2);
            this.RemindPage.Location = new System.Drawing.Point(4, 27);
            this.RemindPage.Name = "RemindPage";
            this.RemindPage.Padding = new System.Windows.Forms.Padding(3);
            this.RemindPage.Size = new System.Drawing.Size(623, 419);
            this.RemindPage.TabIndex = 1;
            this.RemindPage.Text = "tabPage2";
            this.RemindPage.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(218, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Напоминания";
            // 
            // TaskPage
            // 
            this.TaskPage.Controls.Add(this.label3);
            this.TaskPage.Location = new System.Drawing.Point(4, 27);
            this.TaskPage.Name = "TaskPage";
            this.TaskPage.Padding = new System.Windows.Forms.Padding(3);
            this.TaskPage.Size = new System.Drawing.Size(623, 419);
            this.TaskPage.TabIndex = 2;
            this.TaskPage.Text = "tabPage1";
            this.TaskPage.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(271, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Задачи";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.MenuPanel);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.NotesMenuStrip1;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MenuPanel.ResumeLayout(false);
            this.MenuPanel.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.NotePage.ResumeLayout(false);
            this.NotePage.PerformLayout();
            this.NotesMenuStrip1.ResumeLayout(false);
            this.NotesMenuStrip1.PerformLayout();
            this.RemindPage.ResumeLayout(false);
            this.RemindPage.PerformLayout();
            this.TaskPage.ResumeLayout(false);
            this.TaskPage.PerformLayout();
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
        private System.Windows.Forms.MenuStrip NotesMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem создатьToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.FlowLayoutPanel NoteTable;
    }
}

