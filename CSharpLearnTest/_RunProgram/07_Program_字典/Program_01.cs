using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpLearnTest._Class._07_Class;

namespace CSharpLearnTest._RunProgram._07_Program_字典 {
	class Program_01 {
		static void Main() {
			var employees = new Dictionary<EmployeeId, Employee>(31);

			var idKyle=new EmployeeId("T3755");
			var kyle = new Employee(idKyle,"Kyle Bush",5443890.00m);
			employees.Add(idKyle,kyle);
			Console.WriteLine(kyle);

			var idCarl = new EmployeeId("F3547");
			var carl = new Employee(idCarl, "carl Edwards", 5597120.00m);
			employees.Add(idCarl, carl);
			Console.WriteLine(carl);


			var idDale = new EmployeeId("C3323");
			var dale = new Employee(idDale, "Dale Earnhardt", 3522740.00m);
			employees[idDale] = dale;
			Console.WriteLine(dale);

			while (true) {
				Console.WriteLine("Enter employee id (x to exit)");
				var userInput = Console.ReadLine();
				userInput = userInput.ToUpper();
				if (userInput == "X") break;

				EmployeeId id;
				try {
					id = new EmployeeId(userInput);

					Employee employee;
					if (!employees.TryGetValue(id,out employee)) {
						Console.WriteLine("Employee with id {0} does not exist",id);
					}
					else {
						Console.WriteLine(employee);
					}
				}
				catch (EmployeeIdException ex) {
					Console.WriteLine(ex.Message);
				}
			}
		}
	}
}
