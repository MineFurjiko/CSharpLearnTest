using CSharpLearnTest._Class._06_Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearnTest._RunProgram._06_Program_委托与事件 {
	/// <summary>
	/// .net 事件
	/// </summary>
	class Program_06 {

		static void Main06()
		{
			var dealer = new CarDealer();

			var michael = new Consumer("Micheal");
			dealer.NewCarInfo += michael.NewCarIsHere;

			dealer.NewCar("Mercedes");

			var nick = new Consumer("Nick");
			dealer.NewCarInfo += nick.NewCarIsHere;

			dealer.NewCar("Ferrari");

			dealer.NewCarInfo -= michael.NewCarIsHere;

			dealer.NewCar("Toyota");
		}
	}
}
