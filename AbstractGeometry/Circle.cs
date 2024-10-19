using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace AbstractGeometry
{
	internal class Circle:Shape
	{

		double radius;

		public double Radius
		{
			get => radius;
			set => radius = SizeFilter(value);
		}

		public Circle (double radius, 
			int startX, int startY,
		   int lineWith, System.Drawing.Color color)
		   : base(startX, startY, lineWith, color)
		{
			Radius = radius;
		}

		public override double GetArea() => Math.PI * Math.Pow(Radius, 2);
		public override double GetPerimeter() => 2 * Math.PI* Radius;

		public override void Draw(PaintEventArgs e)
		{
			Pen pen = new Pen (Color, LineWidth);
			e.Graphics.DrawEllipse(pen, StartX, StartY, 2 * (float)Radius, 2 * (float)Radius);
		}
		public override void Info(PaintEventArgs e)
		{
            Console.WriteLine(this.GetType());
            Console.WriteLine($"Радиус круга:{Radius}");
            base.Info(e);
		}
	}
}
