namespace WindowsFormsApp1
{
    partial class fmrPingPong
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
            this.components = new System.ComponentModel.Container();
            this.cmdBall = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.tmrSpiel = new System.Windows.Forms.Timer(this.components);
            this.pnlSpiel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.vsbSchlägerRechts = new System.Windows.Forms.VScrollBar();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPunkte = new System.Windows.Forms.TextBox();
            this.btnreset = new System.Windows.Forms.Button();
            this.btnup = new System.Windows.Forms.Button();
            this.btnright = new System.Windows.Forms.Button();
            this.btnleft = new System.Windows.Forms.Button();
            this.btndown = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.rdbtn1 = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlSpiel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdBall
            // 
            this.cmdBall.BackColor = System.Drawing.SystemColors.Desktop;
            this.cmdBall.Location = new System.Drawing.Point(5, 5);
            this.cmdBall.Name = "cmdBall";
            this.cmdBall.Size = new System.Drawing.Size(25, 23);
            this.cmdBall.TabIndex = 0;
            this.cmdBall.UseVisualStyleBackColor = false;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(12, 475);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(127, 44);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Spiel Starten";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // tmrSpiel
            // 
            this.tmrSpiel.Interval = 2;
            this.tmrSpiel.Tick += new System.EventHandler(this.tmrSpiel_Tick);
            // 
            // pnlSpiel
            // 
            this.pnlSpiel.BackColor = System.Drawing.Color.SeaGreen;
            this.pnlSpiel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSpiel.Controls.Add(this.pictureBox1);
            this.pnlSpiel.Controls.Add(this.cmdBall);
            this.pnlSpiel.Location = new System.Drawing.Point(12, 54);
            this.pnlSpiel.Name = "pnlSpiel";
            this.pnlSpiel.Size = new System.Drawing.Size(802, 352);
            this.pnlSpiel.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Location = new System.Drawing.Point(791, 79);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(6, 60);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // vsbSchlägerRechts
            // 
            this.vsbSchlägerRechts.Location = new System.Drawing.Point(817, 33);
            this.vsbSchlägerRechts.Maximum = 109;
            this.vsbSchlägerRechts.Name = "vsbSchlägerRechts";
            this.vsbSchlägerRechts.Size = new System.Drawing.Size(26, 391);
            this.vsbSchlägerRechts.TabIndex = 1;
            this.vsbSchlägerRechts.Value = 50;
            this.vsbSchlägerRechts.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vsbSchlägerRechts_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(60, 434);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Punkte:";
            // 
            // txtPunkte
            // 
            this.txtPunkte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtPunkte.Location = new System.Drawing.Point(159, 434);
            this.txtPunkte.Name = "txtPunkte";
            this.txtPunkte.Size = new System.Drawing.Size(50, 30);
            this.txtPunkte.TabIndex = 4;
            this.txtPunkte.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnreset
            // 
            this.btnreset.Location = new System.Drawing.Point(12, 536);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(127, 43);
            this.btnreset.TabIndex = 4;
            this.btnreset.Text = "Reset";
            this.btnreset.UseVisualStyleBackColor = true;
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // btnup
            // 
            this.btnup.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnup.Image = global::WindowsFormsApp1.Properties.Resources.icons8_chevron_up_48;
            this.btnup.Location = new System.Drawing.Point(953, 148);
            this.btnup.Name = "btnup";
            this.btnup.Size = new System.Drawing.Size(61, 60);
            this.btnup.TabIndex = 5;
            this.btnup.UseVisualStyleBackColor = false;
            this.btnup.Click += new System.EventHandler(this.btn_control);
            // 
            // btnright
            // 
            this.btnright.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnright.Image = global::WindowsFormsApp1.Properties.Resources.icons8_chevron_right_48;
            this.btnright.Location = new System.Drawing.Point(1000, 226);
            this.btnright.Name = "btnright";
            this.btnright.Size = new System.Drawing.Size(46, 52);
            this.btnright.TabIndex = 6;
            this.btnright.UseVisualStyleBackColor = false;
            this.btnright.Click += new System.EventHandler(this.btn_control);
            // 
            // btnleft
            // 
            this.btnleft.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnleft.Image = global::WindowsFormsApp1.Properties.Resources.icons8_chevron_left_48;
            this.btnleft.Location = new System.Drawing.Point(926, 226);
            this.btnleft.Name = "btnleft";
            this.btnleft.Size = new System.Drawing.Size(44, 52);
            this.btnleft.TabIndex = 7;
            this.btnleft.UseVisualStyleBackColor = false;
            this.btnleft.Click += new System.EventHandler(this.btn_control);
            // 
            // btndown
            // 
            this.btndown.BackColor = System.Drawing.SystemColors.Desktop;
            this.btndown.Image = global::WindowsFormsApp1.Properties.Resources.icons8_chevron_down_48;
            this.btndown.Location = new System.Drawing.Point(953, 289);
            this.btndown.Name = "btndown";
            this.btndown.Size = new System.Drawing.Size(61, 59);
            this.btndown.TabIndex = 8;
            this.btndown.UseVisualStyleBackColor = false;
            this.btndown.Click += new System.EventHandler(this.btn_control);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label2.Location = new System.Drawing.Point(156, 475);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(253, 102);
            this.label2.TabIndex = 9;
            this.label2.Text = "Tastatursteuerung\n\rTaste\n\r  H  horizontale Flugrichtung umkehren\n\r  V  vertikale " +
    "Flugrichung umkehren\n\r  P  Spiel pausieren\n\r  S  Spiel weiterlaufen lassen";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(45, 23);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(110, 21);
            this.radioButton1.TabIndex = 10;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // rdbtn1
            // 
            this.rdbtn1.AutoSize = true;
            this.rdbtn1.Location = new System.Drawing.Point(45, 61);
            this.rdbtn1.Name = "rdbtn1";
            this.rdbtn1.Size = new System.Drawing.Size(17, 16);
            this.rdbtn1.TabIndex = 11;
            this.rdbtn1.TabStop = true;
            this.rdbtn1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Controls.Add(this.rdbtn1);
            this.panel1.Location = new System.Drawing.Point(926, 475);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 12;
            // 
            // fmrPingPong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1147, 591);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btndown);
            this.Controls.Add(this.btnleft);
            this.Controls.Add(this.btnright);
            this.Controls.Add(this.btnup);
            this.Controls.Add(this.btnreset);
            this.Controls.Add(this.txtPunkte);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.vsbSchlägerRechts);
            this.Controls.Add(this.pnlSpiel);
            this.Controls.Add(this.btnStart);
            this.Name = "fmrPingPong";
            this.RightToLeftLayout = true;
            this.Text = "PingPong-Spiel";
            this.pnlSpiel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdBall;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Timer tmrSpiel;
        private System.Windows.Forms.Panel pnlSpiel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.VScrollBar vsbSchlägerRechts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPunkte;
        private System.Windows.Forms.Button btnreset;
        private System.Windows.Forms.Button btnup;
        private System.Windows.Forms.Button btnright;
        private System.Windows.Forms.Button btnleft;
        private System.Windows.Forms.Button btndown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton rdbtn1;
        private System.Windows.Forms.Panel panel1;
    }
}

