using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CSharpLearnTest._Class._06_Class {
	/// <summary>
	/// 客户
	/// </summary>
	class Consumer:INewCarInfo,IWeakEventListener {
		private string name;

		public string Name {
			get { return name; }
			set { name = value; }
		}

		public Consumer(string name) {
			this.name = name;
		}

		public void NewCarIsHere(object sender, CarInfoEventArgs e) {
			Console.WriteLine("{0}: car {1} is new", name, e.Car);
		}

		public bool ReceiveWeakEvent(Type managerType, object sender, EventArgs e) {
			NewCarIsHere(sender, e as CarInfoEventArgs);
			return true;
		}
	}
}
