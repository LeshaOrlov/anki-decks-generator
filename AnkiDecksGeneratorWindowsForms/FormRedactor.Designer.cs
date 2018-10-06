namespace AnkiDecksGeneratorWindowsForms
{
    partial class FormRedactor
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
            this.button1 = new System.Windows.Forms.Button();
            this.ExempBox = new System.Windows.Forms.TextBox();
            this.TrasliteBox = new System.Windows.Forms.TextBox();
            this.TransBox = new System.Windows.Forms.TextBox();
            this.WordBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.PartOfSpeechBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 363);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ExempBox
            // 
            this.ExempBox.Location = new System.Drawing.Point(124, 201);
            this.ExempBox.Multiline = true;
            this.ExempBox.Name = "ExempBox";
            this.ExempBox.Size = new System.Drawing.Size(243, 138);
            this.ExempBox.TabIndex = 17;
            // 
            // TrasliteBox
            // 
            this.TrasliteBox.Location = new System.Drawing.Point(124, 111);
            this.TrasliteBox.Name = "TrasliteBox";
            this.TrasliteBox.Size = new System.Drawing.Size(243, 20);
            this.TrasliteBox.TabIndex = 16;
            // 
            // TransBox
            // 
            this.TransBox.Location = new System.Drawing.Point(124, 78);
            this.TransBox.Name = "TransBox";
            this.TransBox.Size = new System.Drawing.Size(243, 20);
            this.TransBox.TabIndex = 15;
            // 
            // WordBox
            // 
            this.WordBox.Location = new System.Drawing.Point(124, 17);
            this.WordBox.Name = "WordBox";
            this.WordBox.Size = new System.Drawing.Size(243, 20);
            this.WordBox.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Примеры";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Перевод";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Транскрипция";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Слово";
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(105, 363);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(75, 23);
            this.btnModify.TabIndex = 18;
            this.btnModify.Text = "Modify";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(195, 363);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 19;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(292, 363);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 20;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // PartOfSpeechBox
            // 
            this.PartOfSpeechBox.Location = new System.Drawing.Point(124, 49);
            this.PartOfSpeechBox.Name = "PartOfSpeechBox";
            this.PartOfSpeechBox.Size = new System.Drawing.Size(243, 20);
            this.PartOfSpeechBox.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Часть речи";
            // 
            // FormRedactor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 398);
            this.Controls.Add(this.PartOfSpeechBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.ExempBox);
            this.Controls.Add(this.TrasliteBox);
            this.Controls.Add(this.TransBox);
            this.Controls.Add(this.WordBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Name = "FormRedactor";
            this.Text = "FormRedactor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox ExempBox;
        private System.Windows.Forms.TextBox TrasliteBox;
        private System.Windows.Forms.TextBox TransBox;
        private System.Windows.Forms.TextBox WordBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox PartOfSpeechBox;
        private System.Windows.Forms.Label label1;
    }
}