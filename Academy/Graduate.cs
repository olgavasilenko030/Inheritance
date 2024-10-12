using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Academy
{
	internal class Graduate:Human
	{
		public int Year_of_release { get; set; }
		public string Speciality { get; set; }
		public Graduate(
			string lastName, string firstName, int age,
			int year_of_release, string speciality) : base(lastName, firstName, age) { 
			this.Speciality = speciality;
			Year_of_release = year_of_release;

			Console.WriteLine($"SConstructor:{GetHashCode()}");}

		~Graduate()
		{ Console.WriteLine($"Destructor:{GetHashCode()}"); }

		public override void Print()
		{
			base.Print();
			Console.WriteLine($"{Speciality}{Year_of_release}");
		}

		public override string ToString()
		{
			return base.ToString() + $"{Speciality} {Year_of_release}";
		}
	}
}
