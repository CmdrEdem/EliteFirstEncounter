
namespace EliteFirstEncounter.view.gui
{
    partial class SettingsWindow
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
            this.buttonApply = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.textBoxJournalPath = new System.Windows.Forms.TextBox();
            this.labelJournalPath = new System.Windows.Forms.Label();
            this.buttonValidateJournalPath = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonApply
            // 
            this.buttonApply.Location = new System.Drawing.Point(3, 60);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(75, 23);
            this.buttonApply.TabIndex = 0;
            this.buttonApply.Text = "Apply";
            this.buttonApply.UseVisualStyleBackColor = true;
            this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(84, 60);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            // 
            // textBoxJournalPath
            // 
            this.textBoxJournalPath.Location = new System.Drawing.Point(93, 9);
            this.textBoxJournalPath.Name = "textBoxJournalPath";
            this.textBoxJournalPath.Size = new System.Drawing.Size(525, 23);
            this.textBoxJournalPath.TabIndex = 2;
            // 
            // labelJournalPath
            // 
            this.labelJournalPath.AutoSize = true;
            this.labelJournalPath.Location = new System.Drawing.Point(12, 12);
            this.labelJournalPath.Name = "labelJournalPath";
            this.labelJournalPath.Size = new System.Drawing.Size(80, 15);
            this.labelJournalPath.TabIndex = 3;
            this.labelJournalPath.Text = "Journals Path:";
            // 
            // buttonValidateJournalPath
            // 
            this.buttonValidateJournalPath.Location = new System.Drawing.Point(624, 9);
            this.buttonValidateJournalPath.Name = "buttonValidateJournalPath";
            this.buttonValidateJournalPath.Size = new System.Drawing.Size(75, 23);
            this.buttonValidateJournalPath.TabIndex = 4;
            this.buttonValidateJournalPath.Text = "Validate";
            this.buttonValidateJournalPath.UseVisualStyleBackColor = true;
            // 
            // SettingsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 105);
            this.Controls.Add(this.buttonValidateJournalPath);
            this.Controls.Add(this.labelJournalPath);
            this.Controls.Add(this.textBoxJournalPath);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonApply);
            this.Name = "SettingsWindow";
            this.Text = "Settings";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonApply;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.TextBox textBoxJournalPath;
        private System.Windows.Forms.Label labelJournalPath;
        private System.Windows.Forms.Button buttonValidateJournalPath;
    }
}