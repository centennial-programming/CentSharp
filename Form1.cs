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

            // if the escape key was the one pressed
            if (e.KeyCode == Keys.Escape)
            {
                // exit the program
                Application.Exit();
            }
		}

		private void moveUp()
		{
            // create a point for the octo to move to
            Point newOctoPoint = new Point(octo.Location.X, octo.Location.Y - step);
            // create a rectangle using the point
            Rectangle newOctoBounds = new Rectangle(newOctoPoint, octo.Size);
            // note: the point and rectangle represent where the octo will be
            //       after it is moved, not where it is now
            // if the rectangle's top edge is onscreen
            // note: y-coordinates increase as you go down the screen
            if (newOctoBounds.Top >= ClientRectangle.Top)
            {
                // move the octo to the point
                octo.Location = newOctoPoint;
            }
		}

		private void moveDown()
		{
            Point newOctoPoint = new Point(octo.Location.X, octo.Location.Y + step);
            Rectangle newOctoBounds = new Rectangle(newOctoPoint, octo.Size);
            // if the rectangle's bottom edge is onscreen
            // note: y-coordinates increase as you go down the screen
            if (newOctoBounds.Bottom <= ClientRectangle.Bottom)
            {
                octo.Location = newOctoPoint;
            }
		}

		private void moveLeft()
		{
            Point newOctoPoint = new Point(octo.Location.X - step, octo.Location.Y);
            Rectangle newOctoBounds = new Rectangle(newOctoPoint, octo.Size);
            // if the rectangle's left edge is onscreen
            if (newOctoBounds.Left >= ClientRectangle.Left)
            {
                octo.Location = newOctoPoint;
            }
		}

		private void moveRight()
		{
            Point newOctoPoint = new Point(octo.Location.X + step, octo.Location.Y);
            Rectangle newOctoBounds = new Rectangle(newOctoPoint, octo.Size);
            // if the rectangle's right edge is onscreen
            if (newOctoBounds.Right <= ClientRectangle.Right)
            {
                octo.Location = newOctoPoint;
            }
		}
	}
}
