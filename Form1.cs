using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MousePen
{
    public partial class Form1 : Form
    {
        Brush brush = Brushes.Black;
        bool flag = false;         

        public Form1()
        {
            InitializeComponent();

            this.MouseMove += new MouseEventHandler(Form1_MouseMove);       
            
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            Graphics g = this.CreateGraphics();
            if (flag)
            {
                g.FillRectangle(brush, e.X, e.Y, 2, 2);  // рисуем пиксель черного цвета размером 2x2 в точке (e.X, e.Y)
                
            }
            
            g.Dispose(); // освобождаем графический контекст
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            flag = true;
            System.Threading.Thread.Sleep(100);
            
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            brush = Brushes.Green;
        }
    }
}
