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

        private void Form1_Load(object sender, EventArgs e)
        {
			Form form1 = this;
			form1.KeyDown += new KeyEventHandler(Form1_KeyDown);
        }
           
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

			switch (e.KeyCode)
            {
                case Keys.Up:
					octo.Location = new Point(octo.Location.X, octo.Location.Y - step);
				break;
				case Keys.Down:
					octo.Location = new Point(octo.Location.X, octo.Location.Y + step);
				break;
				case Keys.Left:
					octo.Location = new Point(octo.Location.X - 3, octo.Location.Y - step);
					break;
				case Keys.Right:
					octo.Location = new Point(octo.Location.X + 3, octo.Location.Y + step);
				break;
			}
        }
    }
}
