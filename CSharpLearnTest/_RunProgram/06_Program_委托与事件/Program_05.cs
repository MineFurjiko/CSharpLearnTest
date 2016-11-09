using CSharpLearnTest._Class._02_Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearnTest._RunProgram._06_Program_委托与事件 {
	/// <summary>
	/// Lambda表达式
	/// </summary>
	class Program_05 {
		delegate string StringDelegate(string s);

		static void Main05() {
			string mid = ", middle part,";

			//单参数
			StringDelegate lambda = param => {
				param += mid;
				param += " and this was added to the string.";
				return param;
			};
			Console.WriteLine(lambda("Start of string"));

			Console.WriteLine();
			Console.WriteLine("----------------------------");
			Console.WriteLine();

			//多参数
			Func<double, double, double> mulFunc = (x,y) => x * y;
			Console.WriteLine(mulFunc(5,6));

			Console.WriteLine();
			Console.WriteLine("----------------------------");
			Console.WriteLine();

			Action<Book> testAction = book => Console.WriteLine(book.Title);
			Book book1 = new Book(27, "C#之美.");
			testAction(book1);
			Console.WriteLine();

		}
		

	}
}
