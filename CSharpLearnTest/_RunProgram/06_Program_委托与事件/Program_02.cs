using CSharpLearnTest._Class._06_Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearnTest._RunProgram._06_Program_委托与事件 {
	/// <summary>
	/// 观察者模式
	/// </summary>
	class Program_02 {
		static void Main02(string[] args) {
			Heater heater = new Heater();
			Alarm alarm = new Alarm();

			heater.BoilEvent += alarm.MakeAlert;
			heater.BoilEvent += Display.ShowMsg;
			
			heater.BoilWater();
		}
	}
}
