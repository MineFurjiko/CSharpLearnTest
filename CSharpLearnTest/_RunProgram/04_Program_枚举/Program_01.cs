using CSharpLearnTest._Class._04_Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearnTest._RunProgram._04_Program_枚举 {
	class Program_01 {
		static void Main01(string[] args) {
			Family family = new Family();

			/*
			 * In Unity base on momo, foreach will produce GC rubbish.
			 * use this. Get Enumerator and read item by while.
			 */ 
			//var enumerator = family.GetEnumerator();
			//while (enumerator.MoveNext()) {
			//	Person p = enumerator.Current;
			//	Console.WriteLine(p);
			//}

			//using (IEnumerator<Person> enumerator = family.GetEnumerator()) {
			//	while (enumerator.MoveNext()) {
			//		Person p = enumerator.Current;
			//		Console.WriteLine(p);
			//	}
			//}

			Console.WriteLine("---GetEnumerator()---");
			foreach (var person in family) {
				Console.WriteLine(person);
			}
			Console.WriteLine("---GetEnumerator()---");

			Console.WriteLine();

			Console.WriteLine("---Reverse()---");
			foreach (var person in family.Reverse()) {
				Console.WriteLine(person);
			}
			Console.WriteLine("---Reverse()---");

			Console.WriteLine();

			Console.WriteLine("---Subset()---");
			foreach (var person in family.Subset(0,2)) {
				Console.WriteLine(person);
			}
			Console.WriteLine("---Subset()---");
		}
	}
}
