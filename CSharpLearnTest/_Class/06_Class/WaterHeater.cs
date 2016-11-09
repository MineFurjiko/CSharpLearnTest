using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSharpLearnTest._Class._06_Class {
	/// <summary>
	/// 加热器
	/// </summary>
	public class Heater {
		//温度
		private int temperature;

		public delegate void BoilHandler(int param);	//声明委托
		public event BoilHandler BoilEvent;	//声明事件

		//烧水
		public void BoilWater() {
			for (int i = 0; i <= 100; i++) {
				temperature = i;

				if (temperature > 90) {
					if (BoilEvent != null) {
						BoilEvent(temperature);
					}
					Thread.Sleep(50);
				}
			}
		}
	}

	//报警器
	class Alarm {
		public void MakeAlert(int param) {
			Console.WriteLine("Alarm：嘀嘀嘀，水已经 {0} 度了：", param);
		}
	}

	//显示器
	class Display {
		public static void ShowMsg(int param) { //静态方法
			Console.WriteLine("Display：水快烧开了，当前温度：{0}度。", param);
		}
	}
}
