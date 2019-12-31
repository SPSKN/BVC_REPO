using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Brick_Breaker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.SetStyle(ControlStyles.OptimizedDoubleBuffer |
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.UserPaint,
                true);
            this.UpdateStyles();
                
       }
        /// <summary>     /// Variables for the ball and for the movement
        /// </summary>
        private int ballW = 25;
        private int ballH = 25;
        private int ballPosX = 0;
        private int ballPosY = 0;
        private int moveStepX = 4;
        private int moveStepY = 4;
        private int Lives = 3;
    

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void PaintCircle(object sender, PaintEventArgs e)
        { }
        

        private void MoveBall(object sender, EventArgs e)
        {

            pictureBox2.Left = Cursor.Position.X - (pictureBox2.Width / 2);
               
                /*
                 * Aslong as the ball is above the paddle and between the left and right of the paddle
                 * 
                */


                if (ball.Bottom >= pictureBox2.Top && ball.Bottom <= pictureBox2.Bottom && ball.Left >= pictureBox2.Left && ball.Right <= pictureBox2.Right )
                {
                moveStepX += 2;
                moveStepY += 2;
                }
                if(ball.Left <= panel1.Left)
                {
                moveStepX = -moveStepX;
                }
                if(ball.Right >= panel1.Right)
                {
                moveStepX = -moveStepX;
                }
                if(ball.Top <= panel1.Top)
                {
                moveStepY = -moveStepY;

                }
                if(ball.Bottom >= panel1.Bottom)
                {
                timer1.Enabled = false;
                }

            
            
                // paint ball
                this.Refresh();
            
        }

        private void PlayArea(object sender, PaintEventArgs e)
        {
            
               


            

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
}
