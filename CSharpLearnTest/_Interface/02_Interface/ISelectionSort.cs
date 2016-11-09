using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearnTest._Interface._02_Interface {
	interface ISelectionSort {
		/// <summary>
		/// 接口泛型方法
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="array"></param>
		void SelectionSort<T>(T[] array) where T:IComparable;

	}
}