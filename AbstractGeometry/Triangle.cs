using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace AbstractGeometry
{
	abstract class Triangle:Shape
	{
		/*double a, b, c;
		
		public double A
		{
			get => a;
			set => a = SizeFilter(value);
		}
		public double B
		{
			get => b;
			set => b = SizeFilter(value);
		}
		public double C
		{
			get => c;
			set => c = SizeFilter(value);
		}
	

		public Triangle(double a, double b, double c, int startX, int startY,
		   int lineWith, System.Drawing.Color color)
		   : base(startX, startY, lineWith, color)
		{
			A = a;
			B = b;
			C = c;
			
		}

		public override double GetArea() => Math.Sqrt(GetPerimeter() * (GetPerimeter() - A) * (GetPerimeter() - B) * (GetPerimeter() - C));
		public override double GetPerimeter() => (A + B + C) / 2; 

		public override void Draw(PaintEventArgs e)
		{
			throw new NotImplementedException();
		}*/
		public abstract double GetHeight();
		public Triangle (int startX, int startY, int lineWidth, Color color)
			: base (startX, startY, lineWidth, color) { }
		public override void Info(PaintEventArgs e)
		{
            Console.WriteLine($"Высота треугольника: {GetHeight()}");
            base.Info(e);
		}

	}
}
