using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearnTest._RunProgram._06_Program_委托与事件 {
	/// <summary>
	/// 初识委托
	/// </summary>
	class Program_01 {
		private delegate string GetString();

		private delegate void MethodRunOver();
		private static MethodRunOver callback;

		static void PrintInformation01() {
			Console.WriteLine("PrintInformation01 Run Over.");
		}

		static void PrintInformation02() {
			Console.WriteLine("PrintInformation02 Run Over.");
		}

		static void Test01(string str, MethodRunOver callback01) {
			Console.WriteLine(str);
			callback01.Invoke();
		}

		static void Test02(string str,bool haveCallback) {
			Console.WriteLine(str);
			if (haveCallback) {
				callback.Invoke();
			}
		}

		static void Main01(string[] args) {

			//First
			int x = 59;
			GetString gs=default(GetString);
			gs+= (x.ToString);

			Console.WriteLine(gs.Invoke());
			Console.WriteLine();

			//CallBack Test01
			Test01("Hello",PrintInformation01);
			Console.WriteLine();

			//CallBack Test02
			callback += PrintInformation01;
			callback += PrintInformation02;
			Test02("World",true);
		}
	}
}
