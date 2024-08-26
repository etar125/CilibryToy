using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;
using System.Diagnostics;

namespace CilibryToy
{
	public partial class notepad : Form
	{
		public const int WM_NCLBUTTONDOWN = 0xA1;
		public const int HT_CAPTION = 0x2;
		
		[DllImportAttribute("user32.dll")]
		public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
		[DllImportAttribute("user32.dll")]
		public static extern bool ReleaseCapture();
		
		public notepad()
		{
			InitializeComponent();
		}
		void Panel1MouseMove(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
		    {
		        ReleaseCapture();
		        SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
		    }
		}
		void Button1Click(object sender, EventArgs e)
		{
			Close();
		}
		void Button2Click(object sender, EventArgs e)
		{
			if(WindowState == FormWindowState.Maximized)
			{
				WindowState = FormWindowState.Normal;
			}
			else
			{
				WindowState = FormWindowState.Maximized;
			}
		}
		void Button3Click(object sender, EventArgs e)
		{
			if(saveFileDialog1.ShowDialog() == DialogResult.OK)
			{
				File.WriteAllLines(saveFileDialog1.FileName, richTextBox1.Lines);
			}
		}
		void Button4Click(object sender, EventArgs e)
		{
			if(openFileDialog1.ShowDialog() == DialogResult.OK)
			{
				richTextBox1.Lines = File.ReadAllLines(openFileDialog1.FileName);
			}
		}
		void Button5Click(object sender, EventArgs e)
		{
			if(openFileDialog1.ShowDialog() == DialogResult.OK)
			{
				Process.Start(openFileDialog1.FileName);
			}
		}
	}
}
