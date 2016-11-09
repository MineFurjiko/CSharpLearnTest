using CSharpLearnTest._Class._04_Class;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearnTest._RunProgram._04_Program_枚举 {
	class Program_02 {
		static void Main01(string[] args) {
			using (var game = new TicTacToeGame()) {
				IEnumerator enumerator = game.Start(TicTacToeGame.StartStage.Cross);
				while (enumerator.MoveNext()) {
					enumerator = enumerator.Current as IEnumerator;
				}
			}
		}
	}
}
