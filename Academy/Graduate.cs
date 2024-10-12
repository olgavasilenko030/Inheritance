using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Academy
{
	internal class Graduate:Student
	{
		public int Year_of_release { get; set; }

		public string Subject { get; set; }
		public Graduate(
			string lastName, string firstName, int age, string speciality, string group, double rating, double attendance,
			int year_of_release, string subject) : base(lastName, firstName, age, speciality,  group,  rating, attendance)
		{ 
			this.Subject = subject;
			Year_of_release = year_of_release;

			Console.WriteLine($"SConstructor:{GetHashCode()}");}

		~Graduate()
		{ Console.WriteLine($"Destructor:{GetHashCode()}"); }

		public override void Print()
		{
			base.Print();
			Console.WriteLine($"{Subject}{Year_of_release}");
		}

		public override string ToString()
		{
			return base.ToString() + $"{Subject} {Year_of_release}";
		}
	}
}
