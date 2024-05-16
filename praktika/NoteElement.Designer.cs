
namespace praktika
{
    partial class NoteElement
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.TitleLable = new System.Windows.Forms.Label();
            this.OptionMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.изменитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TextNoteRichTextBox = new System.Windows.Forms.RichTextBox();
            this.OptionMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // TitleLable
            // 
            this.TitleLable.AutoEllipsis = true;
            this.TitleLable.AutoSize = true;
            this.TitleLable.BackColor = System.Drawing.Color.Aquamarine;
            this.TitleLable.ContextMenuStrip = this.OptionMenuStrip;
            this.TitleLable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TitleLable.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.TitleLable.Font = new System.Drawing.Font("Perpetua", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLable.Location = new System.Drawing.Point(3, 13);
            this.TitleLable.Name = "TitleLable";
            this.TitleLable.Size = new System.Drawing.Size(72, 28);
            this.TitleLable.TabIndex = 0;
            this.TitleLable.Text = "label1";
            this.TitleLable.DoubleClick += new System.EventHandler(this.NoteElement_DoubleClick);
            // 
            // OptionMenuStrip
            // 
            this.OptionMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.изменитьToolStripMenuItem,
            this.удалитьToolStripMenuItem});
            this.OptionMenuStrip.Name = "contextMenuStrip1";
            this.OptionMenuStrip.Size = new System.Drawing.Size(129, 48);
            // 
            // изменитьToolStripMenuItem
            // 
            this.изменитьToolStripMenuItem.Name = "изменитьToolStripMenuItem";
            this.изменитьToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.изменитьToolStripMenuItem.Text = "Изменить";
            this.изменитьToolStripMenuItem.Click += new System.EventHandler(this.NoteElement_DoubleClick);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.удалитьToolStripMenuItem_Click);
            // 
            // TextNoteRichTextBox
            // 
            this.TextNoteRichTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TextNoteRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextNoteRichTextBox.ContextMenuStrip = this.OptionMenuStrip;
            this.TextNoteRichTextBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TextNoteRichTextBox.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextNoteRichTextBox.Location = new System.Drawing.Point(8, 58);
            this.TextNoteRichTextBox.Name = "TextNoteRichTextBox";
            this.TextNoteRichTextBox.ReadOnly = true;
            this.TextNoteRichTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.TextNoteRichTextBox.Size = new System.Drawing.Size(218, 72);
            this.TextNoteRichTextBox.TabIndex = 1;
            this.TextNoteRichTextBox.Text = "";
            this.TextNoteRichTextBox.ZoomFactor = 1.2F;
            this.TextNoteRichTextBox.DoubleClick += new System.EventHandler(this.NoteElement_DoubleClick);
            // 
            // NoteElement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ContextMenuStrip = this.OptionMenuStrip;
            this.Controls.Add(this.TextNoteRichTextBox);
            this.Controls.Add(this.TitleLable);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DoubleBuffered = true;
            this.Name = "NoteElement";
            this.Size = new System.Drawing.Size(237, 144);
            this.DoubleClick += new System.EventHandler(this.NoteElement_DoubleClick);
            this.OptionMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label TitleLable;
        private System.Windows.Forms.ContextMenuStrip OptionMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem изменитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        public System.Windows.Forms.RichTextBox TextNoteRichTextBox;
    }
}
