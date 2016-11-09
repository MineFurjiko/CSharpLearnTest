using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearnTest._Class._04_Class {

	class TicTacToeGame:IDisposable {
		public enum StartStage
		{
	         Cross,
			Circle
		}

		private IEnumerator cross;
		private IEnumerator circle;

		public TicTacToeGame() {
			cross = Cross();
			circle = Circle();
		}

		private IEnumerator Circle() {
			while (true) {
				Console.WriteLine("Circle, move{0}", move);
				if (++move >= MAXMOVES)
					yield break;
				yield return cross;
			}
		}

		private IEnumerator Cross() {
			while (true) {
				Console.WriteLine("Cross, move{0}", move);
				if (++move >= MAXMOVES)
					yield break;
				yield return circle;
			}
		}

		public IEnumerator Start(StartStage s) {
			switch (s) {
				case StartStage.Circle:
					return circle;
				default:
					return cross;
			}
		}

		private int move = 0;
		const int MAXMOVES = 9;


		public void Dispose() {
			Console.WriteLine("Clean");
		}
	}
}