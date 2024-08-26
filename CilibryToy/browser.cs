using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace CilibryToy
{
	public partial class browser : Form
	{
		public const int WM_NCLBUTTONDOWN = 0xA1;
		public const int HT_CAPTION = 0x2;
		
		[DllImportAttribute("user32.dll")]
		public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
		[DllImportAttribute("user32.dll")]
		public static extern bool ReleaseCapture();
		
		public browser()
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
		void Button1Click(object sender, EventArgs e)
		{
			Close();
		}
		void Button3Click(object sender, EventArgs e)
		{
			webBrowser1.Navigate(new Uri(textBox1.Text));
		}
		void WebBrowser1DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
		{
			
		}
		void WebBrowser1Navigated(object sender, WebBrowserNavigatedEventArgs e)
		{
			textBox1.Text = webBrowser1.Url.ToString();
		}
	}
}
