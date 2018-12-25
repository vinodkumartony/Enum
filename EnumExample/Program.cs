using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumExample
{
	public enum ShppingMethod
	{
		RegularAirMal = 1,
		RegisteredAirMal = 2,
		Express = 3

	}
	class Program
	{
		static void Main(string[] args)
		{
			var method = ShppingMethod.Express;
			Console.WriteLine((int)method);
			

			var methodId = 3;
			Console.WriteLine((ShppingMethod)methodId);

			var methodName = "Express";
			var shippingMethod = (ShppingMethod)Enum.Parse(typeof(ShppingMethod), methodName);
			Console.WriteLine(shippingMethod);
			Console.ReadLine();
		}
	}
}
