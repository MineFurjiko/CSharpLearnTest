using CSharpLearnTest._Class._02_Class;
using CSharpLearnTest._Class._03_Class;
using CSharpLearnTest._Interface._03_Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearnTest._RunProgram._03_Program_拓展方法 {
	class Program_01 {
		static void Main01(string[] args) {

			SortHelper sortHelper = new SortHelper();

			Book[] bookArray = new Book[2];

			bookArray[0] = new Book(124, "C# 3.0揭秘");
			bookArray[1] = new Book(45, ".Net之美");

			Console.WriteLine("Before Sort");
			foreach (var item in bookArray) {
				Console.WriteLine(item.Id + "  " + item.Title);
			}

			sortHelper.DichotomySort(bookArray);	//拓展方法

			Console.WriteLine("After Sort");
			foreach (var item in bookArray) {
				Console.WriteLine(item.Id + "  " + item.Title);
			}

			Console.WriteLine("------------------------");

			IExtTest iec2=new InterfaceExtTestClass();
			iec2.Test02();

			/*
			 *假如我们实现 IExtTest 接口的类很多
			 *而这些类没有派生关系
			 *这时候我们要在接口上新增一个函数
			 *按照以前的做法实现这个接口的类有多少
			 *我们就需要在多少个类中实现该新函数
			 *使用了扩展方法后
			 *我们只需一次拓展该方法。
			 *假如实现这个接口的类被封装在不同的组件中
			 *一些组件由于其他原因难以修改
			 *这时候用扩展方法来扩展接口就是最佳做法； 
			 */

		}
	}
}
