using CSharpLearnTest._Class._05_Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearnTest._RunProgram._05_Program_GC与析构函数 {
	class Program_01 {
		static void Main01(string[] args) {
			//ResourceHolder rh = new ResourceHolder();
			//rh.Dispose();
			//rh.SomeMethod();

			//using (ResourceHolder rh = new ResourceHolder()) {
			//	Console.WriteLine(rh);
			//}


			ResourceHolder rh = new ResourceHolder();
			rh = null;
			GC.Collect();
			//GC.Collect();

			Console.ReadKey();
			
		}
	}
}
