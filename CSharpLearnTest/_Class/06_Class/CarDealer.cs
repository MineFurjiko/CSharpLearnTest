using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearnTest._Class._06_Class {
	/// <summary>
	/// 定义所关注的主题信息
	/// </summary>
	public class CarInfoEventArgs : EventArgs {
		public CarInfoEventArgs(string car) {
			this.Car = car;
		}
		public string Car { get; private set; }
	}

	/// <summary>
	/// 定义关注行为接口
	/// </summary>
	public interface INewCarInfo {
		void NewCarIsHere(object sender, CarInfoEventArgs e);
	}

	/// <summary>
	/// 汽车经销商
	/// </summary>
	class CarDealer {
		/// <summary>
		/// EventHandler 
		/// delegate void EventHandler<TEventArgs>(object sender,TEventArgs e)where TEventArgs:EventArgs
		/// </summary>
		public event EventHandler<CarInfoEventArgs> NewCarInfo;


		public void NewCar(string car) {
			Console.WriteLine("CarDealer: new car {0}",car);
			if (NewCarInfo!=null) {
				NewCarInfo(this, new CarInfoEventArgs(car));
			}
		}
	}
}
