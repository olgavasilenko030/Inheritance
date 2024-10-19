using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbstractGeometry
{
	internal class Square : Shape
	{
		double side;

		public double Side
		{
			get => side;
			set => side = SizeFilter(value);
		}

		public Square(double side, int startX, int startY,
		   int lineWith, System.Drawing.Color color)
		   : base(startX, startY, lineWith, color)
		{
			Side = side;
		}

		public override double GetArea() => Math.Pow(Side,2);
		public override double GetPerimeter() => 4 * Side;

		public override void Draw(PaintEventArgs e)
		{
			throw new NotImplementedException();
		}
	}
	
}
