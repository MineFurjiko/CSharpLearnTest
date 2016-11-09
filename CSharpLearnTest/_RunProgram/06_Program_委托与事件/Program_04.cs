using CSharpLearnTest._Class._02_Class;
using CSharpLearnTest._Class._06_Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearnTest._RunProgram._06_Program_委托与事件 {
	/// <summary>
	/// 综合应用 泛型、拓展方法、委托
	/// </summary>
	class Program_04 {
		static void Main04(string[] args) {
			SortHelper sortHelper = new SortHelper();

			Book[] bookArray = new Book[2];

			bookArray[0] = new Book(124, "C# 3.0揭秘");
			bookArray[1] = new Book(45, ".Net之美");

			Console.WriteLine("Before Sort");
			foreach (var item in bookArray) {
				Console.WriteLine(item.Id + "  " + item.Title);
			}

			//To do Sort
			sortHelper.Sort(bookArray, Book.CompareSalary);

			Console.WriteLine("After Sort");
			foreach (var item in bookArray) {
				Console.WriteLine(item.Id + "  " + item.Title);
			}

		}
	}
}
