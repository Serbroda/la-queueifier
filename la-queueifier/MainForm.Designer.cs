namespace la_queueifier
{
    partial class MainForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbQueueNumber = new System.Windows.Forms.TextBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.grpOptions = new System.Windows.Forms.GroupBox();
            this.nudQueueReaches = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.ckSendNotification = new System.Windows.Forms.CheckBox();
            this.tbTelegramDestinationId = new System.Windows.Forms.TextBox();
            this.tbTelegramApiToken = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbQueuePrefix = new System.Windows.Forms.TextBox();
            this.grpOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQueueReaches)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStart.Location = new System.Drawing.Point(339, 250);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Queue number: ";
            // 
            // tbQueueNumber
            // 
            this.tbQueueNumber.Location = new System.Drawing.Point(155, 19);
            this.tbQueueNumber.Name = "tbQueueNumber";
            this.tbQueueNumber.ReadOnly = true;
            this.tbQueueNumber.Size = new System.Drawing.Size(136, 20);
            this.tbQueueNumber.TabIndex = 2;
            this.tbQueueNumber.Text = "??";
            this.tbQueueNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnStop
            // 
            this.btnStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStop.Enabled = false;
            this.btnStop.Location = new System.Drawing.Point(420, 250);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 3;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // grpOptions
            // 
            this.grpOptions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpOptions.Controls.Add(this.tbQueuePrefix);
            this.grpOptions.Controls.Add(this.label5);
            this.grpOptions.Controls.Add(this.nudQueueReaches);
            this.grpOptions.Controls.Add(this.label4);
            this.grpOptions.Controls.Add(this.ckSendNotification);
            this.grpOptions.Controls.Add(this.tbTelegramDestinationId);
            this.grpOptions.Controls.Add(this.tbTelegramApiToken);
            this.grpOptions.Controls.Add(this.label3);
            this.grpOptions.Controls.Add(this.label2);
            this.grpOptions.Location = new System.Drawing.Point(15, 54);
            this.grpOptions.Name = "grpOptions";
            this.grpOptions.Size = new System.Drawing.Size(480, 190);
            this.grpOptions.TabIndex = 4;
            this.grpOptions.TabStop = false;
            this.grpOptions.Text = "Options";
            // 
            // nudQueueReaches
            // 
            this.nudQueueReaches.Location = new System.Drawing.Point(138, 135);
            this.nudQueueReaches.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudQueueReaches.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudQueueReaches.Name = "nudQueueReaches";
            this.nudQueueReaches.Size = new System.Drawing.Size(135, 20);
            this.nudQueueReaches.TabIndex = 14;
            this.nudQueueReaches.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudQueueReaches.Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Send queue reaches:";
            // 
            // ckSendNotification
            // 
            this.ckSendNotification.AutoSize = true;
            this.ckSendNotification.Location = new System.Drawing.Point(6, 61);
            this.ckSendNotification.Name = "ckSendNotification";
            this.ckSendNotification.Size = new System.Drawing.Size(105, 17);
            this.ckSendNotification.TabIndex = 12;
            this.ckSendNotification.Text = "Send notification";
            this.ckSendNotification.UseVisualStyleBackColor = true;
            this.ckSendNotification.CheckedChanged += new System.EventHandler(this.ckSendNotification_CheckedChanged);
            // 
            // tbTelegramDestinationId
            // 
            this.tbTelegramDestinationId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTelegramDestinationId.Location = new System.Drawing.Point(138, 108);
            this.tbTelegramDestinationId.Name = "tbTelegramDestinationId";
            this.tbTelegramDestinationId.Size = new System.Drawing.Size(333, 20);
            this.tbTelegramDestinationId.TabIndex = 11;
            // 
            // tbTelegramApiToken
            // 
            this.tbTelegramApiToken.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTelegramApiToken.Location = new System.Drawing.Point(138, 82);
            this.tbTelegramApiToken.Name = "tbTelegramApiToken";
            this.tbTelegramApiToken.Size = new System.Drawing.Size(333, 20);
            this.tbTelegramApiToken.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Telegram Destination ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Telegram Token:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Queue text prefix:";
            // 
            // tbQueuePrefix
            // 
            this.tbQueuePrefix.Location = new System.Drawing.Point(138, 26);
            this.tbQueuePrefix.Name = "tbQueuePrefix";
            this.tbQueuePrefix.Size = new System.Drawing.Size(333, 20);
            this.tbQueuePrefix.TabIndex = 16;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 285);
            this.Controls.Add(this.grpOptions);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.tbQueueNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStart);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Lost Ark Queueifier";
            this.grpOptions.ResumeLayout(false);
            this.grpOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQueueReaches)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbQueueNumber;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.GroupBox grpOptions;
        private System.Windows.Forms.TextBox tbTelegramDestinationId;
        private System.Windows.Forms.TextBox tbTelegramApiToken;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox ckSendNotification;
        private System.Windows.Forms.NumericUpDown nudQueueReaches;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbQueuePrefix;
        private System.Windows.Forms.Label label5;
    }
}

