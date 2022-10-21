/*
By InnieSharp(ix4/i#)
*/
using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace CilibryToy
{
	/// <summary>
	/// Description of test.
	/// </summary>
	public partial class test : Form
	{
		public const int WM_NCLBUTTONDOWN = 0xA1;
		public const int HT_CAPTION = 0x2;
		
		[DllImportAttribute("user32.dll")]
		public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
		[DllImportAttribute("user32.dll")]
		public static extern bool ReleaseCapture();
		
		public test()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
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
	}
}
