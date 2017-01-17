using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GDIDrawer;

namespace ICA03_WilliamFichtner
{
    public partial class Form1 : Form
    {
        bool red = false;
        bool green = false;
        bool blue = false;
        bool border = false;
        int thickness = 0;
        CDrawer canvas = new CDrawer();
        Random rng = new Random();

        
        

        public Form1()
        {
            InitializeComponent();
        }

        private void UI_DrawButton_Click(object sender, EventArgs e)
        {
            int xrand = rng.Next(801);
            int yrand = rng.Next(601);

            if (red == true)
            {
                if (border == true)
                {
                    canvas.AddEllipse(xrand, yrand, 50, 50, Color.Red, thickness, Color.White);
                }
                else
                canvas.AddEllipse(xrand, yrand, 50, 50, Color.Red);
            }
            else if (green == true)
            {
                if (border == true)
                {
                    canvas.AddEllipse(xrand, yrand, 50, 50, Color.Green, thickness, Color.White);
                }
                else
                    canvas.AddEllipse(xrand, yrand, 50, 50, Color.Green);
            }
            else if (blue == true)
            {
                if (border == true)
                {
                    canvas.AddEllipse(xrand, yrand, 50, 50, Color.Blue, thickness, Color.White);
                }
                else
                    canvas.AddEllipse(xrand, yrand, 50, 50, Color.Blue);
            }
            
        }

        private void UI_RedRadial_CheckedChanged(object sender, EventArgs e)
        {
            red = true;
            green = false;
            blue = false;
        }

        private void UI_GreenRadial_CheckedChanged(object sender, EventArgs e)
        {
            green = true;
            red = false;
            blue = false;
        }
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            blue = true;
            red = false;
            green = false;
        }

        private void UI_BorderCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (UI_BorderCheckbox.Checked == true)
            {
                border = true;
            }
            else
                border = false;
        }

        private void UI_ThicknessUpDown_ValueChanged(object sender, EventArgs e)
        {
            thickness = (int)UI_ThicknessUpDown.Value;
        }
    }
}
