using CSharpLearnTest._Class._06_Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearnTest._RunProgram._06_Program_委托与事件 {
	/// <summary>
	/// 强连接：如果侦听器对象不再直接引用，但发布程序仍有一个引用，GC就无法回收。
	/// 弱事件：使用WeekEventManager(In WindowsBase程序集)为中介
	/// </summary>
	class Program_07 {
		static void Main07() {
			var dealer = new CarDealer();

			var micheal = new Consumer("Micheal");
			WeakCarInfoEventManager.AddListener(dealer,micheal);

			dealer.NewCar("Mercedes");

			var nick = new Consumer("Nick");
			WeakCarInfoEventManager.AddListener(dealer,nick);

			dealer.NewCar("Ferrari");

			WeakCarInfoEventManager.RemoveListener(dealer,micheal);

			dealer.NewCar("Toyota");
		}
	}
}
