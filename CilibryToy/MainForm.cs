using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace CilibryToy
{
	public partial class MainForm : Form
	{
		bool menu;
		
		public MainForm()
		{
			InitializeComponent();
		}
		void MainFormLoad(object sender, EventArgs e)
		{
			panel2.Location = new Point(999999999, 999999999);
			menu = false;
		}
		void Button1Click(object sender, EventArgs e)
		{
			if (!menu)
			{
				panel2.Location = new Point(0, panel1.Location.Y + panel1.Height);
				menu = true;
			}
			else
			{
				panel2.Location = new Point(999999999, 999999999);
				menu = false;
			}
		}
		void Button3Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
		void Button2Click(object sender, EventArgs e)
		{
			test f = new test();
			f.MdiParent = this;
			f.Show();
			panel2.Location = new Point(999999999, 999999999);
			menu = false;
		}
		void MainFormActivated(object sender, EventArgs e)
		{
			this.SendToBack();
		}
		void Timer1Tick(object sender, EventArgs e)
		{
			label1.Text = DateTime.Now.ToString("g");
		}
	}
}
