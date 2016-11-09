using CSharpLearnTest._Interface._02_Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearnTest._Class._02_Class {
	class SortHelper : ISelectionSort, IStraightInsertionSort<Book> {

		/// <summary>
		/// Bubble Sort
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="array">Sort Array</param>
		public void BubbleSort<T>(T[] array) where T : IComparable {
			int length = array.Length;

			for (int i = 0; i <= length - 2; i++) {
				for (int j = length - 1; j >= 1; j--) {

					// 对两个元素进行交换
					if (array[j].CompareTo(array[j - 1]) < 0) {
						T temp = array[j];
						array[j] = array[j - 1];
						array[j - 1] = temp;
					}
				}
			}
		}

		/// <summary>
		/// Selection Sort
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="array">Sort Array</param>
		public void SelectionSort<T>(T[] array) where T : IComparable {
			T temp;
			int pos = 0;
			for (int i = 0; i < array.Length - 1; i++) {
				pos = i;
				for (int j = i + 1; j < array.Length; j++) {
					if (array[j].CompareTo(array[pos]) < 0) {
						pos = j;
					}
				}
				temp = array[i];
				array[i] = array[pos];
				array[pos] = temp;
			}
		}

		/// <summary>
		/// Straight Insertion Sort
		/// </summary>
		/// <param name="array"></param>
		public void StraightInsertionSort(Book[] array) {
			int i, j;
			int n = array.Length;
			Book target;

			for (i = 1; i < n; i++) {
				j = i;
				target = array[i];

				while (j > 0 && target.CompareTo(array[j - 1]) < 0) {
					array[j] = array[j - 1];
					j--;
				}

				array[j] = target;
			}
		}

	}
}
