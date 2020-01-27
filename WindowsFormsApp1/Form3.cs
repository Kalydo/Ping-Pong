using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        
        public static string path = "C:/Users/ext303035/Desktop/highscoretext.txt";
      
        public Form3()
        {
            InitializeComponent();
            textBox1.Text = Convert.ToString(fmrPingPong.Punktestand);
        }
        
        public void confirmer_Click(object sender, EventArgs e)
        {
            string text;

            if (fmrPingPong.count == 0)
            {
                if (!File.Exists(path))
                {
                    text = Convert.ToString(fmrPingPong.Punktestand) + "\t " + textBox2.Text + "\t " + DateTime.Today.ToShortDateString();
                    File.WriteAllText(path, text);
                }
                text = Convert.ToString(fmrPingPong.Punktestand) + "\t " + textBox2.Text + "\t " + DateTime.Today.ToShortDateString() + Environment.NewLine;
                File.AppendAllText(path, text);

                richTextBox1.Text = File.ReadAllText(path);
                fmrPingPong.count = 1;
            }
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
