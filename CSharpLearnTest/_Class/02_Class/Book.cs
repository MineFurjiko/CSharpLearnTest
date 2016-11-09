using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearnTest._Class._02_Class {
	class Book:IComparable {
		private int id;
		private string title;

		public Book() { }
		public Book(int id, string title) {
			this.id = id;
			this.title = title;
		}

		public int Id {
			get { return this.id; }
		}

		public string Title { 
			get { return this.title; }
			set { this.title = value; }
		}


		public int CompareTo(object obj) {
			Book other = obj as Book;
			return this.id.CompareTo(other.id);
		}

		public static bool CompareSalary(Book b1, Book b2) {
			return b1.id < b2.id;
		}
	}
}