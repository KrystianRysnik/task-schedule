namespace PwSW_Projekt
{
    partial class UC_AddTask
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
            this.importantNoRadio = new System.Windows.Forms.RadioButton();
            this.importantYesRadio = new System.Windows.Forms.RadioButton();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.descriptionRichTexBox = new System.Windows.Forms.RichTextBox();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.importantReqLabel = new System.Windows.Forms.Label();
            this.importantLabel = new System.Windows.Forms.Label();
            this.dateReqLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.nameReqLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.newTaskSubmitBtn = new System.Windows.Forms.Button();
            this.newTaskPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // newTaskPanel
            // 
            this.newTaskPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.newTaskPanel.AutoSize = true;
            this.newTaskPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.newTaskPanel.Controls.Add(this.importantNoRadio);
            this.newTaskPanel.Controls.Add(this.importantYesRadio);
            this.newTaskPanel.Controls.Add(this.dateTimePicker);
            this.newTaskPanel.Controls.Add(this.descriptionRichTexBox);
            this.newTaskPanel.Controls.Add(this.descriptionLabel);
            this.newTaskPanel.Controls.Add(this.importantReqLabel);
            this.newTaskPanel.Controls.Add(this.importantLabel);
            this.newTaskPanel.Controls.Add(this.dateReqLabel);
            this.newTaskPanel.Controls.Add(this.dateLabel);
            this.newTaskPanel.Controls.Add(this.nameTextBox);
            this.newTaskPanel.Controls.Add(this.nameReqLabel);
            this.newTaskPanel.Controls.Add(this.nameLabel);
            this.newTaskPanel.Controls.Add(this.newTaskSubmitBtn);
            this.newTaskPanel.Location = new System.Drawing.Point(0, 0);
            this.newTaskPanel.Name = "newTaskPanel";
            this.newTaskPanel.Size = new System.Drawing.Size(623, 450);
            this.newTaskPanel.TabIndex = 19;
            // 
            // importantNoRadio
            // 
            this.importantNoRadio.AutoSize = true;
            this.importantNoRadio.ForeColor = System.Drawing.Color.White;
            this.importantNoRadio.Location = new System.Drawing.Point(133, 210);
            this.importantNoRadio.Name = "importantNoRadio";
            this.importantNoRadio.Size = new System.Drawing.Size(43, 17);
            this.importantNoRadio.TabIndex = 19;
            this.importantNoRadio.TabStop = true;
            this.importantNoRadio.Text = "NIE";
            this.importantNoRadio.UseVisualStyleBackColor = true;
            // 
            // importantYesRadio
            // 
            this.importantYesRadio.AutoSize = true;
            this.importantYesRadio.ForeColor = System.Drawing.Color.White;
            this.importantYesRadio.Location = new System.Drawing.Point(44, 210);
            this.importantYesRadio.Name = "importantYesRadio";
            this.importantYesRadio.Size = new System.Drawing.Size(46, 17);
            this.importantYesRadio.TabIndex = 18;
            this.importantYesRadio.TabStop = true;
            this.importantYesRadio.Text = "TAK";
            this.importantYesRadio.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker.CalendarForeColor = System.Drawing.Color.White;
            this.dateTimePicker.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.dateTimePicker.CustomFormat = "dd MMMM yyyy, HH:mm";
            this.dateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker.Location = new System.Drawing.Point(43, 133);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(537, 23);
            this.dateTimePicker.TabIndex = 16;
            // 
            // descriptionRichTexBox
            // 
            this.descriptionRichTexBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.descriptionRichTexBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.descriptionRichTexBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.descriptionRichTexBox.Location = new System.Drawing.Point(43, 268);
            this.descriptionRichTexBox.MaxLength = 512;
            this.descriptionRichTexBox.Name = "descriptionRichTexBox";
            this.descriptionRichTexBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.descriptionRichTexBox.Size = new System.Drawing.Size(537, 96);
            this.descriptionRichTexBox.TabIndex = 12;
            this.descriptionRichTexBox.Text = "";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.descriptionLabel.ForeColor = System.Drawing.Color.White;
            this.descriptionLabel.Location = new System.Drawing.Point(40, 246);
            this.descriptionLabel.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(37, 17);
            this.descriptionLabel.TabIndex = 10;
            this.descriptionLabel.Text = "Opis";
            // 
            // importantReqLabel
            // 
            this.importantReqLabel.AutoSize = true;
            this.importantReqLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.importantReqLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.importantReqLabel.Location = new System.Drawing.Point(79, 179);
            this.importantReqLabel.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.importantReqLabel.Name = "importantReqLabel";
            this.importantReqLabel.Size = new System.Drawing.Size(23, 17);
            this.importantReqLabel.TabIndex = 7;
            this.importantReqLabel.Text = "(*)";
            // 
            // importantLabel
            // 
            this.importantLabel.AutoSize = true;
            this.importantLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.importantLabel.ForeColor = System.Drawing.Color.White;
            this.importantLabel.Location = new System.Drawing.Point(40, 179);
            this.importantLabel.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.importantLabel.Name = "importantLabel";
            this.importantLabel.Size = new System.Drawing.Size(39, 17);
            this.importantLabel.TabIndex = 6;
            this.importantLabel.Text = "Pilne";
            // 
            // dateReqLabel
            // 
            this.dateReqLabel.AutoSize = true;
            this.dateReqLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateReqLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.dateReqLabel.Location = new System.Drawing.Point(139, 100);
            this.dateReqLabel.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.dateReqLabel.Name = "dateReqLabel";
            this.dateReqLabel.Size = new System.Drawing.Size(23, 17);
            this.dateReqLabel.TabIndex = 4;
            this.dateReqLabel.Text = "(*)";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateLabel.ForeColor = System.Drawing.Color.White;
            this.dateLabel.Location = new System.Drawing.Point(40, 100);
            this.dateLabel.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(99, 17);
            this.dateLabel.TabIndex = 3;
            this.dateLabel.Text = "Data i godzina";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.nameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nameTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.nameTextBox.Location = new System.Drawing.Point(43, 60);
            this.nameTextBox.MaxLength = 256;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(537, 19);
            this.nameTextBox.TabIndex = 2;
            // 
            // nameReqLabel
            // 
            this.nameReqLabel.AutoSize = true;
            this.nameReqLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nameReqLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.nameReqLabel.Location = new System.Drawing.Point(90, 30);
            this.nameReqLabel.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.nameReqLabel.Name = "nameReqLabel";
            this.nameReqLabel.Size = new System.Drawing.Size(23, 17);
            this.nameReqLabel.TabIndex = 1;
            this.nameReqLabel.Text = "(*)";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nameLabel.ForeColor = System.Drawing.Color.White;
            this.nameLabel.Location = new System.Drawing.Point(40, 30);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(50, 17);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Nazwa";
            // 
            // newTaskSubmitBtn
            // 
            this.newTaskSubmitBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.newTaskSubmitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(124)))), ((int)(((byte)(209)))));
            this.newTaskSubmitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.newTaskSubmitBtn.FlatAppearance.BorderSize = 0;
            this.newTaskSubmitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newTaskSubmitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.newTaskSubmitBtn.ForeColor = System.Drawing.Color.White;
            this.newTaskSubmitBtn.Location = new System.Drawing.Point(43, 390);
            this.newTaskSubmitBtn.Name = "newTaskSubmitBtn";
            this.newTaskSubmitBtn.Size = new System.Drawing.Size(537, 36);
            this.newTaskSubmitBtn.TabIndex = 17;
            this.newTaskSubmitBtn.Text = "DODAJ ZADANIE";
            this.newTaskSubmitBtn.UseVisualStyleBackColor = false;
            this.newTaskSubmitBtn.Click += new System.EventHandler(this.newTaskSubmitBtn_Click);
            // 
            // UC_AddTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.newTaskPanel);
            this.Name = "UC_AddTask";
            this.Size = new System.Drawing.Size(623, 450);
            this.newTaskPanel.ResumeLayout(false);
            this.newTaskPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel newTaskPanel;
        private System.Windows.Forms.RadioButton importantNoRadio;
        private System.Windows.Forms.RadioButton importantYesRadio;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.RichTextBox descriptionRichTexBox;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label importantReqLabel;
        private System.Windows.Forms.Label importantLabel;
        private System.Windows.Forms.Label dateReqLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label nameReqLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Button newTaskSubmitBtn;
    }
}
