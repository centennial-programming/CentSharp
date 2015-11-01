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

			if (e.KeyCode == Keys.Up)
			{
				moveUp();
			}

			if (e.KeyCode == Keys.Down)
			{
				moveDown();
			}

			if (e.KeyCode == Keys.Left)
			{
				moveLeft();
			}

			if (e.KeyCode == Keys.Right)
			{
				moveRight();
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
