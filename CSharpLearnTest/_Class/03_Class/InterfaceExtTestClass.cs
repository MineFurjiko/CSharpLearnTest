using CSharpLearnTest._Interface._03_Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearnTest._Class._03_Class {
	class InterfaceExtTestClass:IExtTest {

		public void Test01() {
			Console.WriteLine("Fun Test01 from IExtTest Interface.");
		}
	}

	static class IExtTestExtension {
		public static void Test02(this IExtTest iet) {
			Console.WriteLine("Fun Test02 from IExtTestExtension.");
		}
	}
}
