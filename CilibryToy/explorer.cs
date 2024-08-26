using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;
using System.Diagnostics;

namespace CilibryToy
{
	public partial class explorer : Form
	{
		public const int WM_NCLBUTTONDOWN = 0xA1;
		public const int HT_CAPTION = 0x2;
		
		[DllImportAttribute("user32.dll")]
		public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
		[DllImportAttribute("user32.dll")]
		public static extern bool ReleaseCapture();
		
		public explorer()
		{
			InitializeComponent();
		}
		void Button1Click(object sender, EventArgs e)
		{
			Close();
		}
		void Panel1MouseMove(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
		    {
		        ReleaseCapture();
		        SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
		    }
		}
		void ListBox1DoubleClick(object sender, EventArgs e)
		{
			try
			{
				if(Directory.Exists(listBox1.SelectedItem.ToString()))
				{
					string ab = listBox1.SelectedItem.ToString();
					listBox1.Items.Clear();
					listBox1.Items.Add(textBox1.Text);
					textBox1.Text = ab;
					foreach(string dir in Directory.GetDirectories(textBox1.Text))
					{
						listBox1.Items.Add(dir);
					}
					foreach(string file in Directory.GetFiles(textBox1.Text))
					{
						listBox1.Items.Add(file);
					}
				}
				else
				{
					Process.Start(listBox1.SelectedItem.ToString());
				}
				listBox1.SelectedIndex = -1;
			}
			catch
			{
				
			}
		}
		void Button3Click(object sender, EventArgs e)
		{
			if(Directory.Exists(textBox1.Text))
			{
				listBox1.Items.Clear();
				foreach(string dir in Directory.GetDirectories(textBox1.Text))
				{
					listBox1.Items.Add(dir);
				}
				foreach(string file in Directory.GetFiles(textBox1.Text))
				{
					listBox1.Items.Add(file);
				}
			}
		}
	}
}
