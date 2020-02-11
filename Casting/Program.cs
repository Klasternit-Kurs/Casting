using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casting
{
	class Program
	{
		static void Main(string[] args)
		{
			int x = 5;
			int y = 2;

			int a = 4; 
			double b = a; //implicitni casting
			
			double c = 4;
			int d = (int)c; //eksplicitni cast
							//Console.WriteLine("Broj je " + d);

			//Console.WriteLine((double)x / y);

			int nekaVrednost = 10;

			//Ista stvar :)
			nekaVrednost = nekaVrednost + 2;
			nekaVrednost += 2;
			nekaVrednost -= 5;
			nekaVrednost /= 3;
			//Neke promene
			
			int broj = 0;

			broj++; //broj = broj + 1 tj broj += 1
			broj--; //Postfix
			++broj; //Prefix
			--broj;

			Console.WriteLine(broj++); //0
			Console.WriteLine(++broj); //2 ili 1
			Console.WriteLine(broj);  //0 ili 2

			if (broj++ < 3)
			{
				Console.WriteLine("Broj je: " + broj);
				Console.WriteLine("Broj je manji od 3");
			}
			


			Console.WriteLine("Broj je: " + broj);

			Console.ReadKey();
		}
	}
}
