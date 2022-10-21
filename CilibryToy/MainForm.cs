/*
By InnieSharp(ix4/i#)
*/
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace CilibryToy
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		bool menu;
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void MainFormLoad(object sender, EventArgs e)
		{
			panel2.Location = new Point(999999999, 999999999);
			menu = false;
		}
		void Button1Click(object sender, EventArgs e)
		{
			if(!menu)
			{
				panel2.Location = new Point(0, panel1.Location.Y - panel2.Height);
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
		void Timer1Tick(object sender, EventArgs e)
		{
			
		}
		void Timer2Tick(object sender, EventArgs e)
		{
			
		}
	}
}
