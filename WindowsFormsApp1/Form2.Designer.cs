namespace WindowsFormsApp1
{
    partial class Form2
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
            this.highscores = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // highscores
            // 
            this.highscores.Location = new System.Drawing.Point(-1, 2);
            this.highscores.Name = "highscores";
            this.highscores.Size = new System.Drawing.Size(265, 170);
            this.highscores.TabIndex = 0;
            this.highscores.Text = "";
            this.highscores.TextChanged += new System.EventHandler(this.highscores_TextChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 324);
            this.Controls.Add(this.highscores);
            this.Name = "Form2";
            this.Text = "Highscore";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox highscores;
    }
}