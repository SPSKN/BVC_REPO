using System;
using System.Threading;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;


namespace Asteroid
{
    public partial class Form1 : Form
    {

        private int _x;
        private int _y;
        //private static Timer timer;
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

            var timer = new System.Timers.Timer();
            timer.Interval = 1000;
            timer.Start();
            string sTimer = timer.ToString();

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            

            
            Graphics g = e.Graphics;
            Pen whitePen = new Pen(Color.White);
            Pen bluePen = new Pen(Color.Blue);
            // Rectangle rect = new Rectangle(20, 20, 100, 90);
            Rectangle ship = new Rectangle(180, 180, 20, 20);
            Random point = new Random();
            //g.DrawEllipse(whitePen, rect);
            g.DrawEllipse(bluePen, ship);
            for(int i =0;i<10;i++)
            {               
               int xRnd = point.Next(10, 450);
               int yRnd = point.Next(50, 300);
               int leng = point.Next(10, 100);
                Rectangle rect = new Rectangle(xRnd, yRnd, leng, leng);
                g.DrawEllipse(whitePen, rect);
            }
            
             Rectangle scoreBoard = new Rectangle(0, 0, 595, 50);
                        
            
            GraphicsPath path = new GraphicsPath();
            path.AddRectangle(scoreBoard);
            e.Graphics.DrawPath(Pens.White, path);
            Region clippingRegion = new Region(path);
            e.Graphics.Clip = clippingRegion;
            e.Graphics.DrawString("Score: ",new Font("Verdana",25,FontStyle.Bold),Brushes.White,10,10);
            
            clippingRegion.Dispose();
            path.Dispose();
           

        }

        private void Timer_Tick(object sender, EventArgs e)
        {

            /*
            Graphics g = this.panel.CreateGraphics();
            Pen whitePen = new Pen(Color.White);
            Pen bluePen = new Pen(Color.Blue);
            // Rectangle rect = new Rectangle(20, 20, 100, 90);
            Rectangle ship = new Rectangle(180, 180, 20, 20);
            Random point = new Random();
            for (int i =0;i<10;++i)
            {
                int xRnd = point.Next(10, 450);
                int yRnd = point.Next(50, 300);
                int leng = point.Next(10, 100);
                Rectangle rect = new Rectangle(xRnd, yRnd, leng, leng);
                g.DrawEllipse(whitePen, rect);
            }
            */
        }

        private void Panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TmrTicker_Tick(object sender, EventArgs e)
        {

        }
    }

}
