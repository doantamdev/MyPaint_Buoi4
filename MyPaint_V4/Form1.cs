using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyPaint_V4
{
    public partial class Form1 : Form
    {
        protected Graphics g;
        private PrototypeRegistry registry;
        public Form1()
        {
            InitializeComponent();
            g = mainPanel.CreateGraphics();
           
        }

        private void mainPanel_MouseDown(object sender, MouseEventArgs e)
        {
            registry = new PrototypeRegistry();

            registry.AddItem("Red", new MyRectangle(e.Location.X, e.Location.Y, 100, 50, 2, Color.Red));
            registry.AddItem("Green", new MyRectangle(e.Location.X, e.Location.Y, 100, 50, 2, Color.Green));
            registry.AddItem("Blue", new MyRectangle(e.Location.X, e.Location.Y, 100, 50, 2, Color.Blue));

            Color selectedColor = Color.Black;

            if (rbRed.Checked)
            {
                selectedColor = Color.Red;
            }
            else if (rbGreen.Checked)
            {
                selectedColor = Color.Green;
            }
            else if (rbBlue.Checked)
            {
                selectedColor = Color.Blue;
            }

            Prototype selectedPrototype = registry.GetByColor(selectedColor);

            if (selectedPrototype != null)
            {
                MyRectangle newR = (MyRectangle)registry.GetByID(selectedPrototype.GetColor());

                newR.Draw(g);
            }
        }
    }
}
