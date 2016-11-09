using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearnTest._RunProgram._06_Program_委托与事件 {

	class TestClass_06_01 {
		/*
		 * 相当于 delegate double Func(double d); 
		 */
		public Func<double, double> testFunc;

		public void Print01(Func<double, double> fc, double d) {
			double result = fc(d);
			Console.WriteLine("Result is "+result.ToString());
		}

		public void Calculate(double d, bool haveCallback) {
			if (haveCallback) {
				Console.WriteLine(testFunc(d)); 
			}
		}
	}

	class TestClass_06_02 {
		/*
		 * 相当于 delegate void Action(string str); 
		 */
		public Action<string> testAction;
	}

	/// <summary>
	/// Func<T,T>  &  Action<T>
	/// </summary>
	class Program_03 {
		static double GetSqrt(double d) { return d * d; }
		
		static void a_print01(string str){Console.WriteLine("print01: "+str);}
		static void a_print02(string str) { Console.WriteLine("print02: "+str); }
		static void Main03(string[] args) {
			TestClass_06_01 testc1 = new TestClass_06_01();
			testc1.Print01(GetSqrt, 10);

			testc1.testFunc += GetSqrt;
			testc1.Calculate(3, true);

			Console.WriteLine();
			Console.WriteLine("--------------------------");
			Console.WriteLine();

			TestClass_06_02 testc2 = new TestClass_06_02();
			testc2.testAction += a_print01;
			testc2.testAction += a_print02;
			testc2.testAction.Invoke("hello");
		}

	}
}
