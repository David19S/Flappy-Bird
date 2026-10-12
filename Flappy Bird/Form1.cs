using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flappy_Bird
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rnd = new Random();
        int ok = 0;
        int scor = 0;
        int k = 0;
        int okk;
        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox2.Left -= 15;
            pictureBox3.Left -= 15;
            if (pictureBox2.Left < -100)
            {
                Random rnd = new Random();
                
                pictureBox2.Left = 530;
                pictureBox3.Left = 530;
                int y = rnd.Next(80, 250);
                pictureBox2.Top = -1 * y;
                pictureBox3.Top = pictureBox2.Top + 430;
                k = 0;
            }
            if(pictureBox1.Left > pictureBox2.Left + 100 && k==0)
            {
                scor++;
                label1.Text = "Score: " + scor;
                k = 1;
            }
            if (pictureBox1.Bounds.IntersectsWith(pictureBox2.Bounds) || pictureBox1.Bounds.IntersectsWith(pictureBox3.Bounds))
            {
                okk = 0;
                timer1.Stop();
                timer2.Stop();
                MessageBox.Show("Ati pierdut! Ati obtinut " + scor + " puncte!");
                button1.Visible = true;
                button2.Visible = true;
                
                 
            }
        }
        int a , b , c , d ;
        private void Form1_Load(object sender, EventArgs e)
        {
            a = pictureBox2.Left;
            b = pictureBox2.Top;
            c = pictureBox3.Left;
            d = pictureBox3.Top;
            timer1.Start();
            timer2.Start();
            button1.Visible = false;
            button2.Visible = false;
            okk = 1;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

            
            if(ok!=1){
                pictureBox1.Top += 5;
            }
            ok = 0;
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                if (pictureBox1.Left > 15 && okk == 1 )
                {
                    pictureBox1.Top -= 35;
                    ok = 1;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Left = 42;
            pictureBox1.Top = 239;
            scor = 0;
            label1.Text = "Score: 0";
            pictureBox2.Left = a;
            pictureBox2.Top = b;
            pictureBox3.Left = c;
            pictureBox3.Top = d;
            timer1.Start();
            timer2.Start();
            button1 .Visible = false;
            button2.Visible = false;
            okk = 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }
    }
}
