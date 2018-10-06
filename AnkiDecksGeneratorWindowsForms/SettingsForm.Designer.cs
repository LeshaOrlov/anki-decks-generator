namespace AnkiDecksGeneratorWindowsForms
{
    partial class SettingsForm
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
            this.SaveBtn = new System.Windows.Forms.Button();
            this.pathCacheFileTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pathCacheAudioFilesTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pathAnkiMultimediaFilesTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pathMacmillanDictionaryTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pathCambridgeDictionaryTextBox = new System.Windows.Forms.TextBox();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(516, 222);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(75, 23);
            this.SaveBtn.TabIndex = 0;
            this.SaveBtn.Text = "Сохранить";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // pathCacheFileTextBox
            // 
            this.pathCacheFileTextBox.Location = new System.Drawing.Point(144, 16);
            this.pathCacheFileTextBox.Name = "pathCacheFileTextBox";
            this.pathCacheFileTextBox.Size = new System.Drawing.Size(447, 20);
            this.pathCacheFileTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "PathCacheFile";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "PathCacheAudioFiles";
            // 
            // pathCacheAudioFilesTextBox
            // 
            this.pathCacheAudioFilesTextBox.Location = new System.Drawing.Point(144, 55);
            this.pathCacheAudioFilesTextBox.Name = "pathCacheAudioFilesTextBox";
            this.pathCacheAudioFilesTextBox.Size = new System.Drawing.Size(447, 20);
            this.pathCacheAudioFilesTextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "PathAnkiMultimediaFiles";
            // 
            // pathAnkiMultimediaFilesTextBox
            // 
            this.pathAnkiMultimediaFilesTextBox.Location = new System.Drawing.Point(144, 93);
            this.pathAnkiMultimediaFilesTextBox.Name = "pathAnkiMultimediaFilesTextBox";
            this.pathAnkiMultimediaFilesTextBox.Size = new System.Drawing.Size(447, 20);
            this.pathAnkiMultimediaFilesTextBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "PathMacmillanDictionary";
            // 
            // pathMacmillanDictionaryTextBox
            // 
            this.pathMacmillanDictionaryTextBox.Location = new System.Drawing.Point(144, 130);
            this.pathMacmillanDictionaryTextBox.Name = "pathMacmillanDictionaryTextBox";
            this.pathMacmillanDictionaryTextBox.Size = new System.Drawing.Size(447, 20);
            this.pathMacmillanDictionaryTextBox.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "PathCambridgeDictionary";
            // 
            // pathCambridgeDictionaryTextBox
            // 
            this.pathCambridgeDictionaryTextBox.Location = new System.Drawing.Point(144, 167);
            this.pathCambridgeDictionaryTextBox.Name = "pathCambridgeDictionaryTextBox";
            this.pathCambridgeDictionaryTextBox.Size = new System.Drawing.Size(447, 20);
            this.pathCambridgeDictionaryTextBox.TabIndex = 9;
            // 
            // ExitBtn
            // 
            this.ExitBtn.Location = new System.Drawing.Point(396, 222);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(75, 23);
            this.ExitBtn.TabIndex = 11;
            this.ExitBtn.Text = "Закрыть";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 268);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pathCambridgeDictionaryTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pathMacmillanDictionaryTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pathAnkiMultimediaFilesTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pathCacheAudioFilesTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pathCacheFileTextBox);
            this.Controls.Add(this.SaveBtn);
            this.Name = "SettingsForm";
            this.Text = "SettingsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.TextBox pathCacheFileTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox pathCacheAudioFilesTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox pathAnkiMultimediaFilesTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox pathMacmillanDictionaryTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox pathCambridgeDictionaryTextBox;
        private System.Windows.Forms.Button ExitBtn;
    }
}