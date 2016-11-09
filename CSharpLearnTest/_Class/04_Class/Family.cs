using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearnTest._Class._04_Class {
	class Family {
		private Person[] persons;

		public Family() {
			persons = new Person[3];
			persons[0] = new Person("Day");
			persons[1] = new Person("Mon");
			persons[2] = new Person("Son");

		}

		public IEnumerator<Person> GetEnumerator() {
			for (int i = 0; i < persons.Length; i++) {
				yield return persons[i];
			}
			
		}

		public IEnumerable<Person> Reverse() {
			for (int i = persons.Length-1; i >= 0; i--) {
				yield return persons[i];
			}
		}

		public IEnumerable<Person> Subset(int start,int count) {
			for (int i = start; i <Math.Min(start+count,persons.Length); i++) {
				yield return persons[i];
			}
		}
	}
}