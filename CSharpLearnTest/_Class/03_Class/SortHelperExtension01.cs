using CSharpLearnTest._Class._02_Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearnTest._Class._03_Class {
	static class SortHelperExtension01 {
		public static void DichotomySort<T>(this SortHelper sortHelper, T[] array) where T : IComparable {

			for (int i = 0; i < array.Length; i++) {
				int start, end, mid;
				start = 0;
				end = i - 1;
				mid = 0;
				T temp = array[i];
				while (start <= end) {
					mid = (start + end) / 2;
					if (array[mid].CompareTo(temp) > 0)//要排序元素在已经排过序的数组左边
                    {
						end = mid - 1;
					}
					else {
						start = mid + 1;
					}
				}
				for (int j = i - 1; j > end; j--)//找到了要插入的位置，然后将这个位置以后的所有元素向后移动

                {
					array[j + 1] = array[j];
				}
				array[end + 1] = temp;


			}
		}
	}
}
