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
			//double pi = Math.PI;
			NumberFormatInfo setPrecision = new NumberFormatInfo();

			setPrecision.NumberDecimalDigits = wynik;

			decimal test = 3.14159265358979323M;

			Console.WriteLine(test.ToString("N", setPrecision)); //Should write 1.23

			setPrecision.NumberDecimalDigits = 3;

			test = 5m / 3m;

			Console.WriteLine(test.ToString("N", setPrecision));

		}
	}
}
