using CSharpLearnTest._Class._02_Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearnTest._Class._06_Class {
	static class SortHelperExtension02 {
		public static void Sort<T>(this SortHelper sortHelper, IList<T> array, Func<T, T, bool> comparison) {
			bool swapped = true;
			do {
				swapped = false;
				for (int i = 0; i < array.Count-1; i++) {
					if (comparison(array[i+1],array[i])) {
						T temp = array[i];
						array[i] = array[i + 1];
						array[i + 1] = temp;
						swapped = true;
					}
				}
			} while (swapped);
		}
	}
}
