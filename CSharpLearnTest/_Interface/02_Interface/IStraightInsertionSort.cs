using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearnTest._Interface._02_Interface {
	/// <summary>
	/// 泛型接口
	/// </summary>
	/// <typeparam name="T"></typeparam>
	interface IStraightInsertionSort<T> where T:IComparable {
		void StraightInsertionSort(T[] array);
	}
}
