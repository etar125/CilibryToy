using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Threading;

namespace CilibryToy
{
	public partial class test : Form
	{
		public const int WM_NCLBUTTONDOWN = 0xA1;
		public const int HT_CAPTION = 0x2;
		
		[DllImportAttribute("user32.dll")]
		public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
		[DllImportAttribute("user32.dll")]
		public static extern bool ReleaseCapture();
		[DllImport("user32.dll")]
		static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);
		
		public test()
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
		void Button2Click(object sender, EventArgs e)
		{
			notepad f = new notepad();
			f.MdiParent = MainForm.ActiveForm;
			f.Show();
		}
		void Button3Click(object sender, EventArgs e)
		{
			browser f = new browser();
			f.MdiParent = MainForm.ActiveForm;
			f.Show();
		}
		void Button4Click(object sender, EventArgs e)
		{
			explorer f = new explorer();
			f.MdiParent = MainForm.ActiveForm;
			f.Show();
		}
		void Button5Click(object sender, EventArgs e)
		{
			Process.Start("cmd");
		}
	}
}
