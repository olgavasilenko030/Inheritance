#define INTERITANCE_CHECK
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy
{
	internal class Program
	{
		static void Main(string[] args)
		{
#if INTERITANCE_CHECK
			Human human = new Human("Montano", "Antinio", 25);
			//human.Print();
			//Console.WriteLine(human);
			Student student = new Student("Pinkman", "Jessie", 25, "Chemistry", "WW20", 95, 96);
			//student.Print();
			//Console.WriteLine(student);
			Teacher teacher = new Teacher("White", "Walter", 50, "Chemistery", 20);
			//teacher.Print();
			//Console.WriteLine(teacher);
#endif
			Human[] group = new Human[]
			{
				new Student ("Pinkman", "Jessie", 25, "Chemistry", "WW20", 95, 96),
				new Teacher ("White", "Walter", 50, "Chemistery", 20)
			};

			foreach (Human item in group)
			{
				Console.WriteLine(item + "\n");
				}
			StreamWriter sw = new StreamWriter("List.txt");
			
			foreach (Human item in group)
			{
				sw.WriteLine(item + "\n");
			}
			sw.Close();

			StreamReader sr = new StreamReader("List.txt");
			while (!sr.EndOfStream)
			{
				string buffer = sr.ReadToEnd();
				Console.WriteLine(buffer);
				sr.Close();
			}

		}
	}
}
