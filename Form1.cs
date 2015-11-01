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
					moveUp();
				break;
				case Keys.Down: //If DOWN key is pressed.
					moveDown();
				break;
				case Keys.Left: //If LEFT key is pressed.
					moveLeft();
				break;
				case Keys.Right: //If RIGHT key is pressed.
					moveRight();
				break;
			}
		}

		private void moveUp()
		{
			octo.Location = new Point(octo.Location.X, octo.Location.Y - step);
		}

		private void moveDown()
		{
			octo.Location = new Point(octo.Location.X, octo.Location.Y + step);
		}

		private void moveLeft()
		{
			octo.Location = new Point(octo.Location.X - step, octo.Location.Y);
		}

		private void moveRight()
		{
			octo.Location = new Point(octo.Location.X + step, octo.Location.Y);
		}
	}
}
