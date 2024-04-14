
namespace Note
{
    partial class EditNoteForm
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
            this.Title = new System.Windows.Forms.Label();
            this.ainCustomTextBox1 = new AINFormControls.AINCustomTextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Location = new System.Drawing.Point(12, 37);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(61, 13);
            this.Title.TabIndex = 0;
            this.Title.Text = "Заголовок";
            // 
            // ainCustomTextBox1
            // 
            this.ainCustomTextBox1.BackColor = System.Drawing.SystemColors.Window;
            this.ainCustomTextBox1.ErrorText = "";
            this.ainCustomTextBox1.InnerText = "";
            this.ainCustomTextBox1.Location = new System.Drawing.Point(15, 53);
            this.ainCustomTextBox1.Multiline = false;
            this.ainCustomTextBox1.Name = "ainCustomTextBox1";
            this.ainCustomTextBox1.Padding = new System.Windows.Forms.Padding(3);
            this.ainCustomTextBox1.PasswordChar = '\0';
            this.ainCustomTextBox1.PlaceholderText = null;
            this.ainCustomTextBox1.Size = new System.Drawing.Size(165, 24);
            this.ainCustomTextBox1.TabIndex = 1;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 98);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(183, 126);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(71, 246);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // EditNoteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(232, 281);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.ainCustomTextBox1);
            this.Controls.Add(this.Title);
            this.Name = "EditNoteForm";
            this.Text = "EditNoteForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private AINFormControls.AINCustomTextBox ainCustomTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button1;
    }
}