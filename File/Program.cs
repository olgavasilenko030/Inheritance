#define WRITE_TO_FILE
#define READ_FROM_FILE
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;// Подключаем файловые потоки
using System.Diagnostics;

namespace File
{
	internal class Program
	{
		static void Main(string[] args)
		{
#if WRITE_TO_FILE
			//StreamWriter sw = new StreamWriter("File.txt");
			//sw.WriteLine("Hello Files");
			//sw.Close();
			//StreamWriter sw =  System.IO.File.AppendText("File.txt");
			//sw.WriteLine("Append to file");
			//sw.Close();
			//Process.Start("notepad", "File.txt");
#endif
			StreamReader sr = new StreamReader("File.txt");
			while (!sr.EndOfStream)
			{
				string buffer = sr.ReadLine();
				Console.WriteLine(buffer);
				sr.Close();
			}
		}
	}
}
