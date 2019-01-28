namespace PwSW_Projekt
{
    partial class Form_View
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

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.activeTab = new System.Windows.Forms.Panel();
            this.abandonedTaskBtn = new System.Windows.Forms.Button();
            this.completeTasksBtn = new System.Windows.Forms.Button();
            this.currentTasksBtn = new System.Windows.Forms.Button();
            this.navigationLabel = new System.Windows.Forms.Label();
            this.newTaskBtn = new System.Windows.Forms.Button();
            this.content = new System.Windows.Forms.Panel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer
            // 
            this.splitContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.splitContainer.Panel1.Controls.Add(this.activeTab);
            this.splitContainer.Panel1.Controls.Add(this.abandonedTaskBtn);
            this.splitContainer.Panel1.Controls.Add(this.completeTasksBtn);
            this.splitContainer.Panel1.Controls.Add(this.currentTasksBtn);
            this.splitContainer.Panel1.Controls.Add(this.navigationLabel);
            this.splitContainer.Panel1.Controls.Add(this.newTaskBtn);
            this.splitContainer.Panel1.Padding = new System.Windows.Forms.Padding(10);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.splitContainer.Panel2.Controls.Add(this.content);
            this.splitContainer.Size = new System.Drawing.Size(800, 450);
            this.splitContainer.SplitterDistance = 175;
            this.splitContainer.SplitterWidth = 2;
            this.splitContainer.TabIndex = 0;
            // 
            // activeTab
            // 
            this.activeTab.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.activeTab.BackColor = System.Drawing.Color.White;
            this.activeTab.Location = new System.Drawing.Point(171, 87);
            this.activeTab.Name = "activeTab";
            this.activeTab.Size = new System.Drawing.Size(4, 32);
            this.activeTab.TabIndex = 5;
            // 
            // abandonedTaskBtn
            // 
            this.abandonedTaskBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.abandonedTaskBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.abandonedTaskBtn.FlatAppearance.BorderSize = 0;
            this.abandonedTaskBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.abandonedTaskBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.abandonedTaskBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.abandonedTaskBtn.Location = new System.Drawing.Point(0, 151);
            this.abandonedTaskBtn.Name = "abandonedTaskBtn";
            this.abandonedTaskBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.abandonedTaskBtn.Size = new System.Drawing.Size(174, 32);
            this.abandonedTaskBtn.TabIndex = 4;
            this.abandonedTaskBtn.Text = "Porzucone zadania";
            this.abandonedTaskBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.abandonedTaskBtn.UseVisualStyleBackColor = true;
            this.abandonedTaskBtn.Click += new System.EventHandler(this.abandonedTaskBtn_Click);
            // 
            // completeTasksBtn
            // 
            this.completeTasksBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.completeTasksBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.completeTasksBtn.FlatAppearance.BorderSize = 0;
            this.completeTasksBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.completeTasksBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.completeTasksBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.completeTasksBtn.Location = new System.Drawing.Point(0, 119);
            this.completeTasksBtn.Name = "completeTasksBtn";
            this.completeTasksBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.completeTasksBtn.Size = new System.Drawing.Size(174, 32);
            this.completeTasksBtn.TabIndex = 3;
            this.completeTasksBtn.Text = "Zakończone zadania";
            this.completeTasksBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.completeTasksBtn.UseVisualStyleBackColor = true;
            this.completeTasksBtn.Click += new System.EventHandler(this.completeTasksBtn_Click);
            // 
            // currentTasksBtn
            // 
            this.currentTasksBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.currentTasksBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.currentTasksBtn.FlatAppearance.BorderSize = 0;
            this.currentTasksBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.currentTasksBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.currentTasksBtn.ForeColor = System.Drawing.Color.White;
            this.currentTasksBtn.Location = new System.Drawing.Point(0, 87);
            this.currentTasksBtn.Name = "currentTasksBtn";
            this.currentTasksBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.currentTasksBtn.Size = new System.Drawing.Size(174, 32);
            this.currentTasksBtn.TabIndex = 2;
            this.currentTasksBtn.Text = "Aktualne zadania";
            this.currentTasksBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.currentTasksBtn.UseVisualStyleBackColor = true;
            this.currentTasksBtn.Click += new System.EventHandler(this.currentTasksBtn_Click);
            // 
            // navigationLabel
            // 
            this.navigationLabel.AutoSize = true;
            this.navigationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)), true);
            this.navigationLabel.ForeColor = System.Drawing.Color.White;
            this.navigationLabel.Location = new System.Drawing.Point(14, 14);
            this.navigationLabel.Name = "navigationLabel";
            this.navigationLabel.Size = new System.Drawing.Size(114, 20);
            this.navigationLabel.TabIndex = 0;
            this.navigationLabel.Text = "NAWIGACJA";
            // 
            // newTaskBtn
            // 
            this.newTaskBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.newTaskBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.newTaskBtn.FlatAppearance.BorderSize = 0;
            this.newTaskBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newTaskBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.newTaskBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.newTaskBtn.Location = new System.Drawing.Point(0, 55);
            this.newTaskBtn.Name = "newTaskBtn";
            this.newTaskBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.newTaskBtn.Size = new System.Drawing.Size(172, 32);
            this.newTaskBtn.TabIndex = 1;
            this.newTaskBtn.Text = "Nowe zadanie";
            this.newTaskBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.newTaskBtn.UseCompatibleTextRendering = true;
            this.newTaskBtn.UseVisualStyleBackColor = true;
            this.newTaskBtn.Click += new System.EventHandler(this.newTaskBtn_Click);
            // 
            // content
            // 
            this.content.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.content.Location = new System.Drawing.Point(3, 3);
            this.content.Name = "content";
            this.content.Size = new System.Drawing.Size(621, 447);
            this.content.TabIndex = 0;
            // 
            // Form_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer);
            this.Name = "Form_View";
            this.Text = "Form1";
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel1.PerformLayout();
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.Button completeTasksBtn;
        private System.Windows.Forms.Button currentTasksBtn;
        private System.Windows.Forms.Label navigationLabel;
        private System.Windows.Forms.Button abandonedTaskBtn;
        private System.Windows.Forms.Button newTaskBtn;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel content;
        private System.Windows.Forms.Panel activeTab;
    }
}

