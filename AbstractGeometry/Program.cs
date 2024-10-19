using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Runtime.InteropServices;


namespace AbstractGeometry
{
	internal class Program
	{
		static void Main(string[] args)
		{
            //Console.WriteLine("AbstractGeometry");

			IntPtr hwnd = GetConsoleWindow();
			Graphics graphics = Graphics.FromHwnd(hwnd);
			System.Drawing.Rectangle window_rect =new System.Drawing.Rectangle (
			Console.WindowLeft,Console.WindowTop,Console.WindowWidth,Console.WindowHeight);
			PaintEventArgs e = new PaintEventArgs(graphics,window_rect);
			
			Rectangle rectangle = new Rectangle(100, 50, 400, 25, 3,System.Drawing.Color.Red);
			rectangle.Info(e);

			Square square = new Square(75, 512, 16, 1, Color.DarkBlue);
			square.Info(e);

			Circle circle = new Circle(75, 570, 95, 5, Color.Yellow);
			circle.Info(e);
		}
		[DllImport("kernel32.dll")]
		public static extern IntPtr GetConsoleWindow();
		[DllImport("kernel32.dll")]
		public static extern IntPtr GetDC(IntPtr hwnd);
	}
}
