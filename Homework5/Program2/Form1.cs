﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text;
            th1 = Double.Parse(s) * Math.PI / 180;
            s = textBox2.Text;
            th2 = Double.Parse(s) * Math.PI / 180;
            s = textBox3.Text;
            double leng = 100;
            leng = Double.Parse(s);
            s = textBox4.Text;
            k = Double.Parse(s);

            if (graphics == null) graphics = this.CreateGraphics();
            drawCayleyTree(10, 200, 310, leng,-Math.PI / 2);
        }
        
        private Graphics graphics;
        double th1 = 30 * Math.PI / 180;
        double th2 = 20 * Math.PI / 180;
        double per1 = 0.6;
        double per2 = 0.7;
        double k = 0.7;
        


        void drawCayleyTree(int n,double x0,double y0,double leng ,double th)
        {
            if (n == 0) return;

            double x1 = x0 + leng * Math.Cos(th);
            double y1 = y0 + leng * Math.Sin(th);
            double x2 = x0 + k*leng * Math.Cos(th);
            double y2 = y0 + k*leng * Math.Sin(th);
            drawLine(x0, y0, x1, y1);
            drawLine(x0, y0, x2, y2);

            drawCayleyTree(n - 1, x1, y1, per1 * leng, th + th1);
            drawCayleyTree(n - 1, x2, y2, per2 * leng, th - th2);

        }

        void drawLine(double x0, double y0,double x1,double y1)
        {
            graphics.DrawLine(Pens.Red, (int)x0, (int)y0, (int)x1, (int)y1);
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
