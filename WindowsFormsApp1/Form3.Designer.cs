namespace WindowsFormsApp1
{
    partial class Form3
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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.confirmer = new System.Windows.Forms.Button();
            this.Vorname = new System.Windows.Forms.Label();
            this.Nachname = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnback = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(137, 79);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(92, 22);
            this.textBox2.TabIndex = 1;
            // 
            // confirmer
            // 
            this.confirmer.Location = new System.Drawing.Point(246, 72);
            this.confirmer.Name = "confirmer";
            this.confirmer.Size = new System.Drawing.Size(102, 36);
            this.confirmer.TabIndex = 4;
            this.confirmer.Text = "Bestätigen";
            this.confirmer.UseVisualStyleBackColor = false;
            this.confirmer.Click += new System.EventHandler(this.confirmer_Click);
            // 
            // Vorname
            // 
            this.Vorname.AutoSize = true;
            this.Vorname.Location = new System.Drawing.Point(12, 27);
            this.Vorname.Name = "Vorname";
            this.Vorname.Size = new System.Drawing.Size(56, 17);
            this.Vorname.TabIndex = 2;
            this.Vorname.Text = "Punkte:";
            // 
            // Nachname
            // 
            this.Nachname.AutoSize = true;
            this.Nachname.Location = new System.Drawing.Point(134, 27);
            this.Nachname.Name = "Nachname";
            this.Nachname.Size = new System.Drawing.Size(49, 17);
            this.Nachname.TabIndex = 3;
            this.Nachname.Text = "Name:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(15, 79);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(53, 22);
            this.textBox1.TabIndex = 5;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 126);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(347, 182);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = "";
            // 
            // btnback
            // 
            this.btnback.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnback.Location = new System.Drawing.Point(284, 322);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(75, 23);
            this.btnback.TabIndex = 7;
            this.btnback.Text = "Zurück";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 357);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.confirmer);
            this.Controls.Add(this.Nachname);
            this.Controls.Add(this.Vorname);
            this.Controls.Add(this.textBox2);
            this.Name = "Form3";
            this.Text = "Game Over!!!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button confirmer;
        private System.Windows.Forms.Label Vorname;
        private System.Windows.Forms.Label Nachname;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnback;
        public System.Windows.Forms.RichTextBox richTextBox1;
    }
}