
namespace praktika
{
    partial class NoteEditForm
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
            this.TitleTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.NoteTextRich = new System.Windows.Forms.RichTextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.KyrcivToolStrip = new System.Windows.Forms.ToolStripButton();
            this.BoldToolStrip = new System.Windows.Forms.ToolStripButton();
            this.UnderlineTollStrip = new System.Windows.Forms.ToolStripButton();
            this.button1 = new System.Windows.Forms.Button();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.Location = new System.Drawing.Point(10, 46);
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.Size = new System.Drawing.Size(275, 20);
            this.TitleTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Заголовок";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Текст заметки";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.NoteTextRich);
            this.panel1.Location = new System.Drawing.Point(10, 85);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(485, 235);
            this.panel1.TabIndex = 4;
            // 
            // NoteTextRich
            // 
            this.NoteTextRich.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NoteTextRich.Location = new System.Drawing.Point(0, 0);
            this.NoteTextRich.Name = "NoteTextRich";
            this.NoteTextRich.Size = new System.Drawing.Size(485, 235);
            this.NoteTextRich.TabIndex = 0;
            this.NoteTextRich.Text = "";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.KyrcivToolStrip,
            this.BoldToolStrip,
            this.UnderlineTollStrip,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(507, 25);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // KyrcivToolStrip
            // 
            this.KyrcivToolStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.KyrcivToolStrip.Image = global::praktika.Properties.Resources.italic_icon_icons_com_48282;
            this.KyrcivToolStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.KyrcivToolStrip.Name = "KyrcivToolStrip";
            this.KyrcivToolStrip.Size = new System.Drawing.Size(23, 22);
            this.KyrcivToolStrip.Text = "toolStripButton1";
            this.KyrcivToolStrip.ToolTipText = "Курсив";
            this.KyrcivToolStrip.Click += new System.EventHandler(this.KyrcivToolStrip_Click);
            // 
            // BoldToolStrip
            // 
            this.BoldToolStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BoldToolStrip.Image = global::praktika.Properties.Resources.font_icon_199162;
            this.BoldToolStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BoldToolStrip.Name = "BoldToolStrip";
            this.BoldToolStrip.Size = new System.Drawing.Size(23, 22);
            this.BoldToolStrip.Text = "toolStripButton1";
            this.BoldToolStrip.ToolTipText = "Полужирный";
            this.BoldToolStrip.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // UnderlineTollStrip
            // 
            this.UnderlineTollStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.UnderlineTollStrip.Image = global::praktika.Properties.Resources.Underline_icon_icons_com_55789;
            this.UnderlineTollStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.UnderlineTollStrip.Name = "UnderlineTollStrip";
            this.UnderlineTollStrip.Size = new System.Drawing.Size(23, 22);
            this.UnderlineTollStrip.Text = "toolStripButton2";
            this.UnderlineTollStrip.ToolTipText = "Подчеркнутый";
            this.UnderlineTollStrip.Click += new System.EventHandler(this.UnderlineTollStrip_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 330);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Подтвердить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::praktika.Properties.Resources._3844444_dot_menu_more_option_110318;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click_1);
            // 
            // NoteEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 365);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TitleTextBox);
            this.Name = "NoteEditForm";
            this.Text = "NoteEditForm";
            this.Load += new System.EventHandler(this.NoteEditForm_Load);
            this.panel1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TitleTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox NoteTextRich;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton KyrcivToolStrip;
        private System.Windows.Forms.ToolStripButton BoldToolStrip;
        private System.Windows.Forms.ToolStripButton UnderlineTollStrip;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.FontDialog fontDialog1;
    }
}