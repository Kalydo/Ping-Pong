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
    public partial class fmrPingPong : Form
    {
        int movex = 5;
        int movey = 3;
        public static int count = 0;
        public static int formcount = 0;
        public static int Punktestand = 0;
        public Form3 thirdform = new Form3();
        

        public fmrPingPong()
        {
            InitializeComponent(); 
        }

        private void tmrSpiel_Tick(object sender, EventArgs e)
        {  
            int currentX = cmdBall.Location.X;
            int currentY = cmdBall.Location.Y;
            int maxwidth = pnlSpiel.Size.Width - 20;
            int maxheight = pnlSpiel.Size.Height - 20;
            int minwidth = 0;
            int minheight = 0;

            cmdBall.Location = new Point(currentX + movex, currentY + movey);
            
            if (cmdBall.Location.X <= minwidth)
            {
                movex = -movex;
            }

            if (cmdBall.Location.X + cmdBall.Width > pictureBox1.Location.X &&
                cmdBall.Location.X + cmdBall.Width < pictureBox1.Location.X + pictureBox1.Width &&
                cmdBall.Location.Y + cmdBall.Height > pictureBox1.Location.Y &&
                cmdBall.Location.Y + cmdBall.Height < pictureBox1.Location.Y + pictureBox1.Height)
                {
                    movex = -movex;
                    Punktestand += 10;
                    txtPunkte.Text = Convert.ToString(Punktestand);
                }

            if(cmdBall.Location.Y >= maxheight || cmdBall.Location.Y <= minheight)
            {
                movey = -movey;
            }

            if (cmdBall.Location.X > pnlSpiel.Width)
            {
                if (formcount == 0)
                {
                    Form3 thirdform = new Form3();
                    //thirdform.richTextBox1.Text = File.ReadAllText(Form3.path);
                    tmrSpiel.Stop();
                    thirdform.Show();
                    formcount = 1;
                }
                tmrSpiel.Stop();
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (!tmrSpiel.Enabled)
            {
                tmrSpiel.Start();
            }
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            cmdBall.Location = new Point(5,5);
            Punktestand = 0;
            count = 0;
            formcount = 0;
            thirdform.Close();
            txtPunkte.Text = Convert.ToString(Punktestand);
        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (keyData == Keys.Down)
            {
                if (pictureBox1.Location.Y + 5 >= pnlSpiel.Size.Height - pictureBox1.Size.Height)
                {
                    return false;
                }
                else
                {
                    pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y + 5);
                    return true;
                }
            }
            else if (keyData == Keys.Up)
            {
                if (pictureBox1.Location.Y - 5 < 0)
                {
                    return false;
                }
                else
                {
                    pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y - 5);
                    return true;
                }
            }
            else if (keyData == Keys.H)
            {
                movey = -movey;
                return true;
            }
            else if (keyData == Keys.V)
            {
                movex = -movex;
                return true;
            }
            else if (keyData == Keys.P)
            {
                tmrSpiel.Stop();
                return true;
            }
            else if (keyData == Keys.S)
            {
                tmrSpiel.Start();
                return true;
            }
            else return base.ProcessDialogKey(keyData);
        }

        private void vsbSchlägerRechts_Scroll(object sender, ScrollEventArgs e)
        {
            int newY = Convert.ToInt32(352.0 / 100.0 * vsbSchlägerRechts.Value);
            int pitchery = Convert.ToInt32(60.0 / 100.0 * vsbSchlägerRechts.Value);
            pictureBox1.Location = new Point(pictureBox1.Location.X, newY - pitchery);
        }

        private void btn_control(object sender, EventArgs e) 
        {
            if (sender == btndown)
            {
                movex = -movex;
                
            }
            else if (sender == btnup)
            {
                movey = -movey;
               
            }
            else if (sender == btnleft)
            {
                tmrSpiel.Stop();
                
            }
            else if (sender == btnright)
            {
                tmrSpiel.Start();
    
            }
        }
    }
}









/*if(x == 0)
{
    cmdBall.Location = new Point(currentX + 5, currentY + 3);
    if(currentX >= 780)
    {

        if (currentY >= (schlaegermin-20) &  currentY <= (schlaegermax + 60))
        {
            Punktestand += 10;
            txtPunkte.Text = Convert.ToString(Punktestand);
            x = 1;
        }
        else
        {
            tmrSpiel.Stop();
        }

    }
    if(currentY >= 320)
    {
        x = 2;
    }


}
if (x == 2)
{
    cmdBall.Location = new Point(currentX + 5, currentY - 3);
    if (currentX >= 780)
    {
        if (currentY >= (schlaegermin - 20) & currentY <= (schlaegermax + 60))
        {
            Punktestand += 10;
            txtPunkte.Text = Convert.ToString(Punktestand);
            x = 3;
        }
        else
        {
            tmrSpiel.Stop();
        }
    }
    if (currentY <= 1)
    {
        x = 0;
    }
}
if (x == 1)
{
    cmdBall.Location = new Point(currentX - 5, currentY + 3);
    if (currentY >= 320)
    {       
        x = 3;
    }
    if (currentX <= 1)
    {
        x = 0;
    }
}

if(x == 3)
{
    cmdBall.Location = new Point(currentX - 5, currentY - 3);
    if (currentX <= 1)
    {
        x = 2;
    }
    if (currentY <= 1)
    {
        x = 1;
    }
}*/
