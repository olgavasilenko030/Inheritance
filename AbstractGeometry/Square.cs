using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace AbstractGeometry
{
	internal class Square : Rectangle
	{
		/*double side;

		public double Side
		{
			get => side;
			set => side = SizeFilter(value);
		}*/

		public Square(double side, int startX, int startY,
		   int lineWith, System.Drawing.Color color)
		   : base(side, side, startX, startY, lineWith, color)
		{
			
		}

		/*public override double GetArea() => Math.Pow(side,2);
		public override double GetPerimeter() => 4 * side;

		public override void Draw(PaintEventArgs e)
		{
		}*/
	}
	
}
