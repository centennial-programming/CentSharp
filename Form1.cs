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
			//If the Up key is pressed.
			if (e.KeyCode == Keys.Up)
			{
				moveUp();
			}

			//If the Down key is pressed.
			if (e.KeyCode == Keys.Down)
			{
				moveDown();
			}

			//If the Left key is pressed.
			if (e.KeyCode == Keys.Left)
			{
				moveLeft();
			}

			//If the Right key is pressed.
			if (e.KeyCode == Keys.Right)
			{
				moveRight();
			}

            if (e.KeyCode == Keys.Escape)
            {
                Application.Exit();
            }
		}

		private void moveUp()
		{
            Point newOctoPoint = new Point(octo.Location.X, octo.Location.Y - step);
            Rectangle newOctoBounds = new Rectangle(newOctoPoint, octo.Size);
            if (newOctoBounds.Y >= ClientRectangle.Top)
            {
                octo.Location = new Point(octo.Location.X, octo.Location.Y - step);
            }
		}

		private void moveDown()
		{
            Point newOctoPoint = new Point(octo.Location.X, octo.Location.Y + step);
            Rectangle newOctoBounds = new Rectangle(newOctoPoint, octo.Size);
            if (newOctoBounds.Y + octo.Size.Height <= ClientRectangle.Bottom)
            {
                octo.Location = new Point(octo.Location.X, octo.Location.Y + step);
            }
		}

		private void moveLeft()
		{
            Point newOctoPoint = new Point(octo.Location.X - step, octo.Location.Y);
            Rectangle newOctoBounds = new Rectangle(newOctoPoint, octo.Size);
            if (newOctoBounds.X >= ClientRectangle.Left)
            {
                octo.Location = new Point(octo.Location.X - step, octo.Location.Y);
            }
		}

		private void moveRight()
		{
            Point newOctoPoint = new Point(octo.Location.X + step, octo.Location.Y);
            Rectangle newOctoBounds = new Rectangle(newOctoPoint, octo.Size);
            if (newOctoBounds.X + octo.Size.Width <= ClientRectangle.Right)
            {
                octo.Location = new Point(octo.Location.X + step, octo.Location.Y);
            }
		}
	}
}
