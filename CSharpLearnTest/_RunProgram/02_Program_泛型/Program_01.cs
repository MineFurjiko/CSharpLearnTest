using CSharpLearnTest._Class._02_Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearnTest._RunProgram._02_Program_泛型 {
	class Program_01 {
		static void Main01(string[] args)
        {
			SortHelper sortHelper = new SortHelper();

			Book[] bookArray = new Book[2];

			bookArray[0] = new Book(124, "C# 3.0揭秘");
			bookArray[1] = new Book(45, ".Net之美");

			Console.WriteLine("Before Sort");
			foreach (var item in bookArray) {
				Console.WriteLine(item.Id+"  "+item.Title);
			}

			//sortHelper.BubbleSort<Book>(bookArray);
			//sortHelper.BubbleSort(bookArray);

			//sortHelper.SelectionSort(bookArray);
			sortHelper.StraightInsertionSort(bookArray);

			Console.WriteLine("After Sort");
			foreach (var item in bookArray) {
				Console.WriteLine(item.Id + "  " + item.Title);
			}
        }
	}
}