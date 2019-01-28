namespace PwSW_Projekt
{
    partial class UC_AddComment
    {
        /// <summary> 
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.newTaskPanel = new System.Windows.Forms.Panel();
            this.commentRichTextBox = new System.Windows.Forms.RichTextBox();
            this.commentLabel = new System.Windows.Forms.Label();
            this.removeTaskSubmitBtn = new System.Windows.Forms.Button();
            this.newTaskPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // newTaskPanel
            // 
            this.newTaskPanel.AutoSize = true;
            this.newTaskPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.newTaskPanel.Controls.Add(this.commentRichTextBox);
            this.newTaskPanel.Controls.Add(this.commentLabel);
            this.newTaskPanel.Controls.Add(this.removeTaskSubmitBtn);
            this.newTaskPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.newTaskPanel.Location = new System.Drawing.Point(0, 0);
            this.newTaskPanel.Name = "newTaskPanel";
            this.newTaskPanel.Size = new System.Drawing.Size(623, 330);
            this.newTaskPanel.TabIndex = 20;
            // 
            // commentRichTextBox
            // 
            this.commentRichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.commentRichTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.commentRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.commentRichTextBox.ForeColor = System.Drawing.Color.White;
            this.commentRichTextBox.Location = new System.Drawing.Point(43, 60);
            this.commentRichTextBox.Name = "commentRichTextBox";
            this.commentRichTextBox.Size = new System.Drawing.Size(533, 164);
            this.commentRichTextBox.TabIndex = 18;
            this.commentRichTextBox.Text = "";
            // 
            // commentLabel
            // 
            this.commentLabel.AutoSize = true;
            this.commentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.commentLabel.ForeColor = System.Drawing.Color.White;
            this.commentLabel.Location = new System.Drawing.Point(40, 30);
            this.commentLabel.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.commentLabel.Name = "commentLabel";
            this.commentLabel.Size = new System.Drawing.Size(76, 17);
            this.commentLabel.TabIndex = 0;
            this.commentLabel.Text = "Komentarz";
            // 
            // removeTaskSubmitBtn
            // 
            this.removeTaskSubmitBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.removeTaskSubmitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(83)))), ((int)(((byte)(70)))));
            this.removeTaskSubmitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.removeTaskSubmitBtn.FlatAppearance.BorderSize = 0;
            this.removeTaskSubmitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeTaskSubmitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.removeTaskSubmitBtn.ForeColor = System.Drawing.Color.White;
            this.removeTaskSubmitBtn.Location = new System.Drawing.Point(43, 250);
            this.removeTaskSubmitBtn.Name = "removeTaskSubmitBtn";
            this.removeTaskSubmitBtn.Size = new System.Drawing.Size(533, 36);
            this.removeTaskSubmitBtn.TabIndex = 17;
            this.removeTaskSubmitBtn.Text = "PORZUĆ ZADANIE";
            this.removeTaskSubmitBtn.UseVisualStyleBackColor = false;
            this.removeTaskSubmitBtn.Click += new System.EventHandler(this.removeTaskSubmitBtn_Click);
            // 
            // UC_AddComment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.newTaskPanel);
            this.Name = "UC_AddComment";
            this.Size = new System.Drawing.Size(623, 330);
            this.newTaskPanel.ResumeLayout(false);
            this.newTaskPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel newTaskPanel;
        private System.Windows.Forms.Label commentLabel;
        private System.Windows.Forms.Button removeTaskSubmitBtn;
        private System.Windows.Forms.RichTextBox commentRichTextBox;
    }
}
