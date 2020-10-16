using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public int x = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Stretches the image to fit the pictureBox.ytytgg
            Bitmap MyImage;
            string fileToDisplay = @"C:\Users\student\source\repos\Cs_praktiks\praktika7\offTop\Risovat_na_Canvas\Resources\C&V.jpeg";
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            
            MyImage = new Bitmap(fileToDisplay);

            // Create pen.
            Pen blackPen = new Pen(Color.Black, 30);
            // Create coordinates of points that define line.
            x+=5;
            int x1 = 100+x;   //topleft to topright
            int y1 = 100 + x;
            int x2 = 100 + x;
            int y2 = 170 + x;
      int x_1 = 150 + x;   
      int y_1 = 200 + x;
      int x_2 = 170 + x;
      int y_2 = 200 + x;


      // Draw line to screen.
      using (var graphics = Graphics.FromImage(MyImage))
            {
                graphics.DrawLine(blackPen, x1, y1, x2, y2);
        graphics.DrawLine(blackPen, x_1, y_1, x_2, y_2);
      }


            pictureBox1.ClientSize = new Size(400, 400);
            pictureBox1.Image = (Image)MyImage;
        }
    }
}
