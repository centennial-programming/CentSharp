using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CentSharp
{
    public partial class Form1 : Form
    {
		int step = 6;

        public Form1()
        {
            InitializeComponent();
        }

		//On Form load (Application Start)
        private void Form1_Load(object sender, EventArgs e)
        {
			//Register event listeners.
			Form form1 = this;
			form1.KeyDown += new KeyEventHandler(Form1_KeyDown);
        }
          
		//KeyDown event.
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

			switch (e.KeyCode)
            {
                case Keys.Up: //If UP key is pressed.
					//Move picture box to new location.
					octo.Location = new Point(octo.Location.X, octo.Location.Y - step);
				break;
				case Keys.Down: //If DOWN key is pressed.
					//Move picture box to new location.
					octo.Location = new Point(octo.Location.X, octo.Location.Y + step);
				break;
				case Keys.Left: //If LEFT key is pressed.
					//Move picture box to new location.
					octo.Location = new Point(octo.Location.X - step, octo.Location.Y);
					break;
				case Keys.Right: //If RIGHT key is pressed.
					 //Move picture box to new location.
					octo.Location = new Point(octo.Location.X + step, octo.Location.Y);
				break;
			}
        }
    }
}
