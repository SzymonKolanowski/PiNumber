using System;
using System.Globalization;
using System.Text;

namespace Dokładność_liczby_PI
{
	class Program
	{
		static void Main(string[] args)
		{
			//Find PI to the Nth Digit - Enter a number and have the program generate PI up to that many decimal places. Keep a limit to how far the program will go.

			Console.WriteLine("Podaj wymaganą dokładność liczby PI po przecinku");
			string text = Console.ReadLine();
			decimal wynik = decimal.Parse(text);
			double pi = Math.PI;
			
		}
	}
}
